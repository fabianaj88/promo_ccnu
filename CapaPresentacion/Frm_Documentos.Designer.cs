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
            button1 = new Button();
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
            label6 = new Label();
            txt_obv = new TextBox();
            btn_gentik = new Button();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(916, 153);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 39);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 1;
            label1.Text = "Número de factura:";
            label1.Click += label1_Click;
            // 
            // txt_numf
            // 
            txt_numf.Location = new Point(190, 30);
            txt_numf.Name = "txt_numf";
            txt_numf.Size = new Size(307, 27);
            txt_numf.TabIndex = 2;
            txt_numf.TextChanged += txt_numf_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 82);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 3;
            label2.Text = "Local:";
            label2.Click += label2_Click;
            // 
            // txt_loc
            // 
            txt_loc.Location = new Point(190, 71);
            txt_loc.Name = "txt_loc";
            txt_loc.Size = new Size(307, 27);
            txt_loc.TabIndex = 4;
            txt_loc.TextChanged += txt_loc_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 125);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 5;
            label3.Text = "Cliente:";
            // 
            // txt_cli
            // 
            txt_cli.Location = new Point(190, 114);
            txt_cli.Name = "txt_cli";
            txt_cli.Size = new Size(307, 27);
            txt_cli.TabIndex = 6;
            txt_cli.TextChanged += txt_cli_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(519, 37);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 7;
            label4.Text = "Fecha:";
            label4.Click += label4_Click;
            // 
            // dtim_fec
            // 
            dtim_fec.Location = new Point(619, 32);
            dtim_fec.Name = "dtim_fec";
            dtim_fec.Size = new Size(365, 27);
            dtim_fec.TabIndex = 8;
            dtim_fec.ValueChanged += dtim_fec_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(519, 82);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 9;
            label5.Text = "Total:";
            // 
            // txt_tot
            // 
            txt_tot.Location = new Point(619, 75);
            txt_tot.Name = "txt_tot";
            txt_tot.Size = new Size(113, 27);
            txt_tot.TabIndex = 10;
            txt_tot.TextChanged += txt_tot_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(519, 125);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 11;
            label6.Text = "Observación:";
            label6.Click += label6_Click;
            // 
            // txt_obv
            // 
            txt_obv.Location = new Point(619, 118);
            txt_obv.Name = "txt_obv";
            txt_obv.Size = new Size(365, 27);
            txt_obv.TabIndex = 12;
            txt_obv.TextChanged += txt_obv_TextChanged;
            // 
            // btn_gentik
            // 
            btn_gentik.Location = new Point(50, 165);
            btn_gentik.Name = "btn_gentik";
            btn_gentik.Size = new Size(149, 29);
            btn_gentik.TabIndex = 13;
            btn_gentik.Text = "Generar Tickets";
            btn_gentik.UseVisualStyleBackColor = true;
            btn_gentik.Click += btn_gentik_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1030, 193);
            panel1.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 211);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1030, 265);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Frm_Documentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 488);
            Controls.Add(dataGridView1);
            Controls.Add(btn_gentik);
            Controls.Add(txt_obv);
            Controls.Add(label6);
            Controls.Add(txt_tot);
            Controls.Add(label5);
            Controls.Add(dtim_fec);
            Controls.Add(label4);
            Controls.Add(txt_cli);
            Controls.Add(label3);
            Controls.Add(txt_loc);
            Controls.Add(label2);
            Controls.Add(txt_numf);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Frm_Documentos";
            Text = "Frm_Documentos";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
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
        private Label label6;
        private TextBox txt_obv;
        private Button btn_gentik;
        private Panel panel1;
        private DataGridView dataGridView1;
    }
}