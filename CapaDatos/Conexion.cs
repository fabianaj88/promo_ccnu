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
        private SqlConnection Con = new SqlConnection("Server=DESKTOP-QDFSRUE;Database=ccnu;User Id=sa;Password=alf;");

        public SqlConnection AbrirConexion()
        {
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            return Con;
        }
        public SqlConnection CerrarConexion()
        {
            if (Con.State == ConnectionState.Open)
                Con.Close();
            return Con;
        }
        public static void ConeccionBD()
        {
            // Establecer la cadena de conexión para la segunda base de datos
            ConfigurationManager.AppSettings["dbConnection2"] = "";
            Cls_variables.cadena_emp = $"Data Source={Cls_variables.servidor_bd}; Initial Catalog={Cls_variables.basedatos}; User Id={Cls_variables.usuario_bd}; Password={Cls_variables.clave_bd}";
            ConfigurationManager.AppSettings["dbConnection2"] = Cls_variables.cadena_emp;

            // Verificar la conexión a la empresa
            VerificarConeccionEmpresa();
        }
        public static bool VerificarConeccionEmpresa()
        {
            bool sino = false;

            try
            {
                Cls_variables.conect_emp = new SqlConnection(ConfigurationManager.AppSettings["dbConnection2"]);
                Cls_variables.conect_emp.Open(); // Abre la conexión para verificar
                sino = true;
            }
            catch (Exception)
            {
                sino = false;
            }
            finally
            {
                // Cierra la conexión si fue abierta
                if (Cls_variables.conect_emp != null && Cls_variables.conect_emp.State == System.Data.ConnectionState.Open)
                {
                    Cls_variables.conect_emp.Close();
                }
            }

            return sino;
        }

    }
  
}
