using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormApplication1.Acces_Aux_Donner;
namespace WindowsFormApplication1.Couche_Metier
{[Serializable]
    class Les_Eléves
    {
        List<Eléve> E;
        int _EleveEnCours = -1;
     public Les_Eléves()
         {
             try
             {
                 E =SauvegardeEléve. LoadEléve();
    
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
        }

    
     internal List<Eléve> E1
     {
         get { return E; }
         set { E = value; }
     }
        public void SauvgarderListEléve()
        {
            SauvegardeEléve.savedeEléve(E);
        }


        public IEnumerator<Eléve> GetEnumerator()
        {
            foreach (Eléve El in E) yield return El;
        }
     
        public int NombreEléveParticipant { get { return E.Count; } }
        public int PositionElévesEncours { get { return _EleveEnCours; } }
        public void Ajouter(Eléve El)
        {
            if (E.Count < 30) { E.Add(El); _EleveEnCours++; }
            else
                throw new OccupeExcption("un possible d'ajouter un eléve");
        }
        public Eléve elEncoursposi
        {
            get
            {
                if (E.Count >= 0) return E[_EleveEnCours];
                else return null;
            }

        }
    
        public void Modifie(int Pos, Eléve NeveouxEléve)
        {
            E[Pos] = NeveouxEléve;
        }
        public void Modifier(Eléve Nouveaueleve)
        {
            if (_EleveEnCours != -1) E[_EleveEnCours ] = Nouveaueleve;
        }
        public void Suppremer(int EléveSuppremer)
        {
            if (PositionElévesEncours < E.Count && _EleveEnCours > -1)
                E.RemoveAt(EléveSuppremer);
            if (_EleveEnCours == E.Count)
            {
                _EleveEnCours--;
            }
        }
        public void Supprimer()
        {

            E.RemoveAt(_EleveEnCours);
            if (_EleveEnCours == E.Count) _EleveEnCours--;
        }

        public Eléve suivent()
        {
            if (_EleveEnCours < E.Count - 1)
            {
                _EleveEnCours++;
                return E[_EleveEnCours];
            }
            else return E[_EleveEnCours];
        }
        public Eléve précedent()
        {
            if (_EleveEnCours > 0)
            {
                _EleveEnCours--;
                return E[_EleveEnCours];
            }
            else return E[_EleveEnCours];
        }
        public Eléve Dernier()
        {
            _EleveEnCours = E.Count-1;
            return E[_EleveEnCours];
        }
        public Eléve Premier()
        {
            _EleveEnCours= 0;
            return E[_EleveEnCours];
        }
        public Eléve recherche(int PostionRecherche)
        {
            Eléve elév=null;
            for (int j = 0; j < E.Count; j++)
            {
                if (E[j].Matricule == PositionElévesEncours)
                {
                    elév = E[j];
                    _EleveEnCours = j; break;
                }
            }
            return elév;



            }
        public Eléve Recherche(string nomeleve)
        {
           Eléve ChRech = null;
            for (int i = 0; i < E.Count; i++)
                if (E[i].Nom == nomeleve)
                {
                    ChRech = E[i];
                  _EleveEnCours = i;
                    break;
                }
            return ChRech;
        }
        public bool RechercheDoublon(int matricule)
        {
            bool resultat = false;
            foreach (Eléve el in E)
                if (el.Matricule == matricule) { resultat = true; break; }
            return resultat;
        }
        }
    }

