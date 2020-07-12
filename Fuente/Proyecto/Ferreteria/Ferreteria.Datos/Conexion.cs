using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*using Oracle.DataAccess.Client;*/
/*using System.Data.OracleClient;*/
using Oracle.ManagedDataAccess.Client;

namespace Ferreteria.Datos
{
    public class Conexion
    {
        private static Conexion Con = null;
        private Conexion()
        {

        }
        public OracleConnection CrearConexion()
        {
            OracleConnection Cadena = new OracleConnection();
            try
            {
                Cadena.ConnectionString = "DATA SOURCE=localhost:1521/xe;PASSWORD=FERREDB123;USER ID=FERREDB";
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }
        public static Conexion getInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
        /* public class Conexion  // FORMA LARGA DE HACER LA CONEXION
         {
             private string Base;     // Nombre de la BD a la que me voy a conectar.
             private string Servidor; // Nombre del SVR donde esta la BD.
             private string Usuario;  // Nombre del usuario para acceso a la BD.
             private string Password; // Password del usuario para la conexion para la BD.
             private bool seguridad;  // Tipo de seguridad a utilizar en la BD.


             private static Conexion Con = null;  // Objeto estatico Instancia para llamar a la case conexion.

             private Conexion()
             {
                 this.Base = "xe";
                 this.Servidor = "localhost:1521 /";
                 this.Usuario = "FERREDB";
                 this.Password = "FERREDB123";
                 this.seguridad = true;
                 // DATA SOURCE = localhost:1521 / xe; PERSIST SECURITY INFO = True; USER ID = FERREDB
                 // Data Source = MyOracleDB; User Id = myUsername; Password = myPassword; Integrated Security = no;

             }
             public Oracle.DataAccess.Client.OracleConnection CrearConexion()
             {
                 Oracle.DataAccess.Client.OracleConnection Cadena = new Oracle.DataAccess.Client.OracleConnection();
                 try 
                 {
                     Cadena.ConnectionString = this.Servidor + this.Base + "PERSIST SECURITY INFO = " + this.seguridad + "USER ID = " + this.Usuario + ";";
                 }
                 catch (Exception ex)
                 {
                     Cadena = null;
                     throw ex;
                 }
                 return Cadena;
             }
             public static Conexion getInstancia() 
             {
                 if (Con == null)
                 {
                     Con = new Conexion();
                 }
                 return Con;
             }
         }*/
    }
}

