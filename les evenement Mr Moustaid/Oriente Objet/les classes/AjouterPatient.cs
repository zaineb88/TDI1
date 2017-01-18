using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Oriente_Objet.les_classes
{
    public partial class AjouterPatient : Form
    {
        public AjouterPatient()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Patient p = new Patient(textBox1.Text, textBox2.Text, dateTimePicker1.Value, 
                textBox3.Text, maskedTextBox1.Text, textBox5.Text);
            Program.CB.AjouterPatient(p);
            label6.Text="Patient Ajouter";


        }

        private void AjouterPatient_Load(object sender, EventArgs e)
        {
            textBox1.Text = Program.CB.Patients.Count.ToString();
        }

    }
        
}

