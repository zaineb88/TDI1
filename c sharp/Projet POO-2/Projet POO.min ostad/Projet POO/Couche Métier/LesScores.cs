using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Projet_POO.Acces_aux_données;

namespace Projet_POO.Couche_Métier
{
    [Serializable]
    class LesScores
    {
        List<Score> S;

        public LesScores() 
        {
           S = SauvgardeScores.LoadScores();
        }

        public void SauvgarderListScores()
        {
            SauvgardeScores.SaveScores(S);
        }

        public bool RechercheDoublon(int NumChs, string mois)
        {
            bool resultat = false;
            for(int i=0; i<S.Count; i++)
                if (S[i].NuméroChasseur == NumChs && S[i].Mois == mois) { resultat = true; break; }
            return resultat;
        }

        public void Ajouter(Score Sc)
        {
            S.Add(Sc);
        }

        public void Ajouter(int numeroChasseur, string mois, int nbrGibiers)
        { S.Add(new Score(numeroChasseur,mois,nbrGibiers));
        }

        public  int TotalScoreChasseur(int numeroChasseur)
        {
            
            int TotalScore = 0;
            for (int i = 0; i < S.Count; i++)
                if (S[i].NuméroChasseur == numeroChasseur) TotalScore += S[i].NombreGibiers;
            return TotalScore;
        }


        public List<int> ChasseursAyantUnScore
        {
            get
            {
                List<int> L = new List<int>();
                for (int i = 0; i < S.Count; i++)
                    if (!L.Contains(S[i].NuméroChasseur)) L.Add(S[i].NuméroChasseur);
                return L;
            }
        }

        public int NumeroVainqueur
        {
            get
            {
                int numVainq = ChasseursAyantUnScore[0];
                for (int i = 1; i < ChasseursAyantUnScore.Count; i++)
                    if (TotalScoreChasseur(numVainq) < TotalScoreChasseur(ChasseursAyantUnScore[i]))
                        numVainq = ChasseursAyantUnScore[i];
                return numVainq;
            }
        }


    }
}
