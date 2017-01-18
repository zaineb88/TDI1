namespace WindowsFormsApplication5
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zoomToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.changerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deplacementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deplacerEnHautToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deplacerEnBasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versLaDroiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versLaGaucheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(595, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkOrange;
            this.button2.Location = new System.Drawing.Point(595, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "+";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkOrange;
            this.button3.Location = new System.Drawing.Point(117, 376);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "←";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DarkOrange;
            this.button4.Location = new System.Drawing.Point(223, 376);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 34);
            this.button4.TabIndex = 3;
            this.button4.Text = "→";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.DarkOrange;
            this.button5.Location = new System.Drawing.Point(170, 376);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 34);
            this.button5.TabIndex = 4;
            this.button5.Text = "↓";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.DarkOrange;
            this.button6.Location = new System.Drawing.Point(170, 336);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(47, 34);
            this.button6.TabIndex = 5;
            this.button6.Text = "↑";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(527, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Zoom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(15, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Deplacer";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.DarkOrange;
            this.button7.Location = new System.Drawing.Point(348, 372);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(121, 38);
            this.button7.TabIndex = 9;
            this.button7.Text = "Changer Image";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem1,
            this.zoomToolStripMenuItem2,
            this.loadToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // zoomToolStripMenuItem1
            // 
            this.zoomToolStripMenuItem1.Name = "zoomToolStripMenuItem1";
            this.zoomToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.zoomToolStripMenuItem1.Text = "Zoom +";
            this.zoomToolStripMenuItem1.Click += new System.EventHandler(this.zoomToolStripMenuItem1_Click);
            // 
            // zoomToolStripMenuItem2
            // 
            this.zoomToolStripMenuItem2.Name = "zoomToolStripMenuItem2";
            this.zoomToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.zoomToolStripMenuItem2.Text = "Zoom -";
            this.zoomToolStripMenuItem2.Click += new System.EventHandler(this.zoomToolStripMenuItem2_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "Changer";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem,
            this.changerToolStripMenuItem,
            this.deplacementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(659, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // changerToolStripMenuItem
            // 
            this.changerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.changerToolStripMenuItem.Name = "changerToolStripMenuItem";
            this.changerToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.changerToolStripMenuItem.Text = "changer";
            this.changerToolStripMenuItem.Click += new System.EventHandler(this.changerToolStripMenuItem_Click);
            // 
            // deplacementToolStripMenuItem
            // 
            this.deplacementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deplacerEnHautToolStripMenuItem,
            this.deplacerEnBasToolStripMenuItem,
            this.versLaDroiteToolStripMenuItem,
            this.versLaGaucheToolStripMenuItem});
            this.deplacementToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deplacementToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.deplacementToolStripMenuItem.Name = "deplacementToolStripMenuItem";
            this.deplacementToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.deplacementToolStripMenuItem.Text = "deplacement";
            // 
            // deplacerEnHautToolStripMenuItem
            // 
            this.deplacerEnHautToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.deplacerEnHautToolStripMenuItem.Name = "deplacerEnHautToolStripMenuItem";
            this.deplacerEnHautToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.deplacerEnHautToolStripMenuItem.Text = "Deplacer en haut";
            this.deplacerEnHautToolStripMenuItem.Click += new System.EventHandler(this.deplacerEnHautToolStripMenuItem_Click);
            // 
            // deplacerEnBasToolStripMenuItem
            // 
            this.deplacerEnBasToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.deplacerEnBasToolStripMenuItem.Name = "deplacerEnBasToolStripMenuItem";
            this.deplacerEnBasToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.deplacerEnBasToolStripMenuItem.Text = "Deplacer en bas";
            this.deplacerEnBasToolStripMenuItem.Click += new System.EventHandler(this.deplacerEnBasToolStripMenuItem_Click);
            // 
            // versLaDroiteToolStripMenuItem
            // 
            this.versLaDroiteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.versLaDroiteToolStripMenuItem.Name = "versLaDroiteToolStripMenuItem";
            this.versLaDroiteToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.versLaDroiteToolStripMenuItem.Text = "Vers la droite";
            this.versLaDroiteToolStripMenuItem.Click += new System.EventHandler(this.versLaDroiteToolStripMenuItem_Click);
            // 
            // versLaGaucheToolStripMenuItem
            // 
            this.versLaGaucheToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.versLaGaucheToolStripMenuItem.Name = "versLaGaucheToolStripMenuItem";
            this.versLaGaucheToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.versLaGaucheToolStripMenuItem.Text = "Vers la gauche";
            this.versLaGaucheToolStripMenuItem.Click += new System.EventHandler(this.versLaGaucheToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Image = global::WindowsFormsApplication5.Properties.Resources.DSC02392;
            this.pictureBox1.Location = new System.Drawing.Point(170, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "Zoom +";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.zoomToolStripMenuItem3});
            this.zoomToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoomToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.zoomToolStripMenuItem.Text = "zoom";
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem3
            // 
            this.zoomToolStripMenuItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.zoomToolStripMenuItem3.Name = "zoomToolStripMenuItem3";
            this.zoomToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.zoomToolStripMenuItem3.Text = "Zoom -";
            this.zoomToolStripMenuItem3.Click += new System.EventHandler(this.zoomToolStripMenuItem3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(659, 429);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem changerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deplacementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deplacerEnHautToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deplacerEnBasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versLaDroiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versLaGaucheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem3;
    }
}

