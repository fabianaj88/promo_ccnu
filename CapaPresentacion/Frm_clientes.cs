﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidades;
using CapaNegocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;

namespace CapaPresentacion
{
    public partial class Frm_clientes : Form
    {
        private string xtipdoc = ""; // Campo de clase para almacenar el tipo de documento
        public Frm_clientes()
        {
            InitializeComponent();
            carga_inicial();
        }

        private void Frm_clientes_Load(object sender, EventArgs e)
        {
            // Obtener el tipo de usuario actualmente logueado
            int tipusu = 0;
            string xcodusu = Cls_variables.xcodigo_usu;

            object codadmin = Cls_funciones.LeerRegistrosEnTablaSql("usuarios", "tipo_usu", "N",
                "codigo_usu='" + xcodusu + "'");
            tipusu = (int)Convert.ToInt32(codadmin);

            // Ocultar el botón si no es administrador
            if (tipusu != 1)
            {
                btn_limpsaldo.Enabled = false;
                //btn_recuperarsald.Enabled = false;
            }
        }

        private void txt_codigo_Leave(object sender, EventArgs e)
        {
            string codigoCliente = txt_codigo.Text;

            // Validaciones para cédula, RUC y pasaporte
            if (codigoCliente != "")
            {
                if (radioButton1.Checked)
                {
                    if (IsValidCedula(codigoCliente))
                    {
                        xtipdoc = "1";
                    }
                    else
                    {
                        MessageBox.Show("El código ingresado no es un número de cédula válido.", "Código no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_codigo.Focus();
                        return; // Termina aquí si la validación no es correcta
                    }
                }
                else if (radioButton2.Checked)
                {
                    if (IsValidRuc(codigoCliente))
                    {
                        xtipdoc = "2";
                    }
                    else
                    {
                        MessageBox.Show("El código ingresado no es un número de RUC válido.", "Código no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_codigo.Focus();
                        return; // Termina aquí si la validación no es correcta
                    }
                }
                else if (radioButton3.Checked)
                {
                    if (IsValidPassport(codigoCliente))
                    {
                        xtipdoc = "3";
                    }
                    else
                    {
                        MessageBox.Show("El código ingresado no es un número de Pasaporte válido.", "Código no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_codigo.Focus();
                        return; // Termina aquí si la validación no es correcta
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese el código del cliente.");
            }
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            string codigoCliente = txt_codigo.Text;

            // Validaciones para cédula, RUC y pasaporte
            if (codigoCliente != "")
            {
                if (radioButton1.Checked)
                {
                    if (IsValidCedula(codigoCliente))
                    {
                        xtipdoc = "1";
                    }
                    else
                    {
                        MessageBox.Show("El código ingresado no es un número de cédula válido.", "Código no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_codigo.Focus();
                        return; // Termina aquí si la validación no es correcta
                    }
                }
                else if (radioButton2.Checked)
                {
                    if (IsValidRuc(codigoCliente))
                    {
                        xtipdoc = "2";
                    }
                    else
                    {
                        MessageBox.Show("El código ingresado no es un número de RUC válido.", "Código no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_codigo.Focus();
                        return; // Termina aquí si la validación no es correcta
                    }
                }
                else if (radioButton3.Checked)
                {
                    if (IsValidPassport(codigoCliente))
                    {
                        xtipdoc = "3";
                    }
                    else
                    {
                        MessageBox.Show("El código ingresado no es un número de Pasaporte válido.", "Código no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_codigo.Focus();
                        return; // Termina aquí si la validación no es correcta
                    }
                }
            }

            if (ControlVacio())
            {
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
                        apellido_cli = txt_apellidos.Text,
                        tipo_doc_cli = xtipdoc,
                        num_doc_cli = txt_codigo.Text,
                        fecha_nac_cli = dateTimePicker1.Value,
                        genero_cli = cmb_genero.Text,
                        telefono_cli = txt_telefono.Text,
                        celular_cli = txt_celular.Text,
                        direccion_cli = txt_direccion.Text,
                        correo_cli = txt_correo.Text,

                    };
                    // Llamar a la capa de negocio para grabar los datos
                    N_Clientes ncli = new N_Clientes();
                    bool exito = ncli.GrabarClientes(cliente);

                    if (exito)
                    {

                        MessageBox.Show("Cliente grabado con éxito.");
                        carga_inicial();
                    }
                    else
                    {
                        MessageBox.Show("Error al grabar el cliente.");
                    }
                }
            }

        }
        private void btn_editar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Estás seguro de editar los datos del cliente?",
                                   "Confirmación",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                string xcampos = "";
                int xgraba = 0;
                try
                {
                    xcampos = "nombre_cli='" + txt_nombre.Text + "',apellido_cli='" + txt_apellidos.Text + "',direccion_cli='" + txt_direccion.Text + "',telefono_cli='" + txt_telefono.Text + "',celular_cli='" + txt_celular.Text + "',genero_cli='" + cmb_genero.Text + "',fecha_nac_cli='" + dateTimePicker1.Value + "',correo_cli='" + txt_correo.Text + "'";
                    Cls_funciones.ModificaS("clientes", xcampos, "codigo_cli='" + txt_codigo.Text + "'");
                    xgraba = 1;
                }
                catch
                {
                    xgraba = 0;
                }

                if (xgraba == 1)
                {
                    MessageBox.Show("Cliente editado con éxito.");
                    carga_inicial();
                }
                else
                {
                    MessageBox.Show("Error al editar el cliente");
                }
            }
        }

        private void carga_inicial()
        {
            btn_nuevo.Enabled = true;
            btn_editar.Enabled = false;
            //btn_buscar.Enabled = true;
            btn_eliminar.Enabled = false;
            btn_grabar.Enabled = false;
            btn_cancelar.Enabled = false;
            //
            txt_codigo.Enabled = false;
            txt_nombre.Enabled = false;
            txt_apellidos.Enabled = false;
            txt_direccion.Enabled = false;
            txt_direccion.Enabled = false;
            txt_telefono.Enabled = false;
            txt_celular.Enabled = false;
            txt_correo.Enabled = false;
            cmb_genero.Enabled = false;
            dateTimePicker1.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;

            //-----------------------------
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            txt_codigo.Text = "";
            txt_nombre.Text = "";
            txt_apellidos.Text = "";
            txt_direccion.Text = "";
            txt_telefono.Text = "";
            txt_celular.Text = "";
            txt_correo.Text = "";
            cmb_genero.Text = "";
            txt_saldocli.Text = "";
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            btn_nuevo.Enabled = false;
            btn_editar.Enabled = false;
            //btn_buscar.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_grabar.Enabled = true;
            btn_cancelar.Enabled = true;
            //
            txt_codigo.Enabled = true;
            txt_nombre.Enabled = true;
            txt_apellidos.Enabled = true;
            txt_direccion.Enabled = true;
            txt_direccion.Enabled = true;
            txt_telefono.Enabled = true;
            txt_celular.Enabled = true;
            txt_correo.Enabled = true;
            cmb_genero.Enabled = true;
            dateTimePicker1.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            //
            txt_codigo.Text = "";
            txt_nombre.Text = "";
            txt_apellidos.Text = "";
            txt_direccion.Text = "";
            txt_direccion.Text = "";
            txt_telefono.Text = "";
            txt_celular.Text = "";
            txt_correo.Text = "";
            cmb_genero.Text = "";
            txt_saldocli.Text = "0";

            //dateTimePicker1.Text = DateTime.Now;
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            carga_inicial();
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
        private bool ControlVacio()
        {
            if (txt_codigo.Text == "")
            {
                MessageBox.Show("Ingrese el código del cliente.");
                return false;
            }
            if (txt_nombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del cliente.");
                return false;
            }
            if (txt_apellidos.Text == "")
            {
                MessageBox.Show("Ingrese el apellido del cliente.");
                return false;
            }
            if (txt_direccion.Text == "")
            {
                MessageBox.Show("Ingrese la dirección del cliente.");
                return false;
            }
            //if (txt_telefono.Text == "")
            //{
            //    MessageBox.Show("Ingrese el número de teléfono del cliente.");
            //    return false;
            //}
            if (txt_celular.Text == "")
            {
                MessageBox.Show("Ingrese el número de celular del cliente.");
                return false;
            }
            //if (txt_correo.Text == "")
            //{
            //    MessageBox.Show("Ingrese el correo del cliente.");
            //    return false;
            //}
            if (cmb_genero.Text == "")
            {
                MessageBox.Show("Ingrese el género del cliente.");
                return false;
            }

            return true;
        }

        private void btn_busca_cli_Click(object sender, EventArgs e)
        {
            string xsentencia = "";
            DataTable dt_clientes = new DataTable();
            if (txt_dato_buscar.Text == "")
            {
                xsentencia = "select codigo_cli as Codigo,nombre_cli as Nombres,apellido_cli as Apellidos,direccion_cli as Direccion,telefono_cli as Telefono,celular_cli as Celular,fecha_nac_cli as Nacimiento,genero_cli as Genero,saldo_cli as Saldo,correo_cli as Correo from clientes order by nombre_cli";
            }
            else
            {
                xsentencia = "select codigo_cli as Codigo,nombre_cli as Nombres,apellido_cli as Apellidos,direccion_cli as Direccion,telefono_cli as Telefono,celular_cli as Celular,fecha_nac_cli as Nacimiento,genero_cli as Genero,saldo_cli as Saldo,correo_cli as Correo from clientes where codigo_cli like'%" + txt_dato_buscar.Text + "%' or nombre_cli like'%" + txt_dato_buscar.Text + "%' or apellido_cli like'%" + txt_dato_buscar.Text + "%' order by nombre_cli";
            }
            dt_clientes = Cls_funciones.VisualizaS(xsentencia);
            grid_lista_clientes.DataSource = dt_clientes;
        }
        private void busca_cliente(String dato)
        {
            DataTable dt_datos = new DataTable();
            string xsentencia_usu = "select * from clientes where codigo_cli='" + dato.Trim() + "' ";
            dt_datos = Cls_funciones.VisualizaS(xsentencia_usu);
            if (dt_datos.Rows.Count > 0)
            {
                // int u = 0;
                for (int u = 0; u < dt_datos.Rows.Count; u++)
                {
                    txt_codigo.Text = dt_datos.Rows[u]["codigo_cli"].ToString();
                    txt_nombre.Text = dt_datos.Rows[u]["nombre_cli"].ToString();
                    txt_apellidos.Text = dt_datos.Rows[u]["apellido_cli"].ToString();
                    txt_correo.Text = dt_datos.Rows[u]["correo_cli"].ToString();
                    dateTimePicker1.Text = dt_datos.Rows[u]["fecha_nac_cli"].ToString();
                    cmb_genero.Text = dt_datos.Rows[u]["genero_cli"].ToString();
                    txt_saldocli.Text = dt_datos.Rows[u]["saldo_cli"].ToString();
                    txt_celular.Text = dt_datos.Rows[u]["celular_cli"].ToString();
                    txt_telefono.Text = dt_datos.Rows[u]["telefono_cli"].ToString();
                    txt_direccion.Text = dt_datos.Rows[u]["direccion_cli"].ToString();
                    if (dt_datos.Rows[u]["tipo_doc_cli"].ToString() == "1")
                    {
                        radioButton1.Checked = true;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                    }
                    if (dt_datos.Rows[u]["tipo_doc_cli"].ToString() == "2")
                    {
                        radioButton1.Checked = false;
                        radioButton2.Checked = true;
                        radioButton3.Checked = false;
                    }
                    if (dt_datos.Rows[u]["tipo_doc_cli"].ToString() == "3")
                    {
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = true;
                    }

                }
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;

                btn_nuevo.Enabled = false;
                btn_grabar.Enabled = false;
                btn_editar.Enabled = true;
                btn_cancelar.Enabled = true;

                txt_codigo.Enabled = false;
                txt_saldocli.Enabled = false;
                txt_nombre.Enabled = true;
                txt_apellidos.Enabled = true;
                txt_direccion.Enabled = true;
                txt_telefono.Enabled = true;
                txt_celular.Enabled = true;
                txt_correo.Enabled = true;
                cmb_genero.Enabled = true;
                dateTimePicker1.Enabled = true;

                clientes.SelectedTab = clientes.TabPages[0];

            }

        }
        private void grid_lista_clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ignorar la cabecera
            {
                // Selecciona la fila
                grid_lista_clientes.Rows[e.RowIndex].Selected = true;

                // Si quieres hacer algo con la fila seleccionada
                var selectedRow = grid_lista_clientes.Rows[e.RowIndex];
                // Ejemplo: obtener un valor de la primera columna
                var value = selectedRow.Cells[1].ToString();
                // MessageBox.Show($"Has seleccionado: {value}");
                string nombre = grid_lista_clientes.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                busca_cliente(nombre);
                // Muestra el valor en un mensaje
                //  MessageBox.Show($"Has seleccionado el nombre: {nombre}");
            }
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignorar cualquier otra tecla que no sea número o retroceso
            }
        }
        private void txt_codigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_codigo.Text != "")
                {
                    string xcontrol_cli = Cls_funciones.LeerRegistrosEnTablaSql("clientes", "codigo_cli", "C", "codigo_cli='" + txt_codigo.Text + "'").ToString();
                    if (xcontrol_cli != "")
                    {
                        MessageBox.Show("Código de cliente ya existe .");
                        txt_codigo.Text = "";
                        return;
                    }
                    else
                    {
                        txt_nombre.Focus();
                    }
                }


            }

        }

        private void txt_nombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_apellidos.Focus();
            }
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
        private void txt_apellidos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_direccion.Focus();
            }
        }
        private void txt_apellidos_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt_direccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_telefono.Focus();
            }
        }
        private void txt_telefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_celular.Focus();
            }
        }
        private void txt_celular_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_correo.Focus();
            }
        }
        private void txt_celular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignorar cualquier otra tecla que no sea número o retroceso
            }
        }
        private void txt_correo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_genero.Focus();
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
        private void cmb_genero_TextChanged(object sender, EventArgs e)
        {
            string searchText = cmb_genero.Text;
            cmb_genero.Items.Clear(); // Limpia los elementos actuales

            // Vuelve a agregar los elementos que coinciden con el texto de búsqueda
            if (!string.IsNullOrEmpty(searchText))
            {
                foreach (string item in new[] { "MASCULINO", "FEMENINO", "OTROS" })
                {
                    if (item.StartsWith(searchText, StringComparison.OrdinalIgnoreCase))
                    {
                        cmb_genero.Items.Add(item);
                    }
                }
            }

            // Selecciona el primer elemento que coincida (si existe)
            if (cmb_genero.Items.Count > 0)
            {
                cmb_genero.DroppedDown = true; // Abre la lista desplegable
                cmb_genero.SelectionStart = searchText.Length; // Mantiene el cursor al final del texto
            }
        }
        private void cmb_genero_Click(object sender, EventArgs e)
        {

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



        private void btn_limpsaldo_Click(object sender, EventArgs e)
        {
            // Obtener el tipo de usuario actualmente logueado
            int tipusu = 0;
            string xcodusu = Cls_variables.xcodigo_usu;

            object codadmin = Cls_funciones.LeerRegistrosEnTablaSql("usuarios", "tipo_usu", "N",
                "codigo_usu='" + xcodusu + "'");
            tipusu = (int)Convert.ToInt32(codadmin);

            // Verificar si es administrador (tipo 1)
            if (tipusu == 1)
            {
                try
                {
                    // Verificar si todos los saldos ya están en cero
                    object saldoCount = Cls_funciones.LeerRegistrosEnTablaSql("clientes", "COUNT(*)", "N", "saldo_cli <> 0");
                    int registrosConSaldo = Convert.ToInt32(saldoCount);

                    if (registrosConSaldo == 0)
                    {
                        MessageBox.Show("No puede limpiar los saldos, todos están en cero.",
                            "Operación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var result = MessageBox.Show("¿Estás seguro de limpiar los saldos de los clientes?",
                                    "Confirmación",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        // Actualizar los valores en la base de datos usando ModificaS
                        string campos = "saldo_ant = saldo_cli, saldo_cli = 0";
                        bool resultado = Cls_funciones.ModificaS("clientes", campos, "");
                        if (resultado)
                        {
                            MessageBox.Show("Saldos actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Actualizar promociones cuya fecha de fin ya pasó
                            string condicionPromocion = "fec_fin_pro < GETDATE()";
                            string camposPromocion = "estado_pro = 0"; // False en SQL Server
                            bool resultadoPromociones = Cls_funciones.ModificaS("promociones", camposPromocion, condicionPromocion);

                            if (resultadoPromociones)
                            {
                                MessageBox.Show("Promociones finalizadas desactivadas correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se pudieron desactivar las promociones. Revisa la información.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron actualizar los saldos. Revisa la información.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al actualizar los saldos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Si no es administrador, mostrar mensaje de acceso denegado
                MessageBox.Show("No tienes permisos para realizar esta acción. Solo los administradores pueden actualizar saldos.",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       













        //private void btn_recuperarsald_Click(object sender, EventArgs e)
        //{
        //    // Verificar el tipo de usuario
        //    int tipusu = 0;
        //    string xcodusu = Cls_variables.xcodigo_usu;

        //    object codadmin = Cls_funciones.LeerRegistrosEnTablaSql("usuarios", "tipo_usu", "N",
        //        "codigo_usu='" + xcodusu + "'");
        //    tipusu = (int)Convert.ToInt32(codadmin);

        //    // Verificar si es administrador
        //    if (tipusu == 1)
        //    {
        //        try
        //        {
        //            // Definir los campos y ejecutar la actualización para recuperar saldos
        //            string campos = "saldo_cli = saldo_ant, saldo_ant = 0";
        //            bool resultado = Cls_funciones.ModificaS("clientes", campos, "");

        //            if (resultado)
        //            {
        //                MessageBox.Show("Saldos recuperados correctamente.",
        //                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                btn_limpsaldo.Visible = true;
        //                btn_recuperarsald.Visible = false;
        //            }
        //            else
        //            {
        //                MessageBox.Show("No se pudieron recuperar los saldos. Revisa la información.",
        //                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Ocurrió un error al recuperar los saldos: " + ex.Message,
        //                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    else
        //    {
        //        // Mostrar mensaje si no es administrador
        //        MessageBox.Show("No tienes permisos para realizar esta acción. Solo los administradores pueden recuperar saldos.",
        //            "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}



        //public static void ExportarDataGridViewAExcel(DataGridView dataGridView)
        //{
        //    Excel.Application excelApp = new Excel.Application();
        //    excelApp.Workbooks.Add();

        //    Excel._Worksheet worksheet = (Excel._Worksheet)excelApp.ActiveSheet;

        //    // Exportar encabezados
        //    for (int i = 0; i < dataGridView.Columns.Count; i++)
        //    {
        //        worksheet.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
        //    }

        //    // Exportar filas
        //    for (int i = 0; i < dataGridView.Rows.Count; i++)
        //    {
        //        for (int j = 0; j < dataGridView.Columns.Count; j++)
        //        {
        //            worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value?.ToString();
        //        }
        //    }

        //    // Ajustar columnas automáticamente
        //    worksheet.Columns.AutoFit();

        //    // Hacer visible Excel
        //    excelApp.Visible = true;

        //    // Limpiar recursos
        //    System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
        //    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
        //}

    }
}