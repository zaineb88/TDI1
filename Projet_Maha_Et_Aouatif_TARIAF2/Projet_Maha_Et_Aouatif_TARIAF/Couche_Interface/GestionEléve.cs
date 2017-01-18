using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Projet_Maha_Et_Aouatif_TARIAF.Couche_Metier;


namespace Projet_Maha_Et_Aouatif_TARIAF.Couche_Interface
{
    public partial class GestionEléve : Form
    {
        //internal static Les_Eléves eleve = new Les_Eléves();
        public GestionEléve()
        {
            InitializeComponent();
        }

        private void EtatInitiale()
        {
            if (Program. eleve.NombreEléveParticipant == 0)
            {
                button1.Enabled = true;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                dateTimePicker1.Value = DateTime.Today;

            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = false;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                
            }
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            dateTimePicker1.Value = DateTime.Today;
            button1.Text = "Ajouter";
            button2.Text = "Modifier";


        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Ajouter")
            {
                #region getion intrface bouton Ajouter
                textBox1.Clear(); textBox1.ReadOnly = false;
                textBox2.Clear(); textBox2.ReadOnly = false;
                textBox3.Clear(); textBox3.ReadOnly = false;
                textBox4.Clear(); textBox4.ReadOnly = false;
                dateTimePicker1.Value = DateTime.Today;
               
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button5.Enabled = true;
                button9.Enabled = false;
                #endregion
                button1.Text = "Valider";
            }
            else
            {
                try
                {
                    if (!Program.eleve.RechercheDoublon(int.Parse(textBox1.Text)))
                        Program.eleve.Ajouter(CréerEleve());
                    else MessageBox.Show("Impossible d'ajouter l'eléve: " + textBox2.Text + " , car il y a déja un veleve qui porte ce matricule");
                }
                catch (OccupeExcption ex)
                { MessageBox.Show(ex.Message); }
              
                finally
                {
                    EtatInitiale();
                    //AfficherEléves(eleve.elEncoursposi);
                    label6.Text = EnregistrementEncours();
                }

            }

        }

        //private void AfficherEléves(int p)
        //{
        //    throw new NotImplementedException();
        //}
        private Eléve CréerEleve()
        {
            Eléve e = new Eléve();
           e.Matricule = int.Parse(textBox1.Text);
            e.Nom = textBox2.Text;
            e.Prénom = textBox3.Text;
            e.Adresse = textBox4.Text;
            e.DateDeNaissance = dateTimePicker1.Value;
            return e;
        }

        private void GestionEléve_Load(object sender, EventArgs e)
        {
            EtatInitiale();
            if (Program.eleve.NombreEléveParticipant > 0)
                AfficherEléves(Program.eleve.Premier());
          label6.Text=  EnregistrementEncours();
                
        }
        private void AfficherEléves(Eléve elé)
        {
            if (elé != null)
            {
                textBox1.Text = elé.Matricule.ToString();
                textBox2.Text = elé.Nom;
                textBox3.Text = elé.Prénom;
                
                dateTimePicker1.Value = elé.DateDeNaissance;
                textBox4.Text = elé.Adresse;
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                
                dateTimePicker1.Value = DateTime.Today;
                textBox4.Text = "";
            }
        }
        private String EnregistrementEncours()
        {
            return (Program.eleve.PositionElévesEncours + 1).ToString() + " / " +
               Program.eleve.NombreEléveParticipant.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AfficherEléves(Program.eleve.Premier());
            label6.Text = EnregistrementEncours();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            AfficherEléves(Program.eleve.précedent());
            label6.Text = EnregistrementEncours();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AfficherEléves(Program.eleve.suivent());
            label6.Text = EnregistrementEncours();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AfficherEléves(Program.eleve.Dernier());
            label6.Text = EnregistrementEncours();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Modifier")
            {
                #region getion intrface bouton Modifier
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
                dateTimePicker1.Value = DateTime.Today;
                button1.Enabled = false;
               
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = true;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                #endregion
                button2.Text = "Valider";
            }
            else
            {
                Program.eleve.Modifier(CréerEleve());
                EtatInitiale();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vous voulez vraiment supprimer l'eléve en cours?", "Suppression chasseur!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Program.eleve.Supprimer();
            if (Program.eleve.PositionElévesEncours != -1) AfficherEléves(Program.eleve.elEncoursposi);
            else EtatInitiale();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
      Recherche  Rech = new Recherche();
            if (Rech.ShowDialog() == DialogResult.OK)
            {
                if (Rech.radioButton1.Checked)
                {
                    int matriculeEleve = int.Parse(Rech.textBox1.Text);
                    if (Program.eleve.recherche(matriculeEleve) == null)
                        MessageBox.Show("L'eleve que vous recherchez n'existe pas" + Environment.NewLine + 
                            "Aucun eleve participant porte le numéro :" + matriculeEleve);
                    else { AfficherEléves(Program.eleve.recherche(matriculeEleve)); label6.Text = EnregistrementEncours(); }
                }
                else
                {
                    string nomEleve = Rech.textBox1.Text;
                    if (Program.eleve.Recherche(nomEleve) == null)
                        MessageBox.Show("L'eleve que vous recherchez n'existe pas" + Environment.NewLine + 
                            "Aucun eleve participant ne porte le nom :" + nomEleve);
                    else { AfficherEléves(Program.eleve.Recherche(nomEleve)); label6.Text = EnregistrementEncours(); }

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EtatInitiale();
            AfficherEléves(Program.eleve.elEncoursposi);
        }

        private void GestionEléve_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void GestionEléve_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program. eleve.SauvgarderListEléve();
        }

    }
}
