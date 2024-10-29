using BootstrapBlazor.Components;
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
using System;
using System.Collections.Generic;
using System.Globalization;

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
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            checkBox1.Enabled = true;

            chk_clientes.Enabled = true;
            chk_documentos.Enabled = true;
            chk_promo.Enabled = true;
            chk_reportes.Enabled = true;
            chk_usuarios.Enabled = true;

            limpiar_campos();
            btn_grabar.Enabled = true;
            btn_cancelar.Enabled = true;
            //btn_eliminar.Enabled = false;
            btn_editar.Enabled = false;
            //btn_busca_usu.Enabled = false;

        }
        private void carga_inicial()
        {
            txt_codigo.Enabled = false;
            txt_correo.Enabled = false;
            txt_nombre.Enabled = false;
            txt_clave.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            checkBox1.Enabled = false;

            btn_nuevo.Enabled = true;
            btn_grabar.Enabled = false;
            // btn_eliminar.Enabled = false;
            btn_editar.Enabled = false;
            //  btn_buscar.Enabled = false;

            chk_clientes.Enabled = false;
            chk_documentos.Enabled = false;
            chk_promo.Enabled = false;
            chk_reportes.Enabled = false;
            chk_usuarios.Enabled = false;


        }
        private void limpiar_campos()
        {
            txt_codigo.Text = "";
            txt_correo.Text = "";
            txt_nombre.Text = "";
            txt_clave.Text = "";
            checkBox1.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            chk_clientes.Checked = false;
            chk_documentos.Checked = false;
            chk_promo.Checked = false;
            chk_reportes.Checked = false;
            chk_usuarios.Checked = false;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            //limpiar_campos();
            carga_inicial();
            if (txt_codigo.Enabled == false)
            {

                busca_usuario(txt_codigo.Text);
            }


        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "")
            {
                MessageBox.Show("Ingrese código del usuario .");
                return;
            }
            if (txt_nombre.Text == "")
            {
                MessageBox.Show("Ingrese nombre del usuario .");
                return;
            }
            if (txt_clave.Text == "")
            {
                MessageBox.Show("Ingrese clave de usuario .");
                return;
            }
            var result = MessageBox.Show("¿Estás seguro de grabar los datos del usuario?",
                                    "Confirmación",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
            if (result == DialogResult)
            {
                return;
            }
            else
            {
                grabar_datos_usuarios();
            }

        }
        private void grabar_datos_usuarios()
        {
            if (txt_codigo.Enabled == false)
            {
                Cls_funciones.Elimina_Datos_DB("Usuarios", "codigo_usu='" + txt_codigo.Text + "'");
            }


            DataTable dt_datos = new DataTable();
            string xcondicion_cli = "";
            string xcampos = "";
            xcampos = Cls_funciones.leer_Campos_tabla("usuarios");
            dt_datos = Cls_funciones.Inserta_Datos_tabla_tmp("usuarios", "codigo_usu", "C");
            if (dt_datos.Rows.Count == 1)
            {
                dt_datos.Rows[0]["codigo_usu"] = txt_codigo.Text;
                dt_datos.Rows[0]["nombre_usu"] = txt_nombre.Text;
                dt_datos.Rows[0]["clave_usu"] = txt_clave.Text;
                dt_datos.Rows[0]["email_usu"] = txt_correo.Text;
                if (radioButton1.Checked == true)
                {
                    dt_datos.Rows[0]["tipo_usu"] = 1;
                }
                else
                {
                    dt_datos.Rows[0]["tipo_usu"] = 2;
                }
                dt_datos.Rows[0]["estado_usu"] = checkBox1.Checked;
                dt_datos.Rows[0]["menu_usu"] = chk_usuarios.Checked;
                dt_datos.Rows[0]["menu_doc"] = chk_documentos.Checked;
                dt_datos.Rows[0]["menu_loc"] = chk_promo.Checked;
                dt_datos.Rows[0]["menu_cli"] = chk_clientes.Checked;
                dt_datos.Rows[0]["menu_pro"] = chk_promo.Checked;
                dt_datos.Rows[0]["menu_rep"] = chk_reportes.Checked;


                xcondicion_cli = Cls_funciones.Condicion_grabar(dt_datos, false);
                if (Cls_funciones.Grabar_Datos_DB("usuarios", xcampos, xcondicion_cli) == true)
                {
                    carga_inicial();
                    MessageBox.Show("Datos procesados con exito..");
                }
                else
                {
                    MessageBox.Show("Existe error en los datos..");
                }
            }

        }

        private void btn_busca_usu_Click(object sender, EventArgs e)
        {
            string xsentencia = "";
            DataTable dt_clientes = new DataTable();
            if (txt_dato_buscar.Text == "")
            {
                xsentencia = "select codigo_usu as Codigo,nombre_usu as Nombre,tipo_usu as Tipo,email_usu as Email,estado_usu as Estado,menu_usu as Usuarios,menu_doc as Documentos,menu_loc as Locales,menu_cli as Clientes from usuarios order by nombre_usu";
            }
            else
            {
                xsentencia = "select codigo_usu as Codigo,nombre_usu as Nombre,tipo_usu as Tipo,email_usu as Email,estado_usu as Estado,menu_usu as Usuarios,menu_doc as Documentos,menu_loc as Locales,menu_cli as Clientes from usuarios where codigo_usu like '%" + txt_dato_buscar.Text + "%' or nombre_usu like '%" + txt_dato_buscar.Text + "%' order by nombre_usu";
                //xsentencia = "select codigo_cli as Codigo,nombre_cli as Nombre,direccion_cli as Direccion,telefono_cli as Telefono,fecha_nac_cli as Nacimiento,genero_cli as Genero from clientes where codigo_like'%" + txt_dato_buscar.Text + "%' or nombre_cli like'%" + txt_dato_buscar.Text + "%'";
            }
            dt_clientes = Cls_funciones.VisualizaS(xsentencia);
            grid_lista_usuarios.DataSource = dt_clientes;
        }

        private void grid_lista_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // MessageBox.Show(e.RowIndex); ;
            if (e.RowIndex >= 0) // Ignorar la cabecera
            {
                // Selecciona la fila
                grid_lista_usuarios.Rows[e.RowIndex].Selected = true;

                // Si quieres hacer algo con la fila seleccionada
                var selectedRow = grid_lista_usuarios.Rows[e.RowIndex];
                // Ejemplo: obtener un valor de la primera columna
                var value = selectedRow.Cells[1].ToString();
                // MessageBox.Show($"Has seleccionado: {value}");
                string nombre = grid_lista_usuarios.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();

                // Muestra el valor en un mensaje
                //MessageBox.Show($"Has seleccionado el nombre: {nombre}");
                busca_usuario(nombre);
            }
        }
        private void busca_usuario(String dato)
        {
            DataTable dt_datos = new DataTable();
            string xsentencia_usu = "select * from usuarios where codigo_usu='" + dato.Trim() + "' ";
            dt_datos = Cls_funciones.VisualizaS(xsentencia_usu);
            if (dt_datos.Rows.Count > 0)
            {
                // int u = 0;
                for (int u = 0; u < dt_datos.Rows.Count; u++)
                {
                    txt_codigo.Text = dt_datos.Rows[u]["codigo_usu"].ToString();
                    txt_nombre.Text = dt_datos.Rows[u]["nombre_usu"].ToString();
                    txt_clave.Text = dt_datos.Rows[u]["clave_usu"].ToString();
                    txt_correo.Text = dt_datos.Rows[u]["email_usu"].ToString();
                    if (dt_datos.Rows[u]["tipo_usu"].ToString() == "1")
                    {
                        radioButton1.Checked = true;
                        radioButton2.Checked = false;
                    }
                    else
                    {
                        radioButton1.Checked = false;
                        radioButton2.Checked = true;
                    }
                    checkBox1.Checked = Convert.ToBoolean(dt_datos.Rows[u]["estado_usu"]);
                    chk_usuarios.Checked = Convert.ToBoolean(dt_datos.Rows[u]["menu_usu"]);
                    chk_clientes.Checked = Convert.ToBoolean(dt_datos.Rows[u]["menu_cli"]);
                    chk_documentos.Checked = Convert.ToBoolean(dt_datos.Rows[u]["menu_doc"]);
                    chk_promo.Checked = Convert.ToBoolean(dt_datos.Rows[u]["menu_pro"]);
                    chk_reportes.Checked = Convert.ToBoolean(dt_datos.Rows[u]["menu_rep"]);
                    //chk.Checked = Convert.ToBoolean(dt_datos.Rows[u]["menu_rep"]);

                }
                btn_editar.Enabled = true;
                //btn_eliminar.Enabled = true;

                page_datos.SelectedTab = page_datos.TabPages[0];

            }

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            txt_codigo.Enabled = false;
            txt_correo.Enabled = true;
            txt_nombre.Enabled = true;
            txt_clave.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            checkBox1.Enabled = true;

            chk_clientes.Enabled = true;
            chk_documentos.Enabled = true;
            chk_promo.Enabled = true;
            chk_reportes.Enabled = true;
            chk_usuarios.Enabled = true;

            btn_grabar.Enabled = true;
            btn_cancelar.Enabled = true;
            // btn_eliminar.Enabled = false;
            btn_nuevo.Enabled = false;


        }
    }
}
