using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP2
{
    interface IEmployée
    {
        decimal Revenu { get; }

        double Encienté(string UnitéDeTemps);

        decimal CalculSalaire();
        
        void MiseEnForme();

    }
}
