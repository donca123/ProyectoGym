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
    class Cls_N_Productos
    {
        internal DataTable MtdLeerClientes()
        {
            ClsConexionSQL conn = new ClsConexionSQL();
            DataTable result = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_S_ListarProductos";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);
            return result;
        }

        internal bool MtdActualizarEmpleado(Cls_E_Producto objE)
        {
            try
            {
                ClsConexionSQL objConexion = new ClsConexionSQL();
                SqlCommand objComando = new SqlCommand();
                objComando.Connection = objConexion.conectar();
                objComando.CommandText = "USP_U_ActualizarProducto";
                objComando.CommandType = CommandType.StoredProcedure;
                objComando.Parameters.Add(new SqlParameter("id", SqlDbType.Int));
                objComando.Parameters.Add(new SqlParameter("des", SqlDbType.VarChar));
                objComando.Parameters.Add(new SqlParameter("pres", SqlDbType.Decimal));
                objComando.Parameters.Add(new SqlParameter("prec", SqlDbType.Decimal));
                objComando.Parameters.Add(new SqlParameter("sto", SqlDbType.Int)); 
                objComando.Parameters.Add(new SqlParameter("idt", SqlDbType.Int));
                objComando.Parameters.Add(new SqlParameter("est", SqlDbType.VarChar));
                objComando.Parameters["id"].Value = objE.Idproducto;
                objComando.Parameters["des"].Value = objE.Descripcion.ToUpper();
                objComando.Parameters["pres"].Value = objE.Precio_salida;
                objComando.Parameters["prec"].Value = objE.Precio_compra;
                objComando.Parameters["sto"].Value = objE.Cantidad;
                objComando.Parameters["idt"].Value = objE.Idtipo;
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
            command.CommandText = "USP_S_BUSCARIDPRODUCTO";
            command.Parameters.Add(new SqlParameter("idt", SqlDbType.VarChar));
            command.Parameters["idt"].Value = text;
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);
            return result;
        }
    }
}
