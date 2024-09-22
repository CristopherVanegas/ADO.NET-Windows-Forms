using System;
using System.Windows.Forms;

namespace NuestraPrimeraConexionASqlServer
{
    public partial class frmListadoEspecialidad : Form
    {
        public frmListadoEspecialidad()
        {
            InitializeComponent();
        }

        private void frmListadoEspecialidad_Load(object sender, EventArgs e)
        {
            SQL.ListarProcedureSQL("uspListarEspecialidades", dgvEspecialidad);
        }

        private void eventoFiltrar(object sender, EventArgs e)
        {
            string nombre = txtEspecialidad.Text;
            SQL.filtradoDatos("uspListarEspecialidadesPorNombre", "@nombre", nombre, dgvEspecialidad);

        }
    }
}
