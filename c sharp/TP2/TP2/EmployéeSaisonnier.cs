using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP2
{
    class EmployéeSaisonier: Employée, IEmployée
    {
        decimal TauxHoraire;
        int NombreHueresTravaillées;
        DateTime DateDébutContrat;


        public EmployéeSaisonier() : base() { }
        public EmployéeSaisonier(string cin, string nom, string prénom, DateTime dateDeNaissance, string adresse, string poste, string qualification, decimal tauxHoraire, int nbrHTravaillé, DateTime dateDebutContrat)
            : base(cin, nom, prénom, dateDeNaissance, adresse, poste, qualification) {
                TauxHoraire = tauxHoraire; NombreHueresTravaillées = nbrHTravaillé; DateDébutContrat = dateDebutContrat;}
            

        public decimal Revenu
        {
            get { return CalculSalaire(); }
        }

        public double Encienté(string UnitéDeTemps)
        {
            DateTime maintenant = DateTime.Today;
            TimeSpan durée = maintenant - DateDébutContrat;


            switch (UnitéDeTemps)
            {

                case "Jour": return durée.Days;
                case "Mois": return durée.Days / 30.0;
                default: return durée.Days / 30.0;
            }
        }

        public decimal CalculSalaire()
        {
            return NombreHueresTravaillées * TauxHoraire;
        }

        public void MiseEnForme()
        {
            Nom = Nom.ToUpper();
            Prénom = Prénom.Substring(0, 1).ToUpper() + Prénom.Substring(1).ToLower();
        }
    }
}
