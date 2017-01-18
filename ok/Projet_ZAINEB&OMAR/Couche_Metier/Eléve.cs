using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormApplication1
{[Serializable]
    class Eléve
    {
        static int _NombreEléve = 0;
        int _Matricule;
        string _Nom;
        string _Prénom;
        DateTime _DateDeNaissance;
        string _Adresse;

        public static int NombreEléve
        {
            get { return Eléve._NombreEléve; }
            
        }
        public int Matricule
        {
            get { return _Matricule; }
            set { _Matricule = value; }
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
       
        public DateTime DateDeNaissance
        {
            get { return _DateDeNaissance; }
            set { _DateDeNaissance = value; }
        }
      
        public string Adresse
        {
            get { return _Adresse; }
            set { _Adresse = value; }
        }
        public Eléve() { _NombreEléve++; }

        public Eléve(int matricule, string nom, string prénom)
            : this() { _Matricule = matricule; _Nom = nom; _Prénom = prénom; }

        public Eléve(int matricule, string nom, string prénom, 
            DateTime dateDeNaissance, string adress)
            : this(matricule, nom, prénom)
        { _DateDeNaissance = dateDeNaissance; _Nom = nom; _Prénom = prénom; }
        
    }
}
