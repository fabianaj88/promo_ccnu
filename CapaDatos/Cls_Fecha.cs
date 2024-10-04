using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    internal class Cls_Fecha
    {
        public static string ConvertirFecha(DateTime fecha, string ffh)
        {
            string ansi = "";
            string fansi = "";
            string fhansi = "";
            string año = fecha.Year.ToString();
            string mes = fecha.Month < 10 ? "0" + fecha.Month.ToString() : fecha.Month.ToString();
            string día = fecha.Day < 10 ? "0" + fecha.Day.ToString() : fecha.Day.ToString();
            string hora = fecha.Hour.ToString();
            string minuto = fecha.Minute.ToString();
            string segundo = fecha.Second.ToString();

            try
            {
                fansi = año + mes + día;
                fhansi = $"{año}{mes}{día} {hora}:{minuto}:{segundo}";

                if (ffh == "F")
                {
                    ansi = fansi;
                }
                else if (ffh == "FH")
                {
                    ansi = fhansi;
                }

                return ansi;
            }
            catch (Exception ex)
            {
                ansi = ex.ToString();
                return ansi;
            }
        }
    }
}
