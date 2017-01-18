using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormApplication1.Couche_Metier;
using WindowsFormApplication1.Acces_Aux_Donner;

namespace WindowsFormApplication1.Couche_Interface
{
    public partial class GestionDesNoteDuEléves : Form
    {
        internal static Les_Notes_Eleves Mcs = new Les_Notes_Eleves();
        
        public GestionDesNoteDuEléves()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < Program.eleve.L1.Count; i++)
            {
                if (comboBox1.Text == Program.eleve.L1[i].Matricule.ToString())
                {
                    textBox1.Text = Program.eleve.L1[i].Nom;
                    textBox2.Text =Program.eleve.L1[i].Prénom;
                }
            }
            
        }
        private void EtatInitial()
        {
            if (Program.eleve.NombreEléveParticipant > 0)
            {
                comboBox1.Items.Clear();
                textBox3.Text = "";

                foreach (Eléve El in Program.eleve) comboBox1.Items.Add(El.Matricule);
                comboBox1.Text = ""; comboBox1.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
               
            }
            else
            {
                comboBox1.Text = ""; comboBox1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                textBox3.Text = "";
            }
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox2.Text = "";
            textBox3.Text = "";
        }
        private void GestionDesNoteDuEléves_Load(object sender, EventArgs e)
        {
            EtatInitial();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Mcs.RechercheDoublon(int.Parse(comboBox1.Text), comboBox2.Text) == false)
            {
                try
                {
                    Mcs.Ajouter(int.Parse(comboBox1.Text), comboBox2.Text, int.Parse(textBox3.Text));
                    MessageBox.Show("L'note a été bien enregistré");
                }
                catch (Exception ex) { MessageBox.Show("Attention, une erruer :" +
                    Environment.NewLine + ex.Message, "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                finally
                {
                    EtatInitial();
                }
            }
            else
                MessageBox.Show("Impossible d'ajouter ce note pour l'eleve: "
                    + comboBox1.Text + " , car il y a déja un note enregistré pour ce Matier");
            EtatInitial();
        }

        private void GestionDesNoteDuEléves_Activated(object sender, EventArgs e)
        {
            EtatInitial();
        }

        private void GestionDesNoteDuEléves_FormClosing(object sender, FormClosingEventArgs e)
        {
            Mcs.SauvgarderListNote();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EtatInitial();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Mcs.RechercheDoublon(int.Parse(comboBox1.Text), comboBox2.Text))
            {
                textBox3.Text = Mcs.Recherchenote(int.Parse(comboBox1.Text), comboBox2.Text).Note.ToString();
            }
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if (button3.Text == "Modifier")
            //{
            //    #region getion intrface bouton Modifier
            //    textBox1.ReadOnly = true;
            //    textBox2.ReadOnly = true;
            //    textBox3.ReadOnly = false;
               
                
            //    button1.Enabled = false;

            //    #endregion
            //    button2.Text = "Valider";
            //}
           
        }
    }
}
