using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Itérateurs
{
    class Employée:IEnumerator
    {
        int index = -1;
        int _Matricule;
        string _Nom;
        string _Prénom;
        List<string> Enfants;

        public Employée(int matricule, string nom, string prénom, params string[] enfs) {
            _Matricule = matricule;
            _Nom = nom;
            _Prénom = prénom;
            Enfants=new List<string>();
            Enfants.AddRange(enfs);// foreach(string s in enfs) Enfants.Add(s);
        }

        public string this[int i]
        {
            get { return Enfants[i]; }
            set { Enfants[i] = value; }
        }

        public int NbrEnfants { get { return Enfants.Count; } }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (string s in Enfants) yield return s;
        }


        public string Current
        {
            get { return this[index]; }
        }

        public void Dispose()
        {
            
        }

        object System.Collections.IEnumerator.Current
        {
            get { return this[index]; }
        }

        public bool MoveNext()
        {
            return ++index<this.NbrEnfants;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
