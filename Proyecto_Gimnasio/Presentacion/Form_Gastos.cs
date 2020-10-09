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
    public partial class Form_Gastos : Form
    {
        public Form_Gastos()
        {
            InitializeComponent();
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        public static DataTable mensual = new DataTable();
        public static DataTable compras = new DataTable();
        public static ArrayList total = new ArrayList();
        
        private void BtnMensual_Click(object sender, EventArgs e)
        {
            dgConsultas.DataSource = null;
            dgCompras.DataSource = null;
            Cls_N_Reportes objN = new Cls_N_Reportes();
            mensual = objN.MtdGastosMensuales();
            dgConsultas.DataSource = mensual;
            

            compras = objN.MtdComprasMensuales();
            dgCompras.DataSource = compras;

            foreach (DataGridViewRow fila in dgConsultas.Rows)
            {
                Cls_E_ReporteGastos objE = new Cls_E_ReporteGastos();
                objE.Total = double.Parse(fila.Cells[0].Value.ToString());
                objE.Mes = fila.Cells[1].Value.ToString();
                total.Add(objE);
                
            }
            //foreach (DataGridViewRow fila in dgCompras.Rows)
            //{
            //    int i = 1;
            //    if (fila.Cells[1].Value.ToString() == i.ToString())
            //    {
            //        double x = Convert.ToDouble(total[i]) + Convert.ToDouble(fila.Cells[0].Value);
            //        total[i] = x;
            //    }
            //    i++;


            //}
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
            //foreach (Cls_E_ReporteGastos item in total)
            //{
            //    chart1.Series[0].Points.AddXY(item.Total.ToString(), item.Mes.ToString());
            //}
        }
        private void Form_Gastos_Load(object sender, EventArgs e)
        {

        }

        private void BtnTrimestral_Click(object sender, EventArgs e)
        {
            dgConsultas.DataSource = null;
            Cls_N_Reportes objN = new Cls_N_Reportes();
            mensual = objN.MtdGastosTriemstrales();
            dgConsultas.DataSource = mensual;


            compras = objN.MtdComprasTriMensuales();
            dgCompras.DataSource = compras;

            mtdGrafica2();
        }

        private void BtnSemestral_Click(object sender, EventArgs e)
        {
            dgConsultas.DataSource = null;
            Cls_N_Reportes objN = new Cls_N_Reportes();
            mensual = objN.MtdGastosSemestrales();
            dgConsultas.DataSource = mensual;

            compras = objN.MtdCompraSemestrales();
            dgCompras.DataSource = compras;

            mtdGrafica2();
        }

        private void BtnAnual_Click(object sender, EventArgs e)
        {
            dgConsultas.DataSource = null;
            Cls_N_Reportes objN = new Cls_N_Reportes();
            mensual = objN.MtdGastosAnual();
            dgConsultas.DataSource = mensual;
            mtdGrafica2();
        }
    }
}
