using MySql.Data.MySqlClient;
using System.Data;

namespace ProyectoIntegrador.Datos
{
    internal class DatosUsuario
    {
        public static bool Ingresar(string correo, string clave)
        {
            MySqlCommand Ingresar = new MySqlCommand("Ingresar");

            Ingresar.CommandType = CommandType.StoredProcedure;

            Ingresar.Parameters.Add("correo", MySqlDbType.VarChar).Value = correo;
            Ingresar.Parameters.Add("clave", MySqlDbType.VarChar).Value = clave;

            return EjecutarComando.EjecutarMySQLCommand(Ingresar).Rows.Count == 1; // retorna true cuando los datos estan OK
        }
    }
}