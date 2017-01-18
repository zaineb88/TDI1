using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Fichiers
{
    static class Program
    {

        static void Main(string[] args)
        {
            FileStream f = new FileStream("monfichier.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            StreamWriter sw = new StreamWriter(f);
            sw.WriteLine("C'est la ligne une");
            sw.WriteLine("C'est la ligne deux");
            //sw.Close();
           
           
            Console.WriteLine("... Lecture du fichier......");
            StreamReader sr = new StreamReader(f);
            string contenu = sr.ReadToEnd();
            Console.WriteLine(contenu);
            sr.Close();
            Console.ReadKey();
        }

    }
}
