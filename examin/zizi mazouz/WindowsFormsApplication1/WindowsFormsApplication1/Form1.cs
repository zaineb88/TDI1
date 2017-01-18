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
        int index = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)// enregistrer

        {
     
            Adhérent s = new Adhérent();
            s.Numero = int.Parse(textBox1.Text);
            s.Nom = textBox2.Text;
            s.Date_naissance = dateTimePicker1.Value;
            s.Pays = comboBox1.SelectedItem.ToString();
            s.Ville = comboBox2.SelectedItem.ToString();
            s.Image = openFileDialog1.FileNames.ToString();
            Program.AdhérentP.AjouterAdhérent(s);
            MessageBox.Show("Adhérent ajouter.");
            vider();
        }
        private void vider()    // nouveau 
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vider();
        }
        private void affichage(Adhérent A)
        {
            textBox1.Text = A.Numero.ToString();
            textBox2.Text = A.Nom;
            dateTimePicker1.Value = A.Date_naissance;
            comboBox1.Text = A.Pays;
            comboBox2.Text = A.Ville;

        }

        private void button5_Click(object sender, EventArgs e) // premier
        {
            if (Program.AdhérentP.LesAdhérent.Count > 0)
            {
                index = 0;
                affichage(Program.AdhérentP.LesAdhérent[index]);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                affichage(Program.AdhérentP.LesAdhérent[index]);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (index < Program.AdhérentP.LesAdhérent.Count - 1)
            {
                index++;
                affichage(Program.AdhérentP.LesAdhérent[index]);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Program.AdhérentP.LesAdhérent.Count > 0)
            {
                index = Program.AdhérentP.LesAdhérent.Count - 1;
                affichage(Program.AdhérentP.LesAdhérent[index]);
            }    
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Maroc")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Rabat");
                comboBox2.Items.Add("Larache");
                comboBox2.Items.Add("Marrakeche");
                comboBox2.Items.Add("Meknes");
                
            }
         
                if (comboBox1.SelectedItem.ToString() == "spain ")
                {
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Barça");
                    comboBox2.Items.Add("Granada");
                    

                }
                if (comboBox1.SelectedItem.ToString() == "France")
                {
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("l'ile");
                    comboBox2.Items.Add("paris");
                }
         
        }

        private void button4_Click(object sender, EventArgs e) // quitter
        {
            if (MessageBox.Show("vous voulez quittez"," ",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vider();
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adhérent s = new Adhérent();
            s.Numero = int.Parse(textBox1.Text);
            s.Nom = textBox2.Text;
            s.Date_naissance = dateTimePicker1.Value;
            s.Pays = comboBox1.SelectedItem.ToString();
            s.Ville = comboBox2.SelectedItem.ToString();
            s.Image = openFileDialog1.FileNames.ToString();
            Program.AdhérentP.AjouterAdhérent(s);
            MessageBox.Show("Adhérent ajouter.");
            vider();

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("vous voulez quittez", "Attention", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void premierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.AdhérentP.LesAdhérent.Count > 0)
            {
                index = 0;
                affichage(Program.AdhérentP.LesAdhérent[index]);
            }


        }

        private void precedentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                affichage(Program.AdhérentP.LesAdhérent[index]);
            }

        }

        private void suivantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (index < Program.AdhérentP.LesAdhérent.Count - 1)
            {
                index++;
                affichage(Program.AdhérentP.LesAdhérent[index]);
            }
        }

        private void dernierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.AdhérentP.LesAdhérent.Count > 0)
            {
                index = Program.AdhérentP.LesAdhérent.Count - 1;
                affichage(Program.AdhérentP.LesAdhérent[index]);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nouveauToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            vider();
        }

        private void enregistrerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            

        }

        private void enregistrerToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Adhérent s = new Adhérent();
            s.Numero = int.Parse(textBox1.Text);
            s.Nom = textBox2.Text;
            s.Date_naissance = dateTimePicker1.Value;
            s.Pays = comboBox1.SelectedItem.ToString();
            s.Ville = comboBox2.SelectedItem.ToString();
            s.Image = openFileDialog1.FileNames.ToString();
            Program.AdhérentP.AjouterAdhérent(s);
            MessageBox.Show("Adhérent ajouter.");
            vider();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }


       
    }
}
