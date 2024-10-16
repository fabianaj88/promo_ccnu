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
    public class N_RegistroDoc
    {
        public static (float , List<E_RegistroDoc>) ProcesarSaldoCliente(int coddoc, string codigoCliente, float totalFactura, float montoTicket)
        {
            float salActcli = 0;
            // Obtener saldo actual del cliente
            object resultado = Cls_funciones.LeerRegistrosEnTablaSql("clientes", "saldo_cli", "N", "codigo_cli ='" + codigoCliente + "'");
            salActcli = (float)Convert.ToDouble(resultado);

            // Sumar el total de la factura al saldo actual
            float nuevoSaldo = salActcli + totalFactura;

            // Calcular cuántos tickets se pueden generar
            int cantidadTickets = (int)(nuevoSaldo / montoTicket);

            //Si no alcanza para un ticket, solo actualizamos el saldo
            if (cantidadTickets == 0)
            {
                //Cls_funciones.ModificaS("clientes", "saldo_cli=" + nuevoSaldo.ToString() + "", "codigo_cli='" + codigoCliente + "'");
                return (nuevoSaldo, new List<E_RegistroDoc> { });
            }
            else
            {
                // Si se generan tickets, restamos el valor de los tickets del saldo
                float sobra = nuevoSaldo % montoTicket;
                //Cls_funciones.ModificaS("clientes", "saldo_cli=" + sobra.ToString() + "", "codigo_cli='" + codigoCliente + "'");
                // Generar los registros de los tickets
                int codpro = 0;
                object res_codpro = Cls_funciones.LeerRegistrosEnTablaSql("promociones", "codigo_pro", "N", "estado_pro = 1");
                codpro = (int)Convert.ToInt64(res_codpro);

                List<E_RegistroDoc> registros = GenerarRegistrosDoc(coddoc,cantidadTickets,codpro);

                return (sobra,registros);
            }   
        }

        public static List<E_RegistroDoc> GenerarRegistrosDoc(int coddoc,int cantidadTickets,int codpro)
        {
            List<E_RegistroDoc> registrosDoc = new List<E_RegistroDoc>();
            DateTime fechaActual = DateTime.Now;

            for (int i = 0; i < cantidadTickets; i++)
            {
                E_RegistroDoc registro = new E_RegistroDoc
                {
                    num_tic = i + 1,  
                    codigo_doc = coddoc,
                    fecemi_tic = fechaActual,
                    estado_tic = false,  
                    codigo_pro = codpro
                };

                registrosDoc.Add(registro);
            }

            return registrosDoc;

        }

        public static bool GrabarRegdoc(List<E_RegistroDoc> registros, int codigoDoc, string codigoCliente ,float saldocliente)
        {
            //Actualizar saldo del cliente
            Cls_funciones.ModificaS("clientes","saldo_cli ="+saldocliente+"","codigo_cli ='"+codigoCliente+"'");

            // Obtener los campos de la tabla registro_doc
            string campos = Cls_funciones.leer_Campos_tabla("registro_doc");
            
            // Indicador para saber si al menos un registro fue grabado correctamente
            bool exito = false;

            foreach (var registro in registros)
            {
                // Insertar los datos en la tabla temporal antes de grabar
                DataTable dt_registro = Cls_funciones.Inserta_Datos_tabla_tmp("registro_doc", "num_tic", "I");

                if (dt_registro.Rows.Count == 1)
                {
                    //dt_registro.Rows[0]["num_Tic"] = registro.num_tic;
                    dt_registro.Rows[0]["codigo_doc"] = codigoDoc;
                    dt_registro.Rows[0]["fecemi_tic"] = registro.fecemi_tic;
                    dt_registro.Rows[0]["estado_tic"] = registro.estado_tic ? 1 : 0;
                    dt_registro.Rows[0]["codigo_pro"] = registro.codigo_pro;

                    // Condición para grabar en la base de datos
                    string condicion = Cls_funciones.Condicion_grabar(dt_registro, false);

                    // Grabar los datos en la tabla real (registro_doc)
                    bool resultado = Cls_funciones.Grabar_Datos_DB("registro_doc", campos, condicion);
                    if (resultado)
                    {
                        exito = true;
                    }
                    else
                    {
                        exito = false;
                    }
                }
            }
            return exito;
        }


    }
}
