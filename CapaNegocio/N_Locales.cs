using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace CapaNegocio
{
    public class N_Locales
    {
        private D_Locales dloc = new D_Locales();
        public  bool GrabarLocales(E_Locales local)
        {
            // Leer los campos de la tabla
            string campos = Cls_funciones.leer_Campos_tabla("locales");

            // Crear tabla temporal
            DataTable dtDatos = Cls_funciones.Inserta_Datos_tabla_tmp("locales", "codigo_loc", "C");

            if (dtDatos.Rows.Count == 1)
            {
                dtDatos.Rows[0]["codigo_loc"] = local.codigo_loc;
                dtDatos.Rows[0]["nombre_loc"] = local.nombre_loc;
                dtDatos.Rows[0]["ubi_loc"] = local.ubi_loc;
                dtDatos.Rows[0]["email_loc"] = local.email_loc;
                dtDatos.Rows[0]["telefono_loc"] = local.telefono_loc;
                dtDatos.Rows[0]["copro_escri_loc"] = local.copro_escri_loc;
                dtDatos.Rows[0]["copro_act_loc"] = local.copro_act_loc;
                dtDatos.Rows[0]["arrend_loc"] = local.arrend_loc;
                dtDatos.Rows[0]["estado_loc"] = local.estado_loc;
                

                string condicion = Cls_funciones.Condicion_grabar(dtDatos, false);

                // Grabar datos en la base de datos l
                return Cls_funciones.Grabar_Datos_DB("locales", campos, condicion);
            }

            return false;
        }

        
        // Método para buscar locales por un término de búsqueda
        public DataTable BuscarLocales(string busqueda)
        {
            
            if (string.IsNullOrEmpty(busqueda))
            {
                return dloc.ObtenerTodosLosLocales();
            }
            else
            {
                return dloc.BuscarLocal(busqueda);
            }
        }
    }
}
