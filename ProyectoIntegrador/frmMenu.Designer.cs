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
            this.btnGestinarAlumnos = new System.Windows.Forms.Button();
            this.btnGestionarPagos = new System.Windows.Forms.Button();
            this.btnListarVencimientos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGestinarAlumnos
            // 
            this.btnGestinarAlumnos.Location = new System.Drawing.Point(6, 21);
            this.btnGestinarAlumnos.Name = "btnGestinarAlumnos";
            this.btnGestinarAlumnos.Size = new System.Drawing.Size(172, 174);
            this.btnGestinarAlumnos.TabIndex = 0;
            this.btnGestinarAlumnos.Text = "Gestionar Alumnos";
            this.btnGestinarAlumnos.UseVisualStyleBackColor = true;
            this.btnGestinarAlumnos.Click += new System.EventHandler(this.btnGestinarAlumnos_Click);
            // 
            // btnGestionarPagos
            // 
            this.btnGestionarPagos.Location = new System.Drawing.Point(184, 21);
            this.btnGestionarPagos.Name = "btnGestionarPagos";
            this.btnGestionarPagos.Size = new System.Drawing.Size(172, 174);
            this.btnGestionarPagos.TabIndex = 1;
            this.btnGestionarPagos.Text = "Gestionar Pagos";
            this.btnGestionarPagos.UseVisualStyleBackColor = true;
            // 
            // btnListarVencimientos
            // 
            this.btnListarVencimientos.Location = new System.Drawing.Point(362, 21);
            this.btnListarVencimientos.Name = "btnListarVencimientos";
            this.btnListarVencimientos.Size = new System.Drawing.Size(172, 174);
            this.btnListarVencimientos.TabIndex = 2;
            this.btnListarVencimientos.Text = "Listar Vencimientos";
            this.btnListarVencimientos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGestinarAlumnos);
            this.groupBox1.Controls.Add(this.btnListarVencimientos);
            this.groupBox1.Controls.Add(this.btnGestionarPagos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 529);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menú principal";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Club Deportivo - Menú";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestinarAlumnos;
        private System.Windows.Forms.Button btnGestionarPagos;
        private System.Windows.Forms.Button btnListarVencimientos;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}