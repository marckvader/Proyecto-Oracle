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
    public class NEmpresa
    {
        public static DataTable Listar()
        {
            DEmpresa Datos = new DEmpresa();
            return Datos.Listar();
        }
        public static DataTable ListarDetallado()
        {
            DEmpresa Datos = new DEmpresa();
            return Datos.ListarDetallado();
        }
        public static DataTable Buscar(string Valor)
        {
            DEmpresa Datos = new DEmpresa();
            return Datos.Buscar(Valor);
        }
        public static string Insertar(int IDCia, int IDtcia, int IDTipodi, string numid, string razon, string nombre, int IDProv, string direccion, string tel1, string tel2, string fax, string cp, string web, string email)
        {
            DEmpresa Datos = new DEmpresa();
            string Existe = Datos.Existe(numid);
            if (Existe.Equals("1"))
            {
                return "La Empresa ya Existe";
            }
            else
            {
                TBL_EMPRESA Obj = new TBL_EMPRESA();
                Obj.ID_Cia = IDCia;
                Obj.ID_Tipo_Cia = IDtcia;
                Obj.ID_Tipo_Identificacion = IDTipodi;
                Obj.Num_ID = numid;
                Obj.Razon_Social = razon;
                Obj.Nombre = nombre;
                Obj.ID_Provincia = IDProv;
                Obj.Direccion = direccion;
                Obj.Tel1 = tel1;
                Obj.Tel2 = tel2;
                Obj.Fax = fax;
                Obj.CP = cp;
                Obj.Web = web;
                Obj.Mail = email;
                return Datos.Insertar(Obj);
            }
        }
        public static string Actualizar(int IDCia, int IDtcia, int IDTipodi, string AntNumID, string numid, string razon, string nombre, int IDProv, string direccion, string tel1, string tel2, string fax, string cp, string web, string email)
        {
            DEmpresa Datos = new DEmpresa();
            TBL_EMPRESA Obj = new TBL_EMPRESA();
            if (AntNumID.Equals(numid))
            {
                Obj.ID_Cia = IDCia;
                Obj.ID_Tipo_Cia = IDtcia;
                Obj.ID_Tipo_Identificacion = IDTipodi;
                Obj.Num_ID = numid;
                Obj.Razon_Social = razon;
                Obj.Nombre = nombre;
                Obj.ID_Provincia = IDProv;
                Obj.Direccion = direccion;
                Obj.Tel1 = tel1;
                Obj.Tel2 = tel2;
                Obj.Fax = fax;
                Obj.CP = cp;
                Obj.Web = web;
                Obj.Mail = email;
                return Datos.Actualizar(Obj);
            }
            else
            {
                string Existe = Datos.Existe(numid);
                if (Existe.Equals("1"))
                {
                    return "La Empresa o sucursal ya Existe";
                }
                else
                {
                    Obj.ID_Cia = IDCia;
                    Obj.ID_Tipo_Cia = IDtcia;
                    Obj.ID_Tipo_Identificacion = IDTipodi;
                    Obj.Num_ID = numid;
                    Obj.Razon_Social = razon;
                    Obj.Nombre = nombre;
                    Obj.ID_Provincia = IDProv;
                    Obj.Direccion = direccion;
                    Obj.Tel1 = tel1;
                    Obj.Tel2 = tel2;
                    Obj.Fax = fax;
                    Obj.CP = cp;
                    Obj.Web = web;
                    Obj.Mail = email;
                    return Datos.Actualizar(Obj);
                }
            }
        }
        public static string Eliminar(int IDci)
        {
            DEmpresa datos = new DEmpresa();
            return datos.Eliminar(IDci);
        }
        public static string Activar(int IDci)
        {
            DEmpresa datos = new DEmpresa();
            return datos.Activar(IDci);
        }
        public static string Desactivar(int IDci)
        {
            DEmpresa datos = new DEmpresa();
            return datos.Desactivar(IDci);
        }
    }
}
