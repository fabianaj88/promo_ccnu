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
            pictureBox2 = new PictureBox();
            label1 = new Label();
            txt_usuario = new TextBox();
            label2 = new Label();
            txt_password = new TextBox();
            btn_cancelar = new Button();
            btn_aceptar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gainsboro;
            pictureBox1.Location = new Point(-1, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(425, 190);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(175, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(114, 91);
            label1.Name = "label1";
            label1.Size = new Size(67, 18);
            label1.TabIndex = 2;
            label1.Text = "Usuario:";
            // 
            // txt_usuario
            // 
            txt_usuario.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_usuario.Location = new Point(211, 87);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(100, 25);
            txt_usuario.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(109, 126);
            label2.Name = "label2";
            label2.Size = new Size(94, 18);
            label2.TabIndex = 4;
            label2.Text = "Contraseña:";
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_password.Location = new Point(211, 119);
            txt_password.MaxLength = 10;
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(100, 25);
            txt_password.TabIndex = 5;
            txt_password.UseSystemPasswordChar = true;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = SystemColors.ActiveCaption;
            btn_cancelar.Location = new Point(211, 166);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.RightToLeft = RightToLeft.No;
            btn_cancelar.Size = new Size(75, 29);
            btn_cancelar.TabIndex = 6;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_aceptar
            // 
            btn_aceptar.BackColor = SystemColors.ActiveCaption;
            btn_aceptar.Location = new Point(128, 166);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.RightToLeft = RightToLeft.No;
            btn_aceptar.Size = new Size(75, 29);
            btn_aceptar.TabIndex = 7;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = false;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 256);
            Controls.Add(btn_aceptar);
            Controls.Add(btn_cancelar);
            Controls.Add(txt_password);
            Controls.Add(label2);
            Controls.Add(txt_usuario);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Frm_Login";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += Frm_Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox txt_usuario;
        private Label label2;
        private TextBox txt_password;
        private Button btn_cancelar;
        private Button btn_aceptar;
    }
}