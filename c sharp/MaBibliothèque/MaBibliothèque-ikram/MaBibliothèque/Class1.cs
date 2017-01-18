using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaBibliothèque
{
    public class Personne
    {
        protected string CIN;
        protected string Nom;
        protected string Prénom;
        protected DateTime Datedenaissance;
        protected string Adresse;
        private static int compteur = 0;


        public Personne()
        { compteur++; }
        public Personne(string cin, string nom, string prénom, DateTime datedenaissance, string adresse)
            : this()
        { CIN = cin; Nom = nom; Prénom = prénom; Datedenaissance = datedenaissance; Adresse = adresse; }

        public int Compteur()
        { return compteur; }
        
        
        
        public virtual new string ToString()
        {
            return CIN + " :  " + Nom + " : " + Prénom + " : " + Datedenaissance + " : " + Adresse + " . ";

        }
        public int age()
        {
            DateTime maintenant = DateTime.Today;
            TimeSpan duree = maintenant - Datedenaissance;
            return duree.Days / 365;
        }

    }
}
