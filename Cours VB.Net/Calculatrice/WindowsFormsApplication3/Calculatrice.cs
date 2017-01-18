using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Calculatrice : Form
    {
        double x, y, m;
        string operation;
        Boolean Newnumber = false;
        public Calculatrice()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || Newnumber == true)
            { textBox1.Text = "9"; Newnumber = false; }
            else { textBox1.Text = textBox1.Text + "9"; } 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || Newnumber == true)
            { textBox1.Text = "6"; Newnumber = false; }
            else { textBox1.Text = textBox1.Text + "6"; } 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" ||Newnumber == true)
            { textBox1.Text = "3"; Newnumber = false; }
            else { textBox1.Text = textBox1.Text + "3"; } 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || Newnumber == true)
            { textBox1.Text = "1"; Newnumber = false; }
            else { textBox1.Text = textBox1.Text + "1"; } 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || Newnumber == true)
            { textBox1.Text = "2"; Newnumber = false; }
            else { textBox1.Text = textBox1.Text + "2"; } 
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || Newnumber == true)
            { textBox1.Text = "0"; Newnumber = false; }
            else { textBox1.Text = textBox1.Text + "0"; } 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(",") == false)
            { textBox1.Text = textBox1.Text + ","; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || Newnumber == true)
            { textBox1.Text = "4"; Newnumber = false; }
            else { textBox1.Text = textBox1.Text + "4"; } 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || Newnumber == true)
            { textBox1.Text = "5"; Newnumber = false; }
            else { textBox1.Text = textBox1.Text + "5"; } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || Newnumber == true)
            { textBox1.Text = "7"; Newnumber = false; }
            else { textBox1.Text = textBox1.Text + "7"; } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || Newnumber == true)
            { textBox1.Text = "8"; Newnumber = false; }
            else { textBox1.Text = textBox1.Text + "8"; } 
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 1)
            { textBox1.Text = textBox1.Text.Substring(0, textBox1.TextLength - 1); }
            else textBox1.Text = "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = (-1 * Double.Parse(textBox1.Text)).ToString();

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.Sqrt(Double.Parse(textBox1.Text))).ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = ((Double.Parse(textBox1.Text) * x) / 100).ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="0")
            textBox1.Text = (1/Double.Parse(textBox1.Text)).ToString();
            else textBox1.Text="Error";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operation = "+";
            x = double.Parse(textBox1.Text);
            //textBox1.Text = "0";
            Newnumber = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operation = "-";
            x = double.Parse(textBox1.Text);
           // textBox1.Text = "0";
            Newnumber = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            y = Double.Parse(textBox1.Text);
            if (operation == "+")
            {
                textBox1.Text = (x + y).ToString();
            }
            if (operation == "-")
            {
                textBox1.Text = (x - y).ToString();
            }
            if (operation == "/")
            {
                textBox1.Text = (x / y).ToString();
            }
            if (operation == "x")
            {
                textBox1.Text = (x * y).ToString();

                if (operation == "*")
                {
                    textBox1.Text = (x * y).ToString();
                }

            }
            if (operation == "p")
            {
                int i; Double pu = 1;
                for (i = 1; i <= y; i++)
                {
                    pu = pu * x;
                }
                textBox1.Text = pu.ToString();
            }
            if (operation == "r")
            {
                double r;
                r = Math.Pow(x, 1.0 / y);
                textBox1.Text = r.ToString();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operation = "/";
            x = double.Parse(textBox1.Text);
           // textBox1.Text = "0";
            Newnumber = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operation = "x";
            x = double.Parse(textBox1.Text);
           // textBox1.Text = "0";
            Newnumber = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            x = 0;
            y = 0;
            operation = "";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            m = Double.Parse(textBox1.Text);
            Newnumber = true;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = m.ToString();
            Newnumber = true;
        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void aproposDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form x = new Apropos();
            x.Show();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            textBox1.Width = 265;
            this.Width = 293;
            panel2.Left = 11;

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            textBox1.Width = 530;
            this.Width = 558;
            panel2.Left = 283;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Double i, f;
            f = 1;
            for (i = 1; i <=
                Double.Parse(textBox1.Text); i++)
            {
                f = f * i;
            }
            textBox1.Text = f.ToString();
            Newnumber = true;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Double x = Double.Parse(textBox1.Text);
            textBox1.Text = (x * x).ToString();
            Newnumber = true;
        }

        private void button39_Click(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {
            operation = "p";
            x = Double.Parse(textBox1.Text);
            Newnumber = true;
        }

        private void button52_Click(object sender, EventArgs e)
        {
            x = Double.Parse(textBox1.Text);
            textBox1.Text = (Math.Pow(10,x)).ToString();
            Newnumber = true;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Double r;
            x = Double.Parse(textBox1.Text);
            r = Math.Pow(x, (0.3333333333333333));
            textBox1.Text = r.ToString();
            Newnumber = true;
        }

        private void button51_Click(object sender, EventArgs e)
        {
            string[] s = textBox1.Text.Split(',');
            textBox1.Text = s[0];
            Newnumber = true;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            operation = "r";
            x = Double.Parse(textBox1.Text);
            Newnumber = true;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            double=r;
            x=Double.Parse(textBox1.Text);
            if(radioButton1.Checked==true)
                r=Math.Sin(x*Math.PI/180);
            if(radioButton2.Checked==true)
                r=Math.Sin(x);
            if(radioButton3.Checked==true)
             r=Math.Sin(x*200/Math.PI);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
