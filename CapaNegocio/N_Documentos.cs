using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;
using CapaEntidades;


namespace CapaNegocio
{
    public class N_Documentos
    {
        private D_Documentos docu = new D_Documentos();
        public bool GrabarDocumento(E_Documentos documento)
        {
            // Leer los campos de la tabla
            string campos = Cls_funciones.leer_Campos_tabla("documentos");



            // Crear tabla temporal
            DataTable dtDatos = Cls_funciones.Inserta_Datos_tabla_tmp("documentos", "codigo_doc", "I");

            if (dtDatos.Rows.Count == 1)
            {
                dtDatos.Rows[0]["codigo_doc"] = documento.codigo_doc;
                dtDatos.Rows[0]["numfac_doc"] = documento.numfac_doc;
                dtDatos.Rows[0]["codigo_loc_doc"] = documento.codigo_loc_doc;
                dtDatos.Rows[0]["codigo_cli_doc"] = documento.codigo_cli_doc;
                dtDatos.Rows[0]["fecfac_doc"] = documento.fecfac_doc;
                dtDatos.Rows[0]["valfac_doc"] = documento.valfac_doc;
                dtDatos.Rows[0]["obv_doc"] = documento.obv_doc; // Opcional

                string condicion = Cls_funciones.Condicion_grabar(dtDatos, false);

                // Grabar datos en la base de datos
                return Cls_funciones.Grabar_Datos_DB("documentos", campos, condicion);
            }

            return false;
        }

        // Método para obtener los locales como DataTable, usando la capa de datos
        public DataTable ObtenerLocales()
        {
            return docu.ObtenerLocales();
        }
       
    }
}
