using MySql.Data.MySqlClient;
using System.Data;

namespace ProyectoIntegrador.Datos
{
    internal class DatosAlumno
    {
        public static DataTable obtenerListaAlumnos()
        {
            DataTable alumnos = new DataTable();
            MySqlCommand LeerAlumnos = new MySqlCommand("LeerAlumnos");

            LeerAlumnos.CommandType = CommandType.StoredProcedure;

            return EjecutarComando.EjecutarMySQLCommand(LeerAlumnos);
        }

        public static int crearAlumno(Alumno alumno)
        {
            MySqlCommand CrearAlumno = new MySqlCommand("CrearAlumno");

            CrearAlumno.CommandType = CommandType.StoredProcedure;
            CrearAlumno.Parameters.Add("p_nombre", MySqlDbType.VarChar).Value = alumno.Nombre;
            CrearAlumno.Parameters.Add("p_apellido", MySqlDbType.VarChar).Value = alumno.Apellido;
            CrearAlumno.Parameters.Add("p_esSocio", MySqlDbType.Bit).Value = alumno.EsSocio;

            return int.Parse(
                EjecutarComando.EjecutarMySQLCommand(CrearAlumno).Rows[0]["identificador"].ToString()
            );
        }

        public static bool existeAlumno(string nombre, string apellido)
        {
            string query = "SELECT COUNT(*) FROM Alumno WHERE nombre = @nombre AND apellido = @apellido";
            MySqlCommand cmd = new MySqlCommand(query);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@apellido", apellido);
            DataTable dt = EjecutarComando.EjecutarMySQLCommand(cmd);
            return Convert.ToInt32(dt.Rows[0][0]) > 0;
        }