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
       private Conexion con = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand cmd = new SqlCommand();

        public DataTable Mostrar() 
        {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "Select * from documentos";
            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            con.CerrarConexion();
            return tabla;
        }

    }
}
