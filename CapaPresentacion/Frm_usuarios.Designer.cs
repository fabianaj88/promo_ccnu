namespace CapaPresentacion
{
    partial class Frm_usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_usuarios));
            pictureBox4 = new PictureBox();
            page_datos = new TabControl();
            tabPage1 = new TabPage();
            chk_reportes = new CheckBox();
            chk_promo = new CheckBox();
            chk_clientes = new CheckBox();
            chk_documentos = new CheckBox();
            chk_usuarios = new CheckBox();
            label14 = new Label();
            pictureBox5 = new PictureBox();
            checkBox1 = new CheckBox();
            txt_clave = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label7 = new Label();
            label3 = new Label();
            label9 = new Label();
            label8 = new Label();
            btn_cancelar = new Button();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label6 = new Label();
            txt_correo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
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
            grid_lista_usuarios = new DataGridView();
            seleccionar = new DataGridViewButtonColumn();
            panel1 = new Panel();
            btn_busca_usu = new Button();
            txt_dato_buscar = new TextBox();
            label12 = new Label();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            page_datos.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_lista_usuarios).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(923, 545);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // page_datos
            // 
            page_datos.Controls.Add(tabPage1);
            page_datos.Controls.Add(tabPage2);
            page_datos.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            page_datos.Location = new Point(38, 61);
            page_datos.Name = "page_datos";
            page_datos.SelectedIndex = 0;
            page_datos.Size = new Size(845, 459);
            page_datos.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.WhiteSmoke;
            tabPage1.Controls.Add(chk_reportes);
            tabPage1.Controls.Add(chk_promo);
            tabPage1.Controls.Add(chk_clientes);
            tabPage1.Controls.Add(chk_documentos);
            tabPage1.Controls.Add(chk_usuarios);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(pictureBox5);
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Controls.Add(txt_clave);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(btn_cancelar);
            tabPage1.Controls.Add(radioButton2);
            tabPage1.Controls.Add(radioButton1);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txt_correo);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label2);
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
            tabPage1.Size = new Size(837, 430);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registro";
            // 
            // chk_reportes
            // 
            chk_reportes.AutoSize = true;
            chk_reportes.BackColor = Color.Gainsboro;
            chk_reportes.FlatStyle = FlatStyle.Popup;
            chk_reportes.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            chk_reportes.Location = new Point(647, 360);
            chk_reportes.Name = "chk_reportes";
            chk_reportes.Size = new Size(76, 20);
            chk_reportes.TabIndex = 43;
            chk_reportes.Text = "Reportes";
            chk_reportes.UseVisualStyleBackColor = false;
            // 
            // chk_promo
            // 
            chk_promo.AutoSize = true;
            chk_promo.BackColor = Color.Gainsboro;
            chk_promo.FlatStyle = FlatStyle.Popup;
            chk_promo.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            chk_promo.Location = new Point(502, 362);
            chk_promo.Name = "chk_promo";
            chk_promo.Size = new Size(86, 20);
            chk_promo.TabIndex = 42;
            chk_promo.Text = "Campañas";
            chk_promo.UseVisualStyleBackColor = false;
            // 
            // chk_clientes
            // 
            chk_clientes.AutoSize = true;
            chk_clientes.BackColor = Color.Gainsboro;
            chk_clientes.FlatStyle = FlatStyle.Popup;
            chk_clientes.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            chk_clientes.Location = new Point(365, 362);
            chk_clientes.Name = "chk_clientes";
            chk_clientes.Size = new Size(71, 20);
            chk_clientes.TabIndex = 41;
            chk_clientes.Text = "Clientes";
            chk_clientes.UseVisualStyleBackColor = false;
            // 
            // chk_documentos
            // 
            chk_documentos.AutoSize = true;
            chk_documentos.BackColor = Color.Gainsboro;
            chk_documentos.FlatStyle = FlatStyle.Popup;
            chk_documentos.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            chk_documentos.Location = new Point(205, 361);
            chk_documentos.Name = "chk_documentos";
            chk_documentos.Size = new Size(97, 20);
            chk_documentos.TabIndex = 40;
            chk_documentos.Text = "Documentos";
            chk_documentos.UseVisualStyleBackColor = false;
            // 
            // chk_usuarios
            // 
            chk_usuarios.AutoSize = true;
            chk_usuarios.BackColor = Color.Gainsboro;
            chk_usuarios.FlatStyle = FlatStyle.Popup;
            chk_usuarios.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            chk_usuarios.Location = new Point(81, 360);
            chk_usuarios.Name = "chk_usuarios";
            chk_usuarios.Size = new Size(75, 20);
            chk_usuarios.TabIndex = 39;
            chk_usuarios.Text = "Usuarios";
            chk_usuarios.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Gainsboro;
            label14.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(360, 321);
            label14.Name = "label14";
            label14.Size = new Size(94, 19);
            label14.TabIndex = 38;
            label14.Text = "PERMISOS";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Gainsboro;
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.Location = new Point(6, 294);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(825, 129);
            pictureBox5.TabIndex = 37;
            pictureBox5.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Gainsboro;
            checkBox1.FlatStyle = FlatStyle.Popup;
            checkBox1.Location = new Point(577, 135);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(59, 20);
            checkBox1.TabIndex = 36;
            checkBox1.Text = "Activo";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // txt_clave
            // 
            txt_clave.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_clave.Location = new Point(154, 205);
            txt_clave.MaxLength = 15;
            txt_clave.Name = "txt_clave";
            txt_clave.Size = new Size(152, 22);
            txt_clave.TabIndex = 35;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Gainsboro;
            label10.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(58, 208);
            label10.Name = "label10";
            label10.Size = new Size(42, 16);
            label10.TabIndex = 34;
            label10.Text = "Clave:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Gainsboro;
            label11.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(58, 248);
            label11.Name = "label11";
            label11.Size = new Size(49, 16);
            label11.TabIndex = 33;
            label11.Text = "Correo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Gainsboro;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(58, 176);
            label7.Name = "label7";
            label7.Size = new Size(55, 16);
            label7.TabIndex = 31;
            label7.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gainsboro;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(58, 140);
            label3.Name = "label3";
            label3.Size = new Size(51, 16);
            label3.TabIndex = 2;
            label3.Text = "Código:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Gainsboro;
            label9.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(66, 357);
            label9.Name = "label9";
            label9.Size = new Size(0, 16);
            label9.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Gainsboro;
            label8.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(66, 322);
            label8.Name = "label8";
            label8.Size = new Size(0, 16);
            label8.TabIndex = 28;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelar.Image = (Image)resources.GetObject("btn_cancelar.Image");
            btn_cancelar.Location = new Point(443, 16);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(112, 35);
            btn_cancelar.TabIndex = 24;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Gainsboro;
            radioButton2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(186, 75);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(69, 20);
            radioButton2.TabIndex = 20;
            radioButton2.TabStop = true;
            radioButton2.Text = "Usuario";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Gainsboro;
            radioButton1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(58, 75);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(105, 20);
            radioButton1.TabIndex = 19;
            radioButton1.TabStop = true;
            radioButton1.Text = "Administrador";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Gainsboro;
            label6.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(66, 277);
            label6.Name = "label6";
            label6.Size = new Size(0, 16);
            label6.TabIndex = 18;
            // 
            // txt_correo
            // 
            txt_correo.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_correo.Location = new Point(154, 245);
            txt_correo.MaxLength = 30;
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(232, 22);
            txt_correo.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gainsboro;
            label5.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(66, 243);
            label5.Name = "label5";
            label5.Size = new Size(0, 16);
            label5.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Gainsboro;
            label4.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(66, 206);
            label4.Name = "label4";
            label4.Size = new Size(0, 16);
            label4.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gainsboro;
            label2.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(66, 170);
            label2.Name = "label2";
            label2.Size = new Size(0, 16);
            label2.TabIndex = 13;
            // 
            // txt_nombre
            // 
            txt_nombre.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nombre.Location = new Point(154, 170);
            txt_nombre.MaxLength = 50;
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(401, 22);
            txt_nombre.TabIndex = 10;
            // 
            // txt_codigo
            // 
            txt_codigo.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_codigo.Location = new Point(154, 134);
            txt_codigo.MaxLength = 3;
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(152, 22);
            txt_codigo.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(66, 137);
            label1.Name = "label1";
            label1.Size = new Size(0, 16);
            label1.TabIndex = 8;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Gainsboro;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(6, 112);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(825, 177);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Gainsboro;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(6, 63);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(825, 44);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // btn_editar
            // 
            btn_editar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_editar.Image = (Image)resources.GetObject("btn_editar.Image");
            btn_editar.Location = new Point(315, 16);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(112, 35);
            btn_editar.TabIndex = 3;
            btn_editar.Text = "Editar";
            btn_editar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // btn_grabar
            // 
            btn_grabar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_grabar.Image = (Image)resources.GetObject("btn_grabar.Image");
            btn_grabar.Location = new Point(186, 16);
            btn_grabar.Name = "btn_grabar";
            btn_grabar.Size = new Size(112, 35);
            btn_grabar.TabIndex = 2;
            btn_grabar.Text = "Grabar";
            btn_grabar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_grabar.UseVisualStyleBackColor = true;
            btn_grabar.Click += btn_grabar_Click;
            // 
            // btn_nuevo
            // 
            btn_nuevo.BackColor = Color.Gainsboro;
            btn_nuevo.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_nuevo.Image = (Image)resources.GetObject("btn_nuevo.Image");
            btn_nuevo.Location = new Point(58, 16);
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
            pictureBox1.Location = new Point(6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(825, 53);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(grid_lista_usuarios);
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 25);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(837, 430);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Listado";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // grid_lista_usuarios
            // 
            grid_lista_usuarios.AllowUserToAddRows = false;
            grid_lista_usuarios.AllowUserToDeleteRows = false;
            grid_lista_usuarios.BackgroundColor = Color.Gainsboro;
            grid_lista_usuarios.BorderStyle = BorderStyle.Fixed3D;
            grid_lista_usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_lista_usuarios.Columns.AddRange(new DataGridViewColumn[] { seleccionar });
            grid_lista_usuarios.Location = new Point(6, 60);
            grid_lista_usuarios.Name = "grid_lista_usuarios";
            grid_lista_usuarios.ReadOnly = true;
            grid_lista_usuarios.RowTemplate.Height = 25;
            grid_lista_usuarios.Size = new Size(825, 364);
            grid_lista_usuarios.TabIndex = 0;
            grid_lista_usuarios.CellContentClick += grid_lista_clientes_CellContentClick;
            // 
            // seleccionar
            // 
            seleccionar.FlatStyle = FlatStyle.Popup;
            seleccionar.HeaderText = "#";
            seleccionar.Name = "seleccionar";
            seleccionar.ReadOnly = true;
            seleccionar.SortMode = DataGridViewColumnSortMode.Programmatic;
            seleccionar.Text = "Seleccionar";
            seleccionar.ToolTipText = "Seleccionar fila";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(btn_busca_usu);
            panel1.Controls.Add(txt_dato_buscar);
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(827, 47);
            panel1.TabIndex = 3;
            // 
            // btn_busca_usu
            // 
            btn_busca_usu.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_busca_usu.Image = (Image)resources.GetObject("btn_busca_usu.Image");
            btn_busca_usu.ImageAlign = ContentAlignment.MiddleRight;
            btn_busca_usu.Location = new Point(328, 6);
            btn_busca_usu.Name = "btn_busca_usu";
            btn_busca_usu.Size = new Size(112, 35);
            btn_busca_usu.TabIndex = 2;
            btn_busca_usu.Text = "Buscar";
            btn_busca_usu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_busca_usu.UseVisualStyleBackColor = true;
            btn_busca_usu.Click += btn_busca_usu_Click;
            // 
            // txt_dato_buscar
            // 
            txt_dato_buscar.Location = new Point(42, 12);
            txt_dato_buscar.Name = "txt_dato_buscar";
            txt_dato_buscar.Size = new Size(264, 22);
            txt_dato_buscar.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(651, 412);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 3;
            label12.Text = "label12";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(405, 37);
            label13.Name = "label13";
            label13.Size = new Size(112, 24);
            label13.TabIndex = 37;
            label13.Text = "USUARIOS";
            // 
            // Frm_usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 545);
            Controls.Add(label13);
            Controls.Add(page_datos);
            Controls.Add(pictureBox4);
            Controls.Add(label12);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_usuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_usuarios";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            page_datos.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid_lista_usuarios).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox4;
        private TabControl page_datos;
        private TabPage tabPage1;
        private Label label11;
        private Label label7;
        private Label label3;
        private Label label9;
        private Label label8;
        private Button btn_cancelar;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label6;
        private TextBox txt_correo;
        private Label label5;
        private Label label4;
        private Label label2;
        private TextBox txt_nombre;
        private TextBox txt_codigo;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button btn_editar;
        private Button btn_grabar;
        private Button btn_nuevo;
        private PictureBox pictureBox1;
        private TabPage tabPage2;
        private Button btn_busca_usu;
        private TextBox txt_dato_buscar;
        private DataGridView grid_lista_usuarios;
        private Panel panel1;
        private CheckBox checkBox1;
        private TextBox txt_clave;
        private Label label10;
        private Label label12;
        private Label label13;
        private Label label14;
        private PictureBox pictureBox5;
        private CheckBox chk_promo;
        private CheckBox chk_clientes;
        private CheckBox chk_documentos;
        private CheckBox chk_usuarios;
        private CheckBox chk_reportes;
        private DataGridViewButtonColumn seleccionar;
    }
}