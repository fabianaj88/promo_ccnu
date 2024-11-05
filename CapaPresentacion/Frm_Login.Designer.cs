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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txt_usuario = new TextBox();
            label2 = new Label();
            txt_password = new TextBox();
            btn_cancelar = new Button();
            btn_aceptar = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gainsboro;
            pictureBox1.Location = new Point(292, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(341, 426);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(343, 326);
            label1.Name = "label1";
            label1.Size = new Size(59, 16);
            label1.TabIndex = 2;
            label1.Text = "Usuario:";
            // 
            // txt_usuario
            // 
            txt_usuario.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_usuario.Location = new Point(443, 319);
            txt_usuario.MaxLength = 3;
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(138, 22);
            txt_usuario.TabIndex = 3;
            txt_usuario.TextChanged += txt_usuario_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gainsboro;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(343, 361);
            label2.Name = "label2";
            label2.Size = new Size(83, 16);
            label2.TabIndex = 4;
            label2.Text = "Contraseña:";
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_password.Location = new Point(443, 354);
            txt_password.MaxLength = 10;
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(138, 22);
            txt_password.TabIndex = 5;
            txt_password.UseSystemPasswordChar = true;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = SystemColors.ActiveCaption;
            btn_cancelar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cancelar.Location = new Point(472, 405);
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
            btn_aceptar.Location = new Point(343, 405);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.RightToLeft = RightToLeft.No;
            btn_aceptar.Size = new Size(102, 33);
            btn_aceptar.TabIndex = 7;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = false;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Gainsboro;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(343, 105);
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
            // Frm_Login
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            ClientSize = new Size(923, 545);
            Controls.Add(btn_aceptar);
            Controls.Add(btn_cancelar);
            Controls.Add(txt_password);
            Controls.Add(label2);
            Controls.Add(txt_usuario);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Name = "Frm_Login";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Load += Frm_Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txt_usuario;
        private Label label2;
        private TextBox txt_password;
        private Button btn_cancelar;
        private Button btn_aceptar;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}