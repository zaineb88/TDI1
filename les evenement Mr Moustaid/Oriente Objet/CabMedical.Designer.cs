namespace Oriente_Objet
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
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rendezVousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Fichier = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Fichier,
            this.patientToolStripMenuItem,
            this.rendezVousToolStripMenuItem,
            this.visitesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(369, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.consulterToolStripMenuItem});
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // rendezVousToolStripMenuItem
            // 
            this.rendezVousToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem1,
            this.consulterToolStripMenuItem1});
            this.rendezVousToolStripMenuItem.Name = "rendezVousToolStripMenuItem";
            this.rendezVousToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.rendezVousToolStripMenuItem.Text = "RendezVous";
            // 
            // visitesToolStripMenuItem
            // 
            this.visitesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem2,
            this.consulterToolStripMenuItem2});
            this.visitesToolStripMenuItem.Name = "visitesToolStripMenuItem";
            this.visitesToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.visitesToolStripMenuItem.Text = "Visites";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // consulterToolStripMenuItem
            // 
            this.consulterToolStripMenuItem.Name = "consulterToolStripMenuItem";
            this.consulterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.consulterToolStripMenuItem.Text = "Consulter";
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.ajouterToolStripMenuItem1.Text = "Ajouter";
            // 
            // consulterToolStripMenuItem1
            // 
            this.consulterToolStripMenuItem1.Name = "consulterToolStripMenuItem1";
            this.consulterToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.consulterToolStripMenuItem1.Text = "Consulter";
            // 
            // Fichier
            // 
            this.Fichier.Name = "Fichier";
            this.Fichier.Size = new System.Drawing.Size(54, 20);
            this.Fichier.Text = "Fichier";
            // 
            // ajouterToolStripMenuItem2
            // 
            this.ajouterToolStripMenuItem2.Name = "ajouterToolStripMenuItem2";
            this.ajouterToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.ajouterToolStripMenuItem2.Text = "Ajouter";
            // 
            // consulterToolStripMenuItem2
            // 
            this.consulterToolStripMenuItem2.Name = "consulterToolStripMenuItem2";
            this.consulterToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.consulterToolStripMenuItem2.Text = "Consulter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 262);
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
        private System.Windows.Forms.ToolStripMenuItem Fichier;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rendezVousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consulterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem visitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem consulterToolStripMenuItem2;
    }
}

