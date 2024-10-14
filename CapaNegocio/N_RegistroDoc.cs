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
        public static (float , List<E_RegistroDoc>) ProcesarSaldoCliente(string codigoCliente, float totalFactura, float montoTicket)
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
                List<E_RegistroDoc> registros = GenerarRegistrosDoc(cantidadTickets);

                return (sobra,registros);
            }   
        }

        public static List<E_RegistroDoc> GenerarRegistrosDoc(int cantidadTickets)
        {
            List<E_RegistroDoc> registrosDoc = new List<E_RegistroDoc>();
            DateTime fechaActual = DateTime.Now;

            for (int i = 0; i < cantidadTickets; i++)
            {
                E_RegistroDoc registro = new E_RegistroDoc
                {
                    num_Tic = i + 1,  
                    codigo_doc = 0,
                    fecemi_tic = fechaActual,
                    estado_tic = false,  
                    codigo_pro = 0
                };

                registrosDoc.Add(registro);
            }

            return registrosDoc;

        }
        
    }
}
