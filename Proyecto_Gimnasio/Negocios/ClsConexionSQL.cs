using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Proyecto_Gimnasio.Negocios
{
    class ClsConexionSQL
    {
        private SqlConnection conn = null;

        static String user = "sa";
        static String password = "123456";
        static String servidor = "localhost"; //(localhost) (host) .;
        static String basedatos = "DB_GIMNASIO";

        public SqlConnection conectar()
        {
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = "server=" + servidor + ";" + "database=" + basedatos + ";uid=" + user + ";" + "pwd=" + password + ";integrated security = false";
                conn.Open();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return conn;
        }

        public SqlConnection cerrar()
        {
            try
            {
                conn = new SqlConnection();
                conn.Close();
            }
            catch (SqlException ex) { throw ex; }
            return conn;
        }
    }
}
