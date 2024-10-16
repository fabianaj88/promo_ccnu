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
                //// Crear un objeto de la entidad Documento
                //E_Locales local = new E_Locales
                //{
                //    codigo_loc = txt_codigoloc.Text,
                //    nombre_loc = txt_nomloc.Text,
                //    ubi_loc = txt_mail_loc.Text,
                //    email_loc = txt_mail_loc.Text,
                //    telefono_loc = txt_telfloc.Text,
                //    responsable_loc = txt_resloc.Text,

                //};


                //// Llamar a la capa de negocio para grabar los datos
                //N_Locales negocio = new N_Locales();
                //bool exito = negocio.GrabarLocales(local);

                //if (exito)
                //{
                //    MessageBox.Show("Local grabado con éxito.");
                //    //LimpiarLocal();
                //}
                //else
                //{
                //    MessageBox.Show("Error al grabar el local.");
                //}
            }
        }
    }
}
