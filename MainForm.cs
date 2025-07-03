using System;
using System.Management;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Threading;
using SplitScreenMod.Properties;
using System.Drawing.Imaging;
using System.Security.AccessControl;

namespace SplitScreenMod
{
    public enum ScreensConfiguration {
        Single, Extended, DuplicateOrShowOnlyOne
    }

    public partial class MainForm : Form
    {
        private BorderForm mBorderForm = new BorderForm();
        private IntPtr mActiveWindow = IntPtr.Zero;
        private int mAppPID = Process.GetCurrentProcess().Id;

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            WindowIcon.Image = Icon.ToBitmap();
        }

        private void TimerFindWindow_Tick(object sender, EventArgs e)
        {
            IntPtr handle = WIN32.GetForegroundWindow();
            if (handle == IntPtr.Zero) return;

            int pid = WIN32.GetProcessID(handle);
            if (pid == 0) return;

            // Игнорируем собственное приложение
            if (mAppPID == pid) return;

            // Игнорируем некоторый список приложений
            if (IsIgnoredApp(pid)) return;

            mBorderForm.Show(handle);

            // Игнорируем повторное нахождение окна
            if (handle == mActiveWindow) return;

            TextProcessID.Text = pid.ToString();
            TextWindowID.Text = PointerToHex(handle) + " (" + handle.ToString() + ")";
            TextWindowTitle.Text = WIN32.GetWindowTitle(handle);
            ToolTip.SetToolTip(TextWindowTitle, TextWindowTitle.Text);
            TextProcessFilename.Text = WIN32.GetProcessFilename(pid);
            ToolTip.SetToolTip(TextProcessFilename, TextProcessFilename.Text);
            WindowIcon.Image = WIN32.GetProcessIcon(handle);

            mActiveWindow = handle;
        }

        private bool IsIgnoredApp(int pid)
        {
            String filename = WIN32.GetProcessFilename(pid);
            
            // Игнорируем окна у которых не удалось получить имя файла
            if (filename.Length == 0) return true;
            
            if (filename.IndexOf("explorer.exe", StringComparison.OrdinalIgnoreCase) >= 0) return true;
            if (filename.IndexOf("taskmgr.exe", StringComparison.OrdinalIgnoreCase) >= 0) return true;

            return false;
        }

        private void AddWindowToList(IntPtr handle)
        {
            if (handle == IntPtr.Zero) return;
            if (handle == Handle) return;

            String windowID = handle.ToString();
            if (TreeView.Nodes.ContainsKey(windowID)) return;

            String title = PointerToHex(handle) + " : " + WIN32.GetWindowTitle(handle);
            Image icon = WIN32.GetProcessIcon(handle);

            int imageId = ImageList.Images.Add(icon, Color.White);
            TreeView.Nodes.Add(windowID, title, imageId, imageId);

            AddWindowsLabel.Hide();
        }

        private void ClearFormData() {
            TextProcessID.Text = "0";
            TextWindowID.Text = "0";
            TextWindowTitle.Text = "";
            TextProcessFilename.Text = "";
            WindowIcon.Image = Icon.ToBitmap();
            WindowCapture.Image = null;
        }

        private void ClearWindowsList() {
            TreeView.Nodes.Clear();
            ImageList.Images.Clear();
            AddWindowsLabel.Show();
        }

        private void ButtonAddWindow_Click(object sender, EventArgs e) {
            AddWindowToList(mActiveWindow);
        }

        private void TimerCapture_Tick(object sender, EventArgs e)
        {
            // После запуска программы активное окно равно нулю
            if (mActiveWindow == IntPtr.Zero) return;

            // Если окно было закрыто, то обнуляем форму
            if (!WIN32.IsWindow(mActiveWindow)) {
                mActiveWindow = IntPtr.Zero;
                ClearFormData();
                return;
            }

            WindowCapture.Image = WIN32.GetWindowCapture(mActiveWindow);
        }

        private void FindGameButton_Click(object sender, EventArgs e) {
            Point point = new Point(0, FindGameButton.Height);
            MenuFindGame.Show(FindGameButton, point);
        }

        private void ClearWindowsButton_Click(object sender, EventArgs e) {
            ClearWindowsList();
        }

        private void TimerCheckWindows_Tick(object sender, EventArgs e)
        {
            foreach (TreeNode node in TreeView.Nodes) {
                if (node == null) continue;
                IntPtr handle = StringToIntPtr(node.Name);
                if (!WIN32.IsWindow(handle)) TreeView.Nodes.Remove(node);
            }
        }

        private void RemoveWindowButton_Click(object sender, EventArgs e)
        {
            if (TreeView.SelectedNode != null) {
                TreeView.Nodes.Remove(TreeView.SelectedNode);
            }

            if (TreeView.Nodes.Count == 0) {
                AddWindowsLabel.Show();
            }

            mBorderForm.Hide();
        }

        private void MainForm_MouseLeave(object sender, EventArgs e) {
            mBorderForm.Hide();
        }

        private String PointerToHex(IntPtr pointer) {
            return "0x" + pointer.ToString("x8").ToUpper();
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e) {
            WIN32.SetForegroundWindow(StringToIntPtr(TreeView.SelectedNode.Name));
        }

        private void MainForm_Resize(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Minimized) Hide();
        }

        private void MenuItemShow_Click(object sender, EventArgs e) {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void MenuItemExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e) {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void MenuItemMinecraft_Click(object sender, EventArgs e)
        {
            ClearWindowsList();

            List<IntPtr> windows = WIN32.FindWindows();
            foreach (IntPtr handle in windows)
            {
                String title = WIN32.GetWindowTitle(handle);
                if (title == null) continue;
                // Ignore Steam Overlay
                if (title.IndexOf("GDI+ Window", StringComparison.OrdinalIgnoreCase) >= 0) continue;
                if (title.IndexOf("Minecraft", StringComparison.OrdinalIgnoreCase) < 0) continue;
                int pid = WIN32.GetProcessID(handle);
                String filename = WIN32.GetProcessFilename(pid);
                if (filename.IndexOf("javaw.exe", StringComparison.OrdinalIgnoreCase) < 0) continue;
                AddWindowToList(handle);
            }
        }

        private void MenuItemTerraria_Click(object sender, EventArgs e)
        {
            ClearWindowsList();

            List<IntPtr> windows = WIN32.FindWindows();
            foreach (IntPtr handle in windows)
            {
                String title = WIN32.GetWindowTitle(handle);
                if (title == null) continue;
                // Ignore Steam Overlay
                if (title.IndexOf("GDI+ Window", StringComparison.OrdinalIgnoreCase) >= 0) continue;
                if (title.IndexOf("Terraria", StringComparison.OrdinalIgnoreCase) < 0) continue;
                int pid = WIN32.GetProcessID(handle);
                String filename = WIN32.GetProcessFilename(pid);
                if (filename.IndexOf("terraria", StringComparison.OrdinalIgnoreCase) < 0) continue;
                AddWindowToList(handle);
            }
        }

        private void MenuItemCounterStrike_Click(object sender, EventArgs e)
        {
            ClearWindowsList();

            List<IntPtr> windows = WIN32.FindWindows();
            foreach (IntPtr handle in windows)
            {
                String title = WIN32.GetWindowTitle(handle);
                if (title == null) continue;
                // Ignore Steam Overlay
                if (title.IndexOf("GDI+ Window", StringComparison.OrdinalIgnoreCase) >= 0) continue;
                if (title.IndexOf("Counter-Strike", StringComparison.OrdinalIgnoreCase) < 0) continue;
                int pid = WIN32.GetProcessID(handle);
                String filename = WIN32.GetProcessFilename(pid);
                if (filename.IndexOf("hl.exe", StringComparison.OrdinalIgnoreCase) < 0) continue;
                AddWindowToList(handle);
            }
        }

        private void MenuItemHalfLife_Click(object sender, EventArgs e)
        {
            ClearWindowsList();

            List<IntPtr> windows = WIN32.FindWindows();
            foreach (IntPtr handle in windows)
            {
                String title = WIN32.GetWindowTitle(handle);
                if (title == null) continue;
                // Ignore Steam Overlay
                if (title.IndexOf("GDI+ Window", StringComparison.OrdinalIgnoreCase) >= 0) continue;
                if (title.IndexOf("Half-Life", StringComparison.OrdinalIgnoreCase) < 0) continue;
                int pid = WIN32.GetProcessID(handle);
                String filename = WIN32.GetProcessFilename(pid);
                if (filename.IndexOf("hl.exe", StringComparison.OrdinalIgnoreCase) < 0) continue;
                AddWindowToList(handle);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*
            IntPtr mutex = IntPtr.Zero;

            // Counter-Strike GO
            mutex = KERNEL32.OpenMutex(KERNEL32.MUTEX_ALL_ACCESS, false, "hl2_singleton_mutex");
            if (mutex != IntPtr.Zero) {
                KERNEL32.ReleaseMutex(mutex);
            }

            // Counter-Strike 1.6 / Half-Life
            mutex = KERNEL32.OpenMutex(KERNEL32.MUTEX_ALL_ACCESS, false, "ValveHalfLifeLauncherMutex");
            if (mutex != IntPtr.Zero) {
                Text = KERNEL32.ReleaseMutex(mutex).ToString();
            }
            */

            Mutex m = new Mutex();
            Mutex.OpenExisting("ValveHalfLifeLauncherMutex", MutexRights.Delete);
            m.Close();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            mBorderForm.Hide();

            // Отключаем основной функционал
            TimerFindWin.Enabled = false;
            TimerCapture.Enabled = false;
            ClearFormData();

            // Включаем таймер активатора окон
            TimerActivate.Enabled = true;
            StartButton.Visible = false;
            StopButton.Visible = true;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            // Возвращаем основной функционал
            TimerFindWin.Enabled = true;
            TimerCapture.Enabled = true;

            // Выключаем таймер активатора окон
            TimerActivate.Enabled = false;
            StartButton.Visible = true;
            StopButton.Visible = false;
        }

        private void SplitWindowButton_Click(object sender, EventArgs e)
        {
            SplitForm mSplitForm = new SplitForm();
            mSplitForm.StartPosition = FormStartPosition.Manual;
            mSplitForm.Left = Left + (Width - mSplitForm.Width) / 2;
            mSplitForm.Top = Top + (Height - mSplitForm.Height) / 2;

            List<IntPtr> list = new List<IntPtr>();
            foreach (TreeNode node in TreeView.Nodes) {
                if (node == null) continue;
                list.Add(StringToIntPtr(node.Name));
            }
            mSplitForm.SetWindowsList(list);

            mSplitForm.ShowDialog();
        }

        private IntPtr StringToIntPtr(String text) {
            if (String.IsNullOrEmpty(text)) return IntPtr.Zero;
            return new IntPtr(Convert.ToInt32(text));
        }

        private void TimerActivate_Tick(object sender, EventArgs e)
        {
            foreach (TreeNode node in TreeView.Nodes)
            {
                if (node == null) continue;
                IntPtr handle = StringToIntPtr(node.Name);
                WIN32.SendMessage(handle, WIN32.WM_ACTIVATE, WIN32.WA_CLICKACTIVE, IntPtr.Zero);
                WIN32.SetActiveWindow(handle);
            }
        }
    }
}
