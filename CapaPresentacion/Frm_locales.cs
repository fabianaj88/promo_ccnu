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
    public partial class Frm_locales : Form
    {
        public Frm_locales()
        {
            InitializeComponent();
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            if (txt_codigoloc.Text == "")
            {
                MessageBox.Show("Ingrese el código del local..");
                return;
            }
            if (txt_nomloc.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del local.");
                return;
            }
            if (txt_ubiloc.Text == "")
            {
                MessageBox.Show("Ingrese la ubicación del local.");
                return;
            }
            if (txt_resloc.Text == "")
            {
                MessageBox.Show("Ingrese el arrendatario del local.");
                return;
            }

            var result = MessageBox.Show("¿Estás seguro de grabar los datos del local?",
                                    "Confirmación",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                // Crear un objeto de la entidad Documento
                E_Locales local = new E_Locales
                {
                    codigo_loc = txt_codigoloc.Text,
                    nombre_loc = txt_nomloc.Text,
                    ubi_loc = txt_ubiloc.Text,
                    email_loc = txt_mail_loc.Text,
                    telefono_loc = txt_telfloc.Text,
                    copro_escri_loc = txt_coproes.Text,
                    copro_act_loc = txt_coproact.Text,
                    arrend_loc = txt_resloc.Text,
                    estado_loc = chc_actloc.Checked,

                };


                // Llamar a la capa de negocio para grabar los datos
                N_Locales negocio = new N_Locales();
                bool exito = negocio.GrabarLocales(local);

                if (exito)
                {
                    MessageBox.Show("Local grabado con éxito.");
                    LimpiarLocal();
                }
                else
                {
                    MessageBox.Show("Error al grabar el local.");
                }
            }
        }

        private void LimpiarLocal()
        {
            txt_codigoloc.Text = "";
            txt_nomloc.Text = "";
            txt_ubiloc.Text = "";
            txt_mail_loc.Text = "";
            txt_telfloc.Text = "";
            txt_coproes.Text = "";
            txt_coproact.Text = "";
            txt_resloc.Text = "";

            txt_codigoloc.Enabled = false;
            txt_nomloc.Enabled = false;
            txt_ubiloc.Enabled = false;
            txt_mail_loc.Enabled = false;
            txt_telfloc.Enabled = false;
            txt_coproes.Enabled = false;
            txt_coproact.Enabled = false;
            txt_resloc.Enabled = false;
            chc_actloc.Enabled = false;

            btn_nuevo_loc.Enabled = true;
            btn_grabar_loc.Enabled = false;
            btn_editar_loc.Enabled = false;
            btn_eliminar_loc.Enabled = true;
        }



        private void btn_nuevo_loc_Click(object sender, EventArgs e)
        {
            NuevoLocal();
        }
        private void NuevoLocal()
        {
            txt_codigoloc.Enabled = true;
            txt_nomloc.Enabled = true;
            txt_ubiloc.Enabled = true;
            txt_mail_loc.Enabled = true;
            txt_telfloc.Enabled = true;
            txt_coproes.Enabled = true;
            txt_coproact.Enabled = true;
            txt_resloc.Enabled = true;
            chc_actloc.Enabled = true;
            chc_actloc.Checked = true;

            btn_nuevo_loc.Enabled = true;
            btn_grabar_loc.Enabled = true;
            btn_editar_loc.Enabled = false;
            btn_eliminar_loc.Enabled = true;
        }

        private void txt_mail_loc_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Convertir la tecla a minúscula si es una letra
            e.KeyChar = char.ToLower(e.KeyChar);
        }

        private void txt_mail_loc_Validating(object sender, CancelEventArgs e)
        {
            if (!txt_mail_loc.Text.Contains("@"))
            {
                MessageBox.Show("El correo debe contener el símbolo '@'.", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Evita que se pierda el foco del control hasta que el usuario corrija el texto
            }
        }
        private void btn_busca_cli_Click(object sender, EventArgs e)
        {
            //string xsentencia = "";
            //DataTable dt_clientes = new DataTable();
            //if (txt_dato_buscar.Text == "")
            //{
            //    xsentencia = "select codigo_loc as Codigo,nombre_loc as Nombre,ubi_loc as Ubicacion,email_loc as Correo,telefono_loc as Telefono,copro_escri_loc as Copropietario_escritura,copro_act_loc as Copropietario_Actual,arrend_loc as Arrendatario from locales order by nombre_loc";
            //}
            //else
            //{
            //    xsentencia = "select codigo_loc as Codigo,nombre_loc as Nombre,ubi_loc as Ubicacion,email_loc as Correo,telefono_loc as Telefono,copro_escri_loc as Copropietario_escritura,copro_act_loc as Copropietario_Actual,arrend_loc as Arrendatario from locales where codigo_loc like'%" + txt_dato_buscar.Text + "%' or nombre_loc like'%" + txt_dato_buscar.Text + "%' order by nombre_loc";
            //}
            //dt_clientes = Cls_funciones.VisualizaS(xsentencia);
            //grid_lista_locales.DataSource = dt_clientes;
            string busqueda = txt_dato_buscar.Text;
            N_Locales negocioloc = new N_Locales();
            DataTable dt_regloc = negocioloc.BuscarLocales(busqueda);
            grid_lista_locales.DataSource = dt_regloc;
        }
        private void grid_lista_locales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //N_Locales negocioDocumentos = new N_Locales();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = grid_lista_locales.Rows[e.RowIndex];

                // Llenar los controles TextBox
                txt_codigoloc.Text = filaSeleccionada.Cells["Codigo"].Value.ToString();
                txt_nomloc.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                txt_ubiloc.Text = filaSeleccionada.Cells["Ubicacion"].Value.ToString();
                txt_mail_loc.Text = filaSeleccionada.Cells["Correo"].Value.ToString();
                txt_telfloc.Text = filaSeleccionada.Cells["Telefono"].Value.ToString();
                txt_coproes.Text = filaSeleccionada.Cells["Copropietario_escritura"].Value.ToString();
                txt_coproact.Text = filaSeleccionada.Cells["Copropietario_actual"].Value.ToString();
                txt_resloc.Text = filaSeleccionada.Cells["Arrendatario"].Value.ToString();
                chc_actloc.Checked = Convert.ToBoolean(filaSeleccionada.Cells["Activo"].Value);

                // Redirigir al primer TabPage
                txt_codigoloc.Enabled = false;
                txt_nomloc.Enabled = true;
                txt_ubiloc.Enabled = true;
                txt_mail_loc.Enabled = true;
                txt_telfloc.Enabled = true;
                txt_coproes.Enabled = true;
                txt_coproact.Enabled = true;
                txt_resloc.Enabled = true;
                chc_actloc.Enabled = true;

                btn_nuevo_loc.Enabled = false;
                btn_grabar_loc.Enabled = false;
                btn_editar_loc.Enabled = true;
                btn_eliminar_loc.Enabled = true;


                tab_locales.SelectedTab = tab_locales.TabPages[0];
            }
        }

        private void btn_editar_loc_Click(object sender, EventArgs e)
        {
            string xcampos = "";
            int xgraba = 0;
            try
            {
                xcampos = "nombre_loc='" + txt_nomloc.Text + "',ubi_loc='" + txt_ubiloc.Text + "',email_loc='" + txt_mail_loc.Text + "',telefono_loc='" + txt_telfloc.Text + "',copro_escri_loc='" + txt_coproes.Text + "',copro_act_loc='" + txt_coproact.Text + "',arrend_loc='" + txt_resloc.Text + "',estado_loc='" + chc_actloc.Checked + "'";
                Cls_funciones.ModificaS("locales", xcampos, "codigo_loc='" + txt_codigoloc.Text + "'");
                xgraba = 1;
            }
            catch
            {
                xgraba = 0;
            }

            if (xgraba == 1)
            {
                MessageBox.Show("Local editado con éxito.");
                LimpiarLocal();
            }
            else
            {
                MessageBox.Show("Error al editar el local.");
            }
        }

        private void btn_eliminar_loc_Click(object sender, EventArgs e)
        {
            LimpiarLocal();
        }
    }
}
