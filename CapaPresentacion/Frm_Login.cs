using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
            datos_conexion();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text != "" && txt_usuario.Text != "")
            {
                string xusuario = txt_usuario.Text;
                string xclave = txt_password.Text;
                string xsentencia = "";
                DataTable dt_usu = new DataTable();
                xsentencia = "select * from usuarios where codigo_usu='" + xusuario.Trim() + "' and clave_usu='" + xclave.Trim() + "' ";
                dt_usu = Cls_funciones.VisualizaS(xsentencia);
                if (dt_usu.Rows.Count > 0)
                {
                    Cls_variables.xcodigo_usu = dt_usu.Rows[0]["codigo_usu"].ToString();

                    Frm_Login frm1 = new Frm_Login();
                    frm1.Close();
                    Frm_menu_principal frm2 = new Frm_menu_principal();
                    frm2.Show();

                    // this.Close();
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos");
                }

            }
            else
            {
                MessageBox.Show("Datos Incompletos");
            }



        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }
        private void datos_conexion()
        {
            Cls_variables.servidor_bd = "FABIANA";
            Cls_variables.basedatos = "ccnu";
            Cls_variables.usuario_bd = "sa";
            Cls_variables.clave_bd = "alf";
            Conexion.ConeccionBD();
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
