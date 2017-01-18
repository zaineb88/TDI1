using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Height -= 1;
            pictureBox1.Width -= 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Left -= 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Top -= 4;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Left += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Top += 4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Height += 1;
            pictureBox1.Width += 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void changerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void deplacerEnHautToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Top -= 4;
        }

        private void deplacerEnBasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Top += 4;
        }

        private void versLaDroiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Left += 4;
        }

        private void versLaGaucheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Left -= 4;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            pictureBox1.Height += 1;
            pictureBox1.Width += 1;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pictureBox1.Height -= 1;
            pictureBox1.Width -= 1;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zoomToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            pictureBox1.Height -= 1;
            pictureBox1.Width -= 1;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void zoomToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pictureBox1.Height += 1;
            pictureBox1.Width += 1;
        }

        private void zoomToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            pictureBox1.Height -= 1;
            pictureBox1.Width -= 1;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }
    }
}
