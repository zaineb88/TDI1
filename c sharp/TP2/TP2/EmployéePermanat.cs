using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP2
{
    class EmployéePermanant:Employée,IEmployée
    {

        decimal SalaireDeBase;
        int HeuresSupplémentaires;
        DateTime DateEmbauche;

        public EmployéePermanant() : base() { }

        public EmployéePermanant(string cin, string nom, string prénom, DateTime dateDeNaissance, string adresse, string poste, string qualification, decimal salaireDeBase, int heuresSup, DateTime dateEmbauche)
            : base(cin, nom, prénom, dateDeNaissance, adresse, poste, qualification) {

                SalaireDeBase = salaireDeBase; HeuresSupplémentaires = heuresSup; DateEmbauche = dateEmbauche;
                this.MiseEnForme();
            }

        public decimal Revenu
        {
            get { return CalculSalaire(); }
        }

        public double Encienté(string UnitéDeTemps)
        {
           DateTime maintenant=DateTime.Today;
           TimeSpan durée=maintenant-DateEmbauche;
            
            
            switch(UnitéDeTemps){
                
                case "Jour"  : return durée.Days;
                case "Mois": return durée.Days / 30.0;
                case "Année": return durée.Days / 365.0;
                default: return  durée.Days / 365.0;
        }

        }

        public decimal CalculSalaire()
        {
            return SalaireDeBase + HeuresSupplémentaires * 200;  
        }

        public void MiseEnForme()
        {
            Nom=Nom.ToUpper();
            Prénom=Prénom.Substring(0, 1).ToUpper() + Prénom.Substring(1).ToLower();
        }
    }
}
