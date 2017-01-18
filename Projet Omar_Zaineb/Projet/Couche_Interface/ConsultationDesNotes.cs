using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormApplication1.Couche_Metier;
using WindowsFormApplication1.Couche_Interface;
namespace WindowsFormApplication1.Couche_Interface
{
    public partial class ConsultationDesNotes : Form
    {
        public ConsultationDesNotes()
        {
            InitializeComponent();
        }
        string moyenneDesEleves;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.eleve.E1.Count; i++)
            {
                if (comboBox1.SelectedItem.ToString() == Program.eleve.E1[i].Matricule.ToString())
                {

                    label6.Text = Program.eleve.E1[i].Matricule.ToString();
                    label7.Text = Program.eleve.E1[i].Nom;
                    label8.Text = Program.eleve.E1[i].Prénom;
                    label10.Text = Program.eleve.E1[i].Adresse;
                    label9.Text = Program.eleve.E1[i].DateDeNaissance.ToShortDateString();
                Afficher(int.Parse(   comboBox1.Text ) );
                    label11.Text = moyenneDesEleves;


                }

            }
            
          
        }

        private void Afficher(int matricule)
        {
            dataGridView1.Rows.Clear();
            lesmatier();

            float moyen = 0;
            string mat;
            try
            {
                for (int i = 0; i <GestionDesNoteDuEléves.Mcs. NombreNote; i++)
                {
                    for (int k = 0; k < 8; k++)
                    {
                        switch (k)
                        {
                            case (0): mat = "Arabe"; break;
                            case (1): mat = "Education Religieuse"; break;
                            case (2): mat = "Histoire géographie"; break;
                            case (3): mat = "Français"; break;
                            case (4): mat = "Mathématique"; break;
                            case (5): mat = "Physique"; break;
                            case (6): mat = "Science Naturelle"; break;
                            default: mat = "Education physique"; break;

                        }




                        if (GestionDesNoteDuEléves.Mcs.RechercheDoublon(matricule, mat))
                        {

                            dataGridView1.Rows[k].Cells[1].Value = GestionDesNoteDuEléves.Mcs.Recherchenote(matricule, mat).Note.ToString();
                            moyen += GestionDesNoteDuEléves.Mcs.Recherchenote(matricule, mat).Note;

                        }
                        else

                            dataGridView1.Rows[k].Cells[1].Value = "0";

                      
                    }

                }
                moyenneDesEleves = "Sa moyenne est :  " + ((moyen / GestionDesNoteDuEléves.Mcs.NombreNote) / 8).ToString();
            }






            catch { }
        }

        private void lesmatier()
        {
            string mat;
            for (int k = 0; k < 8; k++)
            {
                switch (k)
                {
                    case (0): mat = "Arabe"; break;
                    case (1): mat = "Education Religieuse"; break;
                    case (2): mat = "Histoire géographie"; break;
                    case (3): mat = "Français"; break;
                    case (4): mat = "Mathématique"; break;
                    case (5): mat = "Physique"; break;
                    case (6): mat = "Science Naturelle"; break;
                    default: mat = "Education physique"; break;

                }
                dataGridView1.Rows.Add(mat);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }
        

        private void ConsultationDesNotes_Load(object sender, EventArgs e)
        {
            lesmatier();
        }

        private void EtatInitial()
        {
            if (Program.eleve.NombreEléveParticipant > 0)
            {
                comboBox1.Items.Clear();

                for (int i = 0; i < Program.eleve.E1.Count; i++)
                {
                    comboBox1.Items.Add(Program.eleve.E1[i].Matricule);

                }
                //comboBox1.Text = ""; 
                comboBox1.Enabled = true;  

            }
            else
            {
                comboBox1.Text = ""; comboBox1.Enabled = false;

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Eléve l=new Eléve ();
            float moyen=0;
            float moye=0;
            
            string mat;
            for (int i = 0; i < Program.eleve.NombreEléveParticipant; i++)
            {
                for (int j = 0; j < GestionDesNoteDuEléves.Mcs.NombreNote; j++)
                {
                    float note = 0;
                    for (int k = 0; k < 8; k++)
                    {
                        switch (k)
                        {
                            case (0): mat = "Arabe"; break;
                            case (1): mat = "Education Religieuse"; break;
                            case (2): mat = "Histoire géographie"; break;
                            case (3): mat = "Français"; break;
                            case (4): mat = "Mathématique"; break;
                            case (5): mat = "Physique"; break;
                            case (6): mat = "Science Naturelle"; break;
                            default: mat = "Education physique"; break;

                        }




                        if (GestionDesNoteDuEléves.Mcs.RechercheDoublon(Program.eleve.E1[i].Matricule, mat))
                        {

                            note += GestionDesNoteDuEléves.Mcs.Recherchenote(Program.eleve.E1[i].Matricule, mat).Note;


                        }
                       

                       
                        
                        }
                    moyen = note  / 8;
                }
             
             if (moye < moyen)
             {
                 moye = moyen;
                 l = Program.eleve.E1[i];
             }

            }
           MessageBox.Show("  le premier de la classe est : "+l.Nom+"  " +l.Prénom+"   Et sa moyenne est  "+moye+" .");
        }

        private void ConsultationDesNotes_Activated(object sender, EventArgs e)
        {
           EtatInitial();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        }
    }

