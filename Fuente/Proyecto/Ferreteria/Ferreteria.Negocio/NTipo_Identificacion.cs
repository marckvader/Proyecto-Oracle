using System.Data;
using Ferreteria.Datos;
using Ferreteria.Entidades;

namespace Ferreteria.Negocio
{
    public class NTipo_Identificacion
    {
        public static DataTable Listar()
        {
            DTipo_Identificacion Datos = new DTipo_Identificacion();
            return Datos.Listar();
        }
        public static DataTable Buscar(string Valor)
        {
            DTipo_Identificacion Datos = new DTipo_Identificacion();
            return Datos.Buscar(Valor);
        }
        public static string Insertar(int Id, string Personeria)
        {
            DTipo_Identificacion Datos = new DTipo_Identificacion();
            string Existe = Datos.Existe(Personeria);
            if (Existe.Equals("1"))
            {
                return "El tipo de identificacion ya Existe";
            }
            else
            {
                TBL_TIPO_IDENTIFICACION Obj = new TBL_TIPO_IDENTIFICACION();
                Obj.ID_Tipo_Identificacion = Id;
                Obj.Personeria = Personeria;
                return Datos.Insertar(Obj);
            }
        }
        public static string Actualizar(int Id, string Personeria)
        {
            DTipo_Identificacion Datos = new DTipo_Identificacion();
            string Existe = Datos.Existe(Personeria);
            if (Existe.Equals("1"))
            {
                return "El tipo de identificacion ya Existe";
            }
            else
            {
                TBL_TIPO_IDENTIFICACION Obj = new TBL_TIPO_IDENTIFICACION();
                Obj.ID_Tipo_Identificacion = Id;
                Obj.Personeria = Personeria;
                return Datos.Actualizar(Obj);
            }
        }
        public static string Eliminar(int Id)
        {
            DTipo_Identificacion datos = new DTipo_Identificacion();
            return datos.Eliminar(Id);
        }
    }
}

