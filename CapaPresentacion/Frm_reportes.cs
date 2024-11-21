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

namespace CapaPresentacion
{
    public partial class Frm_reportes : Form
    {
        private N_Documentos ndocu = new N_Documentos();
        public Frm_reportes()
        {
            InitializeComponent();
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

            //Limpiar elementos
            cmb_locrep1.SelectedValue = "";
            //dtp_desdrep1.Value = new DateTime(1999, 01, 01);
            //dtp_hastarep1.Value = new DateTime(1999, 01, 01);

            //Habilitar boton para descargar pdf
            btn_pdfrep1.Enabled = true;
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

            ////Limpiar elementos
            //cmb_locrep1.SelectedValue = "";
            //dtp_desdrep1.Value = new DateTime(1999, 01, 01);
            //dtp_hastarep1.Value = new DateTime(1999, 01, 01);

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
                int totalTickets = dt.AsEnumerable().Sum(r => r.Field<int>("TotalTickets"));

                // Crear una nueva fila para los totales
                DataRow filaTotales = dt.NewRow();
                filaTotales["Genero"] = "Totales ==>";
                filaTotales["Clientes"] = totalClientes;
                filaTotales["CantidadFacturas"] = cantidadFacturas;
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

            ////Limpiar elementos
            //cmb_locrep1.SelectedValue = "";
            //dtp_desdrep1.Value = new DateTime(1999, 01, 01);
            //dtp_hastarep1.Value = new DateTime(1999, 01, 01);

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
                int totalTickets = dt.AsEnumerable().Sum(r => r.Field<int>("TotalTickets"));

                // Crear una nueva fila para los totales
                DataRow filaTotales = dt.NewRow();
                filaTotales["RangoEdad"] = "Totales ==>";
                filaTotales["Clientes"] = totalClientes;
                filaTotales["CantidadFacturas"] = cantidadFacturas;
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
                }
            }

            // Abrir el PDF generado
            Process.Start(new ProcessStartInfo(nombreArchivo) { UseShellExecute = true });
        }




        //---------------------------------------------------------------------------


    }
}
