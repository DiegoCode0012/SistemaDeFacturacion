using CursoProgramacion.conexion;
using CursoProgramacion.models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoProgramacion.dao
{
    internal class ProductoDao
    {
       
       private Conexion? sql= new Conexion();
  

        public List<Producto> ObtenerlistadoDeProductos()
        {
            List<Producto> lista = new List<Producto>(); ;
            Producto p;
            string consulta = "SELECT * FROM PRODUCTO";
            SqlCommand comando = new SqlCommand(consulta);
            try
            {
                comando.Connection = sql.abrir();
                SqlDataReader lectura = comando.ExecuteReader();
                while (lectura.Read())
                {
                    p = new Producto();
                    p.Id = lectura.GetInt32("COD_PRODUCTO");
                    p.descripcion = lectura.GetString("DESCRIPCION");
                    p.precio = lectura.GetDouble("PRECIO_PRODUCTO");
                    lista.Add(p);
                }

                comando.Connection.Close();

            }
            catch (Exception e) {
                comando.Connection.Close();

            }
            return lista;
        }
        public Producto get(int id)
        {
            Producto? p = null;
            string consulta = "SELECT * FROM PRODUCTO WHERE producto.COD_PRODUCTO=" + id + ";";
            SqlCommand comando = new SqlCommand(consulta);
            comando.Connection = sql.abrir();
            SqlDataReader lectura = comando.ExecuteReader();
            while (lectura.Read())
            {
                p = new Producto();
                p.Id = lectura.GetInt32("COD_PRODUCTO");
                p.descripcion = lectura.GetString("DESCRIPCION");
                p.precio = lectura.GetDouble("PRECIO_PRODUCTO");
            }
            comando.Connection.Close();
            return p;

        }
    }
}
