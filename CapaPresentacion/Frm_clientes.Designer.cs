﻿namespace CapaPresentacion
{
    partial class Frm_clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_clientes));
            contextMenuStrip1 = new ContextMenuStrip(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            txt_codigo = new TextBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btn_buscar = new Button();
            btn_eliminar = new Button();
            btn_editar = new Button();
            btn_grabar = new Button();
            btn_nuevo = new Button();
            pictureBox1 = new PictureBox();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.ShowCheckMargin = true;
            contextMenuStrip1.ShowImageMargin = false;
            contextMenuStrip1.Size = new Size(61, 4);
            contextMenuStrip1.Text = "1";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(857, 465);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.WhiteSmoke;
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(txt_codigo);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(pictureBox3);
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Controls.Add(btn_buscar);
            tabPage1.Controls.Add(btn_eliminar);
            tabPage1.Controls.Add(btn_editar);
            tabPage1.Controls.Add(btn_grabar);
            tabPage1.Controls.Add(btn_nuevo);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(849, 437);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registro";
            tabPage1.Click += tabPage1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 209);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 13;
            label2.Text = "Cliente";
            label2.Click += label2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(106, 297);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(203, 23);
            textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(106, 250);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(388, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(106, 206);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(388, 23);
            textBox1.TabIndex = 10;
            // 
            // txt_codigo
            // 
            txt_codigo.Location = new Point(106, 166);
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(203, 23);
            txt_codigo.TabIndex = 9;
            txt_codigo.TextChanged += txt_codigo_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 166);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 8;
            label1.Text = "Código";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.WhiteSmoke;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(17, 139);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(805, 292);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(17, 85);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(805, 38);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // btn_buscar
            // 
            btn_buscar.Image = (Image)resources.GetObject("btn_buscar.Image");
            btn_buscar.Location = new Point(451, 48);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(75, 23);
            btn_buscar.TabIndex = 5;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Image = (Image)resources.GetObject("btn_eliminar.Image");
            btn_eliminar.Location = new Point(353, 48);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(75, 23);
            btn_eliminar.TabIndex = 4;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            btn_editar.Image = (Image)resources.GetObject("btn_editar.Image");
            btn_editar.Location = new Point(253, 48);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(75, 23);
            btn_editar.TabIndex = 3;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_grabar
            // 
            btn_grabar.Image = (Image)resources.GetObject("btn_grabar.Image");
            btn_grabar.Location = new Point(151, 48);
            btn_grabar.Name = "btn_grabar";
            btn_grabar.Size = new Size(75, 23);
            btn_grabar.TabIndex = 2;
            btn_grabar.Text = "Grabar";
            btn_grabar.UseVisualStyleBackColor = true;
            // 
            // btn_nuevo
            // 
            btn_nuevo.Image = (Image)resources.GetObject("btn_nuevo.Image");
            btn_nuevo.Location = new Point(55, 48);
            btn_nuevo.Name = "btn_nuevo";
            btn_nuevo.Size = new Size(75, 23);
            btn_nuevo.TabIndex = 1;
            btn_nuevo.Text = "Nuevo";
            btn_nuevo.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightSkyBlue;
            pictureBox1.Location = new Point(17, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(805, 37);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(849, 437);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Listado";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Frm_clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 489);
            Controls.Add(tabControl1);
            Name = "Frm_clientes";
            Text = "Frm_clientes";
            Load += Frm_clientes_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private PictureBox pictureBox1;
        private TabPage tabPage2;
        private Button btn_nuevo;
        private Button btn_eliminar;
        private Button btn_editar;
        private Button btn_grabar;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button btn_buscar;
        private TextBox txt_codigo;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}