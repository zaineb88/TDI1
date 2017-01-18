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
    public partial class Police : Form
    {FontStyle Style = new FontStyle();
        public Police()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
               label4.Font = new Font(textBox1.Text.ToString(),float.Parse(textBox3.Text.ToString()));
          
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = listBox2.SelectedItem.ToString();
            
            if (listBox2.SelectedItem.ToString() == "Bold")
            { Style = FontStyle.Bold; }
            if (listBox2.SelectedItem.ToString() == "Italic")
            { Style = FontStyle.Italic; }
            if (listBox2.SelectedItem.ToString() == "Regular")
            { Style = FontStyle.Regular; }
            if (listBox2.SelectedItem.ToString() == "Underline")
            { Style = FontStyle.Underline; }
            if (listBox2.SelectedItem.ToString() == "Strikeout")
            { Style = FontStyle.Strikeout; }
            label4.Font = new Font(textBox1.Text.ToString(),float.Parse(textBox3.Text.ToString()),Style);
        }

        private void Police_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Arial");
            listBox1.Items.Add("ALGERIAN");
            listBox1.Items.Add("Comic Sans MS");
            listBox1.Items.Add("Times New Roman");
            listBox1.Items.Add("Tahoma");
            listBox1.Items.Add("Microsoft Sans Serif");
            listBox2.Items.Clear();
            listBox2.Items.Add(FontStyle.Bold);
            listBox2.Items.Add(FontStyle.Italic);
            listBox2.Items.Add(FontStyle.Regular);
            listBox2.Items.Add(FontStyle.Underline);
            listBox2.Items.Add(FontStyle.Strikeout);
            textBox1.Text = Font.Name;
            //textBox2.Text = FontStyle.Bold.ToString();
            textBox1.Text = Font.FontFamily.Name;
            textBox2.Text = Font.Style.ToString();
            textBox3.Text = Font.Size.ToString();
            listBox3.Items.Clear();
            for (int i = 8; i < 12; i++)
            {
                listBox3.Items.Add(i.ToString());
            }
            for (int i = 12; i <= 72; i=i+2)
            {
                listBox3.Items.Add(i.ToString());
            }
           
            //comboBox1.Items.Add(Font.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = listBox3.SelectedItem.ToString();
               label4.Font = new Font(textBox1.Text.ToString(),float.Parse(textBox3.Text.ToString()));
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.S = new Font(textBox1.Text.ToString(), float.Parse(textBox3.Text.ToString()), Style);
            Program.C = label4.ForeColor;
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\Fonts");//http\\wwww.google.com
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.ForeColor = System.Drawing.Color.FromName(comboBox2.Text);
        }
        
    }
}
