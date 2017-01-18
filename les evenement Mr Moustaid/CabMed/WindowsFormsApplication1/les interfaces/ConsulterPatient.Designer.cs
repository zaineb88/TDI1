namespace WindowsFormsApplication1.les_interfaces
{
    partial class ConsulterPatient
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
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prénom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Téle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Nom,
            this.Prénom,
            this.Adresse,
            this.Téle,
            this.Email,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(14, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(679, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Prénom
            // 
            this.Prénom.HeaderText = "Prénom";
            this.Prénom.Name = "Prénom";
            // 
            // Adresse
            // 
            this.Adresse.HeaderText = "DateNaissance";
            this.Adresse.Name = "Adresse";
            // 
            // Téle
            // 
            this.Téle.HeaderText = "Adresse";
            this.Téle.Name = "Téle";
            // 
            // Email
            // 
            this.Email.HeaderText = "Téle";
            this.Email.Name = "Email";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Email";
            this.Column1.Name = "Column1";
            // 
            // ConsulterPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 262);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConsulterPatient";
            this.Text = "ConsulterPatient";
            this.Load += new System.EventHandler(this.ConsulterPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prénom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Téle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}