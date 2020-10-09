using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Gimnasio.Entidad;
using Proyecto_Gimnasio.Negocios;
using Proyecto_Gimnasio.Presentacion;

namespace Proyecto_Gimnasio.Presentacion
{
    public partial class Form_Agregar_Producto : Form
    {
        public Form_Agregar_Producto()
        {
            InitializeComponent();
            Cls_N_Compras objN = new Cls_N_Compras();
            txtCodigo.Text = objN.MtdGenerarIdProveedor().ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
            public Form_Agregar_Producto(string combo, string label)
            {
                Cls_N_Compras objN = new Cls_N_Compras();
                InitializeComponent();              
                txtCodigo.Text = objN.MtdGenerarIdProveedor().ToString();
            }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {

            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Agregue descripcion", "Alerta");
                return;
            }
            if (txtPrecio.Text == "")
            {
                MessageBox.Show("Agruegue Precio", "Alerta");
                return;
            }
            if (MessageBox.Show("¿Desea agregar nuevo producto?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Cls_E_Producto objProducto = new Cls_E_Producto();
                Cls_N_Compras objNCompras = new Cls_N_Compras();
                objProducto.Idproducto = int.Parse(txtCodigo.Text);
                objProducto.Descripcion = txtDescripcion.Text;
                objProducto.Cantidad = 0;
                objProducto.Precio_compra = double.Parse(txtPrecio.Text);
                objProducto.Precio_salida = ((Convert.ToDouble(txtPrecio.Text)) + ((Convert.ToDouble(txtPrecio.Text)) / 2));
                objProducto.Idtipo = cbTipo.SelectedIndex + 1;
                objProducto.Estado = "1";
                objNCompras.MtdAgregarProducto(objProducto);
            }
            this.Close();
        }

        private void Form_Agregar_Producto_Load(object sender, EventArgs e)
        {

        }
    }
}
