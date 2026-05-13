namespace ProyectoIntegrador
{
    partial class frmIngresar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresar));
            picLogo = new PictureBox();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            lblUsuario = new Label();
            lblContrasena = new Label();
            btnIngresar = new Button();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.InitialImage = (Image)resources.GetObject("picLogo.InitialImage");
            picLogo.Location = new Point(12, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(250, 250);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(283, 30);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(250, 23);
            txtUsuario.TabIndex = 1;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(283, 74);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = 'X';
            txtContrasena.Size = new Size(250, 23);
            txtContrasena.TabIndex = 2;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(283, 12);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(283, 56);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(67, 15);
            lblContrasena.TabIndex = 4;
            lblContrasena.Text = "Contraseña";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(458, 239);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // frmIngresar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 311);
            Controls.Add(btnIngresar);
            Controls.Add(lblContrasena);
            Controls.Add(lblUsuario);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(picLogo);
            Name = "frmIngresar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Autentificación";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picLogo;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Label lblUsuario;
        private Label lblContrasena;
        private Button btnIngresar;
    }
}
