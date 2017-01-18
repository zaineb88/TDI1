namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.premierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.precedentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suivantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dernierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nouveauToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chercherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste Des Adhérents";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero d\'inscription";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom et prénom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date de Naissance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pays:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ville";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(268, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(268, 166);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(268, 302);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(157, 20);
            this.textBox3.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(268, 196);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Maroc",
            "spain ",
            "France"});
            this.comboBox1.Location = new System.Drawing.Point(268, 230);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(268, 267);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(157, 21);
            this.comboBox2.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Nouveau";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "enregistrer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(369, 344);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "chercher";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(517, 344);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "quitter";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(91, 395);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "premier";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(225, 395);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 18;
            this.button6.Text = "précedent";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(369, 395);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 19;
            this.button7.Text = "suivant";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(517, 395);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 20;
            this.button8.Text = "dernier";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(517, 197);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 22;
            this.button9.Text = "Changer";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Jellyfish;
            this.pictureBox1.Location = new System.Drawing.Point(493, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.enregistrerToolStripMenuItem,
            this.chercherToolStripMenuItem,
            this.quitterToolStripMenuItem,
            this.premierToolStripMenuItem,
            this.precedentToolStripMenuItem,
            this.suivantToolStripMenuItem,
            this.dernierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(710, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            this.nouveauToolStripMenuItem.Click += new System.EventHandler(this.nouveauToolStripMenuItem_Click);
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.enregistrerToolStripMenuItem.Text = "enregistrer";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // chercherToolStripMenuItem
            // 
            this.chercherToolStripMenuItem.Name = "chercherToolStripMenuItem";
            this.chercherToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.chercherToolStripMenuItem.Text = "chercher";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.quitterToolStripMenuItem.Text = "quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // premierToolStripMenuItem
            // 
            this.premierToolStripMenuItem.Name = "premierToolStripMenuItem";
            this.premierToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.premierToolStripMenuItem.Text = "Premier";
            this.premierToolStripMenuItem.Click += new System.EventHandler(this.premierToolStripMenuItem_Click);
            // 
            // precedentToolStripMenuItem
            // 
            this.precedentToolStripMenuItem.Name = "precedentToolStripMenuItem";
            this.precedentToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.precedentToolStripMenuItem.Text = "Precedent";
            this.precedentToolStripMenuItem.Click += new System.EventHandler(this.precedentToolStripMenuItem_Click);
            // 
            // suivantToolStripMenuItem
            // 
            this.suivantToolStripMenuItem.Name = "suivantToolStripMenuItem";
            this.suivantToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.suivantToolStripMenuItem.Text = "suivant";
            this.suivantToolStripMenuItem.Click += new System.EventHandler(this.suivantToolStripMenuItem_Click);
            // 
            // dernierToolStripMenuItem
            // 
            this.dernierToolStripMenuItem.Name = "dernierToolStripMenuItem";
            this.dernierToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.dernierToolStripMenuItem.Text = "Dernier";
            this.dernierToolStripMenuItem.Click += new System.EventHandler(this.dernierToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem1,
            this.enregistrerToolStripMenuItem1,
            this.chercherToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
            // 
            // nouveauToolStripMenuItem1
            // 
            this.nouveauToolStripMenuItem1.Name = "nouveauToolStripMenuItem1";
            this.nouveauToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.nouveauToolStripMenuItem1.Text = "Nouveau";
            this.nouveauToolStripMenuItem1.Click += new System.EventHandler(this.nouveauToolStripMenuItem1_Click);
            // 
            // enregistrerToolStripMenuItem1
            // 
            this.enregistrerToolStripMenuItem1.Name = "enregistrerToolStripMenuItem1";
            this.enregistrerToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.enregistrerToolStripMenuItem1.Text = "enregistrer";
            this.enregistrerToolStripMenuItem1.Click += new System.EventHandler(this.enregistrerToolStripMenuItem1_Click_1);
            // 
            // chercherToolStripMenuItem1
            // 
            this.chercherToolStripMenuItem1.Name = "chercherToolStripMenuItem1";
            this.chercherToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.chercherToolStripMenuItem1.Text = "chercher";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(710, 459);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chercherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem premierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem precedentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suivantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dernierToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chercherToolStripMenuItem1;
    }
}

