using CapaDatos;
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
    public partial class Frm_menu_principal : Form
    {
        public Frm_menu_principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object xpermiso = "";
            Boolean xpermiso_usu = false;
            xpermiso = Cls_funciones.LeerRegistrosEnTablaSql("usuarios", "menu_cli", "L", "codigo_usu='" + Cls_variables.xcodigo_usu + "'");
            xpermiso_usu = Convert.ToBoolean(xpermiso);
            if (xpermiso_usu == true)
            {
                Frm_clientes frm = new Frm_clientes();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Acceso Denegado");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            object xpermiso = "";
            Boolean xpermiso_usu = false;
            xpermiso = Cls_funciones.LeerRegistrosEnTablaSql("usuarios", "menu_doc", "L", "codigo_usu='" + Cls_variables.xcodigo_usu + "'");
            xpermiso_usu = Convert.ToBoolean(xpermiso);
            if (xpermiso_usu == true)
            {
                Frm_Documentos frm = new Frm_Documentos();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Acceso Denegado");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            object xpermiso = "";
            Boolean xpermiso_usu = false;
            xpermiso = Cls_funciones.LeerRegistrosEnTablaSql("usuarios", "menu_loc", "L", "codigo_usu='" + Cls_variables.xcodigo_usu + "'");
            xpermiso_usu = Convert.ToBoolean(xpermiso);
            if (xpermiso_usu == true)
            {
                Frm_locales frm = new Frm_locales();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Acceso Denegado");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            object xpermiso = "";
            Boolean xpermiso_usu = false;
            xpermiso = Cls_funciones.LeerRegistrosEnTablaSql("usuarios", "menu_pro", "L", "codigo_usu='" + Cls_variables.xcodigo_usu + "'");
            xpermiso_usu = Convert.ToBoolean(xpermiso);
            if (xpermiso_usu == true)
            {
                Frm_Promociones frm = new Frm_Promociones();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Acceso Denegado");
            }
            //Frm_Promociones frm = new Frm_Promociones();

            //frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            object xpermiso = "";
            Boolean xpermiso_usu = false;
            xpermiso = Cls_funciones.LeerRegistrosEnTablaSql("usuarios", "menu_usu", "L", "codigo_usu='" + Cls_variables.xcodigo_usu + "'");
            xpermiso_usu = Convert.ToBoolean(xpermiso);
            if (xpermiso_usu == true)
            {
                Frm_usuarios frm = new Frm_usuarios();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Acceso Denegado");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = true;
        }
    }
}
