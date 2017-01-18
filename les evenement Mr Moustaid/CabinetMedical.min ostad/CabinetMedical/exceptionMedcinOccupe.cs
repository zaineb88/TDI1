using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CabinetMedical
{
    class exceptionMedcinOccupe:Exception
    {
        public exceptionMedcinOccupe(String msg):base(msg)
        {}
    }
}
