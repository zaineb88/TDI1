using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestionDesNotesDesEleves
{
    static class Program
    {
        public static Form1 GNE = new Form1();
        /// <summary>
        /// Point d'entrée principal de l'application.
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
