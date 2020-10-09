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
    class Cls_N_Clientes
    {       
        internal DataTable MtdLeerClientes()
        {
            ClsConexionSQL conn = new ClsConexionSQL();
            DataTable result = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_S_ListarClientes";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);
            return result;
        }

        internal void MtdLLenarClientes(ArrayList aClientes)
        {
           
        }

        internal bool MtdComprobarDNI(string v)
        {
            bool existir = false;
            return existir;
        }

        internal bool MtdActualizarCliente(Cls_E_Clientes objE)
        {
            try
            {
                ClsConexionSQL objConexion = new ClsConexionSQL();
                SqlCommand objComando = new SqlCommand();
                objComando.Connection = objConexion.conectar();
                objComando.CommandText = "USP_U_ActualizarClientes";
                objComando.CommandType = CommandType.StoredProcedure;
                objComando.Parameters.Add(new SqlParameter("d", SqlDbType.VarChar));
                objComando.Parameters.Add(new SqlParameter("nom", SqlDbType.VarChar));
                objComando.Parameters.Add(new SqlParameter("est", SqlDbType.VarChar));
                objComando.Parameters["d"].Value = objE.Dni;
                objComando.Parameters["nom"].Value = objE.Nombres;
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

        internal bool MtdAgregarCliente(Cls_E_Clientes objE)
        {
            try
            {
                ClsConexionSQL objConexion = new ClsConexionSQL();
                SqlCommand objComando = new SqlCommand();
                objComando.Connection = objConexion.conectar();
                objComando.CommandText = "USP_I_AgregarClientes";
                objComando.CommandType = CommandType.StoredProcedure;
                objComando.Parameters.Add(new SqlParameter("d", SqlDbType.VarChar));
                objComando.Parameters.Add(new SqlParameter("nom", SqlDbType.VarChar));
                objComando.Parameters.Add(new SqlParameter("est", SqlDbType.VarChar));
                objComando.Parameters["d"].Value = objE.Dni;
                objComando.Parameters["nom"].Value = objE.Nombres.ToUpper();
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

        internal DataTable MtdBuscarClientePorDNI(string text)
        {

            ClsConexionSQL conn = new ClsConexionSQL();
            DataTable result = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_S_BUSCARDNICLIENTE";
            command.Parameters.Add(new SqlParameter("d", SqlDbType.VarChar));
            command.Parameters["d"].Value = text;
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);
            return result;
        }
    }
}
