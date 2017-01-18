using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oriente_Objet.les_classes
{
    class Visites
    {
        DateTime DateVisite;
        DateTime HeureVisite;
        int Code;
        Double Montant;

     
        public DateTime DateVisite1
        {
            get { return DateVisite; }
            set { DateVisite = value; }
        }
        
       public DateTime HeureVisite1
        {
            get { return HeureVisite; }
            set { HeureVisite = value; }
        }

        public int Code1
        {
            get { return Code; }
            set { Code = value; }
        }
        
        public Double Montant1
        {
            get { return Montant; }
            set { Montant = value; }
        }

        //////////// question 2:b ////////:

        public Visites(DateTime DateVisite, DateTime HeureVisite)
        {
            this.DateVisite = DateVisite;
            this.HeureVisite = HeureVisite;
        }

      
       ///// question 2:C ///////////
      

        public Visites()
        {
            new Visites(DateTime.Today, DateTime.Now);
        }

        //////////// 2:d ////////////:

        public override string ToString()//accesseur 
        {
            return base.ToString()
                +"DateVisite "+DateVisite.ToShortDateString()
                +"HeureVisite "+HeureVisite.ToShortTimeString()
                +"Code "+Code.ToString()
                +"Montant "+Montant.ToString();
        }

    }
}
