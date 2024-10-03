namespace CapaPresentacion
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
            contextMenuStrip1 = new ContextMenuStrip(components);
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
            // Frm_clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 489);
            Name = "Frm_clientes";
            Text = "Frm_clientes";
            Load += Frm_clientes_Load;
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
    }
}