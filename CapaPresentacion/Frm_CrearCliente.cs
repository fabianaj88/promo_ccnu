using CapaDatos;
using CapaEntidades;
using CapaNegocio;
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
    public partial class Frm_CrearCliente : Form
    {
        public Frm_CrearCliente(string codigoCliente)
        {
            InitializeComponent();
            txt_codigo.Text = codigoCliente; // Asignar el valor al campo txt_codigo
        }
        public E_Clientes ClienteCreado { get; set; }  // Propiedad pública para devolver el cliente creado
        private void btn_Acepcli_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "")
            {
                MessageBox.Show("Ingrese el código del cliente.");
                return;
            }
            if (txt_nombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del cliente.");
                return;
            }
            if (txt_ape.Text == "")
            {
                MessageBox.Show("Ingrese el apellido del cliente.");
                return;
            }
            if (txt_direccion.Text == "")
            {
                MessageBox.Show("Ingrese la dirección del cliente.");
                return;
            }
            if (txt_telefono.Text == "")
            {
                MessageBox.Show("Ingrese el número de celular del cliente.");
                return;
            }
            if (txt_correo.Text == "")
            {
                MessageBox.Show("Ingrese el correo del cliente.");
                return;
            }
            if (cmb_genero.Text == "")
            {
                MessageBox.Show("Ingrese el género del cliente.");
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
                // Crear un objeto de la entidad Clientes
                E_Clientes cliente = new E_Clientes
                {
                    codigo_cli = txt_codigo.Text,
                    nombre_cli = txt_nombre.Text,
                    apellido_cli = txt_ape.Text,
                    num_doc_cli = txt_codigo.Text,
                    fecha_nac_cli = dtp_fecnac.Value,
                    genero_cli = cmb_genero.Text,
                    celular_cli = txt_telefono.Text,
                    direccion_cli = txt_direccion.Text,

                };

                // Llamar a la capa de negocio para grabar los datos
                N_Clientes ncli = new N_Clientes();
                bool exito = ncli.GrabarClientes(cliente);

                if (exito)
                {
                    // Asignar el cliente creado a la propiedad ClienteCreado
                    ClienteCreado = cliente;

                    MessageBox.Show("Cliente grabado con éxito.");
                    this.DialogResult = DialogResult.OK;  // Para cerrar el formulario con éxito
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al grabar el cliente.");
                }
            }
        }

        private void btn_cancli_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
