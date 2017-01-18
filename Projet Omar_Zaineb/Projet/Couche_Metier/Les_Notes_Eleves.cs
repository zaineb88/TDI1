using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormApplication1.Acces_Aux_Donner;
namespace WindowsFormApplication1.Couche_Metier
{[Serializable]
    class Les_Notes_Eleves
    {
        List<Note_Eléve> N;

        public Les_Notes_Eleves() 
        {
            N = SaveNOTE.LoadNoteEléve();
        }

        public void SauvgarderListNote()
        {
            SaveNOTE.SauveNote(N);
        }

        public bool RechercheDoublon(int Matric, string matier)
        {
            bool resultat = false;
            for (int i = 0; i < N.Count; i++)
                if (N[i].Matricule == Matric && N[i].Matier == matier) { resultat = true; break; }
            return resultat;
        }
        public Note_Eléve Recherchenote(int matricule, string matier)
        {
            Note_Eléve resultat = null;
            for (int i = 0; i < N.Count; i++)
            {
                for (int j = 0; j < 240; j++)
                    if (N[i].Matricule== matricule && N[i].Matier == matier) { resultat =N[i]; break; }
            }
            return resultat;
        }
        public void Ajouter(Note_Eléve note)
        { N.Add(note); }
        public void Ajouter(int matricule, string matier, int nbrGibiers)
        {
            N.Add(new Note_Eléve(matricule, matier, nbrGibiers));
        }
        public float TotalMatierDesEléves(int matriculeLeEléve)
        {

            float TotaDesMatier= 0;
            for (int i = 0; i <N .Count; i++)
                if (N[i].Matricule == matriculeLeEléve) 
               TotaDesMatier += N[i].Note;
            return TotaDesMatier;
        }
        public List<int>NoteMatier
        {
            get
            {
                List<int> Lel = new List<int>();
                for (int i = 0; i <N. Count; i++)
                    if (!Lel.Contains(N[i].Matricule)) Lel.Add(N[i].Matricule);
                return Lel;
            }
        }

        public int LesMoiynneDesNote
        {
            get
            {
                int numVainq = NoteMatier[0];
                for (int i = 1; i <NoteMatier. Count; i++)
                    if ( TotalMatierDesEléves(numVainq) < TotalMatierDesEléves(NoteMatier[i]))
                        numVainq = NoteMatier[i];
                return numVainq;
            }
        }
        public int NombreNote { get { return N. Count; } }
    }
}
