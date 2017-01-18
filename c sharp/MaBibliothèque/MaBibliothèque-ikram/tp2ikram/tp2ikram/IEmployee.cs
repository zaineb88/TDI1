using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp2ikram
{
    interface IEmployee
    {
        decimal revenue { get; }
        double encienté(string UnitéDeTemps);
        decimal calculesalair();
        void MiseEnForme();
    }
}
