using ProyectoIntegrador.Datos;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoIntegrador
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnGestinarAlumnos_Click(object sender, EventArgs e)
        {
            frmGestionarAlumnos gestionarAlumnos = new frmGestionarAlumnos();
            gestionarAlumnos.Show();
        }
    }
}