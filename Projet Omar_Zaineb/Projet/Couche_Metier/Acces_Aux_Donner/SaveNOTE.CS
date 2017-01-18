using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using WindowsFormApplication1.Couche_Metier;
using System.IO;
namespace WindowsFormApplication1.Acces_Aux_Donner
{ 
[Serializable ]
    class SaveNOTE
    {
        public static void SauveNote(List<Note_Eléve> LVes)
        {

            BinaryFormatter BF = new BinaryFormatter();
            FileStream FS = new FileStream("LesNoteEléve.txt", FileMode.OpenOrCreate, FileAccess.Write);
      
            BF.Serialize(FS, LVes);
            FS.Close();
        }


        public static List<Note_Eléve> LoadNoteEléve()
        {
            List<Note_Eléve> LScs = new List<Note_Eléve>();
            if (File.Exists("LesNoteEléve.txt"))
            {
                BinaryFormatter BF = new BinaryFormatter();
                FileStream FS = new FileStream("LesNoteEléve.txt", FileMode.Open, FileAccess.Read);
                LScs = (List<Note_Eléve>)BF.Deserialize(FS);
                FS.Close();
            }
            return LScs;
        }
    }
}
