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
        public static (float , List<E_RegistroDoc>, bool) ProcesarSaldoCliente(int coddoc, string codigoCliente, float totalFactura, float montoTicket, int codpro, bool dobleTic)
        {
            float salActcli = 0;
            // Obtener saldo actual del cliente
            object resultado = Cls_funciones.LeerRegistrosEnTablaSql("clientes", "saldo_cli", "N", "codigo_cli ='" + codigoCliente + "'");
            salActcli = (float)Convert.ToDouble(resultado);

            // Sumar el total de la factura al saldo actual
            float nuevoSaldo = salActcli + totalFactura;

            // Calcular cuántos tickets se pueden generar
            int cantidadTickets = 0;
            if (dobleTic)
            {
                cantidadTickets = (int)((nuevoSaldo / montoTicket)*2);
            }
            else
            {
                cantidadTickets = (int)(nuevoSaldo / montoTicket);
            }

            // Obtener el límite de tickets permitido por la promoción
            int limpro = 0;
            object res_limpro = Cls_funciones.LeerRegistrosEnTablaSql("promociones", "limtick_pro", "N", "codigo_pro =" + codpro + "");
            limpro = (int)Convert.ToInt64(res_limpro);

            // Obtener el número de tickets actuales del cliente
            object res_ticketsActuales = Cls_funciones.LeerRegistrosEnTablaSql("registro_doc r inner join documentos d on d.codigo_doc = r.codigo_doc", "COUNT(r.num_tic)", "N", "d.codigo_cli_doc='" + codigoCliente + "' AND codigo_pro=" + codpro + "");
            int ticketsActuales = (int)Convert.ToInt64(res_ticketsActuales);

            // Verificar si el cliente ya alcanzó el límite de tickets para la promoción
            int ticketsDisponibles = limpro - ticketsActuales;
            if (ticketsDisponibles <= 0)
            {
                // Si ya alcanzó el límite, se deja el saldo en 0 y no se generan más tickets
                Cls_funciones.ModificaS("clientes", "saldo_cli=0", "codigo_cli='" + codigoCliente + "'");
                // true indica que se alcanzó el límite
                return (0, new List<E_RegistroDoc> { },true); // Retornar saldo 0 y sin generar tickets
            }

            // Ajustar la cantidad de tickets a generar según el límite de la promoción
            cantidadTickets = Math.Min(cantidadTickets, ticketsDisponibles);

            //Si no alcanza para un ticket, solo actualizamos el saldo
            if (cantidadTickets == 0)
            {
                //Cls_funciones.ModificaS("clientes", "saldo_cli=" + nuevoSaldo.ToString() + "", "codigo_cli='" + codigoCliente + "'");
                return (nuevoSaldo, new List<E_RegistroDoc> { },false);
            }
            else
            {
                // Si se generan tickets, restamos el valor de los tickets del saldo
                float sobra = nuevoSaldo % montoTicket;
                //Cls_funciones.ModificaS("clientes", "saldo_cli=" + sobra.ToString() + "", "codigo_cli='" + codigoCliente + "'");
                // Generar los registros de los tickets
               
                List<E_RegistroDoc> registros = GenerarRegistrosDoc(coddoc,cantidadTickets,codpro,limpro);

                return (sobra,registros,false);// false indica que no se alcanzó el límite
            }   
        }

        public static List<E_RegistroDoc> GenerarRegistrosDoc(int coddoc,int cantidadTickets,int codpro, int limpro)
        {
            List<E_RegistroDoc> registrosDoc = new List<E_RegistroDoc>();
            DateTime fechaActual = DateTime.Now;
            int cod_regdoc = 0;
            
            object res_regdoc = Cls_funciones.LeerRegistrosEnTablaSql("registro_doc", "ISNULL(MAX(num_tic), 0) + 1", "N", "");
            cod_regdoc = (int)Convert.ToInt64(res_regdoc);

            // Generar solo la cantidad de tickets que se puede según el límite de la promoción
            for (int i = 0; i < Math.Min(cantidadTickets, limpro); i++)
            {
                E_RegistroDoc registro = new E_RegistroDoc
                {
                    num_tic = cod_regdoc + i,
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
                    dt_registro.Rows[0]["num_Tic"] = registro.num_tic;
                    dt_registro.Rows[0]["codigo_doc"] = codigoDoc;
                    dt_registro.Rows[0]["fecemi_tic"] = registro.fecemi_tic;
                    dt_registro.Rows[0]["estado_tic"] = true;
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
