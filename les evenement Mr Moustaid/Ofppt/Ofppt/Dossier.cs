using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ofppt
{
    class Dossier
    {
        int numDossier, cne;

        public int Cne
        {
            get { return cne; }
            set { cne = value; }
        }
         string nom, niveausc1, niveauSc2, choix1, choix2, choix3;

         public string Choix3
         {
             get { return choix3; }
             set { choix3 = value; }
         }

         public string Choix2
         {
             get { return choix2; }
             set { choix2 = value; }
         }

         public string Choix1
         {
             get { return choix1; }
             set { choix1 = value; }
         }

         public string NiveauSc2
         {
             get { return niveauSc2; }
             set { niveauSc2 = value; }
         }

         public string Niveausc1
         {
             get { return niveausc1; }
             set { niveausc1 = value; }
         }
        string prénom;
        string sexe;
        DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        DateTime dateNaissance;

        public DateTime DateNaissance
        {
            get { return dateNaissance; }
            set { dateNaissance = value; }
        }

        public string Sexe
        {
            get { return sexe; }
            set { sexe = value; }
        }

        public string Prénom
        {
            get { return prénom; }
            set { prénom = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }


        public int NumDossier
        {
            get { return numDossier; }
            set { numDossier = value; }
        }
        public Dossier() { }

        public Dossier(int numD, DateTime dateDos, string niveuSc1,int cn, string noM, string prenom, string sex, DateTime datenassance, string niveuSc2, string choi1, string choi2, string choi3)
            : this()
        {
            date = dateDos; niveausc1 = niveuSc1; niveauSc2 = niveuSc2; choix1 = choi1; choix2 = choi2; choix3 = choi3; cne = cn;
            nom = noM; prénom = prenom; numDossier = numD; sexe = sex; dateNaissance = datenassance;

        
        }

    }
}
