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
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Diagnostics;
using System.Drawing;

namespace CapaPresentacion
{
    public partial class Frm_reportes : Form
    {
        public Frm_reportes()
        {
            InitializeComponent();
        }

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

        private void btn_acprep1_Click(object sender, EventArgs e)
        {
            // Llamar a la función que genera el PDF del panel
            GenerarPDF_Panel(panel_rep1, "ReportePanel.pdf");
        }

        private void GenerarPDF_Panel(Panel panel, string nombreArchivo)
        {
            // Crear un Bitmap del contenido del panel
            Bitmap bm = new Bitmap(panel.Width, panel.Height);
            panel.DrawToBitmap(bm, new Rectangle(0, 0, panel.Width, panel.Height));

            // Crear el archivo PDF
            using (PdfWriter writer = new PdfWriter(nombreArchivo))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document document = new Document(pdf);

                    // Convertir el Bitmap a una imagen compatible con iText
                    using (var stream = new System.IO.MemoryStream())
                    {
                        bm.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                        iText.IO.Image.ImageData imageData = iText.IO.Image.ImageDataFactory.Create(stream.ToArray());
                        iText.Layout.Element.Image pdfImage = new iText.Layout.Element.Image(imageData);

                        // Escalar la imagen para ajustarla al tamaño de la página PDF
                        pdfImage.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                        pdfImage.ScaleToFit(pdf.GetDefaultPageSize().GetWidth() - 40, pdf.GetDefaultPageSize().GetHeight() - 40);

                        // Agregar la imagen al documento
                        document.Add(pdfImage);
                    }
                }
            }

            // Abrir el PDF generado
            Process.Start(new ProcessStartInfo(nombreArchivo) { UseShellExecute = true });
        }
    }
}
