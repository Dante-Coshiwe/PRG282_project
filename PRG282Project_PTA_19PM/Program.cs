using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PRG282Project_PTA_19PM
{
    /// <summary>
    /// Main entry point for the Superhero Database application
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
