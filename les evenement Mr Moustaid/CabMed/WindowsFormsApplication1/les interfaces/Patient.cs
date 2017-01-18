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
        private void vide()
        { 
        
            textBox2.Text="";
            textBox3.Text="";
            dateTimePicker1.Value=DateTime.Today;
            textBox4.Text = "";
            maskedTextBox1.Clear();
            textBox6.Text = "";
        }




        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classe_Patient P = new Classe_Patient(textBox2.Text, textBox3.Text, dateTimePicker1.Value, textBox4.Text, maskedTextBox1.Text, textBox6.Text);

                textBox1.Text = Program.cb.LP1.Count.ToString();
     

            Program.cb.AjouterPatient(P);

            label9.Text = "patient Ajouté";

        }

        private void Patient_Load(object sender, EventArgs e)
        {
            textBox1.Text = Program.cb.LP1.Count.ToString();
        }
    }
}