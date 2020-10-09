using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using Proyecto_Gimnasio.Entidad;
using Proyecto_Gimnasio.Presentacion;
namespace Proyecto_Gimnasio.Negocios
{
    class Cls_N_Proveedor
    {
        internal DataTable MtdLeerClientes()
        {
            ClsConexionSQL conn = new ClsConexionSQL();
            DataTable result = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_S_ListarProveedores";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);
            return result;
        }

        internal bool MtdActualizarEmpleado(Cls_E_Proveedor objE)
        {
            try
            {
                ClsConexionSQL objConexion = new ClsConexionSQL();
                SqlCommand objComando = new SqlCommand();
                objComando.Connection = objConexion.conectar();
                objComando.CommandText = "USP_U_ActualizarProveedor";
                objComando.CommandType = CommandType.StoredProcedure;
                objComando.Parameters.Add(new SqlParameter("ruc", SqlDbType.VarChar));
                objComando.Parameters.Add(new SqlParameter("des", SqlDbType.VarChar));
                objComando.Parameters.Add(new SqlParameter("est", SqlDbType.VarChar));
                objComando.Parameters["ruc"].Value = objE.Ruc;
                objComando.Parameters["des"].Value = objE.Descripcion.ToUpper();
                objComando.Parameters["est"].Value = objE.Estado;
                objComando.Connection = objConexion.conectar();
                objComando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        internal bool MtdAgregarEmpleado(Cls_E_Proveedor objE)
        {
            try
            {
                ClsConexionSQL objConexion = new ClsConexionSQL();
                SqlCommand objComando = new SqlCommand();
                objComando.Connection = objConexion.conectar();
                objComando.CommandText = "USP_I_AgregarProveedor";
                objComando.CommandType = CommandType.StoredProcedure;
                objComando.Parameters.Add(new SqlParameter("ruc", SqlDbType.VarChar));
                objComando.Parameters.Add(new SqlParameter("des", SqlDbType.VarChar));
                objComando.Parameters.Add(new SqlParameter("est", SqlDbType.VarChar));
                objComando.Parameters["ruc"].Value = objE.Ruc;
                objComando.Parameters["des"].Value = objE.Descripcion.ToUpper();
                objComando.Parameters["est"].Value = objE.Estado;
                objComando.Connection = objConexion.conectar();
                objComando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        internal DataTable MtdBuscarEmpleadoPorDNI(string text)
        {
            ClsConexionSQL conn = new ClsConexionSQL();
            DataTable result = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_S_BUSCARRUCPROVEEDOR";
            command.Parameters.Add(new SqlParameter("ruc", SqlDbType.VarChar));
            command.Parameters["ruc"].Value = text;
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);
            return result;
        }
    }
}
