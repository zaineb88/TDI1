using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_POO.Couche_Métier
{
    class DepacementNombrePartissipantException:Exception

    {
        public DepacementNombrePartissipantException(string msg)
            : base(msg)
        {
        }
        public string MessageDétaillé
        {
            get
            {
                return "Le nombre de chasseurs participants est limité à 20"
                    + Environment.NewLine + "Verifiez le nombre de chasseurs inscrits avant d'ajouter un nouveau participant";
            }
        }
    }
}
