﻿using System;
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
                dtDatos.Rows[0]["doble_tick"] = documento.doble_tick; 
                dtDatos.Rows[0]["codigo_pro"] = documento.codigo_pro; 

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
        public DataTable ObtenerLocalesFiltrados(string textoBusqueda)
        {
            return docu.ObtenerLocalesFiltrados(textoBusqueda);
        }

        // Método para obtener los promociones como DataTable, usando la capa de datos
        public DataTable ObtenerPromociones()
        {
            return docu.ObtenerPromociones();
        }
        // Método para buscar documentos por un término de búsqueda
        public DataTable BuscarPromociones(string busqueda)
        {
            D_Documentos datosPromo = new D_Documentos();
            if (string.IsNullOrEmpty(busqueda))
            {
                return datosPromo.ObtenerTodasLasPromo();
            }
            else
            {
                return datosPromo.BuscarPromo(busqueda);
            }
        }

        // Método para buscar documentos por un término de búsqueda
        public DataTable BuscarDocumentos(string busqueda)
        {
            D_Documentos datosDocumentos = new D_Documentos();
            if (string.IsNullOrEmpty(busqueda))
            {
                return datosDocumentos.ObtenerTodosLosDocumentos();
            }
            else
            {
                return datosDocumentos.BuscarDocumentos(busqueda);
            }
        }

        // Método para obtener registros de un documento específico
        public DataTable ObtenerRegistrosPorDocumento(string codigoDoc)
        {
            D_Documentos datosDocumentos = new D_Documentos();
            return datosDocumentos.ObtenerRegistrosPorDocumento(codigoDoc);
        }

        // Método para obtener registros de reporte1
        public DataTable Reporte1Doc(string repbusloc, DateTime fechaDesdeRep1, DateTime fechaHastaRep1)
        {
            DateTime fechades = Convert.ToDateTime(fechaDesdeRep1).Date;
            DateTime fechahast = Convert.ToDateTime(fechaHastaRep1).Date;

            D_Documentos datosDocumentos = new D_Documentos();
            if (string.IsNullOrEmpty(repbusloc))
            {
                if (fechades == new DateTime(1999, 01, 01) && fechahast == new DateTime(1999, 01, 01))
                {
                    return datosDocumentos.ObtenerTodosLosDocRep1();
                }
                else
                {
                    return datosDocumentos.ObtenerFechasDocRep1(fechades, fechahast);
                }
                
            }
            else
            {
                if (fechades == new DateTime(1999, 01, 01) && fechahast == new DateTime(1999, 01, 01))
                {
                    return datosDocumentos.ObtenerLocDocRep1(repbusloc);
                }
                else
                {
                    return datosDocumentos.ObtenerFechasLocDocRep1(repbusloc, fechades, fechahast);
                }
               
            }
        }

        // Método para obtener registros de reporte2
        public DataTable Reporte2Doc(DateTime fechaDesdeRep2, DateTime fechaHastaRep2)
        {
            DateTime fechades = Convert.ToDateTime(fechaDesdeRep2).Date;
            DateTime fechahast = Convert.ToDateTime(fechaHastaRep2).Date;

            D_Documentos datosDocumentos = new D_Documentos();
            if (fechades == new DateTime(1999, 01, 01) && fechahast == new DateTime(1999, 01, 01))
            {
                return datosDocumentos.ObtenerTodosGenDocRep2();
            }
            else
            {
               
                return datosDocumentos.ObtenerFecGenDocRep2(fechaDesdeRep2, fechaHastaRep2);

            }
        }
        // Método para obtener registros de reporte3
        public DataTable Reporte3Doc(DateTime fechaDesdeRep3, DateTime fechaHastaRep3)
        {
            DateTime fechades = Convert.ToDateTime(fechaDesdeRep3).Date;
            DateTime fechahast = Convert.ToDateTime(fechaHastaRep3).Date;

            D_Documentos datosDocumentos = new D_Documentos();
            if (fechades == new DateTime(1999, 01, 01) && fechahast == new DateTime(1999, 01, 01))
            {
                return datosDocumentos.ObtenerTodosEdDocRep3();
            }
            else
            {

                return datosDocumentos.ObtenerFecEdDocRep3(fechaDesdeRep3, fechaHastaRep3);

            }
        }
    }
}
