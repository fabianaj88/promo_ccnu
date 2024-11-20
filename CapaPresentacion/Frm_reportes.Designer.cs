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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            tabPage3 = new TabPage();
            panel2 = new Panel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel_rep1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_rep1).BeginInit();
            tabPage3.SuspendLayout();
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
            btn_pdfrep1.Location = new Point(572, 42);
            btn_pdfrep1.Name = "btn_pdfrep1";
            btn_pdfrep1.Size = new Size(47, 27);
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
            btn_acprep1.Location = new Point(384, 34);
            btn_acprep1.Name = "btn_acprep1";
            btn_acprep1.Size = new Size(86, 28);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_rep1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_rep1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_rep1.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_rep1.Location = new Point(7, 41);
            dgv_rep1.Name = "dgv_rep1";
            dgv_rep1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_rep1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_rep1.RowTemplate.Height = 25;
            dgv_rep1.Size = new Size(684, 283);
            dgv_rep1.TabIndex = 1;
            dgv_rep1.RowPrePaint += dgv_rep1_RowPrePaint;
            // 
            // tabPage2
            // 
            tabPage2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage2.Location = new Point(154, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(711, 425);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ventas por género";
            tabPage2.UseVisualStyleBackColor = true;
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
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(705, 419);
            panel2.TabIndex = 0;
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
            tabPage3.ResumeLayout(false);
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
    }
}