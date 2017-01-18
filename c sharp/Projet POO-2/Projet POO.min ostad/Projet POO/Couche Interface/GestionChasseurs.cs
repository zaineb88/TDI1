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
    public partial class GestionChasseurs : Form
    {
        internal static LesChasseurs Chs= new LesChasseurs();
              
        
        public GestionChasseurs()
        {
            InitializeComponent();
            //Chs= new LesChasseurs();
        }

        private void EtatInitiale() 
        {
            if (Chs.NombreChasseursParticipant == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = true;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();


                           }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = false;
               
            }
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            button5.Text = "Ajouter";
            button6.Text = "Modifier";
            
        }
        private void GestionChasseurs_Load(object sender, EventArgs e)
        {
            
            EtatInitiale();
            if (Chs.NombreChasseursParticipant > 0) AfficherChasseur(Chs.Premier());
            label6.Text = EnregistrementEncours();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Ajouter")
            {
                #region getion intrface bouton Ajouter
                textBox1.Clear(); textBox1.ReadOnly = false;
                textBox2.Clear(); textBox2.ReadOnly = false;
                textBox3.Clear(); textBox3.ReadOnly = false;
                textBox4.Clear(); textBox4.ReadOnly = false;
                textBox5.Clear(); textBox5.ReadOnly = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = true;
                #endregion
                button5.Text = "Valider";
            }
            else
            {
                try
                {
                    if (!Chs.RechercheDoublon(int.Parse(textBox1.Text)))
                        Chs.Ajouter(CréerChasseur());
                    else MessageBox.Show("Impossible d'ajouter le chasseur: " + textBox2.Text + " , car il y a déja un vchasseur qui porte ce numéro");
                }
                catch(DepacementNombrePartissipantException ex)
                {MessageBox.Show(ex.MessageDétaillé);}
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
                finally{
                EtatInitiale();
                AfficherChasseur(Chs.ChasseurEncours);
                label6.Text = EnregistrementEncours();
                }

            }
        }

        private Chasseur CréerChasseur()
        {
            Chasseur ch = new Chasseur();
            ch.NuméroChasseur = int.Parse(textBox1.Text);
            ch.Nom = textBox2.Text;
            ch.Prénom = textBox3.Text;
            ch.Adresse = textBox4.Text;
            ch.Téléphone = textBox5.Text;
            return ch;
        }

        private void AfficherChasseur( Chasseur ch)
        {
            if (ch != null)
            {
                textBox1.Text = ch.NuméroChasseur.ToString();
                textBox2.Text = ch.Nom;
                textBox3.Text = ch.Prénom;
                textBox4.Text = ch.Adresse;
                textBox5.Text = ch.Téléphone;
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AfficherChasseur( Chs.Suivant());
            label6.Text = EnregistrementEncours();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AfficherChasseur( Chs.Dernier());
            label6.Text = EnregistrementEncours();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AfficherChasseur(Chs.Précedent());
            label6.Text = EnregistrementEncours();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AfficherChasseur(Chs.Premier());
            label6.Text = EnregistrementEncours();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "Modifier")
            {
                #region getion intrface bouton Modifier
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
                textBox5.ReadOnly = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = true;
                #endregion
                button6.Text = "Valider";
            }
            else
            {
                Chs.Modifier(CréerChasseur());
                EtatInitiale();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vous voulez vraiment supprimer le chasseur en cours?", "Suppression chasseur!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Chs.Supprimer();
            if (Chs.posChasseurEncours != -1) AfficherChasseur(Chs.ChasseurEncours);
            else EtatInitiale();
           
            label6.Text = EnregistrementEncours();
        }

        private String EnregistrementEncours()
        {
            return (Chs.posChasseurEncours + 1).ToString() + " / " + Chs.NombreChasseursParticipant.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Recherche Rech = new Recherche();
            if (Rech.ShowDialog() == DialogResult.OK)
            {
                if (Rech.radioButton1.Checked)
                {
                    int numchass = int.Parse(Rech.textBox1.Text);
                    if (Chs.Recherche(numchass) == null)
                        MessageBox.Show("Le chasseur que vous recherchez n'existe pas" + Environment.NewLine + "Aucun chasseur participant porte le numéro :" + numchass);
                    else { AfficherChasseur(Chs.Recherche(numchass)); label6.Text = EnregistrementEncours(); }
                }
                else {
                    string nomchass = Rech.textBox1.Text;
                    if (Chs.Recherche(nomchass) == null)
                        MessageBox.Show("Le chasseur que vous recherchez n'existe pas" + Environment.NewLine + "Aucun chasseur participant ne porte le nom :" + nomchass);
                    else { AfficherChasseur(Chs.Recherche(nomchass)); label6.Text = EnregistrementEncours(); }
                
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            EtatInitiale();
            AfficherChasseur(Chs.ChasseurEncours);
        }

        private void GestionChasseurs_FormClosing(object sender, FormClosingEventArgs e)
        {
            Chs.SauvgarderListChasseur();
        }

        
    }
}
