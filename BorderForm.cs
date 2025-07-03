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
    public partial class BorderForm : Form
    {
        public BorderForm() {
            InitializeComponent();
        }

        public void Show(IntPtr handle)
        {
            WIN32.RECT rect;
            WIN32.GetWindowRect(handle, out rect);
            int width = rect.Right - rect.Left;
            int height = rect.Bottom - rect.Top;
            
            if (Left == rect.Left && Top == rect.Top && Width == width && Height == height) return;

            Show();

            Left = rect.Left; Top = rect.Top;
            Width = width; Height = height;

            Invalidate();
        }

        private void BorderForm_Load(object sender, EventArgs e) {
            BackColor = Color.Black;
            TransparencyKey = Color.Black;
            WIN32.EnableWindow(Handle, false);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Black, ClientRectangle);

            int width = 5;
            Rectangle rectangle = ClientRectangle;
            rectangle.Inflate(-width, -width);
            ControlPaint.DrawBorder(e.Graphics, rectangle,
                Color.Red, width, ButtonBorderStyle.Solid,
                Color.Red, width, ButtonBorderStyle.Solid,
                Color.Red, width, ButtonBorderStyle.Solid,
                Color.Red, width, ButtonBorderStyle.Solid
            );
        }

        private void BorderForm_Click(object sender, EventArgs e) {
            Hide();
        }
    }
}
