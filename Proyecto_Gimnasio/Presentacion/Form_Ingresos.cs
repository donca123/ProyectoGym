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
using System.Collections;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proyecto_Gimnasio.Presentacion
{
    public partial class Form_Ingresos : Form
    {
        public Form_Ingresos()
        {
            InitializeComponent();
        }
        public static DataTable mensual = new DataTable();
        private void BtnMensual_Click(object sender, EventArgs e)
        {
            dgConsultas.DataSource = null;

            Cls_N_Reportes objN = new Cls_N_Reportes();
            mensual = objN.MtdIngresosMensuales();
            dgConsultas.DataSource = mensual;
            mtdGrafica2();
        }
        private void mtdGrafica2()
        {
            //ArrayList temp = new ArrayList();
            //foreach(DataGridViewRow fila in dgConsulta.Rows)
            //{
            //    ClsEReporte objE = new ClsEReporte();
            //    objE.Tipo = fila.Cells[0].Value.ToString();
            //    objE.Monto = fila.Cells[1].Value.ToString();
            //    temp.Add(objE);
            //}
            chart1.Series[0].Points.Clear();
            chart1.Palette = ChartColorPalette.BrightPastel;
            chart1.Series[0].ChartType = SeriesChartType.Pie;
            foreach (DataRow item in mensual.Rows)
            {
                chart1.Series[0].Points.AddXY(item[1].ToString(), item[0].ToString());
            }
        }

        private void BtnTrimestral_Click(object sender, EventArgs e)
        {

            dgConsultas.DataSource = null;

            Cls_N_Reportes objN = new Cls_N_Reportes();
            mensual = objN.MtdIngresosTriMensuales();
            dgConsultas.DataSource = mensual;
            mtdGrafica2();
        }

        private void BtnSemestral_Click(object sender, EventArgs e)
        {
            dgConsultas.DataSource = null;

            Cls_N_Reportes objN = new Cls_N_Reportes();
            mensual = objN.MtdIngresosSEMESTRAL();
            dgConsultas.DataSource = mensual;
            mtdGrafica2();

        }

        private void BtnAnual_Click(object sender, EventArgs e)
        {

            dgConsultas.DataSource = null;

            Cls_N_Reportes objN = new Cls_N_Reportes();
            mensual = objN.MtdIngresosANUAL();
            dgConsultas.DataSource = mensual;
            mtdGrafica2();
        }

        private void Form_Ingresos_Load(object sender, EventArgs e)
        {

        }
    }
}
