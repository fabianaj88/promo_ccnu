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
using CapaNegocio;
using System.Drawing.Text;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class Frm_Documentos : Form
    {
        private N_Documentos ndocu = new N_Documentos();
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
            float totalFactura = float.Parse(txt_tot.Text);
            string codigoCliente = txt_cli.Text;

            // Aquí llamas a la capa de negocio para procesar saldo y tickets
            N_RegistroDoc.GenerarTicket(codigoCliente, totalFactura, 25); // Donde 25 es el valor requerido para generar un ticket

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
            if (cmb_loc.Text == "")
            {
                MessageBox.Show("Ingrese el local.");
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
                // Crear un objeto de la entidad Documento
                E_Documentos documento = new E_Documentos
                {
                    numfac_doc = int.Parse(txt_numf.Text),
                    codigo_loc_doc = cmb_loc.SelectedValue.ToString(),
                    codigo_cli_doc = txt_cli.Text,
                    fecfac_doc = dtim_fec.Value,
                    valfac_doc = float.Parse(txt_tot.Text),
                    //Observacion = txt_obv.Text // Opcional
                };

                // Llamar a la capa de negocio para grabar los datos
                N_Documentos negocio = new N_Documentos();
                bool exito = negocio.GrabarDocumento(documento);

                if (exito)
                {
                    MessageBox.Show("Documento grabado con éxito.");
                }
                else
                {
                    MessageBox.Show("Error al grabar el documento.");
                }
            }
        }


        private void cmb_loc_Click(object sender, EventArgs e)
        {
            LlenarComboBoxLocales();
        }
        private void LlenarComboBoxLocales()
        {
            // Llamar a la capa de negocio para obtener los locales
            DataTable dtLocales = ndocu.ObtenerLocales();

            if (dtLocales.Rows.Count > 0)
            {
                cmb_loc.DataSource = dtLocales;
                cmb_loc.DisplayMember = "nombre_loc";  // Nombre que se mostrará en el ComboBox
                cmb_loc.ValueMember = "codigo_loc";    // Valor asociado 
            }
            else
            {
                MessageBox.Show("No se encontraron locales.");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
