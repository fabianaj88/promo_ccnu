using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Frm_menu_principal : Form
    {
        public Frm_menu_principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_clientes frm = new Frm_clientes();

            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Documentos frm = new Frm_Documentos();

            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
