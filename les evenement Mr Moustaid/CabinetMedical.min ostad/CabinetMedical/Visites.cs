using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CabinetMedical
{
    class Visites
    {
        DateTime datevisite;
        DateTime heureVisite;  
        int codepatient;
        Double montantpaye;
        public DateTime Datevisite
        {
            get { return datevisite; }
            set { datevisite = value; }
        }
        public DateTime HeureVisite
        {
            get { return heureVisite; }
            set { heureVisite = value; }
        }
        public int Codepatient
        {
            get { return codepatient; }
            set { codepatient = value; }
        }
        public Double Montantpaye
        {
            get { return montantpaye; }
            set { montantpaye = value; }
        }
        public Visites(DateTime datevisite, DateTime heureVisite)
        {
            this.datevisite = datevisite;
            this.heureVisite = heureVisite;
        }
        public Visites()
        {
            new Visites(DateTime.Today, DateTime.Now);
        }
        public override string ToString()
        {
            return base.ToString()
           +"datevisite: "+datevisite.ToShortDateString()+
           "heureVisite : "+heureVisite.ToShortTimeString()
           + "codepatient : "+ codepatient.ToString()
         + "montantpayé: "+montantpaye.ToString();
        }
       
    }
}
