using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Classe_Patient
    {
        static int compteur = 0;
        int _CodePatient;
        string _Nom;
        string _Prénom;
        DateTime _Dt;
        string _Adresse;
        string _télé;
        string _Email;

        public int CodePatient
        {
            get { return _CodePatient; }
            //set { _CodePatient = value; }
        }
        

        public string Nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }
        

        public string Prénom
        {
            get { return _Prénom; }
            set { _Prénom = value; }
        }
        

        public DateTime Dt
        {
            get { return _Dt; }
            set { _Dt = value; }
        }
        

        public string Adresse
        {
            get { return _Adresse; }
            set { _Adresse = value; }
        }
        

        public string Télé
        {
            get { return _télé; }
            set { _télé = value; }
        }
        

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }


        public Classe_Patient(string nom, string prénom)
        {
            compteur++;
            _CodePatient = compteur;
            
            _Nom = nom;
            _Prénom = prénom;
        }

        public Classe_Patient( string nom, string prénom, DateTime dt, string adresse, string télé, string email)
        {
            compteur++;
            _CodePatient = compteur;
            _Nom = nom;
            _Prénom = prénom;
            _Dt = dt;
            _Adresse = adresse;
            _télé = télé;
            _Email = email;

        }
        public override string ToString()
        {
            return _CodePatient + ":" 
                + _Nom + ":"
                + _Prénom + ":" 
                +_Dt.ToShortDateString() + ":" 
                + _Adresse + ":" 
                + _télé + ":"
                + _Email ;
        } 
    }
}
