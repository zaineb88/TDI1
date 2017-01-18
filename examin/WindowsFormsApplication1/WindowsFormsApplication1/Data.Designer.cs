namespace WindowsFormsApplication1
{
    partial class Data
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomcomplet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Nomcomplet,
            this.Date,
            this.Duree,
            this.Ville,
            this.Matricule});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 208);
            this.dataGridView1.TabIndex = 0;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            // 
            // Nomcomplet
            // 
            this.Nomcomplet.HeaderText = "Nom complet";
            this.Nomcomplet.Name = "Nomcomplet";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date depart";
            this.Date.Name = "Date";
            // 
            // Duree
            // 
            this.Duree.HeaderText = "Duree";
            this.Duree.Name = "Duree";
            // 
            // Ville
            // 
            this.Ville.HeaderText = "Ville";
            this.Ville.Name = "Ville";
            // 
            // Matricule
            // 
            this.Matricule.HeaderText = "Matricule";
            this.Matricule.Name = "Matricule";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Classer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 269);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Data";
            this.Text = "Data";
            this.Load += new System.EventHandler(this.Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomcomplet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duree;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricule;
        private System.Windows.Forms.Button button1;
    }
}