namespace GestionDesNotesDesEleves
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
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eléveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.résultatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informationÉlèveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notesElèvesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationDesNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.eléveToolStripMenuItem,
            this.résultatToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // eléveToolStripMenuItem
            // 
            this.eléveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationÉlèveToolStripMenuItem,
            this.notesElèvesToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.eléveToolStripMenuItem.Name = "eléveToolStripMenuItem";
            this.eléveToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.eléveToolStripMenuItem.Text = "Eléve";
            // 
            // résultatToolStripMenuItem
            // 
            this.résultatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultationDesNotesToolStripMenuItem});
            this.résultatToolStripMenuItem.Name = "résultatToolStripMenuItem";
            this.résultatToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.résultatToolStripMenuItem.Text = "Résultat";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposDeToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // informationÉlèveToolStripMenuItem
            // 
            this.informationÉlèveToolStripMenuItem.Name = "informationÉlèveToolStripMenuItem";
            this.informationÉlèveToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.informationÉlèveToolStripMenuItem.Text = "Information élève";
            // 
            // notesElèvesToolStripMenuItem
            // 
            this.notesElèvesToolStripMenuItem.Name = "notesElèvesToolStripMenuItem";
            this.notesElèvesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.notesElèvesToolStripMenuItem.Text = "Notes Elèves";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // consultationDesNotesToolStripMenuItem
            // 
            this.consultationDesNotesToolStripMenuItem.Name = "consultationDesNotesToolStripMenuItem";
            this.consultationDesNotesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.consultationDesNotesToolStripMenuItem.Text = "Consultation des Notes";
            // 
            // aProposDeToolStripMenuItem
            // 
            this.aProposDeToolStripMenuItem.Name = "aProposDeToolStripMenuItem";
            this.aProposDeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aProposDeToolStripMenuItem.Text = "A propos de ...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eléveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationÉlèveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notesElèvesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem résultatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationDesNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aProposDeToolStripMenuItem;
    }
}

