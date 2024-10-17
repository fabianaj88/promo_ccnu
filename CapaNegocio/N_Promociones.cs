using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_Promociones
    {
        public bool GrabarPromociones(E_Promociones promocion)
        {
            string campos = Cls_funciones.leer_Campos_tabla("promociones");

            DataTable dtDatos = Cls_funciones.Inserta_Datos_tabla_tmp("promociones", "codigo_pro", "I");

            if (dtDatos.Rows.Count == 1)
            {
                dtDatos.Rows[0]["codigo_pro"] = promocion.codigo_pro;
                dtDatos.Rows[0]["nombre_pro"] = promocion.nombre_pro;
                dtDatos.Rows[0]["fec_ini_pro"] = promocion.fec_ini_pro;
                dtDatos.Rows[0]["fec_fin_pro"] = promocion.fec_fin_pro;
                dtDatos.Rows[0]["estado_pro"] = false;
                dtDatos.Rows[0]["monto_pro"] = promocion.monto_pro;
                dtDatos.Rows[0]["limtick_pro"] = promocion.limtick_pro;

                string condicion = Cls_funciones.Condicion_grabar(dtDatos, false);

                // Grabar datos en la base de datos
                return Cls_funciones.Grabar_Datos_DB("promociones", campos, condicion);
            }
            return false;
        }
    }
}
