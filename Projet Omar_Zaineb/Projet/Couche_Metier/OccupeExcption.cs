using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormApplication1.Couche_Metier
{
    class OccupeExcption:Exception
    {
        public OccupeExcption(string msg):base(msg) {   }
    }
}
