using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WindowsFormsApplication1
{
    class CabinetMedical
    {
        List<Classe_Patient> LP;
        List<Visites> LV;
        List<RendezVous> LRV;

        internal List<RendezVous> LRV1
        {
            get { return LRV; }
            set { LRV = value; }
        }

        internal List<Classe_Patient> LP1
        {
            get { return LP; }
            set { LP = value; }
        }
        internal List<Visites> LV1
        {
            get { return LV; }
            set { LV = value; }
        }
        public void AjouterPatient(Classe_Patient CPatient)
        {
            LP.Add(CPatient);
        }

        public CabinetMedical()
        {
         LP=new List<Classe_Patient>();
        LV=new List<Visites>();
        LRV=new List<RendezVous>();
        }
        public int PatientExitant(string nom, string prenom)
        {
            int CodPatie=-1;
            for (int i = 0; i < LP.Count; i++)
            {
                if(LP[i].Nom==nom && LP[i].Prénom==prenom)
                {
                    CodPatie=LP[i].CodePatient;
                    break;
                }
            }
          return CodPatie;    
        }
         public void AjouterRDV(RendezVous NouveauRDV)
        {
            if (LRV.Contains(NouveauRDV))
            { throw new ExceptionMedecinOccupe("Medcin occupe"); }
            else
            { LRV.Add(NouveauRDV); }
        }
         //public void AjouterVis(Visites NouveauVis)
         //{
         //    if (LV.Contains(NouveauVis))
         //    { throw new ExceptionMedecinOccupe("Medcin occupe"); }
         //    else
         //    { LV.Add(NouveauVis); }
         //}
         public List<RendezVous> AfficherRDVDuJour(DateTime Jour)
         {
            
             List<RendezVous> RDVMemeJour = new List<RendezVous>();
             RDVMemeJour =null;
             for (int i = 0; i < LRV.Count; i++)
             {
                 if (LRV[i].DateRendezVous.Date == Jour.Date)
                 { RDVMemeJour.Add(LRV[i]); }
             }
            
            return RDVMemeJour;
         }

        
         public List<Classe_Patient> PatientAyantDesVisites()
         {
             DateTime aujourdhui = DateTime.Today;
             TimeSpan durée; int i;
             List<Classe_Patient> p = new List<Classe_Patient>();
             //p = null;
             for (i = 0; i < LV.Count; i++)
             {
                 durée = aujourdhui - LV[i].DateVisites.Date;
                 if (durée.Days <= 7)
                 { p.Add(RechercherCodePatient(LV[i].CodePatient)); }
             }
             return p;
         }
         public void SupprimerPatient(int CodePatientSupprimer)
         {
             LP.Remove(RechercherCodePatient(CodePatientSupprimer));
             for (int i = 0; i < LRV.Count; i++)
             {
                 if (LRV[i].CodePatient == CodePatientSupprimer)
                 { LRV.Remove(CodePatientRDV(CodePatientSupprimer)); }
             }
             for (int i = 0; i < LV.Count; i++)
             { LV.Remove(CodePatientLV(CodePatientSupprimer)); }
         }
         public RendezVous CodePatientRDV(int code)
         {
             int i;
             for (i = 0; i < LRV.Count; i++)
             {
                 if (LRV[i].CodePatient == code)
                 { return LRV[i]; }
             }
             return null;
         }
         public Visites CodePatientLV(int code)
         {
             int i;
             for (i = 0; i < LV.Count; i++)
             {
                 if (LV[i].CodePatient == code)
                 { return LV[i]; }
             }
             return null;
         }
         public  Classe_Patient RechercherCodePatient(int code)
         {
             int i;
             for (i = 0; i < LP.Count; i++)
             {
                 if (LP[i].CodePatient == code)
                 { return LP[i]; }
             }
             return null;
         }
         public void Enregister_patient()
         {
             StreamWriter Sr = new StreamWriter("G:\\Cabinetmedical.txt",false);
             int i;
             for (i = 0; i < LP.Count; i++)
             { 
                 Sr.WriteLine(LP[i].ToString()); 
             }
             Sr.Close();
         }
        // La surcharge des docs;
         public void Enregister_patient(string chemin)
         {
             StreamWriter Sr = new StreamWriter(chemin, false);
             int i;
             for (i = 0; i < LP.Count; i++)
             {
                 Sr.WriteLine(LP[i].ToString());
             }
             Sr.Close();
         }
        public void Lire_patient()
        {
            StreamReader Sr = new StreamReader("D:\\Cabinetmedical.txt");
            string ligne;
            string[] Attribut;
            while( !Sr.EndOfStream)
            {
                ligne =Sr.ReadLine();
                Attribut = ligne.Split(':');
                AjouterPatient(new Classe_Patient(Attribut[1],Attribut[2],DateTime.Parse(Attribut[3]),Attribut[4],Attribut[5],Attribut[6]));
            }
            Sr.Close();
        }
        public void Lire_patient(string chemin)
        {
            StreamReader Sr = new StreamReader(chemin);
            string ligne;
            string[] Attribut;
            while (!Sr.EndOfStream)
            {
                ligne = Sr.ReadLine();
                Attribut = ligne.Split(':');
                AjouterPatient(new Classe_Patient(Attribut[1], Attribut[2], DateTime.Parse(Attribut[3]), Attribut[4], Attribut[5], Attribut[6]));
            }
            Sr.Close();
        }
        public void Vider_Lire_patient()
        {
            int i,nb = LP.Count;
            Classe_Patient.Compteur = 0;
            for (i = 0; i <nb; i++)
            {
                LP.Remove(LP[0]);
            }
        }
        public void Enregister_Visite()
        {
            StreamWriter Sr = new StreamWriter("G:\\ListeVisite.txt", false);
            int i;
            for (i = 0; i < LV.Count; i++)
            {
                Sr.WriteLine(LV[i].ToString());
            }
            Sr.Close();
        }
        public void Enregister_Visite(string chemin)
        {
            StreamWriter Sr = new StreamWriter(chemin, false);
            int i;
            for (i = 0; i < LV.Count; i++)
            {
                Sr.WriteLine(LV[i].ToString());
            }
            Sr.Close();
        }
        public void Lire_Visite()
        {
            StreamReader Sr = new StreamReader("G:\\ListeVisite.txt");
            string ligne;
            string[] Attribut;
            Visites v;
            while (!Sr.EndOfStream)
            {
                ligne = Sr.ReadLine();
                Attribut = ligne.Split(';');
                v=new Visites();
                v.DateVisites=DateTime.Parse(Attribut[0]);
                v.HeureVisites=DateTime.Parse(Attribut[1]);
                v.CodePatient=int.Parse(Attribut[2]);
                v.MantantPayé=Double.Parse(Attribut[3]);
                LV.Add(v);
            }
            Sr.Close();
        }
        
        public void Lire_visite(string chemin)
        {
            StreamReader Sr = new StreamReader(chemin);
            string ligne;
            string[] Attribut;
            while (!Sr.EndOfStream)
            {
                ligne = Sr.ReadLine();
                Attribut = ligne.Split(';');
               LV.Add(new Visites(DateTime.Parse(Attribut[0]),DateTime.Parse(Attribut[1]),int.Parse(Attribut[2]),double.Parse(Attribut[3])));
            }
            Sr.Close();
        }
        
        public void Vider_Lire_visite()
        {
            int i, nb = LV.Count;
            for (i = 0; i < nb; i++)
            {
                LV.Remove(LV[0]);
            }
        }
    }
}

