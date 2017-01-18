using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            int an;
            Console.WriteLine("Donnez l'année :");
            an = Int32.Parse(Console.ReadLine());
            if (bessextille(an)) Console.WriteLine("l'année{0} est bessextille", an);
            else Console.WriteLine("l'année{0} est normale", an);
            Console.ReadKey();
        }
        static bool bessextille(int année)
        {if(année%400==0 || (année%4==0 && année%100!=0)) return true;
         else return false;
        }
    }

}
