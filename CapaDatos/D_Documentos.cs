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

        public DataTable ObtenerLocalesFiltrados(string textoBusqueda)
        {
            string query = "SELECT codigo_loc, nombre_loc FROM locales WHERE nombre_loc like '%" + textoBusqueda + "%'";

            DataTable dt = new DataTable();
            dt = Cls_funciones.VisualizaS(query);
            return dt;
        }

        // Método para obtener promociones vigentes
        public DataTable ObtenerPromociones()
        {
            // Definir la consulta SQL 
            string query = "SELECT * FROM promociones where estado_pro = 1";

            // Llamar a la función VisualizaS para obtener los datos de la tabla promociones
            return Cls_funciones.VisualizaS(query);
        }

        // Método para obtener todos los documentos
        public DataTable ObtenerTodosLosDocumentos()
        {
            
                string query = "SELECT d.codigo_doc as Codigo, d.numfac_doc as Factura, l.nombre_loc as Local, " +
                               "d.codigo_loc_do as Ced_Ruc_Pas, c.nombre_cli as Cliente, d.fecfac_doc as Fecha, d.valfac_doc as Valor, d.doble_tick as DobleTicket " +
                               "FROM documentos d " +
                               "INNER JOIN locales l ON l.codigo_loc = d.codigo_loc_doc " +
                               "INNER JOIN clientes c ON c.codigo_cli = d.codigo_cli_doc " +
                               "ORDER BY d.codigo_doc";

                DataTable dt = new DataTable();
                dt = Cls_funciones.VisualizaS(query);
                
                return dt;
            
        }

        // Método para buscar documentos según un criterio
        public DataTable BuscarDocumentos(string busqueda)
        {
            
                string query = "SELECT d.codigo_doc as Codigo, d.numfac_doc as Factura, l.nombre_loc as Local, " +
                               "d.codigo_loc_do as Ced_Ruc_Pas, c.nombre_cli as Cliente, d.fecfac_doc as Fecha, d.valfac_doc as Valor " +
                               "FROM documentos d " +
                               "INNER JOIN locales l ON l.codigo_loc = d.codigo_loc_doc " +
                               "INNER JOIN clientes c ON c.codigo_cli = d.codigo_cli_doc " +
                               "WHERE d.codigo_doc LIKE '%" + busqueda + "%' OR " +
                               "d.numfac_doc LIKE '%" + busqueda + "%' OR " +
                               "l.nombre_loc LIKE '%" + busqueda + "%' OR " +
                               "c.nombre_cli LIKE '%" + busqueda + "%' " +
                               "ORDER BY d.codigo_doc";

                DataTable dt = new DataTable();
                dt = Cls_funciones.VisualizaS(query);
                return dt;
            
        }

        // Método para obtener registros relacionados a un documento
        public DataTable ObtenerRegistrosPorDocumento(string codigoDoc)
        {
            
                string query = "SELECT * FROM registro_doc WHERE codigo_doc =" + codigoDoc + "";
           
                DataTable dt = new DataTable();
                dt = Cls_funciones.VisualizaS(query);
                return dt;
            
        }

    }
}
