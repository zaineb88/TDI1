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
    public partial class ConsulterPatient : Form
    {
        public ConsulterPatient()
        {
            InitializeComponent();
        }

        private void ConsulterPatient_Load(object sender, EventArgs e)
        {
            string[] cellule;

            for (int i = 0; i < Program.CB.LP1.Count; i++)
            {
                //cellule = new string[7];
                //cellule[0] = Program.CB.LP1[i].CodePatient.ToString();
                //cellule[1] = Program.CB.LP1[i].Nom;
                //cellule[2] = Program.CB.LP1[i].Prénom;
                //cellule[3] = Program.CB.LP1[i].Dt.ToString();
                //cellule[4] = Program.CB.LP1[i].Adresse;
                //cellule[5] = Program.CB.LP1[i].Télé;
                //cellule[6] = Program.CB.LP1[i].Email;
                cellule = Program.CB.LP1[i].ToString().Split(':');
                dataGridView1.Rows.Add(cellule);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
