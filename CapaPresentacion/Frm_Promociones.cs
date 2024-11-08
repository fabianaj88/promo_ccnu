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
                MessageBox.Show("Ingrese el nombre de la campaña.");
                return;
            }
            if (txt_montpro.Text == "")
            {
                MessageBox.Show("Ingrese el monto de la campaña.");
                return;
            }
            if (txt_limticket.Text == "")
            {
                MessageBox.Show("Ingrese el límite de tickets.");
                return;
            }

            var result = MessageBox.Show("¿Estás seguro de grabar los datos de la campaña?",
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
                    estado_pro = chk_estpro.Checked,
                    monto_pro = float.Parse(txt_montpro.Text),
                    limtick_pro = int.Parse(txt_limticket.Text)

                };


                // Llamar a la capa de negocio para grabar los datos
                N_Promociones promo = new N_Promociones();
                bool exito = promo.GrabarPromociones(promocion);

                if (exito)
                {
                    MessageBox.Show("Campaña grabada con éxito.");
                    LimpiarPromocion();
                }
                else
                {
                    MessageBox.Show("Error al grabar la campaña.");
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
            int cod_pro = 0;

            object res_pro = Cls_funciones.LeerRegistrosEnTablaSql("promociones", "ISNULL(MAX(codigo_pro), 0) + 1", "N", "");
            cod_pro = (int)Convert.ToInt64(res_pro);
            txt_codpro.Text = cod_pro.ToString();

            txt_nompro.Text = "";
            txt_nompro.Enabled = false;
            txt_montpro.Text = "";
            txt_montpro.Enabled = false;
            txt_limticket.Text = "";
            txt_limticket.Enabled = false;
            dtp_fecinipro.Value = fechaActual;
            dtp_fecinipro.Enabled = false;
            dtp_fecfinpro.Value = fechaActual;
            dtp_fecfinpro.Enabled = false;
            chk_estpro.Enabled = false;
            chk_estpro.Checked = true;

            btn_grabpro.Enabled = false;
            btn_nuevopromo.Enabled = true;
            btn_edipro.Enabled = false;
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
            chk_estpro.Enabled = true;

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

        }

        private void btn_edipro_Click(object sender, EventArgs e)
        {
            EditarPromo();
        }

        private void EditarPromo()
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

            bool respro = Cls_funciones.ModificaS("promociones", "nombre_pro ='" + txt_nompro.Text + "', fec_ini_pro ='" + dtp_fecinipro.Value + "', fec_fin_pro ='" + dtp_fecfinpro.Value + "', estado_pro ='" + chk_estpro.Checked + "', monto_pro =" + txt_montpro.Text + ", limtick_pro = " + txt_limticket.Text + "", "codigo_pro ='" + txt_codpro.Text + "'");

            if (respro)
            {
                MessageBox.Show("Campaña editada con éxito.");
                LimpiarPromocion();
            }
            else
            {
                MessageBox.Show("Error al editar la campaña.");

            }
        }

        private void txt_montpro_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos, una coma y controlar el retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Anula la entrada si no es un dígito o una coma/punto
            }
            // Si se presiona el punto, lo convierte automáticamente en coma
            if (e.KeyChar == '.')
            {
                e.KeyChar = ','; // Convierte el punto en coma
            }
        }

        private void txt_limticket_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter es un número o una tecla de control (como retroceso)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, cancelar el evento
                e.Handled = true;
            }
        }

        private void txt_limticket_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_montpro_TextChanged(object sender, EventArgs e)
        {
            // Evita múltiples comas en el texto
            int countComas = txt_montpro.Text.Count(c => c == ',');
            if (countComas > 1)
            {
                MessageBox.Show("Solo se permite una coma en el número.");
                txt_montpro.Text = txt_montpro.Text.Remove(txt_montpro.Text.LastIndexOf(',')); // Elimina la última coma ingresada
                txt_montpro.SelectionStart = txt_montpro.Text.Length; // Mueve el cursor al final
            }
        }

        private void txt_nompro_TextChanged(object sender, EventArgs e)
        {
            // Convertir el texto a mayúsculas
            txt_nompro.Text = txt_nompro.Text.ToUpper();

            // Mover el cursor al final del texto para evitar que se quede en una posición anterior
            txt_nompro.SelectionStart = txt_nompro.Text.Length;
        }

        private void dtg_lisPro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //N_Documentos negocioDocumentos = new N_Documentos();
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
                txt_nompro.Enabled = true;
                dtp_fecinipro.Enabled = true;
                dtp_fecfinpro.Enabled = true;
                txt_montpro.Enabled = true;
                txt_limticket.Enabled = true;
                chk_estpro.Enabled = true;

                btn_nuevopromo.Enabled = false;
                btn_grabpro.Enabled = false;
                btn_edipro.Enabled = true;
                btn_cancelarpro.Enabled = true;


                tabControl1.SelectedTab = tabControl1.TabPages[0];
            }
        }

        private void chk_estpro_CheckedChanged(object sender, EventArgs e)
        {
            //EditarEstadoPro();
        }
        private void EditarEstadoPro()
        {
            string xcodpro = txt_codpro.Text;
            //int xcoddoc = int.Parse(txt_num.Text);
            int tipusu = 0;

            string xcodusu = Cls_variables.xcodigo_usu;
            object codadmin = Cls_funciones.LeerRegistrosEnTablaSql("usuarios", "tipo_usu", "N", "codigo_usu='" + xcodusu + "'");
            tipusu = (int)Convert.ToInt64(codadmin);

            if (tipusu == 1)
            {
                Cls_funciones.ModificaS("promociones", "estado_pro ='" + chk_estpro.Checked + "'", "codigo_pro =" + xcodpro + "");
                //LimpiarPromocion();
                MessageBox.Show("Promocion desactivada con éxito.", "Desactivación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                //LimpiarPromocion();
                MessageBox.Show("No tienes permisos para desactivar esta promocion. Solo los administradores pueden desactivar.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }

        private void chk_estpro_Click(object sender, EventArgs e)
        {
            EditarEstadoPro();
        }
    }
}
