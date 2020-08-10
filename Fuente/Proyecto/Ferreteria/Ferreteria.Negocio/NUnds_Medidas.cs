using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Ferreteria.Datos;
using Ferreteria.Entidades;

namespace Ferreteria.Negocio
{
    public class NUnds_Medidas
    {
        public static DataTable Listar()
        {
            DUnds_Medidas Datos = new DUnds_Medidas();
            return Datos.Listar();
        }
        public static DataTable Buscar(string Valor)
        {
            DUnds_Medidas Datos = new DUnds_Medidas();
            return Datos.Buscar(Valor);
        }
        public static string Insertar(int ID_Und_Medida, string Cod_Medida, string Descripcion)
        {
            DUnds_Medidas Datos = new DUnds_Medidas();
            string Existe = Datos.Existe(Cod_Medida);
            if (Existe.Equals("1"))
            {
                return "El Código de la unidad de medida ya Existe";
            }
            else
            {
                TBL_UND_MED Obj = new TBL_UND_MED();
                Obj.ID_Und_Medida = ID_Und_Medida;
                Obj.Cod_Medida = Cod_Medida;
                Obj.Descripcion = Descripcion;
                return Datos.Insertar(Obj);
            }
        }
        public static string Actualizar(int ID_Und_Medida, string NombreAnt, string Cod_Medida, string Descripcion)
        {
            DUnds_Medidas Datos = new DUnds_Medidas();
            TBL_UND_MED Obj = new TBL_UND_MED();
            if (NombreAnt.Equals(Cod_Medida))
            {
                Obj.ID_Und_Medida = ID_Und_Medida;
                Obj.Cod_Medida = Cod_Medida;
                Obj.Descripcion = Descripcion;
                return Datos.Actualizar(Obj);
            }
            else
            {
                string Existe = Datos.Existe(Cod_Medida);
                if (Existe.Equals("1"))
                {
                    return "El Código de la unidad de medida ya Existe";
                }
                else
                {
                    Obj.ID_Und_Medida = ID_Und_Medida;
                    Obj.Cod_Medida = Cod_Medida;
                    Obj.Descripcion = Descripcion;
                    return Datos.Actualizar(Obj);
                }
            }
        }
        public static string Eliminar(int Id)
        {
            DUnds_Medidas datos = new DUnds_Medidas();
            return datos.Eliminar(Id);
        }
    }
}

