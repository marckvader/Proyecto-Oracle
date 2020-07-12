using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.Entidades
{
    public class TBL_INVENTARIO_ARTICULOS
    {
        public int ID_Articulo { get; set; }
        public int ID_Categoria { get; set; }
        public int ID_Bodega { get; set; }
        public string Codigo_Barras { get; set; }
        public string Nombre { get; set; }
        public int ID_Und_Medida { get; set; }
        public int Precio_Venta { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public string Estado { get; set; }
    }
}
