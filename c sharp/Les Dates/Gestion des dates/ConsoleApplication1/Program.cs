using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int an,m,j,i,a=0;
            Boolean X, Y;
            Console.Write("Entrer la valeur de lannée: ");
            an = Int32.Parse(Console.ReadLine());
            Console.Write("Entrer la valeur de mois: ");
            m = Int32.Parse(Console.ReadLine());
            Console.Write("Entrer la valeur de jour: ");
            j = Int32.Parse(Console.ReadLine());
            for (i = 1; i < an; i++)
            {
                if (Bessextille(i))
                    a = a + 366;
                else
                    a = a + 365;
            }
            X = i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12;
            Y = i == 4 || i == 6 || i == 9 || i == 11;
            for (i = 1; i < m; i++)
            {
                if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12)
                { a = a + 31; }
                else
                {
                    if (i == 4 || i == 6 || i == 9 || i == 11)
                        a = a + 30;
                    else
                    {
                        if (Bessextille(an) == true)
                            a = a + 29;
                        else
                            a = a + 28;
                    }
                }
            }

            a = a + j;

            Console.WriteLine(a);
            Console.ReadKey();

           // if (Bessextille(an))
              //  Console.WriteLine("L'année {0} est bessextille", an);
            //else
               // Console.WriteLine("L'année {0} est Non bessextille", an);
           // Console.ReadKey();
        }
        static bool Bessextille(int année)
    {
        if(année%400==0 || (année%4==0 && année%100!=0))
            return true;
        else 
           return false;
    }
    }
}
