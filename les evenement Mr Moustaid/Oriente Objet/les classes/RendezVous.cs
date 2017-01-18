
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oriente_Objet.les_classes
{
    class RendezVous
    {
        DateTime Daterendezvous;
        DateTime Heurerendezvous;
        int Codepatient;
        string Observation;

        public RendezVous(DateTime Daterendezvous, DateTime Heurerendezvous, int Codepatient, string Observation)
        {
            this.Daterendezvous = Daterendezvous;
            this.Heurerendezvous = Heurerendezvous;
            this.Codepatient = Codepatient;
        }
        public DateTime Daterendezvous1
        {
            get { return Daterendezvous; }
            set { Daterendezvous = value; }
        }
        public DateTime Heurerendezvous1
        {
            get { return Heurerendezvous; }
            set { Heurerendezvous = value; }
        }
        public int Codepatient1
        {
            get { return Codepatient; }
            set { Codepatient = value; }
        }
        public string Observation1
        {
            get { return Observation; }
            set { Observation = value; }
        }
        public override string ToString()
        {

            return base.ToString() +
                "Daterendezvous:" + Daterendezvous.ToShortDateString() + "Heurerendezvous:" + Heurerendezvous.ToShortDateString() + "Codepatient:" + Codepatient.ToString() + "Observation:" + Observation;

        }


    }
}
