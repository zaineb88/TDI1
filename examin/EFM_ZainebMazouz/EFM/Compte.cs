using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFM
{
    class Compte
    {
        int NCompte;
        double Solde;
        DateTime DateOuverture;
        string Nom;
        string Prénom;
        string Adresse;
        string DécouvertAcordé;

        public string DécouvertAcordé1
        {
            get { return DécouvertAcordé; }
            set { DécouvertAcordé = value; }
        }

        public int NCompte1
        {
            get { return NCompte; }
            set { NCompte = value; }
        }
        

        public double Solde1
        {
            get { return Solde; }
            set { Solde = value; }
        }
       

        public DateTime DateOuverture1
        {
            get { return DateOuverture; }
            set { DateOuverture = value; }
        }
        

        public string Nom1
        {
            get { return Nom; }
            set { Nom = value; }
        }
        

        public string Prénom1
        {
            get { return Prénom; }
            set { Prénom = value; }
        }
        

        public string Adresse1
        {
            get { return Adresse; }
            set { Adresse = value; }
        }

        public Compte() { }

        public Compte(int nc, double sol, DateTime daov, string no, string pré, string adr,string decac)
        { NCompte = nc; Solde = sol; DateOuverture = daov; Nom = no; Prénom = pré; Adresse = adr; DécouvertAcordé = decac; }

        public override string ToString()
        {
            return NCompte + ";" + Solde + ";" + DateOuverture.ToShortDateString() + ";" + Nom + ";" + Prénom + ";" + Adresse + ";" + DécouvertAcordé;
        }

    }
}
