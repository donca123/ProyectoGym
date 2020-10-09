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
using System.Collections;

namespace Proyecto_Gimnasio.Presentacion
{
    public partial class Form_Inventario : Form
    {
        public static DataTable Aproductos = new DataTable();
        public Form_Inventario()
        {
            InitializeComponent();
        }
      

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            if (txtBuscaDni.Text == "")
            {
                MessageBox.Show("llene campo");
                return;
            }
            Cls_N_Productos objN = new Cls_N_Productos();
            dgInventario.Rows.Clear();
            tabla = objN.MtdBuscarEmpleadoPorDNI(txtBuscaDni.Text);
            foreach (DataRow fila in tabla.Rows)
            {
                dgInventario.Rows.Add(fila[0].ToString(), fila[1].ToString(), fila[2].ToString(), fila[3].ToString(), fila[4].ToString(), fila[5].ToString(), fila[6].ToString());
            }
            mtdPintar();
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {

            dgInventario.Rows.Clear();
            txtBuscaDni.Clear();
            Cls_N_Productos objN = new Cls_N_Productos();
            Aproductos = objN.MtdLeerClientes();
            foreach (DataRow fila in Aproductos.Rows)
            {
                dgInventario.Rows.Add(fila[0].ToString(), fila[1].ToString(), fila[2].ToString(), fila[3].ToString(), fila[4].ToString(), fila[5].ToString(), fila[6].ToString());
            }
            mtdPintar();
        }

        private void Form_Inventario_Load(object sender, EventArgs e)
        {
            Cls_N_Productos objN = new Cls_N_Productos();
            Aproductos = objN.MtdLeerClientes();

            foreach (DataRow fila in Aproductos.Rows)
            {
                dgInventario.Rows.Add(fila[0].ToString(), fila[1].ToString(), fila[2].ToString(), fila[3].ToString(), fila[4].ToString(), fila[5].ToString(), fila[6].ToString());
            }
           
            mtdPintar();
        }

        private void mtdPintar()
        {
            foreach (DataGridViewRow fila in dgInventario.Rows)
            {
                if (int.Parse(fila.Cells[4].Value.ToString()) > 10)
                {
                    fila.DefaultCellStyle.ForeColor = Color.Blue;
                }
                else 
                {
                    fila.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void DgInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        bool modificar = false;
        private void DgInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {                
                if (this.dgInventario.Columns[e.ColumnIndex].Name == "Deshabilitar")
                {
                    dgInventario.CurrentRow.Cells[6].Value = "0";
                    mtdPintar();

                }
                else if ((this.dgInventario.Columns[e.ColumnIndex].Name == "Modificar"))
                {
                    if (MessageBox.Show("¿Seguro que desea Modificar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        modificar = true;
                        bool existir = false;
                        Cls_E_Producto objE = new Cls_E_Producto();
                        objE.Idproducto =int.Parse(dgInventario.CurrentRow.Cells[0].Value.ToString());
                        objE.Descripcion = dgInventario.CurrentRow.Cells[1].Value.ToString();
                        objE.Precio_salida = double.Parse(dgInventario.CurrentRow.Cells[2].Value.ToString());
                        objE.Precio_compra = double.Parse(dgInventario.CurrentRow.Cells[3].Value.ToString());
                        objE.Cantidad = int.Parse(dgInventario.CurrentRow.Cells[4].Value.ToString());
                        objE.Idtipo = int.Parse(dgInventario.CurrentRow.Cells[5].Value.ToString());
                        objE.Estado = dgInventario.CurrentRow.Cells[6].Value.ToString();
                        Cls_N_Productos objN = new Cls_N_Productos();
                        existir = objN.MtdActualizarEmpleado(objE);
                        if (existir == true)
                        {
                            MessageBox.Show("Modificado exitosamente");
                            btnRefrescar.PerformClick();
                            dgInventario.Columns[0].ReadOnly = true;

                        }
                    }

                }
            }
            catch
            {
                //nada
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
