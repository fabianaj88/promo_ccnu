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
            if (txt_nomcli.Text == "")
            {
                MessageBox.Show("Ingrese un cliente válido.");
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
            (float nuevoSaldo, List<E_RegistroDoc> registros, bool limiteAlcanzado) = N_RegistroDoc.ProcesarSaldoCliente(coddoc, codigoCliente, totalFactura, montpro);

            // Si el límite se alcanzó, mostrar el mensaje
            if (limiteAlcanzado)
            {
                LimpiarGenTicket();
                MessageBox.Show("El cliente ha alcanzado el límite de tickets para esta promoción. No se generarán más tickets.", "Límite alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Salir para no seguir procesando tickets
            }

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

            //MessageBox.Show("Grabar e imprimir tickets");


            // Crear un objeto de la entidad Documento
            E_Documentos documento = new E_Documentos
            {
                codigo_doc = int.Parse(txt_num.Text),
                numfac_doc = txt_numf.Text,
                codigo_loc_doc = cmb_loc.SelectedValue.ToString(),
                codigo_cli_doc = txt_cli.Text,
                fecfac_doc = dtim_fec.Value,
                valfac_doc = float.Parse(txt_tot.Text),
                //obv_doc = txt_obv.Text // Opcional
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
                            MessageBox.Show("Tickets generados con éxito.");
                            LimpiarGenTicket();
                        }
                        else
                        {
                            MessageBox.Show("Error al generar tickets.");
                        }
                    }
                    else
                    {
                        //Actualizar saldo del cliente
                        Cls_funciones.ModificaS("clientes", "saldo_cli =" + saldocliente + "", "codigo_cli ='" + codigoCliente + "'");

                        MessageBox.Show("Tickets generados con éxito.");
                        LimpiarGenTicket();
                    }


                }
                else
                {
                    MessageBox.Show("Error al generar tickets.");
                }
            }
            else
            {
                MessageBox.Show("Genere los tickets para grabar.");
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
            object codcli = Cls_funciones.LeerRegistrosEnTablaSql("clientes", "CONCAT(LTRIM(RTRIM(nombre_cli)),' ', LTRIM(RTRIM(apellido_cli)))", "C", "codigo_cli='" + codigoCliente + "'");
            txt_nomcli.Text = codcli.ToString();

        }

        private void btn_nuevoDoc_Click(object sender, EventArgs e)
        {
            NuevoGenTicket();
        }

        private void txt_numf_TextChanged(object sender, EventArgs e)
        {
            // Elimina los guiones del texto ingresado
            string input = txt_numf.Text.Replace("-", "");

            // Controla que no exceda los 17 caracteres numéricos (sin guiones)
            if (input.Length > 15)
                input = input.Substring(0, 15);

            // Agrega los guiones según el número de caracteres ingresados
            if (input.Length <= 3)
            {
                txt_numf.Text = input;
            }
            else if (input.Length > 3 && input.Length <= 6)
            {
                txt_numf.Text = input.Substring(0, 3) + "-" + input.Substring(3);
            }
            else if (input.Length > 6)
            {
                txt_numf.Text = input.Substring(0, 3) + "-" + input.Substring(3, 3) + "-" + input.Substring(6);
            }

            // Posiciona el cursor al final del texto
            txt_numf.SelectionStart = txt_numf.Text.Length;
        }

        private void txt_numf_Leave(object sender, EventArgs e)
        {
            // Elimina los guiones para procesar el texto completo
            string input = txt_numf.Text.Replace("-", "");

            if (input.Length > 6 && input.Length <= 15)
            {
                // Completamos solo los últimos 9 dígitos con ceros a la izquierda si el usuario no ingresó todos los números
                string lastPart = input.Substring(6).PadLeft(9, '0'); // Llena con ceros a la izquierda
                input = input.Substring(0, 6) + lastPart; // Reconstruye la cadena completa
            }

            // Reconstruimos el formato con los guiones
            if (input.Length > 6)
            {
                txt_numf.Text = input.Substring(0, 3) + "-" + input.Substring(3, 3) + "-" + input.Substring(6);
            }

            // Posiciona el cursor al final del texto
            txt_numf.SelectionStart = txt_numf.Text.Length;

            dtim_fec.Focus();
        }

        private void txt_numf_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y controlar la longitud
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignorar cualquier otra tecla que no sea número o retroceso
            }
        }

        private void txt_tot_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Ejecutar la lógica del botón 'Generar Ticket' al presionar Enter
                btn_gentik_Click(sender, e);
            }
        }

        private void cmb_loc_Leave(object sender, EventArgs e)
        {
            txt_cli.Focus();

        }

        private void txt_cli_Leave(object sender, EventArgs e)
        {
            if (txt_nomcli.Text == "")
            {
                Frm_CrearCliente frm = new Frm_CrearCliente();

                // Mostrar el formulario de cliente como modal
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Después de cerrar el formulario modal, puedes acceder al cliente creado
                    E_Clientes cliente = frm.ClienteCreado;
                    string codigoCliente = txt_cli.Text;
                    object codcli = Cls_funciones.LeerRegistrosEnTablaSql("clientes", "CONCAT(LTRIM(RTRIM(nombre_cli)),' ', LTRIM(RTRIM(apellido_cli)))", "C", "codigo_cli='" + codigoCliente + "'");
                    txt_nomcli.Text = codcli.ToString();
                    //MessageBox.Show("Cliente agregado.");
                }

            }
            //txt_numf.Focus();

        }

        private void dtim_fec_Leave(object sender, EventArgs e)
        {
            txt_tot.Focus();
        }

        private void txt_nomcli_Leave(object sender, EventArgs e)
        {
            txt_numf.Focus();
        }

        private void btn_busTick_Click(object sender, EventArgs e)
        {
            string busqueda = txt_busTick.Text;
            N_Documentos negocioDocumentos = new N_Documentos();
            DataTable dt_registro = negocioDocumentos.BuscarDocumentos(busqueda);
            dtg_lisDoc.DataSource = dt_registro;
        }

        private void dtg_lisDoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            N_Documentos negocioDocumentos = new N_Documentos();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dtg_lisDoc.Rows[e.RowIndex];

                // Llenar los controles TextBox
                txt_num.Text = filaSeleccionada.Cells["Codigo"].Value.ToString();
                txt_numf.Text = filaSeleccionada.Cells["Factura"].Value.ToString();
                cmb_loc.Text = filaSeleccionada.Cells["Local"].Value.ToString();
                txt_nomcli.Text = filaSeleccionada.Cells["nombre_cli"].Value.ToString();
                dtim_fec.Value = Convert.ToDateTime(filaSeleccionada.Cells["fecfac_doc"].Value);
                txt_tot.Text = filaSeleccionada.Cells["valfac_doc"].Value.ToString();

                // Llenar el segundo DataGridView
                string codigoDoc = filaSeleccionada.Cells["Codigo"].Value.ToString();
                DataTable dt_registroDoc = negocioDocumentos.ObtenerRegistrosPorDocumento(codigoDoc);
                dgvRegisDoc.DataSource = dt_registroDoc;

                // Redirigir al primer TabPage
                tabControl1.SelectedTab = tabControl1.TabPages[0];  
            }
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
            txt_tot.Enabled = false;
            //txt_obv.Text = "";
            txt_saldocli.Text = "";
            txt_saldocli.Visible = false;
            lbl_salcli.Visible = false;
            dgvRegisDoc.DataSource = null;
            dgvRegisDoc.Columns.Clear();
        }

        private void NuevoGenTicket()
        {

            txt_num.Enabled = true;
            txt_numf.Enabled = true;
            cmb_loc.Enabled = true;
            txt_cli.Enabled = true;
            txt_nomcli.Enabled = true;
            txt_tot.Enabled = true;
            dtim_fec.Enabled = true;
            //txt_obv.Enabled = true;

        }
    }
}
