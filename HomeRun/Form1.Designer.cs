namespace HomeRun
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInsert = new System.Windows.Forms.Button();
            this.dgvRecord = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbTabella = new System.Windows.Forms.ComboBox();
            this.lblTabella = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 12);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(146, 81);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Inserisci";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // dgvRecord
            // 
            this.dgvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecord.Location = new System.Drawing.Point(12, 99);
            this.dgvRecord.Name = "dgvRecord";
            this.dgvRecord.Size = new System.Drawing.Size(1184, 514);
            this.dgvRecord.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(164, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(146, 81);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Modifica";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(316, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 81);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Elimina";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // cmbTabella
            // 
            this.cmbTabella.FormattingEnabled = true;
            this.cmbTabella.Location = new System.Drawing.Point(954, 72);
            this.cmbTabella.Name = "cmbTabella";
            this.cmbTabella.Size = new System.Drawing.Size(242, 21);
            this.cmbTabella.TabIndex = 4;
            // 
            // lblTabella
            // 
            this.lblTabella.AutoSize = true;
            this.lblTabella.Location = new System.Drawing.Point(951, 56);
            this.lblTabella.Name = "lblTabella";
            this.lblTabella.Size = new System.Drawing.Size(87, 13);
            this.lblTabella.TabIndex = 5;
            this.lblTabella.Text = "Seleziona tabella";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 625);
            this.Controls.Add(this.lblTabella);
            this.Controls.Add(this.cmbTabella);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvRecord);
            this.Controls.Add(this.btnInsert);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dgvRecord;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbTabella;
        private System.Windows.Forms.Label lblTabella;
    }
}

