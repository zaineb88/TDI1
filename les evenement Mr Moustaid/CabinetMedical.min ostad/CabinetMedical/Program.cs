using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CabinetMedical
{
    static class Program
    {
      public static  Cabinetmedical CB = new Cabinetmedical();
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CabMedical());
        }
    }
}
