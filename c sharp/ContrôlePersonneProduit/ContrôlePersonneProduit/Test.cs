using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContrôlePersonneProduit
{
    class Test
    {
        static void Main(string[] args)
        {
            Personne P1 = new Personne("BH14587", "Maraji Ahmed");
            Personne P2 = new Personne("LK25478", "Alami Ilham");
            Produit D1 = new Produit("B102", "Bureau pour PC", 700f);
            Produit D2 = new Produit("C305", "Chaise pour bureau",550f);
            Produit D3 = new Produit("T406", "Table à deux places", 250f);
            Produit D4 = new Produit("TB250", "Tableau blanc", 650f);

            Console.WriteLine(P1.Affichage());
            Console.WriteLine(P2.Affichage());
            Console.WriteLine(D1.Affichage());
            Console.WriteLine(D2.Affichage());
            Console.WriteLine(D3.Affichage());
            Console.WriteLine(D4.Affichage());
            P1.ListeProduitAchetée(D1);
            P1.ListeProduitAchetée(D3);
            P1.ListeProduitAchetée(D4);
            P2.ListeProduitAchetée(D2); 
            P2.ListeProduitAchetée(D3);
           
            Console.ReadKey();

        }
    }
}
