using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.les_interfaces
{
    public partial class CabinetMedical : Form
    {
        public CabinetMedical()
        {
            InitializeComponent();
        }

        private void CabinetMedical_Load(object sender, EventArgs e)
        {
            Program.CB.Lire_patient();
        }

        private void ajouterToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Patient A = new Patient();
            A.MdiParent = this;
            A.Show();
        }

        private void consulterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsulterPatient C = new ConsulterPatient();
            C.MdiParent = this;
            C.Show();
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.CB.Enregister_patient();
            Program.CB.Enregister_Visite();
        }

        private void enregistrerSousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ou bach man3amlochi txt f enregistrer saveFileDialog1.DefaultExt="txt";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            { Program.CB.Enregister_patient(saveFileDialog1.FileName); }
            saveFileDialog2.ShowDialog();
            if (saveFileDialog2.FileName != "")
            { Program.CB.Enregister_Visite(saveFileDialog2.FileName); }

        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                Program.CB.Vider_Lire_patient();
                Program.CB.Lire_patient(openFileDialog1.FileName); }
            openFileDialog2.ShowDialog(); 
            if (openFileDialog2.FileName != "")
            {
                Program.CB.Vider_Lire_visite();
                Program.CB.Lire_visite(openFileDialog2.FileName);
            }
            
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterVisites A = new AjouterVisites();
            A.MdiParent = this;
            A.Show();
        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AjouterRendezVous A = new AjouterRendezVous();
            A.MdiParent = this;
            A.Show();
        }

        private void consulterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consulterToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsulterVisite C = new ConsulterVisite();
            C.MdiParent = this;
            C.Show();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void rendezVousToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void patientAyantDesVisitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientAyantDesVisites A = new PatientAyantDesVisites();
            A.MdiParent = this;
            A.Show();
        }
    }
}
