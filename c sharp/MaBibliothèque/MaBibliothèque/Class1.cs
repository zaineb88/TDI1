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
        protected DateTime DateDeNaissance;
        protected string Adresse;
        private static int compteur=0;


        public Personne()
        {
            compteur++;
        }

        public Personne(string cin, string nom, string prénom, DateTime dateDeNaissance, string adresse):this() 
        {
            CIN = cin; Nom = nom; Prénom = prénom; DateDeNaissance = dateDeNaissance; Adresse = adresse;
        
        }

        public int Compteur {
            get { return compteur;}
        }


        public virtual new string ToString() {

            return CIN + ": " + Nom + " " + Prénom + " est né le: " + DateDeNaissance.ToShortDateString() + " et habite à: " + Adresse + ".";
        }

        public int Age() 
        {
            DateTime maintenant = DateTime.Today;
            TimeSpan durée = maintenant - DateDeNaissance;
            return durée.Days / 365;
        }

    }
}
