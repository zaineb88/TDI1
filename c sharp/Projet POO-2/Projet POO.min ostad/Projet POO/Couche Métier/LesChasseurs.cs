using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Projet_POO.Acces_aux_données;
using System.Windows.Forms;

namespace Projet_POO.Couche_Métier
{ [Serializable]
    class LesChasseurs
    {
        List<Chasseur> L;
        int ChasEnCours=-1;

        public LesChasseurs()
         {
             try
             {
                 L = SauvgardeChasseurs.LoadChasseurs();
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
        }

        public void SauvgarderListChasseur()
        {
            SauvgardeChasseurs.SaveChasseurs(L);
        }

        public Chasseur this[int i]
        {
            get { return L[i]; }
            set { L[i] = value; }
        }

          public IEnumerator<Chasseur> GetEnumerator()
        {
            foreach (Chasseur ch in L) yield return ch;
        }

          public int NombreChasseursParticipant { get { return L.Count; } }

          public int posChasseurEncours { get { return ChasEnCours; } }

          public Chasseur ChasseurEncours { get {
              if (L.Count > 0) return L[ChasEnCours];
              else return null;
          }
          }

          public int[] NumerosDesChasseurs {
              get {
                  int[] NumsChs = new int[L.Count];
                  for (int i = 0; i < L.Count; i++ ) NumsChs[i]=L[i].NuméroChasseur;
                  return NumsChs;
              }
          }
        public void Ajouter(Chasseur ch)
          {
              if (L.Count <20) L.Add(ch);
              else throw new DepacementNombrePartissipantException("Le nombre de participants a déjà atteind 20 chasseurs");
                            ChasEnCours = L.Count - 1;
          }
          
        public void Modifier(int posEncienCh, Chasseur Nouveauch)
          {
              L[posEncienCh] = Nouveauch;
          }
        public void Modifier( Chasseur Nouveauch)
        {
            if(ChasEnCours !=-1) L[ChasEnCours] = Nouveauch;
        }

        public void Supprimer(int posChasASupprimer)
        {
            if(posChasASupprimer>-1 && posChasASupprimer<L.Count)
                L.RemoveAt(posChasASupprimer);
            if (ChasEnCours == L.Count) ChasEnCours--;
        }

        public void Supprimer()
        {

            L.RemoveAt(ChasEnCours);
            if (ChasEnCours == L.Count) ChasEnCours--;
        }

        public Chasseur Suivant()
        {
            if (ChasEnCours < L.Count - 1)
            {
                ChasEnCours++;
                return L[ChasEnCours];
                        }
            else return L[ChasEnCours];
        }


        public Chasseur Précedent()
        {
            if (ChasEnCours > 0)
            {
                ChasEnCours--;
                return L[ChasEnCours];
            }
            else return L[ChasEnCours];
        }

        public Chasseur Premier()
        {
                   ChasEnCours=0;
                return L[ChasEnCours];
                   }

        public Chasseur Dernier()
        {
            ChasEnCours = L.Count-1;
            return L[ChasEnCours];
        }

        public Chasseur Recherche(int numChasseur)
        {
            Chasseur ChRech=null; 
            for(int i=0; i<L.Count; i++)
            if (L[i].NuméroChasseur == numChasseur)
            {
                ChRech = L[i];
                ChasEnCours = i;
                break;
            }
            return ChRech;
        }

        public Chasseur Recherche(string nomChasseur)
        {
            Chasseur ChRech = null;
            for (int i = 0; i < L.Count; i++)
                if (L[i].Nom== nomChasseur)
                {
                    ChRech = L[i];
                    ChasEnCours = i;
                    break;
                }
            return ChRech;
        }
        public bool RechercheDoublon(int numeroChasseur)
        {
            bool resultat = false;
            foreach(Chasseur chs in L)
                if (chs.NuméroChasseur == numeroChasseur) { resultat = true; break; }
            return resultat;
        }


    }
}
