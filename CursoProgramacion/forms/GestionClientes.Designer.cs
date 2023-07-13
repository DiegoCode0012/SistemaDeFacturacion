namespace CursoProgramacion
{
    partial class GestionClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionClientes));
            dataGridView1 = new DataGridView();
            Insertar2 = new Button();
            eliminar2 = new Button();
            actualizar2 = new Button();
            txttarjeta2 = new TextBox();
            label7 = new Label();
            txttelefono2 = new TextBox();
            label8 = new Label();
            txtapellido2 = new TextBox();
            label9 = new Label();
            txtnombre2 = new TextBox();
            label10 = new Label();
            label5 = new Label();
            txtId2 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Insertar2
            // 
            resources.ApplyResources(Insertar2, "Insertar2");
            Insertar2.Name = "Insertar2";
            Insertar2.UseVisualStyleBackColor = true;
            Insertar2.Click += Insertar_Click;
            // 
            // eliminar2
            // 
            resources.ApplyResources(eliminar2, "eliminar2");
            eliminar2.Name = "eliminar2";
            eliminar2.UseVisualStyleBackColor = true;
            eliminar2.Click += eliminar2_Click;
            // 
            // actualizar2
            // 
            resources.ApplyResources(actualizar2, "actualizar2");
            actualizar2.Name = "actualizar2";
            actualizar2.UseVisualStyleBackColor = true;
            actualizar2.Click += get_Click;
            // 
            // txttarjeta2
            // 
            resources.ApplyResources(txttarjeta2, "txttarjeta2");
            txttarjeta2.Name = "txttarjeta2";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // txttelefono2
            // 
            resources.ApplyResources(txttelefono2, "txttelefono2");
            txttelefono2.Name = "txttelefono2";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // txtapellido2
            // 
            resources.ApplyResources(txtapellido2, "txtapellido2");
            txtapellido2.Name = "txtapellido2";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // txtnombre2
            // 
            resources.ApplyResources(txtnombre2, "txtnombre2");
            txtnombre2.Name = "txtnombre2";
            txtnombre2.TextChanged += txtnombre2_TextChanged;
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.Name = "label10";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // txtId2
            // 
            resources.ApplyResources(txtId2, "txtId2");
            txtId2.Name = "txtId2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = SystemColors.HotTrack;
            label1.Name = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.clientes;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // GestionClientes
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtId2);
            Controls.Add(label5);
            Controls.Add(txttarjeta2);
            Controls.Add(label7);
            Controls.Add(txttelefono2);
            Controls.Add(label8);
            Controls.Add(txtapellido2);
            Controls.Add(label9);
            Controls.Add(txtnombre2);
            Controls.Add(label10);
            Controls.Add(actualizar2);
            Controls.Add(eliminar2);
            Controls.Add(Insertar2);
            Controls.Add(dataGridView1);
            Name = "GestionClientes";
            Load += GestionClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button Insertar2;
        private Button eliminar2;
        private Button actualizar2;
        private TextBox txttarjeta2;
        private Label label7;
        private TextBox txttelefono2;
        private Label label8;
        private TextBox txtapellido2;
        private Label label9;
        private TextBox txtnombre2;
        private Label label10;
        private Label label5;
        private TextBox txtId2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}