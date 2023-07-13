using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CursoProgramacion.dao;
using CursoProgramacion.models;
using MySqlX.XDevAPI;

namespace CursoProgramacion
{
    public partial class GestionClientes : Form
    {

        public GestionClientes()
        {
            InitializeComponent();

        }
        DataTable table = new DataTable("table");

        private void GestionClientes_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Id");
            table.Columns.Add("Nombre");
            table.Columns.Add("Apellido");
            table.Columns.Add("Telefono");
            table.Columns.Add("T.Credito");
            actualizarTabla();
        }

        private void actualizarTabla()
        {

            ClienteDao clienteDao = new ClienteDao();
            List<Cliente> lista = clienteDao.ObtenerlistadoDeClientes();
            table.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                Cliente cliente = lista[i];
                table.Rows.Add(cliente.Id, cliente.Nombre, cliente.Apellido, cliente.Telefono, cliente.TarjetaDeCredito);

            }
            dataGridView1.DataSource = table;

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            /*  Cliente cliente = new Cliente();
              cliente.Nombre = txtnombre2.Text;
              cliente.Apellido = txtapellido2.Text;
              cliente.Telefono = txttelefono2.Text;
              cliente.TarjetaDeCredito = txttarjeta2.Text;



              ClienteDao clienteDao = new ClienteDao();
              clienteDao.Guardar(cliente);
              actualizarTabla();*/
        }





        private void listClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void agregar_Click(object sender, EventArgs e)
        {

        }

        private void limpiar2()
        {
            txtId2.Text = "";
            txtnombre2.Text = "";
            txtapellido2.Text = "";
            txttelefono2.Text = "";
            txttarjeta2.Text = "";
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.CurrentRow.Selected = true;
                txtId2.Text = dataGridView1.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                txtnombre2.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].FormattedValue.ToString();
                txtapellido2.Text = dataGridView1.Rows[e.RowIndex].Cells["apellido"].FormattedValue.ToString();
                txttelefono2.Text = dataGridView1.Rows[e.RowIndex].Cells["telefono"].FormattedValue.ToString();
                txttarjeta2.Text = dataGridView1.Rows[e.RowIndex].Cells["T.Credito"].FormattedValue.ToString();
            }

        }
        private void Insertar_Click(object sender, EventArgs e)
        {
            String id, nombre, apellido, telefono, tarjeta;
            id = txtId2.Text;
            nombre = txtnombre2.Text;
            apellido = txtapellido2.Text;
            telefono = txttelefono2.Text;
            tarjeta = txttarjeta2.Text;
            if (nombre == "" || apellido == "" || telefono == "" || tarjeta == "")
            {
                MessageBox.Show("Los campos deben estar llenos juntos con el ID");
            }
            else
            {
                Cliente cliente = new Cliente();
                cliente.Nombre = txtnombre2.Text;
                cliente.Apellido = txtapellido2.Text;
                cliente.Telefono = txttelefono2.Text;
                cliente.TarjetaDeCredito = txttarjeta2.Text;

                ClienteDao clienteDao = new ClienteDao();
                clienteDao.insertar(cliente);
                MessageBox.Show("Cliente insertado con exito");
                limpiar2();
            }
            actualizarTabla();

        }

        private void eliminar2_Click(object sender, EventArgs e)
        {
            String id;
            id = txtId2.Text;
            if (id != "")
            {
                int x = Int32.Parse(id);
                ClienteDao clienteDao = new ClienteDao();
                clienteDao.Eliminar2(x);
                MessageBox.Show("Cliente eliminado con exito");
                limpiar2();

            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar");
            }

            actualizarTabla();
        }
        private void get_Click(object sender, EventArgs e)
        {
            String id, nombre, apellido, telefono, tarjeta;
            id = txtId2.Text;
            nombre = txtnombre2.Text;
            apellido = txtapellido2.Text;
            telefono = txttelefono2.Text;
            tarjeta = txttarjeta2.Text;
            if (id == "" || nombre == "" || apellido == "" || telefono == "" || tarjeta == "")
            {
                MessageBox.Show("Los campos deben estar llenos juntos con el ID");
            }
            else
            {
                ClienteDao clienteDao = new ClienteDao();
                int x = Int32.Parse(id);
                Cliente cliente = clienteDao.get(x);
                if (cliente != null)
                {
                    cliente.Nombre = txtnombre2.Text;
                    cliente.Apellido = txtapellido2.Text;
                    cliente.Telefono = txttelefono2.Text;
                    cliente.TarjetaDeCredito = txttarjeta2.Text;
                    cliente.Id = Int32.Parse(txtId2.Text);
                    clienteDao.actualizar(cliente);
                    MessageBox.Show("Cliente actualizado con exito");
                    limpiar2();

                }
                else
                {
                    MessageBox.Show("El cliente no se encuentra en BBDD");
                }

                actualizarTabla();

            }


        }

        private void txtnombre2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
