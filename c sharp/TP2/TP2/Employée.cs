using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaBibliothèque;

namespace TP2
{
  abstract  class  Employée:Personne
    {
      protected string _Poste;
      protected string _Qualification;


      public Employée() : base() { }
      public Employée(string cin, string nom, string prénom, DateTime dateDeNaissance, string adresse, string poste, string qualification)
          : base(cin, nom, prénom, dateDeNaissance, adresse)
      { _Poste = poste; _Qualification = qualification; }


      public override string ToString()
      {
          return base.ToString()+Environment.NewLine + "Occupe le poste: " + _Poste + " et sa qualification est: " +_Qualification + ".";
      }


      public string Poste
      {
          get { return _Poste; }
          set { _Poste = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower(); }
      }

        public string Qualification{
          get { return _Qualification; }
          set { _Qualification = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower(); }

      }

    }
}
