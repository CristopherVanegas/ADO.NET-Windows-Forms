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
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);
            SqlCommand cmd = new SqlCommand("uspListarEspecialidades", cn);
            cmd.CommandType = CommandType.StoredProcedure;  // Especifico que es un SP y lo hace más rápido porque especifico su tipo
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            dgvEspecialidad.DataSource = tabla;

        }
    }
}
