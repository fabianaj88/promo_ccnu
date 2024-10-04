using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos
{
    
    internal class Cls_funciones
    {
         
        public static DataTable leer_campos_sql(string xtabla )
        {
            DataTable dtResultado = new DataTable();
            return dtResultado;


        }
        public static DataTable VisualizaS(string query)
        {
            
            DataTable dtResultado = new DataTable();            
            using (SqlCommand cmdQuery = new SqlCommand(query, Cls_variables.conect_emp))
            {
                cmdQuery.CommandType = CommandType.Text;
                cmdQuery.CommandTimeout = 50000000;

                using (SqlDataAdapter da = new SqlDataAdapter(cmdQuery))
                {
                    try
                    {
                        da.Fill(dtResultado);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("ERROR: Revisar..");
                    }
                }
            }
            return dtResultado;
        }
        public static string EDAD(DateTime fecha)
        {
            int edadd = (int)((DateTime.Now - fecha).TotalDays % 365);
            string edadreturn = "";

            if (fecha != new DateTime(1900, 1, 1))
            {
                int hoyd = DateTime.Now.Day;
                int nacd = fecha.Day;
                int hoya = DateTime.Now.Year;
                int naca = fecha.Year;
                int hoym = DateTime.Now.Month;
                int nacm = fecha.Month;
                int edadm = hoym - nacm;

                if (edadm < 0) edadm += 12;

                int edada;
                if (edadm == 0)
                {
                    edada = hoya - naca;
                }
                else
                {
                    edada = hoya - naca;
                }

                if (edadm == 0)
                {
                    edadd = 0;
                }
                else
                {
                    edadd = hoyd - nacd;
                    if (edadd < 0) edadd = 0;
                }

                if (edadd == 0)
                {
                    edadreturn = $"{edada}.{edadm}";
                }
                else
                {
                    edadreturn = $"{edada}.{edadm}.{edadd}";
                }
            }
            else
            {
                edadreturn = "";
            }

            return edadreturn;
        }
        public static string leer_Campos_tabla(string tabla)
        {
            string sentencia = $"SELECT COLUMN_NAME FROM information_schema.columns WHERE table_name = '{tabla}'";
            DataTable dt = new DataTable();
            string campos = "";

            try
            {
                dt = VisualizaS(sentencia);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        campos += dt.Rows[i]["COLUMN_NAME"].ToString();
                        if (i < dt.Rows.Count - 1)
                        {
                            campos += ",";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones (opcional)
                Console.WriteLine($"Error: {ex.Message}");
            }

            return campos;
        }
        public static string Condicion_grabar(DataTable tabla_tmp, bool imagen)
        {
            string condicion = "";
            Type tipo;

            if (tabla_tmp.Rows.Count == 1)
            {
                for (int i = 0; i < tabla_tmp.Columns.Count; i++)
                {
                    tipo = tabla_tmp.Columns[i].DataType;

                    if (i < tabla_tmp.Columns.Count - 1) // Para las columnas excepto la última
                    {
                        if (tipo == typeof(string))
                            condicion += "'" + tabla_tmp.Rows[0][i].ToString().Trim() + "',";
                        else if (tipo == typeof(double) || tipo == typeof(decimal) || tipo == typeof(float))
                            condicion += Convert.ToDouble(tabla_tmp.Rows[0][i]).ToString("######0.00000").Replace(",", ".") + ",";
                        else if (tipo == typeof(int) || tipo == typeof(short) || tipo == typeof(long))
                            condicion += tabla_tmp.Rows[0][i] + ",";
                        else if (tipo == typeof(DateTime))
                            condicion += "'" + Cls_Fecha.ConvertirFecha((DateTime)tabla_tmp.Rows[0][i], "FH") + "',";
                        else if (tipo == typeof(bool))
                            condicion += "'" + tabla_tmp.Rows[0][i].ToString().Trim() + "',";
                        else if (tipo == typeof(byte[]))
                            condicion += imagen ? "@imagen," : "'{0}',";
                    }

                    if (i == tabla_tmp.Columns.Count - 1) // Para la última columna
                    {
                        if (tipo == typeof(string))
                            condicion += "'" + tabla_tmp.Rows[0][i].ToString().Trim() + "'";
                        else if (tipo == typeof(double) || tipo == typeof(decimal) || tipo == typeof(float))
                            condicion += Convert.ToDouble(tabla_tmp.Rows[0][i]).ToString("######0.00000").Replace(",", ".");
                        else if (tipo == typeof(int) || tipo == typeof(short) || tipo == typeof(long))
                            condicion += tabla_tmp.Rows[0][i];
                        else if (tipo == typeof(DateTime))
                            condicion += "'" + Cls_Fecha.ConvertirFecha((DateTime)tabla_tmp.Rows[0][i], "FH") + "'";
                        else if (tipo == typeof(bool))
                            condicion += "'" + tabla_tmp.Rows[0][i].ToString().Trim() + "'";
                        else if (tipo == typeof(byte[]))
                            condicion += imagen ? "@imagen" : "'{0}'";
                    }
                }
            }

            return condicion;
        }
        public static DataTable Inserta_Datos_tabla_tmp(string tabla, string campo_condicion, string tipo_dato, string campos = null)
        {
            DataTable dt_tabla_tmp = new DataTable();
            Type tipo;
            byte[] imagen = new byte[] { 0 };

            if (campos == null)
            {
                if (tipo_dato == "C")
                    dt_tabla_tmp = VisualizaS($"SELECT * FROM {tabla} WHERE {campo_condicion} = '//*'");
                else if (tipo_dato == "I")
                    dt_tabla_tmp = VisualizaS($"SELECT * FROM {tabla} WHERE {campo_condicion} IS NULL");
            }
            else
            {
                if (tipo_dato == "C")
                    dt_tabla_tmp = VisualizaS($"SELECT {campos} FROM {tabla} WHERE {campo_condicion} = '//*'");
                else if (tipo_dato == "I")
                    dt_tabla_tmp = VisualizaS($"SELECT {campos} FROM {tabla} WHERE {campo_condicion} IS NULL");
            }

            if (dt_tabla_tmp.Rows.Count == 0)
            {
                dt_tabla_tmp.Rows.Add();
                for (int i = 0; i < dt_tabla_tmp.Columns.Count; i++)
                {
                    tipo = dt_tabla_tmp.Columns[i].DataType;

                    if (tipo == typeof(string))
                        dt_tabla_tmp.Rows[0][i] = "";
                    else if (tipo == typeof(double))
                        dt_tabla_tmp.Rows[0][i] = 0.0;
                    else if (tipo == typeof(int))
                        dt_tabla_tmp.Rows[0][i] = 0;
                    else if (tipo == typeof(short))
                        dt_tabla_tmp.Rows[0][i] = (short)0;
                    else if (tipo == typeof(long))
                        dt_tabla_tmp.Rows[0][i] = 0L;
                    else if (tipo == typeof(DateTime))
                        dt_tabla_tmp.Rows[0][i] = new DateTime(1900, 1, 1);
                    else if (tipo == typeof(bool))
                        dt_tabla_tmp.Rows[0][i] = false;
                    else if (tipo == typeof(byte[]))
                        dt_tabla_tmp.Rows[0][i] = imagen;
                    else if (tipo == typeof(decimal))
                        dt_tabla_tmp.Rows[0][i] = 0m;
                    else if (tipo == typeof(float))
                        dt_tabla_tmp.Rows[0][i] = 0f;
                }
            }

            return dt_tabla_tmp;
        }
        public static bool Grabar_Datos_DB(string tabla, string campos, string valores)
        {
            bool control = false;
            DataTable dt_del = new DataTable();
            
            try
            {
                string query = $"INSERT INTO {tabla} ({campos}) VALUES ({valores})";
                SqlCommand cmdquery = new SqlCommand(query, Cls_variables.conect_emp)
                {
                    CommandType = CommandType.Text
                };                
                    // Execute without image
                using (SqlDataAdapter da = new SqlDataAdapter(cmdquery))
                {
                   da.Fill(dt_del);
                   control = true;
                }
                
              
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR.. no se puede grabar el registro, revise la información");
                control = false;
            }

            return control;
        }
        public static bool Elimina_Datos_DB(string tabla, string condicion)
        {
            
            bool control = false;
            DataTable dt_del = new DataTable();
            string query;

            if (!string.IsNullOrEmpty(condicion))
            {
                query = $"DELETE FROM {tabla} WHERE {condicion}";
            }
            else
            {
                query = $"DELETE FROM {tabla}";
            }

            using (SqlCommand cmdquery = new SqlCommand(query, Cls_variables.conect_emp))
            {
                cmdquery.CommandType = CommandType.Text;

                using (SqlDataAdapter da = new SqlDataAdapter(cmdquery))
                {
                    try
                    {
                        da.Fill(dt_del);
                        control = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("ERROR.. no se puede eliminar el registro, revise la información");
                        control = false;
                    }
                }
            }

            return control;
        }
        public static bool ModificaS(string tabla, string campos, string condicion)
        {
            
            bool control = false;
            DataTable dt_upd = new DataTable();
            string query;

                query = !string.IsNullOrEmpty(condicion)
                    ? $"UPDATE {tabla} SET {campos} WHERE {condicion}"
                    : $"UPDATE {tabla} SET {campos}";

                using (SqlCommand cmdquery = new SqlCommand(query, Cls_variables.conect_emp))
                {
                    cmdquery.CommandType = CommandType.Text;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmdquery))
                    {
                        try
                        {
                            da.Fill(dt_upd);
                            control = true;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("ERROR.. no se puede modificar el registro, revise la información");
                            control = false;
                        }
                    }
                }         

            return control;
        }
    }
}
