using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ferreteria.Entidades;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace Ferreteria.Datos
{
    public class DEmpresa
    {
        public DataTable Listar()
        {
            OracleDataReader Resultado;
            DataTable Tabla = new DataTable();
            OracleConnection sqloraclecon = new OracleConnection();
            try
            {
                sqloraclecon = Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("LISTAR_TBL_EMPRESABASIC", sqloraclecon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("REGISTROS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                sqloraclecon.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqloraclecon.State == ConnectionState.Open) sqloraclecon.Close();
            }
        }
        public DataTable Buscar(string Valor)
        {
            OracleDataReader Resultado;
            DataTable Tabla = new DataTable();
            OracleConnection sqloraclecon = new OracleConnection();
            try
            {
                sqloraclecon = Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("BUSCAR_TBL_CATEGORIA", sqloraclecon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("CATEGOR", OracleDbType.Varchar2).Value = Valor;
                comando.Parameters.Add("REGISTROS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                sqloraclecon.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqloraclecon.State == ConnectionState.Open) sqloraclecon.Close();
            }
        }
        public string Existe(string Valor)
        {
            string Rpta = "";
            OracleConnection sqloraclecon = new OracleConnection();
            try
            {
                sqloraclecon = Conexion.getInstancia().CrearConexion();
                sqloraclecon.Open();
                OracleCommand Comando = new OracleCommand("SELECT * FROM TBL_EMPRESA WHERE NUM_ID = :NUMID", sqloraclecon);
                Comando.Parameters.Add(":NUMID", Valor);
                OracleDataReader Respuesta = Comando.ExecuteReader();
                if (Respuesta.Read())
                {
                    Rpta = "1";
                }
                else
                {
                    Rpta = "0";
                }                
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqloraclecon.State == ConnectionState.Open) sqloraclecon.Close();
            }
            return Rpta;
        }
        public string Insertar(TBL_EMPRESA Obj)
        {
            string Rpta = "";
            OracleConnection sqloraclecon = new OracleConnection();
            try
            {
                sqloraclecon = Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("INSERTAR_TBL_EMPRESA", sqloraclecon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("VAR1", OracleDbType.Int16).Value = Obj.ID_Cia;
                comando.Parameters.Add("VAR2", OracleDbType.Int16).Value = Obj.ID_Tipo_Cia;
                comando.Parameters.Add("VAR3", OracleDbType.Int16).Value = Obj.ID_Tipo_Identificacion;
                comando.Parameters.Add("VAR4", OracleDbType.Varchar2).Value = Obj.Num_ID;
                comando.Parameters.Add("VAR5", OracleDbType.Varchar2).Value = Obj.Razon_Social;
                comando.Parameters.Add("VAR6", OracleDbType.Varchar2).Value = Obj.Nombre;
                comando.Parameters.Add("VAR7", OracleDbType.Int16).Value = Obj.ID_Provincia;
                comando.Parameters.Add("VAR8", OracleDbType.Varchar2).Value = Obj.Direccion;
                comando.Parameters.Add("VAR9", OracleDbType.Varchar2).Value = Obj.Tel1;
                comando.Parameters.Add("VAR10", OracleDbType.Varchar2).Value = Obj.Tel2;
                comando.Parameters.Add("VAR11", OracleDbType.Varchar2).Value = Obj.Fax;
                comando.Parameters.Add("VAR12", OracleDbType.Varchar2).Value = Obj.CP;
                comando.Parameters.Add("VAR13", OracleDbType.Varchar2).Value = Obj.Web;
                comando.Parameters.Add("VAR14", OracleDbType.Varchar2).Value = Obj.Mail;                
                sqloraclecon.Open();
                Rpta = comando.ExecuteNonQuery() == -1 ? "OK" : "NO SE PUDO INGRESAR EL REGISTRO.";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqloraclecon.State == ConnectionState.Open) sqloraclecon.Close();
            }
            return Rpta;
        }
        public string Actualizar(TBL_EMPRESA Obj)
        {
            string Rpta = "";
            OracleConnection sqloraclecon = new OracleConnection();
            try
            {
                sqloraclecon = Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_TBL_EMPRESA", sqloraclecon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("VAR1", OracleDbType.Int16).Value = Obj.ID_Cia;
                comando.Parameters.Add("VAR2", OracleDbType.Int16).Value = Obj.ID_Tipo_Cia;
                comando.Parameters.Add("VAR3", OracleDbType.Int16).Value = Obj.ID_Tipo_Identificacion;
                comando.Parameters.Add("VAR4", OracleDbType.Varchar2).Value = Obj.Num_ID;
                comando.Parameters.Add("VAR5", OracleDbType.Varchar2).Value = Obj.Razon_Social;
                comando.Parameters.Add("VAR6", OracleDbType.Varchar2).Value = Obj.Nombre;
                comando.Parameters.Add("VAR7", OracleDbType.Int16).Value = Obj.ID_Provincia;
                comando.Parameters.Add("VAR8", OracleDbType.Varchar2).Value = Obj.Direccion;
                comando.Parameters.Add("VAR9", OracleDbType.Varchar2).Value = Obj.Tel1;
                comando.Parameters.Add("VAR10", OracleDbType.Varchar2).Value = Obj.Tel2;
                comando.Parameters.Add("VAR11", OracleDbType.Varchar2).Value = Obj.Fax;
                comando.Parameters.Add("VAR12", OracleDbType.Varchar2).Value = Obj.CP;
                comando.Parameters.Add("VAR13", OracleDbType.Varchar2).Value = Obj.Web;
                comando.Parameters.Add("VAR14", OracleDbType.Varchar2).Value = Obj.Mail;
                sqloraclecon.Open();
                Rpta = comando.ExecuteNonQuery() == -1 ? "OK" : "NO SE PUDO ACTUALIZAR EL REGISTRO.";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqloraclecon.State == ConnectionState.Open) sqloraclecon.Close();
            }
            return Rpta;
        }
        public string Eliminar(string numID)
        {
            string Rpta = "";
            OracleConnection sqloraclecon = new OracleConnection();
            try
            {
                sqloraclecon = Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("BORRAR_TBL_EMPRESA", sqloraclecon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("VAR15", OracleDbType.Varchar2).Value = numID;
                sqloraclecon.Open();
                Rpta = comando.ExecuteNonQuery() == -1 ? "OK" : "NO SE PUDO ELIMINAR EL REGISTRO.";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqloraclecon.State == ConnectionState.Open) sqloraclecon.Close();
            }
            return Rpta;
        }
        public string Activar(string numID)
        {
            string Rpta = "";
            OracleConnection sqloraclecon = new OracleConnection();
            try
            {
                sqloraclecon = Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("ACTIV_EMPRESA", sqloraclecon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("VAR15", OracleDbType.Varchar2).Value = numID;
                sqloraclecon.Open();
                Rpta = comando.ExecuteNonQuery() == -1 ? "OK" : "NO SE PUDO ACTIVAR EL REGISTRO.";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqloraclecon.State == ConnectionState.Open) sqloraclecon.Close();
            }
            return Rpta;
        }
        public string Desactivar(string numID)
        {
            string Rpta = "";
            OracleConnection sqloraclecon = new OracleConnection();
            try
            {
                sqloraclecon = Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("DESACTIV_EMPRESA", sqloraclecon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("VAR15", OracleDbType.Varchar2).Value = numID;
                sqloraclecon.Open();
                Rpta = comando.ExecuteNonQuery() == -1 ? "OK" : "NO SE PUDO DESACTIVAR EL REGISTRO.";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqloraclecon.State == ConnectionState.Open) sqloraclecon.Close();
            }
            return Rpta;
        }
    }
}
