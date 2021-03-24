using System;
using System.Windows.Forms;

namespace Zinexium
{
    static class Program
    {
        public static bool ColorsChanged = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Zinexium());
        }
    }
}
