﻿namespace CapaPresentacion
{
    partial class Frm_locales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_locales));
            tab_locales = new TabControl();
            tabPage1 = new TabPage();
            chc_actloc = new CheckBox();
            txt_coproact = new TextBox();
            txt_coproes = new TextBox();
            label9 = new Label();
            label8 = new Label();
            btn_nuevo_loc = new Button();
            txt_resloc = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txt_telfloc = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            txt_mail_loc = new TextBox();
            txt_ubiloc = new TextBox();
            txt_nomloc = new TextBox();
            txt_codigoloc = new TextBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            btn_eliminar_loc = new Button();
            btn_editar_loc = new Button();
            btn_grabar_loc = new Button();
            pictureBox1 = new PictureBox();
            tabPage2 = new TabPage();
            grid_lista_locales = new DataGridView();
            panel1 = new Panel();
            btn_busca_loc = new Button();
            txt_dato_buscar = new TextBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            tab_locales.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_lista_locales).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tab_locales
            // 
            tab_locales.Controls.Add(tabPage1);
            tab_locales.Controls.Add(tabPage2);
            tab_locales.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tab_locales.Location = new Point(30, 66);
            tab_locales.Name = "tab_locales";
            tab_locales.SelectedIndex = 0;
            tab_locales.Size = new Size(860, 454);
            tab_locales.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.WhiteSmoke;
            tabPage1.Controls.Add(chc_actloc);
            tabPage1.Controls.Add(txt_coproact);
            tabPage1.Controls.Add(txt_coproes);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(btn_nuevo_loc);
            tabPage1.Controls.Add(txt_resloc);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txt_telfloc);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txt_mail_loc);
            tabPage1.Controls.Add(txt_ubiloc);
            tabPage1.Controls.Add(txt_nomloc);
            tabPage1.Controls.Add(txt_codigoloc);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(pictureBox3);
            tabPage1.Controls.Add(btn_eliminar_loc);
            tabPage1.Controls.Add(btn_editar_loc);
            tabPage1.Controls.Add(btn_grabar_loc);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Location = new Point(4, 25);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(852, 425);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registro";
            // 
            // chc_actloc
            // 
            chc_actloc.AutoSize = true;
            chc_actloc.BackColor = Color.Gainsboro;
            chc_actloc.Enabled = false;
            chc_actloc.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            chc_actloc.Location = new Point(597, 89);
            chc_actloc.Name = "chc_actloc";
            chc_actloc.Size = new Size(61, 20);
            chc_actloc.TabIndex = 15;
            chc_actloc.Text = "Activo";
            chc_actloc.UseVisualStyleBackColor = false;
            // 
            // txt_coproact
            // 
            txt_coproact.Enabled = false;
            txt_coproact.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_coproact.Location = new Point(201, 317);
            txt_coproact.MaxLength = 50;
            txt_coproact.Name = "txt_coproact";
            txt_coproact.Size = new Size(311, 22);
            txt_coproact.TabIndex = 24;
            // 
            // txt_coproes
            // 
            txt_coproes.Enabled = false;
            txt_coproes.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_coproes.Location = new Point(201, 279);
            txt_coproes.MaxLength = 50;
            txt_coproes.Name = "txt_coproes";
            txt_coproes.Size = new Size(311, 22);
            txt_coproes.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Gainsboro;
            label9.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(46, 320);
            label9.Name = "label9";
            label9.Size = new Size(126, 16);
            label9.TabIndex = 22;
            label9.Text = "Copropietario actual:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Gainsboro;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(46, 282);
            label8.Name = "label8";
            label8.Size = new Size(141, 16);
            label8.TabIndex = 15;
            label8.Text = "Copropietario escritura:";
            // 
            // btn_nuevo_loc
            // 
            btn_nuevo_loc.BackColor = Color.LightGray;
            btn_nuevo_loc.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_nuevo_loc.Image = (Image)resources.GetObject("btn_nuevo_loc.Image");
            btn_nuevo_loc.ImageAlign = ContentAlignment.MiddleRight;
            btn_nuevo_loc.Location = new Point(46, 11);
            btn_nuevo_loc.Name = "btn_nuevo_loc";
            btn_nuevo_loc.Size = new Size(112, 35);
            btn_nuevo_loc.TabIndex = 21;
            btn_nuevo_loc.Text = "Nuevo";
            btn_nuevo_loc.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_nuevo_loc.UseVisualStyleBackColor = false;
            btn_nuevo_loc.Click += btn_nuevo_loc_Click;
            // 
            // txt_resloc
            // 
            txt_resloc.Enabled = false;
            txt_resloc.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_resloc.Location = new Point(201, 355);
            txt_resloc.MaxLength = 50;
            txt_resloc.Name = "txt_resloc";
            txt_resloc.Size = new Size(311, 22);
            txt_resloc.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Gainsboro;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(46, 358);
            label7.Name = "label7";
            label7.Size = new Size(81, 16);
            label7.TabIndex = 19;
            label7.Text = "Arrendatario:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Gainsboro;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(46, 206);
            label6.Name = "label6";
            label6.Size = new Size(49, 16);
            label6.TabIndex = 18;
            label6.Text = "Correo:";
            // 
            // txt_telfloc
            // 
            txt_telfloc.Enabled = false;
            txt_telfloc.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_telfloc.Location = new Point(201, 241);
            txt_telfloc.MaxLength = 35;
            txt_telfloc.Name = "txt_telfloc";
            txt_telfloc.Size = new Size(203, 22);
            txt_telfloc.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gainsboro;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(46, 244);
            label5.Name = "label5";
            label5.Size = new Size(58, 16);
            label5.TabIndex = 16;
            label5.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Gainsboro;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(46, 168);
            label4.Name = "label4";
            label4.Size = new Size(68, 16);
            label4.TabIndex = 15;
            label4.Text = "Ubicación:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gainsboro;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(46, 130);
            label2.Name = "label2";
            label2.Size = new Size(116, 16);
            label2.TabIndex = 13;
            label2.Text = "Nombre comercial:";
            // 
            // txt_mail_loc
            // 
            txt_mail_loc.Enabled = false;
            txt_mail_loc.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_mail_loc.Location = new Point(201, 203);
            txt_mail_loc.MaxLength = 30;
            txt_mail_loc.Name = "txt_mail_loc";
            txt_mail_loc.Size = new Size(203, 22);
            txt_mail_loc.TabIndex = 12;
            txt_mail_loc.KeyPress += txt_mail_loc_KeyPress;
            txt_mail_loc.Validating += txt_mail_loc_Validating;
            // 
            // txt_ubiloc
            // 
            txt_ubiloc.Enabled = false;
            txt_ubiloc.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ubiloc.Location = new Point(201, 165);
            txt_ubiloc.MaxLength = 30;
            txt_ubiloc.Name = "txt_ubiloc";
            txt_ubiloc.Size = new Size(203, 22);
            txt_ubiloc.TabIndex = 11;
            // 
            // txt_nomloc
            // 
            txt_nomloc.Enabled = false;
            txt_nomloc.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nomloc.Location = new Point(201, 127);
            txt_nomloc.MaxLength = 50;
            txt_nomloc.Name = "txt_nomloc";
            txt_nomloc.Size = new Size(311, 22);
            txt_nomloc.TabIndex = 10;
            // 
            // txt_codigoloc
            // 
            txt_codigoloc.Enabled = false;
            txt_codigoloc.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_codigoloc.Location = new Point(201, 90);
            txt_codigoloc.MaxLength = 8;
            txt_codigoloc.Name = "txt_codigoloc";
            txt_codigoloc.Size = new Size(141, 22);
            txt_codigoloc.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(46, 93);
            label1.Name = "label1";
            label1.Size = new Size(51, 16);
            label1.TabIndex = 8;
            label1.Text = "Código:";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Gainsboro;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(6, 55);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(840, 363);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // btn_eliminar_loc
            // 
            btn_eliminar_loc.BackColor = Color.LightGray;
            btn_eliminar_loc.Enabled = false;
            btn_eliminar_loc.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_eliminar_loc.Image = (Image)resources.GetObject("btn_eliminar_loc.Image");
            btn_eliminar_loc.ImageAlign = ContentAlignment.MiddleRight;
            btn_eliminar_loc.Location = new Point(443, 11);
            btn_eliminar_loc.Name = "btn_eliminar_loc";
            btn_eliminar_loc.Size = new Size(112, 35);
            btn_eliminar_loc.TabIndex = 4;
            btn_eliminar_loc.Text = "Cancelar";
            btn_eliminar_loc.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_eliminar_loc.UseVisualStyleBackColor = false;
            btn_eliminar_loc.Click += btn_eliminar_loc_Click;
            // 
            // btn_editar_loc
            // 
            btn_editar_loc.BackColor = Color.LightGray;
            btn_editar_loc.Enabled = false;
            btn_editar_loc.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_editar_loc.Image = (Image)resources.GetObject("btn_editar_loc.Image");
            btn_editar_loc.ImageAlign = ContentAlignment.MiddleRight;
            btn_editar_loc.Location = new Point(311, 11);
            btn_editar_loc.Name = "btn_editar_loc";
            btn_editar_loc.Size = new Size(112, 35);
            btn_editar_loc.TabIndex = 3;
            btn_editar_loc.Text = "Editar";
            btn_editar_loc.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_editar_loc.UseVisualStyleBackColor = false;
            btn_editar_loc.Click += btn_editar_loc_Click;
            // 
            // btn_grabar_loc
            // 
            btn_grabar_loc.BackColor = Color.LightGray;
            btn_grabar_loc.Enabled = false;
            btn_grabar_loc.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_grabar_loc.Image = (Image)resources.GetObject("btn_grabar_loc.Image");
            btn_grabar_loc.ImageAlign = ContentAlignment.MiddleRight;
            btn_grabar_loc.Location = new Point(178, 11);
            btn_grabar_loc.Name = "btn_grabar_loc";
            btn_grabar_loc.Size = new Size(112, 35);
            btn_grabar_loc.TabIndex = 2;
            btn_grabar_loc.Text = "Grabar";
            btn_grabar_loc.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_grabar_loc.UseVisualStyleBackColor = false;
            btn_grabar_loc.Click += btn_grabar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightSteelBlue;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(840, 45);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(grid_lista_locales);
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 25);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(852, 425);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Listado";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // grid_lista_locales
            // 
            grid_lista_locales.AllowUserToAddRows = false;
            grid_lista_locales.AllowUserToDeleteRows = false;
            grid_lista_locales.BackgroundColor = Color.Gainsboro;
            grid_lista_locales.BorderStyle = BorderStyle.Fixed3D;
            grid_lista_locales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_lista_locales.Location = new Point(6, 54);
            grid_lista_locales.Name = "grid_lista_locales";
            grid_lista_locales.ReadOnly = true;
            grid_lista_locales.RowTemplate.Height = 25;
            grid_lista_locales.Size = new Size(843, 368);
            grid_lista_locales.TabIndex = 5;
            grid_lista_locales.CellDoubleClick += grid_lista_locales_CellDoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(btn_busca_loc);
            panel1.Controls.Add(txt_dato_buscar);
            panel1.Location = new Point(4, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(849, 43);
            panel1.TabIndex = 4;
            // 
            // btn_busca_loc
            // 
            btn_busca_loc.BackColor = Color.LightGray;
            btn_busca_loc.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_busca_loc.Image = (Image)resources.GetObject("btn_busca_loc.Image");
            btn_busca_loc.ImageAlign = ContentAlignment.MiddleRight;
            btn_busca_loc.Location = new Point(265, 4);
            btn_busca_loc.Name = "btn_busca_loc";
            btn_busca_loc.Size = new Size(112, 35);
            btn_busca_loc.TabIndex = 3;
            btn_busca_loc.Text = "Buscar";
            btn_busca_loc.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_busca_loc.UseVisualStyleBackColor = false;
            btn_busca_loc.Click += btn_busca_cli_Click;
            // 
            // txt_dato_buscar
            // 
            txt_dato_buscar.Location = new Point(18, 9);
            txt_dato_buscar.Name = "txt_dato_buscar";
            txt_dato_buscar.Size = new Size(230, 22);
            txt_dato_buscar.TabIndex = 2;
            // 
            // label3
            // 
            label3.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(399, 34);
            label3.Name = "label3";
            label3.Size = new Size(122, 28);
            label3.TabIndex = 14;
            label3.Text = "LOCALES";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(923, 545);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // Frm_locales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 545);
            Controls.Add(label3);
            Controls.Add(tab_locales);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_locales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_locales";
            tab_locales.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid_lista_locales).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tab_locales;
        private TabPage tabPage1;
        private Label label6;
        private TextBox txt_telfloc;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txt_mail_loc;
        private TextBox txt_ubiloc;
        private TextBox txt_nomloc;
        private TextBox txt_codigoloc;
        private Label label1;
        private PictureBox pictureBox3;
        private Button btn_eliminar_loc;
        private Button btn_editar_loc;
        private Button btn_grabar_loc;
        private PictureBox pictureBox1;
        private TabPage tabPage2;
        private PictureBox pictureBox2;
        private Label label7;
        private TextBox txt_resloc;
        private Button btn_nuevo_loc;
        private TextBox txt_coproes;
        private Label label9;
        private Label label8;
        private TextBox txt_coproact;
        private Panel panel1;
        private TextBox txt_dato_buscar;
        private Button btn_busca_loc;
        private DataGridView grid_lista_locales;
        private CheckBox chc_actloc;
        private Button button1;
    }
}