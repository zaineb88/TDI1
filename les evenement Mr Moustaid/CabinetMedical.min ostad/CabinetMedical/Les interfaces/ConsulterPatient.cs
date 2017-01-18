using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CabinetMedical.Les_interfaces
{
    public partial class ConsulterPatient : Form
    {
        public ConsulterPatient()
        {
            InitializeComponent();
        }

        private void ConsulterPatient_Load(object sender, EventArgs e)
        { int i; String [] cellule;
        for (i = 0; i < Program.CB.Patients.Count; i++)
        {
            //cellule = new String[7];
            //cellule[0] = Program.CB.Patients[i].Code.ToString();
            //cellule[1] = Program.CB.Patients[i].Nom;
            //cellule[2] = Program.CB.Patients[i].Prenom;
            //cellule[3] = Program.CB.Patients[i].Datenaissance.ToShortDateString();
            //cellule[4] = Program.CB.Patients[i].Adresse;
            //cellule[5] = Program.CB.Patients[i].Tel;
            //cellule[6] = Program.CB.Patients[i].Email;
            cellule = Program.CB.Patients[i].ToString().Split(':');
            dataGridView1.Rows.Add(cellule);
        }
             
        }
    }
}
