using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;
using CapaNegocio;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class P_Documentos : Form
    {
        N_Documentos objetondoc = new N_Documentos();
        public P_Documentos()
        {
            InitializeComponent();
        }



        private void P_Documentos_Load(object sender, EventArgs e)
        {
            MostrarDoc();
        }

        private void MostrarDoc()
        {
            //dataGridView1.DataSource = objetondoc.MostrarDoc();
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
    }
}