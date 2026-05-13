using ProyectoIntegrador.Datos;
using System.Data;
using System.Windows.Forms;

namespace ProyectoIntegrador
{
    public partial class frmGestionarAlumnos : Form
    {
        private bool edit = false;
        private DataTable alumnos;


        public frmGestionarAlumnos()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            alumnos = DatosAlumno.obtenerListaAlumnos();
            dbgrdAlumnos.DataSource = alumnos;
        }

        private void btnVolver_Click(object sender, System.EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Hide();
        }

        private void dbgrdAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            edit = true;
            txtNombre.Text = alumnos.Rows[e.RowIndex]["nombre"].ToString();
            txtApellido.Text = alumnos.Rows[e.RowIndex]["apellido"].ToString();
            chkSocio.Checked = alumnos.Rows[e.RowIndex]["esSocio"].ToString() == "True";
        }
    }
}