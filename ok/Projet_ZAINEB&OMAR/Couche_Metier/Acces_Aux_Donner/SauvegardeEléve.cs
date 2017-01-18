using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using WindowsFormApplication1.Couche_Metier;



namespace WindowsFormApplication1.Acces_Aux_Donner
{
    [Serializable]
    class SauvegardeEléve
    {
        public static void savedeEléve(List<Eléve> L)
        {
            BinaryFormatter BF = new BinaryFormatter();
            FileStream FS = new FileStream("LesEléve.txt", FileMode.OpenOrCreate, FileAccess.Write);
            BF.Serialize(FS, L);
            FS.Close();
        }
        public static List<Eléve> LoadEléve()
        {
            List<Eléve> L = new List<Eléve>();

            if (File.Exists("LesEléve.txt"))
            {
                BinaryFormatter BF = new BinaryFormatter();
                FileStream FS = new FileStream("LesEléve.txt", FileMode.Open, FileAccess.Read);
                L = (List<Eléve>)BF.Deserialize(FS);
                FS.Close();
            }

            return L;
        }


    }
}
