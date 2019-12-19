using System;
using System.Windows.Forms;

namespace CrashIt
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length == 2 || args.Length == 3)
            {
                if (!CrashInjecter.Crash(args))
                    MessageBox.Show(
                        @"Usage: CrashIt [ProcessName] [Optional:ProcessTitle]" + Environment.NewLine +
                        @"Example: CrashIt newconsole setup" + Environment.NewLine + Environment.NewLine +
                        @"Usage: CrashIt [id:ProcessID]" + Environment.NewLine +
                        @"Example: CrashIt id:100", @"No Process to crash!");
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CrashIt());
        }
    }
}
