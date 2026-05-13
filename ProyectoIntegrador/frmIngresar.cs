using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            const string USUARIO = "Administrador";
            const string CONTRASENA = "Admin1234";

            if(txtUsuario.Text == USUARIO & txtContrasena.Text == CONTRASENA)
            {
                MessageBox.Show(
                    "INGRESO OK",
                    "Error de ingreso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop
                );
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
