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
            SQL.llenarComboBox("uspComboFormaFarmaceutica", cboFormaFarmaceutica, "NOMBRE", "IIDFORMAFARMACEUTICA");
        }
    }
}

