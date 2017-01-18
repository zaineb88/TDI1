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
    public partial class AjouterPatient : Form
    {

        public AjouterPatient()
        {
            InitializeComponent();
        }
        private void vider()
        {
            textBox1.Text = ""; textBox2.Text = ""; textBox4.Text = "";
            textBox5.Text = ""; dateTimePicker1.Value = DateTime.Today;
            maskedTextBox1.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Patient p = new Patient(textBox1.Text, textBox2.Text
                , dateTimePicker1.Value, textBox4.Text
                , maskedTextBox1.Text, textBox5.Text);
            Program.CB.AjouterPatient(p);
            label9.Text = "Patient Ajouté";
            textBox3.Text = Program.CB.Patients.Count.ToString();
            vider();
        }

        private void AjouterPatient_Load(object sender, EventArgs e)
        {
            textBox3.Text = Program.CB.Patients.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vider();
            label9.Text = "";
        }
    }
}
