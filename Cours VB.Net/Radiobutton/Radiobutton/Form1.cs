﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Radiobutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            { textBox1.Text = "Format:RTF"; }
            else
            { textBox1.Text = "Format:TEXT BRUT"; }
            if (radioButton3.Checked)
            { textBox1.Text += " Sauvegarde Auto :OUI"; }
            else
            { textBox1.Text += " Sauvegarde Auto :NON"; }
             
        
        }
    }
}
