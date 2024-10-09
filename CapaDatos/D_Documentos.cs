using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Configuration;

using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class D_Documentos
    {
        

        public DataTable ObtenerLocales()
        {
            // Definir la consulta SQL para obtener los nombres de los locales
            string query = "SELECT * FROM locales";  

            // Llamar a la función VisualizaS para obtener los datos de la tabla locales
            return Cls_funciones.VisualizaS(query);
        }

    }
}
