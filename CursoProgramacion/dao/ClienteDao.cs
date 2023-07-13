using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using CursoProgramacion.models;
using System.Data;
using Org.BouncyCastle.Utilities.Collections;
using MySqlX.XDevAPI;
using CursoProgramacion.conexion;

namespace CursoProgramacion.dao
{
    internal class ClienteDao
    {
   
         Conexion sql= new Conexion();
        public List<Cliente> ObtenerlistadoDeClientes() {
            List<Cliente> lista=new List<Cliente>();
            Cliente cliente;
            string consulta = "SELECT * FROM CLIENTE";
            try
            {
                SqlCommand comando = new SqlCommand(consulta);
                comando.Connection = sql.abrir();
                SqlDataReader lectura = comando.ExecuteReader();
                while (lectura.Read())
                {
                    cliente = new Cliente();
                    cliente.Id = lectura.GetInt32("id");
                    cliente.Nombre = lectura.GetString("nombre");
                    cliente.Apellido = lectura.GetString("apellido");
                    cliente.Telefono = lectura.GetString("telefono");
                    cliente.TarjetaDeCredito = lectura.GetString("tarjeta_de_credito");
                    lista.Add(cliente);
                }
                comando.Connection.Close();

            }
            catch (Exception e ) {
                MessageBox.Show(e.Message);

            }
            return lista;
        }
      

        public void insertar (Cliente cliente)
        {

            string consulta = "INSERT INTO cliente (nombre,apellido,telefono,tarjeta_de_credito) VALUES ('" + cliente.Nombre + "','" + cliente.Apellido + "','" + cliente.Telefono + "',  '" + cliente.TarjetaDeCredito + "')";
            SqlCommand comando = new SqlCommand(consulta);
            try
            {
                comando.Connection = sql.abrir();
                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                comando.Connection.Close();

            }
            comando.Connection.Close();


        }

        public void actualizar(Cliente cliente)
        {

            String consulta = "UPDATE cliente SET nombre='" + cliente.Nombre +
                    "',apellido='" + cliente.Apellido +
                    "',telefono='" + cliente.Telefono +
                    "',tarjeta_de_credito='" + cliente.TarjetaDeCredito +
                    "' WHERE cliente.id='" + cliente.Id +
                    "';";
            SqlCommand comando = new SqlCommand(consulta);
            try
            {
                comando.Connection = sql.abrir();
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                comando.Connection.Close();
            }
            comando.Connection.Close();


        }

        public void Eliminar(Cliente cliente)
        {
            string consulta = "DELETE FROM cliente WHERE cliente.id=" + cliente.Id +";";
            SqlCommand comando = new SqlCommand(consulta);
            try
            {
                comando.Connection = sql.abrir();
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                comando.Connection.Close();
            }
            comando.Connection.Close();


        }

        public void Eliminar2(int id)
        {
            string consulta = "DELETE FROM cliente WHERE cliente.id=" + id + ";";
            SqlCommand comando = new SqlCommand(consulta);
            try
            {
                comando.Connection = sql.abrir();
           
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                comando.Connection.Close();
            }
            comando.Connection.Close();


        }

        public Cliente get(int id)
        {
            Cliente? cliente=null;
            string consulta = "SELECT * FROM cliente WHERE cliente.id=" + id + ";";
            SqlCommand comando = new SqlCommand(consulta);
            try
            {
                comando.Connection = sql.abrir();      
                SqlDataReader lectura = comando.ExecuteReader();
                while (lectura.Read())
                {
                    cliente = new Cliente();
                    cliente.Id = lectura.GetInt32("id");
                    cliente.Nombre = lectura.GetString("nombre");
                    cliente.Apellido = lectura.GetString("apellido");
                    cliente.Telefono = lectura.GetString("telefono");
                    cliente.TarjetaDeCredito = lectura.GetString("tarjeta_de_credito");
                }

            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
                comando.Connection.Close();

            }
            comando.Connection.Close();
            return cliente;

        }

      


    }
}
