using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DateNaissance
{
    class Program
    {
        static void Main(string[] args)
        {
        
            int j,m,a;
            DateTime aujourdhui = DateTime.Today;
        Console.WriteLine("donner le jour de votre date de naissance");
        j=Int32.Parse(Console.ReadLine());
        Console.WriteLine("donner le mois de votre date de naissance");
        m=Int32.Parse(Console.ReadLine());
        Console.WriteLine("donner l'année de votre date de naissance");
        a=Int32.Parse(Console.ReadLine());
        Console.WriteLine("Le jour de votre naissance était un  {0}",JourDeLaSemaine(j,m,a));
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
    }
}
