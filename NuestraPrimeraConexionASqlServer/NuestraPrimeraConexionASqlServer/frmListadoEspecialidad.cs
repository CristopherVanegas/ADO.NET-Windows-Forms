using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

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
    }
}
