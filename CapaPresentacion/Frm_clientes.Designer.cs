﻿namespace CapaPresentacion
{
    partial class Frm_clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_clientes));
            clientes = new TabControl();
            tabPage1 = new TabPage();
            panel2 = new Panel();
            btn_limpsaldo = new Button();
            btn_eliminar = new Button();
            label18 = new Label();
            txt_saldocli = new TextBox();
            txt_celular = new TextBox();
            label17 = new Label();
            label16 = new Label();
            txt_apellidos = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label7 = new Label();
            label3 = new Label();
            label9 = new Label();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btn_cancelar = new Button();
            cmb_genero = new ComboBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label6 = new Label();
            txt_correo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            txt_telefono = new TextBox();
            txt_direccion = new TextBox();
            txt_nombre = new TextBox();
            txt_codigo = new TextBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btn_editar = new Button();
            btn_grabar = new Button();
            btn_nuevo = new Button();
            pictureBox1 = new PictureBox();
            tabPage2 = new TabPage();
            grid_lista_clientes = new DataGridView();
            panel1 = new Panel();
            btn_busca_cli = new Button();
            txt_dato_buscar = new TextBox();
            pictureBox4 = new PictureBox();
            label15 = new Label();
            clientes.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_lista_clientes).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // clientes
            // 
            clientes.Controls.Add(tabPage1);
            clientes.Controls.Add(tabPage2);
            clientes.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            clientes.Location = new Point(41, 75);
            clientes.Name = "clientes";
            clientes.SelectedIndex = 0;
            clientes.Size = new Size(836, 452);
            clientes.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.WhiteSmoke;
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(label18);
            tabPage1.Controls.Add(txt_saldocli);
            tabPage1.Controls.Add(txt_celular);
            tabPage1.Controls.Add(label17);
            tabPage1.Controls.Add(label16);
            tabPage1.Controls.Add(txt_apellidos);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(btn_cancelar);
            tabPage1.Controls.Add(cmb_genero);
            tabPage1.Controls.Add(radioButton3);
            tabPage1.Controls.Add(radioButton2);
            tabPage1.Controls.Add(radioButton1);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txt_correo);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txt_telefono);
            tabPage1.Controls.Add(txt_direccion);
            tabPage1.Controls.Add(txt_nombre);
            tabPage1.Controls.Add(txt_codigo);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(pictureBox3);
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Controls.Add(btn_editar);
            tabPage1.Controls.Add(btn_grabar);
            tabPage1.Controls.Add(btn_nuevo);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Location = new Point(4, 25);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(828, 423);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registro";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btn_limpsaldo);
            panel2.Controls.Add(btn_eliminar);
            panel2.Location = new Point(552, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(253, 46);
            panel2.TabIndex = 44;
            // 
            // btn_limpsaldo
            // 
            btn_limpsaldo.BackColor = Color.LightGray;
            btn_limpsaldo.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_limpsaldo.Image = (Image)resources.GetObject("btn_limpsaldo.Image");
            btn_limpsaldo.Location = new Point(40, 3);
            btn_limpsaldo.Name = "btn_limpsaldo";
            btn_limpsaldo.Size = new Size(168, 35);
            btn_limpsaldo.TabIndex = 43;
            btn_limpsaldo.Text = "Limpiar Saldos";
            btn_limpsaldo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_limpsaldo.UseVisualStyleBackColor = false;
            btn_limpsaldo.Click += btn_limpsaldo_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_eliminar.Image = (Image)resources.GetObject("btn_eliminar.Image");
            btn_eliminar.Location = new Point(208, 3);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(38, 35);
            btn_eliminar.TabIndex = 4;
            btn_eliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Visible = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Gainsboro;
            label18.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(594, 133);
            label18.Name = "label18";
            label18.Size = new Size(44, 16);
            label18.TabIndex = 42;
            label18.Text = "Saldo:";
            // 
            // txt_saldocli
            // 
            txt_saldocli.Enabled = false;
            txt_saldocli.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_saldocli.Location = new Point(648, 128);
            txt_saldocli.MaxLength = 10;
            txt_saldocli.Name = "txt_saldocli";
            txt_saldocli.Size = new Size(114, 22);
            txt_saldocli.TabIndex = 41;
            // 
            // txt_celular
            // 
            txt_celular.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_celular.Location = new Point(393, 266);
            txt_celular.MaxLength = 10;
            txt_celular.Name = "txt_celular";
            txt_celular.Size = new Size(149, 22);
            txt_celular.TabIndex = 40;
            txt_celular.KeyDown += txt_celular_KeyDown;
            txt_celular.KeyPress += txt_celular_KeyPress;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Gainsboro;
            label17.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(324, 271);
            label17.Name = "label17";
            label17.Size = new Size(51, 16);
            label17.TabIndex = 39;
            label17.Text = "Celular:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Gainsboro;
            label16.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(54, 201);
            label16.Name = "label16";
            label16.Size = new Size(64, 16);
            label16.TabIndex = 38;
            label16.Text = "Apellidos:";
            // 
            // txt_apellidos
            // 
            txt_apellidos.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_apellidos.Location = new Point(154, 198);
            txt_apellidos.MaxLength = 50;
            txt_apellidos.Name = "txt_apellidos";
            txt_apellidos.Size = new Size(388, 22);
            txt_apellidos.TabIndex = 37;
            txt_apellidos.KeyDown += txt_apellidos_KeyDown;
            txt_apellidos.KeyPress += txt_apellidos_KeyPress;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Gainsboro;
            label14.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(55, 378);
            label14.Name = "label14";
            label14.Size = new Size(76, 16);
            label14.TabIndex = 36;
            label14.Text = "Fecha nac.:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Gainsboro;
            label13.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(55, 345);
            label13.Name = "label13";
            label13.Size = new Size(53, 16);
            label13.TabIndex = 35;
            label13.Text = "Género:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Gainsboro;
            label12.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(55, 272);
            label12.Name = "label12";
            label12.Size = new Size(58, 16);
            label12.TabIndex = 34;
            label12.Text = "Teléfono:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Gainsboro;
            label11.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(55, 309);
            label11.Name = "label11";
            label11.Size = new Size(49, 16);
            label11.TabIndex = 33;
            label11.Text = "Correo:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Gainsboro;
            label10.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(55, 237);
            label10.Name = "label10";
            label10.Size = new Size(65, 16);
            label10.TabIndex = 32;
            label10.Text = "Dirección:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Gainsboro;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(55, 168);
            label7.Name = "label7";
            label7.Size = new Size(63, 16);
            label7.TabIndex = 31;
            label7.Text = "Nombres:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gainsboro;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(55, 135);
            label3.Name = "label3";
            label3.Size = new Size(93, 16);
            label3.TabIndex = 2;
            label3.Text = "CI/RUC/PASS:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Gainsboro;
            label9.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(63, 354);
            label9.Name = "label9";
            label9.Size = new Size(0, 16);
            label9.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Gainsboro;
            label8.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(63, 319);
            label8.Name = "label8";
            label8.Size = new Size(0, 16);
            label8.TabIndex = 28;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.ImeMode = ImeMode.NoControl;
            dateTimePicker1.Location = new Point(154, 375);
            dateTimePicker1.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(152, 22);
            dateTimePicker1.TabIndex = 29;
            dateTimePicker1.Value = new DateTime(2024, 10, 7, 0, 0, 0, 0);
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.LightGray;
            btn_cancelar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelar.Image = (Image)resources.GetObject("btn_cancelar.Image");
            btn_cancelar.Location = new Point(426, 15);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(112, 35);
            btn_cancelar.TabIndex = 24;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // cmb_genero
            // 
            cmb_genero.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_genero.FormattingEnabled = true;
            cmb_genero.Items.AddRange(new object[] { "MASCULINO", "FEMENINO", "OTROS" });
            cmb_genero.Location = new Point(154, 340);
            cmb_genero.Name = "cmb_genero";
            cmb_genero.Size = new Size(152, 24);
            cmb_genero.TabIndex = 23;
            cmb_genero.TextChanged += cmb_genero_TextChanged;
            cmb_genero.Click += cmb_genero_Click;
            // 
            // radioButton3
            // 
            radioButton3.BackColor = Color.Gainsboro;
            radioButton3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.Location = new Point(252, 72);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(104, 24);
            radioButton3.TabIndex = 26;
            radioButton3.Text = "Pasaporte";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Gainsboro;
            radioButton2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(154, 74);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(48, 20);
            radioButton2.TabIndex = 20;
            radioButton2.TabStop = true;
            radioButton2.Text = "Ruc";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Gainsboro;
            radioButton1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(55, 74);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(65, 20);
            radioButton1.TabIndex = 19;
            radioButton1.TabStop = true;
            radioButton1.Text = "Cedula";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Gainsboro;
            label6.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(63, 274);
            label6.Name = "label6";
            label6.Size = new Size(0, 16);
            label6.TabIndex = 18;
            // 
            // txt_correo
            // 
            txt_correo.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_correo.Location = new Point(154, 303);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(232, 22);
            txt_correo.TabIndex = 17;
            txt_correo.KeyDown += txt_correo_KeyDown;
            txt_correo.KeyPress += txt_correo_KeyPress;
            txt_correo.Validating += txt_correo_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gainsboro;
            label5.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(63, 240);
            label5.Name = "label5";
            label5.Size = new Size(0, 16);
            label5.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Gainsboro;
            label4.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(63, 203);
            label4.Name = "label4";
            label4.Size = new Size(0, 16);
            label4.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gainsboro;
            label2.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(63, 167);
            label2.Name = "label2";
            label2.Size = new Size(0, 16);
            label2.TabIndex = 13;
            // 
            // txt_telefono
            // 
            txt_telefono.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_telefono.Location = new Point(154, 268);
            txt_telefono.MaxLength = 10;
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(152, 22);
            txt_telefono.TabIndex = 12;
            txt_telefono.KeyDown += txt_telefono_KeyDown;
            txt_telefono.KeyPress += txt_telefono_KeyPress;
            // 
            // txt_direccion
            // 
            txt_direccion.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_direccion.Location = new Point(154, 232);
            txt_direccion.MaxLength = 50;
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(388, 22);
            txt_direccion.TabIndex = 11;
            txt_direccion.KeyDown += txt_direccion_KeyDown;
            // 
            // txt_nombre
            // 
            txt_nombre.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nombre.Location = new Point(154, 164);
            txt_nombre.MaxLength = 50;
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(388, 22);
            txt_nombre.TabIndex = 10;
            txt_nombre.KeyDown += txt_nombre_KeyDown;
            txt_nombre.KeyPress += txt_nombre_KeyPress;
            // 
            // txt_codigo
            // 
            txt_codigo.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_codigo.Location = new Point(154, 132);
            txt_codigo.MaxLength = 15;
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(152, 22);
            txt_codigo.TabIndex = 9;
            txt_codigo.KeyDown += txt_codigo_KeyDown;
            txt_codigo.Leave += txt_codigo_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(63, 134);
            label1.Name = "label1";
            label1.Size = new Size(0, 16);
            label1.TabIndex = 8;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Gainsboro;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(6, 108);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(815, 310);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Gainsboro;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(6, 65);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(816, 38);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // btn_editar
            // 
            btn_editar.BackColor = Color.LightGray;
            btn_editar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_editar.Image = (Image)resources.GetObject("btn_editar.Image");
            btn_editar.Location = new Point(302, 15);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(112, 35);
            btn_editar.TabIndex = 3;
            btn_editar.Text = "Editar";
            btn_editar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_editar.UseVisualStyleBackColor = false;
            btn_editar.Click += btn_editar_Click;
            // 
            // btn_grabar
            // 
            btn_grabar.BackColor = Color.LightGray;
            btn_grabar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_grabar.Image = (Image)resources.GetObject("btn_grabar.Image");
            btn_grabar.Location = new Point(178, 15);
            btn_grabar.Name = "btn_grabar";
            btn_grabar.Size = new Size(112, 35);
            btn_grabar.TabIndex = 2;
            btn_grabar.Text = "Grabar";
            btn_grabar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_grabar.UseVisualStyleBackColor = false;
            btn_grabar.Click += btn_grabar_Click;
            // 
            // btn_nuevo
            // 
            btn_nuevo.BackColor = Color.LightGray;
            btn_nuevo.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_nuevo.Image = (Image)resources.GetObject("btn_nuevo.Image");
            btn_nuevo.Location = new Point(54, 15);
            btn_nuevo.Name = "btn_nuevo";
            btn_nuevo.Size = new Size(112, 35);
            btn_nuevo.TabIndex = 1;
            btn_nuevo.Text = "Nuevo";
            btn_nuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_nuevo.UseVisualStyleBackColor = false;
            btn_nuevo.Click += btn_nuevo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightSteelBlue;
            pictureBox1.Location = new Point(6, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(816, 56);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(grid_lista_clientes);
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 25);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(828, 423);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Listado";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // grid_lista_clientes
            // 
            grid_lista_clientes.AllowUserToAddRows = false;
            grid_lista_clientes.AllowUserToDeleteRows = false;
            grid_lista_clientes.BackgroundColor = Color.Gainsboro;
            grid_lista_clientes.BorderStyle = BorderStyle.Fixed3D;
            grid_lista_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_lista_clientes.Location = new Point(7, 57);
            grid_lista_clientes.Name = "grid_lista_clientes";
            grid_lista_clientes.ReadOnly = true;
            grid_lista_clientes.RowTemplate.Height = 25;
            grid_lista_clientes.Size = new Size(814, 360);
            grid_lista_clientes.TabIndex = 0;
            grid_lista_clientes.CellDoubleClick += grid_lista_clientes_CellDoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(btn_busca_cli);
            panel1.Controls.Add(txt_dato_buscar);
            panel1.Location = new Point(7, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(814, 47);
            panel1.TabIndex = 3;
            // 
            // btn_busca_cli
            // 
            btn_busca_cli.BackColor = Color.LightGray;
            btn_busca_cli.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_busca_cli.Image = (Image)resources.GetObject("btn_busca_cli.Image");
            btn_busca_cli.ImageAlign = ContentAlignment.MiddleRight;
            btn_busca_cli.Location = new Point(319, 6);
            btn_busca_cli.Name = "btn_busca_cli";
            btn_busca_cli.Size = new Size(112, 35);
            btn_busca_cli.TabIndex = 2;
            btn_busca_cli.Text = "Buscar";
            btn_busca_cli.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_busca_cli.UseVisualStyleBackColor = false;
            btn_busca_cli.Click += btn_busca_cli_Click;
            // 
            // txt_dato_buscar
            // 
            txt_dato_buscar.Location = new Point(38, 12);
            txt_dato_buscar.Name = "txt_dato_buscar";
            txt_dato_buscar.Size = new Size(264, 22);
            txt_dato_buscar.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(923, 545);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(396, 39);
            label15.Name = "label15";
            label15.Size = new Size(107, 24);
            label15.TabIndex = 2;
            label15.Text = "CLIENTES";
            // 
            // Frm_clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 545);
            Controls.Add(label15);
            Controls.Add(clientes);
            Controls.Add(pictureBox4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_clientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_clientes";
            Load += Frm_clientes_Load;
            clientes.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid_lista_clientes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl clientes;
        private TabPage tabPage2;
        private Button btn_busca_cli;
        private TextBox txt_dato_buscar;
        private DataGridView grid_lista_clientes;
        private Label label10;
        private TextBox txt_saldo_cli;
        private TabPage tabPage1;
        private Label label9;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private Button btn_cancelar;
        private ComboBox cmb_genero;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label6;
        private TextBox txt_correo;
        private Label label5;
        private Label label4;
        private Label label2;
        private TextBox txt_telefono;
        private TextBox txt_direccion;
        private TextBox txt_nombre;
        private TextBox txt_codigo;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button btn_eliminar;
        private Button btn_editar;
        private Button btn_grabar;
        private Button btn_nuevo;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private Label label7;
        private Label label3;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label15;
        private Panel panel1;
        private Label label16;
        private TextBox txt_apellidos;
        private TextBox txt_celular;
        private Label label17;
        private TextBox txt_saldocli;
        private Label label18;
        private Button btn_limpsaldo;
        private Button btn_recuperarsald;
        private Panel panel2;
    }
}