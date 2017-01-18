using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContrôlePersonneProduit
{
    class Personne
    {
        string _NuméroCIN;
        string _NomComplet;
        List<Produit> ProduitAchetés;

        //internal List<Produit> ProduitAchetés1
        //{
        //    get { return ProduitAchetés; }
        //    set { ProduitAchetés = value; }
        //}

        public Personne() { ProduitAchetés = new List<Produit>();}//par défaut

        public Personne(string numCIN, string nom):this()
        {
            _NuméroCIN = numCIN; _NomComplet = nom;
        }
        public string NuméroCIN
        {
            get { return _NuméroCIN; }
            set { _NuméroCIN = value; }
        }
        public string NomComplet
        {
            get { return _NomComplet; }
            set { _NomComplet = value; }
        }
        public void ListeProduitAchetée(Produit produit)//méthode dyal ajouter dernaha 7it 7tajinaha f question 9

        {
            ProduitAchetés.Add(produit);
           
        }
        public float MontantPayé()
        {
            float m = 0;
            foreach (Produit p in ProduitAchetés)
                m = (m + p.PrixUnitaire) * 1.2f;
            return m;
        }

        public string Affichage() // question 11
        {
            if (ProduitAchetés.Count == 0)
            {
                return "Numero de CIN : " + _NuméroCIN + "  " + _NomComplet + ".";
            }
            else
            {
                string s = "Numero de CIN : " + _NuméroCIN + " Nom Complet " + _NomComplet + 
                    " acheté les produit : " + Environment.NewLine;
                foreach (Produit p in ProduitAchetés)
                    s = s + p.Affichage() + Environment.NewLine;

                s = s +"Le montant qui doit payé "+ this.MontantPayé().ToString() + "MAD";
                return s;
            }
                    
        }
    }
}
