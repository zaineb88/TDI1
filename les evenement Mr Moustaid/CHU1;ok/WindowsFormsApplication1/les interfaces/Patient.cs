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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classe_Patient P = new Classe_Patient(textBox2.Text,textBox3.Text,dateTimePicker1.Value,textBox4.Text,maskedTextBox1.Text,textBox6.Text);
            Program.CB.AjouterPatient(P);
            label9.Text = "Patient Ajouté";
            textBox1.Text = Program.CB.LP1.Count.ToString();
            Vider();
            
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            textBox1.Text = Program.CB.LP1.Count.ToString();
        }
        public void Vider()
        {
             textBox2.Text = ""; textBox3.Text = ""; dateTimePicker1.Value = DateTime.Today;
            maskedTextBox1.Clear(); textBox4.Text = ""; textBox6.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vider();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
