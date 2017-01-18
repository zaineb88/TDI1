using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class RendezVous
    {
        DateTime _DateRendezVous;
        DateTime _HeureRendezVous;
        int _CodePatient;
        string _Observation;

        public RendezVous()
        {
            
        }

        public RendezVous(DateTime daterendezvous, DateTime heuresrendezvous, int codepatient)
        { _DateRendezVous = daterendezvous;
        _HeureRendezVous = heuresrendezvous;
        _CodePatient = codepatient;
        }
        public DateTime DateRendezVous
        {
            get { return _DateRendezVous; }
            set { _DateRendezVous = value; }
        }
        public DateTime HeureRendezVous
        {
            get { return _HeureRendezVous; }
            set { _HeureRendezVous = value; }
        }
        public int CodePatient
        {
            get { return _CodePatient; }
            set { _CodePatient = value; }
        }
        public string Observation
        {
            get { return _Observation; }
            set { _Observation = value; }
        }
        public override string ToString()
        {
            return _DateRendezVous.ToShortDateString() + " " + _HeureRendezVous.ToShortTimeString() + " " + _CodePatient + " " + _Observation;
        }
    }
}
