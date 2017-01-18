using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TariafMaha
{
    class ListSuive
    {
        List<Suivi> Ls;

        internal List<Suivi> Ls1
        {
            get { return Ls; }
            set { Ls = value; }
        }
        public ListSuive()
        { Ls = new List<Suivi>(); }
    }
}
