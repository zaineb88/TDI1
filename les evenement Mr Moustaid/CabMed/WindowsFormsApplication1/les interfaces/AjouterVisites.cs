using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.les_interfaces
{
    public partial class Visites : Form
    {
        public Visites()
        {
            InitializeComponent();
        }

        private void Visites_Load(object sender, EventArgs e)
        {
            for(int i=0;i<Program.cb.LP1.Count;i++)
            {
            comboBox1.Items.Add(Program.cb.LP1[i].CodePatient);}
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //if (comboBox1.SelectedItem != null)
            //{
            //    for (int i = 0; i < Program.cb.LP1.Count; i++)

            //        if (Program.cb.LP1[i].CodePatient.ToString() == comboBox1.SelectedItem.ToString())
            //        {
            //            textBox2.Text = Program.cb.LP1[i]..........;;
            //        }
            //}
                
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           //textBox1.Text = Program.cb.RechercherCodePatient
           //     (int.Parse(comboBox1.SelectedItem.ToString())).Nom + "  "
           //     + Program.cb.RechercherCodePatient
           //     (int.Parse(comboBox1.SelectedItem.ToString())).Prénom;
           
            if(comboBox1.SelectedItem!=null)
            {
                for(int i =0;i<Program.cb.LP1.Count;i++)
    

                 if(Program.cb.LP1[i].CodePatient.ToString()==comboBox1.SelectedItem.ToString())
                 {
                 textBox1.Text=Program.cb.LP1[i].Nom+" "+Program.cb.LP1[i].Prénom;
                 }
                 }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visites v = new Visites();
            v.DateVisites = dateTimePicker1.Value;
            v.HeureVisites = dateTimePicker2.Value;
            v.CodePatients = int.Parse(comboBox1.SelectedItem.ToString());
            v.Montantpayé = Double.Parse(textBox1.SelectedItem.ToString());
            Program.cb.Visites.Add(v);
            


        }
    }
}
