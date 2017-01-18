using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examen2013POO
{
    public class CentreExamen
    {
        private int CodeCentre;
        public Etablissement EtablissementDuCentre;

        public CentreExamen(int CodeCentre, Etablissement EtablissementDuCentre)
        {
            this.CodeCentre = CodeCentre;
            this.EtablissementDuCentre = EtablissementDuCentre;
        }

        public int codecentre
        {
            get { return CodeCentre; }
            set { CodeCentre = value; }
        }

        public virtual void AfficherInformation()
        {
            Console.WriteLine(this.CodeCentre + " \n" + this.EtablissementDuCentre.codeetab + " " + this.EtablissementDuCentre.désignationetab + " " + this.EtablissementDuCentre.nombrestagiaires);
        }
    }
}
