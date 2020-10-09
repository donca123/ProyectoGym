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
    public partial class Form_Reportes : Form
    {
        public Form_Reportes()
        {
            InitializeComponent();
        }
        private Form _objForm;
        public static string consulta;
        private void Button1_Click(object sender, EventArgs e)
        {
            MtdReporteDia();
        }
        private void MtdReporteDia()
        {

            if (Application.OpenForms.OfType<Proyecto_Gimnasio.Presentacion.Form_Ingresos>().Count() < 0)
            {
                MessageBox.Show("Abierto");
            }
            else
            {
                if (_objForm != null)
                {
                    _objForm.Close();

                }
                _objForm = new Proyecto_Gimnasio.Presentacion.Form_Ingresos
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill

                };

                panelContenedor2.Controls.Add(_objForm);
                _objForm.Show();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<Proyecto_Gimnasio.Presentacion.Form_ProductosReporte>().Count() < 0)
            {
                MessageBox.Show("Abierto");
            }
            else
            {
                if (_objForm != null)
                {
                    _objForm.Close();

                }
                _objForm = new Proyecto_Gimnasio.Presentacion.Form_ProductosReporte
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill

                };

                panelContenedor2.Controls.Add(_objForm);
                _objForm.Show();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Proyecto_Gimnasio.Presentacion.Form_VerGanancia>().Count() < 0)
            {
                MessageBox.Show("Abierto");
            }
            else
            {
                if (_objForm != null)
                {
                    _objForm.Close();

                }
                _objForm = new Proyecto_Gimnasio.Presentacion.Form_VerGanancia
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill

                };

                panelContenedor2.Controls.Add(_objForm);
                _objForm.Show();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Proyecto_Gimnasio.Presentacion.Form_Gastos>().Count() < 0)
            {
                MessageBox.Show("Abierto");
            }
            else
            {
                if (_objForm != null)
                {
                    _objForm.Close();

                }
                _objForm = new Proyecto_Gimnasio.Presentacion.Form_Gastos
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill

                };

                panelContenedor2.Controls.Add(_objForm);
                _objForm.Show();
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Proyecto_Gimnasio.Presentacion.Form_EmpleadoReporte>().Count() < 0)
            {
                MessageBox.Show("Abierto");
            }
            else
            {
                if (_objForm != null)
                {
                    _objForm.Close();

                }
                _objForm = new Proyecto_Gimnasio.Presentacion.Form_EmpleadoReporte
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill

                };

                panelContenedor2.Controls.Add(_objForm);
                _objForm.Show();
            }
        }
    }
}
