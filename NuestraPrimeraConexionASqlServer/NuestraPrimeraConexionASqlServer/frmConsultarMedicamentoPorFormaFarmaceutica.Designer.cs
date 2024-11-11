namespace NuestraPrimeraConexionASqlServer
{
    partial class frmConsultarMedicamentoPorFormaFarmaceutica
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
            this.txtFormaFarmaceutica = new System.Windows.Forms.Label();
            this.cboFormaFarmaceutica = new System.Windows.Forms.ComboBox();
            this.dgvMedicamentos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFormaFarmaceutica
            // 
            this.txtFormaFarmaceutica.AutoSize = true;
            this.txtFormaFarmaceutica.Location = new System.Drawing.Point(143, 21);
            this.txtFormaFarmaceutica.Name = "txtFormaFarmaceutica";
            this.txtFormaFarmaceutica.Size = new System.Drawing.Size(248, 20);
            this.txtFormaFarmaceutica.TabIndex = 0;
            this.txtFormaFarmaceutica.Text = "Seleccione la forma farmaceutica:";
            // 
            // cboFormaFarmaceutica
            // 
            this.cboFormaFarmaceutica.FormattingEnabled = true;
            this.cboFormaFarmaceutica.Location = new System.Drawing.Point(410, 18);
            this.cboFormaFarmaceutica.Name = "cboFormaFarmaceutica";
            this.cboFormaFarmaceutica.Size = new System.Drawing.Size(263, 28);
            this.cboFormaFarmaceutica.TabIndex = 1;
            this.cboFormaFarmaceutica.SelectionChangeCommitted += new System.EventHandler(this.eventoFiltrar);
            // 
            // dgvMedicamentos
            // 
            this.dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamentos.Location = new System.Drawing.Point(12, 56);
            this.dgvMedicamentos.Name = "dgvMedicamentos";
            this.dgvMedicamentos.RowHeadersWidth = 62;
            this.dgvMedicamentos.RowTemplate.Height = 28;
            this.dgvMedicamentos.Size = new System.Drawing.Size(776, 382);
            this.dgvMedicamentos.TabIndex = 2;
            // 
            // frmConsultarMedicamentoPorFormaFarmaceutica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMedicamentos);
            this.Controls.Add(this.cboFormaFarmaceutica);
            this.Controls.Add(this.txtFormaFarmaceutica);
            this.Name = "frmConsultarMedicamentoPorFormaFarmaceutica";
            this.Text = "frmConsultarMedicamentoPorFormaFarmaceutica";
            this.Load += new System.EventHandler(this.frmConsultarMedicamentoPorFormaFarmaceutica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtFormaFarmaceutica;
        private System.Windows.Forms.ComboBox cboFormaFarmaceutica;
        private System.Windows.Forms.DataGridView dgvMedicamentos;
    }
}