namespace NuestraPrimeraConexionASqlServer
{
    partial class frmListadoDoctor
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
            this.dgvListadoDoctor = new System.Windows.Forms.DataGridView();
            this.rbApPaterno = new System.Windows.Forms.RadioButton();
            this.rbApMaterno = new System.Windows.Forms.RadioButton();
            this.txtValor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoDoctor
            // 
            this.dgvListadoDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoDoctor.Location = new System.Drawing.Point(12, 97);
            this.dgvListadoDoctor.Name = "dgvListadoDoctor";
            this.dgvListadoDoctor.RowHeadersWidth = 62;
            this.dgvListadoDoctor.RowTemplate.Height = 28;
            this.dgvListadoDoctor.Size = new System.Drawing.Size(776, 330);
            this.dgvListadoDoctor.TabIndex = 0;
            // 
            // rbApPaterno
            // 
            this.rbApPaterno.AutoSize = true;
            this.rbApPaterno.Location = new System.Drawing.Point(27, 33);
            this.rbApPaterno.Name = "rbApPaterno";
            this.rbApPaterno.Size = new System.Drawing.Size(150, 24);
            this.rbApPaterno.TabIndex = 1;
            this.rbApPaterno.TabStop = true;
            this.rbApPaterno.Text = "Apellido Paterno";
            this.rbApPaterno.UseVisualStyleBackColor = true;
            this.rbApPaterno.CheckedChanged += new System.EventHandler(this.filtrar);
            // 
            // rbApMaterno
            // 
            this.rbApMaterno.AutoSize = true;
            this.rbApMaterno.Location = new System.Drawing.Point(179, 33);
            this.rbApMaterno.Name = "rbApMaterno";
            this.rbApMaterno.Size = new System.Drawing.Size(153, 24);
            this.rbApMaterno.TabIndex = 2;
            this.rbApMaterno.TabStop = true;
            this.rbApMaterno.Text = "Apellido Materno";
            this.rbApMaterno.UseVisualStyleBackColor = true;
            this.rbApMaterno.CheckedChanged += new System.EventHandler(this.filtrar);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(338, 33);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(450, 26);
            this.txtValor.TabIndex = 3;
            this.txtValor.TextChanged += new System.EventHandler(this.filtrar);
            // 
            // frmListadoDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.rbApMaterno);
            this.Controls.Add(this.rbApPaterno);
            this.Controls.Add(this.dgvListadoDoctor);
            this.Name = "frmListadoDoctor";
            this.Text = "frmListadoDoctor";
            this.Load += new System.EventHandler(this.frmListadoDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDoctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoDoctor;
        private System.Windows.Forms.RadioButton rbApPaterno;
        private System.Windows.Forms.RadioButton rbApMaterno;
        private System.Windows.Forms.TextBox txtValor;
    }
}