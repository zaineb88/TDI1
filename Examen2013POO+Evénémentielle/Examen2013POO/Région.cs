using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examen2013POO
{
    public class Région
    {
        private int CodeRégion;
        private string DésignationRégion;
        private int NombreEtab = 0;

        public List<Etablissement> le;

        public Région(int CodeRégion, string DésignationRégion)
        {
            this.NombreEtab = 0;
            this.CodeRégion = CodeRégion;
            this.DésignationRégion = DésignationRégion;
            this.le = new List<Etablissement>();
        }

        public int coderégion
        {
            get { return CodeRégion; }
            set { CodeRégion = value; }
        }
        public string désignationrégion
        {
            get { return DésignationRégion; }
            set { DésignationRégion = value; }
        }
        public int nombreetab
        {
            get { return NombreEtab; }
        }

        public void AjouterEtablissement(Etablissement e)
        {
            this.le.Add(e);
            this.NombreEtab++;
        }
    }
}
