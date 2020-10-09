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
    class ClsNCargo
    {
        public DataTable MtdListarCargo()
        {
            ClsConexionSQL conn = new ClsConexionSQL();
            DataTable result = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_S_ListarCargos";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);
            return result;
        }

        public Boolean MtdAgregarCargo(ClsECargo objE)
        {
            try
            {
                ClsConexionSQL objConexion = new ClsConexionSQL();
                SqlCommand objComando = new SqlCommand();
                objComando.Connection = objConexion.conectar();
                objComando.CommandText = "USP_I_AgregarCargo";
                objComando.CommandType = CommandType.StoredProcedure;
                objComando.Parameters.Add(new SqlParameter("cod", SqlDbType.Int));
                objComando.Parameters.Add(new SqlParameter("des", SqlDbType.VarChar));
                objComando.Parameters["cod"].Value = objE.Codigo;
                objComando.Parameters["des"].Value = objE.Descripcion.ToUpper();
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

        public Boolean MtdActualizarCargo(ClsECargo objE)
        {
            try
            {
                ClsConexionSQL objConexion = new ClsConexionSQL();
                SqlCommand objComando = new SqlCommand();
                objComando.Connection = objConexion.conectar();
                objComando.CommandText = "USP_U_ActualizarCargo";
                objComando.CommandType = CommandType.StoredProcedure;
                objComando.Parameters.Add(new SqlParameter("cod", SqlDbType.Int));
                objComando.Parameters.Add(new SqlParameter("des", SqlDbType.VarChar));
                objComando.Parameters["cod"].Value = objE.Codigo;
                objComando.Parameters["des"].Value = objE.Descripcion;
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
       

       

    
    }
}
