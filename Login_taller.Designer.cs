namespace Sistema_Taller
{
    partial class Login_taller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_taller));
            pnlMarca = new Panel();
            pnlLogin = new Panel();
            lblTitulo = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblContrasena = new Label();
            txtContrasena = new TextBox();
            btnIniciar = new Button();
            pictureBox1 = new PictureBox();
            pnlMarca.SuspendLayout();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlMarca
            // 
            pnlMarca.BackColor = Color.FromArgb(13, 35, 58);
            pnlMarca.Controls.Add(pictureBox1);
            pnlMarca.Dock = DockStyle.Left;
            pnlMarca.Location = new Point(0, 0);
            pnlMarca.Name = "pnlMarca";
            pnlMarca.Size = new Size(410, 560);
            pnlMarca.TabIndex = 2;
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.White;
            pnlLogin.Controls.Add(lblTitulo);
            pnlLogin.Controls.Add(lblUsuario);
            pnlLogin.Controls.Add(txtUsuario);
            pnlLogin.Controls.Add(lblContrasena);
            pnlLogin.Controls.Add(txtContrasena);
            pnlLogin.Controls.Add(btnIniciar);
            pnlLogin.Dock = DockStyle.Left;
            pnlLogin.Location = new Point(410, 0);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(440, 560);
            pnlLogin.TabIndex = 3;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(13, 35, 58);
            lblTitulo.Location = new Point(85, 105);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(261, 52);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Iniciar sesión";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsuario.Location = new Point(85, 175);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(70, 23);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 11F);
            txtUsuario.Location = new Point(85, 200);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(260, 32);
            txtUsuario.TabIndex = 2;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblContrasena.Location = new Point(85, 245);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(99, 23);
            lblContrasena.TabIndex = 3;
            lblContrasena.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Segoe UI", 11F);
            txtContrasena.Location = new Point(85, 270);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(260, 32);
            txtContrasena.TabIndex = 4;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(30, 120, 225);
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Location = new Point(85, 330);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(260, 45);
            btnIniciar.TabIndex = 5;
            btnIniciar.Text = "INICIAR SESIÓN";
            btnIniciar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(410, 560);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login_taller
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 560);
            Controls.Add(pnlLogin);
            Controls.Add(pnlMarca);
            Name = "Login_taller";
            Text = "Form2";
            Load += Login_taller_Load;
            pnlMarca.ResumeLayout(false);
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMarca;
        private Panel pnlLogin;
        private Label lblTitulo;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblContrasena;
        private TextBox txtContrasena;
        private Button btnIniciar;
        private PictureBox pictureBox1;
    }
}