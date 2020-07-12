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
public class NTipoCia
{
    public static DataTable Listar()
    {
        DTipoCia Datos = new DTipoCia();
        return Datos.Listar();
    }
    public static DataTable Buscar(string Valor)
    {
        DTipoCia Datos = new DTipoCia();
        return Datos.Buscar(Valor);
    }
    public static string Insertar(int ID_Tipo_Cia, string Tipo_Empresa, string Descripcion)
    {
        DTipoCia Datos = new DTipoCia();
        string Existe = Datos.Existe(Tipo_Empresa);
        if (Existe.Equals("1"))
        {
            return "La Compañía ya Existe";
        }
        else
        {
            TBL_TIPO_CIA Obj = new TBL_TIPO_CIA();
            Obj.ID_Tipo_Cia = ID_Tipo_Cia;
            Obj.Tipo_Empresa = Tipo_Empresa;
            Obj.Descripcion = Descripcion;
            return Datos.Insertar(Obj);
        }
    }
    public static string Actualizar(int ID_Tipo_Cia, string NombreAnterior, string Tipo_Empresa, string Descripcion)
    {
        DTipoCia Datos = new DTipoCia();
        TBL_TIPO_CIA Obj = new TBL_TIPO_CIA();
        if (NombreAnterior.Equals(Tipo_Empresa))
        {
            Obj.ID_Tipo_Cia = ID_Tipo_Cia;
            Obj.Tipo_Empresa = Tipo_Empresa;
            Obj.Descripcion = Descripcion;
            return Datos.Actualizar(Obj);
        }
        else
        {
            string Existe = Datos.Existe(Tipo_Empresa);
            if (Existe.Equals("1"))
            {
                return "La Compañía ya Existe";
            }
            else
            {
                Obj.ID_Tipo_Cia = ID_Tipo_Cia;
                Obj.Tipo_Empresa = Tipo_Empresa;
                Obj.Descripcion = Descripcion;
                return Datos.Actualizar(Obj);
            }

        }
    }
    public static string Eliminar(int Id)
    {
        DTipoCia datos = new DTipoCia();
        return datos.Eliminar(Id);
    }
}    






