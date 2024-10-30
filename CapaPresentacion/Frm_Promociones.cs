using CapaDatos;
using CapaEntidades;
using CapaNegocio;
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
    public partial class Frm_Promociones : Form
    {
        public Frm_Promociones()
        {
            InitializeComponent();

            int cod_pro = 0;

            object res_pro = Cls_funciones.LeerRegistrosEnTablaSql("promociones", "ISNULL(MAX(codigo_pro), 0) + 1", "N", "");
            cod_pro = (int)Convert.ToInt64(res_pro);
            txt_codpro.Text = cod_pro.ToString();
        }

        private void btn_grabpro_Click(object sender, EventArgs e)
        {

            if (txt_nompro.Text == "")
            {
                MessageBox.Show("Ingrese el nombre de la promoción.");
                return;
            }
            if (txt_montpro.Text == "")
            {
                MessageBox.Show("Ingrese el monto de la promoción.");
                return;
            }
            if (txt_limticket.Text == "")
            {
                MessageBox.Show("Ingrese el límite de tickets.");
                return;
            }

            var result = MessageBox.Show("¿Estás seguro de grabar los datos de la promoción?",
                                    "Confirmación",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                //// Crear un objeto de la entidad Promociones
                E_Promociones promocion = new E_Promociones
                {
                    codigo_pro = int.Parse(txt_codpro.Text),
                    nombre_pro = txt_nompro.Text,
                    fec_ini_pro = dtp_fecinipro.Value,
                    fec_fin_pro = dtp_fecfinpro.Value,
                    monto_pro = float.Parse(txt_montpro.Text),
                    limtick_pro = int.Parse(txt_limticket.Text)

                };


                // Llamar a la capa de negocio para grabar los datos
                N_Promociones promo = new N_Promociones();
                bool exito = promo.GrabarPromociones(promocion);

                if (exito)
                {
                    MessageBox.Show("Promoción grabada con éxito.");
                    LimpiarPromocion();
                }
                else
                {
                    MessageBox.Show("Error al grabar la promoción.");
                }
            }
        }
        private void btn_cancelarpro_Click(object sender, EventArgs e)
        {
            LimpiarPromocion();
        }
        private void LimpiarPromocion()
        {
            DateTime fechaActual = DateTime.Now;
            //txt_codigoloc.Text = "";
            txt_nompro.Text = "";
            txt_montpro.Text = "";
            txt_limticket.Text = "";
            dtp_fecinipro.Value = fechaActual;
            dtp_fecfinpro.Value = fechaActual;

            btn_grabpro.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {


        }

        private void btn_nuevopromo_Click(object sender, EventArgs e)
        {
            NuevoPromo();
        }

        private void NuevoPromo()
        {

            txt_nompro.Enabled = true;
            dtp_fecinipro.Enabled = true;
            dtp_fecfinpro.Enabled = true;
            txt_montpro.Enabled = true;
            txt_limticket.Enabled = true;

            btn_grabpro.Enabled = true;
            btn_cancelarpro.Enabled = true;

        }

        private void btn_buspro_Click(object sender, EventArgs e)
        {
            string busqueda = txt_buscarpro.Text;
            N_Documentos negocioDocumentos = new N_Documentos();
            DataTable dt_regpro = negocioDocumentos.BuscarPromociones(busqueda);
            dtg_lisPro.DataSource = dt_regpro;
        }

        private void dtg_lisPro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            N_Documentos negocioDocumentos = new N_Documentos();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dtg_lisPro.Rows[e.RowIndex];

                // Llenar los controles TextBox
                txt_codpro.Text = filaSeleccionada.Cells["Codigo"].Value.ToString();
                txt_nompro.Text = filaSeleccionada.Cells["Campaña"].Value.ToString();
                dtp_fecinipro.Value = Convert.ToDateTime(filaSeleccionada.Cells["Fecha_Inicio"].Value);
                dtp_fecfinpro.Value = Convert.ToDateTime(filaSeleccionada.Cells["Fecha_Fin"].Value);
                txt_montpro.Text = filaSeleccionada.Cells["Monto"].Value.ToString();
                txt_limticket.Text = filaSeleccionada.Cells["Limite"].Value.ToString();
                chk_estpro.Checked = Convert.ToBoolean(filaSeleccionada.Cells["Activo"].Value);

                // Redirigir al primer TabPage
                

                tabControl1.SelectedTab = tabControl1.TabPages[0];
            }
        }
    }
}
