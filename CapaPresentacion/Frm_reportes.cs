using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iText.Kernel.Pdf;
using iText.Layout;
using iText.IO.Font.Constants;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Diagnostics;
using System.Drawing;
using CapaNegocio;
using System.Data.Common;
using CapaDatos;
using System.Windows.Forms.DataVisualization.Charting;//(K)

using ClosedXML.Excel;
using DataTable = System.Data.DataTable;

namespace CapaPresentacion
{
    public partial class Frm_reportes : Form
    {
        private N_Documentos ndocu = new N_Documentos();
        public Frm_reportes()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        // Generacion del Grafico de Barras 
        // Crea las variables de Genero y Cantidad
        private List<(string Genero, int Cantidad)> ObtenerDatosDesdeBase(DataGridView dgv)
        {
            List<(string Genero, int Cantidad)> datos = new List<(string Genero, int Cantidad)>();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow) // Evita las filas vacías
                {
                    // Verifica que no sea la fila de totales
                    if (row.Cells["Genero"].Value?.ToString() == "Totales ==>")
                        continue;
                    //Genera las Variables
                    string genero = row.Cells["Genero"].Value.ToString();
                    int cantidad = Convert.ToInt32(row.Cells["Clientes"].Value);
                    datos.Add((genero, cantidad));
                }
            }
            return datos;
        }
        //Actualiza Grafico con los datos de genero y cantidad
        private void ActualizarGraficoDesdeTabla(Chart chart, DataGridView dgv)
        {
            var datos = ObtenerDatosDesdeBase(dgv);
            chart.Series[0].Points.Clear(); // Limpia los puntos del gráfico existente

            foreach (var dato in datos)
            {
                DataPoint punto = new DataPoint
                {
                    AxisLabel = dato.Genero,
                    YValues = new double[] { dato.Cantidad },
                    Label = dato.Cantidad.ToString()
                };
                chart.Series[0].Points.Add(punto);
            }
        }
        //Obtiene los Datos correspondientes
        private List<(string Rango, int Clientes)> ObtenerDatosDesdeBaseEdad(DataGridView dgv)
        {
            List<(string Rango, int Clientes)> datos = new List<(string Rango, int Clientes)>();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow) // Evita filas vacías
                {
                    // Verifica que no sea la fila de totales (Si no se incluye genera una cuarta barra con el total)
                    if (row.Cells["RangoEdad"].Value?.ToString() == "Totales ==>")
                        continue;

                    string rango = row.Cells["RangoEdad"].Value.ToString();
                    int cliente = Convert.ToInt32(row.Cells["Clientes"].Value);
                    datos.Add((rango, cliente));
                }
            }
            return datos;
        }
        //Actualiza los Graficos y Limpia los Datos
        //Obtiene los Datos que se utilizaran Rango y Clientes
        private void ActualizarGraficoDesdeTablaEdad(Chart chart, DataGridView dgv)
        {
            var datos = ObtenerDatosDesdeBaseEdad(dgv);
            chart.Series[0].Points.Clear(); // Limpia los puntos del gráfico existente

            foreach (var dato in datos)
            {
                DataPoint punto = new DataPoint
                {
                    AxisLabel = dato.Rango,
                    YValues = new double[] { dato.Clientes },
                    Label = dato.Clientes.ToString()
                };
                chart.Series[0].Points.Add(punto);
            }
        }
        //Crea el Grafico de Columnas
        private Chart CrearGrafico(List<(string Genero, int Cantidad)> datos)
        {
            Chart chart = new Chart();
            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            Series series = new Series
            {
                ChartType = SeriesChartType.Column, //Aqui gracias a la Libreria se puede seleccionar que tipo de grafico se desea (CUIDADO: La mayoria de graficos se configuran diferentes)
                IsValueShownAsLabel = true, // Mostrar valores en las barras
                LabelForeColor = Color.Black, // Color de los números
            };

            foreach (var dato in datos)
            {
                DataPoint punto = new DataPoint();
                punto.AxisLabel = dato.Genero; // Etiqueta del eje X
                punto.YValues = new double[] { dato.Cantidad }; // Valor Y
                punto.Label = dato.Cantidad.ToString(); // Mostrar número
                punto.LabelFormat = "C"; // Formato de número
                punto.LabelForeColor = Color.Black;//Color de las etiquetas en X y Y
                punto.Font = new Font("Arial", 10); // Fuente
                series.Points.Add(punto);

            }

            chart.Series.Add(series);

            chartArea.AxisX.Title = "Género";
            chartArea.AxisY.Title = "Estadistica";
            chartArea.AxisX.Interval = -1;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisX.LabelStyle.Font = new Font("Arial", 5);
            chartArea.AxisX.LabelStyle.ForeColor = Color.Black; ;


            return chart;
        }
        //Creacion Grafico de Pie
        private Chart CrearGraficoPie(List<(string RangoEdad, int Clientes)> datos)
        {
            Chart chart = new Chart();
            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            Series series = new Series
            {
                ChartType = SeriesChartType.Pie, // Tipo de gráfico pie (CUIDADO: La mayoria de graficos se configuran diferentes)
                IsValueShownAsLabel = true // Mostrar valores en las secciones del gráfico
            };

            foreach (var dato in datos)
            {
                DataPoint punto = new DataPoint
                {
                    AxisLabel = dato.RangoEdad, // Etiqueta del gráfico (Rango de Edad)
                    YValues = new double[] { dato.Clientes }, // Valor de la sección
                    Label = $"{dato.RangoEdad}: {dato.Clientes}" // Etiqueta en el gráfico
                };

                // Configurar estilos opcionales para cada sección
                punto.LabelForeColor = Color.Black; // Color del texto
                punto.Font = new Font("Arial", 10, FontStyle.Bold);
                series.Points.Add(punto);
            }

            chart.Series.Add(series);

            // Configurar el área del gráfico
            chartArea.BackColor = Color.Transparent; // Fondo transparente
            chartArea.Area3DStyle.Enable3D = false; // Habilitar efecto 3D (opcional)

            // Configurar el tamaño del gráfico
            chart.Width = 500;
            chart.Height = 500;

            return chart;
        }
        //--------Poner los nombres de las tabPages en Horizotal---------------------
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tabControl = sender as TabControl;
            Graphics g = e.Graphics;
            Brush textBrush = new SolidBrush(Color.Black);

            // Obtener la pestaña actual
            TabPage tabPage = tabControl.TabPages[e.Index];
            Rectangle tabBounds = tabControl.GetTabRect(e.Index);

            // Dibujar el fondo de la pestaña
            if (e.State == DrawItemState.Selected)
            {
                g.FillRectangle(Brushes.LightBlue, tabBounds);
            }
            else
            {
                g.FillRectangle(SystemBrushes.Control, tabBounds);
            }

            // Configurar el formato del texto para mantenerlo horizontal
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            // Dibujar el texto en horizontal
            g.DrawString(tabPage.Text, tabControl.Font, textBrush, tabBounds, stringFormat);
        }


        //------------------------------------------------------------------
        //----------Proceso Reporte 1----------------------------------------
        private void cmb_locrep1_Click(object sender, EventArgs e)
        {
            if (cmb_locrep1.Text == "")
            {
                LlenarComboBoxLocales();
            }
        }
        private void cmb_locrep1_Leave(object sender, EventArgs e)
        {
            if (cmb_locrep1.Text != "")
            {
                string textoBusqueda = cmb_locrep1.Text;
                FiltrarLocales(textoBusqueda);

            }
        }
        private void LlenarComboBoxLocales()
        {
            // Llamar a la capa de negocio para obtener los locales
            DataTable dtLocales = ndocu.ObtenerLocales();

            if (dtLocales.Rows.Count > 0)
            {

                cmb_locrep1.DataSource = dtLocales;
                cmb_locrep1.DisplayMember = "nombre_loc";  // Nombre que se mostrará en el ComboBox
                cmb_locrep1.ValueMember = "codigo_loc";    // Valor asociado 

            }
            else
            {
                MessageBox.Show("No se encontraron locales.");
            }
        }
        private void FiltrarLocales(string textoBusqueda)
        {
            // Almacena el texto ingresado por el usuario
            string textoIngresado = cmb_locrep1.Text;

            // Llamar a la capa de negocio para obtener los locales filtrados por el texto ingresado
            DataTable dtLocales = ndocu.ObtenerLocalesFiltrados(textoBusqueda);

            if (dtLocales.Rows.Count > 0)
            {

                // Actualizar el DataSource
                cmb_locrep1.DataSource = dtLocales;
                cmb_locrep1.DisplayMember = "nombre_loc";
                cmb_locrep1.ValueMember = "codigo_loc";

                // Actualizar sugerencias para autocompletado
                AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
                foreach (DataRow row in dtLocales.Rows)
                {
                    autoCompleteCollection.Add(row["nombre_loc"].ToString());
                }
                cmb_locrep1.AutoCompleteCustomSource = autoCompleteCollection;

            }
            else
            {
                // Limpiar el DataSource y sugerencias si no hay coincidencias
                MessageBox.Show("El local no existe.");
                cmb_locrep1.Text = "";
            }
        }
        private void btn_acprep1_Click(object sender, EventArgs e)
        {
            // Asignar un valor predeterminado si el ComboBox está vacío o no tiene selección
            string repbusloc = cmb_locrep1.SelectedValue != null ? cmb_locrep1.SelectedValue.ToString() : "";

            DateTime fechaDesdeRep1 = Convert.ToDateTime(dtp_desdrep1.Value).Date;
            DateTime fechaHastaRep1 = Convert.ToDateTime(dtp_hastarep1.Value).Date;

            N_Documentos nRep = new N_Documentos();
            DataTable dt_rep1 = nRep.Reporte1Doc(repbusloc, fechaDesdeRep1, fechaHastaRep1);

            dgv_rep1.DataSource = dt_rep1;

            // Calcular los totales
            AgregarFilaTotales(dt_rep1);

            // Personalizar los encabezados de las columnas en el DataGridView
            dgv_rep1.Columns["FechaPrimeraFactura"].HeaderText = "Primera Factura";
            dgv_rep1.Columns["FechaUltimaFactura"].HeaderText = "Última Factura";
            dgv_rep1.Columns["Local"].HeaderText = "Local";
            dgv_rep1.Columns["Clientes"].HeaderText = "Clientes";
            dgv_rep1.Columns["CantidadFacturas"].HeaderText = "Cant. Facturas";
            dgv_rep1.Columns["ValorTotal"].HeaderText = "Valor Total";
            dgv_rep1.Columns["TotalTickets"].HeaderText = "Total Tickets";

            //Limpiar elementos
            cmb_locrep1.SelectedValue = "";
            //dtp_desdrep1.Value = new DateTime(1999, 01, 01);
            //dtp_hastarep1.Value = new DateTime(1999, 01, 01);

            //Habilitar boton para descargar pdf
            btn_pdfrep1.Enabled = true;
            button1.Enabled = true;
        }

        // Método para agregar una fila de totales al DataGridView
        private void AgregarFilaTotales(DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                // Calcular los totales
                // object numcli = Cls_funciones.LeerRegistrosEnTablaSql("clientes c inner join documentos d on c.codigo_cli = d.codigo_cli_doc ", "count(DISTINCT (c.codigo_cli)) ", "N","");
                //int totalClientes = (int)Convert.ToInt32(numcli);

                int totalClientes = dt.AsEnumerable().Sum(r => r.Field<int>("Clientes"));
                int cantidadFacturas = dt.AsEnumerable().Sum(r => r.Field<int>("CantidadFacturas"));
                double valorTotal = Math.Round(dt.AsEnumerable().Sum(r => r.Field<double>("ValorTotal")), 2);
                int totalTickets = dt.AsEnumerable().Sum(r => r.Field<int>("TotalTickets"));

                // Crear una nueva fila para los totales
                DataRow filaTotales = dt.NewRow();
                filaTotales["Local"] = "Totales ==>";
                filaTotales["Clientes"] = totalClientes;
                filaTotales["CantidadFacturas"] = cantidadFacturas;
                filaTotales["ValorTotal"] = valorTotal;
                filaTotales["TotalTickets"] = totalTickets;

                // Agregar la fila al DataTable
                dt.Rows.Add(filaTotales);

                // Actualizar el DataGridView
                dgv_rep1.DataSource = dt;


                dgv_rep1.RowPrePaint += dgv_rep1_RowPrePaint;
            }
        }
        private void dgv_rep1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int lastRowIndex = dgv_rep1.Rows.Count - 2; // Índice de la última fila
            if (e.RowIndex == lastRowIndex)
            {
                dgv_rep1.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(dgv_rep1.Font, FontStyle.Bold); // Negritas
                dgv_rep1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black; // Color del texto
                dgv_rep1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray; // Fondo opcional
            }
        }
        private void btn_pdfrep1_Click(object sender, EventArgs e)
        {
            // Llamar a la función que genera el PDF desde el DataGridView
            GenerarPDF_DesdeDataGridView(dgv_rep1, "ReporteVentasPorAlmacen.pdf");
        }
        private void GenerarPDF_DesdeDataGridView(DataGridView dgv, string nombreArchivo)
        {
            DateTime fechaDesdeRep1 = Convert.ToDateTime(dtp_desdrep1.Value).Date;
            DateTime fechaHastaRep1 = Convert.ToDateTime(dtp_hastarep1.Value).Date;
            // Crear el archivo PDF
            using (PdfWriter writer = new PdfWriter(nombreArchivo))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document document = new Document(pdf);

                    // Agregar la titulo al documento
                    document.Add(new Paragraph("REPORTE VENTAS POR ALMACEN")
                        .SimulateBold()
                        .SetFontSize(12)
                        .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));

                    // Agregar un subtítulo con las fechas
                    if (fechaDesdeRep1 != new DateTime(1999, 01, 01) && fechaHastaRep1 != new DateTime(1999, 01, 01))
                    {
                        document.Add(new Paragraph($"Desde: {dtp_desdrep1.Value:dd/MM/yyyy}   Hasta: {dtp_hastarep1.Value:dd/MM/yyyy}")
                            .SimulateBold()
                            .SetFontSize(12)
                            .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
                    }


                    // Crear una tabla con el número de columnas del DataGridView
                    Table table = new Table(dgv.Columns.Count);
                    table.SetWidth(UnitValue.CreatePercentValue(100)); // Usar todo el ancho de la página

                    // Establecer ancho de columnas
                    foreach (DataGridViewColumn column in dgv.Columns)
                    {
                        table.AddHeaderCell(new Cell().Add(new Paragraph(column.HeaderText).SimulateBold().SetFontSize(8)));
                    }

                    // Agregar las filas//

                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        DataGridViewRow row = dgv.Rows[i];

                        if (!row.IsNewRow)
                        {
                            for (int j = 0; j < row.Cells.Count; j++)
                            {
                                var cell = row.Cells[j];
                                string cellValue = cell.Value?.ToString() ?? "";

                                // Formatear la columna FechaPrimeraFactura
                                if (dgv.Columns[j].Name == "FechaPrimeraFactura" && DateTime.TryParse(cellValue, out DateTime dateValue))
                                {
                                    cellValue = dateValue.ToString("yyyy-MM-dd");
                                }
                                // Formatear la columna FechaPrimeraFactura
                                else if (dgv.Columns[j].Name == "FechaUltimaFactura" && DateTime.TryParse(cellValue, out dateValue))
                                {
                                    cellValue = dateValue.ToString("yyyy-MM-dd");
                                }

                                // Última fila en negritas
                                if (i == dgv.Rows.Count - 2)
                                {
                                    table.AddCell(new Cell().Add(new Paragraph(cellValue).SimulateBold().SetFontSize(8)));
                                }
                                else
                                {
                                    table.AddCell(new Cell().Add(new Paragraph(cellValue).SetFontSize(8)));
                                }
                            }
                        }
                    }

                    // Agregar la tabla al documento
                    document.Add(table);
                }
            }

            // Abrir el PDF generado
            Process.Start(new ProcessStartInfo(nombreArchivo) { UseShellExecute = true });
        }


        //---------------------------------------------------------------------------------
        //---------Proceso Reporte 2-------------------------------------------------
        private void btn_aceprep2_Click(object sender, EventArgs e)
        {
            DateTime fechaDesdeRep2 = Convert.ToDateTime(dtp_desderep2.Value).Date;
            DateTime fechaHastaRep2 = Convert.ToDateTime(dtp_hastarep2.Value).Date;

            N_Documentos nRep = new N_Documentos();
            DataTable dt_rep2 = nRep.Reporte2Doc(fechaDesdeRep2, fechaHastaRep2);

            dgv_rep2.DataSource = dt_rep2;

            // Calcular los totales
            AgregarFilaTotalesrep2(dt_rep2);

            // Personalizar los encabezados de las columnas en el DataGridView
            dgv_rep2.Columns["FechaPrimeraFactura"].HeaderText = "Primera Factura.";
            dgv_rep2.Columns["FechaUltimaFactura"].HeaderText = "Última Factura";
            dgv_rep2.Columns["Genero"].HeaderText = "Género";
            dgv_rep2.Columns["Clientes"].HeaderText = "Clientes";
            dgv_rep2.Columns["CantidadFacturas"].HeaderText = "Cant. Facturas";
            dgv_rep2.Columns["ValorTotal"].HeaderText = "Valor Total";
            dgv_rep2.Columns["TotalTickets"].HeaderText = "Total Tickets";

            //Habilitar boton para descargar pdf
            btn_pdfrep2.Enabled = true;
        }
        // Método para agregar una fila de totales al DataGridView
        private void AgregarFilaTotalesrep2(DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                // Calcular los totales
                int totalClientes = dt.AsEnumerable().Sum(r => r.Field<int>("Clientes"));
                int cantidadFacturas = dt.AsEnumerable().Sum(r => r.Field<int>("CantidadFacturas"));
                double valorTotal = Math.Round(dt.AsEnumerable().Sum(r => r.Field<double>("ValorTotal")), 2);
                int totalTickets = dt.AsEnumerable().Sum(r => r.Field<int>("TotalTickets"));

                // Crear una nueva fila para los totales
                DataRow filaTotales = dt.NewRow();
                filaTotales["Genero"] = "Totales ==>";
                filaTotales["Clientes"] = totalClientes;
                filaTotales["CantidadFacturas"] = cantidadFacturas;
                filaTotales["ValorTotal"] = valorTotal;
                filaTotales["TotalTickets"] = totalTickets;

                // Agregar la fila al DataTable
                dt.Rows.Add(filaTotales);

                // Actualizar el DataGridView
                dgv_rep2.DataSource = dt;


                dgv_rep2.RowPrePaint += dgv_rep2_RowPrePaint;
            }
        }
        private void dgv_rep2_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int lastRowIndex = dgv_rep2.Rows.Count - 2; // Índice de la última fila
            if (e.RowIndex == lastRowIndex)
            {
                dgv_rep2.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(dgv_rep2.Font, FontStyle.Bold); // Negritas
                dgv_rep2.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black; // Color del texto
                dgv_rep2.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray; // Fondo opcional
            }
        }
        private void btn_pdfrep2_Click(object sender, EventArgs e)
        {
            // Llamar a la función que genera el PDF desde el DataGridView
            GenerarPDF_DataGridViewRep2(dgv_rep2, "ReporteVentasPorGenero.pdf");
        }
        private void GenerarPDF_DataGridViewRep2(DataGridView dgv, string nombreArchivo)
        {
            //Obtener Datos de la base de Datos
            var datos = ObtenerDatosDesdeBase(dgv);
            //Crear grafico
            Chart grafico = CrearGrafico(datos);
            //Guardar la imagen
            string imagenPath = "grafico.png"; //Nombre del grafico 
            grafico.SaveImage(imagenPath, ChartImageFormat.Png); //Ruta donde se genera

            DateTime fechaDesdeRep2 = Convert.ToDateTime(dtp_desderep2.Value).Date;
            DateTime fechaHastaRep2 = Convert.ToDateTime(dtp_hastarep2.Value).Date;

            // Crear el archivo PDF
            using (PdfWriter writer = new PdfWriter(nombreArchivo))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document document = new Document(pdf);

                    // Agregar la titulo al documento
                    document.Add(new Paragraph("REPORTE VENTAS POR GENERO")
                        .SimulateBold()
                        .SetFontSize(12)
                        .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));

                    // Agregar un subtítulo con las fechas
                    if (fechaDesdeRep2 != new DateTime(1999, 01, 01) && fechaHastaRep2 != new DateTime(1999, 01, 01))
                    {
                        document.Add(new Paragraph($"Desde: {dtp_desderep2.Value:dd/MM/yyyy}   Hasta: {dtp_hastarep2.Value:dd/MM/yyyy}")
                            .SimulateBold()
                            .SetFontSize(12)
                            .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
                    }


                    // Crear una tabla con el número de columnas del DataGridView
                    Table table = new Table(dgv.Columns.Count);
                    table.SetWidth(UnitValue.CreatePercentValue(100)); // Usar todo el ancho de la página

                    // Establecer ancho de columnas
                    foreach (DataGridViewColumn column in dgv.Columns)
                    {
                        table.AddHeaderCell(new Cell().Add(new Paragraph(column.HeaderText).SimulateBold().SetFontSize(8)));
                    }

                    // Agregar las filas//

                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        DataGridViewRow row = dgv.Rows[i];

                        if (!row.IsNewRow)
                        {
                            for (int j = 0; j < row.Cells.Count; j++)
                            {
                                var cell = row.Cells[j];
                                string cellValue = cell.Value?.ToString() ?? "";

                                // Formatear la columna FechaPrimeraFactura
                                if (dgv.Columns[j].Name == "FechaPrimeraFactura" && DateTime.TryParse(cellValue, out DateTime dateValue))
                                {
                                    cellValue = dateValue.ToString("yyyy-MM-dd");
                                }
                                // Formatear la columna FechaPrimeraFactura
                                else if (dgv.Columns[j].Name == "FechaUltimaFactura" && DateTime.TryParse(cellValue, out dateValue))
                                {
                                    cellValue = dateValue.ToString("yyyy-MM-dd");
                                }

                                // Última fila en negritas
                                if (i == dgv.Rows.Count - 2)
                                {
                                    table.AddCell(new Cell().Add(new Paragraph(cellValue).SimulateBold().SetFontSize(8)));
                                }
                                else
                                {
                                    table.AddCell(new Cell().Add(new Paragraph(cellValue).SetFontSize(8)));
                                }
                            }
                        }
                    }

                    // Agregar la tabla al documento
                    document.Add(table);
                    //Titulo del Grafico reporte ventas por genero
                    document.Add(new Paragraph("\nGRAFICO REPORTE VENTAS POR GENERO")
                        .SimulateBold()
                        .SetFontSize(12)
                        .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));


                    // Insertar la imagen del gráfico
                    iText.IO.Image.ImageData imageData = iText.IO.Image.ImageDataFactory.Create(imagenPath);
                    iText.Layout.Element.Image pdfImage = new iText.Layout.Element.Image(imageData);
                    //Formato de la imagen 
                    pdfImage.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                    pdfImage.ScaleToFit(pdf.GetDefaultPageSize().GetWidth() - 40, pdf.GetDefaultPageSize().GetHeight() - 40); //Scala a la hora de imprimir el Pdf

                    document.Add(pdfImage);
                }
            }

            // Abrir el PDF generado
            Process.Start(new ProcessStartInfo(nombreArchivo) { UseShellExecute = true });
        }
        //---------------------------------------------------------------------------
        //---------Proceso Reporte 3-------------------------------------------------
        private void btn_aceprep3_Click(object sender, EventArgs e)
        {
            DateTime fechaDesdeRep3 = Convert.ToDateTime(dtp_desderep3.Value).Date;
            DateTime fechaHastaRep3 = Convert.ToDateTime(dtp_hastarep3.Value).Date;

            N_Documentos nRep = new N_Documentos();
            DataTable dt_rep3 = nRep.Reporte3Doc(fechaDesdeRep3, fechaHastaRep3);

            dgv_rep3.DataSource = dt_rep3;
            // Calcular los totales
            AgregarFilaTotalesrep3(dt_rep3);

            // Preparar los datos para el gráfico de pie (Obtiene todos los datos necesarios y los incorpora dentro del grafico) Es una de las distintas formas de configurarlo
            List<(string RangoEdad, int Clientes)> datos = dt_rep3.AsEnumerable()
                .Where(row => row["RangoEdad"].ToString() != "Totales ==>") // Excluir fila de totales
                .Select(row => (row.Field<string>("RangoEdad"), row.Field<int>("Clientes")))
                .ToList();

            // Generar el gráfico de pie
            Chart graficoPie = CrearGraficoPie(datos);

            // Configurar la posición del gráfico debajo de la tabla
            graficoPie.Left = dgv_rep3.Left;
            graficoPie.Top = dgv_rep3.Bottom + 10;

            // Eliminar gráficos anteriores si los hubiera
            var controlesPrevios = this.Controls.OfType<Chart>().ToList();
            foreach (var chart in controlesPrevios)
            {
                this.Controls.Remove(chart);
            }

            // Agregar el gráfico al formulario
            this.Controls.Add(graficoPie);


            // Personalizar los encabezados de las columnas en el DataGridView
            dgv_rep3.Columns["FechaPrimeraFactura"].HeaderText = "Primera Factura";
            dgv_rep3.Columns["FechaUltimaFactura"].HeaderText = "Última Factura";
            dgv_rep3.Columns["RangoEdad"].HeaderText = "Rango Edad";
            dgv_rep3.Columns["Clientes"].HeaderText = "Clientes";
            dgv_rep3.Columns["CantidadFacturas"].HeaderText = "Cant. Facturas";
            dgv_rep3.Columns["ValorTotal"].HeaderText = "Valor Total";
            dgv_rep3.Columns["TotalTickets"].HeaderText = "Total Tickets";


            //Habilitar boton para descargar pdf
            btn_pdfrep3.Enabled = true;
        }
        // Método para agregar una fila de totales al DataGridView
        private void AgregarFilaTotalesrep3(DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                // Calcular los totales
                int totalClientes = dt.AsEnumerable().Sum(r => r.Field<int>("Clientes"));
                int cantidadFacturas = dt.AsEnumerable().Sum(r => r.Field<int>("CantidadFacturas"));
                double valorTotal = Math.Round(dt.AsEnumerable().Sum(r => r.Field<double>("ValorTotal")), 2);
                int totalTickets = dt.AsEnumerable().Sum(r => r.Field<int>("TotalTickets"));

                // Crear una nueva fila para los totales
                DataRow filaTotales = dt.NewRow();
                filaTotales["RangoEdad"] = "Totales ==>";
                filaTotales["Clientes"] = totalClientes;
                filaTotales["CantidadFacturas"] = cantidadFacturas;
                filaTotales["ValorTotal"] = valorTotal;
                filaTotales["TotalTickets"] = totalTickets;

                // Agregar la fila al DataTable
                dt.Rows.Add(filaTotales);

                // Actualizar el DataGridView
                dgv_rep3.DataSource = dt;


                dgv_rep3.RowPrePaint += dgv_rep3_RowPrePaint;
            }
        }
        private void dgv_rep3_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int lastRowIndex = dgv_rep3.Rows.Count - 2; // Índice de la última fila
            if (e.RowIndex == lastRowIndex)
            {
                dgv_rep3.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(dgv_rep3.Font, FontStyle.Bold); // Negritas
                dgv_rep3.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black; // Color del texto
                dgv_rep3.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray; // Fondo opcional
            }
        }
        private void btn_pdfrep3_Click(object sender, EventArgs e)
        {
            // Llamar a la función que genera el PDF desde el DataGridView
            GenerarPDF_DataGridViewRep3(dgv_rep3, "ReporteVentasPorEdad.pdf");
        }
        private void GenerarPDF_DataGridViewRep3(DataGridView dgv, string nombreArchivo)
        {
            //Obtener Datos de la base de Datos
            var datos = ObtenerDatosDesdeBaseEdad(dgv);
            //Crear grafico
            Chart grafico = CrearGraficoPie(datos);
            //Guardar la imagen
            string imagenPath = "graficopie.png";//Nombre del Archivo
            grafico.SaveImage(imagenPath, ChartImageFormat.Png); //Ruta del Archivo

            DateTime fechaDesdeRep3 = Convert.ToDateTime(dtp_desderep3.Value).Date;
            DateTime fechaHastaRep3 = Convert.ToDateTime(dtp_hastarep3.Value).Date;
            // Crear el archivo PDF
            using (PdfWriter writer = new PdfWriter(nombreArchivo))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document document = new Document(pdf);

                    // Agregar la titulo al documento
                    document.Add(new Paragraph("REPORTE VENTAS POR EDAD")
                        .SimulateBold()
                        .SetFontSize(12)
                        .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));

                    // Agregar un subtítulo con las fechas
                    if (fechaDesdeRep3 != new DateTime(1999, 01, 01) && fechaHastaRep3 != new DateTime(1999, 01, 01))
                    {
                        document.Add(new Paragraph($"Desde: {dtp_desderep3.Value:dd/MM/yyyy}   Hasta: {dtp_hastarep3.Value:dd/MM/yyyy}")
                            .SimulateBold()
                            .SetFontSize(12)
                            .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
                    }


                    // Crear una tabla con el número de columnas del DataGridView
                    Table table = new Table(dgv.Columns.Count);
                    table.SetWidth(UnitValue.CreatePercentValue(100)); // Usar todo el ancho de la página

                    // Establecer ancho de columnas
                    foreach (DataGridViewColumn column in dgv.Columns)
                    {
                        table.AddHeaderCell(new Cell().Add(new Paragraph(column.HeaderText).SimulateBold().SetFontSize(8)));
                    }

                    // Agregar las filas//

                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        DataGridViewRow row = dgv.Rows[i];

                        if (!row.IsNewRow)
                        {
                            for (int j = 0; j < row.Cells.Count; j++)
                            {
                                var cell = row.Cells[j];
                                string cellValue = cell.Value?.ToString() ?? "";

                                // Formatear la columna FechaPrimeraFactura
                                if (dgv.Columns[j].Name == "FechaPrimeraFactura" && DateTime.TryParse(cellValue, out DateTime dateValue))
                                {
                                    cellValue = dateValue.ToString("yyyy-MM-dd");
                                }
                                // Formatear la columna FechaPrimeraFactura
                                else if (dgv.Columns[j].Name == "FechaUltimaFactura" && DateTime.TryParse(cellValue, out dateValue))
                                {
                                    cellValue = dateValue.ToString("yyyy-MM-dd");
                                }

                                // Última fila en negritas
                                if (i == dgv.Rows.Count - 2)
                                {
                                    table.AddCell(new Cell().Add(new Paragraph(cellValue).SimulateBold().SetFontSize(8)));
                                }
                                else
                                {
                                    table.AddCell(new Cell().Add(new Paragraph(cellValue).SetFontSize(8)));
                                }
                            }
                        }
                    }

                    // Agregar la tabla al documento
                    document.Add(table);

                    //Agregar el Titulo de Grafico reporte ventas por edad
                    document.Add(new Paragraph("\nGRAFICO REPORTE VENTAS POR EDAD")
                        .SimulateBold()
                        .SetFontSize(12)
                        .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));

                    //Insertar al Pdf
                    iText.IO.Image.ImageData imageData = iText.IO.Image.ImageDataFactory.Create(imagenPath);
                    iText.Layout.Element.Image pdfImage = new iText.Layout.Element.Image(imageData);

                    //Formato de como se vera en el Pdf
                    pdfImage.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                    pdfImage.ScaleToFit(pdf.GetDefaultPageSize().GetWidth() - 40, pdf.GetDefaultPageSize().GetHeight() / 3);

                    document.Add(pdfImage);



                }
            }

            // Abrir el PDF generado
            Process.Start(new ProcessStartInfo(nombreArchivo) { UseShellExecute = true });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Código existente para llenar el DataGridView
            string repbusloc = cmb_locrep1.SelectedValue != null ? cmb_locrep1.SelectedValue.ToString() : "";
            DateTime fechaDesdeRep1 = Convert.ToDateTime(dtp_desdrep1.Value).Date;
            DateTime fechaHastaRep1 = Convert.ToDateTime(dtp_hastarep1.Value).Date;

            N_Documentos nRep = new N_Documentos();
            DataTable dt_rep1 = nRep.Reporte1Doc(repbusloc, fechaDesdeRep1, fechaHastaRep1);
            dgv_rep1.DataSource = dt_rep1;

            // Agregar fila de totales
            AgregarFilaTotales(dt_rep1);

            // Mostrar cuadro de diálogo para guardar el archivo Excel
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivos Excel (.xlsx)|.xlsx",
                Title = "Guardar archivo Excel"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportarAExcel(dgv_rep1, saveFileDialog.FileName);
            }
        }
        private void ExportarAExcel(DataGridView gridView, string nombreArchivo)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Reporte");

                    // Formatear encabezados
                    for (int col = 0; col < gridView.Columns.Count; col++)
                    {
                        var cell = worksheet.Cell(1, col + 1);
                        cell.Value = gridView.Columns[col].HeaderText;
                        cell.Style.Font.Bold = true; // Negrita
                        cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center; // Centrar
                        cell.Style.Fill.BackgroundColor = XLColor.LightGray; // Fondo gris claro
                        cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin; // Bordes
                    }

                    // Formatear datos
                    for (int row = 0; row < gridView.Rows.Count; row++)
                    {
                        for (int col = 0; col < gridView.Columns.Count; col++)
                        {
                            var cell = worksheet.Cell(row + 2, col + 1);
                            var cellValue = gridView.Rows[row].Cells[col].Value;

                            // Asignar valor
                            cell.Value = cellValue?.ToString() ?? "";

                            // Detectar formato
                            if (gridView.Columns[col].Name.Contains("Fecha") && DateTime.TryParse(cellValue?.ToString(), out DateTime dateValue))
                            {
                                cell.Value = dateValue;
                                cell.Style.DateFormat.Format = "yyyy-MM-dd"; // Formato de fecha
                            }
                            else if (gridView.Columns[col].Name.Contains("Valor") && double.TryParse(cellValue?.ToString(), out double doubleValue))
                            {
                                cell.Value = doubleValue;
                                cell.Style.NumberFormat.Format = "$#,##0.00"; // Formato de moneda
                            }

                            // Estilo adicional para totales (última fila)
                            if (row == gridView.Rows.Count - 2)
                            {
                                cell.Style.Font.Bold = true;
                                cell.Style.Fill.BackgroundColor = XLColor.LightGray;
                            }
                        }
                    }

                    // Ajustar ancho de columnas automáticamente
                    worksheet.Columns().AdjustToContents();

                    // Guardar archivo
                    workbook.SaveAs(nombreArchivo);
                }

                MessageBox.Show("Archivo Excel creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar a Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //---------------------------------------------------------------------------


    }
}
