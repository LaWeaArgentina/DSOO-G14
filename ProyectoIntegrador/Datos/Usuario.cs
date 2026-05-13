using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador.Datos
{
    internal class Usuario
    {

        public bool Ingresar(string correo, string clave)
        {
            MySqlDataReader resultado; // variable de tipo datareader
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();
                MySqlCommand Ingresar = new MySqlCommand("Ingresar", sqlCon);
                
                Ingresar.CommandType = CommandType.StoredProcedure;
                Ingresar.Parameters.Add("correo", MySqlDbType.VarChar).Value = correo;
                Ingresar.Parameters.Add("clave", MySqlDbType.VarChar).Value = clave;

                sqlCon.Open();

                resultado = Ingresar.ExecuteReader(); // almacenamos el resulatdo en la variable
                tabla.Load(resultado); // cargamos la tabla con el resultado
                return tabla.Rows.Count == 1; // verificamos si la tabla contiene un registro y retornamos el resultado
            }

            catch (Exception ex)
            {
                throw;
            }

            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { 
                    sqlCon.Close();
                };
            }
        }
    }

}
