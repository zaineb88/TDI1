using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CabinetMedical
{
    class RendezVous
    {
        DateTime daterendezvous;
        DateTime heurerendezvous;
        int codepatient;
        String observation;
        public RendezVous(DateTime daterendezvous, DateTime heurerendezvous, int codepatient)
        {
            this.daterendezvous = daterendezvous;
            this.heurerendezvous = heurerendezvous;
            this.codepatient = codepatient;
        }
        public DateTime Daterendezvous
        {
            get { return daterendezvous; }
            set { daterendezvous = value; }
        }
        public DateTime Heurerendezvous
        {
            get { return heurerendezvous; }
            set { heurerendezvous = value; }
        }
        public int Codepatient
        {
            get { return codepatient; }
            set { codepatient = value; }
        }
        public String Observation
        {
            get { return observation; }
            set { observation = value; }
        }
        public override string ToString()
        {
            return base.ToString() +
            "daterendezvous: " + daterendezvous.ToShortDateString() +
            "heurerendezvous: " + heurerendezvous.ToShortTimeString() +
            "codepatient: " + codepatient.ToString()+ "Observation: "+observation;
        }
    }
}
