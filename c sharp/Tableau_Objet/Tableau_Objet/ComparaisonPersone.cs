using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Tableau_Objet
{
    class ComparaisonPersone:IComparer
    {
        public int Compare(object x, object y)
        {
            Personne p1 = (Personne)x;
            Personne p2 = (Personne)y;
            int resultat = p1.Nom.CompareTo(p2.Nom);
            if (resultat == 0)
            {
                resultat = p1.Prénom.CompareTo(p2.Prénom);
                if (resultat == 0) resultat = p1.DateNaissance.CompareTo(p2.DateNaissance);
            }

            return resultat;
        }
    }
}
