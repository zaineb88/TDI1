namespace Projet_Maha_Et_Aouatif_TARIAF.Couche_Interface
{
    partial class TournoiDesEléves
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eléveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionEléveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eléveToolStripMenuItem,
            this.resultatToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(748, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eléveToolStripMenuItem
            // 
            this.eléveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionEléveToolStripMenuItem,
            this.gestioToolStripMenuItem,
            this.quiterToolStripMenuItem});
            this.eléveToolStripMenuItem.Name = "eléveToolStripMenuItem";
            this.eléveToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.eléveToolStripMenuItem.Text = "Eléve";
            // 
            // gestionEléveToolStripMenuItem
            // 
            this.gestionEléveToolStripMenuItem.Name = "gestionEléveToolStripMenuItem";
            this.gestionEléveToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.gestionEléveToolStripMenuItem.Text = "GestionEléve";
            this.gestionEléveToolStripMenuItem.Click += new System.EventHandler(this.gestionEléveToolStripMenuItem_Click);
            // 
            // gestioToolStripMenuItem
            // 
            this.gestioToolStripMenuItem.Name = "gestioToolStripMenuItem";
            this.gestioToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.gestioToolStripMenuItem.Text = "Gestion des eléves";
            this.gestioToolStripMenuItem.Click += new System.EventHandler(this.gestioToolStripMenuItem_Click);
            // 
            // quiterToolStripMenuItem
            // 
            this.quiterToolStripMenuItem.Name = "quiterToolStripMenuItem";
            this.quiterToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.quiterToolStripMenuItem.Text = "Quiter";
            this.quiterToolStripMenuItem.Click += new System.EventHandler(this.quiterToolStripMenuItem_Click);
            // 
            // resultatToolStripMenuItem
            // 
            this.resultatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulterToolStripMenuItem});
            this.resultatToolStripMenuItem.Name = "resultatToolStripMenuItem";
            this.resultatToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.resultatToolStripMenuItem.Text = "Resultat";
            // 
            // consulterToolStripMenuItem
            // 
            this.consulterToolStripMenuItem.Name = "consulterToolStripMenuItem";
            this.consulterToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.consulterToolStripMenuItem.Text = "Consulter ";
            this.consulterToolStripMenuItem.Click += new System.EventHandler(this.consulterToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposDeToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aProposDeToolStripMenuItem
            // 
            this.aProposDeToolStripMenuItem.Name = "aProposDeToolStripMenuItem";
            this.aProposDeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.aProposDeToolStripMenuItem.Text = "A propos  de";
            this.aProposDeToolStripMenuItem.Click += new System.EventHandler(this.aProposDeToolStripMenuItem_Click);
            // 
            // TournoiDesEléves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 644);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TournoiDesEléves";
            this.Text = "TournoiDesEléves";
            this.Load += new System.EventHandler(this.TournoiDesEléves_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eléveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionEléveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aProposDeToolStripMenuItem;
    }
}