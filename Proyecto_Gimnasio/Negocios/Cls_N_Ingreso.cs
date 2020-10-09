using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using Proyecto_Gimnasio.Entidad;


namespace Proyecto_Gimnasio.Negocios
{
    class Cls_N_Ingreso
    {

        public static string acceso;
        public DataTable MtdListarEmpleado(Cls_E_Ingreso objE)
        {
            DataTable empleado = new DataTable();
            ClsConexionSQL objConexion = new ClsConexionSQL();
            SqlCommand objComando = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            objComando.Connection = objConexion.conectar();
            objComando.CommandText = "USP_S_VALIDARLOGIN";
            objComando.CommandType = CommandType.StoredProcedure;
            objComando.Parameters.Add(new SqlParameter("documento", SqlDbType.VarChar));
            objComando.Parameters.Add(new SqlParameter("cla", SqlDbType.VarChar));
            objComando.Parameters["documento"].Value = objE.Dni;
            objComando.Parameters["cla"].Value = objE.Clave;
            objComando.Connection = objConexion.conectar();
            objComando.ExecuteNonQuery();
            adapter.SelectCommand = objComando;
            adapter.Fill(empleado);
            foreach (DataRow fila in empleado.Rows)
            {
                acceso = fila[5].ToString();
            }            
            return empleado;
        }
    }    
}
