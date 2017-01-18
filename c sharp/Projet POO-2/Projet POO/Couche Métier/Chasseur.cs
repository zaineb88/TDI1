using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_POO.Couche_Métier
{
    class Chasseur//definition de la class
    {
        int _NuméroChasseur;
        string _Nom;
        string _Prénom;
        string _Adresse;
        string _Téléphone;
        static int _NombreChasseur=0;

        public int NuméroChasseur// propriété pour publier les atribus de la class // 7it class par défaut kaykon privait
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
        public static int NombreChasseur { get { return _NombreChasseur; } }// 7ayedna get bach mayetbedilchi w static bach katesma7lo ykon mchtarik bin kol les class

        public Chasseur() { _NombreChasseur++; }// constricteur par défaut
        public Chasseur(int numéroChasseur, string nom, string prénom)// constructeur de question
            : this()// pour appeler le dernier constructeur
        {
            _NuméroChasseur = numéroChasseur;
            _Nom = nom; _Prénom = prénom;
        }
        public Chasseur(int numéroChasseur, string nom, string prénom, string adresse, string téléphone)
            : this(numéroChasseur,nom,prénom)
        {
            _Adresse = adresse;// zidnah gher hado 7it nom w prénom deja m3arfin w 3lihom khdimna this 
            _Téléphone = téléphone;
        }

    }
}
