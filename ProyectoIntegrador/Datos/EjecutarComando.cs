using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ProyectoIntegrador.Datos
{
    public class EjecutarComando
    {
        public static DataTable EjecutarMySQLCommand(MySqlCommand command)
        {
            MySqlConnection conexion = new MySqlConnection();
            DataTable datos = new DataTable();
            MySqlDataReader resultado;

            try
            {
                conexion = Conexion.getInstancia().CrearConcexion();
                conexion.Open();
                command.Connection = conexion;
                resultado = command.ExecuteReader();
                datos.Load(resultado);
            }

            catch (Exception ex)
            {
                throw;
            }

            finally
            {
                conexion.Close();
            }

            return datos;
        }
    }
}