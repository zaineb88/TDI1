using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heritage
{
    class Program
    {
        static void Main(string[] args)
        {

            //Individu I1 = new Individu();
            //I1.CIN = "LA236548";
            //I1.Nom = "Med";
            //I1.Prénom = "Rachid";
            //I1.DateNaissance=DateTime.Parse("14/06/1988");
            //I1.Adresse = "Larache";
            //Console.WriteLine(I1.ToString());
           

            //Individu[] T = new Individu[5];
            //for (int i = 0; i < 5; i++) 
            // { T[i] = new Individu(); }
            // foreach (Individu Ind in T)
            //  {
            //    Ind.CIN = "LA236548";
            //    Ind.Nom = "Med";
            //    Ind.Prénom = "Rachid";
            //    Ind.DateNaissance = DateTime.Parse("14/06/1988");
            //    Ind.Adresse = "Larache";
            //    Console.WriteLine(Ind.ToString());
           
            //  }

            Stagiaire S = new Stagiaire();
            S.CIN = "LA236548";
            S.Nom = "Med";
            S.Prénom = "Rachid";
            S.DateNaissance = DateTime.Parse("14/06/1988");
            S.Adresse = "Larache";
            S.Filière = "TDI";
            S.MoyenneGénérale = 14.35f;
            Console.WriteLine(S.ToString());


 Console.ReadKey();



        }

        
    }
}
