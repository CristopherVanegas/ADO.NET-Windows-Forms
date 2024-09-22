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
            SQL.filtradoDatos("uspFiltrarClinicaPorId", "@idclinica", idclinica, dgvClinica);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listarClinicas();
            txtIdClinica.Text = "";
        }
    }
}
