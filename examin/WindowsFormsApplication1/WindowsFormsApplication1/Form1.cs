using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        internal static  Les_voyage lesVoyages=new Les_voyage();
        private void button8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment quitter ?", "Attention", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            affiche(lesVoyages.Premier());
        }
        private void affiche (Voyage v)
        {
            textBox1.Text = v.Numero.ToString();
            textBox2.Text = v.Nom_prenom;
            dateTimePicker1.Value = v.Date;
            maskedTextBox1. Text = v.Duree.ToString();
            textBox4.Text = v.Ville1;
            textBox5.Text = v.Matricule;

        
        }
        private void button6_Click(object sender, EventArgs e)
        {
           
    

            {
                lesVoyages.Ajouter(int.Parse(textBox1.Text), textBox2.Text, DateTime.Parse(dateTimePicker1.Text), int.Parse(maskedTextBox1.Text), textBox4.Text, textBox5.Text);
                MessageBox.Show("voyage ajoute                         ");
                affiche(lesVoyages.Dernier());
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {if(lesVoyages.nombrevoyage>0)
            affiche(lesVoyages.Precedent());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lesVoyages.nombrevoyage > 0)
            affiche(lesVoyages.Suivant());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lesVoyages.nombrevoyage > 0)
            affiche(lesVoyages.Dernier());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            vider();
            textBox1.Text = lesVoyages.numSuivant().ToString();

        }
        
        public void vider()
        {
            textBox2.Text = "";
            dateTimePicker1.Value =DateTime.Today;
            maskedTextBox1.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment Supprimer ?", "Attention", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                lesVoyages.Supprimer();
                vider();
                textBox1.Text = lesVoyages.numSuivant().ToString();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = lesVoyages.numSuivant().ToString();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Data da = new Data();
            da.Show();
        }

        private void premierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            affiche(lesVoyages.Premier());
        }

        private void precedentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lesVoyages.nombrevoyage > 0)
                affiche(lesVoyages.Precedent());
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vider();
        }

        private void enregestrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lesVoyages.Ajouter(int.Parse(textBox1.Text), textBox2.Text, DateTime.Parse(dateTimePicker1.Text), int.Parse(maskedTextBox1.Text), textBox4.Text, textBox5.Text);
            MessageBox.Show("voyage ajoute                         ");
            affiche(lesVoyages.Dernier());
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment Supprimer ?", "Attention", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                lesVoyages.Supprimer();
                vider();
                textBox1.Text = lesVoyages.numSuivant().ToString();

            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment quitter ?", "Attention", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void suivantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            affiche(lesVoyages.Suivant());
        }

        private void dernierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            affiche(lesVoyages.Dernier());
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Premier";

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Precedent";
        }

        private void button3_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Suivante";
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Dernier";
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Quitter";
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Supprimer";
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Ajouter";
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Nouveau";
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            affiche(lesVoyages.Premier());
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (lesVoyages.nombrevoyage > 0)
                affiche(lesVoyages.Precedent());
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {


        }
    }
}
