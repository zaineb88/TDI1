using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TariafMaha
{
    class Suivi
    {
      public  int NCompte;
      public double Solde;
      public DateTime DateOvertur;
      public string Nom;
      public string prenom;
      public string Adresse;
      public string Decouvert;
      public Suivi(int NCom, double Sol, DateTime Date, string nom, string pren, string adresse,string De)
      { NCompte = NCom; Solde = Sol; DateOvertur = Date; Nom = nom; prenom = pren; Adresse = adresse; Decouvert = De; }

      public Suivi(int NCom, double Sol, DateTime Date, string nom, string pren, string adresse)
      { NCompte = NCom; Solde = Sol; DateOvertur = Date; Nom = nom; prenom = pren; Adresse = adresse;  }



    }
}
