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
    public partial class Liste : Form
    {
        public Liste()
        {
            InitializeComponent();
        }

        private void Liste_Load(object sender, EventArgs e)
        {
            int i;
            ListViewItem L;
            for (i = 1; i <= 20; i++)
            {
                 L = new ListViewItem();
                L.Text = i.ToString();
                L.SubItems.Add((i * i).ToString());
                L.SubItems.Add((i * i * i).ToString());
                listView1.Items.Add(L);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            ListViewItem L;
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Nombre");
            if (checkBox1.Checked)
            { listView1.Columns.Add("Carré"); }
            if (checkBox2.Checked)
            { listView1.Columns.Add("Cube"); }
            for (i = 1; i <= int.Parse(textBox1.Text.ToString()); i++)
            {
                L = new ListViewItem();
                L.Text = i.ToString();
                if (checkBox1.Checked)
                { L.SubItems.Add((i * i).ToString()); }

                if (checkBox2.Checked)
                { L.SubItems.Add((i * i * i).ToString()); }
                listView1.Items.Add(L);
            }
        }
    }
}
