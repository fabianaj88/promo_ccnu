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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Frm_menu_principal frm = new Frm_menu_principal();

            frm.Show();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
