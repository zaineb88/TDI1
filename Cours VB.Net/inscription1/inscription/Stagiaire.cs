using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inscription
{
    class Stagiaire
    {
        String nom;
        String prénom;
        String sexe;
        String option;
        int age;
        private string p;
        private string p_2;
        private string p_3;
        private string p_4;
        private string p_5;
        private int p_6;
        public String Nom
            
        {
            get { return nom; }
            set { nom = value; }
        }
       

        public String Prénom
        {
            get { return prénom; }
            set { prénom = value; }
        }
        

        public String Sexe
        {
            get { return sexe; }
            set { sexe = value; }
        }
       

        public String Option
        {
            get { return option; }
            set { option = value; }
        }
        

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Stagiaire(String nom, String prénom, String sexe, String option, int age)
        { this.Nom = nom; this.Prénom = prénom; this.Sexe = sexe; this.Option = option; this.Age = age; }

        public Stagiaire()
        {
            // TODO: Complete member initialization
        }

        public Stagiaire(string p, string p_2, string p_3, string p_4, string p_5, int p_6)
        {
            // TODO: Complete member initialization
            this.p = p;
            this.p_2 = p_2;
            this.p_3 = p_3;
            this.p_4 = p_4;
            this.p_5 = p_5;
            this.p_6 = p_6;
        }
    }
}
