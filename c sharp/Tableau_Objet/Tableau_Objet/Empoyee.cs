using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tableau_Objet
{
    class Empoyee:Personne,IComparable
    {
        private double _Salaire;

        public Empoyee(string cin, string nom, string prénom, DateTime DN, double salaire)
            : base(cin, nom, prénom, DN)
        { _Salaire = salaire; }

        public double Salaire {
            get { return _Salaire; }
            set { _Salaire=value;}
        }

        public override string ToString()
        {
            return base.ToString() + " son salaire est : " + _Salaire.ToString();
        }

        public int CompareTo(object obj)
        {
            Empoyee E = (Empoyee)obj;
            int resultat = this.Nom.CompareTo(E.Nom);
            if (resultat == 0)
            {
                resultat = this.Prénom.CompareTo(E.Prénom);
                if (resultat == 0) resultat =this.DateNaissance.CompareTo(E.DateNaissance);
            }

            return resultat;
        }
    }
}
