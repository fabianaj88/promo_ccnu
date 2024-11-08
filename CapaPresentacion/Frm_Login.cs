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
            CargarConfiguracion(); //datos_conexion();
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
                    txt_usuario.Text = "";
                    txt_password.Text = "";

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
        private void btn_close_Click(object sender, EventArgs e)
        {
            txt_claveconf.Text = "";
            pan_clavconf.Enabled = false;
            pan_clavconf.Visible = false;
            pan_conf.Enabled = false;
            pan_conf.Visible = false;
            pan_ini.Enabled = true;
            pan_ini.Visible = true;
        }
        private void txt_claveconf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string clave_conf = "AdminGiga923";

                if (txt_claveconf.Text == clave_conf)
                {
                    txt_claveconf.Text = "";
                    pan_clavconf.Enabled = false;
                    pan_clavconf.Visible = false;
                    pan_conf.Enabled = true;
                    pan_conf.Visible = true;
                    pan_ini.Enabled = false;
                    pan_ini.Visible = false;
                }
                else
                {
                    txt_claveconf.Text = "";

                    MessageBox.Show("Clave Incorrecta");

                    pan_clavconf.Enabled = false;
                    pan_clavconf.Visible = false;
                    pan_conf.Enabled = false;
                    pan_conf.Visible = false;
                    pan_ini.Enabled = true;
                    pan_ini.Visible = true;


                }
            }
        }
        private void btn_conf_Click(object sender, EventArgs e)
        {
            pan_clavconf.Enabled = true;
            pan_clavconf.Visible = true;
            pan_conf.Enabled = false;
            pan_conf.Visible = false;
            pan_ini.Enabled = false;
            pan_ini.Visible = false;

        }
        private void btn_guardarconf_Click(object sender, EventArgs e)
        {
            // Verificar si los TextBox tienen valores ingresados
            if (string.IsNullOrWhiteSpace(txt_serv.Text) || string.IsNullOrWhiteSpace(txt_bd.Text))
            {
                MessageBox.Show("Por favor, ingrese el servidor y la base de datos.");
                return;
            }
            datos_conexion();
            pan_conf.Enabled = false;
            pan_conf.Visible = false;
            pan_ini.Enabled = true;
            pan_ini.Visible = true;

        }
        private void datos_conexion()
        {
            //Cls_variables.servidor_bd = "DESKTOP-QDFSRUE";
            //Cls_variables.basedatos = "ccnu";
            //Cls_variables.usuario_bd = "sa";
            //Cls_variables.clave_bd = "alf";
            //Conexion.ConeccionBD();

            // Asignar los valores de los TextBox a las variables de configuración
            Cls_variables.servidor_bd = txt_serv.Text;
            Cls_variables.basedatos = txt_bd.Text;

            // Asignar otros valores de usuario y contraseña (si son constantes)
            Cls_variables.usuario_bd = "sa";
            Cls_variables.clave_bd = "alf";

            // Llamar al método de conexión
            try
            {
                Conexion.ConeccionBD();
                MessageBox.Show("Conexión guardada y establecida correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al establecer la conexión: " + ex.Message);
            }

            // Opcional: Guardar los valores en un archivo de configuración si deseas persistirlos
            GuardarConfiguracion();

        }

        // Método para guardar la configuración en un archivo o en las propiedades de la aplicación
        private void GuardarConfiguracion()
        {
            // Por ejemplo, puedes guardar en Properties.Settings si estás en un proyecto de Windows Forms:
            Properties.Settings.Default["servidor_bd"] = txt_serv.Text;
            Properties.Settings.Default["basedatos"] = txt_bd.Text;

            Properties.Settings.Default.Save();
        }
        private void btn_canconf_Click(object sender, EventArgs e)
        {
            pan_conf.Enabled = false;
            pan_conf.Visible = false;
            pan_ini.Enabled = true;
            pan_ini.Visible = true;
        }

        private void CargarConfiguracion()
        {
            // Cargar los valores guardados en Properties.Settings y asignarlos a Cls_variables
            Cls_variables.servidor_bd = Properties.Settings.Default["servidor_bd"]?.ToString();
            Cls_variables.basedatos = Properties.Settings.Default["basedatos"]?.ToString();
            // Asignar otros valores de usuario y contraseña (si son constantes)
            Cls_variables.usuario_bd = "sa";
            Cls_variables.clave_bd = "alf";

            // Llamar a la conexión automática si los datos están completos
            if (!string.IsNullOrEmpty(Cls_variables.servidor_bd) &&
                !string.IsNullOrEmpty(Cls_variables.basedatos) &&
                !string.IsNullOrEmpty(Cls_variables.usuario_bd) &&
                !string.IsNullOrEmpty(Cls_variables.clave_bd))
            {
                try
                {
                    Conexion.ConeccionBD();
                    //MessageBox.Show("Conexión establecida automáticamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar automáticamente: " + ex.Message);
                }
            }


        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
