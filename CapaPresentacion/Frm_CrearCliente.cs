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
        private string xtipdoc = ""; // Campo de clase para almacenar el tipo de documento
        public Frm_CrearCliente(string codigoCliente)
        {
            InitializeComponent();
            txt_codigo.Text = codigoCliente; // Asignar el valor al campo txt_codigo

            // Validar el tipo de documento en función del valor asignado
            VerificarTipoDocumento();

            //Agregar opciones al ComboBox
            //cmb_genero.Items.Add("MASCULINOQ");
            //cmb_genero.Items.Add("FEMENINO");
            //cmb_genero.Items.Add("OTROS");

            // Establecer estilo para solo selección (DropDownList)
            //cmb_genero.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        // Método para verificar el tipo de documento
        private void VerificarTipoDocumento()
        {
            string codigo = txt_codigo.Text;

            // Verifica si es un RUC (13 dígitos numéricos)
            if (codigo.Length == 13 && codigo.All(char.IsDigit))
            {
                xtipdoc = "2";
                //MessageBox.Show("Es un RUC.");
            }
            // Verifica si es una cédula (10 dígitos numéricos)
            else if (codigo.Length == 10 && codigo.All(char.IsDigit))
            {
                xtipdoc = "1";
                //MessageBox.Show("Es una cédula.");
            }
            //// Verifica si puede ser un pasaporte (alfanumérico, 6-10 caracteres)
            //else if (codigo.Length >= 6 && codigo.Length <= 10 && codigo.All(char.IsLetterOrDigit))
            //{
            //    MessageBox.Show("Es un pasaporte.");
            //}
            else
            {
                xtipdoc = "3";
                //MessageBox.Show("Es un pasaporte.");
            }
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
                    tipo_doc_cli = xtipdoc,
                    num_doc_cli = txt_codigo.Text,
                    fecha_nac_cli = dtp_fecnac.Value,
                    genero_cli = cmb_genero.Text,
                    celular_cli = txt_telefono.Text,
                    direccion_cli = txt_direccion.Text,
                    correo_cli = txt_correo.Text,

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

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras y convertirlas a mayúsculas
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == ' ')
            {
                e.KeyChar = char.ToUpper(e.KeyChar); // Convertir a mayúscula
            }
            else
            {
                e.Handled = true; // Bloquear cualquier otro carácter
            }
        }

        private void txt_ape_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras y convertirlas a mayúsculas
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == ' ')
            {
                e.KeyChar = char.ToUpper(e.KeyChar); // Convertir a mayúscula
            }
            else
            {
                e.Handled = true; // Bloquear cualquier otro carácter
            }
        }

        private void txt_correo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Convertir la tecla a minúscula si es una letra
            e.KeyChar = char.ToLower(e.KeyChar);
        }

        private void txt_correo_Validating(object sender, CancelEventArgs e)
        {
            if (!txt_correo.Text.Contains("@"))
            {
                MessageBox.Show("El correo debe contener el símbolo '@'.", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Evita que se pierda el foco del control hasta que el usuario corrija el texto
            }
        }
        // Evento KeyPress para permitir solo números

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado no es un dígito y no es la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquear el carácter
            }
        }

        private void txt_telefono_TextChanged(object sender, EventArgs e)
        {
            // Si el texto es mayor a 10 caracteres, recortarlo
            if (txt_correo.Text.Length > 10)
            {
                txt_telefono.Text = txt_telefono.Text.Substring(0, 10);
                txt_telefono.SelectionStart = txt_telefono.Text.Length; // Mover el cursor al final
            }
        }


    }
}
