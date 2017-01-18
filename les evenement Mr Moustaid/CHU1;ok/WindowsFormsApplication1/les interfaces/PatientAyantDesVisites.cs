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
    public partial class PatientAyantDesVisites : Form
    {
        public PatientAyantDesVisites()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void PatientAyantDesVisites_Load(object sender, EventArgs e)
        {
            List<Classe_Patient> LPV = new List<Classe_Patient>();
            LPV = Program.CB.PatientAyantDesVisites();
            String[] cellule = new String[3];
            for (int i = 0; i < LPV.Count; i++)
            {
                cellule = LPV[i].ToString().Split(':');
                dataGridView1.Rows.Add(cellule);
            }
        }
    }
}
