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
    public partial class Frm_clientes : Form
    {
        public Frm_clientes()
        {
            InitializeComponent();
            carga_inicial();
        }

        private void Frm_clientes_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            btn_nuevo.Enabled = false;
            btn_editar.Enabled = false;
            btn_buscar.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_grabar.Enabled = true;
            btn_cancelar.Enabled = true;
            //
            txt_codigo.Enabled = true;
            txt_nombre.Enabled = true;
            txt_direccion.Enabled = true;
            txt_direccion.Enabled = true;
            txt_telefono.Enabled = true;
            txt_correo.Enabled = true;
            cmb_genero.Enabled = true;
            //
            txt_codigo.Text = "";
            txt_nombre.Text = "";
            txt_direccion.Text = "";
            txt_direccion.Text = "";
            txt_telefono.Text = "";
            txt_correo.Text = "";
            cmb_genero.Text = "";
        }
        private void carga_inicial()
        {
            btn_nuevo.Enabled = true;
            btn_editar.Enabled = true;
            btn_buscar.Enabled = true;
            btn_eliminar.Enabled = true;
            btn_grabar.Enabled = false;
            btn_cancelar.Enabled = false;
            //
            txt_codigo.Enabled = false;
            txt_nombre.Enabled = false;
            txt_direccion.Enabled = false;
            txt_direccion.Enabled = false;
            txt_telefono.Enabled = false;
            txt_correo.Enabled = false;
            cmb_genero.Enabled = false;


        }
        private void cargar_registros(string xcodigo_cli = "")
        {
            String xsentencia = "";
            DataTable dt_clientes = new DataTable();
            if (xcodigo_cli == "")
            {
                xsentencia = "select top 1 * from clientes order by nombre_cli ";
            }
            else
            {
                xsentencia = "select top 1 * from clientes where codigo_cli='" + xcodigo_cli.Trim() + "'  order by nombre_cli ";
            }

            dt_clientes = Cls_funciones.VisualizaS(xsentencia);
            if (dt_clientes.Rows.Count > 0)
            {

            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "")
            {
                MessageBox.Show("Ingrese código del cliente .");
                return;
            }
            if (txt_nombre.Text == "")
            {
                MessageBox.Show("Ingrese nombre del cliente .");
                return;
            }
            if (cmb_genero.Text == "")
            {
                MessageBox.Show("Ingrese genero del cliente .");
                return;
            }
            var result = MessageBox.Show("¿Estás seguro de grabar los datos del cliente?",
                                    "Confirmación",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                grabar_datos_clientes();
            }


        }
        private void grabar_datos_clientes()
        {

            DataTable dt_datos = new DataTable();
            string xcondicion_cli = "";
            string xcampos = "";
            xcampos = Cls_funciones.leer_Campos_tabla("clientes");
            dt_datos = Cls_funciones.Inserta_Datos_tabla_tmp("clientes", "codigo_cli", "C");
            if (dt_datos.Rows.Count == 1)
            {
                dt_datos.Rows[0]["codigo_cli"] = txt_codigo.Text;
                dt_datos.Rows[0]["nombre_cli"] = txt_nombre.Text;
                dt_datos.Rows[0]["direccion_cli"] = txt_direccion.Text;
                dt_datos.Rows[0]["telefono_cli"] = txt_telefono.Text;
                //dt_datos.Rows[0]["codigo_cli"] = txt_correo.Text;
                dt_datos.Rows[0]["genero_cli"] = cmb_genero.SelectedValue;

                xcondicion_cli = Cls_funciones.Condicion_grabar(dt_datos, false);
                if (Cls_funciones.Grabar_Datos_DB("clientes", xcampos, xcondicion_cli) == true)
                {
                    MessageBox.Show("Datos procesados con exito..");
                }
                else
                {
                    MessageBox.Show("Existe error en los datos..");
                }
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            carga_inicial();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            //panel1_Paint.Visible = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_busca_cli_Click(object sender, EventArgs e)
        {
            string xsentencia = "";
            DataTable dt_clientes = new DataTable();
            if (txt_dato_buscar.Text == "")
            {
                xsentencia = "select codigo_cli as Codigo,nombre_cli as Nombre,direccion_cli as Direccion,telefono_cli as Telefono,fecha_nac_cli as Nacimiento from clientes order by nombre_cli";
            }
            else
            {
                xsentencia = "select codigo_cli as Codigo,nombre_cli as Nombre,direccion_cli as Direccion,telefono_cli as Telefono,fecha_nac_cli as Nacimiento from clientes where codigo_like'%" + txt_dato_buscar.Text + "%' or nombre_cli like'%" + txt_dato_buscar.Text + "%'";
            }
            dt_clientes = Cls_funciones.VisualizaS(xsentencia);
            grid_lista_clientes.DataSource = dt_clientes;




        }

        private void grid_lista_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(grid_lista_clientes.SelectedRows[0];)
            if (grid_lista_clientes.SelectedRows.Count > 0)
            {
                // Obtener la primera fila seleccionada
                DataGridViewRow filaSeleccionada = grid_lista_clientes.SelectedRows[0];

                // Obtener el valor de la columna "codigo_cli"
                string codigoCli = filaSeleccionada.Cells["codigo_cli"].Value.ToString();

                // Mostrar el valor (puedes hacer lo que necesites con él)
                MessageBox.Show("Código Cliente: " + codigoCli);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna fila.");
            }
        }
    }
}
