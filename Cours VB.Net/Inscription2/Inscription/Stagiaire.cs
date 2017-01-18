using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inscription
{
    class Stagiaire
    {
        private string nom;
        private string prénom;
        private string sexe;
        private string option;
        private int age;
        public Stagiaire()
        { }
        public Stagiaire(string noom, string prénoom, string seexe, string ooption, int agee)
        {
            nom = noom; prénom = prénoom; sexe = seexe; option = ooption; age = agee;
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prénom
        {
            get { return prénom; }
            set { prénom = value; }
        }
        public string Sexe
        {
            get { return sexe; }
            set { sexe = value; }
        }
        public string Option
        {
            get { return option; }
            set { option = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
       
    }
}
