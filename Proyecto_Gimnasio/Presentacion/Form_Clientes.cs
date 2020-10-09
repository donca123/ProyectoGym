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
    public partial class Form_Clientes : Form
    {
        public Form_Clientes()
        {
            InitializeComponent();
        }
        public static DataTable clientes = new DataTable();
        private void BtnAgregarCliente_Click(object sender, EventArgs e)
        {

        }

        private void Form_Clientes_Load(object sender, EventArgs e)
        {
            Cls_N_Clientes objN = new Cls_N_Clientes();
            clientes = objN.MtdLeerClientes();
         
                foreach(DataRow fila in clientes.Rows)
                {
                    dgCliente.Rows.Add(fila[0].ToString(), fila[1].ToString(), fila[2].ToString());
                }
            txtBuscaDni.AutoCompleteCustomSource.Clear();
            foreach (DataRow r in clientes.Rows)
            {
                //getting all rows in the specific field|Column
                var rw = r.Field<string>("dni");

                //Set the properties of a textbox to make it auto suggest and append.
                txtBuscaDni.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtBuscaDni.AutoCompleteSource = AutoCompleteSource.CustomSource;
                //adding all rows into the textbox
                txtBuscaDni.AutoCompleteCustomSource.Add(rw);
            }
            mtdPintar();
         
            
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            dgCliente.Rows.Add();
            dgCliente.Columns[0].ReadOnly = false;
        }

        private void DgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        bool modificar = false;
        private void DgCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                if (this.dgCliente.Columns[e.ColumnIndex].Name == "Guardar")
                {
                    if (MessageBox.Show("¿Seguro que desea Guardar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        {
                            foreach (DataRow fila in clientes.Rows)
                            {
                                if (dgCliente.CurrentRow.Cells[0].Value.ToString() == fila[0].ToString())
                                {
                                    modificar = true;
                                    bool existir = false;
                                    Cls_E_Clientes objE = new Cls_E_Clientes();
                                    objE.Dni = dgCliente.CurrentRow.Cells[0].Value.ToString();
                                    objE.Nombres = dgCliente.CurrentRow.Cells[1].Value.ToString();
                                    objE.Estado = dgCliente.CurrentRow.Cells[2].Value.ToString();
                                    Cls_N_Clientes objN = new Cls_N_Clientes();
                                    existir = objN.MtdActualizarCliente(objE);
                                    if (existir == true)
                                    {
                                        MessageBox.Show("Modificado exitosamente");
                                        btnRefrescar.PerformClick();
                                        dgCliente.Columns[0].ReadOnly = true;

                                    }
                                    break;
                                }
                                else
                                {
                                    bool existir;
                                    Cls_E_Clientes objE = new Cls_E_Clientes();
                                    objE.Dni = dgCliente.CurrentRow.Cells[0].Value.ToString();
                                    objE.Nombres = dgCliente.CurrentRow.Cells[1].Value.ToString();
                                    objE.Estado = dgCliente.CurrentRow.Cells[2].Value.ToString();
                                    Cls_N_Clientes objN = new Cls_N_Clientes();
                                    existir = objN.MtdAgregarCliente(objE);
                                    if (existir == true)
                                    {
                                        MessageBox.Show("Guardado exitosamente");
                                        btnRefrescar.PerformClick();
                                        dgCliente.Columns[0].ReadOnly = true;
                                    }
                                }
                            }
                        }
                    }

                }
                else if (this.dgCliente.Columns[e.ColumnIndex].Name == "Deshabilitar")
                {
                   
                        dgCliente.CurrentRow.Cells[2].Value = "0";
                        mtdPintar();
                    
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

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            dgCliente.Rows.Clear();
            txtBuscaDni.Clear();
            Cls_N_Clientes objN = new Cls_N_Clientes();
            clientes = objN.MtdLeerClientes();

            foreach (DataRow fila in clientes.Rows)
            {
                dgCliente.Rows.Add(fila[0].ToString(), fila[1].ToString(), fila[2].ToString());
            }
            mtdPintar();

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            if (txtBuscaDni.Text == "")
            {
                MessageBox.Show("llene campo");
                return;
            }
            Cls_N_Clientes objN = new Cls_N_Clientes();
            dgCliente.Rows.Clear();
            tabla = objN.MtdBuscarClientePorDNI(txtBuscaDni.Text);
            foreach (DataRow fila in tabla.Rows)
            {
                dgCliente.Rows.Add(fila[0].ToString(), fila[1].ToString(), fila[2].ToString());
            }
            mtdPintar();
        }
        private void mtdPintar()
        {
            foreach (DataGridViewRow fila in dgCliente.Rows)
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
    }

}
