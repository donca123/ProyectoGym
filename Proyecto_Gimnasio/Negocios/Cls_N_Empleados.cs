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
    class Cls_N_Empleados
    {
        internal DataTable MtdListarEmpleados()
        {
            ClsConexionSQL conn = new ClsConexionSQL();
            DataTable result = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_S_ListarEmpleados";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);
            return result;
        }

        internal bool MtdActualizarEmpleado(Cls_E_Empleado objE)
        {
            try
            {
                ClsConexionSQL objConexion = new ClsConexionSQL();
                SqlCommand objComando = new SqlCommand();
                objComando.Connection = objConexion.conectar();
                objComando.CommandText = "USP_U_ActualizarEmpleados";
                objComando.CommandType = CommandType.StoredProcedure;
                objComando.Parameters.Add(new SqlParameter("d", SqlDbType.VarChar));
                objComando.Parameters.Add(new SqlParameter("nom", SqlDbType.VarChar));
                objComando.Parameters.Add(new SqlParameter("cla", SqlDbType.VarChar));
                objComando.Parameters.Add(new SqlParameter("idc", SqlDbType.Int));
                objComando.Parameters.Add(new SqlParameter("est", SqlDbType.VarChar));
                objComando.Parameters["d"].Value = objE.Dni;
                objComando.Parameters["nom"].Value = objE.Nombre.ToUpper();
                objComando.Parameters["cla"].Value = objE.Clave;
                objComando.Parameters["idc"].Value = objE.Idcargo;
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

        internal bool MtdAgregarEmpleado(Cls_E_Empleado objE)
        {
            try
            {
                ClsConexionSQL objConexion = new ClsConexionSQL();
                SqlCommand objComando = new SqlCommand();
                objComando.Connection = objConexion.conectar();
                objComando.CommandText = "USP_I_AgregarEmpleado";
                objComando.CommandType = CommandType.StoredProcedure;
                objComando.Parameters.Add(new SqlParameter("d", SqlDbType.VarChar));
                objComando.Parameters.Add(new SqlParameter("nom", SqlDbType.VarChar));
                objComando.Parameters.Add(new SqlParameter("cla", SqlDbType.Int));
                objComando.Parameters.Add(new SqlParameter("idc", SqlDbType.VarChar));
                objComando.Parameters.Add(new SqlParameter("est", SqlDbType.VarChar));
                objComando.Parameters["d"].Value = objE.Dni;
                objComando.Parameters["nom"].Value = objE.Nombre.ToUpper();
                objComando.Parameters["cla"].Value = objE.Clave;
                objComando.Parameters["idc"].Value = objE.Idcargo;
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
            command.CommandText = "USP_S_BUSCARDNIEMPLEADO";
            command.Parameters.Add(new SqlParameter("d", SqlDbType.VarChar));
            command.Parameters["d"].Value = text;
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);
            return result;
        }
    }
}

