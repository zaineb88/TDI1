using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ping
{
    public partial class Form1 : Form
    {  
        enum position
        { 
        left,right,up,down
        }
        int points = 0;
        int _x1, _y1;
        int  y2;
        public Form1()
        {
            InitializeComponent();
            _x1 = 2;
            _y1 = 2;
            y2 = 20;
       
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Left -= _x1;
            pictureBox2.Top += _y1;
            //if (pictureBox2.Left <= pictureBox3.Right && pictureBox2.Top >= pictureBox3.Top && pictureBox2.Bottom <= pictureBox3.Bottom && pictureBox2.Left > pictureBox3.Left)
            if (pictureBox2.Left <= pictureBox1.Right-5 && pictureBox2.Left >= pictureBox1.Left  && pictureBox2.Top>= pictureBox1.Top+20  && pictureBox2.Bottom <= pictureBox1.Bottom+10)
            {
                y2 += 3;
                 _x1 += 1;
                _y1 += 1;
                _x1 = -_x1;
                points++;
                label2.Text = points.ToString();
            }
            if (pictureBox2.Bottom <= panel1.Bottom)
            {
                _y1 = -_y1;
            }
            if (pictureBox2.Top >= panel1.Top)
            {
                _y1 = -_y1;
            }
            if (pictureBox2.Right >= panel1.Right)
            {
                _x1 = -_x1;
            }

            if (pictureBox2.Right <= panel1.Left)
            {
                timer1.Enabled = false;
                

            }
          
                

            //x2 += 1;
            //y2 += 1;
            ////x2 = -x2;
         

           Invalidate();
            //this.Refresh();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (pictureBox1.Top+27 >= panel1.Top && timer1.Enabled)
            {
                if (e.KeyCode == Keys.Up)
                {

                
                    pictureBox1.Top -= y2;
                }
            }
             if(pictureBox1.Bottom <= panel1.Bottom+30 && timer1.Enabled)
            {
                    if(e.KeyCode == Keys.Down)
                {
                    pictureBox1.Top += y2;
                }
            }
             if (e.KeyCode == Keys.Escape)
             {
                 this.Close();
             }
             if (e.KeyCode == Keys.N)
             {
                 pictureBox2.Top = 30;
                 pictureBox2.Left = 300;
                 points = 0;
                 _x1 = 2;
                 _y1 = 2;
                 y2 = 20;
                 label2.Text = "0";
                 timer1.Enabled = true;
             }
        }

     

        
    }
        }

