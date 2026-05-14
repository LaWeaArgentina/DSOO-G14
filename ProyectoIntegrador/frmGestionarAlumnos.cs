using ProyectoIntegrador.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace ProyectoIntegrador
{
    public partial class frmGestionarAlumnos : Form
    {
        private bool edit = false;
        private List<Alumno> alumnos = new List<Alumno>();

        public frmGestionarAlumnos()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            DataTable datosalumnos = DatosAlumno.obtenerListaAlumnos();

            foreach (DataRow row in datosalumnos.Rows)
            {
                if (row["esSocio"].ToString() == "True")
                {
                    alumnos.Add(
                        new Socio(
                            int.Parse( row["identificador"].ToString() ),
                            row["nombre"].ToString(),
                            row["apellido"].ToString(),
                            DateTime.ParseExact(
                                row["vencimiento"].ToString(),
                                "dd/M/yyyy HH:mm:ss",
                                CultureInfo.InvariantCulture
                            ) 
                        )
                    );
                }

                else
                {
                    alumnos.Add(
                        new Nosocio(
                            int.Parse(row["identificador"].ToString()),
                            row["nombre"].ToString(),
                            row["apellido"].ToString()
                        )
                    );
                }
            };

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
            txtNombre.Text = alumnos[e.RowIndex].Nombre;
            txtApellido.Text = alumnos[e.RowIndex].Apellido;
            chkSocio.Checked = alumnos[e.RowIndex].EsSocio;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            edit = false;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            chkSocio.Checked = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (edit == false)
            {
                if (chkSocio.Checked == true)
                {
                    Socio newSocio = new Socio(
                        txtNombre.Text,
                        txtApellido.Text
                    );
                    DatosAlumno.crearAlumno(newSocio);
                }

                else
                {
                    Nosocio newNosocio = new Nosocio(
                        txtNombre.Text,
                        txtApellido.Text
                    );
                    DatosAlumno.crearAlumno(newNosocio);
                }
            }
            
            else 
            {
                // TODO: Editar un registro
            }

            btnLimpiar_Click(sender, e);
            CargarDatos();
        }
    }
}