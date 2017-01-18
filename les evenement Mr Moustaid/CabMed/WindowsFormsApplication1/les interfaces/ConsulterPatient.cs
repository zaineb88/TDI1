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
            int i; string[] cellule = new string[7];
            for (i = 0; i < Program.cb.LP1.Count; i++)
            {
                //cellule[0] = Program.cb.LP1[i].CodePatient.ToString();
                //cellule[1] = Program.cb.LP1[i].Nom;
                //cellule[2] = Program.cb.LP1[i].Prénom;
                //cellule[3] = Program.cb.LP1[i].Dt.ToString();
                //cellule[4] = Program.cb.LP1[i].Télé.ToString();
                //cellule[5] = Program.cb.LP1[i].Adresse;
                //cellule[6] = Program.cb.LP1[i].Email;
                //dataGridView1.Rows.Add(cellule);
                cellule = Program.cb.LP1[i].ToString().Split(':');// hadi tosawi kol li f ta3li9 lfo9
                dataGridView1.Rows.Add(cellule);
            }

        }
    }
}
