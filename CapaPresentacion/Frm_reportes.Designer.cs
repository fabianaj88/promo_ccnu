namespace CapaPresentacion
{
    partial class Frm_reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_reportes));
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            panel3 = new Panel();
            btn_pdfrep1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            cmb_locrep1 = new ComboBox();
            dtp_desdrep1 = new DateTimePicker();
            panel4 = new Panel();
            dtp_hastarep1 = new DateTimePicker();
            btn_acprep1 = new Button();
            panel_rep1 = new Panel();
            label1 = new Label();
            dgv_rep1 = new DataGridView();
            tabPage2 = new TabPage();
            panel5 = new Panel();
            panel_rep2 = new Panel();
            dgv_rep2 = new DataGridView();
            label8 = new Label();
            panel6 = new Panel();
            btn_pdfrep2 = new Button();
            label6 = new Label();
            label7 = new Label();
            dtp_desderep2 = new DateTimePicker();
            dtp_hastarep2 = new DateTimePicker();
            panel7 = new Panel();
            btn_aceprep2 = new Button();
            tabPage3 = new TabPage();
            panel2 = new Panel();
            panel10 = new Panel();
            dgv_rep3 = new DataGridView();
            label11 = new Label();
            panel9 = new Panel();
            btn_pdfrep3 = new Button();
            label9 = new Label();
            label10 = new Label();
            dtp_desderep3 = new DateTimePicker();
            dtp_hastarep3 = new DateTimePicker();
            panel8 = new Panel();
            btn_aceprep3 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel_rep1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_rep1).BeginInit();
            tabPage2.SuspendLayout();
            panel5.SuspendLayout();
            panel_rep2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_rep2).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            tabPage3.SuspendLayout();
            panel2.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_rep3).BeginInit();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
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
            tabControl1.Alignment = TabAlignment.Left;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.ImeMode = ImeMode.NoControl;
            tabControl1.ItemSize = new Size(10, 150);
            tabControl1.Location = new Point(26, 62);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(869, 433);
            tabControl1.TabIndex = 1;
            tabControl1.DrawItem += tabControl1_DrawItem;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage1.Location = new Point(154, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(711, 425);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ventas por almacén";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel_rep1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(705, 419);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSteelBlue;
            panel3.Controls.Add(btn_pdfrep1);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(cmb_locrep1);
            panel3.Controls.Add(dtp_desdrep1);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(699, 78);
            panel3.TabIndex = 2;
            // 
            // btn_pdfrep1
            // 
            btn_pdfrep1.Enabled = false;
            btn_pdfrep1.Location = new Point(551, 25);
            btn_pdfrep1.Name = "btn_pdfrep1";
            btn_pdfrep1.Size = new Size(82, 27);
            btn_pdfrep1.TabIndex = 8;
            btn_pdfrep1.Text = "PDF";
            btn_pdfrep1.UseVisualStyleBackColor = true;
            btn_pdfrep1.Click += btn_pdfrep1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(193, 47);
            label5.Name = "label5";
            label5.Size = new Size(45, 16);
            label5.TabIndex = 7;
            label5.Text = "Hasta:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(15, 47);
            label4.Name = "label4";
            label4.Size = new Size(48, 16);
            label4.TabIndex = 6;
            label4.Text = "Desde:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 16);
            label2.Name = "label2";
            label2.Size = new Size(42, 16);
            label2.TabIndex = 5;
            label2.Text = "Local:";
            // 
            // cmb_locrep1
            // 
            cmb_locrep1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_locrep1.FormattingEnabled = true;
            cmb_locrep1.Location = new Point(65, 13);
            cmb_locrep1.Name = "cmb_locrep1";
            cmb_locrep1.Size = new Size(168, 24);
            cmb_locrep1.TabIndex = 4;
            cmb_locrep1.Click += cmb_locrep1_Click;
            cmb_locrep1.Leave += cmb_locrep1_Leave;
            // 
            // dtp_desdrep1
            // 
            dtp_desdrep1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_desdrep1.Format = DateTimePickerFormat.Short;
            dtp_desdrep1.Location = new Point(65, 43);
            dtp_desdrep1.Name = "dtp_desdrep1";
            dtp_desdrep1.Size = new Size(117, 22);
            dtp_desdrep1.TabIndex = 2;
            dtp_desdrep1.Value = new DateTime(1999, 1, 1, 12, 59, 0, 0);
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(dtp_hastarep1);
            panel4.Controls.Add(btn_acprep1);
            panel4.Location = new Point(6, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(489, 72);
            panel4.TabIndex = 9;
            // 
            // dtp_hastarep1
            // 
            dtp_hastarep1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_hastarep1.Format = DateTimePickerFormat.Short;
            dtp_hastarep1.Location = new Point(234, 38);
            dtp_hastarep1.Name = "dtp_hastarep1";
            dtp_hastarep1.Size = new Size(117, 22);
            dtp_hastarep1.TabIndex = 3;
            dtp_hastarep1.Value = new DateTime(1999, 1, 1, 12, 59, 0, 0);
            // 
            // btn_acprep1
            // 
            btn_acprep1.BackColor = Color.Silver;
            btn_acprep1.Location = new Point(385, 20);
            btn_acprep1.Name = "btn_acprep1";
            btn_acprep1.Size = new Size(86, 27);
            btn_acprep1.TabIndex = 1;
            btn_acprep1.Text = "Aceptar";
            btn_acprep1.UseVisualStyleBackColor = false;
            btn_acprep1.Click += btn_acprep1_Click;
            // 
            // panel_rep1
            // 
            panel_rep1.BackColor = SystemColors.Window;
            panel_rep1.Controls.Add(label1);
            panel_rep1.Controls.Add(dgv_rep1);
            panel_rep1.Location = new Point(3, 85);
            panel_rep1.Name = "panel_rep1";
            panel_rep1.Size = new Size(699, 329);
            panel_rep1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(225, 14);
            label1.Name = "label1";
            label1.Size = new Size(222, 16);
            label1.TabIndex = 2;
            label1.Text = "REPORTE VENTAS POR ALMACEN";
            // 
            // dgv_rep1
            // 
            dgv_rep1.BackgroundColor = SystemColors.Window;
            dgv_rep1.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgv_rep1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgv_rep1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgv_rep1.DefaultCellStyle = dataGridViewCellStyle11;
            dgv_rep1.Location = new Point(7, 41);
            dgv_rep1.Name = "dgv_rep1";
            dgv_rep1.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgv_rep1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgv_rep1.RowTemplate.Height = 25;
            dgv_rep1.Size = new Size(684, 283);
            dgv_rep1.TabIndex = 1;
            dgv_rep1.RowPrePaint += dgv_rep1_RowPrePaint;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel5);
            tabPage2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage2.Location = new Point(154, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(711, 425);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ventas por género";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gainsboro;
            panel5.Controls.Add(panel_rep2);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(705, 419);
            panel5.TabIndex = 0;
            // 
            // panel_rep2
            // 
            panel_rep2.BackColor = SystemColors.Window;
            panel_rep2.Controls.Add(dgv_rep2);
            panel_rep2.Controls.Add(label8);
            panel_rep2.Location = new Point(4, 89);
            panel_rep2.Name = "panel_rep2";
            panel_rep2.Size = new Size(697, 324);
            panel_rep2.TabIndex = 1;
            // 
            // dgv_rep2
            // 
            dgv_rep2.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = SystemColors.Control;
            dataGridViewCellStyle13.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dgv_rep2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dgv_rep2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.Window;
            dataGridViewCellStyle14.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dgv_rep2.DefaultCellStyle = dataGridViewCellStyle14;
            dgv_rep2.Location = new Point(6, 37);
            dgv_rep2.Name = "dgv_rep2";
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = SystemColors.Control;
            dataGridViewCellStyle15.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dgv_rep2.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dgv_rep2.RowTemplate.Height = 25;
            dgv_rep2.Size = new Size(685, 279);
            dgv_rep2.TabIndex = 4;
            dgv_rep2.RowPrePaint += dgv_rep2_RowPrePaint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(243, 13);
            label8.Name = "label8";
            label8.Size = new Size(213, 16);
            label8.TabIndex = 3;
            label8.Text = "REPORTE VENTAS POR GENERO";
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightSteelBlue;
            panel6.Controls.Add(btn_pdfrep2);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(dtp_desderep2);
            panel6.Controls.Add(dtp_hastarep2);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(4, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(697, 79);
            panel6.TabIndex = 0;
            // 
            // btn_pdfrep2
            // 
            btn_pdfrep2.Enabled = false;
            btn_pdfrep2.Location = new Point(557, 23);
            btn_pdfrep2.Name = "btn_pdfrep2";
            btn_pdfrep2.Size = new Size(75, 30);
            btn_pdfrep2.TabIndex = 13;
            btn_pdfrep2.Text = "PDF";
            btn_pdfrep2.UseVisualStyleBackColor = true;
            btn_pdfrep2.Click += btn_pdfrep2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(198, 34);
            label6.Name = "label6";
            label6.Size = new Size(45, 16);
            label6.TabIndex = 11;
            label6.Text = "Hasta:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(13, 34);
            label7.Name = "label7";
            label7.Size = new Size(48, 16);
            label7.TabIndex = 10;
            label7.Text = "Desde:";
            // 
            // dtp_desderep2
            // 
            dtp_desderep2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_desderep2.Format = DateTimePickerFormat.Short;
            dtp_desderep2.Location = new Point(67, 29);
            dtp_desderep2.Name = "dtp_desderep2";
            dtp_desderep2.Size = new Size(117, 22);
            dtp_desderep2.TabIndex = 8;
            dtp_desderep2.Value = new DateTime(1999, 1, 1, 12, 59, 0, 0);
            // 
            // dtp_hastarep2
            // 
            dtp_hastarep2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_hastarep2.Format = DateTimePickerFormat.Short;
            dtp_hastarep2.Location = new Point(249, 29);
            dtp_hastarep2.Name = "dtp_hastarep2";
            dtp_hastarep2.Size = new Size(117, 22);
            dtp_hastarep2.TabIndex = 9;
            dtp_hastarep2.Value = new DateTime(1999, 1, 1, 12, 59, 0, 0);
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Controls.Add(btn_aceprep2);
            panel7.Location = new Point(6, 6);
            panel7.Name = "panel7";
            panel7.Size = new Size(486, 67);
            panel7.TabIndex = 12;
            // 
            // btn_aceprep2
            // 
            btn_aceprep2.Location = new Point(392, 15);
            btn_aceprep2.Name = "btn_aceprep2";
            btn_aceprep2.Size = new Size(75, 30);
            btn_aceprep2.TabIndex = 0;
            btn_aceprep2.Text = "Aceptar";
            btn_aceprep2.UseVisualStyleBackColor = true;
            btn_aceprep2.Click += btn_aceprep2_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(panel2);
            tabPage3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage3.Location = new Point(154, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(711, 425);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Ventas por edad";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(panel9);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(705, 419);
            panel2.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.Window;
            panel10.Controls.Add(dgv_rep3);
            panel10.Controls.Add(label11);
            panel10.Location = new Point(4, 89);
            panel10.Name = "panel10";
            panel10.Size = new Size(697, 324);
            panel10.TabIndex = 2;
            // 
            // dgv_rep3
            // 
            dgv_rep3.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = SystemColors.Control;
            dataGridViewCellStyle16.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            dgv_rep3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            dgv_rep3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = SystemColors.Window;
            dataGridViewCellStyle17.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.False;
            dgv_rep3.DefaultCellStyle = dataGridViewCellStyle17;
            dgv_rep3.Location = new Point(6, 37);
            dgv_rep3.Name = "dgv_rep3";
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = SystemColors.Control;
            dataGridViewCellStyle18.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            dgv_rep3.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            dgv_rep3.RowTemplate.Height = 25;
            dgv_rep3.Size = new Size(685, 279);
            dgv_rep3.TabIndex = 4;
            dgv_rep3.RowPrePaint += dgv_rep3_RowPrePaint;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(243, 13);
            label11.Name = "label11";
            label11.Size = new Size(194, 16);
            label11.TabIndex = 3;
            label11.Text = "REPORTE VENTAS POR EDAD";
            // 
            // panel9
            // 
            panel9.BackColor = Color.LightSteelBlue;
            panel9.Controls.Add(btn_pdfrep3);
            panel9.Controls.Add(label9);
            panel9.Controls.Add(label10);
            panel9.Controls.Add(dtp_desderep3);
            panel9.Controls.Add(dtp_hastarep3);
            panel9.Controls.Add(panel8);
            panel9.Location = new Point(4, 5);
            panel9.Name = "panel9";
            panel9.Size = new Size(697, 79);
            panel9.TabIndex = 1;
            // 
            // btn_pdfrep3
            // 
            btn_pdfrep3.Enabled = false;
            btn_pdfrep3.Location = new Point(557, 23);
            btn_pdfrep3.Name = "btn_pdfrep3";
            btn_pdfrep3.Size = new Size(75, 30);
            btn_pdfrep3.TabIndex = 13;
            btn_pdfrep3.Text = "PDF";
            btn_pdfrep3.UseVisualStyleBackColor = true;
            btn_pdfrep3.Click += btn_pdfrep3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(198, 34);
            label9.Name = "label9";
            label9.Size = new Size(45, 16);
            label9.TabIndex = 11;
            label9.Text = "Hasta:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(13, 34);
            label10.Name = "label10";
            label10.Size = new Size(48, 16);
            label10.TabIndex = 10;
            label10.Text = "Desde:";
            // 
            // dtp_desderep3
            // 
            dtp_desderep3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_desderep3.Format = DateTimePickerFormat.Short;
            dtp_desderep3.Location = new Point(67, 29);
            dtp_desderep3.Name = "dtp_desderep3";
            dtp_desderep3.Size = new Size(117, 22);
            dtp_desderep3.TabIndex = 8;
            dtp_desderep3.Value = new DateTime(1999, 1, 1, 12, 59, 0, 0);
            // 
            // dtp_hastarep3
            // 
            dtp_hastarep3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_hastarep3.Format = DateTimePickerFormat.Short;
            dtp_hastarep3.Location = new Point(249, 29);
            dtp_hastarep3.Name = "dtp_hastarep3";
            dtp_hastarep3.Size = new Size(117, 22);
            dtp_hastarep3.TabIndex = 9;
            dtp_hastarep3.Value = new DateTime(1999, 1, 1, 12, 59, 0, 0);
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.Fixed3D;
            panel8.Controls.Add(btn_aceprep3);
            panel8.Location = new Point(6, 6);
            panel8.Name = "panel8";
            panel8.Size = new Size(486, 67);
            panel8.TabIndex = 12;
            // 
            // btn_aceprep3
            // 
            btn_aceprep3.Location = new Point(392, 15);
            btn_aceprep3.Name = "btn_aceprep3";
            btn_aceprep3.Size = new Size(75, 30);
            btn_aceprep3.TabIndex = 0;
            btn_aceprep3.Text = "Aceptar";
            btn_aceprep3.UseVisualStyleBackColor = true;
            btn_aceprep3.Click += btn_aceprep3_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(411, 27);
            label3.Name = "label3";
            label3.Size = new Size(122, 28);
            label3.TabIndex = 15;
            label3.Text = "REPORTES";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Frm_reportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 545);
            Controls.Add(label3);
            Controls.Add(tabControl1);
            Controls.Add(pictureBox1);
            Name = "Frm_reportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_reportes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel_rep1.ResumeLayout(false);
            panel_rep1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_rep1).EndInit();
            tabPage2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel_rep2.ResumeLayout(false);
            panel_rep2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_rep2).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_rep3).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Panel panel_rep1;
        private Button btn_acprep1;
        private Panel panel3;
        private DateTimePicker dtp_hastarep1;
        private DateTimePicker dtp_desdrep1;
        private Label label5;
        private Label label4;
        private Label label2;
        private ComboBox cmb_locrep1;
        private DataGridView dgv_rep1;
        private Label label1;
        private Button btn_pdfrep1;
        private Panel panel4;
        private Panel panel5;
        private Panel panel_rep2;
        private Panel panel6;
        private Label label6;
        private Label label7;
        private DateTimePicker dtp_desderep2;
        private DateTimePicker dtp_hastarep2;
        private Panel panel7;
        private Button btn_pdfrep2;
        private Button btn_aceprep2;
        private Label label8;
        private DataGridView dgv_rep2;
        private Panel panel10;
        private DataGridView dgv_rep3;
        private Label label11;
        private Panel panel9;
        private Button btn_pdfrep3;
        private Label label9;
        private Label label10;
        private DateTimePicker dtp_desderep3;
        private DateTimePicker dtp_hastarep3;
        private Panel panel8;
        private Button btn_aceprep3;
    }
}