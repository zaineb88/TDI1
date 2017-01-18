using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormApplication1.Couche_Metier
{[Serializable]
    class Note_Eléve
    {
        int _Matricule;
        string _Matier;
        float _Note;

        public int Matricule
        {
            get { return _Matricule; }
            set { _Matricule = value; }
        }
     
        public string Matier
        {
            get { return _Matier; }
            set { _Matier = value; }
        }
       
        public float Note
        {
            get { return _Note; }
            set { _Note = value; }
        }
        public Note_Eléve(int matricule, string matier, float nombreGibbiers)
        {
            _Matricule = matricule;
            _Matier = matier;
            _Note = nombreGibbiers;
        }

    }
}
