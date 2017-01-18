namespace WindowsFormsApplication1.les_interfaces
{
    partial class CabinetMedical
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
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerSousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.patientAyantDesVisitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rendezVousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.patientToolStripMenuItem,
            this.rendezVousToolStripMenuItem,
            this.visiteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrerToolStripMenuItem,
            this.enregistrerSousToolStripMenuItem,
            this.ouvrirToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // enregistrerSousToolStripMenuItem
            // 
            this.enregistrerSousToolStripMenuItem.Name = "enregistrerSousToolStripMenuItem";
            this.enregistrerSousToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.enregistrerSousToolStripMenuItem.Text = "Enregistrer sous....";
            this.enregistrerSousToolStripMenuItem.Click += new System.EventHandler(this.enregistrerSousToolStripMenuItem_Click);
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir...";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem2,
            this.consulterToolStripMenuItem1,
            this.patientAyantDesVisitesToolStripMenuItem});
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.patientToolStripMenuItem.Text = "Patient";
            this.patientToolStripMenuItem.Click += new System.EventHandler(this.patientToolStripMenuItem_Click);
            // 
            // ajouterToolStripMenuItem2
            // 
            this.ajouterToolStripMenuItem2.Name = "ajouterToolStripMenuItem2";
            this.ajouterToolStripMenuItem2.Size = new System.Drawing.Size(205, 22);
            this.ajouterToolStripMenuItem2.Text = "Ajouter";
            this.ajouterToolStripMenuItem2.Click += new System.EventHandler(this.ajouterToolStripMenuItem2_Click);
            // 
            // consulterToolStripMenuItem1
            // 
            this.consulterToolStripMenuItem1.Name = "consulterToolStripMenuItem1";
            this.consulterToolStripMenuItem1.Size = new System.Drawing.Size(205, 22);
            this.consulterToolStripMenuItem1.Text = "Consulter";
            this.consulterToolStripMenuItem1.Click += new System.EventHandler(this.consulterToolStripMenuItem1_Click);
            // 
            // patientAyantDesVisitesToolStripMenuItem
            // 
            this.patientAyantDesVisitesToolStripMenuItem.Name = "patientAyantDesVisitesToolStripMenuItem";
            this.patientAyantDesVisitesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.patientAyantDesVisitesToolStripMenuItem.Text = "Patient ayant des visites..";
            this.patientAyantDesVisitesToolStripMenuItem.Click += new System.EventHandler(this.patientAyantDesVisitesToolStripMenuItem_Click);
            // 
            // rendezVousToolStripMenuItem
            // 
            this.rendezVousToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem1,
            this.consulterToolStripMenuItem});
            this.rendezVousToolStripMenuItem.Name = "rendezVousToolStripMenuItem";
            this.rendezVousToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.rendezVousToolStripMenuItem.Text = "RendezVous";
            this.rendezVousToolStripMenuItem.Click += new System.EventHandler(this.rendezVousToolStripMenuItem_Click);
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.ajouterToolStripMenuItem1.Text = "Ajouter";
            this.ajouterToolStripMenuItem1.Click += new System.EventHandler(this.ajouterToolStripMenuItem1_Click);
            // 
            // consulterToolStripMenuItem
            // 
            this.consulterToolStripMenuItem.Name = "consulterToolStripMenuItem";
            this.consulterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.consulterToolStripMenuItem.Text = "Consulter";
            this.consulterToolStripMenuItem.Click += new System.EventHandler(this.consulterToolStripMenuItem_Click);
            // 
            // visiteToolStripMenuItem
            // 
            this.visiteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.consulterToolStripMenuItem2});
            this.visiteToolStripMenuItem.Name = "visiteToolStripMenuItem";
            this.visiteToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.visiteToolStripMenuItem.Text = "Visite";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // consulterToolStripMenuItem2
            // 
            this.consulterToolStripMenuItem2.Name = "consulterToolStripMenuItem2";
            this.consulterToolStripMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.consulterToolStripMenuItem2.Text = "Consulter";
            this.consulterToolStripMenuItem2.Click += new System.EventHandler(this.consulterToolStripMenuItem2_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // CabinetMedical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 262);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CabinetMedical";
            this.Text = "CabinetMedical";
            this.Load += new System.EventHandler(this.CabinetMedical_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem consulterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rendezVousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consulterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerSousToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem consulterToolStripMenuItem2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.ToolStripMenuItem patientAyantDesVisitesToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}