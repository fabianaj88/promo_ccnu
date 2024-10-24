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
                MessageBox.Show("Ingrese el código del local.");
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
                    ubi_loc = txt_mail_loc.Text,
                    email_loc = txt_mail_loc.Text,
                    telefono_loc = txt_telfloc.Text,
                    copro_escri_loc = txt_coproes.Text,
                    copro_act_loc = txt_coproact.Text,
                    arrend_loc = txt_resloc.Text,

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
            txt_resloc.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
