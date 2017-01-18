using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaBibliothèque;
namespace tp2ikram
{
    abstract class Employee:Personne
    {
        protected string Poste;
        protected string Qualification;
        public Employee() { }
        public Employee(string cin, string nom, string prénom, DateTime datedenaissance, string adresse, string poste, string qualification) : base(cin, nom, prénom, datedenaissance, adresse)
        {
            Qualification = qualification; Poste = poste;
      
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + Qualification + " : " + Poste + " .";
        }




    }
}
