using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Projet_POO.Couche_Métier;

namespace Projet_POO.Couche_Interface
{
    public partial class GestionScores : Form
    {
        internal static LesScores Scs=new LesScores();

        public GestionScores()
        {
            //Scs = new LesScores();
            InitializeComponent();
        }
        private void EtatInitial()
        {
            if (GestionChasseurs.Chs.NombreChasseursParticipant > 0)
            {
                comboBox1.Items.Clear();
                foreach (Chasseur ch in GestionChasseurs.Chs) comboBox1.Items.Add(ch.NuméroChasseur);
                comboBox1.Text = ""; comboBox1.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
            }
            else {
                comboBox1.Text = ""; comboBox1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
            }
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox2.Text = "";
            textBox3.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Chasseur ch = GestionChasseurs.Chs.Recherche(int.Parse(comboBox1.Text));
            textBox1.Text = ch.Nom;
            textBox2.Text = ch.Prénom;
        }

        private void GestionScores_Load(object sender, EventArgs e)
        {
            EtatInitial();
                    
                    }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Scs.RechercheDoublon(int.Parse(comboBox1.Text), comboBox2.Text) == false)
            {
                try
                {
                    Scs.Ajouter(int.Parse(comboBox1.Text), comboBox2.Text, int.Parse(textBox3.Text));
                    MessageBox.Show("Le score a été bien enregistré");
                }
                catch (Exception ex) { MessageBox.Show("Attention, une erruer s'est produite:" + Environment.NewLine + ex.Message,"Erreur !!!!!!!!!",MessageBoxButtons.OK,MessageBoxIcon.Error); }
                finally
                {
                    EtatInitial();
                }
            }
            else
                MessageBox.Show("Impossible d'ajouter ce score pour le chasseur: " + comboBox1.Text + " , car il y a déja un score enregistré pour ce mois");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EtatInitial();
        }

        private void GestionScores_Activated(object sender, EventArgs e)
        {
            EtatInitial();
        }

        private void GestionScores_FormClosing(object sender, FormClosingEventArgs e)
        {
            Scs.SauvgarderListScores();
        }


       
    }
}
