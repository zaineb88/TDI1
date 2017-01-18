using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Bloc_Note
{
    public partial class Form1 : Form
    {
        string copier;
        public Form1()
        {
            InitializeComponent();
        }

        private void policeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Police P = new Police();
            P.ShowDialog();
            richTextBox1.SelectionColor = Program.C;
            richTextBox1.SelectionFont = Program.S;
            
        }
        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                openFileDialog1.ShowDialog();
                if (openFileDialog1.FileName != "")
                {
                    richTextBox1.Text = OuvrirFichier(openFileDialog1.FileName);
                }
            }
        }
        public string OuvrirFichier(string Chemin)
        {
            StreamReader Sr = new StreamReader(Chemin);
            string ligne;
            while (!Sr.EndOfStream)
            {
                ligne = Sr.ReadLine();
                return ligne;
            }
            Sr.Close();
            return null;

        }
        public void Enregistrer()
        {

        }
        public void NouveauText()
        {
            richTextBox1.Text = "";
        }
        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                NouveauText();
            }
            else
                if (MessageBox.Show("Voulez vous enregistrer le fichier", "Attention", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    saveFileDialog1.ShowDialog();
                    EnregistrerSousFichier(saveFileDialog1.FileName); }
                else
                    NouveauText();
        }
        public void EnregistrerFichier()
        {
            StreamWriter Sr = new StreamWriter("G:\\Fichier.txt", false);
            Sr.WriteLine(richTextBox1.Text);
            Sr.Close();
        }
        public void EnregistrerSousFichier(string chemin)
        {
            StreamWriter Sr = new StreamWriter(chemin,false);
            Sr.WriteLine(richTextBox1.Text);
            Sr.Close();
        }

        private void enregistrerSousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                EnregistrerSousFichier(saveFileDialog1.FileName);
            }
        }

        private void enregitrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnregistrerFichier();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void dateHeureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = DateTime.Now.ToString();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                this.Close();
            }
            else
            {
                if (MessageBox.Show("Voulez vous enregistrer le fichier", "Attention", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    saveFileDialog1.ShowDialog();
                    EnregistrerSousFichier(saveFileDialog1.FileName);
                }
                this.Close();
            }
        }

        private void copierToolStripMenuItem_Click(object sender, EventArgs e)
        {

            copier = richTextBox1.SelectedText;
        }

        private void collerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = copier;
        }

        private void coperToolStripMenuItem_Click(object sender, EventArgs e)
        {
           copier = richTextBox1.SelectedText  ;
           richTextBox1.SelectedText = "";
        }

        private void selectionnerToutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void coupierToolStripMenuItem_Click(object sender, EventArgs e)// mili zedna contextmenustrip mchina lkhana dyalo f rich w khtarinah 
        {
            copier = richTextBox1.SelectedText;

        }

        private void couperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copier = richTextBox1.SelectedText;
            richTextBox1.SelectedText = "";
        }

        private void collerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = copier;
        }

        private void sélectionnerToutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void barreDétatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barreDétatToolStripMenuItem.Checked = !barreDétatToolStripMenuItem.Checked;
            statusStrip1.Visible = barreDétatToolStripMenuItem.Checked;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
    toolStripStatusLabel1.Text = "Ln" + richTextBox1.Lines.Count() + ",Col" + richTextBox1.TextLength.ToString();// ,china l statustrips w khtarina awel khtiyar fih w khwina text dyalo toma ,china l rich w klikina w ktibna hadchi 


        }

        private void retourAutomatiquementÀLaLigneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            retourAutomatiquementÀLaLigneToolStripMenuItem.Checked = !retourAutomatiquementÀLaLigneToolStripMenuItem.Checked;
            richTextBox1.Multiline = retourAutomatiquementÀLaLigneToolStripMenuItem.Checked;
        }

        private void rechercherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rechercher P = new Rechercher();
            P.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (Program.chercher == true)
            {
                Program.chercher = false;
                richTextBox1.Select(
                richTextBox1.Text.IndexOf(Program.chaine),
                    Program.chaine.Length);
                Rechercher F3 = new Rechercher();
                F3.ShowDialog();
            }
        }
        
    }
}
