using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace SplitScreenMod
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            bool IsSingleInstance = false;
            Mutex mutex = new Mutex(true, "SPLIT_SCREEN_MOD_MUTEX_SINGLE_INSTANCE", out IsSingleInstance);
            if (!IsSingleInstance) return;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ActiveForm());

            Application.Run(new MainForm());
        }
    }
}
