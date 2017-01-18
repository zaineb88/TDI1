using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CabinetMedical
{
    class Cabinetmedical
    {
        List<Patient> patients;
        List<RendezVous> rendezvous;
        List<Visites> visites;
        internal List<RendezVous> Rendezvous
        {
            get { return rendezvous; }
            set { rendezvous = value; }
        }
        internal List<Visites> Visites
        {
            get { return visites; }
            set { visites = value; }
        }
        internal List<Patient> Patients
        {
            get { return patients; }
            set { patients = value; }
        }
        public Cabinetmedical()
        {
            patients=new List<Patient>();
            rendezvous=new List<RendezVous>();
            visites = new List<Visites>();
        }
        public void AjouterPatient(Patient p)
        {
            patients.Add(p);
        }
        public int patientExistant(String nom, String prénom)
        {
            int i;
            for (i = 0; i < patients.Count; i++)
            {
                if (nom == patients[i].Nom && prénom == patients[i].Prenom)
                { return patients[i].Code; }
            }
            return -1;
        }
        public void Ajouterrendezvous(RendezVous r)
        {
          if (rendezvous.Contains(r))
          { throw new exceptionMedcinOccupe("Medcin Occupé");}
          else
          { rendezvous.Add(r); }
        }
        public List<RendezVous> AfficherRDVdujour(DateTime jour)
        {
            List<RendezVous> resultat=new List<RendezVous>();
            resultat = null; int i;
            for (i = 0; i < rendezvous.Count; i++)
            {
                if (rendezvous[i].Daterendezvous.Date == jour.Date)
                {
                    resultat.Add(rendezvous[i]);
                }
            }
            return resultat;
        }
        public Patient rechrecheparCodePatient(int code)
        {
            int i;
            for (i = 0; i < patients.Count; i++)
            {      
                if (code == patients[i].Code)
                    return patients[i];
            }
            return null;
        }
        public List<Patient> patientAyantdesVisites()
        {
            List<Patient> p = new List<Patient>();
            TimeSpan duree; int i;DateTime aujourdhui=DateTime.Today;
            for (i = 0; i < visites.Count; i++)
            {
                duree = aujourdhui - visites[i].Datevisite.Date;
                if (duree.Days <= 7)
                { 
                    p.Add(rechrecheparCodePatient( visites[i].Codepatient)); 
                }
            }
            return p;
        }
       
        public void supprimer(int codepatient)
        {
            int i, k;
            patients.Remove(rechrecheparCodePatient(codepatient));
            for (i = 0; i < visites.Count; i++)
            {
                if (visites[i].Codepatient == codepatient)
                    visites.Remove(visites[i]);
            }
            for (k = 0; k < rendezvous.Count; k++)
            {
                if (rendezvous[k].Codepatient == codepatient)
                    rendezvous.Remove(rendezvous[k]);
            }
        }
        public void enregistrer_patients()
        {
            StreamWriter sr=new StreamWriter("D:\\medical.txt",false);
            int i;
            for (i = 0; i < patients.Count; i++)
            {sr.WriteLine(patients[i].ToString()); }
            sr.Close();
        }
        public void enregistrer_patients(string chemin)
        {
            StreamWriter sr = new StreamWriter(chemin, false);
            int i;
            for (i = 0; i < patients.Count; i++)
            { sr.WriteLine(patients[i].ToString()); }
            sr.Close();
        }
        public void Lire_patients()
        {
            StreamReader sr = new StreamReader("D:\\medical.txt");
            string ligne;
            string [] attribut;
            while(!sr.EndOfStream) 
            {
                ligne = sr.ReadLine();
                attribut=ligne.Split(':');
                AjouterPatient(new Patient(attribut[1],attribut[2],
                 DateTime.Parse(attribut[3]),attribut[4],attribut[5]
                 ,attribut[6]));
            }
            sr.Close();
        }
        public void Lire_patients(String chemin)
        {
            StreamReader sr = new StreamReader(chemin);
            string ligne;
            string[] attribut;
            while (!sr.EndOfStream)
            {
                ligne = sr.ReadLine();
                attribut = ligne.Split(':');
                AjouterPatient(new Patient(attribut[1], attribut[2],
                 DateTime.Parse(attribut[3]), attribut[4], attribut[5]
                 , attribut[6]));
            }
            sr.Close();
        }
        public void vider_List_Patient()
        {
            int i,nb=patients.Count;
            Patient.Compteur= 0;
            for (i = 0; i <nb ; i++)
            { patients.RemoveAt(0);
            }         
        }
    }
}
