using System;
using System.Windows.Forms;

namespace indovina_il_giorno
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Rimuovi ApplicationConfiguration.Initialize(); se non esiste nel tuo progetto
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}