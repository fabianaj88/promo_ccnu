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
using System.Drawing.Printing;
using System.Globalization;

namespace CapaPresentacion//
{
    public partial class Frm_Documentos : Form
    {
        private N_Documentos ndocu = new N_Documentos();
        public Frm_Documentos()
        {
            InitializeComponent();
            int cod_doc = 0;

            object res_doc = Cls_funciones.LeerRegistrosEnTablaSql("documentos", "ISNULL(MAX(codigo_doc), 0) + 1", "N", "");
            cod_doc = (int)Convert.ToInt32(res_doc);
            txt_num.Text = cod_doc.ToString();

            //cmb_loc.Focus();
        }


        //--------------LOCALES-----------------------------------------
        private void cmb_loc_Click(object sender, EventArgs e)
        {
            if (cmb_loc.Text == "")
            {
                LlenarComboBoxLocales();
            }


        }
        private void cmb_loc_TextUpdate(object sender, EventArgs e)
        {

        }
        private void cmb_loc_TextChanged(object sender, EventArgs e)
        {

        }
        private void cmb_loc_Leave(object sender, EventArgs e)
        {

            if (cmb_loc.Text != "")
            {
                string textoBusqueda = cmb_loc.Text;
                FiltrarLocales(textoBusqueda);
                //cmb_loc.Focus();
            }
        }
        private void cmb_loc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_cli.Focus();
            }
        }
        private void FiltrarLocales(string textoBusqueda)
        {
            // Almacena el texto ingresado por el usuario
            string textoIngresado = cmb_loc.Text;

            // Llamar a la capa de negocio para obtener los locales filtrados por el texto ingresado
            DataTable dtLocales = ndocu.ObtenerLocalesFiltrados(textoBusqueda);

            if (dtLocales.Rows.Count > 0)
            {

                // Actualizar el DataSource
                cmb_loc.DataSource = dtLocales;
                cmb_loc.DisplayMember = "nombre_loc";
                cmb_loc.ValueMember = "codigo_loc";

                // Actualizar sugerencias para autocompletado
                AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
                foreach (DataRow row in dtLocales.Rows)
                {
                    autoCompleteCollection.Add(row["nombre_loc"].ToString());
                }
                cmb_loc.AutoCompleteCustomSource = autoCompleteCollection;

            }
            else
            {
                // Limpiar el DataSource y sugerencias si no hay coincidencias
                MessageBox.Show("El local no existe.");
                cmb_loc.Text = "";
            }
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
        //---------------------------------------------------------------

        //----------CLIENTES---------------------------------------------
        private void txt_cli_TextChanged(object sender, EventArgs e)
        {
            string codigoCliente = txt_cli.Text;
            object codcli = Cls_funciones.LeerRegistrosEnTablaSql("clientes", "CONCAT(LTRIM(RTRIM(nombre_cli)),' ', LTRIM(RTRIM(apellido_cli)))", "C", "codigo_cli='" + codigoCliente + "'");
            txt_nomcli.Text = codcli.ToString();

        }
        private void txt_cli_Leave(object sender, EventArgs e)
        {
            string codigoCliente = txt_cli.Text;

            // Validaciones para cédula, RUC y pasaporte
            if (codigoCliente != "")
            {
                if (IsValidCedula(codigoCliente))
                {
                    // Número de cédula válido
                    //MessageBox.Show("Cédula válida.");
                }
                else if (IsValidRuc(codigoCliente))
                {
                    // RUC válido
                    //MessageBox.Show("RUC válido.");
                }
                else if (IsValidPassport(codigoCliente))
                {
                    // Pasaporte válido
                    //MessageBox.Show("Pasaporte válido.");
                }
                else
                {

                    MessageBox.Show("El código ingresado no es un número de cédula, RUC o pasaporte válido.", "Código no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_cli.Focus();
                    return; // Termina aquí si la validación no es correcta
                }

                // Si el código es válido, se verifica si el cliente existe
                if (txt_nomcli.Text == "")
                {
                    Frm_CrearCliente frm = new Frm_CrearCliente(codigoCliente);

                    // Mostrar el formulario de cliente como modal
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        // Después de cerrar el formulario modal, puedes acceder al cliente creado
                        E_Clientes cliente = frm.ClienteCreado;

                        object codcli = Cls_funciones.LeerRegistrosEnTablaSql("clientes", "CONCAT(LTRIM(RTRIM(nombre_cli)),' ', LTRIM(RTRIM(apellido_cli)))", "C", "codigo_cli='" + codigoCliente + "'");
                        txt_nomcli.Text = codcli.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese el código del cliente.");
            }
        }


        private void txt_nomcli_Leave(object sender, EventArgs e)
        {
            txt_numf.Focus();
        }
        private void txt_cli_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_nompro.Focus();
            }
        }

        // Método para validar la cédula 
        private bool IsValidCedula(string cedula)
        {
            if (cedula.Length != 10 || !cedula.All(char.IsDigit)) return false;

            int total = 0;
            int[] coefficients = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            for (int i = 0; i < cedula.Length - 1; i++)
            {
                int digit = int.Parse(cedula[i].ToString()) * coefficients[i];
                total += digit > 9 ? digit - 9 : digit;
            }
            int verifierDigit = int.Parse(cedula[cedula.Length - 1].ToString());
            int checkDigit = 10 - (total % 10);
            if (checkDigit == 10) checkDigit = 0;

            return verifierDigit == checkDigit;
        }

        // Método para validar RUC
        private bool IsValidRuc(string ruc)
        {
            return ruc.Length == 13 && ruc.All(char.IsDigit);
        }

        // Método para validar el pasaporte (alfanumérico y longitud de 5)
        private bool IsValidPassport(string passport)
        {
            return passport.Length == 5 && passport.All(char.IsLetterOrDigit);
        }
        //---------------------------------------------------------------

        //------DOCUMENTO------------------------------------------------
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
        private void txt_numf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtim_fec.Focus();
            }

        }

        private void txt_tot_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Ejecutar la lógica del botón 'Generar Ticket' al presionar Enter
                btn_gentik_Click(sender, e);
                //LlenarPanelImp();
            }
        }

        private void txt_tot_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos, una coma y controlar el retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Anula la entrada si no es un dígito o una coma/punto
            }
            // Si se presiona el punto, lo convierte automáticamente en coma
            if (e.KeyChar == '.')
            {
                e.KeyChar = ','; // Convierte el punto en coma
            }
        }

        private void txt_tot_TextChanged(object sender, EventArgs e)
        {
            // Evita múltiples comas en el texto
            int countComas = txt_tot.Text.Count(c => c == ',');
            if (countComas > 1)
            {
                MessageBox.Show("Solo se permite una coma en el número.");
                txt_tot.Text = txt_tot.Text.Remove(txt_tot.Text.LastIndexOf(',')); // Elimina la última coma ingresada
                txt_tot.SelectionStart = txt_tot.Text.Length; // Mueve el cursor al final
            }
        }

        private void dtim_fec_Leave(object sender, EventArgs e)
        {
            txt_tot.Focus();
        }
        private void dtim_fec_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_tot.Focus();
            }
        }
        //-----------------------------------------------------------------

        //------------PROMOCIONES------------------------------------------


        private void cmb_nompro_Click(object sender, EventArgs e)
        {
            LlenarComboBoxPromociones();
            chk_dobleTi.Visible = true;
            pib_dobleT.Visible = true;
        }

        private void LlenarComboBoxPromociones()
        {
            // Llamar a la capa de negocio para obtener los locales
            DataTable dtPromo = ndocu.ObtenerPromociones();
            

            if (dtPromo.Rows.Count > 0)
            {

                cmb_nompro.DataSource = dtPromo;
                cmb_nompro.DisplayMember = "nombre_pro";  // Nombre que se mostrará en el ComboBox
                cmb_nompro.ValueMember = "codigo_pro";    // Valor asociado 

            }
            else
            {
                MessageBox.Show("No se encontraron promociones vigentes.");
            }
        }
        private void cmb_nompro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //DateTime fechaActual = DateTime.Now;
                //MessageBox.Show("fecha actual maquina:" + fechaActual + "");
                txt_numf.Focus();
            }
        }

        //-----------------------------------------------------------------

        //------------PROCEDIMIENTOS---------------------------------------
        private void btn_gentik_Click(object sender, EventArgs e)
        {
            if (ControlVacio())
            {
                string xnumf = txt_numf.Text;
                string xcodloc = cmb_loc.SelectedValue.ToString();
                string xcodcli = txt_cli.Text;
                int codpro = int.Parse(cmb_nompro.SelectedValue.ToString());

                DataTable dtfacloccam = new DataTable();
                string xsentencia = "";
                xsentencia = "select d.codigo_doc, d.numfac_doc, d.codigo_loc_doc, d.codigo_cli_doc, r.codigo_pro from documentos d inner join registro_doc r on d.codigo_doc = r.codigo_doc where d.numfac_doc = '" + xnumf + "' and d.codigo_loc_doc = '" + xcodloc + "' and d.codigo_cli_doc = '" + xcodcli + "' and r.codigo_pro = " + codpro + " group by d.codigo_doc, d.numfac_doc, d.codigo_loc_doc, d.codigo_cli_doc, r.codigo_pro";
                dtfacloccam = Cls_funciones.VisualizaS(xsentencia);
                if (dtfacloccam.Rows.Count == 0)
                {
                    //Cls_variables.xcodigo_usu = dt_usu.Rows[0]["codigo_usu"].ToString();
                    DateTime fechaFactura = dtim_fec.Value.Date;

                    object fecini_pro = Cls_funciones.LeerRegistrosEnTablaSql("promociones", "fec_ini_pro", "D", "codigo_pro=" + codpro + "");
                    object fecfin_pro = Cls_funciones.LeerRegistrosEnTablaSql("promociones", "fec_fin_pro", "D", "codigo_pro=" + codpro + "");

                    // Convertir las fechas obtenidas a Date
                    DateTime fechaInicioPromocion = Convert.ToDateTime(fecini_pro).Date;
                    DateTime fechaFinPromocion = Convert.ToDateTime(fecfin_pro).Date;

                    // Verificar si la fecha de la factura está dentro del rango de la promoción
                    if (fechaFactura >= fechaInicioPromocion && fechaFactura <= fechaFinPromocion)
                    {
                        float montpro = 0;
                        int coddoc = int.Parse(txt_num.Text);
                        float totalFactura = float.Parse(txt_tot.Text);
                        string codigoCliente = txt_cli.Text;

                        bool dobleTic = chk_dobleTi.Checked;

                        object monto_pro = Cls_funciones.LeerRegistrosEnTablaSql("promociones", "monto_pro", "N", "codigo_pro=" + codpro + "");
                        montpro = (float)Convert.ToDouble(monto_pro);

                        // Aquí llamas a la capa de negocio para procesar saldo y tickets
                        (float nuevoSaldo, List<E_RegistroDoc> registros, bool limiteAlcanzado) = N_RegistroDoc.ProcesarSaldoCliente(coddoc, codigoCliente, totalFactura, montpro, codpro, dobleTic);

                        // Si el límite se alcanzó, mostrar el mensaje
                        if (limiteAlcanzado)
                        {
                            LimpiarGenTicket();
                            MessageBox.Show("El cliente ha alcanzado el límite de tickets para esta campaña. No se generarán más tickets.", "Límite alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return; // Salir para no seguir procesando tickets
                        }

                        // Mostrar el nuevo saldo o saldo restante en el TextBox 'txt_saldocli'
                        lbl_salcli.Visible = true;
                        txt_saldocli.Visible = true;
                        txt_saldocli.Text = nuevoSaldo.ToString("0.00");

                        // Mostrar los registros generados en el DataGridView
                        dgvRegisDoc.DataSource = registros;

                        // Personalizar los encabezados de las columnas en el DataGridView
                        dgvRegisDoc.Columns["num_tic"].HeaderText = "Ticket N°";
                        dgvRegisDoc.Columns["codigo_doc"].HeaderText = "Registro N°";
                        dgvRegisDoc.Columns["fecemi_tic"].HeaderText = "Fecha Emisión";
                        dgvRegisDoc.Columns["estado_tic"].HeaderText = "Ticket Impreso";
                        dgvRegisDoc.Columns["codigo_pro"].HeaderText = "Código Campaña";
                    }
                    else
                    {
                        MessageBox.Show("La fecha de la factura no es válida para la campaña.");
                        dgvRegisDoc.DataSource = null;
                        dgvRegisDoc.Columns.Clear();
                    }
                }
                else
                {
                    //LimpiarGenTicket();
                    MessageBox.Show("El número de la factura ya fue registrada para la campaña.");
                }

                LlenarPanelImp();
            }
        }

        private void btn_grabarTicket_Click(object sender, EventArgs e)
        {
            if (ControlVacio())
            {
                string xnumf = txt_numf.Text;
                string xcodloc = cmb_loc.SelectedValue.ToString();
                string xcodcli = txt_cli.Text;
                int codpro = int.Parse(cmb_nompro.SelectedValue.ToString());

                DataTable dtfacloccam = new DataTable();
                string xsentencia = "";
                xsentencia = "select d.codigo_doc, d.numfac_doc, d.codigo_loc_doc, d.codigo_cli_doc, r.codigo_pro from documentos d inner join registro_doc r on d.codigo_doc = r.codigo_doc where d.numfac_doc = '" + xnumf + "' and d.codigo_loc_doc = '" + xcodloc + "' and d.codigo_cli_doc = '" + xcodcli + "' and r.codigo_pro = " + codpro + "and anular_doc = 'False' group by d.codigo_doc, d.numfac_doc, d.codigo_loc_doc, d.codigo_cli_doc, r.codigo_pro";
                dtfacloccam = Cls_funciones.VisualizaS(xsentencia);
                if (dtfacloccam.Rows.Count == 0)
                {
                    //MessageBox.Show("Grabar e imprimir tickets");
                    //int codpro = int.Parse(cmb_nompro.SelectedValue.ToString());
                    DateTime fechaFactura = dtim_fec.Value;

                    object fecini_pro = Cls_funciones.LeerRegistrosEnTablaSql("promociones", "fec_ini_pro", "D", "codigo_pro=" + codpro + "");
                    object fecfin_pro = Cls_funciones.LeerRegistrosEnTablaSql("promociones", "fec_fin_pro", "D", "codigo_pro=" + codpro + "");

                    // Convertir las fechas obtenidas a DateTime
                    DateTime fechaInicioPromocion = Convert.ToDateTime(fecini_pro);
                    DateTime fechaFinPromocion = Convert.ToDateTime(fecfin_pro);

                    // Verificar si la fecha de la factura está dentro del rango de la promoción
                    if (fechaFactura >= fechaInicioPromocion && fechaFactura <= fechaFinPromocion)
                    {
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
                            doble_tick = bool.Parse(chk_dobleTi.Checked.ToString()),
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
                                        // Cambiar a la pestaña de impresión

                                        tabControl1.SelectedTab = tabControl1.TabPages[2];

                                        // Ejecutar la lógica del botón 'Imprimir' al grabar Ticket
                                        btn_impTicket_Click(sender, e);

                                        tabControl1.SelectedTab = tabControl1.TabPages[0];

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
                                    // Convertir el saldo del cliente a una cadena con punto como separador decimal
                                    string saldoClienteFormateado = saldocliente.ToString(CultureInfo.InvariantCulture);

                                    Cls_funciones.ModificaS("clientes", "saldo_cli =" + saldoClienteFormateado + "", "codigo_cli ='" + codigoCliente + "'");

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
                    else
                    {
                        MessageBox.Show("La fecha de la factura no es válida para la promoción.");
                    }
                }
                else
                {
                    //LimpiarGenTicket();
                    MessageBox.Show("El número de la factura ya fue registrada para la promoción.");
                }
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarGenTicket();
            btn_nuevoDoc.Enabled = true;
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
            //txt_tot.Enabled = false;
            //txt_obv.Text = "";
            txt_saldocli.Text = "";
            txt_saldocli.Visible = false;
            lbl_salcli.Visible = false;
            dgvRegisDoc.DataSource = null;
            dgvRegisDoc.Columns.Clear();
            cmb_nompro.Text = "";

            btn_anulartick.Enabled = false;
            chk_dobleTi.Visible = false;
            pib_dobleT.Visible = false;

            txt_num.Enabled = false;
            txt_numf.Enabled = false;
            cmb_loc.Enabled = false;
            txt_cli.Enabled = false;
            txt_nomcli.Enabled = false;
            txt_tot.Enabled = false;
            dtim_fec.Enabled = false;
            cmb_nompro.Enabled = false;
            chk_dobleTi.Enabled = false;

            btn_nuevoDoc.Enabled = true;
            btn_grabarTicket.Enabled = false;
            btn_limpiar.Enabled = false;
            btn_gentik.Enabled = false;
            btn_impdoc.Visible = false;
        }

        private void btn_nuevoDoc_Click(object sender, EventArgs e)
        {
            NuevoGenTicket();
        }
        private void btn_anulartick_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Estás seguro de anular el documento?",
                                    "Confirmación",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                AnularTicket();
            }

        }
        private void AnularTicket()
        {
            string xcoddoc = txt_num.Text;
            string xcodcli = txt_cli.Text;
            int tipusu = 0;
            float xsumval = 0;
            float xval = 0;

            string xcodusu = Cls_variables.xcodigo_usu;
            object codadmin = Cls_funciones.LeerRegistrosEnTablaSql("usuarios", "tipo_usu", "N", "codigo_usu='" + xcodusu + "'");
            tipusu = (int)Convert.ToInt32(codadmin);

            object sumval = Cls_funciones.LeerRegistrosEnTablaSql("documentos", "sum(valfac_doc)", "N", "codigo_cli_doc=" + xcodcli + " and anular_doc = 'False'");
            xsumval = (float)Convert.ToDouble(sumval);
            object val = Cls_funciones.LeerRegistrosEnTablaSql("documentos", "valfac_doc", "N", "codigo_doc=" + xcoddoc + " and anular_doc = 'False'");
            xval = (float)Convert.ToDouble(val);
            float respanusalcli = xsumval - xval;
            respanusalcli = (float)Math.Round(respanusalcli, 2);
            // Convertir el saldo del cliente a una cadena con punto como separador decimal
            string respanusalcliFor = respanusalcli.ToString(CultureInfo.InvariantCulture);

            object docanul = Cls_funciones.LeerRegistrosEnTablaSql("documentos", "anular_doc", "L", "codigo_doc=" + xcoddoc + "");
            bool docanula = (bool)Convert.ToBoolean(docanul);

            if (tipusu == 1)
            {
                if (docanula == false)
                {
                    Cls_funciones.ModificaS("clientes", "saldo_cli =" + respanusalcliFor + "", "codigo_cli ='" + xcodcli + "'");
                    Cls_funciones.ModificaS("documentos", "anular_doc =" + 1 + "", "codigo_doc =" + xcoddoc + "");
                    LimpiarGenTicket();
                    MessageBox.Show("Documento anulado con éxito.", "Anulación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El documento ya esta anulado... No puede volver a anular.");
                }
            }
            else
            {
                LimpiarGenTicket();
                MessageBox.Show("No tienes permisos para anular este documento. Solo los administradores pueden borrar.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }
        private void NuevoGenTicket()
        {
            cmb_loc.Focus();
            txt_num.Enabled = true;
            txt_numf.Enabled = true;
            cmb_loc.Enabled = true;
            txt_cli.Enabled = true;
            txt_nomcli.Enabled = true;
            txt_tot.Enabled = true;
            dtim_fec.Enabled = true;
            cmb_nompro.Enabled = true;
            chk_dobleTi.Enabled = true;

            btn_grabarTicket.Enabled = true;
            btn_limpiar.Enabled = true;
            btn_gentik.Enabled = true;

        }

        private bool ControlVacio()
        {
            if (txt_numf.Text == "")
            {
                MessageBox.Show("Ingrese el número de factura.");
                return false;
            }
            if (cmb_loc.Text == "")
            {
                MessageBox.Show("Ingrese el local.");
                return false;
            }
            if (cmb_nompro.Text == "")
            {
                MessageBox.Show("Seleccione una campaña.");
                return false;
            }
            if (txt_cli.Text == "")
            {
                MessageBox.Show("Ingrese el código del cliente.");
                return false;
            }
            if (txt_nomcli.Text == "")
            {
                MessageBox.Show("Ingrese un cliente válido.");
                return false;
            }
            if (txt_tot.Text == "")
            {
                MessageBox.Show("Ingrese el valor de la factura.");
                return false;
            }

            return true;
        }
        private void chk_dobleTi_CheckedChanged(object sender, EventArgs e)
        {
            dgvRegisDoc.DataSource = null;
            dgvRegisDoc.Columns.Clear();
        }
        //-------------------------------------------------------------------

        //-----------BUSCAR--------------------------------------------------
        private void btn_busTick_Click(object sender, EventArgs e)
        {
            string busqueda = txt_busTick.Text;
            N_Documentos negocioDocumentos = new N_Documentos();
            DataTable dt_registro = negocioDocumentos.BuscarDocumentos(busqueda);
            dtg_lisDoc.DataSource = dt_registro;
        }

        private void dtg_lisDoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            N_Documentos negocioDocumentos = new N_Documentos();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dtg_lisDoc.Rows[e.RowIndex];

                // Llenar los controles TextBox
                txt_num.Text = filaSeleccionada.Cells["Codigo"].Value.ToString();
                txt_numf.Text = filaSeleccionada.Cells["Factura"].Value.ToString();
                cmb_loc.Text = filaSeleccionada.Cells["Local"].Value.ToString();
                txt_cli.Text = filaSeleccionada.Cells["Ced_Ruc_Pas"].Value.ToString();
                txt_nomcli.Text = filaSeleccionada.Cells["Cliente"].Value.ToString();
                dtim_fec.Value = Convert.ToDateTime(filaSeleccionada.Cells["Fecha"].Value);
                txt_tot.Text = filaSeleccionada.Cells["Valor"].Value.ToString();
                chk_dobleTi.Checked = Convert.ToBoolean(filaSeleccionada.Cells["DobleTicket"].Value);

                // Llenar el segundo DataGridView
                string codigoDoc = filaSeleccionada.Cells["Codigo"].Value.ToString();
                DataTable dt_registroDoc = negocioDocumentos.ObtenerRegistrosPorDocumento(codigoDoc);

                //int codigoPro = int.Parse(dt_registroDoc.Rows[0]["codigo_pro"].ToString());
                if (dt_registroDoc.Rows.Count == 0)
                {
                    cmb_nompro.SelectedValue = null;
                    cmb_nompro.Text = "";

                    dgvRegisDoc.DataSource = null;
                }
                else
                {
                    int codigoPro = int.Parse(dt_registroDoc.Rows[0]["codigo_pro"].ToString());
                    object nompro = Cls_funciones.LeerRegistrosEnTablaSql("promociones", "nombre_pro", "C", "codigo_pro=" + codigoPro + "");
                    //cmb_nompro.ValueMember = codigoPro.ToString();
                    cmb_nompro.Text = nompro.ToString();

                    dgvRegisDoc.DataSource = dt_registroDoc;

                    // Personalizar los encabezados de las columnas en el DataGridView
                    dgvRegisDoc.Columns["num_tic"].HeaderText = "Ticket N°";
                    dgvRegisDoc.Columns["codigo_doc"].HeaderText = "Registro N°";
                    dgvRegisDoc.Columns["fecemi_tic"].HeaderText = "Fecha Emisión";
                    dgvRegisDoc.Columns["estado_tic"].HeaderText = "Ticket Impreso";
                    dgvRegisDoc.Columns["codigo_pro"].HeaderText = "Código Campaña";

                    
                }


                // Redirigir al primer TabPage
                txt_num.Enabled = false;
                txt_numf.Enabled = false;
                cmb_loc.Enabled = false;
                txt_cli.Enabled = false;
                txt_nomcli.Enabled = false;
                dtim_fec.Enabled = false;
                txt_tot.Enabled = false;
                cmb_nompro.Enabled = false;
                chk_dobleTi.Visible = true;
                chk_dobleTi.Enabled = false;
                pib_dobleT.Visible = true;
                txt_saldocli.Enabled = false;

                btn_grabarTicket.Enabled = false;
                btn_gentik.Enabled = false;
                btn_limpiar.Enabled = true;
                btn_anulartick.Enabled = true;
                btn_nuevoDoc.Enabled = false;
                btn_impdoc.Visible = true;

                tabControl1.SelectedTab = tabControl1.TabPages[0];
            }
        }

        //--------------------------------------------------------------------

        //----------IMPRIMIR-----------------------------------------------------
        private void ImprimiTicket(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(panel_impTickets.Width, panel_impTickets.Height);
            panel_impTickets.DrawToBitmap(bm, new Rectangle(0, 0, panel_impTickets.Width, panel_impTickets.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void btn_impTicket_Click(object sender, EventArgs e)
        {
            // Recorrer cada fila del DataGridView para generar y mostrar cada ticket
            foreach (DataGridViewRow row in dgvRegisDoc.Rows)
            {
                if (row.Cells["num_Tic"].Value != null) // Asegurarse de que no esté vacío
                {
                    // Obtener el número de ticket de la fila actual
                    string numeroTicket = row.Cells["num_tic"].Value.ToString();

                    // Configurar el Label lblnregdocT con el número de ticket actual
                    lbl_nregdocT.Text = numeroTicket;

                    //---imprimir con vista previa--------------
                    //printPreviewDialog1.Document = printDocument1;
                    //printPreviewDialog1.ShowDialog();
                    //--------------------------------------------

                    // Establecer el documento de impresión
                    printDocument1.PrintPage += new PrintPageEventHandler(ImprimiTicket);

                    // Enviar directamente a la impresora predeterminada sin vista previa
                    printDocument1.Print();
                }
            }
            //printPreviewDialog1.ShowDialog();
        }
        private void btn_impdoc_Click(object sender, EventArgs e)
        {
            int tipusu = 0;
            string xcoddoc = txt_num.Text;

            string xcodusu = Cls_variables.xcodigo_usu;
            object codadmin = Cls_funciones.LeerRegistrosEnTablaSql("usuarios", "tipo_usu", "N", "codigo_usu='" + xcodusu + "'");
            tipusu = (int)Convert.ToInt32(codadmin);
            object docanul = Cls_funciones.LeerRegistrosEnTablaSql("documentos", "anular_doc", "L", "codigo_doc=" + xcoddoc + "");
            bool docanula = (bool)Convert.ToBoolean(docanul);

            if (tipusu == 1)
            {
                if (docanula == false)
                {
                    LlenarPanelImp();

                    // Cambiar a la pestaña de impresión

                    tabControl1.SelectedTab = tabControl1.TabPages[2];

                    // Ejecutar la lógica del botón 'Imprimir' al grabar Ticket
                    btn_impTicket_Click(sender, e);

                    tabControl1.SelectedTab = tabControl1.TabPages[0];

                    MessageBox.Show("Tickets generados con éxito.");
                    LimpiarGenTicket();
                }
                else
                {
                    MessageBox.Show("No puede reimprimir un documento anulado.");
                }
            }
            else
            {
                MessageBox.Show("No tienes permisos para reimprimir tickets. Solo los administradores pueden reimprimir.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void LlenarPanelImp()
        {

            lbl_numdT.Text = txt_num.Text;
            txt_proT.Text = cmb_nompro.Text;
            txt_cedtik.Text = txt_cli.Text;
            object nomTcli = Cls_funciones.LeerRegistrosEnTablaSql("clientes", "celular_cli", "C", "codigo_cli='" + txt_cli.Text + "'");
            object dirTcli = Cls_funciones.LeerRegistrosEnTablaSql("clientes", "direccion_cli", "C", "codigo_cli='" + txt_cli.Text + "'");
            int codpro = 0;

            if (cmb_nompro.Text == "")
            {
                codpro = 0;
            }
            else
            {
                if (cmb_nompro.SelectedValue == null)
                {
                    N_Documentos negocioDocumentos = new N_Documentos();
                    string codigoDoc = txt_num.Text;
                    DataTable dt_registroDoc = negocioDocumentos.ObtenerRegistrosPorDocumento(codigoDoc);
                    codpro = int.Parse(dt_registroDoc.Rows[0]["codigo_pro"].ToString());
                }
                else
                {
                    codpro = int.Parse(cmb_nompro.SelectedValue.ToString());
                }
            }

            object fecproT = Cls_funciones.LeerRegistrosEnTablaSql("promociones", "fec_fin_pro", "D", "codigo_pro=" + codpro + "");
            DateTime fecha = DateTime.Parse(fecproT.ToString());
            lbl_fechaproT.Text = fecha.ToString("dd/MM/yyyy");
            txt_nomcliT.Text = txt_nomcli.Text;
            txt_telfT.Text = nomTcli.ToString();
            txt_dirT.Text = dirTcli.ToString();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmb_nompro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //------------------------------------------------------------------------


    }
}
