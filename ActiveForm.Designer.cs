
namespace SplitScreenMod
{
    partial class ActiveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActiveForm));
            this.InfoText = new System.Windows.Forms.RichTextBox();
            this.AppID1 = new System.Windows.Forms.Label();
            this.UnlockKeyText = new System.Windows.Forms.TextBox();
            this.AppID2 = new System.Windows.Forms.Label();
            this.AppID3 = new System.Windows.Forms.Label();
            this.AppID4 = new System.Windows.Forms.Label();
            this.UnlockKeyLabel = new System.Windows.Forms.Label();
            this.AppIDLabel = new System.Windows.Forms.Label();
            this.UnlockButton = new System.Windows.Forms.Button();
            this.GoogleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoText
            // 
            this.InfoText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.InfoText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.InfoText, "InfoText");
            this.InfoText.Name = "InfoText";
            this.InfoText.TabStop = false;
            // 
            // AppID1
            // 
            this.AppID1.BackColor = System.Drawing.Color.White;
            this.AppID1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.AppID1, "AppID1");
            this.AppID1.Name = "AppID1";
            // 
            // UnlockKeyText
            // 
            this.UnlockKeyText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.UnlockKeyText, "UnlockKeyText");
            this.UnlockKeyText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UnlockKeyText.Name = "UnlockKeyText";
            this.UnlockKeyText.ShortcutsEnabled = false;
            this.UnlockKeyText.TextChanged += new System.EventHandler(this.UnlockKeyText_TextChanged);
            this.UnlockKeyText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UnlockKeyText_KeyPress);
            // 
            // AppID2
            // 
            this.AppID2.BackColor = System.Drawing.Color.White;
            this.AppID2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.AppID2, "AppID2");
            this.AppID2.Name = "AppID2";
            // 
            // AppID3
            // 
            this.AppID3.BackColor = System.Drawing.Color.White;
            this.AppID3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.AppID3, "AppID3");
            this.AppID3.Name = "AppID3";
            // 
            // AppID4
            // 
            this.AppID4.BackColor = System.Drawing.Color.White;
            this.AppID4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.AppID4, "AppID4");
            this.AppID4.Name = "AppID4";
            // 
            // UnlockKeyLabel
            // 
            resources.ApplyResources(this.UnlockKeyLabel, "UnlockKeyLabel");
            this.UnlockKeyLabel.Name = "UnlockKeyLabel";
            // 
            // AppIDLabel
            // 
            resources.ApplyResources(this.AppIDLabel, "AppIDLabel");
            this.AppIDLabel.Name = "AppIDLabel";
            // 
            // UnlockButton
            // 
            this.UnlockButton.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.UnlockButton, "UnlockButton");
            this.UnlockButton.Name = "UnlockButton";
            this.UnlockButton.UseVisualStyleBackColor = false;
            this.UnlockButton.Click += new System.EventHandler(this.UnlockButton_Click);
            // 
            // GoogleButton
            // 
            this.GoogleButton.BackColor = System.Drawing.Color.White;
            this.GoogleButton.Image = global::SplitScreenMod.Properties.Resources.GooglePlay;
            resources.ApplyResources(this.GoogleButton, "GoogleButton");
            this.GoogleButton.Name = "GoogleButton";
            this.GoogleButton.UseVisualStyleBackColor = false;
            this.GoogleButton.Click += new System.EventHandler(this.GoogleButton_Click);
            // 
            // ActiveForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.UnlockButton);
            this.Controls.Add(this.AppIDLabel);
            this.Controls.Add(this.UnlockKeyLabel);
            this.Controls.Add(this.AppID4);
            this.Controls.Add(this.AppID3);
            this.Controls.Add(this.AppID2);
            this.Controls.Add(this.UnlockKeyText);
            this.Controls.Add(this.AppID1);
            this.Controls.Add(this.InfoText);
            this.Controls.Add(this.GoogleButton);
            this.Name = "ActiveForm";
            this.Load += new System.EventHandler(this.ActiveForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoogleButton;
        private System.Windows.Forms.RichTextBox InfoText;
        private System.Windows.Forms.Label AppID1;
        private System.Windows.Forms.TextBox UnlockKeyText;
        private System.Windows.Forms.Label AppID2;
        private System.Windows.Forms.Label AppID3;
        private System.Windows.Forms.Label AppID4;
        private System.Windows.Forms.Label UnlockKeyLabel;
        private System.Windows.Forms.Label AppIDLabel;
        private System.Windows.Forms.Button UnlockButton;
    }
}