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
    public class NMonedas
    {
        public static DataTable Listar()
        {
            DMonedas Datos = new DMonedas();
            return Datos.Listar();
        }
        public static DataTable Buscar(string Valor)
        {
            DMonedas Datos = new DMonedas();
            return Datos.Buscar(Valor);
        }
        public static string Insertar(int ID_Moneda, string Cod_Moneda, string Descripcion)
        {
            DMonedas Datos = new DMonedas();
            string Existe = Datos.Existe(Descripcion);
            if (Existe.Equals("1"))
            {
                return "La moneda ya Existe";
            }
            else
            {
                TBL_MONEDAS Obj = new TBL_MONEDAS();
                Obj.ID_Moneda = ID_Moneda;
                Obj.Cod_Moneda = Cod_Moneda;
                Obj.Descripcion = Descripcion;
                return Datos.Insertar(Obj);
            }
        }
        public static string Actualizar(int ID_Moneda, string NombreAnt, string Cod_Moneda, string Descripcion)
        {
            DMonedas Datos = new DMonedas();
            TBL_MONEDAS Obj = new TBL_MONEDAS();
            if (NombreAnt.Equals(Descripcion))
            {
                Obj.ID_Moneda = ID_Moneda;
                Obj.Cod_Moneda = Cod_Moneda;
                Obj.Descripcion = Descripcion;
                return Datos.Actualizar(Obj);
            }
            else
            {
                string Existe = Datos.Existe(Descripcion);
                if (Existe.Equals("1"))
                {
                    return "La moneda ya Existe";
                }
                else
                {
                    Obj.ID_Moneda = ID_Moneda;
                    Obj.Cod_Moneda = Cod_Moneda;
                    Obj.Descripcion = Descripcion;
                    return Datos.Actualizar(Obj);
                }
            }
        }
        public static string Eliminar(int Id)
        {
            DMonedas datos = new DMonedas();
            return datos.Eliminar(Id);
        }
        /*public static string Activar(int Id)
        {
            DCategoria datos = new DCategoria();
            return datos.Activar(Id);
        }
        public static string Desactivar(int Id)
        {
            DCategoria datos = new DCategoria();
            return datos.Desactivar(Id);
        }*/
    }
}
