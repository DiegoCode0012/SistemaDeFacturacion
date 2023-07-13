using CursoProgramacion.conexion;
using CursoProgramacion.models;
using Microsoft.Data.SqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoProgramacion.dao
{
    internal class FacturaDao
    {


         Conexion sql= new Conexion();
        ClienteDao cDao = new ClienteDao();
        

        public void insertarFactura(Factura F)
        {
            
            string consulta = "INSERT INTO FACTURA (FECHA_EMISION,COD_CLIENTE) VALUES ('" + DateTime.Today + "','" + F.Cliente.Id + "')";
            SqlCommand comando = new SqlCommand(consulta);
            comando.Connection = sql.abrir();
            try
            {
                comando.ExecuteNonQuery();
                comando.Connection.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                comando.Connection.Close();

            }


        }

        public string insertarItem(Item item)
        {
            string? msg = null;
            string consulta = "INSERT INTO DETALLE_FACTURA (COD_PRODUCTO,CANTIDAD,NUMERO_FACTURA) VALUES ('" + item.producto.Id + "','" + item.cantidad + "', '"+ item.factura.Id+ "')";
            SqlCommand comando = new SqlCommand(consulta);
            comando.Connection = sql.abrir();
            try
            {
                comando.ExecuteNonQuery();
                comando.Connection.Close();

            }
            catch (Exception e)
            {
                msg = e.Message;
                MessageBox.Show(e.Message);
                comando.Connection.Close();

            }
            return msg;

        }

        public Factura UltimaFactura() {
            Factura? f=null;
            Cliente c;
            SqlCommand comando = new SqlCommand("ultimoID", sql.abrir());
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataReader lectura = comando.ExecuteReader();
            try
            {
                while (lectura.Read())
                {
                    f = new Factura();
                    c = new Cliente();
                    f.Id = lectura.GetInt32("NUMERO_FACTURA");
                    f.fecha = lectura.GetDateTime("FECHA_EMISION");
                    int iDC = lectura.GetInt32("COD_CLIENTE");
                    c = cDao.get(iDC);
                    f.Cliente = c;
                }
                comando.Connection.Close();

            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
                comando.Connection.Close();

            }

            return f;
        }
       
       

    }
}
