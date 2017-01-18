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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void informationsElèveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterElève A = new AjouterElève();
            A.MdiParent = this;
            A.Show();
        }
    }
}
