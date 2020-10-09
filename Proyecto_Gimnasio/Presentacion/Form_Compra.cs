using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Proyecto_Gimnasio.Entidad;
using Proyecto_Gimnasio.Negocios;
using Proyecto_Gimnasio.Presentacion;
using System.IO;
using System.Windows.Forms;

namespace Proyecto_Gimnasio.Presentacion
{
    public partial class Form_Compra : Form
    {
        public Form_Compra()
        {
            InitializeComponent();
        }
        public static DataTable productos = new DataTable();
        public static DataTable clientes = new DataTable();
        public static DataTable empresa = new DataTable();
        public static DataTable boleta = new DataTable();
        public static double subtotal = 0;
        private void Form_Compra_Load(object sender, EventArgs e)
        {
            foreach (DataRow fila in Form_Ingreso.empleado.Rows)
            {
                lblEmpleado.Text = fila[1].ToString();
                lblDNIEMP.Text = fila[0].ToString();
            }
            Cls_N_Compras objN = new Cls_N_Compras();
            boleta = objN.MtdListarBoletas();
            int numeroboletas = boleta.Rows.Count;
            lblNumeroBoleta.Text = objN.MtdCalcularNumeroBoleta(numeroboletas);
            cbProductos.Items.Clear();
            
            productos = objN.MtdListarProductos();
            foreach (DataRow fila in productos.Rows)
            {
                if (fila[6].ToString() == "1")
                {
                    cbProductos.Items.Add(fila[1].ToString().ToUpper());
                }
            }
            cbProveedor.Items.Clear();
            empresa = objN.MtdListarEmpresa();
            foreach (DataRow fila in empresa.Rows)
            {
                cbProveedor.Items.Add(fila[1].ToString());
            }
        }

        private void CbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProveedor.SelectedIndex != -1)
            {
                foreach (DataRow fila in empresa.Rows)
                {
                    if (fila[1].ToString() == cbProveedor.SelectedItem.ToString())
                    {
                        lblProveedor.Text = fila[0].ToString().ToUpper();
                    }
                }
            }
        }

        private void CbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProductos.SelectedIndex != -1)
            {
                foreach (DataRow fila in productos.Rows)
                {
                    if (fila[1].ToString() == cbProductos.SelectedItem.ToString())
                    {
                        lblProducto.Text = fila[0].ToString().ToUpper();
                        txtPrecioUnitario.Text = fila[3].ToString();
                    }
                }
            }
        }

        private void DgvCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            double acumulador = 0;
            try
            {
                if (this.dgvCompra.Columns[e.ColumnIndex].Name == "Eliminar")
                {

                    foreach (DataGridViewRow fila in dgvCompra.Rows)
                    {
                        acumulador += double.Parse(fila.Cells[2].Value.ToString());
                    }
                    acumulador -= double.Parse(dgvCompra.CurrentRow.Cells[2].Value.ToString());
                    txtSubTotal.Text = acumulador.ToString();
                    txtIgv.Text = (acumulador * 0.18).ToString();
                    txtTotal.Text = (acumulador + (acumulador * 0.18)).ToString();
                    dgvCompra.Rows.RemoveAt(dgvCompra.CurrentRow.Index);
                }
            }
            catch
            {
                //nada
            }
        }

        private void TxtTotal_TextChanged(object sender, EventArgs e)
        {

            Cls_N_Ventas objN = new Cls_N_Ventas();
            txtMonedaEnLEtras.Text = objN.MtdConvertirALetras(txtTotal.Text);
        }

        private void PicAgregar_Click(object sender, EventArgs e)
        {
            bool comprobar = false;
            subtotal = 0;
            if (cbProductos.SelectedIndex == -1 || cbProveedor.SelectedIndex == -1 || txtPrecioUnitario.Text == "" || txtCantidadProducto.Text == "")
            {
                MessageBox.Show("Seleccione campos");
                return;
            }          
            int cantidad = 0;

            Cls_N_Ventas objN = new Cls_N_Ventas();
            double importe = objN.MtdCalcularImporte(txtCantidadProducto.Text, txtPrecioUnitario.Text);

            foreach (DataGridViewRow fila in dgvCompra.Rows)
            {
                if (lblProducto.Text == fila.Cells[0].Value.ToString())
                {
                    comprobar = true;
                    importe = double.Parse(fila.Cells[2].Value.ToString()) + importe;
                    cantidad = int.Parse(txtCantidadProducto.Text) + int.Parse(fila.Cells[1].Value.ToString());
                    fila.Cells[2].Value = importe.ToString();
                    fila.Cells[1].Value = cantidad.ToString();

                }

                else
                {
                    comprobar = false;
                }
            }

            if (comprobar == true)
            {

            }
            else
            {
                dgvCompra.Rows.Add(lblProducto.Text, txtCantidadProducto.Text, importe.ToString(), txtPrecioUnitario.Text);
            }


            foreach (DataGridViewRow fila in dgvCompra.Rows)
            {
                subtotal = objN.MtdHallarSubtotal(fila.Cells[2].Value.ToString());
            }
            txtSubTotal.Text = subtotal.ToString();
            txtIgv.Text = (subtotal * 0.18).ToString();
            txtTotal.Text = (subtotal + (subtotal * 0.18)).ToString();
            cbProductos.SelectedIndex = -1;
            lblProducto.Text = "";
            txtCantidadProducto.Clear();
            txtPrecioUnitario.Clear();
            cbProveedor.Enabled = false;
        }

        private void PicGuardar_Click(object sender, EventArgs e)
        {
            if (dgvCompra.Rows.Count == 0 || cbTipoPago.SelectedIndex == -1)
            {
                MessageBox.Show("INGRESE PRODUCTOS/seleccione metodo de pago");
                return;
            }
            else
            {
                if (MessageBox.Show("¿Registrar Venta?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    bool comprobar2 = false;
                    Cls_E_Boleta objEBoleta = new Cls_E_Boleta();
                    Cls_E_DetalleBoleta objEDetalleBoelta = new Cls_E_DetalleBoleta();
                    Cls_N_Compras objN = new Cls_N_Compras();
                    objEBoleta.Serie = lblSerie.Text;
                    objEBoleta.Numero = lblNumeroBoleta.Text;
                    objEBoleta.Estado = "1";
                    objEBoleta.Cliente = lblProveedor.Text;
                    objEBoleta.Empleado = lblDNIEMP.Text;
                    objEBoleta.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    objEBoleta.Subtotal = double.Parse(txtSubTotal.Text);
                    objEBoleta.Igv = double.Parse(txtIgv.Text);
                    objEBoleta.Total = double.Parse(txtTotal.Text);
                    objEBoleta.Tipopago = cbTipoPago.SelectedItem.ToString();
                    bool comprobar = objN.MtdAgregarABoleta(objEBoleta);
                    foreach (DataGridViewRow fila in dgvCompra.Rows)
                    {
                        objEDetalleBoelta.Serie = lblSerie.Text;
                        objEDetalleBoelta.Numero = lblNumeroBoleta.Text;
                        objEDetalleBoelta.Codigo = int.Parse(fila.Cells[0].Value.ToString());
                        objEDetalleBoelta.Cantidad = int.Parse(fila.Cells[1].Value.ToString());
                        objEDetalleBoelta.Importe = double.Parse(fila.Cells[2].Value.ToString());
                        objEDetalleBoelta.Precio_unitario = double.Parse(fila.Cells[3].Value.ToString());
                        comprobar2 = objN.MtdAgregarDetalleBoleta(objEDetalleBoelta);
                    }

                    if (comprobar == true && comprobar2 == true)
                    {
                        int cantidad = 0;
                        foreach (DataGridViewRow fila in dgvCompra.Rows)
                        {
                            Cls_E_Producto objE = new Cls_E_Producto();
                            objE.Idproducto = int.Parse(fila.Cells[0].Value.ToString());
                            foreach (DataRow filas in productos.Rows)
                            {
                                if (filas[0].ToString() == fila.Cells[0].Value.ToString())
                                {
                                    cantidad = int.Parse(filas[4].ToString());
                                    break;
                                }
                            }
                            objE.Cantidad = cantidad + int.Parse(fila.Cells[1].Value.ToString());
                            objN.MtdIncrementarProductos(objE);
                        }
                        MessageBox.Show("Compra Registrada");
                        cbProveedor.Enabled = true;

                        boleta.Rows.Clear();
                        boleta = objN.MtdListarBoletas();
                        int numeroboletas = boleta.Rows.Count;
                        lblNumeroBoleta.Text = objN.MtdCalcularNumeroBoleta(numeroboletas);
                        dgvCompra.Rows.Clear();
                        cbProductos.SelectedIndex = -1;
                        cbProveedor.SelectedIndex = -1;

                        txtCantidadProducto.Clear();
                        txtPrecioUnitario.Clear();
                        lblProducto.Text = "";
                        lblProveedor.Text = "";
                        txtIgv.Clear();
                        txtSubTotal.Clear();
                        txtTotal.Clear();
                        txtMonedaEnLEtras.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese datos validos");
                    }
                }
            }
        }

        private void PicAgregarProducto_Click(object sender, EventArgs e)
        {
            if (cbProveedor.SelectedIndex==-1)
            {
                MessageBox.Show("Seleccione proveedor");
                return;
            }
            string ayuda = "no se encontro";
            Form_Agregar_Producto f = new Form_Agregar_Producto();
            f.ShowDialog();
            Cls_N_Compras objN = new Cls_N_Compras();
            cbProductos.Items.Clear();
            productos = objN.MtdListarProductos();
            foreach (DataRow fila in productos.Rows)
            {
                if (fila[6].ToString() == "1")
                {
                    cbProductos.Items.Add(fila[1].ToString().ToUpper());
                }
            }
        }
    }
}
