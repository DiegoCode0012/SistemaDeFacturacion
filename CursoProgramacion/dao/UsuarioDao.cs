using CursoProgramacion.conexion;
using CursoProgramacion.models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoProgramacion.dao
{
    internal class UsuarioDao
    {

        Conexion sql = new Conexion();

        public List<User> ObtenerlistadoDeUsuarios()
        {
            List<User> lista = new List<User>();
            User user;
            string consulta = "SELECT * FROM USUARIOS";
            try
            {
                SqlCommand comando = new SqlCommand(consulta);
                comando.Connection = sql.abrir();
                SqlDataReader lectura = comando.ExecuteReader();
                while (lectura.Read())
                {
                    user = new User();
                    user.usuario = lectura.GetString(1);
                    user.contraseña = lectura.GetString(2);
                    lista.Add(user);
                }
                comando.Connection.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            return lista;
        }
    }
}
