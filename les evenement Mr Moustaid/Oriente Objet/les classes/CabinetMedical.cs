using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;// zidnaha 7it khadimna StreamWriter

namespace Oriente_Objet.les_classes
{
    class CabinetMedical
    {
        List<Patient> patients;

        internal List<Patient> Patients
        {
            get { return patients; }
            set { patients = value; }
        }
        List<RendezVous> rendezvous;
        List<Visites> visites;

        public CabinetMedical() // constricteur // wakha mametlobch f so2al kandiroh 7it rah kayet7taj
        { patients = new List<Patient>();
        rendezvous = new List<RendezVous>();
        visites = new List<Visites>();
        }
        // question b //

        public void AjouterPatient(Patient p)
        {
            patients.Add(p);
        }
        // question c //
        public int patientExistant  (string nom, String prenom)
        {
            int i;
            for (i = 0; i < patients.Count; i++)
            {
                if (nom == patients[i].Nom1 && prenom == patients[i].Prénom1)
                { return patients[i].Code1; }

            } 
            return -1;
        }
        public void Ajouterrendezvous(RendezVous r)
        {
            if (rendezvous.Contains(r))
            { throw new exceptionmedicinoccupe("medcin occupe"); }
            else
            {
                rendezvous.Add(r);
            }
        }

        public List<RendezVous> AfficherRDVdujour(DateTime jour)
        {
            List<RendezVous> resultat = new List<RendezVous>();
            resultat = null; int i = 0;
            for (i = 0; i < rendezvous.Count; i++)
            { 
               if(rendezvous[i].Daterendezvous1.Date == jour.Date)
               {
                   resultat.Add(rendezvous[i]);
               }
            }
            return resultat;
        }
        public Patient rechercheparCodaPatient(int code)
        {
            int i;
            for (i = 0; i < patients.Count; i++)
            {   
                if (code == patients[i].Code1)
                    return patients[i];
            }
            return null;
        }
        public List<Patient> patientAyantdesVsisites()
        {
            List<Patient> p = new List<Patient>();
            p=null;
            TimeSpan duree; int i;DateTime aujourdhui=DateTime.Today;
            for (i = 0; i < visites.Count; i++)
            {
                duree = aujourdhui - visites[i].DateVisite1.Date;
                if (duree.Days <= 7)
                {
                    p.Add(rechercheparCodaPatient(visites[i].Code1));
                }
            }

            return p;
        }
        public Visites rechercheVisite(int codepatient)
        {
            int i;
            for (i = 0; i < visites.Count; i++)
            {
                if (visites[i].Code1 == codepatient)
                {
                    return visites[i];
                }
            }
            return null;

        }

        public void supprimer(int codepatient)
        {
            int i, k;
            patients.Remove(rechercheparCodaPatient(codepatient));
            for (i = 0; i < visites.Count; i++)
            {
                if (visites[i].Code1 == codepatient)
                    visites.Remove(visites[i]);
            }

            for (k = 0; k < rendezvous.Count; k++)
            {
                if (rendezvous[i].Codepatient1 == codepatient)
                    rendezvous.Remove(rendezvous[i]);
            }
        }
        public void enregistrer_patient()
        { 
         StreamWriter sr= new StreamWriter("D:\\medical.txt",false);// 3la hadi zidna lfo9 using system IO
         int i;
         for (i = 0; i < patients.Count; i++)
         { sr.WriteLine(patients[i].ToString()); }
         sr.Close();
        }
    }
}