using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Voyage
    {
        int numero=1;
        string nom_prenom;
        DateTime date;
        int duree;
        string Ville;
        string matricule;

        public string Matricule
        {
            get { return matricule; }
            set { matricule = value; }
        }

        public string Ville1
        {
            get { return Ville; }
            set { Ville = value; }
        }

        public int Duree
        {
            get { return duree; }
            set { duree = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Nom_prenom
        {
            get { return nom_prenom; }
            set { nom_prenom = value; }
        }

        public int Numero
        {
            get { return numero; }
           
        }
        public Voyage() { numero++; }
        public Voyage(int num, string nomprenom, DateTime datedebut, int dure, string vill, string matricul)
            : this()
        {
            numero = num;
            nom_prenom = nomprenom;
            date = datedebut;
            duree = dure;
            Ville = vill;
            matricule = matricul;
        
        }
        public override string ToString()
        {
            return numero + ";" + nom_prenom + ";" + date.ToShortDateString() + ";" + duree + ";" + Ville + ";" + matricule;
        }
    }
}
