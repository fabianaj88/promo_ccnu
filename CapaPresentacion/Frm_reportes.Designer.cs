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
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            btn_acprep1 = new Button();
            panel_rep1 = new Panel();
            label1 = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            panel2 = new Panel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            panel_rep1.SuspendLayout();
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
            tabControl1.ItemSize = new Size(20, 200);
            tabControl1.Location = new Point(41, 76);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(840, 423);
            tabControl1.TabIndex = 1;
            tabControl1.DrawItem += tabControl1_DrawItem;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage1.Location = new Point(204, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(632, 415);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ventas por almacén";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(btn_acprep1);
            panel1.Controls.Add(panel_rep1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(626, 409);
            panel1.TabIndex = 0;
            // 
            // btn_acprep1
            // 
            btn_acprep1.BackColor = Color.Silver;
            btn_acprep1.Location = new Point(72, 24);
            btn_acprep1.Name = "btn_acprep1";
            btn_acprep1.Size = new Size(75, 23);
            btn_acprep1.TabIndex = 1;
            btn_acprep1.Text = "Aceptar";
            btn_acprep1.UseVisualStyleBackColor = false;
            btn_acprep1.Click += btn_acprep1_Click;
            // 
            // panel_rep1
            // 
            panel_rep1.BackColor = SystemColors.Window;
            panel_rep1.Controls.Add(label1);
            panel_rep1.Location = new Point(95, 91);
            panel_rep1.Name = "panel_rep1";
            panel_rep1.Size = new Size(337, 202);
            panel_rep1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 76);
            label1.Name = "label1";
            label1.Size = new Size(35, 16);
            label1.TabIndex = 0;
            label1.Text = "hola";
            // 
            // tabPage2
            // 
            tabPage2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage2.Location = new Point(204, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(632, 415);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ventas por género";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(panel2);
            tabPage3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage3.Location = new Point(204, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(632, 415);
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
            panel2.Size = new Size(626, 409);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(411, 31);
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
            panel_rep1.ResumeLayout(false);
            panel_rep1.PerformLayout();
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
        private Label label1;
        private Button btn_acprep1;
    }
}