using ProyectoIntegrador.Datos;
using System;
using System.Windows.Forms;

namespace ProyectoIntegrador
{
    public partial class frmIngresar : Form
    {
        public frmIngresar()
        {
            InitializeComponent();
            txtUsuario.Focus();
        }

        private void borrarDatos()
        {
            txtUsuario.Text = string.Empty;
            txtContrasena.Text = string.Empty;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool isValid = DatosUsuario.Ingresar(
                txtUsuario.Text,
                txtContrasena.Text
            );

            if(isValid)
            {
                frmMenu menu = new frmMenu();
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show(
                    "Los datos ingresados no son correctos.\nVerifiquelos y vuelva a intentarlo.",
                    "Error de ingreso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop
                );
                txtUsuario.Focus();
            }
            borrarDatos();
        }
    }
}
