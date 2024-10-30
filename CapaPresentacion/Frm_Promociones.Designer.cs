namespace CapaPresentacion
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
            chk_estpro = new CheckBox();
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
            btn_cancelarpro = new Button();
            btn_edipro = new Button();
            btn_grabpro = new Button();
            btn_nuevopromo = new Button();
            tabPage2 = new TabPage();
            dtg_lisPro = new DataGridView();
            panel3 = new Panel();
            btn_buspro = new Button();
            txt_buscarpro = new TextBox();
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
            panel2.Controls.Add(chk_estpro);
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
            // chk_estpro
            // 
            chk_estpro.AutoSize = true;
            chk_estpro.BackColor = Color.Gainsboro;
            chk_estpro.CheckAlign = ContentAlignment.MiddleRight;
            chk_estpro.Enabled = false;
            chk_estpro.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            chk_estpro.Location = new Point(534, 49);
            chk_estpro.Name = "chk_estpro";
            chk_estpro.Size = new Size(61, 20);
            chk_estpro.TabIndex = 16;
            chk_estpro.Text = "Activo";
            chk_estpro.UseVisualStyleBackColor = false;
            // 
            // txt_limticket
            // 
            txt_limticket.Enabled = false;
            txt_limticket.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_limticket.Location = new Point(175, 229);
            txt_limticket.Name = "txt_limticket";
            txt_limticket.ShortcutsEnabled = false;
            txt_limticket.Size = new Size(159, 22);
            txt_limticket.TabIndex = 15;
            txt_limticket.TextChanged += txt_limticket_TextChanged;
            txt_limticket.KeyPress += txt_limticket_KeyPress;
            // 
            // dtp_fecinipro
            // 
            dtp_fecinipro.Enabled = false;
            dtp_fecinipro.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_fecinipro.Format = DateTimePickerFormat.Short;
            dtp_fecinipro.Location = new Point(175, 120);
            dtp_fecinipro.Name = "dtp_fecinipro";
            dtp_fecinipro.Size = new Size(159, 22);
            dtp_fecinipro.TabIndex = 14;
            dtp_fecinipro.Value = new DateTime(2024, 10, 16, 12, 37, 55, 0);
            // 
            // dtp_fecfinpro
            // 
            dtp_fecfinpro.Enabled = false;
            dtp_fecfinpro.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_fecfinpro.Format = DateTimePickerFormat.Short;
            dtp_fecfinpro.Location = new Point(175, 157);
            dtp_fecfinpro.Name = "dtp_fecfinpro";
            dtp_fecfinpro.Size = new Size(159, 22);
            dtp_fecfinpro.TabIndex = 13;
            dtp_fecfinpro.Value = new DateTime(2024, 10, 16, 12, 33, 25, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(41, 193);
            label6.Name = "label6";
            label6.Size = new Size(47, 16);
            label6.TabIndex = 11;
            label6.Text = "Monto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(41, 231);
            label5.Name = "label5";
            label5.Size = new Size(110, 16);
            label5.TabIndex = 10;
            label5.Text = "Limite de Tickets:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(41, 162);
            label4.Name = "label4";
            label4.Size = new Size(64, 16);
            label4.TabIndex = 9;
            label4.Text = "Fecha fin:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(41, 120);
            label3.Name = "label3";
            label3.Size = new Size(81, 16);
            label3.TabIndex = 8;
            label3.Text = "Fecha inicio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(41, 85);
            label2.Name = "label2";
            label2.Size = new Size(73, 16);
            label2.TabIndex = 7;
            label2.Text = "Promoción:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(41, 49);
            label1.Name = "label1";
            label1.Size = new Size(51, 16);
            label1.TabIndex = 6;
            label1.Text = "Código:";
            // 
            // txt_montpro
            // 
            txt_montpro.Enabled = false;
            txt_montpro.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_montpro.Location = new Point(175, 193);
            txt_montpro.Name = "txt_montpro";
            txt_montpro.Size = new Size(159, 22);
            txt_montpro.TabIndex = 5;
            txt_montpro.TextChanged += txt_montpro_TextChanged;
            txt_montpro.KeyPress += txt_montpro_KeyPress;
            // 
            // txt_nompro
            // 
            txt_nompro.Enabled = false;
            txt_nompro.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nompro.Location = new Point(175, 83);
            txt_nompro.Name = "txt_nompro";
            txt_nompro.Size = new Size(276, 22);
            txt_nompro.TabIndex = 1;
            txt_nompro.TextChanged += txt_nompro_TextChanged;
            // 
            // txt_codpro
            // 
            txt_codpro.Enabled = false;
            txt_codpro.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_codpro.Location = new Point(175, 47);
            txt_codpro.Name = "txt_codpro";
            txt_codpro.Size = new Size(159, 22);
            txt_codpro.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(btn_cancelarpro);
            panel1.Controls.Add(btn_edipro);
            panel1.Controls.Add(btn_grabpro);
            panel1.Controls.Add(btn_nuevopromo);
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(825, 53);
            panel1.TabIndex = 0;
            // 
            // btn_cancelarpro
            // 
            btn_cancelarpro.BackColor = Color.LightGray;
            btn_cancelarpro.Enabled = false;
            btn_cancelarpro.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelarpro.Image = (Image)resources.GetObject("btn_cancelarpro.Image");
            btn_cancelarpro.ImageAlign = ContentAlignment.MiddleRight;
            btn_cancelarpro.Location = new Point(389, 9);
            btn_cancelarpro.Name = "btn_cancelarpro";
            btn_cancelarpro.Size = new Size(112, 35);
            btn_cancelarpro.TabIndex = 6;
            btn_cancelarpro.Text = "Cancelar";
            btn_cancelarpro.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_cancelarpro.UseVisualStyleBackColor = false;
            btn_cancelarpro.Click += btn_cancelarpro_Click;
            // 
            // btn_edipro
            // 
            btn_edipro.BackColor = Color.LightGray;
            btn_edipro.Enabled = false;
            btn_edipro.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_edipro.Image = (Image)resources.GetObject("btn_edipro.Image");
            btn_edipro.ImageAlign = ContentAlignment.MiddleRight;
            btn_edipro.Location = new Point(273, 9);
            btn_edipro.Name = "btn_edipro";
            btn_edipro.Size = new Size(112, 35);
            btn_edipro.TabIndex = 5;
            btn_edipro.Text = "Editar";
            btn_edipro.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_edipro.UseVisualStyleBackColor = false;
            btn_edipro.Click += btn_edipro_Click;
            // 
            // btn_grabpro
            // 
            btn_grabpro.BackColor = Color.LightGray;
            btn_grabpro.Enabled = false;
            btn_grabpro.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_grabpro.Image = (Image)resources.GetObject("btn_grabpro.Image");
            btn_grabpro.ImageAlign = ContentAlignment.MiddleRight;
            btn_grabpro.Location = new Point(157, 9);
            btn_grabpro.Name = "btn_grabpro";
            btn_grabpro.Size = new Size(112, 35);
            btn_grabpro.TabIndex = 4;
            btn_grabpro.Text = "Grabar";
            btn_grabpro.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_grabpro.UseVisualStyleBackColor = false;
            btn_grabpro.Click += btn_grabpro_Click;
            // 
            // btn_nuevopromo
            // 
            btn_nuevopromo.BackColor = Color.LightGray;
            btn_nuevopromo.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_nuevopromo.Image = (Image)resources.GetObject("btn_nuevopromo.Image");
            btn_nuevopromo.ImageAlign = ContentAlignment.MiddleRight;
            btn_nuevopromo.Location = new Point(41, 9);
            btn_nuevopromo.Name = "btn_nuevopromo";
            btn_nuevopromo.Size = new Size(112, 35);
            btn_nuevopromo.TabIndex = 3;
            btn_nuevopromo.Text = "Nuevo";
            btn_nuevopromo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_nuevopromo.UseVisualStyleBackColor = false;
            btn_nuevopromo.Click += btn_nuevopromo_Click;
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
            // dtg_lisPro
            // 
            dtg_lisPro.BackgroundColor = Color.Gainsboro;
            dtg_lisPro.BorderStyle = BorderStyle.Fixed3D;
            dtg_lisPro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_lisPro.Location = new Point(4, 57);
            dtg_lisPro.Name = "dtg_lisPro";
            dtg_lisPro.ReadOnly = true;
            dtg_lisPro.RowTemplate.Height = 25;
            dtg_lisPro.Size = new Size(827, 368);
            dtg_lisPro.TabIndex = 0;
            dtg_lisPro.CellClick += dtg_lisPro_CellClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSteelBlue;
            panel3.Controls.Add(btn_buspro);
            panel3.Controls.Add(txt_buscarpro);
            panel3.Location = new Point(4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(827, 47);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // btn_buspro
            // 
            btn_buspro.BackColor = Color.LightGray;
            btn_buspro.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_buspro.Image = (Image)resources.GetObject("btn_buspro.Image");
            btn_buspro.ImageAlign = ContentAlignment.MiddleRight;
            btn_buspro.Location = new Point(316, 6);
            btn_buspro.Name = "btn_buspro";
            btn_buspro.Size = new Size(112, 35);
            btn_buspro.TabIndex = 8;
            btn_buspro.Text = "Buscar";
            btn_buspro.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_buspro.UseVisualStyleBackColor = false;
            btn_buspro.Click += btn_buspro_Click;
            // 
            // txt_buscarpro
            // 
            txt_buscarpro.Location = new Point(32, 12);
            txt_buscarpro.Name = "txt_buscarpro";
            txt_buscarpro.Size = new Size(264, 23);
            txt_buscarpro.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(398, 34);
            label7.Name = "label7";
            label7.Size = new Size(119, 24);
            label7.TabIndex = 15;
            label7.Text = "CAMPAÑAS";
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
        private Button btn_nuevopromo;
        private Button btn_grabpro;
        private Button btn_edipro;
        private TextBox txt_montpro;
        private TextBox txt_nompro;
        private TextBox txt_codpro;
        private Button btn_cancelarpro;
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
        private TextBox txt_buscarpro;
        private DataGridView dtg_lisPro;
        private Button btn_buspro;
        private CheckBox chk_estpro;
    }
}