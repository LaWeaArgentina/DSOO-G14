namespace ProyectoIntegrador
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnGestinarAlumnos = new System.Windows.Forms.Button();
            this.btnGestionarPagos = new System.Windows.Forms.Button();
            this.btnListarVencimientos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGestinarAlumnos
            // 
            this.btnGestinarAlumnos.Location = new System.Drawing.Point(6, 21);
            this.btnGestinarAlumnos.Name = "btnGestinarAlumnos";
            this.btnGestinarAlumnos.Size = new System.Drawing.Size(500, 64);
            this.btnGestinarAlumnos.TabIndex = 0;
            this.btnGestinarAlumnos.Text = "Gestionar Alumnos";
            this.btnGestinarAlumnos.UseVisualStyleBackColor = true;
            this.btnGestinarAlumnos.Click += new System.EventHandler(this.btnGestinarAlumnos_Click);
            // 
            // btnGestionarPagos
            // 
            this.btnGestionarPagos.Location = new System.Drawing.Point(6, 91);
            this.btnGestionarPagos.Name = "btnGestionarPagos";
            this.btnGestionarPagos.Size = new System.Drawing.Size(500, 64);
            this.btnGestionarPagos.TabIndex = 1;
            this.btnGestionarPagos.Text = "Gestionar Pagos";
            this.btnGestionarPagos.UseVisualStyleBackColor = true;
            // 
            // btnListarVencimientos
            // 
            this.btnListarVencimientos.Location = new System.Drawing.Point(6, 161);
            this.btnListarVencimientos.Name = "btnListarVencimientos";
            this.btnListarVencimientos.Size = new System.Drawing.Size(500, 64);
            this.btnListarVencimientos.TabIndex = 2;
            this.btnListarVencimientos.Text = "Listar Vencimientos";
            this.btnListarVencimientos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGestinarAlumnos);
            this.groupBox1.Controls.Add(this.btnListarVencimientos);
            this.groupBox1.Controls.Add(this.btnGestionarPagos);
            this.groupBox1.Location = new System.Drawing.Point(258, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 240);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menú principal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Club Deportivo - Menú";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestinarAlumnos;
        private System.Windows.Forms.Button btnGestionarPagos;
        private System.Windows.Forms.Button btnListarVencimientos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}