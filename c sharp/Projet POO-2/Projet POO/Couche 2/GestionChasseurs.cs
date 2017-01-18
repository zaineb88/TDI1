using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Projet_POO.Couche_Métier;

namespace Projet_POO.Couche_2
{
    public partial class GestionChasseurs : Form
    {

        internal LesChasseurs Chs;
        public GestionChasseurs()
        {
            InitializeComponent();
          
        }

        private void GestionChasseurs_Load(object sender, EventArgs e)
        {
            Chs = new LesChasseurs();
            etatinitial();
            position();
            textenablF();
            button9.Enabled = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {


            if (button5.Text == "Ajouter")
            {
                textenablT();
                textBox1.Clear();
                textBox2.Clear(); textBox4.Clear();
                textBox3.Clear(); textBox5.Clear();
                button5.Text = "Valider";
                buttonEnablF();
                buttonposF(); button9.Enabled = true;


            }
            else 
                           
                // try khesha tkon hna 
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && button5.Text == "Valider")
                {

                    if (Chs.NombreChasseursParticipant <= 0)
                    {
                        buttonposF();
                        button8.Enabled = false;

                    }
                    else
                    {
                        if (Chs.NombreChasseursParticipant == 1)
                        {
                            button8.Enabled = false;
                            buttonposF();
                            button2.Enabled = true;
                            button3.Enabled = true;

                        }
                        else { buttonposT(); button8.Enabled = true; }
                    }



                    Chs.Ajouter(CreerCh());
                    button5.Text = "Ajouter";
                    position(); button9.Enabled = false;

                    button7.Enabled = true;
                    button6.Enabled = true;
                    textenablF();
                }
                else
                {
                    MessageBox.Show("Remplire les zones de text vide .", "Champs vide", MessageBoxButtons.OK);
                }
            }
        }
        
        private Chasseur CreerCh()
        {
            Chasseur ch = new Chasseur();
            ch.NuméroChasseur = int.Parse(textBox1.Text);
            ch.Nom = textBox2.Text;
            ch.Prénom = textBox3.Text;
            ch.Adresse = textBox4.Text;
            ch.Téléphone = textBox5.Text;
            return ch; 
        }
        private void Afficherch(Chasseur ch)
        {
            (textBox1.Text) = ch.NuméroChasseur.ToString();
            textBox2.Text = ch.Nom;
            textBox3.Text = ch.Prénom;
            textBox4.Text = ch.Adresse;
            textBox5.Text = ch.Téléphone;
        
        }

        private void button3_Click(object sender, EventArgs e)
        {if(Chs.PositionChasseursEncours!=-1)
            Afficherch(Chs.Suivant());
        position();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Chs.PositionChasseursEncours != -1)
            {
                Afficherch(Chs.Precedant());
                position();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Chs.PositionChasseursEncours != -1)
            {
                Afficherch(Chs.Premier());
                position();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Chs.PositionChasseursEncours != -1)
            {
                Afficherch(Chs.Dernier());
                position();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Chs.PositionChasseursEncours != -1)
            {


                if (button6.Text == "Modifier")
                {
                    textenablT();
                    button5.Enabled = false;
                    button7.Enabled = false;
                    buttonEnablF();
                    buttonposF();
                    button6.Enabled = true;
                    button6.Text = "Valider";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && button6.Text == "Valider")
                {
                    if (Chs.NombreChasseursParticipant <= 1)
                    {
                        buttonposF();

                    }
                    else if (Chs.NombreChasseursParticipant == 2)
                    {
                        buttonposF();
                        button2.Enabled = true;
                        button3.Enabled = true;
                    }
                    else { buttonposT(); button8.Enabled = true; }
                    button5.Enabled = true;
                    button7.Enabled = true;
                    Chs.Modifier(CreerCh());
                    textenablF();
                    button6.Text = "Modifier";
                }
                else MessageBox.Show("Remplire les zones de text vide .", "Modification", MessageBoxButtons.OK);

            }
            position();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Chs.PositionChasseursEncours != -1)
            {
                if (MessageBox.Show("Voulez vous vraiment supprimer cett chasseur?", "Suppretion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Chs.Supprimer();
                    if (Chs.PositionChasseursEncours != -1)
                    {
                        Afficherch(Chs.ChasseursEncours);
                        position();
                    }

                    else
                    {
                        textBox1.Clear();
                        textBox2.Clear(); textBox4.Clear();
                        textBox3.Clear(); textBox5.Clear();
                        button7.Enabled = false;
                        button6.Enabled = false;
                        position();
                    }

                    if (Chs.NombreChasseursParticipant <= 1)
                    {
                        buttonposF();
                        button8.Enabled = false;

                    }
                    else
                    {
                        if (Chs.NombreChasseursParticipant == 2)
                        {
                            button8.Enabled = false;
                            buttonposF();
                            button2.Enabled = true;
                            button3.Enabled = true;

                        }
                        else { buttonposT(); button8.Enabled = true; }
                    }
                }
            }
            position();
        }
        private void position()
        {
            label6.Text = (Chs.PositionChasseursEncours + 1).ToString() + " / " + Chs.NombreChasseursParticipant.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Recherche rech = new Recherche();
            if (rech.ShowDialog() == DialogResult.OK)//kadar mili kaykon darouri tjaweb (fenétre model)
            {
                if (rech.radioButton2.Checked && rech.textBox1.Text!="")
                {
                    int numch = int.Parse(rech.textBox1.Text);
                    if (Chs.recherche(numch) == null)
                    {
                        MessageBox.Show("non valid", "rechercher", MessageBoxButtons.OK);
                    }
                        else{Afficherch(Chs.recherche(numch));}
                }
                else
                {
                   
                        string nomch = rech.textBox1.Text;
                        if (Chs.recherche(nomch) == null)
                        {
                            MessageBox.Show("non valid .", "rechercher", MessageBoxButtons.OK);
                        }
                        else { Afficherch(Chs.recherche(nomch)); }
                    
                }
            }
               
        }
        #region buttons et textbox enabling
    
        private void etatinitial()
        {
            if (Chs.NombreChasseursParticipant == 0 )
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = true;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;

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
            
            }
          
            if (Chs.NombreChasseursParticipant <= 2)
            {
                button4.Enabled = false;
                button8.Enabled = false;
                button1.Enabled = false;
            }
            if (Chs.NombreChasseursParticipant <= 1)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button8.Enabled = false;
                
            }

        }

        private void textenablF()
        {
            textBox1.Enabled=false;
            textBox1.BackColor = Color.LightGray;
            textBox2.Enabled = false;
            textBox2.BackColor = Color.LightGray;
            textBox3.Enabled = false;
            textBox3.BackColor = Color.LightGray;
            textBox4.Enabled = false;
            textBox4.BackColor = Color.LightGray;
            textBox5.Enabled = false;
            textBox5.BackColor = Color.LightGray;
        
        }
        private void textenablT()
        {
            textBox1.Enabled = true;
            textBox1.BackColor = Color.White;
            textBox2.Enabled = true;
            textBox2.BackColor = Color.White;
            textBox3.Enabled = true;
            textBox3.BackColor = Color.White;
            textBox4.Enabled = true;
            textBox4.BackColor = Color.White;
            textBox5.Enabled = true;
            textBox5.BackColor = Color.White;

        }
        private void buttonEnablF()
        {
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
        }
        private void buttonEnablT()
        {
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true; 
                
        }
        private void buttonposF()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }
        private void buttonposT()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }
        
#endregion 

        private void button9_Click(object sender, EventArgs e)
        {
            if (Chs.PositionChasseursEncours != -1)
            {
                Afficherch(Chs.ChasseursEncours);
                position();
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear(); textBox4.Clear();
                textBox3.Clear(); textBox5.Clear();
            }
            button5.Text = "Ajouter";
            textenablT();
            textenablF();
            button9.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

       
    }
}
