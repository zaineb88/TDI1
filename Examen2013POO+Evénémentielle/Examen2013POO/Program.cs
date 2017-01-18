using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace Examen2013POO
{
    [Serializable()]
    public class Program
    {
        public static List<Région> lr = new List<Région>();
        public static List<Prometric> lp = new List<Prometric>();

        public static void AfficherEtablissement(Région e)
        {
            bool trouvé = false;
            for (int i = 0; i < lr.Count; i++)
            {
                for (int j = 0; j < lr[i].le.Count; j++)
                {
                    if (e.coderégion == lr[i].le[j].codeetab)
                    {
                        trouvé = true;
                        Console.WriteLine("Le code de la région est : " + lr[i].coderégion);
                        Console.WriteLine("La désignation de la région est : " + lr[i].désignationrégion + "\n");
                        lr[i].le[j].AfficherInformation();
                        break;
                    }
                }
            }
            if (trouvé == false)
            {
                Console.WriteLine("Aucune région correspondante.");
            }
        }

        public static void InformationPrometric(Etablissement e)
        {
            bool trouvé = false;
            for (int i = 0; i < lp.Count; i++)
            {
                if (e.codeetab == lp[i].EtablissementDuCentre.codeetab)
                {
                    trouvé = true;
                    Console.WriteLine("Nom & prénom : " + lp[i].administrateurprometric);
                    Console.WriteLine("Nombre de postes : " + lp[i].nombrepostes);
                    break;
                }
            }
            if (trouvé == false)
            {
                Console.WriteLine("Le centre n'existe pas.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1- Récuperer les données.");
            Console.WriteLine("2- Ajouter une région à la liste des régions.");
            Console.WriteLine("3- Ajouter un centre prometric à la liste des centres prometrics.");
            Console.WriteLine("4- Ajouter un établissement à une région de la liste des régions.");
            Console.WriteLine("5- Sauvegarder les données.");
            Console.WriteLine("6- Rechercher et afficher les établissements d'une région donnée.");
            Console.WriteLine("7- Rechercher et afficher les informations du centre prometric d'un établissement d'une région donnée.");
            Console.WriteLine("8- FIN");
            Console.WriteLine("Entrez votre choix : ");
            int choix = Convert.ToInt32(Console.ReadLine());
            switch (choix)
            {
                case 1 :
                    StreamReader srD = new StreamReader("Sérialisation Liste Région.xml");
                XmlSerializer xsD = new XmlSerializer(typeof(List<Région>));

                        object liste = xsD.Deserialize(srD);
                        
                        foreach (Région xx in liste as List<Région>)
                        {
                            Console.WriteLine(xx.ToString());
                        }
                    srD.Close();
                    StreamReader srD2 = new StreamReader("Sérialisation Liste Prometric.xml");
                XmlSerializer xsD2 = new XmlSerializer(typeof(List<Prometric>));

                        object liste2 = xsD2.Deserialize(srD2);
                        
                        foreach (Prometric xx in liste as List<Prometric>)
                        {
                            Console.WriteLine(xx.ToString());
                        }
                    srD2.Close();
                    
                    break;

                case 2 :
                    Console.WriteLine("Entrez le code de la région :");
                    int coderégion = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Entrez la désignation de la région :");
                    string désignationrégion = Console.ReadLine();
                    Console.WriteLine("Le nombre d'établissements dans cette région et par défaut égale à 0 :");
                    Région r = new Région(coderégion, désignationrégion);
                    lr.Add(r);
                    Console.WriteLine("Région ajoutée avec succés.");
                    break;

                case 3:
                    break;

                case 4:
                    Console.WriteLine("Entrez le code de l'établissement :");
                    int codeétab = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Entrez la désignation de l'établissement :");
                    string désignationétab = Console.ReadLine();
                    Console.WriteLine("Le nombre de stagiaires dans cet établissement :");
                    int nbrstagiaireétab = Convert.ToInt32(Console.ReadLine());
                    Etablissement e = new Etablissement(codeétab, désignationétab, nbrstagiaireétab);
                    Console.WriteLine("Entrez le code de la région où vous voulez ajouter cet établissement :");
                    int coderégionAjout = Convert.ToInt32(Console.ReadLine());
                    foreach (Région x in lr)
                    {
                        if (x.coderégion == coderégionAjout)
                        {
                            x.AjouterEtablissement(e);
                        }
                    }
                    Console.WriteLine("Etablissement ajoutée avec succés.");
                    break;

                case 5:
                    Console.WriteLine("*** Serialisation XMLSerializer ***\n");
                StreamWriter sw = new StreamWriter("Sérialisation Liste Région.xml");
                XmlSerializer xs = new XmlSerializer(typeof(List<Région>));
                    xs.Serialize(sw, lr);
                sw.Close();
                Console.WriteLine();
                StreamWriter sw2 = new StreamWriter("Sérialisation Liste Prometric.xml");
                XmlSerializer xs2 = new XmlSerializer(typeof(List<Prometric>));
                    xs2.Serialize(sw2, lp);
                sw2.Close();
                    break;

                case 6:

                    break;

                case 7:

                    break;

                case 8:
                    Console.WriteLine("A bientôt");
                    Console.ReadKey();
                    break;
            }
        }
    }
}