using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace inscription
{
    public partial class Form1 : Form
    {
        ArrayList LesStagiaires = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            comboBox1.Items.Add("TSGE");
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stagiaire s1;
            if(radioButton1.Checked)
            s1 = new Stagiaire(textBox1.Text,textBox2.Text,"M",comboBox1.SelectedItem.ToString(),int.Parse(numericUpDown1.Value.ToString()));
            else
                s1 = new Stagiaire(textBox1.Text, textBox2.Text, "F", comboBox1.SelectedItem.ToString(), int.Parse(numericUpDown1.Value.ToString()));
            LesStagiaires.Add(s1);
            //comboBox1.Items.Add(textBox3.Text);*
            string[] row = new string[5];
            row[0] = textBox1.Text;
            row[1] = textBox2.Text;
            if (radioButton1.Checked)
                row[2] = "M";
            else
                row[2] = "F";
            row[3] = comboBox1.SelectedItem.ToString();
            row[4] = numericUpDown1.Value.ToString();
            this.dataGridView1.Rows.Add(row);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //comboBox1.Items.Remove(textBox3.Text);
            // textBox3.Text = "";
            Stagiaire s1 = new Stagiaire();
            if (dataGridView1.SelectedRows.Count == 0)
                label9.Text = "Erreur de selection";
            else
            {
                label9.Text = " ";
                s1 = new Stagiaire(
                dataGridView1.SelectedRows[0].Cells[0].Value.ToString(),
                dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                dataGridView1.SelectedRows[0].Cells[3].Value.ToString(),
                int.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString()));
                LesStagiaires.Remove(s1);
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem != null)
            textBox3.Text = comboBox1.SelectedItem.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
                textBox3.Text = comboBox1.SelectedItem.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Sorted = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Text = dateTimePicker1.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TimeSpan t = DateTime.Now.Date - dateTimePicker1.Value;
           // textBox4.Text = (Math.Round(t.Days / 365.00, 2)).ToString();
            textBox4.Text = (t.Days / 365).ToString() + "ans" + ((t.Days % 365) / 30).ToString() + "mois" + ((t.Days % 365) % 30).ToString()+"jour";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int i;
            for(i=0;i<listBox1.SelectedItems.Count;i++)
            {
            textBox5.Text+=listBox1.SelectedItems[i].ToString()+" ";}
        }
    }
}
