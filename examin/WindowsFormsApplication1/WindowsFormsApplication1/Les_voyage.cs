using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Les_voyage
    {
        int index = -1;
        List<Voyage> lesVoyages;

        internal List<Voyage> LesVoyages
        {
            get { return lesVoyages; }
            set { lesVoyages = value; }
        }
        public int numSuivant()
        {
            return index+1;
        }
        public void Ajouter(Voyage v)
        {
            lesVoyages.Add(v);
            index=lesVoyages.Count-1;
        }
        public void Ajouter(int nu, string nompreno, DateTime datedebut, int dur, string vil, string matricu)
        {
            lesVoyages.Add(new Voyage(nu, nompreno, datedebut, dur, vil, matricu));
            index = lesVoyages.Count - 1;
        }
        public void Supprimer()
        {
            if (lesVoyages.Count > 0)
            {
                lesVoyages.Remove(lesVoyages[index]);
                index-- ;
            }
        }
        public int nombrevoyage
        { 
              get{return lesVoyages.Count;}
        }
        public Voyage this[int i]
        {
            get { return lesVoyages[i]; }
            set { lesVoyages[i] = value; }

        }
        public Voyage Suivant()
        {
            Voyage v = null;
            if (index != -1)
            {
                index++;
                v = lesVoyages[index];
            }
            return v;
        }
        public Voyage Precedent()
        {
            Voyage v = null;
            if (index != -1)
            {
                index--;
                v = lesVoyages[index];
            }
            return v;
        }
        public Voyage Premier()
        {
            Voyage v = null;
            if (index != -1 && lesVoyages.Count>0)
            {
                index = 0;
                v = lesVoyages[index];
            }
            return v;
        }
        public Voyage Dernier()
        {
            Voyage v = null;
            if (index != -1)
            {
                index = lesVoyages.Count-1;
                v = lesVoyages[index];
            }
            return v;
        }
        public Les_voyage() { lesVoyages = new List<Voyage>(); }
    }
}
