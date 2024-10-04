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
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            button2 = new Button();
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
            // textBox1
            // 
            textBox1.Location = new Point(190, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(307, 27);
            textBox1.TabIndex = 2;
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
            // textBox2
            // 
            textBox2.Location = new Point(190, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(307, 27);
            textBox2.TabIndex = 4;
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
            // textBox3
            // 
            textBox3.Location = new Point(190, 114);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(307, 27);
            textBox3.TabIndex = 6;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(619, 32);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(301, 27);
            dateTimePicker1.TabIndex = 8;
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
            // textBox4
            // 
            textBox4.Location = new Point(619, 75);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(113, 27);
            textBox4.TabIndex = 10;
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
            // textBox5
            // 
            textBox5.Location = new Point(619, 118);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(365, 27);
            textBox5.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new Point(50, 165);
            button2.Name = "button2";
            button2.Size = new Size(149, 29);
            button2.TabIndex = 13;
            button2.Text = "Generar Tickets";
            button2.UseVisualStyleBackColor = true;
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
            Controls.Add(button2);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Button button2;
        private Panel panel1;
        private DataGridView dataGridView1;
    }
}