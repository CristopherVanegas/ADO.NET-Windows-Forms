using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuestraPrimeraConexionASqlServer
{
    public partial class frmListadoDoctor : Form
    {
        public frmListadoDoctor()
        {
            InitializeComponent();
        }

        private void frmListadoDoctor_Load(object sender, EventArgs e)
        {
            SQL.ListarConsultaSQL("USPLISTARDOCTOR", dgvListadoDoctor);
            rbApPaterno.Checked = true;
        }

        private void filtrar(object sender, EventArgs e)
        {
            string valor = txtValor.Text;
            if (rbApPaterno.Checked)
            {
                SQL.filtradoDatos("uspConsultaDoctorPorApPaterno", "@apPaterno", valor, dgvListadoDoctor);
            } else if (rbApMaterno.Checked)
            {
                SQL.filtradoDatos("uspConsultaDoctorPorApMaterno", "@apMaterno", valor, dgvListadoDoctor);
            }
        }
    }
}
