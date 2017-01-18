using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Projet_Maha_Et_Aouatif_TARIAF.Acces_Aux_Donner;
namespace Projet_Maha_Et_Aouatif_TARIAF.Couche_Metier
{[Serializable]
    class Les_Eléves
    {
        List<Eléve> L;
        int _EleveEnCours = -1;
     public Les_Eléves()
         {
             try
             {
                 L =SauvegardeEléve. LoadEléve();
    
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
        }

    
     internal List<Eléve> L1
     {
         get { return L; }
         set { L = value; }
     }
        public void SauvgarderListEléve()
        {
            SauvegardeEléve.savedeEléve(L);
        }


        public IEnumerator<Eléve> GetEnumerator()
        {
            foreach (Eléve El in L) yield return El;
        }
        //public int NombreEleve { get { return L.Count; } }
        public int NombreEléveParticipant { get { return L.Count; } }
        public int PositionElévesEncours { get { return _EleveEnCours; } }
        public void Ajouter(Eléve El)
        {
            if (L.Count < 30) L.Add(El);
            else
             throw new OccupeExcption ("un possible d'ajouter un eléve");
        }
        public Eléve elEncoursposi
        {
            get
            {
                if (L.Count >= 0) return L[_EleveEnCours];
                else return null;
            }

        }
        public int[] MatriculeDesEléves
        {
            get
            {
                int[] matriculeeléve = new int[L.Count];
                for (int i = 0; i < L.Count; i++) matriculeeléve[i] = L[i].Matricule;
                return matriculeeléve;
            }
        }
        public void Modifie(int Pos, Eléve NeveouxEléve)
        {
            L[Pos] = NeveouxEléve;
        }
        public void Modifier(Eléve Nouveaueleve)
        {
            if (_EleveEnCours != -1) L[_EleveEnCours ] = Nouveaueleve;
        }
        public void Suppremer(int EléveSuppremer)
        {
            if (PositionElévesEncours < L.Count && _EleveEnCours > -1)
                L.RemoveAt(EléveSuppremer);
            if (_EleveEnCours == L.Count)
            {
                _EleveEnCours--;
            }
        }
        public void Supprimer()
        {

            L.RemoveAt(_EleveEnCours);
            if (_EleveEnCours == L.Count) _EleveEnCours--;
        }

        public Eléve suivent()
        {
            if (_EleveEnCours < L.Count - 1)
            {
                _EleveEnCours++;
                return L[_EleveEnCours];
            }
            else return L[_EleveEnCours];
        }
        public Eléve précedent()
        {
            if (_EleveEnCours > 0)
            {
                _EleveEnCours--;
                return L[_EleveEnCours];
            }
            else return L[_EleveEnCours];
        }
        public Eléve Dernier()
        {
            _EleveEnCours = L.Count-1;
            return L[_EleveEnCours];
        }
        public Eléve Premier()
        {
            _EleveEnCours= 0;
            return L[_EleveEnCours];
        }
        public Eléve recherche(int PostionRecherche)
        {Eléve elév=null;
            for (int i = 0; i < L.Count; i++)
            {
                if (L[i].Matricule == PositionElévesEncours)
                    elév = L[i];
                _EleveEnCours=i;break;
            }
            return elév;



            }
        public Eléve Recherche(string nomeleve)
        {
           Eléve ChRech = null;
            for (int i = 0; i < L.Count; i++)
                if (L[i].Nom == nomeleve)
                {
                    ChRech = L[i];
                  _EleveEnCours = i;
                    break;
                }
            return ChRech;
        }
        public bool RechercheDoublon(int matricule)
        {
            bool resultat = false;
            foreach (Eléve el in L)
                if (el.Matricule == matricule) { resultat = true; break; }
            return resultat;
        }
        }
    }

