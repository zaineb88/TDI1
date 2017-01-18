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
    public partial class AjouterRendezVous : Form
    {
        int index = 0;
        public AjouterRendezVous()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //for (int i = 0; i < Program.CB.LP1.Count; i++)
            //{
            //    if (comboBox1.SelectedItem.ToString() == Program.CB.LP1[i].CodePatient.ToString())
            //    {
            //        textBox2.Text = Program.CB.LP1[i].Nom + Program.CB.LP1[i].Prénom;
            //    }
            //}
            // ou
            textBox2.Text = Program.CB.RechercherCodePatient(int.Parse(comboBox1.SelectedItem.ToString())).Nom + " "
                + Program.CB.RechercherCodePatient(int.Parse(comboBox1.SelectedItem.ToString())).Prénom;
        }

        private void AjouterRendezVous_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.CB.LP1.Count; i++)
            {
                comboBox1.Items.Add(Program.CB.LP1[i].CodePatient.ToString());
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RendezVous RV = new RendezVous(dateTimePicker1.Value, dateTimePicker2.Value, int.Parse(comboBox1.SelectedItem.ToString()));
            RV.Observation = textBox1.Text;
            Program.CB.LRV1.Add(RV);
            MessageBox.Show("Rendez vous Ajouté");
            Vider();
        }
        public void Vider()
        {
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Now;
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            label7.Text = "";
        }
        public void AffichageRDV(int i)
        {
            dateTimePicker1.Value = Program.CB.LRV1[i].DateRendezVous;
            dateTimePicker2.Value = Program.CB.LRV1[i].HeureRendezVous;
            comboBox1.Text = Program.CB.LRV1[i].CodePatient.ToString();
            textBox1.Text = Program.CB.LRV1[i].Observation.ToString();
            label7.Text = (index + 1).ToString() + "/" + Program.CB.LRV1.Count;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            index = 0;
            AffichageRDV(index);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            index = Program.CB.LRV1.Count - 1;
            AffichageRDV(index);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                AffichageRDV(index);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (index <Program.CB.LRV1.Count-1)
            {
                index++;
                AffichageRDV(index);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Vider();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment supprimer ? ", "Attention", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Program.CB.LRV1.RemoveAt(index);
                MessageBox.Show("RendezVous supprimé");
                Vider();
            }
        }
    }
}
