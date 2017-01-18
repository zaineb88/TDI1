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
    public partial class AjouterVisites : Form
    {
        public AjouterVisites()
        {
            InitializeComponent();
        }

        private void Visites_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.CB.LP1.Count; i++)
            {
                comboBox1.Items.Add(Program.CB.LP1[i].CodePatient.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.CB.LP1.Count; i++)
            {
                if (comboBox1.SelectedItem.ToString() == Program.CB.LP1[i].CodePatient.ToString())
                {
                  textBox2.Text = Program.CB.LP1[i].Nom + Program.CB.LP1[i].Prénom;
                }
            }
            // ou
            //textBox2.Text = Program.CB.RechercherCodePatient(int.Parse(comboBox1.SelectedItem.ToString())).Nom + " "
            //    + Program.CB.RechercherCodePatient(int.Parse(comboBox1.SelectedItem.ToString())).Prénom;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Visites V = new Visites(dateTimePicker1.Value, dateTimePicker2.Value, int.Parse(comboBox1.Text), Double.Parse(textBox1.Text));
                Program.CB.LV1.Add(V);
                label7.Text = " Visite ajouter";
            }
            Vider();
           }
        public void Vider()
        {
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Now;
            comboBox1.Text = "";
            textBox1.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Vider();
        }
    }
}
