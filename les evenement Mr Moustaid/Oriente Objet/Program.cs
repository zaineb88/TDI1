using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Oriente_Objet
{
    static class Program
    {
        public static les_classes.CabinetMedical CB = new les_classes.CabinetMedical();
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
