namespace CursoProgramacion.forms
{
    partial class GestionFacturas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            cbProducto = new ComboBox();
            btnAgregar = new Button();
            txtcantidad = new Label();
            label1 = new Label();
            label2 = new Label();
            lblPrecio = new Label();
            Cliente = new Label();
            combocliente = new ComboBox();
            txtcantidad1 = new TextBox();
            button1 = new Button();
            lblDescripcion = new Label();
            label3 = new Label();
            txtTotal = new TextBox();
            Producto = new Label();
            button2 = new Button();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(117, 244);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(540, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cbProducto
            // 
            cbProducto.FormattingEnabled = true;
            cbProducto.Location = new Point(372, 83);
            cbProducto.Name = "cbProducto";
            cbProducto.Size = new Size(121, 23);
            cbProducto.TabIndex = 1;
            cbProducto.SelectedIndexChanged += cbProducto_SelectedIndexChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(226, 215);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtcantidad
            // 
            txtcantidad.AutoSize = true;
            txtcantidad.Location = new Point(237, 187);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(55, 15);
            txtcantidad.TabIndex = 4;
            txtcantidad.Text = "Cantidad";
            txtcantidad.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(237, 124);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "Precio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 152);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 6;
            label2.Text = "Descripcion";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(372, 124);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(19, 15);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "llll";
            // 
            // Cliente
            // 
            Cliente.AutoSize = true;
            Cliente.Location = new Point(237, 51);
            Cliente.Name = "Cliente";
            Cliente.Size = new Size(44, 15);
            Cliente.TabIndex = 9;
            Cliente.Text = "Cliente";
            // 
            // combocliente
            // 
            combocliente.FormattingEnabled = true;
            combocliente.Location = new Point(372, 51);
            combocliente.Name = "combocliente";
            combocliente.Size = new Size(121, 23);
            combocliente.TabIndex = 10;
            combocliente.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtcantidad1
            // 
            txtcantidad1.Location = new Point(393, 184);
            txtcantidad1.Name = "txtcantidad1";
            txtcantidad1.Size = new Size(100, 23);
            txtcantidad1.TabIndex = 11;
            txtcantidad1.TextChanged += txtcantidad1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(251, 400);
            button1.Name = "button1";
            button1.Size = new Size(96, 38);
            button1.TabIndex = 12;
            button1.Text = "Crear Factura";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(372, 152);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(19, 15);
            lblDescripcion.TabIndex = 8;
            lblDescripcion.Text = "llll";
            lblDescripcion.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(485, 412);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 14;
            label3.Text = "Total";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(557, 409);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 15;
            // 
            // Producto
            // 
            Producto.AutoSize = true;
            Producto.Location = new Point(237, 83);
            Producto.Name = "Producto";
            Producto.Size = new Size(56, 15);
            Producto.TabIndex = 16;
            Producto.Text = "Producto";
            // 
            // button2
            // 
            button2.Location = new Point(407, 215);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 17;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.ForestGreen;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(246, 9);
            label4.Name = "label4";
            label4.Size = new Size(271, 37);
            label4.TabIndex = 31;
            label4.Text = "Generando Facturas";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.tienda;
            pictureBox4.Location = new Point(12, 51);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(163, 156);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 32;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.facturas;
            pictureBox2.Location = new Point(573, 51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(167, 156);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            // 
            // GestionFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox4);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(Producto);
            Controls.Add(txtTotal);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(txtcantidad1);
            Controls.Add(combocliente);
            Controls.Add(Cliente);
            Controls.Add(lblDescripcion);
            Controls.Add(lblPrecio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtcantidad);
            Controls.Add(btnAgregar);
            Controls.Add(cbProducto);
            Controls.Add(dataGridView1);
            Name = "GestionFacturas";
            Text = "Form1";
            Load += GestionFacturas_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox cbProducto;
        private Button btnAgregar;
        private TextBox cantidad;
        private Label txtcantidad;
        private Label label1;
        private Label label2;
        private Label lblPrecio;
        private Label Cliente;
        private ComboBox combocliente;
        private TextBox txtcantidad1;
        private Button button1;
        private Label lblDescripcion;
        private Label label3;
        private TextBox txtTotal;
        private Label Producto;
        private Button button2;
        private Label label4;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
    }
}