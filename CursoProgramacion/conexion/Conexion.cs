using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoProgramacion.conexion
{
    internal class Conexion
    {
        public string cadena = "Data Source=DESKTOP-PEUJJD1\\SQLEXPRESS01;Initial Catalog=BD_HIRAOKA4; Integrated Security=True; TrustServerCertificate=True";
        private SqlConnection conectarbd;
        public Conexion()
        {
            conectarbd = new SqlConnection();
            conectarbd.ConnectionString = cadena;
        }
        public SqlConnection Conexion2() {
            return conectarbd = new SqlConnection(cadena);
        }
        
        public SqlConnection abrir()
        {
            try
            {
                conectarbd.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir BD " + ex.Message);

            }
            return conectarbd;
        }

        public void cerrar()
        {
            conectarbd.Close();
        }
    }
}
