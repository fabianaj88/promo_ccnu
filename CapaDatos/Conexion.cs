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
                Con.Open();
            return Con;
        }
    }
  
}
