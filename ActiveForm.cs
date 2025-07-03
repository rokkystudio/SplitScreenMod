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
    public partial class ActiveForm : Form
    {
        public ActiveForm() {
            InitializeComponent();
        }

        private void GoogleButton_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://play.google.com/store/apps/details?id=com.rokkystudio.splitscreenmod");
        }

        private void UnlockKeyText_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void UnlockKeyText_TextChanged(object sender, EventArgs e) {
            UnlockButton.Enabled = UnlockKeyText.Text.Length == UnlockKeyText.MaxLength;
        }

        private void UnlockButton_Click(object sender, EventArgs e) {
            UnlockButton.Enabled = false;
            UnlockKeyText.Enabled = false;
            System.Threading.Thread.Sleep(3000);
        }

        private void ActiveForm_Load(object sender, EventArgs e) {
            String id = Protect.GetAppID();
            AppID1.Text = id[0].ToString();
            AppID2.Text = id[1].ToString();
            AppID3.Text = id[2].ToString();
            AppID4.Text = id[3].ToString();
        }
    }
}
