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
    public partial class AjouterVisite : Form
    {
        public AjouterVisite()
        {
            InitializeComponent();
        }

        private void AjouterVisite_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.CB.Patients.Count; i++)
            {
                comboBox1.Items.Add(Program.CB.Patients[i].Code);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = Program.CB.rechrecheparCodePatient
                    (int.Parse(comboBox1.SelectedItem.ToString())).Nom
                    +" "+ Program.CB.rechrecheparCodePatient
                    (int.Parse(comboBox1.SelectedItem.ToString())).Prenom;
        }
        public void vider()
        {
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Now;
            comboBox1.Text = "";
            textBox2.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Visites v = new Visites();
            v.Datevisite = dateTimePicker1.Value;
            v.HeureVisite = dateTimePicker2.Value;
            v.Codepatient = int.Parse(comboBox1.SelectedItem.ToString());
            v.Montantpaye = Double.Parse(textBox2.Text);
            Program.CB.Visites.Add(v);
            label7.Text = "Visite ajoutée";
            vider();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            vider();
            label7.Text = "";
        }
    }
}
