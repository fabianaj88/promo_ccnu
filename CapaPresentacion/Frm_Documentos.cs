using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Frm_Documentos : Form
    {
        public Frm_Documentos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia de la clase Conexion
            Conexion conexion = new Conexion();

            try
            {
                // Abrir la conexión
                SqlConnection con = conexion.AbrirConexion();
                MessageBox.Show("Conexión abierta correctamente.");

                // Realizar aquí las operaciones que necesites con la conexión...
            }
            catch (Exception ex)
            {
                // Manejar cualquier error
                MessageBox.Show("Error al abrir la conexión: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                conexion.CerrarConexion();
                MessageBox.Show("Conexión cerrada.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_numf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_loc_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt_cli_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn_gentik_Click(object sender, EventArgs e)
        {

        }

        private void txt_tot_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_obv_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtim_fec_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_grabarTicket_Click(object sender, EventArgs e)
        {
            if (txt_numf.Text == "")
            {
                MessageBox.Show("Ingrese el número de factura.");
                return;
            }
            if (txt_loc.Text == "")
            {
                MessageBox.Show("Ingrese el código del local.");
                return;
            }
            if (txt_cli.Text == "")
            {
                MessageBox.Show("Ingrese el código del cliente.");
                return;
            }
            if (txt_tot.Text == "")
            {
                MessageBox.Show("Ingrese el valor de la factura.");
                return;
            }

            var result = MessageBox.Show("¿Estás seguro de grabar los datos del documento?",
                                    "Confirmación",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                grabar_datos_documentos();
            }
        }
        private void grabar_datos_documentos()
        {
            DataTable dt_datos = new DataTable();
            string xcondicion_doc = "";
            string xcampos = "";
            xcampos = Cls_funciones.leer_Campos_tabla("documentos");
            dt_datos = Cls_funciones.Inserta_Datos_tabla_tmp("documentos", "numfac_doc", "I");

            if (dt_datos.Rows.Count == 1)
            {
                dt_datos.Rows[0]["numfac_doc"] = int.Parse(txt_numf.Text);
                dt_datos.Rows[0]["codigo_loc_doc"] = txt_loc.Text;
                dt_datos.Rows[0]["codigo_cli_doc"] = txt_cli.Text;
                dt_datos.Rows[0]["fecfac_doc"] = dtim_fec.Value; // Asumiendo que usas DateTimePicker para la fecha
                dt_datos.Rows[0]["valfac_doc"] = float.Parse(txt_tot.Text);
                //dt_datos.Rows[0]["obv_doc"] = txt_obv.Text; // Observación es opcional

                xcondicion_doc = Cls_funciones.Condicion_grabar(dt_datos, false);
                if (Cls_funciones.Grabar_Datos_DB("documentos", xcampos, xcondicion_doc) == true)
                {
                    MessageBox.Show("Documento grabado con éxito.");
                }
                else
                {
                    MessageBox.Show("Error al grabar el documento.");
                }
            }
        }

    }
}
