using CursoProgramacion.dao;
using CursoProgramacion.models;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CursoProgramacion.forms
{
    public partial class GestionFacturas : Form
    {
        public GestionFacturas()
        {
            InitializeComponent();

        }
        DataTable table = new DataTable("table");


        private void GestionFacturas_Load_1(object sender, EventArgs e)
        {
            table.Columns.Add("CODIGO");
            table.Columns.Add("Descripcion");
            table.Columns.Add("Cantidad");
            table.Columns.Add("Precio");
            table.Columns.Add("Importe");
            listarComboProducto();
            listarComboCliente();
            dataGridView1.DataSource = table;


            int selectedValue;
            bool parseOK = Int32.TryParse(cbProducto.SelectedValue.ToString(), out selectedValue);
            ProductoDao pDao = new ProductoDao();
            Producto p = pDao.get(selectedValue);

            lblPrecio.Text = Convert.ToString(p.precio);
            lblDescripcion.Text = p.descripcion;

        }
        public void listarComboProducto()
        {
            var dataSource = new List<Producto>();
            ProductoDao pDao = new ProductoDao();
            List<Producto> lista = pDao.ObtenerlistadoDeProductos();
            for (int i = 0; i < lista.Count; i++)
            {
                Producto p = lista[i];
                dataSource.Add(p);
            }
            //            dataGridView1.DataSource = table;
            cbProducto.DataSource = dataSource;
            cbProducto.DisplayMember = "descripcion";
            cbProducto.ValueMember = "id";
            cbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void listarComboCliente()
        {
            var dataSource = new List<Cliente>();
            ClienteDao cDao = new ClienteDao();
            List<Cliente> lista = cDao.ObtenerlistadoDeClientes();
            for (int i = 0; i < lista.Count; i++)
            {
                Cliente c = lista[i];
                dataSource.Add(c);
            }
            //            dataGridView1.DataSource = table;
            combocliente.DataSource = dataSource;
            combocliente.DisplayMember = "nombre";
            combocliente.ValueMember = "id";
            combocliente.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedValue;
            bool parseOK = Int32.TryParse(cbProducto.SelectedValue.ToString(), out selectedValue);
            ProductoDao pDao = new ProductoDao();
            Producto p = pDao.get(selectedValue);
            if (p == null)
            {
            }
            else
            {
                lblPrecio.Text = Convert.ToString(p.precio);
                lblDescripcion.Text = p.descripcion;
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {

            int selectedValue;
            bool parseOK = Int32.TryParse(cbProducto.SelectedValue.ToString(), out selectedValue);
            ProductoDao pDao = new ProductoDao();
            Producto p = pDao.get(selectedValue);

            int cantidad;
            bool result = int.TryParse(txtcantidad1.Text, out cantidad);
            bool Found = false;

            if (cantidad > 0)
            {

                if (table.Rows.Count > 0)
                {

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {

                        //0,1,2
                        int c = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                        //entramos a este if si se ha encontrado una fila que tenga el mismo id del COMBO
                        if (c == p.Id)
                        {
                            int cantA = Convert.ToInt32(dataGridView1.Rows[i].Cells["CANTIDAD"].Value);
                            int precio = Convert.ToInt32(dataGridView1.Rows[i].Cells["PRECIO"].Value);
                            cantA = cantA + cantidad;
                            dataGridView1.Rows[i].Cells["CANTIDAD"].Value = cantA;
                            dataGridView1.Rows[i].Cells["IMPORTE"].Value = cantA * precio;


                            dataGridView1.UpdateCellValue(2, i);
                            dataGridView1.UpdateCellValue(4, i);
                            Found = true;
                            Actualizar();
                        }
                    }
                    if (!Found)
                    {
                        double? IMPORTE = cantidad * p.precio;
                        table.Rows.Add(p.Id, p.descripcion, cantidad, p.precio, IMPORTE);
                        Actualizar();
                    }

                }
                else
                {
                    MessageBox.Show("XXXXX---");
                    double? IMPORTE = cantidad * p.precio;
                    table.Rows.Add(p.Id, p.descripcion, cantidad, p.precio, IMPORTE);
                    Actualizar();
                }
            }
            else
            {
                MessageBox.Show("Debe definir la cantidad");
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex;
            MessageBox.Show("" + x);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (table.Rows.Count > 0)
            {
                int selectedValueCliente;
                bool parseOK = Int32.TryParse(combocliente.SelectedValue.ToString(), out selectedValueCliente);
                ClienteDao cDao = new ClienteDao();
                Cliente c = cDao.get(selectedValueCliente);

                ProductoDao pDao = new ProductoDao();

                Factura f = new Factura();
                FacturaDao fDao = new FacturaDao();
                f.Cliente = c;

                fDao.insertarFactura(f);
                Factura LastFactura = fDao.UltimaFactura();
                if (LastFactura != null)
                {

                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        Item item = new Item();

                        item.cantidad = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);


                        int idProducto = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                        Producto p = pDao.get(idProducto);
                        item.producto = p;


                        item.factura = LastFactura;
                        string v = fDao.insertarItem(item);

                    }
                    table.Rows.Clear();
                    MessageBox.Show("Factura guardada con exito");
                }
                else
                {
                    MessageBox.Show("No se encontro la Factura");
                }

            }
            else
            {
                MessageBox.Show("No se puede guardar la Factura sin los items");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FacturaDao f = new FacturaDao();
            MessageBox.Show("OK" + f.UltimaFactura().Id);
        }
        public void Actualizar()
        {
            double total = 0;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                total = total + Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
            }
            txtTotal.Text = total.ToString();

        }

        private void button2_Click_1(object sender, EventArgs e)

        {
            int c = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows.RemoveAt(c);
            Actualizar();

        }

        private void txtcantidad1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
