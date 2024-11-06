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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Documentos));
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
            chk_dobleTi = new CheckBox();
            cmb_nompro = new ComboBox();
            btn_anulartick = new Button();
            btn_nuevoDoc = new Button();
            btn_limpiar = new Button();
            lbl_nompro = new Label();
            label7 = new Label();
            txt_num = new TextBox();
            panel2 = new Panel();
            textBox1 = new TextBox();
            txt_nomcli = new TextBox();
            lbl_codcli = new Label();
            txt_saldocli = new TextBox();
            lbl_saldocli = new Label();
            lbl_salcli = new Label();
            cmb_loc = new ComboBox();
            btn_grabarTicket = new Button();
            pib_dobleT = new PictureBox();
            tabPage1 = new TabPage();
            dtg_lisDoc = new DataGridView();
            panel3 = new Panel();
            btn_busTick = new Button();
            txt_busTick = new TextBox();
            Tickets = new TabPage();
            btn_impTicket = new Button();
            panel_impTickets = new Panel();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            label8 = new Label();
            lbl_numdT = new Label();
            label19 = new Label();
            txt_dirT = new TextBox();
            label18 = new Label();
            lbl_fechaproT = new Label();
            label17 = new Label();
            label14 = new Label();
            txt_telfT = new TextBox();
            lbl_nregdocT = new Label();
            txt_nomcliT = new TextBox();
            txt_proT = new TextBox();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            toolTip = new ToolTip(components);
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRegisDoc).BeginInit();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pib_dobleT).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_lisDoc).BeginInit();
            panel3.SuspendLayout();
            Tickets.SuspendLayout();
            panel_impTickets.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSteelBlue;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(308, 14);
            label1.Name = "label1";
            label1.Size = new Size(86, 16);
            label1.TabIndex = 1;
            label1.Text = "N° de factura:";
            // 
            // txt_numf
            // 
            txt_numf.BackColor = SystemColors.Window;
            txt_numf.Enabled = false;
            txt_numf.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_numf.Location = new Point(410, 11);
            txt_numf.Margin = new Padding(3, 2, 3, 2);
            txt_numf.Name = "txt_numf";
            txt_numf.Size = new Size(161, 22);
            txt_numf.TabIndex = 5;
            txt_numf.TextChanged += txt_numf_TextChanged;
            txt_numf.KeyDown += txt_numf_KeyDown;
            txt_numf.KeyPress += txt_numf_KeyPress;
            txt_numf.Leave += txt_numf_Leave;
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
            label3.Location = new Point(308, 10);
            label3.Name = "label3";
            label3.Size = new Size(51, 16);
            label3.TabIndex = 5;
            label3.Text = "Cliente:";
            // 
            // txt_cli
            // 
            txt_cli.BackColor = SystemColors.Window;
            txt_cli.Enabled = false;
            txt_cli.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cli.Location = new Point(102, 6);
            txt_cli.Margin = new Padding(3, 2, 3, 2);
            txt_cli.Name = "txt_cli";
            txt_cli.Size = new Size(161, 22);
            txt_cli.TabIndex = 4;
            txt_cli.TextChanged += txt_cli_TextChanged;
            txt_cli.KeyDown += txt_cli_KeyDown;
            txt_cli.Leave += txt_cli_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(308, 45);
            label4.Name = "label4";
            label4.Size = new Size(47, 16);
            label4.TabIndex = 7;
            label4.Text = "Fecha:";
            // 
            // dtim_fec
            // 
            dtim_fec.CalendarMonthBackground = SystemColors.MenuBar;
            dtim_fec.Enabled = false;
            dtim_fec.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtim_fec.Format = DateTimePickerFormat.Short;
            dtim_fec.Location = new Point(410, 38);
            dtim_fec.Margin = new Padding(3, 2, 3, 2);
            dtim_fec.Name = "dtim_fec";
            dtim_fec.Size = new Size(161, 22);
            dtim_fec.TabIndex = 6;
            dtim_fec.Value = new DateTime(2024, 10, 14, 15, 9, 26, 0);
            dtim_fec.KeyDown += dtim_fec_KeyDown;
            dtim_fec.Leave += dtim_fec_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(622, 14);
            label5.Name = "label5";
            label5.Size = new Size(40, 16);
            label5.TabIndex = 9;
            label5.Text = "Valor:";
            // 
            // txt_tot
            // 
            txt_tot.BackColor = SystemColors.Window;
            txt_tot.Enabled = false;
            txt_tot.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_tot.Location = new Point(678, 11);
            txt_tot.Margin = new Padding(3, 2, 3, 2);
            txt_tot.Name = "txt_tot";
            txt_tot.Size = new Size(161, 22);
            txt_tot.TabIndex = 7;
            txt_tot.TextAlign = HorizontalAlignment.Right;
            txt_tot.TextChanged += txt_tot_TextChanged;
            txt_tot.KeyDown += txt_tot_KeyDown;
            txt_tot.KeyPress += txt_tot_KeyPress;
            // 
            // btn_gentik
            // 
            btn_gentik.BackColor = Color.Silver;
            btn_gentik.Enabled = false;
            btn_gentik.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_gentik.Image = (Image)resources.GetObject("btn_gentik.Image");
            btn_gentik.Location = new Point(793, 102);
            btn_gentik.Margin = new Padding(3, 2, 3, 2);
            btn_gentik.Name = "btn_gentik";
            btn_gentik.Size = new Size(51, 38);
            btn_gentik.TabIndex = 10;
            toolTip.SetToolTip(btn_gentik, "Generar Tickets");
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
            dgvRegisDoc.ColumnHeadersHeight = 29;
            dgvRegisDoc.EnableHeadersVisualStyles = false;
            dgvRegisDoc.GridColor = SystemColors.AppWorkspace;
            dgvRegisDoc.Location = new Point(6, 157);
            dgvRegisDoc.Margin = new Padding(3, 2, 3, 2);
            dgvRegisDoc.Name = "dgvRegisDoc";
            dgvRegisDoc.ReadOnly = true;
            dgvRegisDoc.RowHeadersWidth = 51;
            dgvRegisDoc.RowTemplate.Height = 29;
            dgvRegisDoc.Size = new Size(856, 262);
            dgvRegisDoc.TabIndex = 15;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(Tickets);
            tabControl1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.ImeMode = ImeMode.NoControl;
            tabControl1.Location = new Point(24, 61);
            tabControl1.Margin = new Padding(3, 3, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(875, 453);
            tabControl1.TabIndex = 10;
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
            tabPage2.Text = "Registro";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(chk_dobleTi);
            panel1.Controls.Add(cmb_nompro);
            panel1.Controls.Add(btn_anulartick);
            panel1.Controls.Add(btn_nuevoDoc);
            panel1.Controls.Add(btn_limpiar);
            panel1.Controls.Add(lbl_nompro);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txt_num);
            panel1.Controls.Add(btn_gentik);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(cmb_loc);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_grabarTicket);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_numf);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dtim_fec);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txt_tot);
            panel1.Controls.Add(pib_dobleT);
            panel1.Location = new Point(6, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(856, 145);
            panel1.TabIndex = 16;
            // 
            // chk_dobleTi
            // 
            chk_dobleTi.AutoSize = true;
            chk_dobleTi.BackColor = Color.LightSteelBlue;
            chk_dobleTi.BackgroundImageLayout = ImageLayout.None;
            chk_dobleTi.FlatAppearance.BorderSize = 0;
            chk_dobleTi.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            chk_dobleTi.ImageAlign = ContentAlignment.BottomCenter;
            chk_dobleTi.Location = new Point(314, 116);
            chk_dobleTi.Margin = new Padding(0);
            chk_dobleTi.Name = "chk_dobleTi";
            chk_dobleTi.Size = new Size(15, 14);
            chk_dobleTi.TabIndex = 26;
            chk_dobleTi.TextAlign = ContentAlignment.MiddleCenter;
            toolTip.SetToolTip(chk_dobleTi, "Doble Ticket");
            chk_dobleTi.UseVisualStyleBackColor = false;
            chk_dobleTi.Visible = false;
            // 
            // cmb_nompro
            // 
            cmb_nompro.BackColor = SystemColors.Window;
            cmb_nompro.Enabled = false;
            cmb_nompro.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_nompro.FormattingEnabled = true;
            cmb_nompro.Location = new Point(102, 110);
            cmb_nompro.Name = "cmb_nompro";
            cmb_nompro.Size = new Size(161, 24);
            cmb_nompro.TabIndex = 25;
            cmb_nompro.SelectedIndexChanged += cmb_nompro_SelectedIndexChanged;
            cmb_nompro.Click += cmb_nompro_Click;
            cmb_nompro.KeyDown += cmb_nompro_KeyDown;
            // 
            // btn_anulartick
            // 
            btn_anulartick.BackColor = Color.Silver;
            btn_anulartick.Enabled = false;
            btn_anulartick.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_anulartick.Image = (Image)resources.GetObject("btn_anulartick.Image");
            btn_anulartick.Location = new Point(740, 102);
            btn_anulartick.Margin = new Padding(3, 2, 3, 2);
            btn_anulartick.Name = "btn_anulartick";
            btn_anulartick.Size = new Size(51, 38);
            btn_anulartick.TabIndex = 12;
            toolTip.SetToolTip(btn_anulartick, "Anular");
            btn_anulartick.UseVisualStyleBackColor = false;
            btn_anulartick.Click += btn_anulartick_Click;
            // 
            // btn_nuevoDoc
            // 
            btn_nuevoDoc.BackColor = Color.Silver;
            btn_nuevoDoc.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_nuevoDoc.Image = (Image)resources.GetObject("btn_nuevoDoc.Image");
            btn_nuevoDoc.Location = new Point(581, 102);
            btn_nuevoDoc.Margin = new Padding(3, 2, 3, 2);
            btn_nuevoDoc.Name = "btn_nuevoDoc";
            btn_nuevoDoc.Size = new Size(51, 38);
            btn_nuevoDoc.TabIndex = 1;
            toolTip.SetToolTip(btn_nuevoDoc, "Nuevo");
            btn_nuevoDoc.UseVisualStyleBackColor = false;
            btn_nuevoDoc.Click += btn_nuevoDoc_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = Color.Silver;
            btn_limpiar.Enabled = false;
            btn_limpiar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_limpiar.Image = (Image)resources.GetObject("btn_limpiar.Image");
            btn_limpiar.Location = new Point(687, 102);
            btn_limpiar.Margin = new Padding(3, 2, 3, 2);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(51, 38);
            btn_limpiar.TabIndex = 11;
            toolTip.SetToolTip(btn_limpiar, "Limpiar");
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // lbl_nompro
            // 
            lbl_nompro.AutoSize = true;
            lbl_nompro.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_nompro.Location = new Point(10, 113);
            lbl_nompro.Name = "lbl_nompro";
            lbl_nompro.Size = new Size(66, 16);
            lbl_nompro.TabIndex = 24;
            lbl_nompro.Text = "Campaña:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(10, 15);
            label7.Name = "label7";
            label7.Size = new Size(52, 16);
            label7.TabIndex = 23;
            label7.Text = "Reg N°:";
            // 
            // txt_num
            // 
            txt_num.BackColor = SystemColors.Window;
            txt_num.Enabled = false;
            txt_num.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_num.Location = new Point(102, 10);
            txt_num.Name = "txt_num";
            txt_num.ReadOnly = true;
            txt_num.Size = new Size(161, 22);
            txt_num.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBox1);
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
            // textBox1
            // 
            textBox1.Location = new Point(419, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 22);
            textBox1.TabIndex = 12;
            // 
            // txt_nomcli
            // 
            txt_nomcli.BackColor = SystemColors.Window;
            txt_nomcli.Enabled = false;
            txt_nomcli.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nomcli.Location = new Point(410, 6);
            txt_nomcli.Name = "txt_nomcli";
            txt_nomcli.ReadOnly = true;
            txt_nomcli.Size = new Size(161, 22);
            txt_nomcli.TabIndex = 8;
            txt_nomcli.Leave += txt_nomcli_Leave;
            // 
            // lbl_codcli
            // 
            lbl_codcli.AutoSize = true;
            lbl_codcli.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_codcli.Location = new Point(10, 9);
            lbl_codcli.Name = "lbl_codcli";
            lbl_codcli.Size = new Size(80, 16);
            lbl_codcli.TabIndex = 10;
            lbl_codcli.Text = "Cod. cliente:";
            lbl_codcli.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_saldocli
            // 
            txt_saldocli.BackColor = SystemColors.Window;
            txt_saldocli.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_saldocli.ForeColor = SystemColors.WindowText;
            txt_saldocli.Location = new Point(678, 6);
            txt_saldocli.Name = "txt_saldocli";
            txt_saldocli.ReadOnly = true;
            txt_saldocli.Size = new Size(161, 22);
            txt_saldocli.TabIndex = 13;
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
            lbl_salcli.Location = new Point(622, 10);
            lbl_salcli.Name = "lbl_salcli";
            lbl_salcli.Size = new Size(44, 16);
            lbl_salcli.TabIndex = 7;
            lbl_salcli.Text = "Saldo:";
            lbl_salcli.Visible = false;
            // 
            // cmb_loc
            // 
            cmb_loc.Enabled = false;
            cmb_loc.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_loc.FormattingEnabled = true;
            cmb_loc.Location = new Point(102, 38);
            cmb_loc.Name = "cmb_loc";
            cmb_loc.Size = new Size(161, 24);
            cmb_loc.TabIndex = 3;
            cmb_loc.TextUpdate += cmb_loc_TextUpdate;
            cmb_loc.TextChanged += cmb_loc_TextChanged;
            cmb_loc.Click += cmb_loc_Click;
            cmb_loc.KeyDown += cmb_loc_KeyDown;
            cmb_loc.Leave += cmb_loc_Leave;
            // 
            // btn_grabarTicket
            // 
            btn_grabarTicket.BackColor = Color.Silver;
            btn_grabarTicket.Enabled = false;
            btn_grabarTicket.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_grabarTicket.Image = (Image)resources.GetObject("btn_grabarTicket.Image");
            btn_grabarTicket.Location = new Point(634, 102);
            btn_grabarTicket.Margin = new Padding(3, 2, 3, 2);
            btn_grabarTicket.Name = "btn_grabarTicket";
            btn_grabarTicket.Size = new Size(51, 38);
            btn_grabarTicket.TabIndex = 9;
            toolTip.SetToolTip(btn_grabarTicket, "Guardar");
            btn_grabarTicket.UseVisualStyleBackColor = false;
            btn_grabarTicket.Click += btn_grabarTicket_Click;
            // 
            // pib_dobleT
            // 
            pib_dobleT.Image = (Image)resources.GetObject("pib_dobleT.Image");
            pib_dobleT.Location = new Point(326, 105);
            pib_dobleT.Name = "pib_dobleT";
            pib_dobleT.Size = new Size(24, 24);
            pib_dobleT.SizeMode = PictureBoxSizeMode.AutoSize;
            pib_dobleT.TabIndex = 27;
            pib_dobleT.TabStop = false;
            pib_dobleT.Visible = false;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dtg_lisDoc);
            tabPage1.Controls.Add(panel3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(867, 425);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Listado";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtg_lisDoc
            // 
            dtg_lisDoc.BackgroundColor = Color.Gainsboro;
            dtg_lisDoc.BorderStyle = BorderStyle.Fixed3D;
            dtg_lisDoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_lisDoc.Location = new Point(6, 52);
            dtg_lisDoc.Name = "dtg_lisDoc";
            dtg_lisDoc.ReadOnly = true;
            dtg_lisDoc.RowHeadersWidth = 51;
            dtg_lisDoc.RowTemplate.Height = 25;
            dtg_lisDoc.Size = new Size(855, 367);
            dtg_lisDoc.TabIndex = 0;
            dtg_lisDoc.CellDoubleClick += dtg_lisDoc_CellDoubleClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSteelBlue;
            panel3.Controls.Add(btn_busTick);
            panel3.Controls.Add(txt_busTick);
            panel3.Location = new Point(6, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(855, 42);
            panel3.TabIndex = 3;
            // 
            // btn_busTick
            // 
            btn_busTick.BackColor = Color.LightGray;
            btn_busTick.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_busTick.Image = (Image)resources.GetObject("btn_busTick.Image");
            btn_busTick.ImageAlign = ContentAlignment.MiddleRight;
            btn_busTick.Location = new Point(308, 5);
            btn_busTick.Name = "btn_busTick";
            btn_busTick.Size = new Size(100, 32);
            btn_busTick.TabIndex = 2;
            btn_busTick.Text = "Buscar";
            btn_busTick.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_busTick.UseVisualStyleBackColor = false;
            btn_busTick.Click += btn_busTick_Click;
            // 
            // txt_busTick
            // 
            txt_busTick.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_busTick.Location = new Point(27, 10);
            txt_busTick.Name = "txt_busTick";
            txt_busTick.Size = new Size(259, 22);
            txt_busTick.TabIndex = 1;
            // 
            // Tickets
            // 
            Tickets.Controls.Add(btn_impTicket);
            Tickets.Controls.Add(panel_impTickets);
            Tickets.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Tickets.Location = new Point(4, 24);
            Tickets.Name = "Tickets";
            Tickets.Size = new Size(867, 425);
            Tickets.TabIndex = 2;
            Tickets.Text = "Tickets";
            Tickets.UseVisualStyleBackColor = true;
            // 
            // btn_impTicket
            // 
            btn_impTicket.BackColor = Color.LightGray;
            btn_impTicket.Enabled = false;
            btn_impTicket.Location = new Point(19, 12);
            btn_impTicket.Name = "btn_impTicket";
            btn_impTicket.Size = new Size(100, 32);
            btn_impTicket.TabIndex = 1;
            btn_impTicket.Text = "Imprimir";
            btn_impTicket.UseVisualStyleBackColor = false;
            btn_impTicket.Click += btn_impTicket_Click;
            // 
            // panel_impTickets
            // 
            panel_impTickets.Controls.Add(label9);
            panel_impTickets.Controls.Add(panel4);
            panel_impTickets.Location = new Point(19, 57);
            panel_impTickets.Name = "panel_impTickets";
            panel_impTickets.Size = new Size(828, 257);
            panel_impTickets.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(lbl_numdT);
            panel4.Controls.Add(label19);
            panel4.Controls.Add(txt_dirT);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(lbl_fechaproT);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(txt_telfT);
            panel4.Controls.Add(lbl_nregdocT);
            panel4.Controls.Add(txt_nomcliT);
            panel4.Controls.Add(txt_proT);
            panel4.Location = new Point(21, 9);
            panel4.Name = "panel4";
            panel4.Size = new Size(248, 211);
            panel4.TabIndex = 35;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(71, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(103, 46);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 37;
            pictureBox3.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(79, 188);
            label8.Name = "label8";
            label8.Size = new Size(90, 16);
            label8.TabIndex = 36;
            label8.Text = "Válido hasta:";
            // 
            // lbl_numdT
            // 
            lbl_numdT.AutoSize = true;
            lbl_numdT.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_numdT.Location = new Point(3, 189);
            lbl_numdT.Name = "lbl_numdT";
            lbl_numdT.Size = new Size(48, 15);
            lbl_numdT.TabIndex = 24;
            lbl_numdT.Text = "Nº. Doc";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(10, 157);
            label19.Name = "label19";
            label19.Size = new Size(65, 16);
            label19.TabIndex = 31;
            label19.Text = "Dirección:";
            // 
            // txt_dirT
            // 
            txt_dirT.BackColor = SystemColors.Window;
            txt_dirT.BorderStyle = BorderStyle.None;
            txt_dirT.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_dirT.Location = new Point(82, 158);
            txt_dirT.Name = "txt_dirT";
            txt_dirT.ReadOnly = true;
            txt_dirT.Size = new Size(148, 15);
            txt_dirT.TabIndex = 32;
            txt_dirT.TextChanged += txt_dirT_TextChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(10, 131);
            label18.Name = "label18";
            label18.Size = new Size(58, 16);
            label18.TabIndex = 29;
            label18.Text = "Teléfono:";
            // 
            // lbl_fechaproT
            // 
            lbl_fechaproT.AutoSize = true;
            lbl_fechaproT.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_fechaproT.Location = new Point(172, 187);
            lbl_fechaproT.Name = "lbl_fechaproT";
            lbl_fechaproT.Size = new Size(51, 16);
            lbl_fechaproT.TabIndex = 34;
            lbl_fechaproT.Text = "Fecha: ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(10, 105);
            label17.Name = "label17";
            label17.Size = new Size(56, 16);
            label17.TabIndex = 27;
            label17.Text = "Nombre:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(45, 75);
            label14.Name = "label14";
            label14.Size = new Size(90, 19);
            label14.TabIndex = 26;
            label14.Text = "TICKET Nº";
            // 
            // txt_telfT
            // 
            txt_telfT.BackColor = SystemColors.Window;
            txt_telfT.BorderStyle = BorderStyle.None;
            txt_telfT.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_telfT.Location = new Point(82, 132);
            txt_telfT.Name = "txt_telfT";
            txt_telfT.ReadOnly = true;
            txt_telfT.Size = new Size(148, 15);
            txt_telfT.TabIndex = 30;
            // 
            // lbl_nregdocT
            // 
            lbl_nregdocT.AutoSize = true;
            lbl_nregdocT.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nregdocT.Location = new Point(135, 75);
            lbl_nregdocT.Name = "lbl_nregdocT";
            lbl_nregdocT.Size = new Size(104, 19);
            lbl_nregdocT.TabIndex = 25;
            lbl_nregdocT.Text = "Nº. Reg_doc";
            // 
            // txt_nomcliT
            // 
            txt_nomcliT.BackColor = SystemColors.Window;
            txt_nomcliT.BorderStyle = BorderStyle.None;
            txt_nomcliT.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nomcliT.Location = new Point(82, 106);
            txt_nomcliT.Name = "txt_nomcliT";
            txt_nomcliT.ReadOnly = true;
            txt_nomcliT.Size = new Size(148, 15);
            txt_nomcliT.TabIndex = 28;
            // 
            // txt_proT
            // 
            txt_proT.BackColor = SystemColors.Window;
            txt_proT.BorderStyle = BorderStyle.None;
            txt_proT.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_proT.Location = new Point(3, 50);
            txt_proT.Name = "txt_proT";
            txt_proT.ReadOnly = true;
            txt_proT.Size = new Size(240, 22);
            txt_proT.TabIndex = 35;
            txt_proT.Text = "CAMPAÑA";
            txt_proT.TextAlign = HorizontalAlignment.Center;
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
            // printDocument1
            // 
            printDocument1.PrintPage += ImprimiTicket;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 233);
            label9.Name = "label9";
            label9.Size = new Size(10, 15);
            label9.TabIndex = 36;
            label9.Text = ".";
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pib_dobleT).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_lisDoc).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            Tickets.ResumeLayout(false);
            panel_impTickets.ResumeLayout(false);
            panel_impTickets.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private Label lbl_codcli;
        private TextBox txt_nomcli;
        private TextBox txt_num;
        private Label label7;
        private Label lbl_nompro;
        private Button btn_limpiar;
        private TextBox textBox1;
        private DataGridView dtg_lisDoc;
        private Button btn_busTick;
        private TextBox txt_busTick;
        private Panel panel3;
        private Button btn_nuevoDoc;
        private ToolTip toolTip;
        private Button btn_anulartick;
        private TabPage Tickets;
        private Panel panel_impTickets;
        private Label label17;
        private Label label14;
        private Label lbl_nregdocT;
        private Label lbl_numdT;
        private TextBox txt_telfT;
        private Label label18;
        private TextBox txt_nomcliT;
        private TextBox txt_dirT;
        private Label label19;
        private Label lbl_fechaproT;
        private Panel panel4;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button btn_impTicket;
        private TextBox txt_proT;
        private ComboBox cmb_nompro;
        private CheckBox chk_dobleTi;
        private PictureBox pictureBox2;
        private PictureBox pib_dobleT;
        private Label label8;
        private PictureBox pictureBox3;
        private Label label9;
    }
}