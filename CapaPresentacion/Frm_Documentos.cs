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
using Microsoft.Win32;

namespace CapaPresentacion
{
    public partial class Frm_Documentos : Form
    {
        private N_Documentos ndocu = new N_Documentos();
        public Frm_Documentos()
        {
            InitializeComponent();
            int cod_doc = 0;
            int cod_pro = 0;


            object res_doc = Cls_funciones.LeerRegistrosEnTablaSql("documentos", "ISNULL(MAX(codigo_doc), 0) + 1", "N", "");
            cod_doc = (int)Convert.ToInt64(res_doc);
            txt_num.Text = cod_doc.ToString();

            object res_pro = Cls_funciones.LeerRegistrosEnTablaSql("promociones", "nombre_pro", "C", "estado_pro = 1");
            lbl_promo.Text = res_pro.ToString();

            object res_codpro = Cls_funciones.LeerRegistrosEnTablaSql("promociones", "codigo_pro", "N", "estado_pro = 1");
            cod_pro = (int)Convert.ToInt64(res_codpro);
            lbl_codpro.Text = cod_pro.ToString();


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

        private void btn_gentik_Click(object sender, EventArgs e)
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
            float montpro = 0;
            int coddoc = int.Parse(txt_num.Text);
            float totalFactura = float.Parse(txt_tot.Text);
            string codigoCliente = txt_cli.Text;
            object monto_pro = Cls_funciones.LeerRegistrosEnTablaSql("promociones", "monto_pro", "N", "codigo_pro=" + lbl_codpro.Text + "");
            montpro = (float)Convert.ToDouble(monto_pro);

            // Aquí llamas a la capa de negocio para procesar saldo y tickets
            (float nuevoSaldo, List<E_RegistroDoc> registros) = N_RegistroDoc.ProcesarSaldoCliente(coddoc, codigoCliente, totalFactura, montpro);

            // Mostrar el nuevo saldo o saldo restante en el TextBox 'txt_saldocli'
            lbl_salcli.Visible = true;
            txt_saldocli.Visible = true;
            txt_saldocli.Text = nuevoSaldo.ToString("0.00");

            // Mostrar los registros generados en el DataGridView
            dgvRegisDoc.DataSource = registros;
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
                    codigo_doc = int.Parse(txt_num.Text),
                    numfac_doc = int.Parse(txt_numf.Text),
                    codigo_loc_doc = cmb_loc.SelectedValue.ToString(),
                    codigo_cli_doc = txt_cli.Text,
                    fecfac_doc = dtim_fec.Value,
                    valfac_doc = float.Parse(txt_tot.Text),
                    obv_doc = txt_obv.Text // Opcional
                };

                if (dgvRegisDoc.Columns.Count > 0)
                {
                    // Llamar a la capa de negocio para grabar los datos
                    N_Documentos negocio = new N_Documentos();
                    bool exito = negocio.GrabarDocumento(documento);

                    if (exito)
                    {
                        //MessageBox.Show("Documento grabado con éxito.");
                        //Obtener datos para guardar 
                        int coddoc = int.Parse(txt_num.Text);
                        string codigoCliente = txt_cli.Text;
                        float saldocliente = (float)Convert.ToDouble(txt_saldocli.Text);

                        // Obtener los registros actuales que están en el DataGridView
                        List<E_RegistroDoc> regdoc = (List<E_RegistroDoc>)dgvRegisDoc.DataSource;
                        if (regdoc.Count > 0)
                        {
                            // Llamar a la capa de negocios para guardar los registros en la base de datos
                            bool exito_reg = N_RegistroDoc.GrabarRegdoc(regdoc, coddoc, codigoCliente, saldocliente);

                            if (exito_reg)
                            {
                                MessageBox.Show("Documento grabado con éxito.");
                                LimpiarGenTicket();
                            }
                            else
                            {
                                MessageBox.Show("Error al grabar el documento.");
                            }
                        }
                        else
                        {
                            //Actualizar saldo del cliente
                            Cls_funciones.ModificaS("clientes", "saldo_cli =" + saldocliente + "", "codigo_cli ='" + codigoCliente + "'");

                            MessageBox.Show("Documento grabado con éxito.");
                            LimpiarGenTicket();
                        }


                    }
                    else
                    {
                        MessageBox.Show("Error al grabar el documento.");
                    }
                }
                else
                {
                    MessageBox.Show("Genere los tickets para grabar.");
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

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarGenTicket();
        }

        private void txt_cli_TextChanged(object sender, EventArgs e)
        {
            string codigoCliente = txt_cli.Text;
            object codcli = Cls_funciones.LeerRegistrosEnTablaSql("clientes", "Concat(nombre_cli,'',apellido_cli)", "C", "codigo_cli='" + codigoCliente + "'");
            txt_nomcli.Text = codcli.ToString();
        }

        private void LimpiarGenTicket()
        {
            int cod_doc = 0;

            object res_doc = Cls_funciones.LeerRegistrosEnTablaSql("documentos", "ISNULL(MAX(codigo_doc), 0) + 1", "N", "");
            cod_doc = (int)Convert.ToInt64(res_doc);

            txt_num.Text = cod_doc.ToString();
            txt_numf.Text = "";
            cmb_loc.Text = "";
            txt_cli.Text = "";
            txt_tot.Text = "";
            txt_obv.Text = "";
            txt_saldocli.Text = "";
            txt_saldocli.Visible = false;
            lbl_salcli.Visible = false;
            dgvRegisDoc.DataSource = null;
            dgvRegisDoc.Columns.Clear();
        }
    }
}
