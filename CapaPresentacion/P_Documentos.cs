using System;
using CapaDatos;
namespace CapaPresentacion
{
    public partial class P_Documentos : Form
    {
        public P_Documentos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia de la clase de conexi�n
            Conexion connectionManager = new Conexion();

            // Probar la conexi�n
            connectionManager.TestConnection();

        }
    }
}