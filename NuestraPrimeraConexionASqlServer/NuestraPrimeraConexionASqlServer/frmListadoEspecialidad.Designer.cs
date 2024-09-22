namespace NuestraPrimeraConexionASqlServer
{
    partial class frmListadoEspecialidad
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
            this.dgvEspecialidad = new System.Windows.Forms.DataGridView();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.txtNombreEspecialidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidad)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEspecialidad
            // 
            this.dgvEspecialidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecialidad.Location = new System.Drawing.Point(12, 45);
            this.dgvEspecialidad.Name = "dgvEspecialidad";
            this.dgvEspecialidad.RowHeadersWidth = 62;
            this.dgvEspecialidad.RowTemplate.Height = 28;
            this.dgvEspecialidad.Size = new System.Drawing.Size(776, 374);
            this.dgvEspecialidad.TabIndex = 0;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(270, 10);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(213, 26);
            this.txtEspecialidad.TabIndex = 2;
            this.txtEspecialidad.TextChanged += new System.EventHandler(this.eventoFiltrar);
            // 
            // txtNombreEspecialidad
            // 
            this.txtNombreEspecialidad.AutoSize = true;
            this.txtNombreEspecialidad.Location = new System.Drawing.Point(94, 13);
            this.txtNombreEspecialidad.Name = "txtNombreEspecialidad";
            this.txtNombreEspecialidad.Size = new System.Drawing.Size(159, 20);
            this.txtNombreEspecialidad.TabIndex = 3;
            this.txtNombreEspecialidad.Text = "Nombre Especialidad";
            // 
            // frmListadoEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNombreEspecialidad);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.dgvEspecialidad);
            this.Name = "frmListadoEspecialidad";
            this.Text = "frmListadoEspecialidad";
            this.Load += new System.EventHandler(this.frmListadoEspecialidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEspecialidad;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.Label txtNombreEspecialidad;
    }
}