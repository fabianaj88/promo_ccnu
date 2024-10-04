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
    }
}
