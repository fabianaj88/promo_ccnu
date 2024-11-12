namespace CapaPresentacion
{
    partial class Frm_CrearCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CrearCliente));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            txt_ape = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label7 = new Label();
            label3 = new Label();
            dtp_fecnac = new DateTimePicker();
            cmb_genero = new ComboBox();
            txt_correo = new TextBox();
            txt_telefono = new TextBox();
            txt_direccion = new TextBox();
            txt_nombre = new TextBox();
            txt_codigo = new TextBox();
            btn_cancli = new Button();
            btn_Acepcli = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(559, 328);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(540, 42);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(165, 10);
            label1.Name = "label1";
            label1.Size = new Size(209, 22);
            label1.TabIndex = 0;
            label1.Text = "DATOS DEL CLIENTE";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(6, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(546, 315);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(txt_ape);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(dtp_fecnac);
            panel3.Controls.Add(cmb_genero);
            panel3.Controls.Add(txt_correo);
            panel3.Controls.Add(txt_telefono);
            panel3.Controls.Add(txt_direccion);
            panel3.Controls.Add(txt_nombre);
            panel3.Controls.Add(txt_codigo);
            panel3.Controls.Add(btn_cancli);
            panel3.Controls.Add(btn_Acepcli);
            panel3.Location = new Point(3, 53);
            panel3.Name = "panel3";
            panel3.Size = new Size(540, 259);
            panel3.TabIndex = 0;
            // 
            // txt_ape
            // 
            txt_ape.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ape.Location = new Point(266, 39);
            txt_ape.Name = "txt_ape";
            txt_ape.PlaceholderText = "Apellido";
            txt_ape.Size = new Size(133, 21);
            txt_ape.TabIndex = 51;
            txt_ape.KeyPress += txt_ape_KeyPress;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Gainsboro;
            label14.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(28, 186);
            label14.Name = "label14";
            label14.Size = new Size(70, 15);
            label14.TabIndex = 50;
            label14.Text = "Fecha nac.:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Gainsboro;
            label13.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(28, 153);
            label13.Name = "label13";
            label13.Size = new Size(51, 15);
            label13.TabIndex = 49;
            label13.Text = "Género:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Gainsboro;
            label12.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(28, 97);
            label12.Name = "label12";
            label12.Size = new Size(50, 15);
            label12.TabIndex = 48;
            label12.Text = "Celular:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Gainsboro;
            label11.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(28, 126);
            label11.Name = "label11";
            label11.Size = new Size(48, 15);
            label11.TabIndex = 47;
            label11.Text = "Correo:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Gainsboro;
            label10.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(28, 70);
            label10.Name = "label10";
            label10.Size = new Size(62, 15);
            label10.TabIndex = 46;
            label10.Text = "Dirección:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Gainsboro;
            label7.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(28, 42);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 45;
            label7.Text = "Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gainsboro;
            label3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(28, 14);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 37;
            label3.Text = "Código:";
            // 
            // dtp_fecnac
            // 
            dtp_fecnac.CustomFormat = "";
            dtp_fecnac.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_fecnac.Format = DateTimePickerFormat.Short;
            dtp_fecnac.ImeMode = ImeMode.NoControl;
            dtp_fecnac.Location = new Point(127, 181);
            dtp_fecnac.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            dtp_fecnac.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtp_fecnac.Name = "dtp_fecnac";
            dtp_fecnac.Size = new Size(152, 21);
            dtp_fecnac.TabIndex = 44;
            dtp_fecnac.Value = new DateTime(2024, 10, 23, 0, 0, 0, 0);
            // 
            // cmb_genero
            // 
            cmb_genero.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_genero.FormattingEnabled = true;
            cmb_genero.Items.AddRange(new object[] { "MASCULINO", "FEMENINO", "OTROS" });
            cmb_genero.Location = new Point(127, 150);
            cmb_genero.Name = "cmb_genero";
            cmb_genero.Size = new Size(152, 23);
            cmb_genero.TabIndex = 43;
            // 
            // txt_correo
            // 
            txt_correo.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_correo.Location = new Point(127, 123);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(201, 21);
            txt_correo.TabIndex = 42;
            txt_correo.KeyPress += txt_correo_KeyPress;
            txt_correo.Validating += txt_correo_Validating;
            // 
            // txt_telefono
            // 
            txt_telefono.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_telefono.Location = new Point(127, 94);
            txt_telefono.MaxLength = 10;
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(133, 21);
            txt_telefono.TabIndex = 41;
            txt_telefono.TextChanged += txt_telefono_TextChanged;
            txt_telefono.KeyPress += txt_telefono_KeyPress;
            // 
            // txt_direccion
            // 
            txt_direccion.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_direccion.Location = new Point(127, 67);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(272, 21);
            txt_direccion.TabIndex = 40;
            // 
            // txt_nombre
            // 
            txt_nombre.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nombre.Location = new Point(127, 39);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.PlaceholderText = "Nombre";
            txt_nombre.Size = new Size(133, 21);
            txt_nombre.TabIndex = 39;
            txt_nombre.KeyPress += txt_nombre_KeyPress;
            // 
            // txt_codigo
            // 
            txt_codigo.Enabled = false;
            txt_codigo.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_codigo.Location = new Point(127, 11);
            txt_codigo.Name = "txt_codigo";
            txt_codigo.ReadOnly = true;
            txt_codigo.Size = new Size(133, 21);
            txt_codigo.TabIndex = 38;
            // 
            // btn_cancli
            // 
            btn_cancli.BackColor = Color.LightSteelBlue;
            btn_cancli.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cancli.Location = new Point(299, 220);
            btn_cancli.Name = "btn_cancli";
            btn_cancli.Size = new Size(75, 31);
            btn_cancli.TabIndex = 1;
            btn_cancli.Text = "Cancelar";
            btn_cancli.UseVisualStyleBackColor = false;
            btn_cancli.Click += btn_cancli_Click;
            // 
            // btn_Acepcli
            // 
            btn_Acepcli.BackColor = Color.LightSteelBlue;
            btn_Acepcli.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Acepcli.Location = new Point(150, 220);
            btn_Acepcli.Name = "btn_Acepcli";
            btn_Acepcli.Size = new Size(75, 31);
            btn_Acepcli.TabIndex = 0;
            btn_Acepcli.Text = "Aceptar";
            btn_Acepcli.UseVisualStyleBackColor = false;
            btn_Acepcli.Click += btn_Acepcli_Click;
            // 
            // Frm_CrearCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 328);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_CrearCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_CrearCliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btn_cancli;
        private Button btn_Acepcli;
        private Label label1;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label7;
        private Label label3;
        private DateTimePicker dtp_fecnac;
        private ComboBox cmb_genero;
        private TextBox txt_correo;
        private TextBox txt_telefono;
        private TextBox txt_direccion;
        private TextBox txt_nombre;
        private TextBox txt_codigo;
        private TextBox txt_ape;
        private ComboBox cmb_generoc;
    }
}