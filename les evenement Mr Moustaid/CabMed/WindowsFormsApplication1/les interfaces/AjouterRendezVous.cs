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
    public partial class AjouterRendezVous : Form
    {
        public AjouterRendezVous()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem!=null)
            {
                for(int i =0;i<Program.cb.LP1.Count;i++)
    

                 if(Program.cb.LP1[i].CodePatient.ToString()==comboBox1.SelectedItem.ToString())
                 {
                 textBox1.Text=Program.cb.LP1[i].Nom+" "+Program.cb.LP1[i].Prénom;
                 }
                 }
        }
        }
    }

