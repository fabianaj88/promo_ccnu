namespace CapaPresentacion
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            label1 = new Label();
            txt_usuario = new TextBox();
            label2 = new Label();
            txt_password = new TextBox();
            btn_cancelar = new Button();
            btn_aceptar = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btn_conf = new Button();
            toolTip1 = new ToolTip(components);
            btn_close = new Button();
            pan_conf = new Panel();
            btn_canconf = new Button();
            btn_guardarconf = new Button();
            txt_bd = new TextBox();
            txt_serv = new TextBox();
            label4 = new Label();
            label3 = new Label();
            pan_ini = new Panel();
            pan_clavconf = new Panel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            txt_claveconf = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pan_conf.SuspendLayout();
            pan_ini.SuspendLayout();
            pan_clavconf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(53, 269);
            label1.Name = "label1";
            label1.Size = new Size(59, 16);
            label1.TabIndex = 2;
            label1.Text = "Usuario:";
            // 
            // txt_usuario
            // 
            txt_usuario.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_usuario.Location = new Point(153, 262);
            txt_usuario.MaxLength = 3;
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(138, 22);
            txt_usuario.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gainsboro;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(53, 304);
            label2.Name = "label2";
            label2.Size = new Size(83, 16);
            label2.TabIndex = 4;
            label2.Text = "Contraseña:";
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_password.Location = new Point(153, 297);
            txt_password.MaxLength = 10;
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(138, 22);
            txt_password.TabIndex = 5;
            txt_password.UseSystemPasswordChar = true;
            txt_password.TextChanged += txt_password_TextChanged;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = SystemColors.ActiveCaption;
            btn_cancelar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cancelar.Location = new Point(182, 348);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.RightToLeft = RightToLeft.No;
            btn_cancelar.Size = new Size(109, 33);
            btn_cancelar.TabIndex = 6;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_aceptar
            // 
            btn_aceptar.BackColor = SystemColors.ActiveCaption;
            btn_aceptar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_aceptar.Location = new Point(53, 348);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.RightToLeft = RightToLeft.No;
            btn_aceptar.Size = new Size(102, 33);
            btn_aceptar.TabIndex = 7;
            btn_aceptar.Text = "Inicio";
            btn_aceptar.UseVisualStyleBackColor = false;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Gainsboro;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(53, 41);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(238, 199);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(923, 545);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // btn_conf
            // 
            btn_conf.BackColor = Color.Gainsboro;
            btn_conf.Image = (Image)resources.GetObject("btn_conf.Image");
            btn_conf.Location = new Point(12, 498);
            btn_conf.Name = "btn_conf";
            btn_conf.Size = new Size(37, 35);
            btn_conf.TabIndex = 9;
            toolTip1.SetToolTip(btn_conf, "Configuración");
            btn_conf.UseVisualStyleBackColor = false;
            btn_conf.Click += btn_conf_Click;
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.Silver;
            btn_close.Image = (Image)resources.GetObject("btn_close.Image");
            btn_close.Location = new Point(356, 3);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(30, 26);
            btn_close.TabIndex = 4;
            toolTip1.SetToolTip(btn_close, "Salir");
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // pan_conf
            // 
            pan_conf.BackColor = Color.Gainsboro;
            pan_conf.Controls.Add(btn_canconf);
            pan_conf.Controls.Add(btn_guardarconf);
            pan_conf.Controls.Add(txt_bd);
            pan_conf.Controls.Add(txt_serv);
            pan_conf.Controls.Add(label4);
            pan_conf.Controls.Add(label3);
            pan_conf.Location = new Point(282, 170);
            pan_conf.Name = "pan_conf";
            pan_conf.Size = new Size(374, 181);
            pan_conf.TabIndex = 10;
            pan_conf.Visible = false;
            // 
            // btn_canconf
            // 
            btn_canconf.BackColor = Color.LightSteelBlue;
            btn_canconf.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_canconf.Location = new Point(181, 121);
            btn_canconf.Name = "btn_canconf";
            btn_canconf.Size = new Size(75, 32);
            btn_canconf.TabIndex = 5;
            btn_canconf.Text = "Cancelar";
            btn_canconf.UseVisualStyleBackColor = false;
            btn_canconf.Click += btn_canconf_Click;
            // 
            // btn_guardarconf
            // 
            btn_guardarconf.BackColor = Color.LightSteelBlue;
            btn_guardarconf.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_guardarconf.Location = new Point(70, 121);
            btn_guardarconf.Name = "btn_guardarconf";
            btn_guardarconf.Size = new Size(75, 32);
            btn_guardarconf.TabIndex = 4;
            btn_guardarconf.Text = "Guardar";
            btn_guardarconf.UseVisualStyleBackColor = false;
            btn_guardarconf.Click += btn_guardarconf_Click;
            // 
            // txt_bd
            // 
            txt_bd.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_bd.Location = new Point(151, 77);
            txt_bd.Name = "txt_bd";
            txt_bd.Size = new Size(141, 22);
            txt_bd.TabIndex = 3;
            // 
            // txt_serv
            // 
            txt_serv.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_serv.Location = new Point(151, 39);
            txt_serv.Name = "txt_serv";
            txt_serv.Size = new Size(141, 22);
            txt_serv.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(36, 79);
            label4.Name = "label4";
            label4.Size = new Size(101, 16);
            label4.TabIndex = 1;
            label4.Text = "Base de Datos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(36, 41);
            label3.Name = "label3";
            label3.Size = new Size(65, 16);
            label3.TabIndex = 0;
            label3.Text = "Servidor:";
            // 
            // pan_ini
            // 
            pan_ini.BackColor = Color.Gainsboro;
            pan_ini.Controls.Add(pictureBox2);
            pan_ini.Controls.Add(txt_usuario);
            pan_ini.Controls.Add(label1);
            pan_ini.Controls.Add(btn_aceptar);
            pan_ini.Controls.Add(label2);
            pan_ini.Controls.Add(btn_cancelar);
            pan_ini.Controls.Add(txt_password);
            pan_ini.Location = new Point(299, 60);
            pan_ini.Name = "pan_ini";
            pan_ini.Size = new Size(341, 426);
            pan_ini.TabIndex = 11;
            // 
            // pan_clavconf
            // 
            pan_clavconf.BackColor = Color.Gainsboro;
            pan_clavconf.Controls.Add(btn_close);
            pan_clavconf.Controls.Add(label6);
            pan_clavconf.Controls.Add(pictureBox1);
            pan_clavconf.Controls.Add(txt_claveconf);
            pan_clavconf.Controls.Add(label5);
            pan_clavconf.Enabled = false;
            pan_clavconf.Location = new Point(277, 209);
            pan_clavconf.Name = "pan_clavconf";
            pan_clavconf.Size = new Size(389, 152);
            pan_clavconf.TabIndex = 12;
            pan_clavconf.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(93, 84);
            label6.Name = "label6";
            label6.Size = new Size(194, 16);
            label6.TabIndex = 3;
            label6.Text = "Ingrese la clave de configuración";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(161, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // txt_claveconf
            // 
            txt_claveconf.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_claveconf.Location = new Point(151, 109);
            txt_claveconf.Name = "txt_claveconf";
            txt_claveconf.Size = new Size(131, 22);
            txt_claveconf.TabIndex = 1;
            txt_claveconf.UseSystemPasswordChar = true;
            txt_claveconf.KeyDown += txt_claveconf_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(92, 115);
            label5.Name = "label5";
            label5.Size = new Size(47, 16);
            label5.TabIndex = 0;
            label5.Text = "Clave:";
            // 
            // Frm_Login
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            ClientSize = new Size(923, 545);
            Controls.Add(pan_clavconf);
            Controls.Add(pan_ini);
            Controls.Add(pan_conf);
            Controls.Add(btn_conf);
            Controls.Add(pictureBox3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_Login";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Login";
            Load += Frm_Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pan_conf.ResumeLayout(false);
            pan_conf.PerformLayout();
            pan_ini.ResumeLayout(false);
            pan_ini.PerformLayout();
            pan_clavconf.ResumeLayout(false);
            pan_clavconf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private TextBox txt_usuario;
        private Label label2;
        private TextBox txt_password;
        private Button btn_cancelar;
        private Button btn_aceptar;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btn_conf;
        private ToolTip toolTip1;
        private Panel pan_conf;
        private Label label4;
        private Label label3;
        private TextBox txt_bd;
        private TextBox txt_serv;
        private Button btn_canconf;
        private Button btn_guardarconf;
        private Panel pan_ini;
        private Panel pan_clavconf;
        private TextBox txt_claveconf;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label6;
        private Button btn_close;
    }
}