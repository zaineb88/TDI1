using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace Bloc_Note
{
    static class Program
    {
      public static Font S = new Font(FontFamily.GenericSerif, 14);
      public static Color C = new Color();
      public static string chaine;
      public static Boolean chercher = false;
       
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
