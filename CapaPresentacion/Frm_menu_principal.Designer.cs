namespace CapaPresentacion
{
    partial class Frm_menu_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_menu_principal));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(923, 545);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.WhiteSmoke;
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(25, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(85, 79);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(135, 435);
            button1.Name = "button1";
            button1.Size = new Size(155, 56);
            button1.TabIndex = 2;
            button1.Text = "Clientes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSteelBlue;
            button2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(642, 435);
            button2.Name = "button2";
            button2.Size = new Size(143, 56);
            button2.TabIndex = 3;
            button2.Text = "Documentos";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(250, 39);
            label1.Name = "label1";
            label1.Size = new Size(394, 24);
            label1.TabIndex = 4;
            label1.Text = "SISTEMA DE GESTION DE FACTURAS ";
            // 
            // button3
            // 
            button3.BackColor = Color.LightSteelBlue;
            button3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(312, 435);
            button3.Name = "button3";
            button3.Size = new Size(143, 56);
            button3.TabIndex = 5;
            button3.Text = "Locales";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSteelBlue;
            button4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(477, 435);
            button4.Name = "button4";
            button4.Size = new Size(143, 56);
            button4.TabIndex = 6;
            button4.Text = "Promociones";
            button4.UseVisualStyleBackColor = false;
            // 
            // Frm_menu_principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 545);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Frm_menu_principal";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_menu_principal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private Label label1;
        private Button button3;
        private Button button4;
    }
}