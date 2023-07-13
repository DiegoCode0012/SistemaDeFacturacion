using CursoProgramacion.forms;

namespace CursoProgramacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionClientes ventanaClientes = new GestionClientes();
            ventanaClientes.ShowDialog();
        }

        private void factura_Click(object sender, EventArgs e)
        {
            GestionFacturas ventanaFacturas = new GestionFacturas();
            ventanaFacturas.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}