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
    public partial class Form_GestionarCargo : Form
    {
        public Form_GestionarCargo()
        {
            InitializeComponent();
        }

        public static DataTable cargos = new DataTable();

        private void Form_GestionarCargo_Load(object sender, EventArgs e)
        {
            btnListar.PerformClick();

            //autocompletar
            txtDescripcion.AutoCompleteCustomSource.Clear();
            foreach (DataRow r in cargos.Rows)
            {
                //getting all rows in the specific field|Column
                var rw = r.Field<string>("descripcion");

                //Set the properties of a textbox to make it auto suggest and append.
                txtDescripcion.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtDescripcion.AutoCompleteSource = AutoCompleteSource.CustomSource;
                //adding all rows into the textbox
                txtDescripcion.AutoCompleteCustomSource.Add(rw);

            }
        }
     

        private void BtnListar_Click(object sender, EventArgs e)
        {

            dgCargos.ColumnCount = 2;
            dgCargos.Columns[0].HeaderText = "Codigo";
            dgCargos.Columns[1].HeaderText = "Descripcion";
            dgCargos.Rows.Clear();
            ClsNCargo objN = new ClsNCargo();
            cargos = objN.MtdListarCargo();
            foreach (DataRow fila in cargos.Rows)
            {
                dgCargos.Rows.Add(fila[0].ToString(), fila[1].ToString());
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtCodigo.Enabled = true;
        
            txtDescripcion.Clear();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            bool existir;
            ClsECargo objE = new ClsECargo();
            objE.Codigo = int.Parse(txtCodigo.Text);
            objE.Descripcion = txtDescripcion.Text.ToUpper();
            ClsNCargo objN = new ClsNCargo();
            existir = objN.MtdActualizarCargo(objE);
            if (existir == true)
            {
                MessageBox.Show("Modificado exitosamente");
            }
            else
            {
                MessageBox.Show("Error, intente nuevamente");
            }
            btnNuevo.PerformClick();
            btnListar.PerformClick();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            bool existir;
            ClsECargo objE = new ClsECargo();
            objE.Codigo = int.Parse(txtCodigo.Text);
            objE.Descripcion = txtDescripcion.Text.ToUpper();
            ClsNCargo objN = new ClsNCargo();
            existir = objN.MtdAgregarCargo(objE);
            if (existir == true)
            {
                MessageBox.Show("Guardado exitosamente");
            }
            else
            {
                MessageBox.Show("Error, intente nuevamente");
            }
            btnNuevo.PerformClick();
            btnListar.PerformClick();

        }

        private void DgCargos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgCargos.CurrentRow.Cells[0].Value.ToString();
            txtDescripcion.Text = dgCargos.CurrentRow.Cells[1].Value.ToString();
            txtCodigo.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
