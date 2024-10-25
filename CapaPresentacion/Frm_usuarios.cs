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
    public partial class Frm_usuarios : Form
    {
        public Frm_usuarios()
        {
            InitializeComponent();
            carga_inicial();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            txt_codigo.Enabled = true;
            txt_correo.Enabled = true;
            txt_nombre.Enabled = true;
            txt_clave.Enabled = true;
            limpiar_campos();

        }
        private void carga_inicial()
        {
            txt_codigo.Enabled = false;
            txt_correo.Enabled = false;
            txt_nombre.Enabled = false;
            txt_clave.Enabled = false;

            btn_nuevo.Enabled = true;
            btn_grabar.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_editar.Enabled = false;
            btn_buscar.Enabled = false;

        }
        private void limpiar_campos ()
        {
            txt_codigo.Text = "";
            txt_correo.Text = "";
            txt_nombre.Text = "";
            txt_clave.Text = "";
        }
    }
}
