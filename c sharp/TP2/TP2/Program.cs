using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployéePermanant E = new EmployéePermanant("LA12345", "BakALi", "KhalID", DateTime.Parse("12/05/1965"), "15 Avenue Med V", "Chef de Service production", "Cadre Sup", 12265.6m, 3, DateTime.Parse("12/04/2004"));
            Console.WriteLine(E.ToString()+Environment.NewLine + "Son revenu est: " + E.Revenu);
            E.Poste = "DirectEUR adjoint";
            E.Qualification = "IngénIUER";
            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine(E.ToString() + Environment.NewLine + "Son revenu est: " + E.Revenu);
            Console.ReadKey();
        }
    }
}
