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

        public static string crearAlumno(Alumno alumno)
        {
            MySqlCommand CrearAlumno = new MySqlCommand("CrearAlumno");

            CrearAlumno.CommandType = CommandType.StoredProcedure;
            CrearAlumno.Parameters.Add("p_nombre", MySqlDbType.VarChar).Value = alumno.Nombre;
            CrearAlumno.Parameters.Add("p_apellido", MySqlDbType.VarChar).Value = alumno.Apellido;
            CrearAlumno.Parameters.Add("p_esSocio", MySqlDbType.Bit).Value = alumno.EsSocio;

            return EjecutarComando.EjecutarMySQLCommand(CrearAlumno).ToString();
        }
    }
}