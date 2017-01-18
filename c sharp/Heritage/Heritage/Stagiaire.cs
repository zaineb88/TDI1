using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heritage
{
    class Stagiaire:Individu
    {
        public string Filière;
        public float MoyenneGénérale;

        public Stagiaire() {  }

        public Stagiaire(string cin, string nom, string prénom, DateTime dateNaissance,
            string adresse, string filière, float moyenneGénérale) 
           : base(cin,nom,prénom,dateNaissance,adresse)
        {
                Filière = filière;
                MoyenneGénérale = moyenneGénérale;
            }


        public override string ToString() { return base.ToString()+ " "+ Filière+ " " 
            + MoyenneGénérale.ToString(); }

    }
}
