using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tableau_Objet
{
    class Personne

    {
        protected string _CIN;
        protected string _Nom;
        protected string _Prénom;
        protected DateTime _DateNaissance;

        public Personne(string cin, string nom, string prénom, DateTime DN)
        {
            _CIN = cin; _Nom = nom; _Prénom = prénom; _DateNaissance = DN;
        }

        public override string ToString()
        {
            return _CIN + ": " + _Nom + " "+ _Prénom + " (" + _DateNaissance.ToShortDateString() + ")";
        }

        public string CIN {
            get { return _CIN; }
            set { _CIN = value; }
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

        public DateTime DateNaissance
        {
            get { return _DateNaissance; }
            set { _DateNaissance = value; }
        }

    }
}
