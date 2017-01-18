using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetZainebMazouz
{
    public partial class AjouterElève : Form
    {
        public AjouterElève()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Elève P = new Elève(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Value, textBox4.Text);
        //    Program.GNE.Ajouter_Elève(P);
        //    label7.Text = "Elève Ajouté";
        //    textBox1.Text = Program.GNE.El1.Count.ToString();

        //}

        //public Elève RechercherElève(int matr)
        //{
        //    int i;
        //    for (i = 0; i < El1.Count; i++)
        //    {
        //        if (El1[i].Matricule1 == matr)
        //        { return El1[i]; }
        //    }
        //    return null;
        //}
        //public void Enregister_patient()
        //{
        //    StreamWriter Sr = new StreamWriter("D:\\LesElèves.txt", false);
        //    int i;
        //    for (i = 0; i < El1.Count; i++)
        //    {
        //        Sr.WriteLine(El1[i].ToString());
        //    }
        //    Sr.Close();
        //}
    }
}
