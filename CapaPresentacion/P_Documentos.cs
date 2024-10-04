using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class P_Documentos : Form
    {
        N_Documentos objetondoc = new N_Documentos();
        public P_Documentos()
        {
            InitializeComponent();
        }



        private void P_Documentos_Load(object sender, EventArgs e)
        {
            MostrarDoc();
        }

        private void MostrarDoc()
        {
            dataGridView1.DataSource = objetondoc.MostrarDoc();
        }
    }
}