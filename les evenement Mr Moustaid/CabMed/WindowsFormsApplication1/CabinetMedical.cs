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

        internal List<Classe_Patient> LP1
        {
            get { return LP; }
            set { LP = value; }
        }
        List<Visites> LV;
        List<RendezVous> LRV;

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
             p = null;
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
         public Classe_Patient RechercherCodePatient(int code)
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
             StreamWriter Sr = new StreamWriter("D:\\Cabinetmedical.txt",false);
             int i;
             for (i = 0; i < LP.Count; i++)
             { 
                 Sr.WriteLine(LP[i].ToString()); 
             }
             Sr.Close();

         }
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
             int i=0;
             string lignes;
             string[] attribut;
             while(!Sr.EndOfStream)
             {
                 lignes = Sr.ReadLine();
                 attribut = lignes.Split(':');
                 AjouterPatient(new Classe_Patient(attribut[i], attribut[2],
                  DateTime.Parse(attribut[3]), attribut[4], attribut[5], attribut[6]));
                 i++;
             }
             Sr.Close();

         }
         public void Lire_patient(string chemin)
         {
             StreamReader Sr = new StreamReader(chemin);
             int i = 0;
             string lignes;
             string[] attribut;
             while (!Sr.EndOfStream)
             {
                 lignes = Sr.ReadLine();
                 attribut = lignes.Split(':');
                 AjouterPatient(new Classe_Patient(attribut[i], attribut[2],
                  DateTime.Parse(attribut[3]), attribut[4], attribut[5], attribut[6]));
                 i++;
             }
             Sr.Close();

         }
    }
}

