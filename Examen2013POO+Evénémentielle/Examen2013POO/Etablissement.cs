using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examen2013POO
{
    public class Etablissement
    {
        private int CodeEtab;
        private string DésignationEtab;
        private int NombreStagiaires;

        public Etablissement(int CodeEtab, string DésignationEtab, int NombreStagiaires)
        {
            this.CodeEtab = CodeEtab;
            this.DésignationEtab = DésignationEtab;
            this.NombreStagiaires = NombreStagiaires;
        }

        public int codeetab
        {
            get { return CodeEtab; }
            set { CodeEtab = value; }
        }
        public string désignationetab
        {
            get { return DésignationEtab; }
            set { DésignationEtab = value; }
        }
        public int nombrestagiaires
        {
            get { return NombreStagiaires; }
            set 
            {
                if (value <= 0)
                {
                    throw new Exception("Le nombre doit être strictement supérieur à zéro");
                }
                else
                {
                    NombreStagiaires = value; 
                }
            }
        }

        public void AfficherInformation()
        {
            Console.WriteLine(this.CodeEtab + " " + this.DésignationEtab + " " + this.NombreStagiaires);
        }
    }
}
