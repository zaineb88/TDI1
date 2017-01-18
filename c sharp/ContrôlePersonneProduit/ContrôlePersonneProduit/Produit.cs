using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContrôlePersonneProduit
{
    class Produit
    {
        string _CodeProduit;
        string _Intitule;
        float _PrixUnitaire;
        static int Compteur = 0;

        public Produit()//constructeur par défaut
        { Compteur++; }

        public Produit(string codeproduit, string intitule,float prixunitaire):this()
        {
            // ou Compteur++ f 3awad this();
            _CodeProduit = codeproduit; _Intitule = intitule; _PrixUnitaire = prixunitaire;
        }
        public string CodeProduit //propriété 
        {
            get { return _CodeProduit; }// accesseur
            set { _CodeProduit = value; } //modificateur
        }
        public string Intitule
        {
            get { return _Intitule; }
            set { _Intitule = value; }
        }
        public float PrixUnitaire
        {
            get { return _PrixUnitaire; }
            set { _PrixUnitaire = value; }
        }
        public int Compteur1
        {
            get { return Compteur; }
        }
        public string Affichage()
        { return "Le code de produit est :" + _CodeProduit +
            " L'intitule: " + _Intitule + " est leur prix unitaire : " + _PrixUnitaire + "."; }
  
    }

}
