using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Projet_POO.Couche_Métier;
namespace Projet_POO.Couche_Interface
{
    public partial class Resultat : Form
    {
        public Resultat()
        {
            InitializeComponent();
        }

        
        private void Resultat_Load(object sender, EventArgs e)
        {
            EtatInitial();
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Chasseur ch = GestionChasseurs.Chs.Recherche(int.Parse(comboBox1.Text));
            
            label1.Text = "Monsieur: " + ch.Nom+ " " + ch.Prénom + "a réalisé un score de  " + GestionScores.Scs.TotalScoreChasseur(int.Parse(comboBox1.Text)).ToString() + " points.";
        
        
        }

        private void Resultat_Activated(object sender, EventArgs e)
        {
            EtatInitial();
        }


        private void EtatInitial()
        {
            foreach (Chasseur ch in GestionChasseurs.Chs) comboBox1.Items.Add(ch.NuméroChasseur);
            Chasseur Vinq = GestionChasseurs.Chs.Recherche(GestionScores.Scs.NumeroVainqueur);
            label2.Text = "Monsieur: " + Vinq.Nom + " " + Vinq.Prénom + "son score est de : " + GestionScores.Scs.TotalScoreChasseur(Vinq.NuméroChasseur) + " points. Félicitations!!!!";
        }

    }
}
