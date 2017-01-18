using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Adhérent
    {
        int numero;
        string nom;
        DateTime date_naissance;
        string pays;
        string ville;
        string email;
        string image;

        public string Image
        {
            get { return image; }
            set { image = value; }
        }
        List<Adhérent> lesAdhérent;

        internal List<Adhérent> LesAdhérent
        {
            get { return lesAdhérent; }
            set { lesAdhérent = value; }
        }

        public Adhérent() { lesAdhérent = new List<Adhérent>(); }
        public Adhérent(int NU, string NO, DateTime DA, string PA, string VI, string EM,string IM)
            : this()
        {
            numero = NU; nom = NO; date_naissance = DA; pays = PA; ville = VI; email = EM;
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public DateTime Date_naissance
        {
            get { return date_naissance; }
            set { date_naissance = value; }
        }
        public string Pays
        {
            get { return pays; }
            set { pays = value; }
        }
        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public void AjouterAdhérent(Adhérent V)
        {
            lesAdhérent.Add(V);
        }

    }
}
