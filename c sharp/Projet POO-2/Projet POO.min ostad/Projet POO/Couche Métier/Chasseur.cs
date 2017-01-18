using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_POO.Couche_Métier
{
    [Serializable]
    class Chasseur
    {
        int _NuméroChasseur;
        string _Nom;
        string _Prénom;
        string _Adresse;
        string _Téléphone;
        static int _NombreChasseur=0;

        public int NuméroChasseur
        {
            get { return _NuméroChasseur; }
            set { _NuméroChasseur = value; }
        }
      
        public string Nom
        {
            get { return _Nom; }
            set { _Nom = value.ToUpper(); }
        }
        

        public string Prénom
        {
            get { return _Prénom; }
            set { _Prénom = value; }
        }
        
        public string Adresse
        {
            get { return _Adresse; }
            set { _Adresse = value; }
        }
        

        public string Téléphone
        {
            get { return _Téléphone; }
            set { _Téléphone = value; }
        }
       public  static int NombreChasseur { get { return _NombreChasseur; } }

        public Chasseur() { _NombreChasseur++; }
        public Chasseur(int numéroChasseur, string nom, string prénom)
            : this()
        {
            _NuméroChasseur = numéroChasseur;
            _Nom = nom; _Prénom = prénom;
        }
        public Chasseur(int numéroChasseur, string nom, string prénom, string adresse, string téléphone)
            : this(numéroChasseur,nom,prénom)
        {
               _Adresse = adresse; _Téléphone = téléphone;
        }

        


    }
}
