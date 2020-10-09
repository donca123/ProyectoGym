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


namespace Proyecto_Gimnasio
{
    public partial class Form_Ingreso : Form
    {
        public Form_Ingreso()
        {
            InitializeComponent();
        }
        public static DataTable empleado = new DataTable();
      
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            //Administrador
            //ID : 76514314
            //CONTRA: 123456

            //Cargo 2
            //ID: : 45871231
            //CONTRA: 211030

            //bool ingresar = false;

            if (txtDNI.Text.Equals(""))      //para el usuario
            {
                MessageBox.Show("Ingrese Codigo");
                return;               
            }
           
            if (txtClave.Text.Equals(""))        //para la clave
            {
                MessageBox.Show("Ingrese Clave");
                return;
            }
            Cls_N_Ingreso objN = new Cls_N_Ingreso();
            Cls_E_Ingreso objE = new Cls_E_Ingreso();
            objE.Dni = txtDNI.Text;
            objE.Clave = txtClave.Text;
            empleado = objN.MtdListarEmpleado(objE);
            if (empleado.Rows.Count == 0)
            {
                MessageBox.Show("ERROR");
                MTdLimpiar();
            }
            else if (empleado.Rows[0][4].ToString() is "0")
            {
                MessageBox.Show("Usuario inhabilitado");
                MTdLimpiar();
            }
            else
            {

                MessageBox.Show("Bienvenido " + empleado.Rows[0][1].ToString());
                Form_Panel f = new Form_Panel();
                this.Hide();
                f.ShowDialog();


                this.Show();
                MTdLimpiar();
            }
        }

        public void MTdLimpiar()
        {
            txtClave.Clear();
            txtDNI.Clear();
            txtDNI.Focus();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_Ingreso_Load(object sender, EventArgs e)
        {

        }
    }
}
