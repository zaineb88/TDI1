using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Itérateurs
{
    class Program
    {
        static void Main(string[] args)
        {  int i;
            Employée E = new Employée(1234, "Alami", "Rachid", "Mohamed", "Nabil", "Ahmed", "Rajae");
            Console.WriteLine("les enfant avec la boucle for");
            for (i = 0; i < E.NbrEnfants; i++) Console.WriteLine(E[i]);
            Console.WriteLine("les enfant avec la boucle foreach");
            foreach (string s in E) Console.WriteLine(s);
            
            Console.WriteLine("les enfant avec  while (E.MoveNext())");
            while (E.MoveNext()) Console.WriteLine(E.Current);
            Console.ReadKey();
        }
    }
}
