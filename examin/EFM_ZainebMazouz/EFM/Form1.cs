using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EFM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        internal static Collection liste = new Collection();

        private void affiche(Compte c)
        {
            textBox1.Text = c.NCompte1.ToString();
            textBox2.Text = c.Solde1.ToString();
            dateTimePicker1.Value = c.DateOuverture1;
            textBox4.Text = c.Nom1;
            textBox5.Text = c.Prénom1;
            textBox6.Text = c.Adresse1;
            textBox3.Text = c.DécouvertAcordé1;


        }

        public void vider()
        {
            textBox1.Text = " ";
            textBox2.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            affiche(liste.Premier());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (liste.nombrecompte > 0)
                affiche(liste.Dernier());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (liste.nombrecompte > 0)
                affiche(liste.Suivant());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                if (liste.nombrecompte > 0)
                    affiche(liste.Precedent());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                liste.Ajouter(int.Parse(textBox1.Text),double.Parse(textBox2.Text), DateTime.Parse(dateTimePicker1.Text),
                    textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                MessageBox.Show("voyage ajoute");
                vider();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            vider();
            textBox1.Text = liste.numSuivant().ToString();
        }

    ///
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Premier";

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Modifier";
        }

        private void button3_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Supprimer";
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Rechercher";
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Dernier";
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Suivant";
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Précédant";
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Premier";
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Premier";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)

            { label8.Visible = false; }
            else { label10.Visible = false; }
           // Recherche(index);

        }

        private void label11_Click(object sender, EventArgs e)
        {
          //  label11.Text = +1+ "/" +liste.Count;
        }
       
    }
}
