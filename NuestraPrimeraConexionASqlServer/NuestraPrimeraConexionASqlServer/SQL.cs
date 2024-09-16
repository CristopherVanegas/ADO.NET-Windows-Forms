using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace NuestraPrimeraConexionASqlServer
{
    public class SQL
    {
        private static SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);
        
        public static void ListarConsultaSQL(string consulta, DataGridView grilla)
        {
            SqlCommand cmd = new SqlCommand(consulta, cn);
            // cmd.CommandType = CommandType.StoredProcedure;  // Especifico que es un SP y lo hace más rápido porque especifico su tipo
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            grilla.DataSource = tabla;
        }

        public static void ListarProcedureSQL(string procedure, DataGridView grilla)
        {
            SqlCommand cmd = new SqlCommand(procedure, cn);
            cmd.CommandType = CommandType.StoredProcedure;  // Especifico que es un SP y lo hace más rápido porque especifico su tipo
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            grilla.DataSource = tabla;
        }
    }
}
