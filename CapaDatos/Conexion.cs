using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class Conexion
    {
        private string connectionString;
        public Conexion()
        {
            // Leer cadena de conexión desde App.config
            connectionString = ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString;
        }
        public SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                return connection;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                throw;
            }
        }

        public void CloseConnection(SqlConnection connection)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        // Método para probar la conexión
        public void TestConnection()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Conexión a la base de datos establecida correctamente.");
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
    
}
