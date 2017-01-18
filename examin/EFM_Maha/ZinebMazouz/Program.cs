using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TariafMaha
{
    static class Program
    {
        public static ListSuive sui = new ListSuive();
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
