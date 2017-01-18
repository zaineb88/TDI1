using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Radiobutton
{
    public partial class CheckBox : Form
    {
        public CheckBox()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            if (checkBox1.Checked || checkBox2.Checked)
            { textBox1.Text = "Format:"; }
         
            if (checkBox1.Checked)
             { textBox1.Text+= " RTF "; }
            if (checkBox2.Checked)
            { textBox1.Text += "  TEXT BUT "; }
             if (checkBox3.Checked ||checkBox4.Checked);
                { textBox1.Text += " Sauvegarde Auto :"; }
            if (checkBox3.Checked)
            {textBox1.Text+=" OUI ";}
            if (checkBox4.Checked)
            {textBox1.Text+=" NON ";}
            
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = " ";
            int i;
            for (i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            { textBox2.Text += checkedListBox1.CheckedItems[i].ToString()+ " "; }
        }
    }
}
