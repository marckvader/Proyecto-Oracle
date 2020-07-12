using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ferreteria.Datos;
using Ferreteria.Entidades;
using Oracle.ManagedDataAccess.Client;
using System.Runtime.InteropServices.WindowsRuntime;


namespace Ferreteria.Negocio
{
    public class NProvincias
    {
        public static DataTable Listar()
        {
            DProvincias Datos = new DProvincias();
            return Datos.Listar();
        }
        public static DataTable Buscar(string Valor)
        {
            DProvincias Datos = new DProvincias();
            return Datos.Buscar(Valor);
        }
        public static string Insertar (int ID_provincia, string Provincia)
        {
            DProvincias Datos = new DProvincias();
            string Existe = Datos.Existe(Provincia);
            if (Existe.Equals("1"))
            {
                return "La Provincia ya Existe";
            }
            else
            {
                TBL_PROVINCIAS Obj = new TBL_PROVINCIAS();
                Obj.ID_provincia = ID_provincia;
                Obj.Provincia = Provincia;
                return Datos.Insertar(Obj);
            }  
        }
        public static string Actualizar (int Id, string Provincia)
        {
            DProvincias Datos = new DProvincias();
            string Existe = Datos.Existe(Provincia);
            if (Existe.Equals("1"))
            {
                return "La Provincia ya Existe";
            }
            else
            {
                TBL_PROVINCIAS Obj = new TBL_PROVINCIAS();
                Obj.ID_provincia = Id;
                Obj.Provincia = Provincia;
                return Datos.Actualizar(Obj);
            }
        }
        public static string Eliminar (int Id)
        {
            DProvincias datos = new DProvincias();
            return datos.Eliminar(Id);
        }
    }
}
