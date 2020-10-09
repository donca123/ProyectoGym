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
    public partial class Form_Menu : Form
    {
        private Form _objForm;
        public Form_Menu()
        {
            InitializeComponent();

        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {
            if(Cls_N_Ingreso.acceso!="1")
            {
                btnUsuarios.Enabled = false;
            }
            if (Form_Panel.panel is "empleados")
            {
                mtdAbrirEmpleados();
            }
            else if (Form_Panel.panel is "clientes")
            {
                MtdAbrirClientes();
            }
            else if (Form_Panel.panel is "proveedor")
            {
                MtdAbrirProveedor();
            }
            else if (Form_Panel.panel is "reportes")
            {
              
                MtdABrirReportes();
            }
            else if (Form_Panel.panel is "compras")
            {
                MtdAbrirCompras();
            }
            else if(Form_Panel.panel is "inventario")
            {
                MtdAbrirInventario();
            }
            else if(Form_Panel.panel is "ventas")
            {
                MtdAbrirVentas();
            }
            else if (Form_Reportes.consulta == "dia")
            {

                if (Application.OpenForms.OfType<Proyecto_Gimnasio.Presentacion.Form_VentasDia>().Count() < 0)
                {
                    MessageBox.Show("Abierto");
                }
                else
                {
                    if (_objForm != null)
                    {
                        _objForm.Close();

                    }
                    _objForm = new Proyecto_Gimnasio.Presentacion.Form_VentasDia
                    {
                        TopLevel = false,
                        Dock = DockStyle.Fill

                    };

                    PanelContenedor.Controls.Add(_objForm);
                    _objForm.Show();
                }
            }
            else if(Form_Panel.panel is "servicios")
            {
                mtdAbrirServicios();
            }
        }

        private void MtdAbrirVentas()
        {
            if (Application.OpenForms.OfType<Proyecto_Gimnasio.Presentacion.Form_Venta>().Count() < 0)
            {
                MessageBox.Show("Abierto");
            }
            else
            {
                if (_objForm != null)
                {
                    _objForm.Close();

                }
                _objForm = new Proyecto_Gimnasio.Presentacion.Form_Venta
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill

                };

                PanelContenedor.Controls.Add(_objForm);
                _objForm.Show();
            }
        }

        public void mtdAbrirEmpleados()
        {
            if (Application.OpenForms.OfType<Proyecto_Gimnasio.Presentacion.Form_Empleados>().Count() < 0)
            {
                MessageBox.Show("Abierto");
            }
            else
            {
                if (_objForm != null)
                {
                    _objForm.Close();

                }
                _objForm = new Proyecto_Gimnasio.Presentacion.Form_Empleados
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill

                };

                PanelContenedor.Controls.Add(_objForm);
                _objForm.Show();
            }

        }

        public void MtdAbrirClientes()
        {
            if (Application.OpenForms.OfType<Proyecto_Gimnasio.Presentacion.Form_Clientes>().Count() < 0)
            {
                MessageBox.Show("Abierto");
            }
            else
            {
                if (_objForm != null)
                {
                    _objForm.Close();

                }
                _objForm = new Proyecto_Gimnasio.Presentacion.Form_Clientes
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill

                };

                PanelContenedor.Controls.Add(_objForm);
                _objForm.Show();
            }
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            mtdAbrirEmpleados();
        }

        private void BtnCLientes_Click(object sender, EventArgs e)
        {
            MtdAbrirClientes();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            MtdAbrirProveedor();
        }

        private void MtdAbrirProveedor()
        {
            if (Application.OpenForms.OfType<Proyecto_Gimnasio.Presentacion.Form_Proveedor>().Count() < 0)
            {
                MessageBox.Show("Abierto");
            }
            else
            {
                if (_objForm != null)
                {
                    _objForm.Close();

                }
                _objForm = new Proyecto_Gimnasio.Presentacion.Form_Proveedor
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill

                };

                PanelContenedor.Controls.Add(_objForm);
                _objForm.Show();
            }
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
           
            MtdABrirReportes();
            
        }

        private void MtdABrirReportes()
        {

            if (Application.OpenForms.OfType<Proyecto_Gimnasio.Presentacion.Form_Reportes>().Count() < 0)
            {
                MessageBox.Show("Abierto");
            }
            else
            {
                if (_objForm != null)
                {
                    _objForm.Close();

                }
                _objForm = new Proyecto_Gimnasio.Presentacion.Form_Reportes
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill

                };

                PanelContenedor.Controls.Add(_objForm);
                _objForm.Show();
            }   
        }

        private void MtdAbrirCompras()
        {
            if (Application.OpenForms.OfType<Proyecto_Gimnasio.Presentacion.Form_Compra>().Count() < 0)
            {
                MessageBox.Show("Abierto");
            }
            else
            {
                if (_objForm != null)
                {
                    _objForm.Close();

                }
                _objForm = new Proyecto_Gimnasio.Presentacion.Form_Compra
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill

                };

                PanelContenedor.Controls.Add(_objForm);
                _objForm.Show();
            }
        }

        private void BtnVenta_Click(object sender, EventArgs e)
        {
            MtdAbrirCompras();
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            MtdAbrirInventario();
        }

        private void MtdAbrirInventario()
        {
            if (Application.OpenForms.OfType<Proyecto_Gimnasio.Presentacion.Form_Inventario>().Count() < 0)
            {
                MessageBox.Show("Abierto");
            }
            else
            {
                if (_objForm != null)
                {
                    _objForm.Close();

                }
                _objForm = new Proyecto_Gimnasio.Presentacion.Form_Inventario
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill

                };

                PanelContenedor.Controls.Add(_objForm);
                _objForm.Show();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MtdAbrirVentas();
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void PanelContenedor_VisibleChanged(object sender, EventArgs e)
        {
           
        }

        private void PanelContenedor_DockChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnAsistencia_Click(object sender, EventArgs e)
        {
            mtdAbrirServicios();
        }

        private void mtdAbrirServicios()
        {
            if (Application.OpenForms.OfType<Proyecto_Gimnasio.Presentacion.Form_Servicios>().Count() < 0)
            {
                MessageBox.Show("Abierto");
            }
            else
            {
                if (_objForm != null)
                {
                    _objForm.Close();

                }
                _objForm = new Proyecto_Gimnasio.Presentacion.Form_Servicios
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill

                };

                PanelContenedor.Controls.Add(_objForm);
                _objForm.Show();
            }
        }
    }
}
