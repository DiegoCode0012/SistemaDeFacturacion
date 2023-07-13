namespace CursoProgramacion.forms
{
    partial class Login
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
            pictureBox1 = new PictureBox();
            Ingresar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtuser = new TextBox();
            txtcontra = new TextBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login;
            pictureBox1.Location = new Point(78, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Ingresar
            // 
            Ingresar.Location = new Point(131, 313);
            Ingresar.Name = "Ingresar";
            Ingresar.Size = new Size(75, 23);
            Ingresar.TabIndex = 1;
            Ingresar.Text = "Ingresar";
            Ingresar.UseVisualStyleBackColor = true;
            Ingresar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 230);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 263);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // txtuser
            // 
            txtuser.Location = new Point(131, 227);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(100, 23);
            txtuser.TabIndex = 4;
            txtuser.TextChanged += txtuser_TextChanged;
            // 
            // txtcontra
            // 
            txtcontra.Location = new Point(131, 260);
            txtcontra.Name = "txtcontra";
            txtcontra.Size = new Size(100, 23);
            txtcontra.TabIndex = 5;
            txtcontra.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.tienda;
            pictureBox2.Location = new Point(404, 53);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(316, 244);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(291, 9);
            label3.Name = "label3";
            label3.Size = new Size(252, 37);
            label3.TabIndex = 7;
            label3.Text = "Tienda Electronica";
            label3.Click += label3_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.facebook;
            pictureBox3.Location = new Point(404, 313);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(71, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.instagram;
            pictureBox4.Location = new Point(524, 313);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(78, 38);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.whatsap;
            pictureBox5.Location = new Point(645, 313);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(75, 38);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(txtcontra);
            Controls.Add(txtuser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Ingresar);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Ingresar;
        private Label label1;
        private Label label2;
        private TextBox txtuser;
        private TextBox txtcontra;
        private PictureBox pictureBox2;
        private Label label3;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}