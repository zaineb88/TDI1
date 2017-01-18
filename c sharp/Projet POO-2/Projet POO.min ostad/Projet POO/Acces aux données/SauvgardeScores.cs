using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using Projet_POO.Couche_Métier;
using System.IO;

namespace Projet_POO.Acces_aux_données
{
    class SauvgardeScores
    {
        public static void SaveScores(List<Score> LScs)
        {

            BinaryFormatter BF = new BinaryFormatter();
            FileStream FS = new FileStream("LesScores.txt", FileMode.OpenOrCreate, FileAccess.Write);
            BF.Serialize(FS, LScs);
            FS.Close();
        }


        public static List<Score> LoadScores()
        {
            List<Score> LScs = new List<Score>();
            if(File.Exists("LesScores.txt"))
            {
            BinaryFormatter BF = new BinaryFormatter();
            FileStream FS = new FileStream("LesScores.txt", FileMode.Open, FileAccess.Read);
            LScs = (List<Score>)BF.Deserialize(FS);
            FS.Close();
            }
            return LScs;
        }
    }
}
