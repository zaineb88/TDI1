namespace Radiobutton
{
    partial class TreeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("TDI");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("TRI");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("NTIC", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("TSC");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("TSGE");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("AGC", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("ISTA", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode13});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode8.Name = "Nœud5";
            treeNode8.Text = "TDI";
            treeNode9.Name = "Nœud7";
            treeNode9.Text = "TRI";
            treeNode10.Name = "Nœud3";
            treeNode10.Text = "NTIC";
            treeNode11.Name = "Nœud9";
            treeNode11.Text = "TSC";
            treeNode12.Name = "Nœud10";
            treeNode12.Text = "TSGE";
            treeNode13.Name = "Nœud8";
            treeNode13.Text = "AGC";
            treeNode14.Name = "Nœud0";
            treeNode14.Text = "ISTA";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode14});
            this.treeView1.Size = new System.Drawing.Size(214, 147);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // TreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 262);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "TreeView";
            this.Text = "TreeView";
            this.Load += new System.EventHandler(this.TreeView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textBox1;
    }
}