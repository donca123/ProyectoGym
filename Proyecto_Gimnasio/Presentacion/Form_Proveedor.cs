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
    public partial class Form_Proveedor : Form
    {
        public Form_Proveedor()
        {
            InitializeComponent();
        }

        public static DataTable proveedor = new DataTable();

        private void BtnAgregarProveedor_Click(object sender, EventArgs e)
        {

        }

        private void Form_Proveedor_Load(object sender, EventArgs e)
        {
            Cls_N_Proveedor objN = new Cls_N_Proveedor();
            proveedor = objN.MtdLeerClientes();

            foreach (DataRow fila in proveedor.Rows)
            {
                dgProveedor.Rows.Add(fila[0].ToString(), fila[1].ToString(), fila[2].ToString());
            }
            txtBuscaDni.AutoCompleteCustomSource.Clear();
            foreach (DataRow r in proveedor.Rows)
            {
                //getting all rows in the specific field|Column
                var rw = r.Field<string>("ruc");

                //Set the properties of a textbox to make it auto suggest and append.
                txtBuscaDni.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtBuscaDni.AutoCompleteSource = AutoCompleteSource.CustomSource;
                //adding all rows into the textbox
                txtBuscaDni.AutoCompleteCustomSource.Add(rw);
            }
            mtdPintar();
        }

        private void mtdPintar()
        {
            foreach (DataGridViewRow fila in dgProveedor.Rows)
            {
                if (fila.Cells[2].Value.ToString() is "1")
                {
                    fila.DefaultCellStyle.ForeColor = Color.Blue;
                }
                else if (fila.Cells[2].Value.ToString() is "0")
                {
                    fila.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            if (txtBuscaDni.Text == "")
            {
                MessageBox.Show("llene campo");
                return;
            }
            Cls_N_Proveedor objN = new Cls_N_Proveedor();
            dgProveedor.Rows.Clear();
            tabla = objN.MtdBuscarEmpleadoPorDNI(txtBuscaDni.Text);
            foreach (DataRow fila in tabla.Rows)
            {
                dgProveedor.Rows.Add(fila[0].ToString(), fila[1].ToString(), fila[2].ToString());
            }
            mtdPintar();

        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            dgProveedor.Rows.Clear();
            txtBuscaDni.Clear();
            Cls_N_Proveedor objN = new Cls_N_Proveedor();
            proveedor = objN.MtdLeerClientes();

            foreach (DataRow fila in proveedor.Rows)
            {
                dgProveedor.Rows.Add(fila[0].ToString(), fila[1].ToString(), fila[2].ToString());
            }
            mtdPintar();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            dgProveedor.Rows.Add();
            dgProveedor.Columns[0].ReadOnly = false;

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
           
        }
        bool modificar = false;
        private void DgProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgProveedor.Columns[e.ColumnIndex].Name == "Guardar")
                {
                    if (MessageBox.Show("¿Seguro que desea Agregar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        {
                            foreach (DataRow fila in proveedor.Rows)
                            {
                                if (dgProveedor.CurrentRow.Cells[0].Value.ToString() == fila[0].ToString())
                                {
                                    modificar = true;
                                    bool existir = false;
                                    Cls_E_Proveedor objE = new Cls_E_Proveedor();
                                    objE.Ruc = dgProveedor.CurrentRow.Cells[0].Value.ToString();
                                    objE.Descripcion = dgProveedor.CurrentRow.Cells[1].Value.ToString();
                                    objE.Estado = dgProveedor.CurrentRow.Cells[2].Value.ToString();
                                    Cls_N_Proveedor objN = new Cls_N_Proveedor();
                                    existir = objN.MtdActualizarEmpleado(objE);
                                    if (existir == true)
                                    {
                                        MessageBox.Show("Modificado exitosamente");
                                        btnRefrescar.PerformClick();
                                        dgProveedor.Columns[0].ReadOnly = true;

                                    }
                                    break;
                                }
                                else
                                {
                                    bool existir;
                                    Cls_E_Proveedor objE = new Cls_E_Proveedor();
                                    objE.Ruc = dgProveedor.CurrentRow.Cells[0].Value.ToString();
                                    objE.Descripcion = dgProveedor.CurrentRow.Cells[1].Value.ToString();
                                    objE.Estado = dgProveedor.CurrentRow.Cells[2].Value.ToString();
                                    Cls_N_Proveedor objN = new Cls_N_Proveedor();
                                    existir = objN.MtdAgregarEmpleado(objE);
                                    if (existir == true)
                                    {
                                        MessageBox.Show("Guardado exitosamente");
                                        btnRefrescar.PerformClick();
                                        dgProveedor.Columns[0].ReadOnly = true;
                                    }
                                }
                            }
                        }
                    }                 

                }
                else if (this.dgProveedor.Columns[e.ColumnIndex].Name == "Deshabilitar")
                {
                   
                        dgProveedor.CurrentRow.Cells[2].Value = "0";
                        mtdPintar();
                    
                }      
            }
            catch
            {
                //nada
            }
        }
    }
}
