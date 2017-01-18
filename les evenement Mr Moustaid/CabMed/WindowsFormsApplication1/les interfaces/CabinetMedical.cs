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
            Program.cb.Lire_patient();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visites A = new Visites();
            A.MdiParent = this;
            A.Show();
        }

        private void ajouterToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Patient A = new Patient();
            A.MdiParent = this;
            A.Show();

        }

        private void consulterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            les_interfaces.ConsulterPatient A = new les_interfaces.ConsulterPatient();// bach meli nteki 3la consulter f interface dyal cabinet medical tetla3 interface dyal consulter
            A.MdiParent = this;
            A.Show();
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.cb.Enregister_patient();
            
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void enregistrerSousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            { Program.cb.Enregister_patient(saveFileDialog1.FileName); }

        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            { Program.cb.Lire_patient(openFileDialog1.FileName);}
        }

        private void consulterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                les_interfaces.ConsulterPatient A = new les_interfaces.ConsulterPatient();// bach meli nteki 3la consulter f interface dyal cabinet medical tetla3 interface dyal consulter
                A.MdiParent = this;
                A.Show();
            }
        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AjouterRendezVous A = new AjouterRendezVous();
            A.MdiParent = this;
            A.Show();

        }

        private void consulterToolStripMenuItem2_Click(object sender, EventArgs e)
        {
        }
        
    }
}
