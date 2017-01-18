
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class ExceptionMedecinOccupe : Exception
    {
        public ExceptionMedecinOccupe(string msg):base(msg)
        {}
       
    }
}
