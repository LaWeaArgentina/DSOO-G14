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

        public static bool crearAlumno(string nombre, string apellido, bool esSocio, string vencimiento )
        {

            return true;
        }
    }
}