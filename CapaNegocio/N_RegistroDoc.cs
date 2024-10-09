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
        public static void GenerarTicket(string codigoCliente, float totalFactura, float montoTicket)
        {
            float salActcli = 0;
            // Obtener saldo actual del cliente
            object resultado = Cls_funciones.LeerRegistrosEnTablaSql("clientes", "saldo_cli", "N", "codigo_cli ='" + codigoCliente + "'");
            salActcli = (float)Convert.ToDouble(resultado);
            // Sumar el total de la factura al saldo actual
            float nuevoSaldo = salActcli + totalFactura;
            string nuevoSaldocli = nuevoSaldo.ToString();
            // Calcular cuántos tickets se pueden generar
            int cantidadTickets = (int)(nuevoSaldo / montoTicket);

            //Si no alcanza para un ticket, solo actualizamos el saldo
            if (cantidadTickets == 0)
            {
                Cls_funciones.ModificaS("clientes", "saldo_cli=" + nuevoSaldocli + "", "codigo_cli='" + codigoCliente + "'");
            }
            else
            {
                // Si se generan tickets, restamos el valor de los tickets del saldo
                float sobra = nuevoSaldo % montoTicket;
                string sobracli = sobra.ToString();
                Cls_funciones.ModificaS("clientes", "saldo_cli=" + sobracli + "", "codigo_cli='" + codigoCliente + "'");

            }
        }

    }
}
