using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Inscription
{
    public partial class Form1 : Form
    {
        ArrayList LesStagiaires=new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //  comboBox1.Items.Add("TDI");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(textBox4.Text);
            textBox4.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
                textBox4.Text = comboBox1.SelectedItem.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
                textBox3.Text = comboBox1.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Sorted = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text = dateTimePicker1.Text;
            DateTime AujourdHui = DateTime.Today;
            TimeSpan t = AujourdHui - DateTime.Parse(textBox5.Text);
            textBox6.Text = (t.Days / 365).ToString();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime AujourdHui = DateTime.Today;
            TimeSpan t = AujourdHui - dateTimePicker1.Value;
           // textBox6.Text = (Math.Round(t.Days / 365.00,2)).ToString();
            textBox6.Text = (t.Days / 365).ToString() + "  " + "ans" + "  " + ((t.Days % 365) / 30).ToString() + "  " + "mois" + "  " + ((t.Days % 365) % 30).ToString() + "  " + "jours";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                textBox4.Text += listBox1.SelectedItems[i].ToString()+" ";
            }


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Stagiaire S1;
            if(radioButton1.Checked)
                S1=new Stagiaire(textBox1.Text,textBox2.Text,"M",
                    comboBox1.SelectedItem.ToString(),int.Parse(numericUpDown1.Value.ToString()));
            else 
                 S1=new Stagiaire(textBox1.Text,textBox2.Text,"F",
                     comboBox1.SelectedItem.ToString(),int.Parse(numericUpDown1.Value.ToString()));
            LesStagiaires.Add(S1);

            /////////////////////////////////////////////////
            String[] row = new String[5];
            row[0] = textBox1.Text;
            row[1] = textBox2.Text;
            if (radioButton1.Checked)
            { row[2] = "M"; }
            else 
                row[2]="F";
            row[3] = comboBox1.SelectedItem.ToString();
            row[4] = numericUpDown1.Value.ToString();
            this.dataGridView1.Rows.Add(row);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            { label10.Text = "Erreur de Selection"; }
            else
            {
                if (MessageBox.Show("Voullez vous vraiment supprimmer?","Attention", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    label10.Text = "";
                    //////////// Memoire /////////////////////
                    Stagiaire S1;
                    S1 = new Stagiaire(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(),
                        dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                        dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                        dataGridView1.SelectedRows[0].Cells[3].Value.ToString(),
                        int.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString()));
                    LesStagiaires.Remove(S1);
                    ///////////////////: affichage //////////////::
                    dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        { 
            int i=0;
            Stagiaire S1;
            for (i = 0; i < LesStagiaires.Count; i++)
            {
                S1 = (Stagiaire)LesStagiaires[i];
                if (S1.Nom == textBox1.Text)
                { textBox2.Text = S1.Prénom;
                if (S1.Sexe == "F")
                    radioButton2.Checked = true;
                else
                    radioButton1.Checked = true;
                comboBox1.Text = S1.Option;
                numericUpDown1.Value = S1.Age;
                }
            }

            
            
        }

        private void button11_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear(); //pour supprimer dataGridView1

            int i; string[] row = new string[5];
            Stagiaire S1=new Stagiaire();
            for (i = 0; i < LesStagiaires.Count; i++)
            {
                
                S1 = (Stagiaire)LesStagiaires[i];
                if (S1.Option == comboBox1.SelectedItem.ToString())
                { row[0] = S1.Nom;
                   row[1] = S1.Prénom;
                    row[2] = S1.Sexe;
                    row[3] = S1.Option;
                    row[4] = (S1.Age).ToString();
                    this.dataGridView1.Rows.Add(row);
                }
              
                
            }
        }

    }
}
