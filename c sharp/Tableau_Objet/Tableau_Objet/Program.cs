using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Specialized;


namespace Tableau_Objet
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList T = new SortedList();
           T.Add("F",new Empoyee("LA5693", "Alami", "walid", DateTime.Parse("19/07/1974"), 7500));
           Empoyee E = new Empoyee("LA658", "Khamlichi", "Ahmed", DateTime.Parse("19/08/1999"), 12000);
           T.Add("B",E);
           T.Add("f","Salut");
           T.Add("C",new Empoyee("K569897", "Bakali", "Mourad", DateTime.Parse("25/09/2008"), 14000));
           
           T.Add("A",66);
           //ArrayList S = ArrayList.Repeat(E, 20);
           //IEnumerator X = T.GetEnumerator();
           //while (X.MoveNext()) Console.WriteLine(X.Current.ToString());
           //Console.WriteLine(T.Count);
           foreach (Object p in T.Keys) Console.WriteLine(T[p]);
           Console.WriteLine("----------------");
           for (int i = 0; i < T.Count; i++) Console.WriteLine(T.get(i));
          
         
           
            Console.ReadKey();

        
        }
    }
}
