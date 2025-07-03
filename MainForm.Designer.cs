
namespace SplitScreenMod
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TimerFindWin = new System.Windows.Forms.Timer(this.components);
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemShow = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.WindowIcon = new System.Windows.Forms.PictureBox();
            this.WindowCapture = new System.Windows.Forms.PictureBox();
            this.TextProcessFilename = new System.Windows.Forms.Label();
            this.TextWindowTitle = new System.Windows.Forms.Label();
            this.TextWindowID = new System.Windows.Forms.Label();
            this.TextProcessID = new System.Windows.Forms.Label();
            this.LabelProcessFilename = new System.Windows.Forms.Label();
            this.LabelProcessID = new System.Windows.Forms.Label();
            this.LabelWindowTitle = new System.Windows.Forms.Label();
            this.LabelWindowID = new System.Windows.Forms.Label();
            this.TimerCapture = new System.Windows.Forms.Timer(this.components);
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MenuFindGame = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemMinecraft = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTerraria = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCounterStrike = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHalfLife = new System.Windows.Forms.ToolStripMenuItem();
            this.TimerCheckWindows = new System.Windows.Forms.Timer(this.components);
            this.AddWindowsLabel = new System.Windows.Forms.Label();
            this.TreeView = new System.Windows.Forms.TreeView();
            this.TimerActivate = new System.Windows.Forms.Timer(this.components);
            this.StartButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.RemoveWindowButton = new System.Windows.Forms.Button();
            this.ButtonAddWindow = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.SplitWindowButton = new SplitScreenMod.SplitButton();
            this.FindGameButton = new SplitScreenMod.SplitButton();
            this.MenuNotify.SuspendLayout();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WindowIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowCapture)).BeginInit();
            this.MenuFindGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerFindWin
            // 
            this.TimerFindWin.Enabled = true;
            this.TimerFindWin.Interval = 250;
            this.TimerFindWin.Tick += new System.EventHandler(this.TimerFindWindow_Tick);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.ContextMenuStrip = this.MenuNotify;
            resources.ApplyResources(this.NotifyIcon, "NotifyIcon");
            this.NotifyIcon.DoubleClick += new System.EventHandler(this.NotifyIcon_DoubleClick);
            // 
            // MenuNotify
            // 
            this.MenuNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemShow,
            this.MenuItemExit});
            this.MenuNotify.Name = "MenuNotify";
            resources.ApplyResources(this.MenuNotify, "MenuNotify");
            // 
            // MenuItemShow
            // 
            this.MenuItemShow.Name = "MenuItemShow";
            resources.ApplyResources(this.MenuItemShow, "MenuItemShow");
            this.MenuItemShow.Click += new System.EventHandler(this.MenuItemShow_Click);
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Name = "MenuItemExit";
            resources.ApplyResources(this.MenuItemExit, "MenuItemExit");
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // ImageList
            // 
            this.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.ImageList, "ImageList");
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.WindowIcon);
            this.GroupBox.Controls.Add(this.WindowCapture);
            this.GroupBox.Controls.Add(this.TextProcessFilename);
            this.GroupBox.Controls.Add(this.TextWindowTitle);
            this.GroupBox.Controls.Add(this.TextWindowID);
            this.GroupBox.Controls.Add(this.TextProcessID);
            this.GroupBox.Controls.Add(this.LabelProcessFilename);
            this.GroupBox.Controls.Add(this.LabelProcessID);
            this.GroupBox.Controls.Add(this.LabelWindowTitle);
            this.GroupBox.Controls.Add(this.LabelWindowID);
            resources.ApplyResources(this.GroupBox, "GroupBox");
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.TabStop = false;
            // 
            // WindowIcon
            // 
            this.WindowIcon.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.WindowIcon, "WindowIcon");
            this.WindowIcon.Name = "WindowIcon";
            this.WindowIcon.TabStop = false;
            // 
            // WindowCapture
            // 
            this.WindowCapture.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.WindowCapture, "WindowCapture");
            this.WindowCapture.Name = "WindowCapture";
            this.WindowCapture.TabStop = false;
            // 
            // TextProcessFilename
            // 
            this.TextProcessFilename.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            resources.ApplyResources(this.TextProcessFilename, "TextProcessFilename");
            this.TextProcessFilename.Name = "TextProcessFilename";
            // 
            // TextWindowTitle
            // 
            resources.ApplyResources(this.TextWindowTitle, "TextWindowTitle");
            this.TextWindowTitle.Name = "TextWindowTitle";
            // 
            // TextWindowID
            // 
            resources.ApplyResources(this.TextWindowID, "TextWindowID");
            this.TextWindowID.Name = "TextWindowID";
            // 
            // TextProcessID
            // 
            resources.ApplyResources(this.TextProcessID, "TextProcessID");
            this.TextProcessID.Name = "TextProcessID";
            // 
            // LabelProcessFilename
            // 
            resources.ApplyResources(this.LabelProcessFilename, "LabelProcessFilename");
            this.LabelProcessFilename.Name = "LabelProcessFilename";
            // 
            // LabelProcessID
            // 
            resources.ApplyResources(this.LabelProcessID, "LabelProcessID");
            this.LabelProcessID.Name = "LabelProcessID";
            // 
            // LabelWindowTitle
            // 
            resources.ApplyResources(this.LabelWindowTitle, "LabelWindowTitle");
            this.LabelWindowTitle.Name = "LabelWindowTitle";
            // 
            // LabelWindowID
            // 
            resources.ApplyResources(this.LabelWindowID, "LabelWindowID");
            this.LabelWindowID.Name = "LabelWindowID";
            // 
            // TimerCapture
            // 
            this.TimerCapture.Enabled = true;
            this.TimerCapture.Interval = 2000;
            this.TimerCapture.Tick += new System.EventHandler(this.TimerCapture_Tick);
            // 
            // MenuFindGame
            // 
            this.MenuFindGame.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemMinecraft,
            this.MenuItemTerraria,
            this.MenuItemCounterStrike,
            this.MenuItemHalfLife});
            this.MenuFindGame.Name = "MenuFindGame";
            resources.ApplyResources(this.MenuFindGame, "MenuFindGame");
            // 
            // MenuItemMinecraft
            // 
            this.MenuItemMinecraft.Image = global::SplitScreenMod.Properties.Resources.MinecraftIcon;
            this.MenuItemMinecraft.Name = "MenuItemMinecraft";
            resources.ApplyResources(this.MenuItemMinecraft, "MenuItemMinecraft");
            this.MenuItemMinecraft.Click += new System.EventHandler(this.MenuItemMinecraft_Click);
            // 
            // MenuItemTerraria
            // 
            this.MenuItemTerraria.Image = global::SplitScreenMod.Properties.Resources.TerrariaIcon;
            this.MenuItemTerraria.Name = "MenuItemTerraria";
            resources.ApplyResources(this.MenuItemTerraria, "MenuItemTerraria");
            this.MenuItemTerraria.Click += new System.EventHandler(this.MenuItemTerraria_Click);
            // 
            // MenuItemCounterStrike
            // 
            this.MenuItemCounterStrike.Image = global::SplitScreenMod.Properties.Resources.CounterStrikeIcon;
            this.MenuItemCounterStrike.Name = "MenuItemCounterStrike";
            resources.ApplyResources(this.MenuItemCounterStrike, "MenuItemCounterStrike");
            this.MenuItemCounterStrike.Click += new System.EventHandler(this.MenuItemCounterStrike_Click);
            // 
            // MenuItemHalfLife
            // 
            resources.ApplyResources(this.MenuItemHalfLife, "MenuItemHalfLife");
            this.MenuItemHalfLife.Name = "MenuItemHalfLife";
            this.MenuItemHalfLife.Click += new System.EventHandler(this.MenuItemHalfLife_Click);
            // 
            // TimerCheckWindows
            // 
            this.TimerCheckWindows.Enabled = true;
            this.TimerCheckWindows.Interval = 2000;
            this.TimerCheckWindows.Tick += new System.EventHandler(this.TimerCheckWindows_Tick);
            // 
            // AddWindowsLabel
            // 
            this.AddWindowsLabel.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.AddWindowsLabel, "AddWindowsLabel");
            this.AddWindowsLabel.Name = "AddWindowsLabel";
            // 
            // TreeView
            // 
            resources.ApplyResources(this.TreeView, "TreeView");
            this.TreeView.ImageList = this.ImageList;
            this.TreeView.Name = "TreeView";
            this.TreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_AfterSelect);
            // 
            // TimerActivate
            // 
            this.TimerActivate.Interval = 500;
            this.TimerActivate.Tick += new System.EventHandler(this.TimerActivate_Tick);
            // 
            // StartButton
            // 
            resources.ApplyResources(this.StartButton, "StartButton");
            this.StartButton.Image = global::SplitScreenMod.Properties.Resources.StartIcon;
            this.StartButton.Name = "StartButton";
            this.StartButton.Tag = "";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Image = global::SplitScreenMod.Properties.Resources.ClearIcon;
            resources.ApplyResources(this.ClearButton, "ClearButton");
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearWindowsButton_Click);
            // 
            // RemoveWindowButton
            // 
            this.RemoveWindowButton.Image = global::SplitScreenMod.Properties.Resources.MinusIcon;
            resources.ApplyResources(this.RemoveWindowButton, "RemoveWindowButton");
            this.RemoveWindowButton.Name = "RemoveWindowButton";
            this.RemoveWindowButton.UseVisualStyleBackColor = true;
            this.RemoveWindowButton.Click += new System.EventHandler(this.RemoveWindowButton_Click);
            // 
            // ButtonAddWindow
            // 
            this.ButtonAddWindow.Image = global::SplitScreenMod.Properties.Resources.PlusIcon;
            resources.ApplyResources(this.ButtonAddWindow, "ButtonAddWindow");
            this.ButtonAddWindow.Name = "ButtonAddWindow";
            this.ButtonAddWindow.UseVisualStyleBackColor = true;
            this.ButtonAddWindow.Click += new System.EventHandler(this.ButtonAddWindow_Click);
            // 
            // StopButton
            // 
            resources.ApplyResources(this.StopButton, "StopButton");
            this.StopButton.Image = global::SplitScreenMod.Properties.Resources.StopIcon;
            this.StopButton.Name = "StopButton";
            this.StopButton.Tag = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // SplitWindowButton
            // 
            resources.ApplyResources(this.SplitWindowButton, "SplitWindowButton");
            this.SplitWindowButton.Image = global::SplitScreenMod.Properties.Resources.SplitIcon;
            this.SplitWindowButton.Name = "SplitWindowButton";
            this.SplitWindowButton.UseVisualStyleBackColor = true;
            this.SplitWindowButton.Click += new System.EventHandler(this.SplitWindowButton_Click);
            // 
            // FindGameButton
            // 
            resources.ApplyResources(this.FindGameButton, "FindGameButton");
            this.FindGameButton.ContextMenuStrip = this.MenuFindGame;
            this.FindGameButton.Image = global::SplitScreenMod.Properties.Resources.JoystickIcon;
            this.FindGameButton.Name = "FindGameButton";
            this.FindGameButton.SplitMenuStrip = this.MenuFindGame;
            this.FindGameButton.UseVisualStyleBackColor = true;
            this.FindGameButton.Click += new System.EventHandler(this.FindGameButton_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SplitWindowButton);
            this.Controls.Add(this.FindGameButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.AddWindowsLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.RemoveWindowButton);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.ButtonAddWindow);
            this.Controls.Add(this.TreeView);
            this.Controls.Add(this.StopButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.MenuNotify.ResumeLayout(false);
            this.GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WindowIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowCapture)).EndInit();
            this.MenuFindGame.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddWindow;
        private System.Windows.Forms.Timer TimerFindWin;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.PictureBox WindowIcon;
        private System.Windows.Forms.Label LabelWindowTitle;
        private System.Windows.Forms.Label LabelWindowID;
        private System.Windows.Forms.PictureBox WindowCapture;
        private System.Windows.Forms.Timer TimerCapture;
        private System.Windows.Forms.Label LabelProcessFilename;
        private System.Windows.Forms.Label LabelProcessID;
        private System.Windows.Forms.Label TextProcessFilename;
        private System.Windows.Forms.Label TextWindowTitle;
        private System.Windows.Forms.Label TextWindowID;
        private System.Windows.Forms.Label TextProcessID;
        private System.Windows.Forms.Button RemoveWindowButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.ContextMenuStrip MenuFindGame;
        private System.Windows.Forms.ToolStripMenuItem MenuItemMinecraft;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTerraria;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCounterStrike;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHalfLife;
        private System.Windows.Forms.Timer TimerCheckWindows;
        private System.Windows.Forms.Label AddWindowsLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TreeView TreeView;
        private SplitButton FindGameButton;
        private System.Windows.Forms.ContextMenuStrip MenuNotify;
        private System.Windows.Forms.ToolStripMenuItem MenuItemShow;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private SplitButton SplitWindowButton;
        private System.Windows.Forms.Timer TimerActivate;
        private System.Windows.Forms.Button StopButton;
    }
}

