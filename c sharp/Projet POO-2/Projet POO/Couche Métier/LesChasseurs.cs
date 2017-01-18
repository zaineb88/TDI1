using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_POO.Couche_Métier 
{
    class LesChasseurs
    {
        List<Chasseur> L;// liste généric 7it katlib le type f lewel li howa f had l7ala type Chasseur (3aks array list li katlib objet )
        int positionChasEnCours=-1;

        public LesChasseurs()
        { L=new List<Chasseur>();
        }

        public Chasseur this[int i]// andicseur b7al propriété gher andicseur katesta3mil les listes w propriété li les champs 
        {
            get { return L[i]; }
            set { L[i] = value; }
        }

        public IEnumerator<Chasseur> GetEnumerator()//interface( dima ism interface katkon mebdiya b I )
        {
            foreach (Chasseur ch in L) yield return ch;// foreach kankhadmoha mili kaykon 3andna IEnumerateur
        }

          public int NombreChasseursParticipant { get { return L.Count; } }
          public int PositionChasseursEncours { get { return positionChasEnCours; } }
          public Chasseur ChasseursEncours { get { return L[positionChasEnCours]; } }

        public void Ajouter(Chasseur ch)
          {
              if (L.Count < 20)
                  
                  L.Add(ch);
              else
                  throw new DeplacementNombrePartissipantException("le nombre de partissipant a déja  atteint 20");
                       // bach yetéaficha message de erreur
              positionChasEnCours = L.Count - 1;// bach kayerja3 l2akher position
          }
          
        public void Modifier(int posEncienCh, Chasseur Nouveauch)
          {
              L[posEncienCh] = Nouveauch;
              
          }
        public void Modifier( Chasseur Nouveauch)
        {
            if(positionChasEnCours !=-1) L[positionChasEnCours] = Nouveauch;
        }
        public void Supprimer()
        {
           
                L.RemoveAt(positionChasEnCours);
            if (positionChasEnCours == L.Count) positionChasEnCours--;
        }
        public Chasseur Suivant()
        {
            if (positionChasEnCours < L.Count - 1)// ida kona wa9fin f akher position
            {
                positionChasEnCours++;
                return L[positionChasEnCours];
            }
            else return L[positionChasEnCours];
        }
        public Chasseur Precedant()
        {
            if (positionChasEnCours > 0)
            {
                positionChasEnCours--;
                return L[positionChasEnCours];
            }
            else return L[positionChasEnCours];
        }
        public Chasseur Premier()
        {
           
                positionChasEnCours=0;
                return L[positionChasEnCours];
          
        }
        public Chasseur Dernier()
        {

           positionChasEnCours =  L.Count - 1;
            return L[positionChasEnCours];

        }
        public Chasseur recherche(int numchasseur)
        {
            Chasseur cha = null;
            for (int i=0;i<L.Count;i++ )
            {
                if (L[i].NuméroChasseur == numchasseur)
                {

                    cha = L[i];
                    positionChasEnCours = i;
                    break;
                }
            }
            return cha;
        }
        public Chasseur recherche(string nomchasseur)
        {
            Chasseur cha = null;
            for (int i = 0; i < L.Count; i++)
            {
                if (L[i].Nom == nomchasseur)
                {

                    cha = L[i];
                    positionChasEnCours = i;
                    break;
                }
            }
            return cha;
        }

    }
}
