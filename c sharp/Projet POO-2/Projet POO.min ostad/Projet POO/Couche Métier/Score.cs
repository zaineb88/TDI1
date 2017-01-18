using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_POO.Couche_Métier
{
    [Serializable]
    class Score
    {
        int _NuméroChasseur;
        string _Mois;
        int _NombreGibiers;

        public int NuméroChasseur
        {
            get { return _NuméroChasseur; }
            set { _NuméroChasseur = value; }
        }
        

        public string Mois
        {
            get { return _Mois; }
            set { _Mois = value; }
        }
       

        public int NombreGibiers
        {
            get { return _NombreGibiers; }
            set { _NombreGibiers = value; }
        }

        public Score(int NumeroChasseur, string Mois, int NbrGibiers)
        {
            _NuméroChasseur = NumeroChasseur;
            _Mois = Mois;
            _NombreGibiers = NbrGibiers;
        }



    }
}
