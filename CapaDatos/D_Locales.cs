using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class D_Locales
    {
        // Método para obtener todos las locales
        public DataTable ObtenerTodosLosLocales()
        {

            string query = "select codigo_loc as Codigo,nombre_loc as Nombre,ubi_loc as Ubicacion,email_loc as Correo,telefono_loc as Telefono,copro_escri_loc as Copropietario_escritura,copro_act_loc as Copropietario_actual,arrend_loc as Arrendatario, estado_loc as Activo from locales order by nombre_loc";

            DataTable dt = new DataTable();
            dt = Cls_funciones.VisualizaS(query);

            return dt;

        }

        // Método para buscar locales según un criterio
        public DataTable BuscarLocal(string busqueda)
        {

            string query = "select codigo_loc as Codigo,nombre_loc as Nombre,ubi_loc as Ubicacion,email_loc as Correo,telefono_loc as Telefono,copro_escri_loc as Copropietario_escritura,copro_act_loc as Copropietario_actual,arrend_loc as Arrendatario, estado_loc as Activo from locales where codigo_loc like'%" + busqueda + "%' or nombre_loc like'%" + busqueda + "%' order by nombre_loc";

            DataTable dt = new DataTable();
            dt = Cls_funciones.VisualizaS(query);
            return dt;

        }
    }
}
