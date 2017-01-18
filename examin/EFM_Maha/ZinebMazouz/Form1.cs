using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TariafMaha
{
    public partial class Form1 : Form
    {
        public static int index = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Suivi s = new Suivi(int.Parse(textBox1.Text), Double.Parse(textBox2.Text), dateTimePicker1.Value,
                      textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                Program.sui.Ls1.Add(s);
                label10.Visible = false;
                vide();
            }
            else if (radioButton2.Checked == true)
            {
                {
                    Suivi s = new Suivi(int.Parse(textBox1.Text), Double.Parse(textBox2.Text), dateTimePicker1.Value,
                          textBox3.Text, textBox4.Text, textBox5.Text);
                    Program.sui.Ls1.Add(s);
                    label8.Visible = false; textBox6.Visible = false;
                    vide();
                }

            }


        }
        public void affichege(int i)
        {
            textBox1.Text = Program.sui.Ls1[i].NCompte.ToString();
            textBox2.Text = Program.sui.Ls1[i].Solde.ToString();
            dateTimePicker1.Value = Program.sui.Ls1[i].DateOvertur;
            textBox3.Text = Program.sui.Ls1[i].Nom;
            textBox4.Text = Program.sui.Ls1[i].prenom;

            textBox5.Text = Program.sui.Ls1[i].Adresse;
            textBox6.Text = Program.sui.Ls1[i].Decouvert;
            label1.Text = index + 1 + "/" + Program.sui.Ls1.Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "premier";
            index = 0;
            affichege(index);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "precedent";
            if (index > 0)
            {
                index--;
                affichege(index);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "suivent";
            if (index < Program.sui.Ls1.Count - 1)
            {
                index++;
                affichege(index);


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "dernier";
            index = Program.sui.Ls1.Count;
            affichege(index);
        }


        private void button6_Click(object sender, EventArgs e)
        {
            Program.sui.Ls1[index].NCompte = int.Parse(textBox1.Text);
            Program.sui.Ls1[index].Solde = int.Parse(textBox2.Text);
            Program.sui.Ls1[index].DateOvertur = DateTime.Parse(dateTimePicker1.Text);
            Program.sui.Ls1[index].Nom = textBox3.Text;
            Program.sui.Ls1[index].prenom = textBox4.Text;
            Program.sui.Ls1[index].Adresse = textBox5.Text;
            Program.sui.Ls1[index].Decouvert = textBox6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous suprimer", "attantion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Program.sui.Ls1.RemoveAt(index);
            }
        }
        public void vide()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";


        }


        private Suivi Recherche(int D)
        {
            for (int i = 0; i < Program.sui.Ls1.Count; i++)
            {
                if (Program.sui.Ls1[i].NCompte == D)

                    return Program.sui.Ls1[i]; break;
            } return null;
        }


        

        private void button8_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)

            { label8.Visible = false; }
            else { label10.Visible = false;  }
            Recherche(index);

        }

        private void label9_Click(object sender, EventArgs e)
        {
            label9.Text = index + 1 + "/" + Program.sui.Ls1.Count;
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suivi s = new Suivi(int.Parse(textBox1.Text), Double.Parse(textBox2.Text), dateTimePicker1.Value,
                  textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            Program.sui.Ls1.Add(s);
            vide();

        }

        private void modifiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.sui.Ls1[index].NCompte = int.Parse(textBox1.Text);
            Program.sui.Ls1[index].Solde = int.Parse(textBox2.Text);
            Program.sui.Ls1[index].DateOvertur = DateTime.Parse(dateTimePicker1.Text);
            Program.sui.Ls1[index].Nom = textBox3.Text;
            Program.sui.Ls1[index].prenom = textBox4.Text;
            Program.sui.Ls1[index].Adresse = textBox5.Text;
            Program.sui.Ls1[index].Decouvert = textBox6.Text;
        }

        private void supremerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous suprimer", "attantion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Program.sui.Ls1.RemoveAt(index);
            }
        }

        private void premierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index = 0;
            affichege(index);
        }

        private void precedentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                affichege(index);
            }
        }

        private void suiventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (index < Program.sui.Ls1.Count - 1)
            {
                index++;
                affichege(index);
            }
        }

        private void dernierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index = Program.sui.Ls1.Count;
            affichege(index);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}