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
            Locales = new TabControl();
            tabPage1 = new TabPage();
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
            panel1 = new Panel();
            label10 = new Label();
            txt_clave = new TextBox();
            checkBox1 = new CheckBox();
            label12 = new Label();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            Locales.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_lista_clientes).BeginInit();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(649, 408);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // Locales
            // 
            Locales.Controls.Add(tabPage1);
            Locales.Controls.Add(tabPage2);
            Locales.Location = new Point(12, 44);
            Locales.Name = "Locales";
            Locales.SelectedIndex = 0;
            Locales.Size = new Size(625, 356);
            Locales.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.WhiteSmoke;
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
            tabPage1.Controls.Add(btn_buscar);
            tabPage1.Controls.Add(btn_eliminar);
            tabPage1.Controls.Add(btn_editar);
            tabPage1.Controls.Add(btn_grabar);
            tabPage1.Controls.Add(btn_nuevo);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(617, 328);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registro";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Gainsboro;
            label11.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(58, 246);
            label11.Name = "label11";
            label11.Size = new Size(55, 16);
            label11.TabIndex = 33;
            label11.Text = "Correo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Gainsboro;
            label7.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(58, 174);
            label7.Name = "label7";
            label7.Size = new Size(59, 16);
            label7.TabIndex = 31;
            label7.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gainsboro;
            label3.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(58, 138);
            label3.Name = "label3";
            label3.Size = new Size(56, 16);
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
            btn_cancelar.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelar.Location = new Point(254, 16);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(81, 39);
            btn_cancelar.TabIndex = 24;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Gainsboro;
            radioButton2.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(186, 80);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(73, 20);
            radioButton2.TabIndex = 20;
            radioButton2.TabStop = true;
            radioButton2.Text = "Usuario";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Gainsboro;
            radioButton1.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(58, 80);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(112, 20);
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
            txt_correo.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_correo.Location = new Point(154, 243);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(232, 23);
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
            txt_nombre.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nombre.Location = new Point(154, 168);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(388, 23);
            txt_nombre.TabIndex = 10;
            // 
            // txt_codigo
            // 
            txt_codigo.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_codigo.Location = new Point(154, 132);
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(152, 23);
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
            pictureBox3.Location = new Point(6, 111);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(605, 193);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Gainsboro;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(6, 68);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(605, 38);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // btn_buscar
            // 
            btn_buscar.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_buscar.Location = new Point(418, 15);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(75, 39);
            btn_buscar.TabIndex = 5;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_eliminar.Location = new Point(339, 16);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(75, 39);
            btn_eliminar.TabIndex = 4;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            btn_editar.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_editar.Location = new Point(176, 16);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(75, 39);
            btn_editar.TabIndex = 3;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_grabar
            // 
            btn_grabar.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_grabar.Location = new Point(97, 15);
            btn_grabar.Name = "btn_grabar";
            btn_grabar.Size = new Size(75, 39);
            btn_grabar.TabIndex = 2;
            btn_grabar.Text = "Grabar";
            btn_grabar.UseVisualStyleBackColor = true;
            // 
            // btn_nuevo
            // 
            btn_nuevo.BackColor = Color.Gainsboro;
            btn_nuevo.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_nuevo.Location = new Point(16, 15);
            btn_nuevo.Name = "btn_nuevo";
            btn_nuevo.Size = new Size(75, 39);
            btn_nuevo.TabIndex = 1;
            btn_nuevo.Text = "Nuevo";
            btn_nuevo.UseVisualStyleBackColor = false;
            btn_nuevo.Click += btn_nuevo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightSteelBlue;
            pictureBox1.Location = new Point(6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(605, 56);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btn_busca_cli);
            tabPage2.Controls.Add(txt_dato_buscar);
            tabPage2.Controls.Add(grid_lista_clientes);
            tabPage2.Controls.Add(panel1);
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
            btn_busca_cli.Location = new Point(292, 21);
            btn_busca_cli.Name = "btn_busca_cli";
            btn_busca_cli.Size = new Size(75, 23);
            btn_busca_cli.TabIndex = 2;
            btn_busca_cli.Text = "Buscar";
            btn_busca_cli.UseVisualStyleBackColor = true;
            // 
            // txt_dato_buscar
            // 
            txt_dato_buscar.Location = new Point(37, 21);
            txt_dato_buscar.Name = "txt_dato_buscar";
            txt_dato_buscar.Size = new Size(230, 23);
            txt_dato_buscar.TabIndex = 1;
            // 
            // grid_lista_clientes
            // 
            grid_lista_clientes.AllowUserToAddRows = false;
            grid_lista_clientes.AllowUserToDeleteRows = false;
            grid_lista_clientes.BackgroundColor = Color.Gainsboro;
            grid_lista_clientes.BorderStyle = BorderStyle.Fixed3D;
            grid_lista_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_lista_clientes.Columns.AddRange(new DataGridViewColumn[] { seleccionar });
            grid_lista_clientes.Location = new Point(6, 60);
            grid_lista_clientes.Name = "grid_lista_clientes";
            grid_lista_clientes.ReadOnly = true;
            grid_lista_clientes.RowTemplate.Height = 25;
            grid_lista_clientes.Size = new Size(849, 358);
            grid_lista_clientes.TabIndex = 0;
            // 
            // seleccionar
            // 
            seleccionar.HeaderText = "#";
            seleccionar.Name = "seleccionar";
            seleccionar.ReadOnly = true;
            seleccionar.SortMode = DataGridViewColumnSortMode.Programmatic;
            seleccionar.Text = "Seleccionar";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Location = new Point(6, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(849, 43);
            panel1.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Gainsboro;
            label10.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(58, 206);
            label10.Name = "label10";
            label10.Size = new Size(47, 16);
            label10.TabIndex = 34;
            label10.Text = "Clave:";
            // 
            // txt_clave
            // 
            txt_clave.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_clave.Location = new Point(154, 203);
            txt_clave.Name = "txt_clave";
            txt_clave.Size = new Size(152, 23);
            txt_clave.TabIndex = 35;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(154, 277);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(60, 19);
            checkBox1.TabIndex = 36;
            checkBox1.Text = "Activo";
            checkBox1.UseVisualStyleBackColor = true;
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
            label13.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(251, 9);
            label13.Name = "label13";
            label13.Size = new Size(138, 29);
            label13.TabIndex = 37;
            label13.Text = "USUARIOS";
            // 
            // Frm_usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 408);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(Locales);
            Controls.Add(pictureBox4);
            Name = "Frm_usuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_usuarios";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
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
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox4;
        private TabControl Locales;
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
        private Button btn_buscar;
        private Button btn_eliminar;
        private Button btn_editar;
        private Button btn_grabar;
        private Button btn_nuevo;
        private PictureBox pictureBox1;
        private TabPage tabPage2;
        private Button btn_busca_cli;
        private TextBox txt_dato_buscar;
        private DataGridView grid_lista_clientes;
        private DataGridViewButtonColumn seleccionar;
        private Panel panel1;
        private CheckBox checkBox1;
        private TextBox txt_clave;
        private Label label10;
        private Label label12;
        private Label label13;
    }
}