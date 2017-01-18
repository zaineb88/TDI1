using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bloc_Note
{
    public partial class Rechercher : Form
    {
        public Rechercher()
        {
            InitializeComponent();
        }

        private void Rechercher_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.chaine = textBox1.Text;
           // Police.ActiveForm.Activate();
            Program.chercher = true;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
