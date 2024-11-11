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
    public partial class frmListadoPaciente : Form
    {
        public frmListadoPaciente()
        {
            InitializeComponent();
        }

        private void frmListadoPaciente_Load(object sender, EventArgs e)
        {
            cboOpcion.SelectedIndex = 0;
            SQL.ListarProcedureSQL("uspListarPacientesPrograma", dgvPaciente);
        }

        private void filtrar(object sender, EventArgs e)
        {
            string opcion = cboOpcion.Text;
            string valor = txtValor.Text;

            if (opcion.Equals("Nombre"))
            {
                SQL.filtradoDatos("uspConsultarPacientesProgramaPorNombre", "@nombre", valor, dgvPaciente);
            }
            else if (opcion.Equals("Apellido Paterno")) {
                SQL.filtradoDatos("uspConsultarPacientesProgramaPorApPaterno", "@apPaterno", valor, dgvPaciente);
            }
            else
            {
                SQL.filtradoDatos("uspConsultarPacientesProgramaPorApMaterno", "@apMaterno", valor, dgvPaciente);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
