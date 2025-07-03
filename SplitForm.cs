using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitScreenMod
{
    public partial class SplitForm : Form
    {
        private List<IntPtr> mWindowsList = null;

        public SplitForm() {
            InitializeComponent();
        }

        public void SetWindowsList(List<IntPtr> list) {
            mWindowsList = list;
        }

        private void SplitHorizontal(int size)
        {
            int width = SystemInformation.VirtualScreen.Width / size;
            int height = SystemInformation.VirtualScreen.Height;

            int count = 0;
            foreach (IntPtr handle in mWindowsList)
            {
                if (count == size) count = 0;
                int x = count * width;
                WIN32.SetWindowPos(handle, WIN32.HWND_NOTOPMOST, x, 0, width, height, WIN32.SWP_SHOWWINDOW);
                count++;
            }
        }

        private void SplitVertical(int size)
        {
            int width = SystemInformation.VirtualScreen.Width;
            int height = SystemInformation.VirtualScreen.Height / size;

            int count = 0;
            foreach (IntPtr handle in mWindowsList)
            {
                if (count == size) count = 0;
                int y = count * height;
                WIN32.SetWindowPos(handle, WIN32.HWND_NOTOPMOST, 0, y, width, height, WIN32.SWP_SHOWWINDOW);
                count++;
            }
        }

        private void SplitFullButton_Click(object sender, EventArgs e)
        {
            int width = SystemInformation.VirtualScreen.Width;
            int height = SystemInformation.VirtualScreen.Height;

            foreach (IntPtr handle in mWindowsList) {
                WIN32.SetWindowPos(handle, WIN32.HWND_NOTOPMOST, 0, 0, width, height, WIN32.SWP_SHOWWINDOW);
            }
        }

        private void SplitHorizontal2Button_Click(object sender, EventArgs e) {
            SplitHorizontal(2);
        }

        private void SplitHorizontal3Button_Click(object sender, EventArgs e) {
            SplitHorizontal(3);
        }

        private void SplitHorizontal4Button_Click(object sender, EventArgs e) {
            SplitHorizontal(4);
        }

        private void SplitEquivalent4Button_Click(object sender, EventArgs e)
        {
            int width = SystemInformation.VirtualScreen.Width / 2;
            int height = SystemInformation.VirtualScreen.Height / 2;

            int countX = 0; int countY = 0;
            foreach (IntPtr handle in mWindowsList)
            {
                if (countX == 2) { countX = 0; countY++; }
                if (countY == 2) countY = 0;

                int x = countX * width;
                int y = countY * height;
                WIN32.SetWindowPos(handle, WIN32.HWND_NOTOPMOST, x, y, width, height, WIN32.SWP_SHOWWINDOW);
                countX++;
            }
        }

        private void SplitVertical2Button_Click(object sender, EventArgs e) {
            SplitVertical(2);
        }

        private void SplitVertical3Button_Click(object sender, EventArgs e) {
            SplitVertical(3);
        }

        private void SplitVertical4Button_Click(object sender, EventArgs e) {
            SplitVertical(4);
        }

        private void SplitLeft3Button_Click(object sender, EventArgs e)
        {
            int width = SystemInformation.VirtualScreen.Width / 2;
            int height = SystemInformation.VirtualScreen.Height / 2;

            int count = 0;
            foreach (IntPtr handle in mWindowsList)
            {
                if (count == 3) count = 0;

                if (count == 0) {
                    WIN32.SetWindowPos(handle, WIN32.HWND_NOTOPMOST, 0, 0, width, height, WIN32.SWP_SHOWWINDOW);
                }

                if (count == 1) {
                    WIN32.SetWindowPos(handle, WIN32.HWND_NOTOPMOST, width, 0, width, height * 2, WIN32.SWP_SHOWWINDOW);
                }

                if (count == 2) {
                    WIN32.SetWindowPos(handle, WIN32.HWND_NOTOPMOST, 0, height, width, height, WIN32.SWP_SHOWWINDOW);
                }

                count++;
            }
        }

        private void SplitRight3Button_Click(object sender, EventArgs e)
        {
            int width = SystemInformation.VirtualScreen.Width / 2;
            int height = SystemInformation.VirtualScreen.Height / 2;

            int count = 0;
            foreach (IntPtr handle in mWindowsList)
            {
                if (count == 3) count = 0;

                if (count == 0) {
                    WIN32.SetWindowPos(handle, WIN32.HWND_NOTOPMOST, 0, 0, width, height * 2, WIN32.SWP_SHOWWINDOW);
                }

                if (count == 1) {
                    WIN32.SetWindowPos(handle, WIN32.HWND_NOTOPMOST, width, 0, width, height, WIN32.SWP_SHOWWINDOW);
                }

                if (count == 2) {
                    WIN32.SetWindowPos(handle, WIN32.HWND_NOTOPMOST, width, height, width, height, WIN32.SWP_SHOWWINDOW);
                }

                count++;
            }
        }

        private void SplitTop3Button_Click(object sender, EventArgs e)
        {
            int width = SystemInformation.VirtualScreen.Width / 2;
            int height = SystemInformation.VirtualScreen.Height / 2;

            int count = 0;
            foreach (IntPtr handle in mWindowsList)
            {
                if (count == 3) count = 0;

                if (count == 0) {
                    WIN32.SetWindowPos(handle, WIN32.HWND_NOTOPMOST, 0, 0, width, height, WIN32.SWP_SHOWWINDOW);
                }

                if (count == 1) {
                    WIN32.SetWindowPos(handle, WIN32.HWND_NOTOPMOST, width, 0, width, height, WIN32.SWP_SHOWWINDOW);
                }

                if (count == 2) {
                    WIN32.SetWindowPos(handle, WIN32.HWND_NOTOPMOST, 0, height, width * 2, height, WIN32.SWP_SHOWWINDOW);
                }

                count++;
            }
        }

        private void SplitBottom3Button_Click(object sender, EventArgs e)
        {
            int width = SystemInformation.VirtualScreen.Width / 2;
            int height = SystemInformation.VirtualScreen.Height / 2;

            int count = 0;
            foreach (IntPtr handle in mWindowsList)
            {
                if (count == 3) count = 0;

                if (count == 0) {
                    WIN32.SetWindowPos(handle, WIN32.HWND_NOTOPMOST, 0, 0, width * 2, height, WIN32.SWP_SHOWWINDOW);
                }

                if (count == 1) {
                    WIN32.SetWindowPos(handle, WIN32.HWND_NOTOPMOST, 0, height, width, height, WIN32.SWP_SHOWWINDOW);
                }

                if (count == 2) {
                    WIN32.SetWindowPos(handle, WIN32.HWND_NOTOPMOST, width, height, width, height, WIN32.SWP_SHOWWINDOW);
                }

                count++;
            }
        }
    }
}
