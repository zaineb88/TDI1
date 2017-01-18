using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormApplication1.Couche_Interface
{
    public partial class TournoiDesEléves : Form
    {
        public TournoiDesEléves()
        {
            InitializeComponent();
        }

        private void gestionEléveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionEléve G = new GestionEléve();
            G.MdiParent = this;
            G.Show();
        }

  

        private void gestioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionDesNoteDuEléves g = new GestionDesNoteDuEléves();
            g.MdiParent = this;
            g.Show();
        }

        private void aProposDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            APropos A = new APropos();
            A.MdiParent = this;
            A.Show();
        }

        private void consulterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultationDesNotes g = new ConsultationDesNotes();
            g.MdiParent = this;
            g.Show();
        }

        private void quiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eléveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
