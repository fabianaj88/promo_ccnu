namespace CapaPresentacion
{
    partial class Frm_Documentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Documentos));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            txt_numf = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_cli = new TextBox();
            label4 = new Label();
            dtim_fec = new DateTimePicker();
            label5 = new Label();
            txt_tot = new TextBox();
            btn_gentik = new Button();
            dgvRegisDoc = new DataGridView();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            panel1 = new Panel();
            btn_limpiar = new Button();
            lbl_codpro = new Label();
            label7 = new Label();
            txt_num = new TextBox();
            txt_obv = new TextBox();
            lbl_obs = new Label();
            pictureBox2 = new PictureBox();
            lbl_promo = new Label();
            panel2 = new Panel();
            txt_nomcli = new TextBox();
            lbl_codcli = new Label();
            txt_saldocli = new TextBox();
            lbl_saldocli = new Label();
            lbl_salcli = new Label();
            cmb_loc = new ComboBox();
            btn_grabarTicket = new Button();
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRegisDoc).BeginInit();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSteelBlue;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(288, 14);
            label1.Name = "label1";
            label1.Size = new Size(86, 16);
            label1.TabIndex = 1;
            label1.Text = "N° de factura:";
            // 
            // txt_numf
            // 
            txt_numf.BackColor = SystemColors.MenuBar;
            txt_numf.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_numf.Location = new Point(380, 11);
            txt_numf.Margin = new Padding(3, 2, 3, 2);
            txt_numf.Name = "txt_numf";
            txt_numf.Size = new Size(161, 22);
            txt_numf.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSteelBlue;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 43);
            label2.Name = "label2";
            label2.Size = new Size(42, 16);
            label2.TabIndex = 3;
            label2.Text = "Local:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSteelBlue;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(288, 10);
            label3.Name = "label3";
            label3.Size = new Size(51, 16);
            label3.TabIndex = 5;
            label3.Text = "Cliente:";
            // 
            // txt_cli
            // 
            txt_cli.BackColor = SystemColors.MenuBar;
            txt_cli.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cli.Location = new Point(93, 4);
            txt_cli.Margin = new Padding(3, 2, 3, 2);
            txt_cli.Name = "txt_cli";
            txt_cli.Size = new Size(162, 22);
            txt_cli.TabIndex = 6;
            txt_cli.TextChanged += txt_cli_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(571, 13);
            label4.Name = "label4";
            label4.Size = new Size(47, 16);
            label4.TabIndex = 7;
            label4.Text = "Fecha:";
            // 
            // dtim_fec
            // 
            dtim_fec.CalendarMonthBackground = SystemColors.MenuBar;
            dtim_fec.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtim_fec.Format = DateTimePickerFormat.Short;
            dtim_fec.Location = new Point(655, 9);
            dtim_fec.Margin = new Padding(3, 2, 3, 2);
            dtim_fec.Name = "dtim_fec";
            dtim_fec.Size = new Size(188, 22);
            dtim_fec.TabIndex = 8;
            dtim_fec.Value = new DateTime(2024, 10, 14, 15, 9, 26, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(288, 44);
            label5.Name = "label5";
            label5.Size = new Size(40, 16);
            label5.TabIndex = 9;
            label5.Text = "Valor:";
            // 
            // txt_tot
            // 
            txt_tot.BackColor = SystemColors.MenuBar;
            txt_tot.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_tot.Location = new Point(380, 40);
            txt_tot.Margin = new Padding(3, 2, 3, 2);
            txt_tot.Name = "txt_tot";
            txt_tot.Size = new Size(161, 22);
            txt_tot.TabIndex = 10;
            // 
            // btn_gentik
            // 
            btn_gentik.BackColor = Color.Silver;
            btn_gentik.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_gentik.Image = (Image)resources.GetObject("btn_gentik.Image");
            btn_gentik.Location = new Point(792, 102);
            btn_gentik.Margin = new Padding(3, 2, 3, 2);
            btn_gentik.Name = "btn_gentik";
            btn_gentik.Size = new Size(51, 38);
            btn_gentik.TabIndex = 13;
            btn_gentik.UseVisualStyleBackColor = false;
            btn_gentik.Click += btn_gentik_Click;
            // 
            // dgvRegisDoc
            // 
            dgvRegisDoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRegisDoc.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            dgvRegisDoc.BackgroundColor = Color.Gainsboro;
            dgvRegisDoc.BorderStyle = BorderStyle.Fixed3D;
            dgvRegisDoc.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvRegisDoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvRegisDoc.DefaultCellStyle = dataGridViewCellStyle5;
            dgvRegisDoc.GridColor = SystemColors.AppWorkspace;
            dgvRegisDoc.Location = new Point(6, 157);
            dgvRegisDoc.Margin = new Padding(3, 2, 3, 2);
            dgvRegisDoc.Name = "dgvRegisDoc";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvRegisDoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvRegisDoc.RowHeadersWidth = 51;
            dgvRegisDoc.RowTemplate.Height = 29;
            dgvRegisDoc.Size = new Size(856, 262);
            dgvRegisDoc.TabIndex = 15;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.ImeMode = ImeMode.NoControl;
            tabControl1.Location = new Point(24, 61);
            tabControl1.Margin = new Padding(3, 3, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(875, 453);
            tabControl1.TabIndex = 16;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(dgvRegisDoc);
            tabPage2.Controls.Add(panel1);
            tabPage2.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage2.ForeColor = Color.Black;
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(867, 425);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btn_limpiar);
            panel1.Controls.Add(lbl_codpro);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txt_num);
            panel1.Controls.Add(txt_obv);
            panel1.Controls.Add(lbl_obs);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(lbl_promo);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(cmb_loc);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_grabarTicket);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_numf);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dtim_fec);
            panel1.Controls.Add(btn_gentik);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txt_tot);
            panel1.Location = new Point(6, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(856, 145);
            panel1.TabIndex = 16;
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = Color.Silver;
            btn_limpiar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_limpiar.Image = (Image)resources.GetObject("btn_limpiar.Image");
            btn_limpiar.Location = new Point(739, 102);
            btn_limpiar.Margin = new Padding(3, 2, 3, 2);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(51, 38);
            btn_limpiar.TabIndex = 25;
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // lbl_codpro
            // 
            lbl_codpro.AutoSize = true;
            lbl_codpro.Location = new Point(77, 112);
            lbl_codpro.Name = "lbl_codpro";
            lbl_codpro.Size = new Size(13, 16);
            lbl_codpro.TabIndex = 24;
            lbl_codpro.Text = "0";
            lbl_codpro.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(10, 15);
            label7.Name = "label7";
            label7.Size = new Size(72, 16);
            label7.TabIndex = 23;
            label7.Text = "N° de doc.:";
            // 
            // txt_num
            // 
            txt_num.Enabled = false;
            txt_num.Location = new Point(93, 11);
            txt_num.Name = "txt_num";
            txt_num.Size = new Size(162, 22);
            txt_num.TabIndex = 22;
            // 
            // txt_obv
            // 
            txt_obv.Location = new Point(655, 39);
            txt_obv.Name = "txt_obv";
            txt_obv.Size = new Size(188, 22);
            txt_obv.TabIndex = 21;
            // 
            // lbl_obs
            // 
            lbl_obs.AutoSize = true;
            lbl_obs.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_obs.Location = new Point(571, 43);
            lbl_obs.Name = "lbl_obs";
            lbl_obs.Size = new Size(82, 16);
            lbl_obs.TabIndex = 20;
            lbl_obs.Text = "Observación:";
            lbl_obs.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(14, 101);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // lbl_promo
            // 
            lbl_promo.AutoSize = true;
            lbl_promo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_promo.Location = new Point(96, 111);
            lbl_promo.Name = "lbl_promo";
            lbl_promo.Size = new Size(131, 19);
            lbl_promo.TabIndex = 18;
            lbl_promo.Text = "PROMOCIONES";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txt_nomcli);
            panel2.Controls.Add(lbl_codcli);
            panel2.Controls.Add(txt_saldocli);
            panel2.Controls.Add(lbl_saldocli);
            panel2.Controls.Add(lbl_salcli);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txt_cli);
            panel2.Location = new Point(-1, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(856, 33);
            panel2.TabIndex = 17;
            // 
            // txt_nomcli
            // 
            txt_nomcli.Enabled = false;
            txt_nomcli.Location = new Point(380, 4);
            txt_nomcli.Name = "txt_nomcli";
            txt_nomcli.Size = new Size(161, 22);
            txt_nomcli.TabIndex = 11;
            // 
            // lbl_codcli
            // 
            lbl_codcli.AutoSize = true;
            lbl_codcli.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_codcli.Location = new Point(10, 10);
            lbl_codcli.Name = "lbl_codcli";
            lbl_codcli.Size = new Size(80, 16);
            lbl_codcli.TabIndex = 10;
            lbl_codcli.Text = "Cod. cliente:";
            lbl_codcli.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_saldocli
            // 
            txt_saldocli.BackColor = SystemColors.Window;
            txt_saldocli.Enabled = false;
            txt_saldocli.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_saldocli.ForeColor = SystemColors.InfoText;
            txt_saldocli.Location = new Point(655, 4);
            txt_saldocli.Name = "txt_saldocli";
            txt_saldocli.Size = new Size(137, 22);
            txt_saldocli.TabIndex = 9;
            txt_saldocli.TextAlign = HorizontalAlignment.Right;
            txt_saldocli.Visible = false;
            // 
            // lbl_saldocli
            // 
            lbl_saldocli.AutoSize = true;
            lbl_saldocli.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_saldocli.Location = new Point(698, 9);
            lbl_saldocli.Name = "lbl_saldocli";
            lbl_saldocli.Size = new Size(0, 20);
            lbl_saldocli.TabIndex = 8;
            // 
            // lbl_salcli
            // 
            lbl_salcli.AutoSize = true;
            lbl_salcli.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_salcli.Location = new Point(571, 10);
            lbl_salcli.Name = "lbl_salcli";
            lbl_salcli.Size = new Size(44, 16);
            lbl_salcli.TabIndex = 7;
            lbl_salcli.Text = "Saldo:";
            lbl_salcli.Visible = false;
            // 
            // cmb_loc
            // 
            cmb_loc.FormattingEnabled = true;
            cmb_loc.Location = new Point(93, 38);
            cmb_loc.Name = "cmb_loc";
            cmb_loc.Size = new Size(161, 24);
            cmb_loc.TabIndex = 16;
            cmb_loc.Click += cmb_loc_Click;
            // 
            // btn_grabarTicket
            // 
            btn_grabarTicket.BackColor = Color.Silver;
            btn_grabarTicket.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_grabarTicket.Image = (Image)resources.GetObject("btn_grabarTicket.Image");
            btn_grabarTicket.Location = new Point(686, 102);
            btn_grabarTicket.Margin = new Padding(3, 2, 3, 2);
            btn_grabarTicket.Name = "btn_grabarTicket";
            btn_grabarTicket.Size = new Size(51, 38);
            btn_grabarTicket.TabIndex = 15;
            btn_grabarTicket.UseVisualStyleBackColor = false;
            btn_grabarTicket.Click += btn_grabarTicket_Click;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(867, 425);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.GradientInactiveCaption;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(923, 545);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(338, 34);
            label6.Name = "label6";
            label6.Size = new Size(208, 24);
            label6.TabIndex = 0;
            label6.Text = "GENERAR TICKETS";
            // 
            // Frm_Documentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 545);
            Controls.Add(label6);
            Controls.Add(tabControl1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Frm_Documentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Documentos";
            ((System.ComponentModel.ISupportInitialize)dgvRegisDoc).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txt_numf;
        private Label label2;
        private Label label3;
        private TextBox txt_cli;
        private Label label4;
        private DateTimePicker dtim_fec;
        private Label label5;
        private TextBox txt_tot;
        private Button btn_gentik;
        private DataGridView dgvRegisDoc;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label6;
        private Button btn_grabarTicket;
        private ComboBox cmb_loc;
        private Panel panel2;
        private Label lbl_salcli;
        private Label lbl_saldocli;
        private TextBox txt_saldocli;
        private Label lbl_promo;
        private PictureBox pictureBox2;
        private Label lbl_obs;
        private TextBox txt_obv;
        private Label lbl_codcli;
        private TextBox txt_nomcli;
        private TextBox txt_num;
        private Label label7;
        private Label lbl_codpro;
        private Button btn_limpiar;
    }
}