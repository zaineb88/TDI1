using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projet_POO.Couche_Interface
{
    public partial class TournoiDeChasse : Form
    {
        public TournoiDeChasse()
        {
            InitializeComponent();
        }

        

        private void gestionChasseursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionChasseurs GestChass = new GestionChasseurs();


            GestChass.MdiParent = this; 
            GestChass.Show(); 
        }

        private void gestionScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionScores GestScore = new GestionScores();
            GestScore.MdiParent = this;
            GestScore.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void consultationDesResultatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resultat Res = new Resultat();
            Res.MdiParent = this;
            Res.Show();
        }
    }
}
