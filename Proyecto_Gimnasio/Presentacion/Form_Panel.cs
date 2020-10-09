using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Gimnasio.Negocios;

namespace Proyecto_Gimnasio.Presentacion
{
    public partial class Form_Panel : Form
    {
        public Form_Panel()
        {
            InitializeComponent();
        }
        public static string panel;
        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea Cerrar Sesion?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            panel = "empleados";
            mtdAbrirPanel();
        }

        public void mtdAbrirPanel()
        {
            Form_Menu f = new Form_Menu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void BtnCLientes_Click(object sender, EventArgs e)
        {
            panel = "clientes";
            mtdAbrirPanel();
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            panel = "proveedor";
            mtdAbrirPanel();
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            panel = "reportes";
            mtdAbrirPanel();
        }

        private void BtnAsistencia_Click(object sender, EventArgs e)
        {
            panel = "servicios";
            mtdAbrirPanel();
        }

        private void Form_Panel_Load(object sender, EventArgs e)
        {
            if(Cls_N_Ingreso.acceso!="1")
            {
                btnUsuarios.Enabled = false;
                lblCargo.Text = "Atencion al cliente";
            }
            else
            {
                lblCargo.Text = "Administrador";
            }

            foreach(DataRow fila in Form_Ingreso.empleado.Rows)
            {
                lblEmpleado.Text = fila[1].ToString();
            }

            
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void BtnVenta_Click(object sender, EventArgs e)
        {
            panel = "compras";
            mtdAbrirPanel();
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            panel = "inventario";
            mtdAbrirPanel();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            panel = "ventas";
            mtdAbrirPanel();
        }
    }
}
