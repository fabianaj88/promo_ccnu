﻿namespace CapaPresentacion
{
    partial class Frm_Promociones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Promociones));
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel2 = new Panel();
            txt_limticket = new TextBox();
            dtp_fecinipro = new DateTimePicker();
            dtp_fecfinpro = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_montpro = new TextBox();
            txt_nompro = new TextBox();
            txt_codpro = new TextBox();
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            btn_grabpro = new Button();
            button1 = new Button();
            tabPage2 = new TabPage();
            button2 = new Button();
            textBox1 = new TextBox();
            dtg_lisPro = new DataGridView();
            panel3 = new Panel();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_lisPro).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(923, 545);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(39, 61);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(845, 459);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(837, 431);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(txt_limticket);
            panel2.Controls.Add(dtp_fecinipro);
            panel2.Controls.Add(dtp_fecfinpro);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txt_montpro);
            panel2.Controls.Add(txt_nompro);
            panel2.Controls.Add(txt_codpro);
            panel2.Location = new Point(6, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(825, 363);
            panel2.TabIndex = 1;
            // 
            // txt_limticket
            // 
            txt_limticket.Location = new Point(175, 259);
            txt_limticket.Name = "txt_limticket";
            txt_limticket.ShortcutsEnabled = false;
            txt_limticket.Size = new Size(159, 23);
            txt_limticket.TabIndex = 15;
            // 
            // dtp_fecinipro
            // 
            dtp_fecinipro.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_fecinipro.Format = DateTimePickerFormat.Short;
            dtp_fecinipro.Location = new Point(175, 130);
            dtp_fecinipro.Name = "dtp_fecinipro";
            dtp_fecinipro.Size = new Size(159, 23);
            dtp_fecinipro.TabIndex = 14;
            dtp_fecinipro.Value = new DateTime(2024, 10, 16, 12, 37, 55, 0);
            // 
            // dtp_fecfinpro
            // 
            dtp_fecfinpro.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_fecfinpro.Format = DateTimePickerFormat.Short;
            dtp_fecfinpro.Location = new Point(175, 170);
            dtp_fecfinpro.Name = "dtp_fecfinpro";
            dtp_fecfinpro.Size = new Size(159, 23);
            dtp_fecfinpro.TabIndex = 13;
            dtp_fecfinpro.Value = new DateTime(2024, 10, 16, 12, 33, 25, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(41, 218);
            label6.Name = "label6";
            label6.Size = new Size(50, 16);
            label6.TabIndex = 11;
            label6.Text = "Monto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(41, 261);
            label5.Name = "label5";
            label5.Size = new Size(116, 16);
            label5.TabIndex = 10;
            label5.Text = "Limite de Tickets:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(41, 175);
            label4.Name = "label4";
            label4.Size = new Size(70, 16);
            label4.TabIndex = 9;
            label4.Text = "Fecha fin:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(41, 130);
            label3.Name = "label3";
            label3.Size = new Size(87, 16);
            label3.TabIndex = 8;
            label3.Text = "Fecha inicio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(41, 85);
            label2.Name = "label2";
            label2.Size = new Size(78, 16);
            label2.TabIndex = 7;
            label2.Text = "Promoción:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(41, 41);
            label1.Name = "label1";
            label1.Size = new Size(56, 16);
            label1.TabIndex = 6;
            label1.Text = "Código:";
            // 
            // txt_montpro
            // 
            txt_montpro.Location = new Point(175, 218);
            txt_montpro.Name = "txt_montpro";
            txt_montpro.Size = new Size(159, 23);
            txt_montpro.TabIndex = 5;
            // 
            // txt_nompro
            // 
            txt_nompro.Location = new Point(175, 83);
            txt_nompro.Name = "txt_nompro";
            txt_nompro.Size = new Size(276, 23);
            txt_nompro.TabIndex = 1;
            // 
            // txt_codpro
            // 
            txt_codpro.Enabled = false;
            txt_codpro.Location = new Point(175, 39);
            txt_codpro.Name = "txt_codpro";
            txt_codpro.Size = new Size(159, 23);
            txt_codpro.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btn_grabpro);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(825, 52);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(448, 9);
            button5.Name = "button5";
            button5.Size = new Size(75, 35);
            button5.TabIndex = 7;
            button5.Text = "Buscar";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(344, 9);
            button4.Name = "button4";
            button4.Size = new Size(75, 35);
            button4.TabIndex = 6;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(240, 9);
            button3.Name = "button3";
            button3.Size = new Size(75, 35);
            button3.TabIndex = 5;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = true;
            // 
            // btn_grabpro
            // 
            btn_grabpro.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_grabpro.Location = new Point(138, 9);
            btn_grabpro.Name = "btn_grabpro";
            btn_grabpro.Size = new Size(75, 35);
            btn_grabpro.TabIndex = 4;
            btn_grabpro.Text = "Grabar";
            btn_grabpro.UseVisualStyleBackColor = true;
            btn_grabpro.Click += btn_grabpro_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(41, 9);
            button1.Name = "button1";
            button1.Size = new Size(75, 35);
            button1.TabIndex = 3;
            button1.Text = "Nuevo";
            button1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dtg_lisPro);
            tabPage2.Controls.Add(panel3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(837, 431);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Listado";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(326, 10);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(31, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(264, 23);
            textBox1.TabIndex = 1;
            // 
            // dtg_lisPro
            // 
            dtg_lisPro.BackgroundColor = Color.Gainsboro;
            dtg_lisPro.BorderStyle = BorderStyle.Fixed3D;
            dtg_lisPro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_lisPro.Location = new Point(4, 57);
            dtg_lisPro.Name = "dtg_lisPro";
            dtg_lisPro.RowTemplate.Height = 25;
            dtg_lisPro.Size = new Size(827, 368);
            dtg_lisPro.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSteelBlue;
            panel3.Controls.Add(button2);
            panel3.Controls.Add(textBox1);
            panel3.Location = new Point(4, 8);
            panel3.Name = "panel3";
            panel3.Size = new Size(827, 43);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(375, 30);
            label7.Name = "label7";
            label7.Size = new Size(161, 24);
            label7.TabIndex = 15;
            label7.Text = "PROMOCIONES";
            // 
            // Frm_Promociones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 545);
            Controls.Add(label7);
            Controls.Add(tabControl1);
            Controls.Add(pictureBox1);
            Name = "Frm_Promociones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Promociones";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_lisPro).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel2;
        private Panel panel1;
        private Button button1;
        private Button btn_grabpro;
        private Button button3;
        private TextBox txt_montpro;
        private TextBox txt_nompro;
        private TextBox txt_codpro;
        private Button button5;
        private Button button4;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dtp_fecfinpro;
        private DateTimePicker dtp_fecinipro;
        private Label label7;
        private TextBox txt_limticket;
        private Panel panel3;
        private Button button2;
        private TextBox textBox1;
        private DataGridView dtg_lisPro;
    }
}