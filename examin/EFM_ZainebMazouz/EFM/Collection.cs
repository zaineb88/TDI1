using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFM
{
    class Collection
    {
        int index = -1;

        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        List<Compte> liste;

        internal List<Compte> Liste
        {
            get { return liste; }
            set { liste = value; }
        }

        public Collection()
        { liste = new List<Compte>(); }

         public int numSuivant()
        {
            return index+1;
        }
        public void Ajouter(Compte c)
        {
            liste.Add(c);
            index=liste.Count-1;
        }
        public void Ajouter(int nu, double sol, DateTime dateouv, string nom, string prénom, string adresse,string decoav)
        {
            liste.Add(new Compte(nu, sol, dateouv, nom, prénom, adresse,decoav));
            index = liste.Count - 1;
        }
        public void Supprimer()
        {
            if (liste.Count > 0)
            {
                liste.Remove(liste[index]);
                index-- ;
            }
        }

            public int nombrecompte
        { 
              get{return liste.Count;}
        }
        public Compte this[int i]
        {
            get { return liste[i]; }
            set { liste[i] = value; }

        }
        public Compte Suivant()
        {
            Compte c = null;
            if (index != -1)
            {
                index++;
                c = liste[index];
            }
            return c;
        }
        public Compte Precedent()
        {
            Compte c = null;
            if (index != -1)
            {
                index--;
                c= liste[index];
            }
            return c;
        }
        public Compte Premier()
        {
            Compte c = null;
            if (index != -1 && liste.Count>0)
            {
                index = 0;
                c = liste[index];
            }
            return c;
        }
        public Compte Dernier()
        {
            Compte c = null;
            if (index != -1)
            {
                index = liste.Count-1;
                c = liste[index];
            }
            return c;
        }
     
    }
}
