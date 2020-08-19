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
    public class NEmpresa
    {
        public static DataTable Listar()
        {
            DEmpresa Datos = new DEmpresa();
            return Datos.Listar();
        }
        public static DataTable Buscar(string Valor)
        {
            DEmpresa Datos = new DEmpresa();
            return Datos.Buscar(Valor);
        }
        public static string Insertar(int ID, int IDTipo, int IDtipoID, string NID, string razon, string Nombre, int IDP,string Direccion, string tel1, string tel2, string fax, string codpos, string dicweb, string email)
        {
            DEmpresa Datos = new DEmpresa();
            string Existe = Datos.Existe(razon);
            if (Existe.Equals("1"))
            {
                return "La Empresa o Sucursal ya Existe";
            }
            else
            {
                TBL_EMPRESA Obj = new TBL_EMPRESA();
                Obj.ID_Cia = ID;
                Obj.ID_Tipo_Cia = IDTipo;
                Obj.ID_Tipo_Identificacion = IDtipoID;
                Obj.Num_ID = NID;
                Obj.Razon_Social = razon;
                Obj.Nombre = Nombre;
                Obj.ID_Provincia = IDP;
                Obj.Direccion = Direccion;
                Obj.Tel1 = tel1;
                Obj.Tel2 = tel2;
                Obj.Fax = fax;
                Obj.CP = codpos;
                Obj.Web = dicweb;
                Obj.Mail = email;
                return Datos.Insertar(Obj);
            }
        }
        public static string Actualizar(int ID, int IDTipo, int IDtipoID, string NID, string NIDActual, string razon, string Nombre, int IDP, string Direccion, string tel1, string tel2, string fax, string codpos, string dicweb, string email)
        {
            DEmpresa Datos = new DEmpresa();
            TBL_EMPRESA Obj = new TBL_EMPRESA();
            if (NIDActual.Equals(NID))
            {
                Obj.ID_Cia = ID;
                Obj.ID_Tipo_Cia = IDTipo;
                Obj.ID_Tipo_Identificacion = IDtipoID;
                Obj.Num_ID = NID;
                Obj.Razon_Social = razon;
                Obj.Nombre = Nombre;
                Obj.ID_Provincia = IDP;
                Obj.Direccion = Direccion;
                Obj.Tel1 = tel1;
                Obj.Tel2 = tel2;
                Obj.Fax = fax;
                Obj.CP = codpos;
                Obj.Web = dicweb;
                Obj.Mail = email;
                return Datos.Actualizar(Obj);
            }
            else
            {
                string Existe = Datos.Existe(NID);
                if (Existe.Equals("1"))
                {
                    return "La Empresa o Sucursal ya Existe";
                }
                else
                {
                    Obj.ID_Cia = ID;
                    Obj.ID_Tipo_Cia = IDTipo;
                    Obj.ID_Tipo_Identificacion = IDtipoID;
                    Obj.Num_ID = NID;
                    Obj.Razon_Social = razon;
                    Obj.Nombre = Nombre;
                    Obj.ID_Provincia = IDP;
                    Obj.Direccion = Direccion;
                    Obj.Tel1 = tel1;
                    Obj.Tel2 = tel2;
                    Obj.Fax = fax;
                    Obj.CP = codpos;
                    Obj.Web = dicweb;
                    Obj.Mail = email;
                    return Datos.Actualizar(Obj);
                }
            }
        }
        public static string Eliminar(int Id)
        {
            DEmpresa datos = new DEmpresa();
            return datos.Eliminar(Id);
        }
       
        public static string Activar(int Id)
        {
            DEmpresa datos = new DEmpresa();
            return datos.Activar(Id);
        }
        public static string Desactivar(int Id)
        {
            DEmpresa datos = new DEmpresa();
            return datos.Desactivar(Id);
        }
    }
}
