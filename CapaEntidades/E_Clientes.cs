using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Clientes
    {
        public string codigo_cli { get; set; }
        public string nombre_cli { get; set; }
        public string apellido_cli { get; set; }
        public string tipo_doc_cli { get; set; }
        public string num_doc_cli { get; set; }
        public DateTime fecha_nac_cli { get; set; }
        public string genero_cli { get; set; }
        public string celular_cli { get; set; }
        public string telefono_cli { get; set; }
        public string direccion_cli { get; set; }
        public float saldo_cli { get; set; }
    }
}
