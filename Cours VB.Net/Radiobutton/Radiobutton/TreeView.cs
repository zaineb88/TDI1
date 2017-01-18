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
    public partial class TreeView : Form
    {
        public TreeView()
        {
            InitializeComponent();
        }

        private void TreeView_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBox1.Text = treeView1.SelectedNode.Text;
        }
    }
}
