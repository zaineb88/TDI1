using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_POO
{
    class DeplacementNombrePartissipantException:Exception
    {
        public DeplacementNombrePartissipantException(string msg) // msg= message
            : base(msg)
        { 
        }
        public string MessageDétaillé
        {
            get
            {
                return " le nombre de chasseurs participant est limité à 20"
                    + Environment.NewLine + "verifier le nombre de chasseurs inscrits avant d'ajouter un partissipant";
            }
        }
    }
}
     