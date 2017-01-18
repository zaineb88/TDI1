using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetZainebMazouz
{
    class LesElèves
    {
        public List<Elève> El;

        public List<Elève> El1
        {
            get { return El; }
            set { El = value; }
        }

        public void Ajouter_Elève(Elève e)
        {
            El.Add(e);
        }

        public LesElèves()
        {
            El = new List<Elève>();

        }

    }
}