using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionDesNotesDesEleves
{
    class Elève
    {
        static int compteur = 0;



        int Matricule;
        string Nom;
        string Prénom;
        DateTime DateNaissance;
        string Adresse;
        string Télé;
        string Email;


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
        

        public DateTime DateNaissance1
        {
            get { return DateNaissance; }
            set { DateNaissance = value; }
        }
        

        public string Adresse1
        {
            get { return Adresse; }
            set { Adresse = value; }
        }
        

        public string Télé1
        {
            get { return Télé; }
            set { Télé = value; }
        }


        

        public string Email1
        {
            get { return Email; }
            set { Email = value; }
        }

          public Elève( string nom, string prénom, DateTime DN, string adresse, string télé, string email)
        {
            compteur++;
            Matricule = compteur;
            Nom = nom;
            Prénom = prénom;
            DateNaissance = DN;
            Adresse = adresse;
            Télé = télé;
            Email = email;

        }
        public override string ToString()
        {
            return Matricule+ " : " + Nom + " : " + Prénom + " : " + DateNaissance .ToShortDateString() + " : " + Adresse + " : " + Télé + " : " + Email;
        } 

    }
}
