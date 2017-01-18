using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Projet_POO.Couche_Métier;
using System.IO;

namespace Projet_POO.Acces_aux_données
{
    class SauvgardeChasseurs
    {
        public static void SaveChasseurs(List<Chasseur> L)
        {
            BinaryFormatter BF = new BinaryFormatter();
            FileStream FS = new FileStream("LesChasseurs.txt", FileMode.OpenOrCreate, FileAccess.Write);
            BF.Serialize(FS, L);
            FS.Close();
        }


        public static List<Chasseur> LoadChasseurs()
        {
            List<Chasseur> L = new List<Chasseur>();
           
            if (File.Exists("LesChasseurs.txt"))
            {   
                BinaryFormatter BF = new BinaryFormatter();
                FileStream FS = new FileStream("LesChasseurs.txt", FileMode.Open, FileAccess.Read);
                L = (List<Chasseur>)BF.Deserialize(FS);
                FS.Close();
            }
                        
            return L;
        }
    }
}
