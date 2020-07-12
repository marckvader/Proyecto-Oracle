using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Ferreteria.Datos;
using Ferreteria.Entidades;
using Microsoft.SqlServer.Server;

namespace Ferreteria.Negocio
{
    public class NCategoria
    {
        public static DataTable Listar()
        {
            DCategoria Datos = new DCategoria();
            return Datos.Listar();
        }
        public static DataTable Buscar(string Valor)
        {
            DCategoria Datos = new DCategoria();
            return Datos.Buscar(Valor);
        }
        public static string Insertar(int ID_Categoria, string Categoria, string Descripcion)
        {
            DCategoria Datos = new DCategoria();
            string Existe = Datos.Existe(Categoria);
            if (Existe.Equals("1"))
            {
                return "La Categoría ya Existe";
            }
            else
            {
               TBL_CATEGORIA Obj = new TBL_CATEGORIA();
                Obj.ID_Categoria = ID_Categoria;
                Obj.Categoria = Categoria;
                Obj.Descripcion = Descripcion;
                return Datos.Insertar(Obj);
            }
        }
        public static string Actualizar(int ID_Categoria, string NombreAnt, string Categoria, string Descripcion)
        {
            DCategoria Datos = new DCategoria();
            TBL_CATEGORIA Obj = new TBL_CATEGORIA();
            if (NombreAnt.Equals(Categoria))
            {
                Obj.ID_Categoria = ID_Categoria;
                Obj.Categoria = Categoria;
                Obj.Descripcion = Descripcion;
                return Datos.Actualizar(Obj);
            }
            else
            {
                string Existe = Datos.Existe(Categoria);
                if (Existe.Equals("1"))
                {
                    return "La Categoría ya Existe";
                }
                else
                {
                    Obj.ID_Categoria = ID_Categoria;
                    Obj.Categoria = Categoria;
                    Obj.Descripcion = Descripcion;
                    return Datos.Actualizar(Obj);
                }
            }            
        }
        public static string Eliminar(int Id)
        {
            DCategoria datos = new DCategoria();
            return datos.Eliminar(Id);
        }
        public static string Activar (int Id)
        {
            DCategoria datos = new DCategoria();
            return datos.Activar(Id);
        }
        public static string Desactivar(int Id)
        {
            DCategoria datos = new DCategoria();
            return datos.Desactivar(Id);
        }
    }
}