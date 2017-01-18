using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculatrice
{
    public partial class Form1 : Form
    {
        double x, y;
        string operation;
        Boolean new_number = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || new_number == true)
            { textBox1.Text = "2"; new_number = false; }
            else { textBox1.Text = textBox1.Text + "2"; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || new_number == true)
            { textBox1.Text = "1"; new_number = false; }
            else { textBox1.Text = textBox1.Text + "1"; }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || new_number == true)
            { textBox1.Text = "3"; new_number = false; }
            else { textBox1.Text = textBox1.Text + "3"; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || new_number == true)
            { textBox1.Text = "4"; new_number = false; }
            else { textBox1.Text = textBox1.Text + "4"; }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || new_number == true)
            { textBox1.Text = "5"; new_number = false; }
            else { textBox1.Text = textBox1.Text + "5"; }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || new_number == true)
            { textBox1.Text = "6"; new_number = false; }
            else { textBox1.Text = textBox1.Text + "6"; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || new_number == true)
            { textBox1.Text = "7"; new_number = false; }
            else { textBox1.Text = textBox1.Text + "7"; }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || new_number == true)
            { textBox1.Text = "8"; new_number = false; }
            else { textBox1.Text = textBox1.Text + "8"; }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || new_number == true)
            { textBox1.Text = "9"; new_number = false; }
            else { textBox1.Text = textBox1.Text + "9"; }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || new_number == true)
            { textBox1.Text = "0"; new_number = false; }
            else { textBox1.Text = textBox1.Text + "0"; }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(",") == false)
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 1)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            else
                textBox1.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = (-1 * Double.Parse(textBox1.Text)).ToString(); 
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.Sqrt(double.Parse(textBox1.Text))).ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            x = 0;
            operation = "";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
                textBox1.Text = (1 / Double.Parse(textBox1.Text)).ToString();
            else
                textBox1.Text = "Erreur";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            operation = "+";
            x = Double.Parse(textBox1.Text);
            //textBox1.Text = "0";
            new_number = true;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            operation = "-";
            x = Double.Parse(textBox1.Text);
            //textBox1.Text = "0";
            new_number = true;
        }

        private void button28_Click(object sender, EventArgs e)
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
            if (operation == "*")
            {
                textBox1.Text = (x * y).ToString();
            }
            if (operation == "/")
            {
                textBox1.Text = (x / y).ToString();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";

        }

        private void button23_Click(object sender, EventArgs e)
        {
            operation = "*";
            x = Double.Parse(textBox1.Text);
            //textBox1.Text = "0";
            new_number = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            operation = "/";
            x = Double.Parse(textBox1.Text);
            //textBox1.Text = "0";
            new_number = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = ((Double.Parse(textBox1.Text) *x) /100).ToString();
        }
     }
}

