using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaNegocio
{
    public class N_Clientes
    {
        public bool GrabarClientes(E_Clientes cliente)
        {
            // Leer los campos de la tabla
            string campos = Cls_funciones.leer_Campos_tabla("clientes");

            // Crear tabla temporal
            DataTable dtDatos = Cls_funciones.Inserta_Datos_tabla_tmp("clientes", "codigo_cli", "C");

            if (dtDatos.Rows.Count == 1)
            {
                dtDatos.Rows[0]["codigo_cli"] = cliente.codigo_cli;
                dtDatos.Rows[0]["nombre_cli"] = cliente.nombre_cli;
                dtDatos.Rows[0]["apellido_cli"] = cliente.apellido_cli;
                dtDatos.Rows[0]["tipo_doc_cli"] = "CEDULA";
                dtDatos.Rows[0]["num_doc_cli"] = cliente.num_doc_cli;
                dtDatos.Rows[0]["fecha_nac_cli"] = cliente.fecha_nac_cli;
                dtDatos.Rows[0]["genero_cli"] = cliente.genero_cli;
                dtDatos.Rows[0]["celular_cli"] = cliente.celular_cli;
                dtDatos.Rows[0]["telefono_cli"] = cliente.telefono_cli;
                dtDatos.Rows[0]["direccion_cli"] = cliente.direccion_cli;
                dtDatos.Rows[0]["saldo_cli"] = 0;


                string condicion = Cls_funciones.Condicion_grabar(dtDatos, false);

                // Grabar datos en la base de datos
                return Cls_funciones.Grabar_Datos_DB("clientes", campos, condicion);
            }

            return false;
        }
    }
}
