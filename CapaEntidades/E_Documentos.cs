using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Documentos
    {
        public int codigo_doc { get; set; }
        public int numfac_doc { get; set; }
        public string codigo_loc_doc { get; set; }
        public string codigo_cli_doc { get; set; }
        public DateTime fecfac_doc { get; set; }
        public float valfac_doc { get; set; }
        public string obv_doc { get; set; }

    }
}
