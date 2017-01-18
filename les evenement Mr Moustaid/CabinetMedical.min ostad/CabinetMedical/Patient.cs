using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CabinetMedical
{
    class Patient
    {
        static int compteur = 0;

        
        int code;
        String nom;
        String prenom;
        DateTime datenaissance;
        String adresse;
        String tel;
        String email;
       public static int Compteur
        {
            get { return Patient.compteur; }
            set { Patient.compteur = value; }
        }
        public int Code
        {
            get { return code; }
            //set { code = value; }
        }
        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public String Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public String Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
        public DateTime Datenaissance
        {
            get { return datenaissance; }
            set { datenaissance = value; }
        }
        public String Tel
        {
            get { return tel; }
            set { tel = value; }
        } 

        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        public Patient(String nom, String prenom)
        {
            compteur++;
            code = compteur;
            this.nom = nom;
            this.prenom = prenom;
        }
  public Patient(String nom, String prenom
        ,DateTime datenaissance,String adresse,String tel,String email)
        {
            compteur++;
            code = compteur;
            this.nom = nom;
            this.prenom = prenom;
            this.datenaissance = datenaissance;
            this.adresse = adresse; 
            this.tel = tel;
            this.email = email;
        }
        public override string ToString()
        {
            return code+":"+nom
          + ":" + prenom 
          + ":" + datenaissance.ToShortDateString()
          + ":" + adresse + ":" + tel + ":" + email;
        }
    }
}
