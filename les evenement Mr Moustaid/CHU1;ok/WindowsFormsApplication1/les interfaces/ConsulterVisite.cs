using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.les_interfaces
{
    public partial class ConsulterVisite : Form
    {
        public ConsulterVisite()
        {
            InitializeComponent();
        }

        private void ConsulterVisite_Load(object sender, EventArgs e)
        {
            string[] cellule;

            for (int i = 0; i < Program.CB.LV1.Count; i++)
            {
                cellule = Program.CB.LV1[i].ToString().Split(';');
                dataGridView1.Rows.Add(cellule);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
