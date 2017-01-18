using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heritage
{
    class Individu
     
    {
        public string CIN;
        public string Nom;
        public string Prénom;
        public DateTime DateNaissance;
        public string Adresse;
        protected static int compteur = 0;

        public Individu()
            : base()
        {
            compteur++;
        }

        public Individu(string cin, string nom, string prénom, DateTime dateNaissance, string adresse) 
        {
            CIN = cin;
            Nom = nom;
            Prénom = prénom;
            DateNaissance = dateNaissance;
            Adresse = adresse;
            compteur++; // momkin mayetktebch hna w ndiro :this() mor l9aws
        }


        public int Age() 
        {
            DateTime AujourdHui = DateTime.Today;
            TimeSpan t = AujourdHui - DateNaissance;
            return t.Days / 365;
        }


        public virtual new string ToString()// méthode ToString pour Afficher
        {
            return CIN + " " + Nom + " " + Prénom + " "
                + DateNaissance.ToShortDateString() + " " + Adresse+ ".";
        }



        public static int NombreIndividu()
        {
            return compteur;
        }

    }


}
