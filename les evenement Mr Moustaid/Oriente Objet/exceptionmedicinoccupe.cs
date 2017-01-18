using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oriente_Objet
{
    class exceptionmedicinoccupe:Exception

    {
        public exceptionmedicinoccupe(string msg)
            : base(msg)
        { }
    }
}
