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
    class Cls_N_Compras
    {
        internal DataTable MtdListarBoletas()
        {
            ClsConexionSQL conn = new ClsConexionSQL();
            DataTable result = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_S_ListarCompras";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);
            return result;
        }

        internal DataTable MtdListarEmpresa()
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

        public string MtdConvertirALetras(string num)
        {
            string res, dec = "";
            Int64 entero;
            int decimales;
            double nro;

            try
            {
                nro = Convert.ToDouble(num);
            }

            catch
            {
                return "";
            }

            entero = Convert.ToInt64(Math.Truncate(nro));
            decimales = Convert.ToInt32(Math.Round((nro - entero) * 100, 2));

            if (decimales > 0)
            {
                dec = " CON " + decimales.ToString() + "/ 100 CENTIMOS";
            }

            res = toText(Convert.ToDouble(entero)) + " SOLES " + dec;

            return res;
        }

        internal void MtdAgregarProducto(Cls_E_Producto objE)
        {
            
                ClsConexionSQL objConexion = new ClsConexionSQL();
                SqlCommand objComando = new SqlCommand();
                objComando.Connection = objConexion.conectar();
                objComando.CommandText = "USP_I_AgregarProducto";
                objComando.CommandType = CommandType.StoredProcedure;
                objComando.Parameters.Add(new SqlParameter("id", SqlDbType.Int));
                objComando.Parameters.Add(new SqlParameter("descripcion", SqlDbType.VarChar));
                objComando.Parameters.Add(new SqlParameter("precios", SqlDbType.Decimal));
                objComando.Parameters.Add(new SqlParameter("precioc", SqlDbType.Decimal));
                objComando.Parameters.Add(new SqlParameter("stock", SqlDbType.Int));
            objComando.Parameters.Add(new SqlParameter("idt", SqlDbType.Int));
            objComando.Parameters.Add(new SqlParameter("estado", SqlDbType.VarChar));
            objComando.Parameters["id"].Value = objE.Idproducto;
                objComando.Parameters["descripcion"].Value = objE.Descripcion.ToUpper();
                objComando.Parameters["precios"].Value = objE.Precio_salida;
                objComando.Parameters["precioc"].Value = objE.Precio_compra;
                objComando.Parameters["stock"].Value = objE.Cantidad;
            objComando.Parameters["idt"].Value = objE.Idtipo;
            objComando.Parameters["estado"].Value = objE.Estado;
            objComando.Connection = objConexion.conectar();
                objComando.ExecuteNonQuery();           
          
        }

        internal int MtdGenerarIdProveedor()
        {
            DataTable temp = new DataTable();
            ClsConexionSQL conn = new ClsConexionSQL();
     
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_S_ListarProductos";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(temp);

            int idproducto = temp.Rows.Count+1;


            return idproducto;

        }

        internal double MtdCalcularImporte(string cantidad, string precio)
        {
            double cant = double.Parse(cantidad);
            double prec = double.Parse(precio);
            double importe = cant * prec;
            return importe;
        }

        internal double MtdHallarSubtotal(string importe)
        {
            Form_Venta.subtotal = double.Parse(importe) + Form_Venta.subtotal;
            return Form_Venta.subtotal;
        }

        private string toText(double value)
        {
            string Num2Text = "";
            value = Math.Truncate(value);
            if (value == 0) Num2Text = "CERO";
            else if (value == 1) Num2Text = "UNO";
            else if (value == 2) Num2Text = "DOS";
            else if (value == 3) Num2Text = "TRES";
            else if (value == 4) Num2Text = "CUATRO";
            else if (value == 5) Num2Text = "CINCO";
            else if (value == 6) Num2Text = "SEIS";
            else if (value == 7) Num2Text = "SIETE";
            else if (value == 8) Num2Text = "OCHO";
            else if (value == 9) Num2Text = "NUEVE";
            else if (value == 10) Num2Text = "DIEZ";
            else if (value == 11) Num2Text = "ONCE";
            else if (value == 12) Num2Text = "DOCE";
            else if (value == 13) Num2Text = "TRECE";
            else if (value == 14) Num2Text = "CATORCE";
            else if (value == 15) Num2Text = "QUINCE";
            else if (value < 20) Num2Text = "DIECI" + toText(value - 10);
            else if (value == 20) Num2Text = "VEINTE";
            else if (value < 30) Num2Text = "VEINTI" + toText(value - 20);
            else if (value == 30) Num2Text = "TREINTA";
            else if (value == 40) Num2Text = "CUARENTA";
            else if (value == 50) Num2Text = "CINCUENTA";
            else if (value == 60) Num2Text = "SESENTA";
            else if (value == 70) Num2Text = "SETENTA";
            else if (value == 80) Num2Text = "OCHENTA";
            else if (value == 90) Num2Text = "NOVENTA";
            else if (value < 100) Num2Text = toText(Math.Truncate(value / 10) * 10) + " Y " + toText(value % 10);
            else if (value == 100) Num2Text = "CIEN";
            else if (value < 200) Num2Text = "CIENTO " + toText(value - 100);
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = toText(Math.Truncate(value / 100)) + "CIENTOS";
            else if (value == 500) Num2Text = "QUINIENTOS";
            else if (value == 700) Num2Text = "SETECIENTOS";
            else if (value == 900) Num2Text = "NOVECIENTOS";
            else if (value < 1000) Num2Text = toText(Math.Truncate(value / 100) * 100) + " " + toText(value % 100);
            else if (value == 1000) Num2Text = "MIL";
            else if (value < 2000) Num2Text = "MIL " + toText(value % 1000);
            else if (value < 1000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000)) + " MIL";
                if ((value % 1000) > 0) Num2Text = Num2Text + " " + toText(value % 1000);
            }
            else if (value == 1000000) Num2Text = "UN MILLON";
            else if (value < 2000000) Num2Text = "UN MILLON " + toText(value % 1000000);
            else if (value < 1000000000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000000)) + " MILLONES ";
                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000) * 1000000);
            }
            else if (value == 1000000000000) Num2Text = "UN BILLON";
            else if (value < 2000000000000) Num2Text = "UN BILLON " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            else
            {
                Num2Text = toText(Math.Truncate(value / 1000000000000)) + " BILLONES";
                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            }
            return Num2Text;
        }

        internal string MtdCalcularNumeroBoleta(int numeroboletas)
        {
            numeroboletas++;
            if (numeroboletas.ToString().Length == 1)
            {
                return "00000" + numeroboletas.ToString();
            }
            else if (numeroboletas.ToString().Length == 2)
            {
                return "0000" + numeroboletas.ToString();

            }
            else if (numeroboletas.ToString().Length == 3)
            {
                return "000" + numeroboletas.ToString();
            }
            else if (numeroboletas.ToString().Length == 4)
            {
                return "00" + numeroboletas.ToString();
            }
            else if (numeroboletas.ToString().Length == 5)
            {
                return "0" + numeroboletas.ToString();
            }
            else
            {
                return numeroboletas.ToString();
            }
        }
        internal void MtdIncrementarProductos(Cls_E_Producto objE)
        {

            ClsConexionSQL objConexion = new ClsConexionSQL();
            SqlCommand objComando = new SqlCommand();
            objComando.Connection = objConexion.conectar();
            objComando.CommandText = "USP_U_DecrementarProducto";
            objComando.CommandType = CommandType.StoredProcedure;
            objComando.Parameters.Add(new SqlParameter("cant", SqlDbType.Int));
            objComando.Parameters.Add(new SqlParameter("cod", SqlDbType.Int));
            objComando.Parameters["cod"].Value = objE.Idproducto;
            objComando.Parameters["cant"].Value = objE.Cantidad;
            objComando.Connection = objConexion.conectar();
            objComando.ExecuteNonQuery();
        }

        internal bool MtdAgregarDetalleBoleta(Cls_E_DetalleBoleta objEDetalleBoelta)
        {
            try
            {
                ClsConexionSQL objConexion = new ClsConexionSQL();
                SqlCommand objComando = new SqlCommand();
                objComando.Connection = objConexion.conectar();
                objComando.CommandText = "USP_I_AgregarDetalleCompra";
                objComando.CommandType = CommandType.StoredProcedure;
                objComando.Parameters.Add(new SqlParameter("importe", SqlDbType.Decimal));
                objComando.Parameters.Add(new SqlParameter("precio", SqlDbType.Decimal));
                objComando.Parameters.Add(new SqlParameter("ser", SqlDbType.VarChar));
                objComando.Parameters.Add(new SqlParameter("num", SqlDbType.VarChar));
                objComando.Parameters.Add(new SqlParameter("id", SqlDbType.Int));
                objComando.Parameters.Add(new SqlParameter("cantidad", SqlDbType.Int));

                objComando.Parameters["cantidad"].Value = objEDetalleBoelta.Cantidad;
                objComando.Parameters["precio"].Value = objEDetalleBoelta.Precio_unitario;
                objComando.Parameters["importe"].Value = objEDetalleBoelta.Importe;
                objComando.Parameters["ser"].Value = objEDetalleBoelta.Serie;
                objComando.Parameters["num"].Value = objEDetalleBoelta.Numero;
                objComando.Parameters["id"].Value = objEDetalleBoelta.Codigo;
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

        public Boolean MtdAgregarABoleta(Cls_E_Boleta objEBoleta)
        {
            try
            {
                ClsConexionSQL objConexion = new ClsConexionSQL();
                SqlCommand objComando = new SqlCommand();
                objComando.Connection = objConexion.conectar();
                objComando.CommandText = "USP_I_AgregarCompra";
                objComando.CommandType = CommandType.StoredProcedure;
                objComando.Parameters.Add(new SqlParameter("ser", SqlDbType.VarChar));
                objComando.Parameters.Add(new SqlParameter("num", SqlDbType.VarChar));
                objComando.Parameters.Add(new SqlParameter("dnie", SqlDbType.VarChar));
                objComando.Parameters.Add(new SqlParameter("fecha", SqlDbType.Date));
                objComando.Parameters.Add(new SqlParameter("dnic", SqlDbType.VarChar));
                objComando.Parameters.Add(new SqlParameter("sub", SqlDbType.Decimal));
                objComando.Parameters.Add(new SqlParameter("igv", SqlDbType.Decimal));
                objComando.Parameters.Add(new SqlParameter("total", SqlDbType.Decimal));
                objComando.Parameters.Add(new SqlParameter("estado", SqlDbType.VarChar));
                objComando.Parameters.Add(new SqlParameter("tipopago", SqlDbType.VarChar));
                objComando.Parameters["ser"].Value = objEBoleta.Serie;
                objComando.Parameters["num"].Value = objEBoleta.Numero;
                objComando.Parameters["dnie"].Value = objEBoleta.Empleado;
                objComando.Parameters["fecha"].Value = objEBoleta.Fecha;
                objComando.Parameters["dnic"].Value = objEBoleta.Cliente;
                objComando.Parameters["sub"].Value = objEBoleta.Total;
                objComando.Parameters["igv"].Value = objEBoleta.Total;
                objComando.Parameters["total"].Value = objEBoleta.Total;
                objComando.Parameters["estado"].Value = objEBoleta.Estado;
                objComando.Parameters["tipopago"].Value = objEBoleta.Empleado;
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

        internal DataTable MtdLIstarClientes()
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

        internal DataTable MtdListarProductos()
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
    }
}
