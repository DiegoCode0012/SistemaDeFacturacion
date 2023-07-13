namespace CursoProgramacion
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            factura = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(196, 250);
            button1.Name = "button1";
            button1.Size = new Size(140, 58);
            button1.TabIndex = 1;
            button1.Text = "Gestionar Clientes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // factura
            // 
            factura.Location = new Point(391, 250);
            factura.Name = "factura";
            factura.Size = new Size(144, 58);
            factura.TabIndex = 2;
            factura.Text = "Generar Factura";
            factura.UseVisualStyleBackColor = true;
            factura.Click += factura_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.clientes;
            pictureBox1.Location = new Point(196, 117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.facturas;
            pictureBox2.Location = new Point(391, 117);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(144, 106);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(173, 44);
            label1.Name = "label1";
            label1.Size = new Size(425, 37);
            label1.TabIndex = 5;
            label1.Text = "Bienvenido a Tienda Electronica";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.tienda;
            pictureBox3.Location = new Point(595, 161);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(141, 126);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.tienda;
            pictureBox4.Location = new Point(3, 161);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(141, 126);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(factura);
            Controls.Add(button1);
            Name = "Menu";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button factura;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}