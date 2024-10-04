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
            label1 = new Label();
            txt_numf = new TextBox();
            label2 = new Label();
            txt_loc = new TextBox();
            label3 = new Label();
            txt_cli = new TextBox();
            label4 = new Label();
            dtim_fec = new DateTimePicker();
            label5 = new Label();
            txt_tot = new TextBox();
            btn_gentik = new Button();
            dataGridView1 = new DataGridView();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            panel1 = new Panel();
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSteelBlue;
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(20, 60);
            label1.Name = "label1";
            label1.Size = new Size(97, 16);
            label1.TabIndex = 1;
            label1.Text = "Número de factura:";
            label1.Click += label1_Click;
            // 
            // txt_numf
            // 
            txt_numf.BackColor = SystemColors.MenuBar;
            txt_numf.Location = new Point(136, 52);
            txt_numf.Margin = new Padding(3, 2, 3, 2);
            txt_numf.Name = "txt_numf";
            txt_numf.Size = new Size(269, 22);
            txt_numf.TabIndex = 2;
            txt_numf.TextChanged += txt_numf_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSteelBlue;
            label2.Location = new Point(20, 87);
            label2.Name = "label2";
            label2.Size = new Size(35, 16);
            label2.TabIndex = 3;
            label2.Text = "Local:";
            label2.Click += label2_Click;
            // 
            // txt_loc
            // 
            txt_loc.BackColor = SystemColors.MenuBar;
            txt_loc.Location = new Point(136, 79);
            txt_loc.Margin = new Padding(3, 2, 3, 2);
            txt_loc.Name = "txt_loc";
            txt_loc.Size = new Size(269, 22);
            txt_loc.TabIndex = 4;
            txt_loc.TextChanged += txt_loc_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSteelBlue;
            label3.Location = new Point(20, 114);
            label3.Name = "label3";
            label3.Size = new Size(42, 16);
            label3.TabIndex = 5;
            label3.Text = "Cliente:";
            // 
            // txt_cli
            // 
            txt_cli.BackColor = SystemColors.MenuBar;
            txt_cli.Location = new Point(136, 106);
            txt_cli.Margin = new Padding(3, 2, 3, 2);
            txt_cli.Name = "txt_cli";
            txt_cli.Size = new Size(269, 22);
            txt_cli.TabIndex = 6;
            txt_cli.TextChanged += txt_cli_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(421, 45);
            label4.Name = "label4";
            label4.Size = new Size(40, 16);
            label4.TabIndex = 7;
            label4.Text = "Fecha:";
            label4.Click += label4_Click;
            // 
            // dtim_fec
            // 
            dtim_fec.CalendarMonthBackground = SystemColors.MenuBar;
            dtim_fec.Location = new Point(509, 45);
            dtim_fec.Margin = new Padding(3, 2, 3, 2);
            dtim_fec.Name = "dtim_fec";
            dtim_fec.Size = new Size(228, 22);
            dtim_fec.TabIndex = 8;
            dtim_fec.Value = new DateTime(2024, 10, 4, 11, 8, 27, 0);
            dtim_fec.ValueChanged += dtim_fec_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(421, 79);
            label5.Name = "label5";
            label5.Size = new Size(33, 16);
            label5.TabIndex = 9;
            label5.Text = "Total:";
            // 
            // txt_tot
            // 
            txt_tot.BackColor = SystemColors.MenuBar;
            txt_tot.Location = new Point(509, 73);
            txt_tot.Margin = new Padding(3, 2, 3, 2);
            txt_tot.Name = "txt_tot";
            txt_tot.Size = new Size(99, 22);
            txt_tot.TabIndex = 10;
            txt_tot.TextChanged += txt_tot_TextChanged;
            // 
            // btn_gentik
            // 
            btn_gentik.BackColor = Color.Silver;
            btn_gentik.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_gentik.Image = (Image)resources.GetObject("btn_gentik.Image");
            btn_gentik.Location = new Point(779, 96);
            btn_gentik.Margin = new Padding(3, 2, 3, 2);
            btn_gentik.Name = "btn_gentik";
            btn_gentik.Size = new Size(65, 39);
            btn_gentik.TabIndex = 13;
            btn_gentik.UseVisualStyleBackColor = false;
            btn_gentik.Click += btn_gentik_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ActiveBorder;
            dataGridView1.Location = new Point(6, 151);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(856, 269);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(txt_numf);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(txt_loc);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(txt_cli);
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
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dtim_fec);
            panel1.Controls.Add(btn_gentik);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txt_tot);
            panel1.Location = new Point(6, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(856, 137);
            panel1.TabIndex = 16;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(868, 425);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.GradientInactiveCaption;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(921, 545);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(348, 29);
            label6.Name = "label6";
            label6.Size = new Size(242, 29);
            label6.TabIndex = 18;
            label6.Text = "GENERAR TICKETS";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // Frm_Documentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 539);
            Controls.Add(label6);
            Controls.Add(tabControl1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Frm_Documentos";
            Text = "Frm_Documentos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txt_numf;
        private Label label2;
        private TextBox txt_loc;
        private Label label3;
        private TextBox txt_cli;
        private Label label4;
        private DateTimePicker dtim_fec;
        private Label label5;
        private TextBox txt_tot;
        private Button btn_gentik;
        private DataGridView dataGridView1;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label6;
    }
}