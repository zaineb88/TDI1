using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
        }

        private void Data_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Form1.lesVoyages.nombrevoyage; i++)
            {
            

                string[] cellule = new string[6];
               
                    cellule = Form1.lesVoyages[i].ToString().Split(';');

                    dataGridView1.Rows.Add(cellule);

                
            }
            
            }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Descending);
        }
        }
    }

