using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace NuestraPrimeraConexionASqlServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listarClinicas();
        }

        private void listarClinicas()
        {
            SQL.ListarConsultaSQL("SELECT IIDCLINICA, NOMBRE, DIRECCION\r\n\tFROM Clinica\r\n\tWHERE BHABILITADO = 1;", dgvClinica);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string idclinica = txtIdClinica.Text;
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);
            SqlCommand cmd = new SqlCommand("uspFiltrarClinicaPorId", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idclinica", idclinica);
            DataTable tabla = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(tabla);
            dgvClinica.DataSource = tabla;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listarClinicas();
            txtIdClinica.Text = "";
        }
    }
}
