﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ferreteria.Entidades;
using System.Data;
using Oracle.ManagedDataAccess.Client;


namespace Ferreteria.Datos
{
    public class DInventario_Articulos
    {
        public DataTable Listar()
        {
            OracleDataReader Resultado;
            DataTable Tabla = new DataTable();
            OracleConnection sqloraclecon = new OracleConnection();
            try
            {
                sqloraclecon = Conexion.GetInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("LISTAR_TBL_CATEGORIA", sqloraclecon);
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
                sqloraclecon = Conexion.GetInstancia().CrearConexion();
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
                sqloraclecon = Conexion.GetInstancia().CrearConexion();
                sqloraclecon.Open();
                OracleCommand Comando = new OracleCommand("SELECT * FROM TBL_CATEGORIA WHERE CATEGORIA = :Categoria", sqloraclecon);
                Comando.Parameters.Add(":Categoria", Valor);
                OracleDataReader Respuesta = Comando.ExecuteReader();
                if (Respuesta.Read())
                {
                    Rpta = "1";
                }
                else
                {
                    Rpta = "0";
                }
                /*OracleCommand Comando = new OracleCommand("EXISTE_TBL_PROVINCIAS", sqloraclecon);
                Comando.Connection = sqloraclecon;
                Comando.CommandText = "EXISTE_TBL_PROVINCIAS";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("PROV", OracleDbType.Varchar2).Value = Valor;
                OracleParameter ParExiste = new OracleParameter();
                Comando.Parameters.Add(ParExiste);
                ParExiste.ParameterName = "REGISTROS";
                ParExiste.OracleDbType = OracleDbType.Int32;
                ParExiste.Direction = ParameterDirection.Output;
                ///sqloraclecon.Open();
                Comando.ExecuteReader();
                Rpta = Convert.ToString(ParExiste.Value);*/
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
        public string Insertar(TBL_CATEGORIA Obj)
        {
            string Rpta = "";
            OracleConnection sqloraclecon = new OracleConnection();
            try
            {
                sqloraclecon = Conexion.GetInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("INSERTAR_TBL_CATEGORIA", sqloraclecon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("IDCAT", OracleDbType.Int16).Value = Obj.ID_Categoria;
                comando.Parameters.Add("CATEGORI", OracleDbType.Varchar2).Value = Obj.Categoria;
                comando.Parameters.Add("DESCRIP", OracleDbType.Varchar2).Value = Obj.Descripcion;
                //comando.Parameters.Add("EST", OracleDbType.Boolean).Value = Obj.Estado;
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
        public string Actualizar(TBL_CATEGORIA Obj)
        {
            string Rpta = "";
            OracleConnection sqloraclecon = new OracleConnection();
            try
            {
                sqloraclecon = Conexion.GetInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_TBL_CATEGORIA", sqloraclecon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("IDCAT", OracleDbType.Int16).Value = Obj.ID_Categoria;
                comando.Parameters.Add("CATEGORI", OracleDbType.Varchar2).Value = Obj.Categoria;
                comando.Parameters.Add("DESCRIP", OracleDbType.Varchar2).Value = Obj.Descripcion;
                //comando.Parameters.Add("EST", OracleDbType.Boolean).Value = Obj.Estado;
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
        public string Eliminar(int Id)
        {
            string Rpta = "";
            OracleConnection sqloraclecon = new OracleConnection();
            try
            {
                sqloraclecon = Conexion.GetInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("BORRAR_TBL_CATEGORIA", sqloraclecon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("IDCAT", OracleDbType.Int16).Value = Id;
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
        public string Activar(int Id)
        {
            string Rpta = "";
            OracleConnection sqloraclecon = new OracleConnection();
            try
            {
                sqloraclecon = Conexion.GetInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("ACTIV_CATEGORIA", sqloraclecon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("IDCAT", OracleDbType.Int16).Value = Id;
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
        public string Desactivar(int Id)
        {
            string Rpta = "";
            OracleConnection sqloraclecon = new OracleConnection();
            try
            {
                sqloraclecon = Conexion.GetInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("DESACTIV_CATEGORIA", sqloraclecon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("IDCAT", OracleDbType.Int16).Value = Id;
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
