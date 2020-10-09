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
    public partial class Form_Empleados : Form
    {
        public Form_Empleados()
        {
            InitializeComponent();
        }

        public static DataTable empleados = new DataTable();
        private void Form_Empleados_Load(object sender, EventArgs e)
        {
            
            Cls_N_Empleados objN = new Cls_N_Empleados();
            empleados = objN.MtdListarEmpleados();
           
            foreach(DataRow fila in empleados.Rows)
            {
                dgEmpleados.Rows.Add(fila[0].ToString(), fila[1].ToString(), fila[2].ToString(), fila[3].ToString(),fila[4].ToString());
            }

            txtBuscaDni.AutoCompleteCustomSource.Clear();
            foreach (DataRow r in empleados.Rows)
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
        bool modificar = false;
        private void DgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                if (this.dgEmpleados.Columns[e.ColumnIndex].Name == "Guardar")
                {
                    if (MessageBox.Show("¿Seguro que desea Guardar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        {
                            foreach(DataRow fila in empleados.Rows)
                            {
                                if(dgEmpleados.CurrentRow.Cells[0].Value.ToString()==fila[0].ToString())
                                {
                                    modificar = true;
                                    bool existir = false;
                                    Cls_E_Empleado objE = new Cls_E_Empleado();
                                    objE.Dni = dgEmpleados.CurrentRow.Cells[0].Value.ToString();
                                    objE.Nombre = dgEmpleados.CurrentRow.Cells[1].Value.ToString();
                                    objE.Clave = dgEmpleados.CurrentRow.Cells[2].Value.ToString();
                                    objE.Idcargo = int.Parse(dgEmpleados.CurrentRow.Cells[3].Value.ToString());
                                    objE.Estado = dgEmpleados.CurrentRow.Cells[4].Value.ToString();
                                    Cls_N_Empleados objN = new Cls_N_Empleados();
                                    existir = objN.MtdActualizarEmpleado(objE);
                                    if (existir == true)
                                    {
                                        MessageBox.Show("Modificado exitosamente");
                                        btnRefrescar.PerformClick();
                                        dgEmpleados.Columns[0].ReadOnly = true;
                                       
                                    }                                 
                                    break;
                                }
                                else
                                {
                                    bool existir;
                                    Cls_E_Empleado objE = new Cls_E_Empleado();
                                    objE.Dni = dgEmpleados.CurrentRow.Cells[0].Value.ToString();
                                    objE.Nombre = dgEmpleados.CurrentRow.Cells[1].Value.ToString();
                                    objE.Clave = dgEmpleados.CurrentRow.Cells[2].Value.ToString();
                                    objE.Idcargo = int.Parse(dgEmpleados.CurrentRow.Cells[3].Value.ToString());
                                    objE.Estado = dgEmpleados.CurrentRow.Cells[4].Value.ToString();
                                    Cls_N_Empleados objN = new Cls_N_Empleados();
                                    existir = objN.MtdAgregarEmpleado(objE);
                                    if (existir == true)
                                    {
                                        MessageBox.Show("Guardado exitosamente");
                                        btnRefrescar.PerformClick();
                                        dgEmpleados.Columns[0].ReadOnly = true;

                                    }             
                                }
                            }

                           
                        }
                    }        
                }
                else if (this.dgEmpleados.Columns[e.ColumnIndex].Name == "Deshabilitar")
                {
                   
                       if(dgEmpleados.CurrentRow.Cells[3].Value.ToString()=="1")
                        {
                            MessageBox.Show("No se puede deshabilitar al administrador");
                            return;
                        }
                       else
                        {
                            dgEmpleados.CurrentRow.Cells[4].Value= "0";
                            mtdPintar();
                       }
                    
                }          
            }
            catch
            {
                //nada
            }

        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            dgEmpleados.Rows.Clear();
            txtBuscaDni.Clear();
            Cls_N_Empleados objN = new Cls_N_Empleados();
            empleados = objN.MtdListarEmpleados();

            foreach (DataRow fila in empleados.Rows)
            {
                dgEmpleados.Rows.Add(fila[0].ToString(), fila[1].ToString(), fila[2].ToString(), fila[3].ToString(), fila[4].ToString());
            }
            mtdPintar();
        }

        private void mtdPintar()
        {
            foreach (DataGridViewRow fila in dgEmpleados.Rows)
            {
                if (fila.Cells[4].Value.ToString() is "1")
                {
                    fila.DefaultCellStyle.ForeColor = Color.Blue;
                }
                else if (fila.Cells[4].Value.ToString() is "0")
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
            Cls_N_Empleados objN = new Cls_N_Empleados();
            dgEmpleados.Rows.Clear();
            tabla = objN.MtdBuscarEmpleadoPorDNI(txtBuscaDni.Text);
            foreach (DataRow fila in tabla.Rows)
            {
                dgEmpleados.Rows.Add(fila[0].ToString(), fila[1].ToString(), fila[2].ToString(), fila[3].ToString(), fila[4].ToString());
            }
            mtdPintar();

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            dgEmpleados.Rows.Add();
            dgEmpleados.Columns[0].ReadOnly = false;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
         
        }

        private void BtnGestionarCargos_Click(object sender, EventArgs e)
        {
            Form_GestionarCargo f = new Form_GestionarCargo();
            f.ShowDialog();
        }
    }
}
