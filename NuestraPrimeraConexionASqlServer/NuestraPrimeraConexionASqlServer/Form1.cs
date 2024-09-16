using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            SQL.ListarConsultaSQL("SELECT IIDCLINICA, NOMBRE, DIRECCION\r\n\tFROM Clinica\r\n\tWHERE BHABILITADO = 1;", dgvClinica);

            //// Establece la coneccion con SQL Server
            //SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);

            //// Creo el comando y le paso la conexion
            //SqlCommand cmd = new SqlCommand("SELECT IIDCLINICA, NOMBRE, DIRECCION\r\n\tFROM Clinica\r\n\tWHERE BHABILITADO = 1;", cn);

            //// Le paso un adaptador para la consulta
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);

            //// Creo la tabla
            //DataTable tabla = new DataTable();

            //// Lleno el adaptador con los datos de la tabla
            //sda.Fill(tabla);

            //// Asigno al DataGridView la tabla
            //dgvClinica.DataSource = tabla;

        }
    }
}
