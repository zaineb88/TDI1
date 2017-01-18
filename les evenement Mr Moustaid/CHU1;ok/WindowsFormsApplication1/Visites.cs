using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Visites
    {
             DateTime _DateVisites;
             DateTime _HeureVisites;
             int _CodePatient;
             Double _MantantPayé;



public DateTime DateVisites
{
  get { return _DateVisites; }
  set { _DateVisites = value; }
}
   

public DateTime HeureVisites
{
  get { return _HeureVisites; }
  set { _HeureVisites = value; }
}
        
public int CodePatient
{
  get { return _CodePatient; }
  set { _CodePatient = value; }
}
        
public Double MantantPayé
{
  get { return _MantantPayé; }
  set { _MantantPayé = value; }
}

        public Visites(DateTime datevisites, DateTime heurevisites) 
        {
            _DateVisites = datevisites;
            _HeureVisites = heurevisites;

        }
        public Visites(DateTime datevisites, DateTime heurevisites,int codepatient,Double montant)
        {
            _DateVisites = datevisites;
            _HeureVisites = heurevisites;
            _CodePatient = codepatient;
            _MantantPayé = montant;

        }

        public Visites()
        {
            new Visites(DateTime.Today, DateTime.Now);


        }




       public override string  ToString()
{
    return _DateVisites.ToShortDateString() + " ; " + _HeureVisites.ToShortTimeString() + " ; " + _CodePatient.ToString() + " ; " + _MantantPayé.ToString();
}
       
       
    }
}

   
