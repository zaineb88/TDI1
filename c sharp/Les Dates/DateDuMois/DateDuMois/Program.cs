using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace caculer_le_nombre_de_jour
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, m, j;

            Console.WriteLine("Pour afficher le calendrier d'un mois veuillez:");
            Console.Write("Donnez le mois :");
            m = Int32.Parse(Console.ReadLine());
            Console.Write("Donnez l'année :");
            a = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("");



            CalendrierMois(m, a);

            Console.ReadKey();
        }

        static bool bessextille(int année)
        {
            if (année % 400 == 0 || (année % 4 == 0 && année % 100 != 0)) return true;
            else return false;
        }

        static int NombreJourDepuis01_01_01(int jour, int mois, int année)
        {
            int i, s = 0;

            for (i = 1; i < année; i++)
            {
                if (bessextille(i))
                { s = s + 366; }
                else
                { s = s + 365; }
            }

            for (i = 1; i < mois; i++)
            {
                if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12)
                    s = s + 31;
                else
                {
                    if (i == 4 || i == 6 || i == 9 || i == 11)
                        s = s + 30;
                    else
                    {
                        if (bessextille(année))
                            s = s + 29;
                        else
                            s = s + 28;
                    }
                }
            }
            s = s + jour;
            return s;

        }

        static int DifferenceDate(int jour1, int mois1, int année1, int jour2, int mois2, int année2)
        {
            return NombreJourDepuis01_01_01(jour1, mois1, année1) - NombreJourDepuis01_01_01(jour2, mois2, année2);
        }


        static string JourDeLaSemaine(int jour, int mois, int année)
        {
            int NbrJour = NombreJourDepuis01_01_01(jour, mois, année) - 1;
            int Joursemaine = NbrJour % 7;
            switch (Joursemaine)
            {
                case 0: return "Lundi"; break;
                case 1: return "Mardi"; break;
                case 2: return "Mercredi"; break;
                case 3: return "Jeudi"; break;
                case 4: return "Vendredi"; break;
                case 5: return "Samedi"; break;
                case 6: return "Dimanche"; break;
                default: return "";

            }


        }


        static void CalendrierMois(int mois, int année)
        {
            int[,] M = new int[6, 7];
            int Joursemaine = (NombreJourDepuis01_01_01(1, mois, année) - 1) % 7;
            int dernierJour;
            if (mois == 1 || mois == 3 || mois == 5 || mois == 7 || mois == 8 || mois == 10 || mois == 12)
                dernierJour = 31;
            else
                if (mois == 4 || mois == 6 || mois == 9 || mois == 11)
                    dernierJour = 30;
                else
                    if (bessextille(année)) dernierJour = 29; else dernierJour = 28;
            int jour = 1;
            for (int i = Joursemaine; i < 7; i++) { M[0, i] = jour; jour++; }
            for (int lg = 1; lg < 6; lg++)
            {
                for (int cl = 0; cl < 7; cl++) { M[lg, cl] = jour; jour++; if (jour == dernierJour + 1) break; }
                if (jour == dernierJour + 1) break;
            }

            Console.WriteLine("--calendrier du mois {0} de l'année {1}--", mois, année);
            Console.WriteLine(""); Console.WriteLine("");
            Console.WriteLine("Lun Mar Mer Jeu Ven Sam Dim");
            for (int lg = 0; lg < 6; lg++)
            {
                for (int cl = 0; cl < 7; cl++)
                    if (M[lg, cl] == 0) Console.Write("    ");
                    else
                        if (M[lg, cl] < 10) Console.Write("  {0} ", M[lg, cl]);
                        else Console.Write(" {0} ", M[lg, cl]);
                Console.WriteLine("");
            }





        }
    }






}




