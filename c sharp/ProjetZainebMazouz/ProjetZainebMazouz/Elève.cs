using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ProjetZainebMazouz
{
    class Elève
    {
         static int compteur = 0;



        int Matricule;
        string Nom;
        string Prénom;
        string Adresse;
        DateTime DateNaissance;
      

        public static int Compteur
        {
            get { return Elève.compteur; }
            set { Elève.compteur = value; }
        }


        public int Matricule1
        {
            get { return Matricule; }
            set { Matricule = value; }
        }
        

        public string Nom1
        {
            get { return Nom; }
            set { Nom = value; }
        }
        

        public string Prénom1
        {
            get { return Prénom; }
            set { Prénom = value; }
        }
        
        public string Adresse1
        {
            get { return Adresse; }
            set { Adresse = value; }
        }
        
        public DateTime DateNaissance1
        {
            get { return DateNaissance; }
            set { DateNaissance = value; }
        }
        

        

       

          public Elève( string nom, string prénom, DateTime DN, string adresse)
        {
            compteur++;
            Matricule = compteur;
            Nom = nom;
            Prénom = prénom;
            DateNaissance = DN;
            Adresse = adresse;
            
        }
        public override string ToString()
        {
            return Matricule + " : " + Nom + " : " + Prénom + " : " + DateNaissance.ToShortDateString() + " : " + Adresse;
        } 

    }
}
