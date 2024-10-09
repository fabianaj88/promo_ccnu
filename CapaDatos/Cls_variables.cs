using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
     public class Cls_variables
    {
        public static SqlConnection ConectDB = new SqlConnection();
        public static SqlConnection conect_emp = new SqlConnection();

        public static string Cadena { get; set; }
        public static string cadena_emp { get; set; }

        private static SqlConnection conec = new SqlConnection(ConfigurationManager.AppSettings["dbConnection"]);
        private static SqlConnection conec_emp = new SqlConnection(ConfigurationManager.AppSettings["dbConnection2"]);

        public static string empresa { get; set; }
        public static string xcodigo_usu { get; set; }
        public static string usuario { get; set; }
        public static string servidor_bd { get; set; }
        public static string clave_bd { get; set; }
        public static string basedatos { get; set; }
        public static string usuario_bd { get; set; }
        public static string clave_tecnico { get; set; }
        public static int tipo_usu { get; set; }
        public static string menu { get; set; }
        public static string item { get; set; }
        public static int sis_tipo { get; set; }
        public static int estaciones { get; set; }
        public static int anio { get; set; }
        public static string nombre_terminal { get; set; }
        public static string ip_terminal { get; set; }
        public static string mac_terminal { get; set; }
        public static string sucursal { get; set; }
    }
}
