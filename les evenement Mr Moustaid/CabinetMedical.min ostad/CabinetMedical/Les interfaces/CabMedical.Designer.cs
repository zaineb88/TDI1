namespace CabinetMedical
{
    partial class CabMedical
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
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerSousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rendezVousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.visiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposDeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.patientsAyantDesVisitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientToolStripMenuItem,
            this.patientToolStripMenuItem1,
            this.rendezVousToolStripMenuItem,
            this.visiteToolStripMenuItem,
            this.aProposDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(635, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem,
            this.toolStripMenuItem1,
            this.enregistrerSousToolStripMenuItem,
            this.toolStripMenuItem2});
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.patientToolStripMenuItem.Text = "Fichier";
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItem1.Text = "Enregistrer";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // enregistrerSousToolStripMenuItem
            // 
            this.enregistrerSousToolStripMenuItem.Name = "enregistrerSousToolStripMenuItem";
            this.enregistrerSousToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.enregistrerSousToolStripMenuItem.Text = "Enregistrer sous";
            this.enregistrerSousToolStripMenuItem.Click += new System.EventHandler(this.enregistrerSousToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItem2.Text = "Quitter";
            // 
            // patientToolStripMenuItem1
            // 
            this.patientToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.consulterToolStripMenuItem,
            this.patientsAyantDesVisitesToolStripMenuItem});
            this.patientToolStripMenuItem1.Name = "patientToolStripMenuItem1";
            this.patientToolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.patientToolStripMenuItem1.Text = "Patient";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // consulterToolStripMenuItem
            // 
            this.consulterToolStripMenuItem.Name = "consulterToolStripMenuItem";
            this.consulterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.consulterToolStripMenuItem.Text = "Consulter";
            this.consulterToolStripMenuItem.Click += new System.EventHandler(this.consulterToolStripMenuItem_Click);
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
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.ajouterToolStripMenuItem1.Text = "Ajouter";
            this.ajouterToolStripMenuItem1.Click += new System.EventHandler(this.ajouterToolStripMenuItem1_Click);
            // 
            // consulterToolStripMenuItem1
            // 
            this.consulterToolStripMenuItem1.Name = "consulterToolStripMenuItem1";
            this.consulterToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.consulterToolStripMenuItem1.Text = "Consulter";
            // 
            // visiteToolStripMenuItem
            // 
            this.visiteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem2,
            this.consulterToolStripMenuItem2});
            this.visiteToolStripMenuItem.Name = "visiteToolStripMenuItem";
            this.visiteToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.visiteToolStripMenuItem.Text = "Visite";
            // 
            // ajouterToolStripMenuItem2
            // 
            this.ajouterToolStripMenuItem2.Name = "ajouterToolStripMenuItem2";
            this.ajouterToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.ajouterToolStripMenuItem2.Text = "Ajouter";
            this.ajouterToolStripMenuItem2.Click += new System.EventHandler(this.ajouterToolStripMenuItem2_Click);
            // 
            // consulterToolStripMenuItem2
            // 
            this.consulterToolStripMenuItem2.Name = "consulterToolStripMenuItem2";
            this.consulterToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.consulterToolStripMenuItem2.Text = "Consulter";
            // 
            // aProposDeToolStripMenuItem
            // 
            this.aProposDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposDeToolStripMenuItem1});
            this.aProposDeToolStripMenuItem.Name = "aProposDeToolStripMenuItem";
            this.aProposDeToolStripMenuItem.Size = new System.Drawing.Size(24, 20);
            this.aProposDeToolStripMenuItem.Text = "?";
            this.aProposDeToolStripMenuItem.Click += new System.EventHandler(this.aProposDeToolStripMenuItem_Click);
            // 
            // aProposDeToolStripMenuItem1
            // 
            this.aProposDeToolStripMenuItem1.Name = "aProposDeToolStripMenuItem1";
            this.aProposDeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aProposDeToolStripMenuItem1.Text = "A propos de";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // patientsAyantDesVisitesToolStripMenuItem
            // 
            this.patientsAyantDesVisitesToolStripMenuItem.Name = "patientsAyantDesVisitesToolStripMenuItem";
            this.patientsAyantDesVisitesToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.patientsAyantDesVisitesToolStripMenuItem.Text = "Patients ayant des visites";
            this.patientsAyantDesVisitesToolStripMenuItem.Click += new System.EventHandler(this.patientsAyantDesVisitesToolStripMenuItem_Click);
            // 
            // CabMedical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 485);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CabMedical";
            this.Text = "Cabinet Medical";
            this.Load += new System.EventHandler(this.CabMedical_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rendezVousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consulterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem consulterToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aProposDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposDeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem enregistrerSousToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem patientsAyantDesVisitesToolStripMenuItem;
    }
}

