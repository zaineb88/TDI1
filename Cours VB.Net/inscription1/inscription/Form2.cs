using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace inscription
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(listBox1.Items);
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
        }
    }
}
