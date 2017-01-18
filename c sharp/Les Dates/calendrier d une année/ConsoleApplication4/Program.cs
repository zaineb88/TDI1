using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("            Pour afficher le calendrier d'un année veuillez:");
            Console.Write("                                Donnez l'année: ");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("");


           Calendrier_12mois(a);//méthode


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
        static void CalendrierMois3(int mois, int mois1, int mois2, int année)
        {
            int cl, lg, i;
            int[,] M = new int[6, 7]; int[,] M1 = new int[6, 7]; int[,] M2 = new int[6, 7];
            int Joursemaine = (NombreJourDepuis01_01_01(1, mois, année) - 1) % 7;
            int dernierJour;
            if (mois == 1 || mois == 3 || mois == 5 || mois == 7 || mois == 8 || mois == 10 || mois == 12)
                dernierJour = 31;
            else
                if (mois == 4 || mois == 6 || mois == 9 || mois == 11)
                    dernierJour = 30;
                else
                    if (bessextille(année)) dernierJour = 29; else dernierJour = 28;
            int Joursemaine1 = (NombreJourDepuis01_01_01(1, mois1, année) - 1) % 7;
            int dernierJour1;
            if (mois1 == 1 || mois1 == 3 || mois1 == 5 || mois1 == 7 || mois1 == 8 || mois1 == 10 || mois1 == 12)
                dernierJour1 = 31;
            else
                if (mois1 == 4 || mois1 == 6 || mois1 == 9 || mois1 == 11)
                    dernierJour1 = 30;
                else
                    if (bessextille(année)) dernierJour1 = 29; else dernierJour1 = 28;

            int Joursemaine2 = (NombreJourDepuis01_01_01(1, mois2, année) - 1) % 7;
            int dernierJour2;
            if (mois2 == 1 || mois2 == 3 || mois2 == 5 || mois2 == 7 || mois2 == 8 || mois2 == 10 || mois2 == 12)
                dernierJour2 = 31;
            else
                if (mois2 == 4 || mois2 == 6 || mois2 == 9 || mois2 == 11)
                    dernierJour2 = 30;
                else
                    if (bessextille(année)) dernierJour2 = 29; else dernierJour2 = 28;

            int jour = 1;
            for (i = Joursemaine; i < 7; i++) { M[0, i] = jour; jour++; }
            for (lg = 1; lg < 6; lg++)
            {
                for (cl = 0; cl < 7; cl++) { M[lg, cl] = jour; jour++; if (jour == dernierJour + 1) break; }
                if (jour == dernierJour + 1) break;
            }
            int jour1 = 1;
            for (i = Joursemaine1; i < 7; i++) { M1[0, i] = jour1; jour1++; }
            for (lg = 1; lg < 6; lg++)
            {
                for (cl = 0; cl < 7; cl++) { M1[lg, cl] = jour1; jour1++; if (jour1 == dernierJour1 + 1) break; }
                if (jour1 == dernierJour1 + 1) break;
            }


            int jour2 = 1;
            for (i = Joursemaine2; i < 7; i++) { M2[0, i] = jour2; jour2++; }
            for (lg = 1; lg < 6; lg++)
            {
                for (cl = 0; cl < 7; cl++) { M2[lg, cl] = jour2; jour2++; if (jour2 == dernierJour2 + 1) break; }
                if (jour2 == dernierJour2 + 1) break;
            }

            Console.Write(" Lu Ma Me Je Ve Sa Di"); Console.Write("  Lu Ma Me Je Ve Sa Di"); Console.WriteLine("    Lu Ma Me Je Ve Sa Di");

            for (cl = 0; cl < 7; cl++) { if (M[0, cl] == 0) Console.Write("   "); else Console.Write("  {0}", M[0, cl]); }
            Console.Write(" ");
            for (cl = 0; cl < 7; cl++) { if (M1[0, cl] == 0) Console.Write("   "); else Console.Write("  {0}", M1[0, cl]); }
            Console.Write("   ");
            for (cl = 0; cl < 7; cl++) { if (M2[0, cl] == 0) Console.Write("   "); else Console.Write("  {0}", M2[0, cl]); }
            Console.WriteLine("");

            for (cl = 0; cl < 7; cl++) { if (M[1, cl] < 10) Console.Write("  {0}", M[1, cl]); else Console.Write(" {0}", M[1, cl]); }
            Console.Write(" ");
            for (cl = 0; cl < 7; cl++) { if (M1[1, cl] < 10) Console.Write("  {0}", M1[1, cl]); else Console.Write(" {0}", M1[1, cl]); }
            Console.Write("   ");
            for (cl = 0; cl < 7; cl++) { if (M2[1, cl] < 10) Console.Write("  {0}", M2[1, cl]); else Console.Write(" {0}", M2[1, cl]); }
            Console.WriteLine("");
            for (cl = 0; cl < 7; cl++) { if (M[2, cl] < 10) Console.Write("  {0}", M[2, cl]); else Console.Write(" {0}", M[2, cl]); }
            Console.Write(" ");
            for (cl = 0; cl < 7; cl++) { if (M1[2, cl] < 10) Console.Write("  {0}", M1[2, cl]); else Console.Write(" {0}", M1[2, cl]); }
            Console.Write("   ");
            for (cl = 0; cl < 7; cl++) { if (M2[2, cl] < 10) Console.Write("  {0}", M2[2, cl]); else Console.Write(" {0}", M2[2, cl]); }
            Console.WriteLine("");
            for (cl = 0; cl < 7; cl++) { Console.Write(" {0}", M[3, cl]); }
            Console.Write(" ");
            for (cl = 0; cl < 7; cl++) { Console.Write(" {0}", M1[3, cl]); }
            Console.Write("   ");
            for (cl = 0; cl < 7; cl++) { Console.Write(" {0}", M2[3, cl]); }
            Console.WriteLine("");

            for (cl = 0; cl < 7; cl++) { if (M[4, cl] == 0) Console.Write("   "); else Console.Write(" {0}", M[4, cl]); }
            Console.Write(" ");
            for (cl = 0; cl < 7; cl++) { if (M1[4, cl] == 0) Console.Write("   "); else Console.Write(" {0}", M1[4, cl]); }
            Console.Write("   ");
            for (cl = 0; cl < 7; cl++) { if (M2[4, cl] == 0) Console.Write("   "); else Console.Write(" {0}", M2[4, cl]); }
            Console.WriteLine("");


            for (cl = 0; cl < 7; cl++) { if (M[5, cl] == 0) Console.Write("   "); else Console.Write(" {0}", M[5, cl]); }
            Console.Write(" ");
            for (cl = 0; cl < 7; cl++) { if (M1[5, cl] == 0) Console.Write("   "); else Console.Write(" {0}", M1[5, cl]); }
            Console.Write("   ");
            for (cl = 0; cl < 7; cl++) { if (M2[5, cl] == 0) Console.Write("   "); else Console.Write(" {0}", M2[5, cl]); }
            Console.WriteLine("");
            Console.WriteLine("");
        }

        static void Calendrier_12mois(int année)
        {

            Console.WriteLine("                    calandrier de l'année {0}", année);
            Console.WriteLine("    jaunveir                 février                mars   ");
            Console.WriteLine("");
            CalendrierMois3(1, 2, 3, année);
            Console.WriteLine("    avril                      mai                  juin   ");
            Console.WriteLine("");
            CalendrierMois3(4, 5, 6, année);
            Console.WriteLine("    juillet                   aout                  september   ");
            Console.WriteLine("");
            CalendrierMois3(7, 8, 9, année);
            Console.WriteLine("    Octobre                   Novembre               Décembre   ");
            Console.WriteLine("");
            CalendrierMois3(10, 11, 12, année);



        }
    }






}
