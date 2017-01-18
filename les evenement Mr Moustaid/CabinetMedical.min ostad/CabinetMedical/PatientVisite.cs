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
    public partial class PatientVisite : Form
    {
        public PatientVisite()
        {
            InitializeComponent();
        }

        private void PatientVisite_Load(object sender, EventArgs e)
        {
            List<Patient> LPV = new List<Patient>();
            LPV = Program.CB.patientAyantdesVisites();
            String[] cellule = new String[3]; int i;
            for (i= 0; i < LPV.Count; i++)
            {
                cellule = LPV[i].ToString().Split(':');
                dataGridView1.Rows.Add(cellule);
            }
        }
    }
}
