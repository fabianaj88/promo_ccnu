using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;


namespace CapaNegocio
{
    public class N_Documentos
    {
        private D_Documentos objetoDoc = new D_Documentos();

        public DataTable MostrarDoc()
        { 
            DataTable tabla = new DataTable();
            tabla = objetoDoc.Mostrar();
            return tabla;
        }
    }
}
