using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examen2013POO
{
    public class Prometric : CentreExamen
    {
        private int NombrePostes;
        private string AdministrateurPrometric;

        public Prometric(int CodeCentre, Etablissement EtablissementDuCentre, int NombrePostes, string Nom, string Prénom)
            :base(CodeCentre, EtablissementDuCentre)
        {
            this.NombrePostes = NombrePostes;
            this.AdministrateurPrometric = Nom + " - ";
            this.AdministrateurPrometric += Prénom;
        }

        public int nombrepostes
        {
            get { return NombrePostes; }
            set { NombrePostes = value; }
        }
        public string administrateurprometric
        {
            get { return AdministrateurPrometric; }
            set 
            { 
                if (AdministrateurPrometric.Contains("-"))
                AdministrateurPrometric = value;
                else
                    throw new Exception("Le nom est le prénom doivent êtres séparés par un Tiret.");
            }
        }

        public override void AfficherInformation()
        {
            base.AfficherInformation();
            Console.WriteLine("\n" + this.NombrePostes + " " + this.AdministrateurPrometric);
        }


    }

}
