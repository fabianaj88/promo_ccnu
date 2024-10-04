namespace CapaPresentacion
{
    partial class Frm_grid_listado_clientes
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
            grid_clientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grid_clientes).BeginInit();
            SuspendLayout();
            // 
            // grid_clientes
            // 
            grid_clientes.AllowUserToAddRows = false;
            grid_clientes.AllowUserToDeleteRows = false;
            grid_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_clientes.Location = new Point(-1, 34);
            grid_clientes.Name = "grid_clientes";
            grid_clientes.ReadOnly = true;
            grid_clientes.RowTemplate.Height = 25;
            grid_clientes.Size = new Size(803, 417);
            grid_clientes.TabIndex = 0;
            grid_clientes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Frm_grid_listado_clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grid_clientes);
            Name = "Frm_grid_listado_clientes";
            Text = "Frm_grid_listado_clientes";
            ((System.ComponentModel.ISupportInitialize)grid_clientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grid_clientes;
    }
}