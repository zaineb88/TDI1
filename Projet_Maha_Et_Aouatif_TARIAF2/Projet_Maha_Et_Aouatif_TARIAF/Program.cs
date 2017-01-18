using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Projet_Maha_Et_Aouatif_TARIAF.Couche_Metier;
namespace Projet_Maha_Et_Aouatif_TARIAF
{
    static class Program
    {
       public static Les_Eléves eleve = new Les_Eléves();

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Couche_Interface.TournoiDesEléves ());
        }
    }
}
