using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CabinetMedical
{
    public partial class CabMedical : Form
    {
        public CabMedical()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void CabMedical_Load(object sender, EventArgs e)
        {
            Program.CB.Lire_patients();
        }

        private void aProposDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterPatient A = new AjouterPatient();
            A.MdiParent = this;
            A.Show();
        }

        private void consulterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Les_interfaces.ConsulterPatient A = new Les_interfaces.ConsulterPatient();
            A.MdiParent = this;
            A.Show();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Program.CB.enregistrer_patients();
        }

        private void enregistrerSousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            { Program.CB.enregistrer_patients(saveFileDialog1.FileName); }

        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                Program.CB.vider_List_Patient();
                Program.CB.Lire_patients(openFileDialog1.FileName); 
            }
        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Les_interfaces.ajouterRendezVous A = new Les_interfaces.ajouterRendezVous();
            A.MdiParent = this;
            A.Show();
        }

        private void ajouterToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Les_interfaces.AjouterVisite A = new Les_interfaces.AjouterVisite();
            A.MdiParent = this;
            A.Show();
        }

        private void patientsAyantDesVisitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientVisite A = new PatientVisite();
            A.MdiParent = this;
            A.Show();
        }
    }
}
