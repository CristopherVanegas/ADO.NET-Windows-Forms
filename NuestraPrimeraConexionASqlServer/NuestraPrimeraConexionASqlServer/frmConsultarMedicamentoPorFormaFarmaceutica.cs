using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NuestraPrimeraConexionASqlServer
{
    public partial class frmConsultarMedicamentoPorFormaFarmaceutica : Form
    {
        public frmConsultarMedicamentoPorFormaFarmaceutica()
        {
            InitializeComponent();
        }

        private void frmConsultarMedicamentoPorFormaFarmaceutica_Load(object sender, EventArgs e)
        {
            SQL.llenarComboBox("uspComboFormaFarmaceutica", cboFormaFarmaceutica, "NOMBRE");
            SQL.ListarProcedureSQL("uspListarMedicamentos", dgvMedicamentos);
        }

        private void eventoFiltrar(object sender, EventArgs e)
        {
            string idForma = cboFormaFarmaceutica.SelectedValue.ToString();
            SQL.filtradoDatos("uspConsultarMedicamentosPorFormaFarmaceutica", "@IIDFORMAFARMACEUTICA", idForma, dgvMedicamentos);
        }
    }
}

