using CursoProgramacion.conexion;
using CursoProgramacion.dao;
using CursoProgramacion.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoProgramacion.forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean rpta = false;
            String usuario = txtuser.Text;
            String contra = txtcontra.Text;
            UsuarioDao user = new UsuarioDao();
            List<User> users = user.ObtenerlistadoDeUsuarios();
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].usuario == usuario && users[i].contraseña == contra)
                {
                    rpta = true;
                    MessageBox.Show("Bienevenido " + usuario);
                    Menu m = new Menu();
                    m.ShowDialog();
                    break;
                }
            }
            if (rpta == false)
            {
                MessageBox.Show("Nombre o contraseña incorrectos");

            }
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
