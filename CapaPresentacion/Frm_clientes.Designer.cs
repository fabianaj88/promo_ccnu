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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_clientes));
            contextMenuStrip1 = new ContextMenuStrip(components);
            Locales = new TabControl();
            tabPage1 = new TabPage();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            btn_cancelar = new Button();
            cmb_genero = new ComboBox();
            label7 = new Label();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label6 = new Label();
            txt_correo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txt_telefono = new TextBox();
            txt_direccion = new TextBox();
            txt_nombre = new TextBox();
            txt_codigo = new TextBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btn_buscar = new Button();
            btn_eliminar = new Button();
            btn_editar = new Button();
            btn_grabar = new Button();
            btn_nuevo = new Button();
            pictureBox1 = new PictureBox();
            tabPage2 = new TabPage();
            btn_busca_cli = new Button();
            txt_dato_buscar = new TextBox();
            grid_lista_clientes = new DataGridView();
            seleccionar = new DataGridViewButtonColumn();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            txt_saldo_cli = new TextBox();
            label10 = new Label();
            Locales.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_lista_clientes).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.ShowCheckMargin = true;
            contextMenuStrip1.ShowImageMargin = false;
            contextMenuStrip1.Size = new Size(61, 4);
            contextMenuStrip1.Text = "1";
            // 
            // Locales
            // 
            Locales.Controls.Add(tabPage1);
            Locales.Controls.Add(tabPage2);
            Locales.Controls.Add(tabPage3);
            Locales.Controls.Add(tabPage4);
            Locales.Location = new Point(12, 12);
            Locales.Name = "Locales";
            Locales.SelectedIndex = 0;
            Locales.Size = new Size(857, 465);
            Locales.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.WhiteSmoke;
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(txt_saldo_cli);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(btn_cancelar);
            tabPage1.Controls.Add(cmb_genero);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(radioButton3);
            tabPage1.Controls.Add(radioButton2);
            tabPage1.Controls.Add(radioButton1);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txt_correo);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txt_telefono);
            tabPage1.Controls.Add(txt_direccion);
            tabPage1.Controls.Add(txt_nombre);
            tabPage1.Controls.Add(txt_codigo);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(pictureBox3);
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Controls.Add(btn_buscar);
            tabPage1.Controls.Add(btn_eliminar);
            tabPage1.Controls.Add(btn_editar);
            tabPage1.Controls.Add(btn_grabar);
            tabPage1.Controls.Add(btn_nuevo);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(849, 437);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registro";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(36, 386);
            label9.Name = "label9";
            label9.Size = new Size(79, 16);
            label9.TabIndex = 30;
            label9.Text = "Fecha Nac:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.ImeMode = ImeMode.NoControl;
            dateTimePicker1.Location = new Point(127, 381);
            dateTimePicker1.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(152, 22);
            dateTimePicker1.TabIndex = 29;
            dateTimePicker1.Value = new DateTime(2024, 10, 7, 0, 0, 0, 0);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(36, 346);
            label8.Name = "label8";
            label8.Size = new Size(59, 16);
            label8.TabIndex = 28;
            label8.Text = "Genero:";
            // 
            // btn_cancelar
            // 
            btn_cancelar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelar.Image = (Image)resources.GetObject("btn_cancelar.Image");
            btn_cancelar.Location = new Point(342, 48);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 24;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // cmb_genero
            // 
            cmb_genero.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_genero.FormattingEnabled = true;
            cmb_genero.Items.AddRange(new object[] { "MASCULINO", "FEMENINO", "OTROS" });
            cmb_genero.Location = new Point(127, 343);
            cmb_genero.Name = "cmb_genero";
            cmb_genero.Size = new Size(152, 24);
            cmb_genero.TabIndex = 23;
            // 
            // label7
            // 
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 25;
            // 
            // radioButton3
            // 
            radioButton3.Location = new Point(0, 0);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(104, 24);
            radioButton3.TabIndex = 26;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(164, 94);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(45, 19);
            radioButton2.TabIndex = 20;
            radioButton2.TabStop = true;
            radioButton2.Text = "Ruc";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(55, 94);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 19);
            radioButton1.TabIndex = 19;
            radioButton1.TabStop = true;
            radioButton1.Text = "Cedula";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(36, 306);
            label6.Name = "label6";
            label6.Size = new Size(55, 16);
            label6.TabIndex = 18;
            label6.Text = "Correo:";
            // 
            // txt_correo
            // 
            txt_correo.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_correo.Location = new Point(127, 306);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(232, 23);
            txt_correo.TabIndex = 17;
            txt_correo.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(36, 272);
            label5.Name = "label5";
            label5.Size = new Size(65, 16);
            label5.TabIndex = 16;
            label5.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(36, 235);
            label4.Name = "label4";
            label4.Size = new Size(70, 16);
            label4.TabIndex = 15;
            label4.Text = "Direccion:";
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 199);
            label2.Name = "label2";
            label2.Size = new Size(51, 16);
            label2.TabIndex = 13;
            label2.Text = "Cliente";
            label2.Click += label2_Click;
            // 
            // txt_telefono
            // 
            txt_telefono.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_telefono.Location = new Point(127, 270);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(152, 23);
            txt_telefono.TabIndex = 12;
            // 
            // txt_direccion
            // 
            txt_direccion.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_direccion.Location = new Point(127, 236);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(388, 23);
            txt_direccion.TabIndex = 11;
            // 
            // txt_nombre
            // 
            txt_nombre.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nombre.Location = new Point(127, 200);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(388, 23);
            txt_nombre.TabIndex = 10;
            // 
            // txt_codigo
            // 
            txt_codigo.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_codigo.Location = new Point(127, 164);
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(152, 23);
            txt_codigo.TabIndex = 9;
            txt_codigo.TextChanged += txt_codigo_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 166);
            label1.Name = "label1";
            label1.Size = new Size(56, 16);
            label1.TabIndex = 8;
            label1.Text = "Código:";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Gainsboro;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(17, 130);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(805, 10);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Gainsboro;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(17, 85);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(805, 38);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // btn_buscar
            // 
            btn_buscar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_buscar.Image = (Image)resources.GetObject("btn_buscar.Image");
            btn_buscar.Location = new Point(541, 48);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(75, 23);
            btn_buscar.TabIndex = 5;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_eliminar.Image = (Image)resources.GetObject("btn_eliminar.Image");
            btn_eliminar.Location = new Point(439, 48);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(75, 23);
            btn_eliminar.TabIndex = 4;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            btn_editar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_editar.Image = (Image)resources.GetObject("btn_editar.Image");
            btn_editar.Location = new Point(243, 48);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(75, 23);
            btn_editar.TabIndex = 3;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_grabar
            // 
            btn_grabar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_grabar.Image = (Image)resources.GetObject("btn_grabar.Image");
            btn_grabar.Location = new Point(148, 48);
            btn_grabar.Name = "btn_grabar";
            btn_grabar.Size = new Size(75, 23);
            btn_grabar.TabIndex = 2;
            btn_grabar.Text = "Grabar";
            btn_grabar.UseVisualStyleBackColor = true;
            btn_grabar.Click += btn_grabar_Click;
            // 
            // btn_nuevo
            // 
            btn_nuevo.BackColor = Color.Gainsboro;
            btn_nuevo.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_nuevo.Image = (Image)resources.GetObject("btn_nuevo.Image");
            btn_nuevo.Location = new Point(55, 48);
            btn_nuevo.Name = "btn_nuevo";
            btn_nuevo.Size = new Size(75, 23);
            btn_nuevo.TabIndex = 1;
            btn_nuevo.Text = "Nuevo";
            btn_nuevo.UseVisualStyleBackColor = false;
            btn_nuevo.Click += btn_nuevo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightSkyBlue;
            pictureBox1.Location = new Point(17, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(805, 37);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btn_busca_cli);
            tabPage2.Controls.Add(txt_dato_buscar);
            tabPage2.Controls.Add(grid_lista_clientes);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(849, 437);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Listado";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_busca_cli
            // 
            btn_busca_cli.Location = new Point(261, 21);
            btn_busca_cli.Name = "btn_busca_cli";
            btn_busca_cli.Size = new Size(75, 23);
            btn_busca_cli.TabIndex = 2;
            btn_busca_cli.Text = "Buscar";
            btn_busca_cli.UseVisualStyleBackColor = true;
            btn_busca_cli.Click += btn_busca_cli_Click;
            // 
            // txt_dato_buscar
            // 
            txt_dato_buscar.Location = new Point(6, 21);
            txt_dato_buscar.Name = "txt_dato_buscar";
            txt_dato_buscar.Size = new Size(230, 23);
            txt_dato_buscar.TabIndex = 1;
            // 
            // grid_lista_clientes
            // 
            grid_lista_clientes.AllowUserToAddRows = false;
            grid_lista_clientes.AllowUserToDeleteRows = false;
            grid_lista_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_lista_clientes.Columns.AddRange(new DataGridViewColumn[] { seleccionar });
            grid_lista_clientes.Location = new Point(3, 60);
            grid_lista_clientes.Name = "grid_lista_clientes";
            grid_lista_clientes.ReadOnly = true;
            grid_lista_clientes.RowTemplate.Height = 25;
            grid_lista_clientes.Size = new Size(840, 374);
            grid_lista_clientes.TabIndex = 0;
            grid_lista_clientes.CellContentClick += grid_lista_clientes_CellContentClick;
            // 
            // seleccionar
            // 
            seleccionar.HeaderText = "#";
            seleccionar.Name = "seleccionar";
            seleccionar.ReadOnly = true;
            seleccionar.SortMode = DataGridViewColumnSortMode.Programmatic;
            seleccionar.Text = "Seleccionar";
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(849, 437);
            tabPage3.TabIndex = 2;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(849, 437);
            tabPage4.TabIndex = 3;
            // 
            // txt_saldo_cli
            // 
            txt_saldo_cli.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_saldo_cli.Location = new Point(717, 161);
            txt_saldo_cli.Name = "txt_saldo_cli";
            txt_saldo_cli.Size = new Size(105, 23);
            txt_saldo_cli.TabIndex = 31;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(639, 168);
            label10.Name = "label10";
            label10.Size = new Size(47, 16);
            label10.TabIndex = 32;
            label10.Text = "Saldo ";
            // 
            // Frm_clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 489);
            Controls.Add(Locales);
            Name = "Frm_clientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_clientes";
            Load += Frm_clientes_Load;
            Locales.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid_lista_clientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TabControl Locales;
        private TabPage tabPage1;
        private PictureBox pictureBox1;
        private TabPage tabPage2;
        private Button btn_nuevo;
        private Button btn_eliminar;
        private Button btn_editar;
        private Button btn_grabar;
        private PictureBox pictureBox2;
        private Button btn_buscar;
        private TextBox txt_codigo;
        private Label label1;
        private Label label2;
        private TextBox txt_telefono;
        private TextBox txt_direccion;
        private TextBox txt_nombre;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox txt_correo;
        private Label label5;
        private ComboBox cmb_genero;
        private Label label7;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button btn_cancelar;
        private Button btn_busca_cli;
        private TextBox txt_dato_buscar;
        private DataGridView grid_lista_clientes;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private Label label9;
        private DataGridViewButtonColumn seleccionar;
        private Label label10;
        private TextBox txt_saldo_cli;
    }
}