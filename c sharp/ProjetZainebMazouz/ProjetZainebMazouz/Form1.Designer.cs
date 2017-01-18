namespace ProjetZainebMazouz
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.elèveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationsElèveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notesElèveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationDesNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elèveToolStripMenuItem,
            this.resultatToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // elèveToolStripMenuItem
            // 
            this.elèveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationsElèveToolStripMenuItem,
            this.notesElèveToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.elèveToolStripMenuItem.Name = "elèveToolStripMenuItem";
            this.elèveToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.elèveToolStripMenuItem.Text = "Elève";
            // 
            // informationsElèveToolStripMenuItem
            // 
            this.informationsElèveToolStripMenuItem.Name = "informationsElèveToolStripMenuItem";
            this.informationsElèveToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.informationsElèveToolStripMenuItem.Text = "Informations Elève";
            this.informationsElèveToolStripMenuItem.Click += new System.EventHandler(this.informationsElèveToolStripMenuItem_Click);
            // 
            // notesElèveToolStripMenuItem
            // 
            this.notesElèveToolStripMenuItem.Name = "notesElèveToolStripMenuItem";
            this.notesElèveToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.notesElèveToolStripMenuItem.Text = "Notes Elève";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // resultatToolStripMenuItem
            // 
            this.resultatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultationDesNotesToolStripMenuItem});
            this.resultatToolStripMenuItem.Name = "resultatToolStripMenuItem";
            this.resultatToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.resultatToolStripMenuItem.Text = "Resultat";
            // 
            // consultationDesNotesToolStripMenuItem
            // 
            this.consultationDesNotesToolStripMenuItem.Name = "consultationDesNotesToolStripMenuItem";
            this.consultationDesNotesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.consultationDesNotesToolStripMenuItem.Text = "Consultation des Notes";
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
            this.aProposDeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.aProposDeToolStripMenuItem.Text = "A propos de ...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem elèveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationsElèveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notesElèveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationDesNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aProposDeToolStripMenuItem;
    }
}

