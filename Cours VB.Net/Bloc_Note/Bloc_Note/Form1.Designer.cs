namespace Bloc_Note
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregitrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerSousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateHeureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionnerToutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.policeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retourAutomatiquementÀLaLigneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barreDétatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.coupierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sélectionnerToutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 240);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(695, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.affichageToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(695, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.ouvrirToolStripMenuItem,
            this.enregitrerToolStripMenuItem,
            this.enregistrerSousToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            this.nouveauToolStripMenuItem.Click += new System.EventHandler(this.nouveauToolStripMenuItem_Click);
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir....";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // enregitrerToolStripMenuItem
            // 
            this.enregitrerToolStripMenuItem.Name = "enregitrerToolStripMenuItem";
            this.enregitrerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.enregitrerToolStripMenuItem.Text = "Enregitrer";
            this.enregitrerToolStripMenuItem.Click += new System.EventHandler(this.enregitrerToolStripMenuItem_Click);
            // 
            // enregistrerSousToolStripMenuItem
            // 
            this.enregistrerSousToolStripMenuItem.Name = "enregistrerSousToolStripMenuItem";
            this.enregistrerSousToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.enregistrerSousToolStripMenuItem.Text = "Enregistrer sous ....";
            this.enregistrerSousToolStripMenuItem.Click += new System.EventHandler(this.enregistrerSousToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.annulerToolStripMenuItem,
            this.dateHeureToolStripMenuItem,
            this.copierToolStripMenuItem,
            this.coperToolStripMenuItem,
            this.collerToolStripMenuItem,
            this.selectionnerToutToolStripMenuItem,
            this.rechercherToolStripMenuItem});
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editionToolStripMenuItem.Text = "Edition";
            // 
            // annulerToolStripMenuItem
            // 
            this.annulerToolStripMenuItem.Name = "annulerToolStripMenuItem";
            this.annulerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.annulerToolStripMenuItem.Text = "Annuler";
            // 
            // dateHeureToolStripMenuItem
            // 
            this.dateHeureToolStripMenuItem.Name = "dateHeureToolStripMenuItem";
            this.dateHeureToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.dateHeureToolStripMenuItem.Text = "Date/Heure";
            this.dateHeureToolStripMenuItem.Click += new System.EventHandler(this.dateHeureToolStripMenuItem_Click);
            // 
            // copierToolStripMenuItem
            // 
            this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
            this.copierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copierToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.copierToolStripMenuItem.Text = "Copier";
            this.copierToolStripMenuItem.Click += new System.EventHandler(this.copierToolStripMenuItem_Click);
            // 
            // coperToolStripMenuItem
            // 
            this.coperToolStripMenuItem.Name = "coperToolStripMenuItem";
            this.coperToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.coperToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.coperToolStripMenuItem.Text = "Couper";
            this.coperToolStripMenuItem.Click += new System.EventHandler(this.coperToolStripMenuItem_Click);
            // 
            // collerToolStripMenuItem
            // 
            this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
            this.collerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.collerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.collerToolStripMenuItem.Text = "Coller";
            this.collerToolStripMenuItem.Click += new System.EventHandler(this.collerToolStripMenuItem_Click);
            // 
            // selectionnerToutToolStripMenuItem
            // 
            this.selectionnerToutToolStripMenuItem.Name = "selectionnerToutToolStripMenuItem";
            this.selectionnerToutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.selectionnerToutToolStripMenuItem.Text = "Selectionner tout";
            this.selectionnerToutToolStripMenuItem.Click += new System.EventHandler(this.selectionnerToutToolStripMenuItem_Click);
            // 
            // rechercherToolStripMenuItem
            // 
            this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
            this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.rechercherToolStripMenuItem.Text = "Rechercher";
            this.rechercherToolStripMenuItem.Click += new System.EventHandler(this.rechercherToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.policeToolStripMenuItem,
            this.retourAutomatiquementÀLaLigneToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // policeToolStripMenuItem
            // 
            this.policeToolStripMenuItem.Name = "policeToolStripMenuItem";
            this.policeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.policeToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.policeToolStripMenuItem.Text = "Police";
            this.policeToolStripMenuItem.Click += new System.EventHandler(this.policeToolStripMenuItem_Click);
            // 
            // retourAutomatiquementÀLaLigneToolStripMenuItem
            // 
            this.retourAutomatiquementÀLaLigneToolStripMenuItem.Checked = true;
            this.retourAutomatiquementÀLaLigneToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.retourAutomatiquementÀLaLigneToolStripMenuItem.Name = "retourAutomatiquementÀLaLigneToolStripMenuItem";
            this.retourAutomatiquementÀLaLigneToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.retourAutomatiquementÀLaLigneToolStripMenuItem.Text = "Retour automatiquement à la ligne";
            this.retourAutomatiquementÀLaLigneToolStripMenuItem.Click += new System.EventHandler(this.retourAutomatiquementÀLaLigneToolStripMenuItem_Click);
            // 
            // affichageToolStripMenuItem
            // 
            this.affichageToolStripMenuItem.Checked = true;
            this.affichageToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.affichageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barreDétatToolStripMenuItem});
            this.affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            this.affichageToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.affichageToolStripMenuItem.Text = "Affichage";
            // 
            // barreDétatToolStripMenuItem
            // 
            this.barreDétatToolStripMenuItem.Checked = true;
            this.barreDétatToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.barreDétatToolStripMenuItem.Name = "barreDétatToolStripMenuItem";
            this.barreDétatToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.barreDétatToolStripMenuItem.Text = "Barre d\'état";
            this.barreDétatToolStripMenuItem.Click += new System.EventHandler(this.barreDétatToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(695, 216);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coupierToolStripMenuItem,
            this.couperToolStripMenuItem,
            this.collerToolStripMenuItem1,
            this.sélectionnerToutToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 92);
            // 
            // coupierToolStripMenuItem
            // 
            this.coupierToolStripMenuItem.Name = "coupierToolStripMenuItem";
            this.coupierToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.coupierToolStripMenuItem.Text = "Copier";
            this.coupierToolStripMenuItem.Click += new System.EventHandler(this.coupierToolStripMenuItem_Click);
            // 
            // couperToolStripMenuItem
            // 
            this.couperToolStripMenuItem.Name = "couperToolStripMenuItem";
            this.couperToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.couperToolStripMenuItem.Text = "Couper";
            this.couperToolStripMenuItem.Click += new System.EventHandler(this.couperToolStripMenuItem_Click);
            // 
            // collerToolStripMenuItem1
            // 
            this.collerToolStripMenuItem1.Name = "collerToolStripMenuItem1";
            this.collerToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.collerToolStripMenuItem1.Text = "Coller";
            this.collerToolStripMenuItem1.Click += new System.EventHandler(this.collerToolStripMenuItem1_Click);
            // 
            // sélectionnerToutToolStripMenuItem
            // 
            this.sélectionnerToutToolStripMenuItem.Name = "sélectionnerToutToolStripMenuItem";
            this.sélectionnerToutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.sélectionnerToutToolStripMenuItem.Text = "Sélectionner tout";
            this.sélectionnerToutToolStripMenuItem.Click += new System.EventHandler(this.sélectionnerToutToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 262);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem policeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem enregitrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerSousToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem annulerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateHeureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectionnerToutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem coupierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sélectionnerToutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barreDétatToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem retourAutomatiquementÀLaLigneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem;

    }
}

