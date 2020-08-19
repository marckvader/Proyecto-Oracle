using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.Entidades
{
    public class TBL_EMPRESA
    {
        public int ID_Cia { get; set; }
        public int ID_Tipo_Cia { get; set; }
        public int ID_Tipo_Identificacion { get; set; }
        public string Num_ID { get; set; }
        public string Razon_Social { get; set; }
        public string Nombre { get; set; }
        public int ID_Provincia { get; set; }
        public string Direccion { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Fax { get; set; }
        public string CP { get; set; }
        public string Web { get; set; }
        public string Mail { get; set; }
        public string Estado { get; set; }
    }
}
