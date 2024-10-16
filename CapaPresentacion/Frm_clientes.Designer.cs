namespace CapaPresentacion
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
            Locales = new TabControl();
            tabPage2 = new TabPage();
            btn_busca_cli = new Button();
            txt_dato_buscar = new TextBox();
            grid_lista_clientes = new DataGridView();
            seleccionar = new DataGridViewButtonColumn();
            pictureBox1 = new PictureBox();
            btn_nuevo = new Button();
            btn_grabar = new Button();
            btn_editar = new Button();
            btn_eliminar = new Button();
            btn_buscar = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            txt_codigo = new TextBox();
            txt_nombre = new TextBox();
            txt_direccion = new TextBox();
            txt_telefono = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_correo = new TextBox();
            label6 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            cmb_genero = new ComboBox();
            btn_cancelar = new Button();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            tabPage1 = new TabPage();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            label7 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            Locales.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_lista_clientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // Locales
            // 
            Locales.Controls.Add(tabPage1);
            Locales.Controls.Add(tabPage2);
            Locales.Location = new Point(28, 75);
            Locales.Name = "Locales";
            Locales.SelectedIndex = 0;
            Locales.Size = new Size(869, 452);
            Locales.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btn_busca_cli);
            tabPage2.Controls.Add(txt_dato_buscar);
            tabPage2.Controls.Add(grid_lista_clientes);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(861, 424);
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
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightSteelBlue;
            pictureBox1.Location = new Point(6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(849, 56);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_nuevo
            // 
            btn_nuevo.BackColor = Color.Gainsboro;
            btn_nuevo.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_nuevo.Location = new Point(55, 15);
            btn_nuevo.Name = "btn_nuevo";
            btn_nuevo.Size = new Size(75, 39);
            btn_nuevo.TabIndex = 1;
            btn_nuevo.Text = "Nuevo";
            btn_nuevo.UseVisualStyleBackColor = false;
            btn_nuevo.Click += btn_nuevo_Click;
            // 
            // btn_grabar
            // 
            btn_grabar.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_grabar.Location = new Point(154, 15);
            btn_grabar.Name = "btn_grabar";
            btn_grabar.Size = new Size(75, 39);
            btn_grabar.TabIndex = 2;
            btn_grabar.Text = "Grabar";
            btn_grabar.UseVisualStyleBackColor = true;
            btn_grabar.Click += btn_grabar_Click;
            // 
            // btn_editar
            // 
            btn_editar.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_editar.Location = new Point(252, 15);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(75, 39);
            btn_editar.TabIndex = 3;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_eliminar.Location = new Point(458, 15);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(75, 39);
            btn_eliminar.TabIndex = 4;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            btn_buscar.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_buscar.Location = new Point(557, 15);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(75, 39);
            btn_buscar.TabIndex = 5;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Gainsboro;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(6, 68);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(849, 38);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Gainsboro;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(6, 111);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(849, 307);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
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
            // txt_codigo
            // 
            txt_codigo.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_codigo.Location = new Point(154, 132);
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(152, 23);
            txt_codigo.TabIndex = 9;
            txt_codigo.TextChanged += txt_codigo_TextChanged;
            // 
            // txt_nombre
            // 
            txt_nombre.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nombre.Location = new Point(154, 168);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(388, 23);
            txt_nombre.TabIndex = 10;
            // 
            // txt_direccion
            // 
            txt_direccion.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_direccion.Location = new Point(154, 204);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(388, 23);
            txt_direccion.TabIndex = 11;
            // 
            // txt_telefono
            // 
            txt_telefono.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_telefono.Location = new Point(154, 238);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(152, 23);
            txt_telefono.TabIndex = 12;
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
            label2.Click += label2_Click;
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
            // txt_correo
            // 
            txt_correo.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_correo.Location = new Point(154, 274);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(232, 23);
            txt_correo.TabIndex = 17;
            txt_correo.TextChanged += textBox4_TextChanged;
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
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Gainsboro;
            radioButton1.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(55, 77);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(70, 20);
            radioButton1.TabIndex = 19;
            radioButton1.TabStop = true;
            radioButton1.Text = "Cedula";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Gainsboro;
            radioButton2.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(154, 77);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(50, 20);
            radioButton2.TabIndex = 20;
            radioButton2.TabStop = true;
            radioButton2.Text = "Ruc";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.BackColor = Color.Gainsboro;
            radioButton3.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.Location = new Point(252, 75);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(104, 24);
            radioButton3.TabIndex = 26;
            radioButton3.Text = "Pasaporte";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // cmb_genero
            // 
            cmb_genero.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_genero.FormattingEnabled = true;
            cmb_genero.Items.AddRange(new object[] { "MASCULINO", "FEMENINO", "OTROS" });
            cmb_genero.Location = new Point(154, 311);
            cmb_genero.Name = "cmb_genero";
            cmb_genero.Size = new Size(152, 24);
            cmb_genero.TabIndex = 23;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelar.Location = new Point(352, 15);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(81, 39);
            btn_cancelar.TabIndex = 24;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.ImeMode = ImeMode.NoControl;
            dateTimePicker1.Location = new Point(154, 349);
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
            label8.BackColor = Color.Gainsboro;
            label8.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(63, 319);
            label8.Name = "label8";
            label8.Size = new Size(0, 16);
            label8.TabIndex = 28;
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
            // tabPage1
            // 
            tabPage1.BackColor = Color.WhiteSmoke;
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
            tabPage1.Controls.Add(btn_buscar);
            tabPage1.Controls.Add(btn_eliminar);
            tabPage1.Controls.Add(btn_editar);
            tabPage1.Controls.Add(btn_grabar);
            tabPage1.Controls.Add(btn_nuevo);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(861, 424);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registro";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gainsboro;
            label3.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(55, 135);
            label3.Name = "label3";
            label3.Size = new Size(56, 16);
            label3.TabIndex = 2;
            label3.Text = "Código:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Gainsboro;
            label7.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(55, 171);
            label7.Name = "label7";
            label7.Size = new Size(55, 16);
            label7.TabIndex = 31;
            label7.Text = "Cliente:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Gainsboro;
            label10.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(55, 207);
            label10.Name = "label10";
            label10.Size = new Size(70, 16);
            label10.TabIndex = 32;
            label10.Text = "Dirección:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Gainsboro;
            label11.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(55, 277);
            label11.Name = "label11";
            label11.Size = new Size(55, 16);
            label11.TabIndex = 33;
            label11.Text = "Correo:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Gainsboro;
            label12.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(55, 241);
            label12.Name = "label12";
            label12.Size = new Size(65, 16);
            label12.TabIndex = 34;
            label12.Text = "Teléfono:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Gainsboro;
            label13.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(55, 314);
            label13.Name = "label13";
            label13.Size = new Size(59, 16);
            label13.TabIndex = 35;
            label13.Text = "Género:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Gainsboro;
            label14.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(55, 354);
            label14.Name = "label14";
            label14.Size = new Size(82, 16);
            label14.TabIndex = 36;
            label14.Text = "Fecha nac.:";
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
            Controls.Add(Locales);
            Controls.Add(pictureBox4);
            Name = "Frm_clientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_clientes";
            Load += Frm_clientes_Load;
            Locales.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid_lista_clientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl Locales;
        private TabPage tabPage2;
        private Button btn_busca_cli;
        private TextBox txt_dato_buscar;
        private DataGridView grid_lista_clientes;
        private DataGridViewButtonColumn seleccionar;
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
        private Button btn_buscar;
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
    }
}