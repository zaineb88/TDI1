using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oriente_Objet.les_classes
{
    class Patient
    {
        static int compteur=0;// dernaha 3la 7sab lcode 7it metlob fi so2al yeb9a yetzad 1 b 1 
        int Code;
        string Nom;
        string Prénom;
        DateTime DateDeNaissance;
        string Adresse;
        int Tél;
        string EMail;
        private string p;
        private string p_2;
        private DateTime dateTime;
        private string p_3;
        private string p_4;
        private string p_5;

  
       public int Code1
        {
            get { return Code; }
           // set { Code = value; } // pour non modiffier   
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
        public DateTime DateDeNaissance1
        {
            get { return DateDeNaissance; }
            set { DateDeNaissance = value; }
        }
        public string Adresse1
        {
            get { return Adresse; }
            set { Adresse = value; }
        }
        public int Tél1
        {
            get { return Tél; }
            set { Tél = value; }
        }
        public string EMail1
        {
            get { return EMail; }
            set { EMail = value; }
        }

        ///////////////// question b ////////////////////
        public Patient(string Nom, string Prénom) // constructeur
        {
            compteur++;
            Code = compteur;
            this.Nom = Nom;
            this.Prénom = Prénom;
        }
        ///////////////// question c ////////////////////
        public Patient(string Nom, string Prénom,DateTime DateDeNaissance, string Adresse, int Tél,string EMail)
        {
            compteur++;
            Code = compteur;
            this.Nom = Nom;
            this.Prénom = Prénom;
            this.DateDeNaissance = DateDeNaissance;
            this.Adresse = Adresse;
            this.Tél = Tél;
            this.EMail = EMail;
        }

        public Patient(string p, string p_2, DateTime dateTime, string p_3, string p_4, string p_5)
        {
            // TODO: Complete member initialization
            this.p = p;
            this.p_2 = p_2;
            this.dateTime = dateTime;
            this.p_3 = p_3;
            this.p_4 = p_4;
            this.p_5 = p_5;
        }
        //////////////// question d //////////////// 

        public override string ToString() // accesseur // afficher
        {
            return base.ToString()+"Code : "+Code+"+Nom : "+Nom
                +"Prénom : "+Prénom
                +"DateDeNaissance :"+DateDeNaissance.ToShortTimeString()
                +"Adresse :"+Adresse+"Tél :"+Tél;
        }

        
        
    }
}
