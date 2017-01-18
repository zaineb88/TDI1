using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_Maha_Et_Aouatif_TARIAF.Couche_Metier
{
    class OccupeExcption:Exception
    {
        public OccupeExcption(string msg):base(msg) {   }
    }
}
