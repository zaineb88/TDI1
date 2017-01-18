using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ofppt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        LesDos LesDOssie = new LesDos();
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            maskedTextBox1.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        private void afficher(Dossier dos)
        {
            textBox1.Text = dos.Cne.ToString();
            textBox2.Text = dos.Nom;
            textBox3.Text = dos.Prénom;
            maskedTextBox1.Text = dos.NumDossier.ToString();
            dateTimePicker1.Value = dos.Date;
            dateTimePicker2.Value = dos.DateNaissance;
            comboBox1.Text = dos.Niveausc1;
            comboBox2.Text = dos.NiveauSc2;
            comboBox3.Text = dos.Choix1;
            comboBox4.Text = dos.Choix2;
            comboBox5.Text = dos.Choix3;
            if (dos.Sexe == "M")
                radioButton1.Checked = true;
            else radioButton2.Checked = true;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            afficher(LesDOssie.Dernier());
        }

        private void button2_Click(object sender, EventArgs e)
        {string sex;
            if(radioButton1.Checked)
                sex="M";
            else
                 sex="F";
            try
            {
               
                LesDOssie.ajouterDO(new Dossier(int.Parse(maskedTextBox1.Text), dateTimePicker1.Value, comboBox1.Text, int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, sex, dateTimePicker2.Value, comboBox2.Text, comboBox3.Text, comboBox4.Text, comboBox5.Text));

                MessageBox.Show("Ajouter ");
                afficher(LesDOssie[LesDOssie.Index]);
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LesDOssie.Supprimer();
            if (LesDOssie.Index != -1)
                afficher(LesDOssie[LesDOssie.Index]);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            afficher(LesDOssie.Suivant());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            afficher(LesDOssie.Precedent());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            afficher(LesDOssie.Premier());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rechercher rech = new Rechercher();
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox1.Checked == false && checkBox4.Checked == false)
            { MessageBox.Show("Impossible "); }
            else
            if (rech.ShowDialog() == DialogResult.OK)
            {
                if (checkBox1.Checked)
                {
                    if (LesDOssie.RechercherSiNUMDOssDejaExist(int.Parse(rech.textBox1.Text)) == -1)
                    {
                        MessageBox.Show("n'existe pas ");
                    }
                    else
                    { 
                    afficher(LesDOssie[LesDOssie.RechercherSiNUMDOssDejaExist(int.Parse(rech.textBox1.Text))]);
                    }
                }
                else if(checkBox2.Checked)
                {
                 if (LesDOssie.RechercherSiCNEDOssDejaExist(int.Parse(rech.textBox1.Text)) == -1)
                    {
                        MessageBox.Show("n'existe pas ");
                    }
                    else
                    { 
                    afficher(LesDOssie[LesDOssie.RechercherSiCNEDOssDejaExist(int.Parse(rech.textBox1.Text))]);
                    }
                }
                 else if(checkBox3.Checked)
                {
                 if (LesDOssie.RechercherSiNomDejaExist((rech.textBox1.Text)) == -1)
                    {
                        MessageBox.Show("n'existe pas ");
                    }
                    else
                    {
                        afficher(LesDOssie[LesDOssie.RechercherSiNomDejaExist((rech.textBox1.Text))]);
                    }
                }
                else if (checkBox4.Checked)
                {
                    if (LesDOssie.RechercherSiPreNomDejaExist((rech.textBox1.Text)) == -1)
                    {
                        MessageBox.Show("n'existe pas ");
                    }
                    else
                    {
                        afficher(LesDOssie[LesDOssie.RechercherSiPreNomDejaExist((rech.textBox1.Text))]);
                    }
                }
            
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rechercherToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Rechercher rech = new Rechercher();
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox1.Checked == false && checkBox4.Checked == false)
            { MessageBox.Show("Impossible "); }
            else
                if (rech.ShowDialog() == DialogResult.OK)
                {
                    if (checkBox1.Checked)
                    {
                        if (LesDOssie.RechercherSiNUMDOssDejaExist(int.Parse(rech.textBox1.Text)) == -1)
                        {
                            MessageBox.Show("n'existe pas ");
                        }
                        else
                        {
                            afficher(LesDOssie[LesDOssie.RechercherSiNUMDOssDejaExist(int.Parse(rech.textBox1.Text))]);
                        }
                    }
                    else if (checkBox2.Checked)
                    {
                        if (LesDOssie.RechercherSiCNEDOssDejaExist(int.Parse(rech.textBox1.Text)) == -1)
                        {
                            MessageBox.Show("n'existe pas ");
                        }
                        else
                        {
                            afficher(LesDOssie[LesDOssie.RechercherSiCNEDOssDejaExist(int.Parse(rech.textBox1.Text))]);
                        }
                    }
                    else if (checkBox3.Checked)
                    {
                        if (LesDOssie.RechercherSiNomDejaExist((rech.textBox1.Text)) == -1)
                        {
                            MessageBox.Show("n'existe pas ");
                        }
                        else
                        {
                            afficher(LesDOssie[LesDOssie.RechercherSiNomDejaExist((rech.textBox1.Text))]);
                        }
                    }
                    else if (checkBox4.Checked)
                    {
                        if (LesDOssie.RechercherSiPreNomDejaExist((rech.textBox1.Text)) == -1)
                        {
                            MessageBox.Show("n'existe pas ");
                        }
                        else
                        {
                            afficher(LesDOssie[LesDOssie.RechercherSiPreNomDejaExist((rech.textBox1.Text))]);
                        }
                    }

                }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LesDOssie.Supprimer();
            if (LesDOssie.Index != -1)
                afficher(LesDOssie[LesDOssie.Index]);
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sex;
            if (radioButton1.Checked)
                sex = "M";
            else
                sex = "F";
            try
            {
                LesDOssie.ajouterDO(new Dossier(int.Parse(maskedTextBox1.Text), dateTimePicker1.Value, comboBox1.Text, int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, sex, dateTimePicker2.Value, comboBox2.Text, comboBox3.Text, comboBox4.Text, comboBox5.Text));
                afficher(LesDOssie[LesDOssie.Index]);
            }
            catch { }
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            maskedTextBox1.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
        }
    }
}
