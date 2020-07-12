using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.Entidades
{
    public class TBL_CATEGORIA
    {
        public int ID_Categoria { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
    }
}
