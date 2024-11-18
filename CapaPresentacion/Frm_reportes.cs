using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
