namespace Projet_POO.Couche_Interface
{
    partial class TournoiDeChasse
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
            this.tournoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionChasseursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationDesResultatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aPropsDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tournoiToolStripMenuItem,
            this.resultatToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(474, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tournoiToolStripMenuItem
            // 
            this.tournoiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionChasseursToolStripMenuItem,
            this.gestionScoresToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.tournoiToolStripMenuItem.Name = "tournoiToolStripMenuItem";
            this.tournoiToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.tournoiToolStripMenuItem.Text = "&Tournoi";
            // 
            // gestionChasseursToolStripMenuItem
            // 
            this.gestionChasseursToolStripMenuItem.Name = "gestionChasseursToolStripMenuItem";
            this.gestionChasseursToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.gestionChasseursToolStripMenuItem.Text = "Gestion &Chasseurs";
            this.gestionChasseursToolStripMenuItem.Click += new System.EventHandler(this.gestionChasseursToolStripMenuItem_Click);
            // 
            // gestionScoresToolStripMenuItem
            // 
            this.gestionScoresToolStripMenuItem.Name = "gestionScoresToolStripMenuItem";
            this.gestionScoresToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.gestionScoresToolStripMenuItem.Text = "Gestion &Scores";
            this.gestionScoresToolStripMenuItem.Click += new System.EventHandler(this.gestionScoresToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // resultatToolStripMenuItem
            // 
            this.resultatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultationDesResultatsToolStripMenuItem});
            this.resultatToolStripMenuItem.Name = "resultatToolStripMenuItem";
            this.resultatToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.resultatToolStripMenuItem.Text = "&Resultat";
            // 
            // consultationDesResultatsToolStripMenuItem
            // 
            this.consultationDesResultatsToolStripMenuItem.Name = "consultationDesResultatsToolStripMenuItem";
            this.consultationDesResultatsToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.consultationDesResultatsToolStripMenuItem.Text = "&Consultation des Resultats";
            this.consultationDesResultatsToolStripMenuItem.Click += new System.EventHandler(this.consultationDesResultatsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aPropsDeToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "&?";
            // 
            // aPropsDeToolStripMenuItem
            // 
            this.aPropsDeToolStripMenuItem.Name = "aPropsDeToolStripMenuItem";
            this.aPropsDeToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.aPropsDeToolStripMenuItem.Text = "A props de..";
            // 
            // TournoiDeChasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 346);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TournoiDeChasse";
            this.Text = "TournoiDeChasse";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tournoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionChasseursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionScoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationDesResultatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aPropsDeToolStripMenuItem;
    }
}