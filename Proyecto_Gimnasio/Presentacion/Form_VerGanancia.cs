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
//chart
using System.Windows.Forms.DataVisualization.Charting;

namespace Proyecto_Gimnasio.Presentacion
{
    public partial class Form_VerGanancia : Form
    {
        public Form_VerGanancia()
        {
            InitializeComponent();
        }
        public static double acumulador_ganancias = 0;

        public static ArrayList Areporte = new ArrayList();

        private void Form_VerGanancia_Load(object sender, EventArgs e)
        {
            double gastos=0, ingresos=0;
            Cls_N_Reportes objN = new Cls_N_Reportes();
            DataTable gasto = objN.MtdGastosAnual();
            DataTable ingreso = objN.MtdIngresosANUAL();
            foreach(DataRow fila in gasto.Rows)
            {
                 gastos = double.Parse(fila[0].ToString());
            }
            foreach (DataRow fila in ingreso.Rows)
            {
               ingresos = double.Parse(fila[0].ToString());
            }

            dgConsulta.Rows.Add(gastos.ToString(),"GASTOS");
            dgConsulta.Rows.Add(ingresos.ToString(),"INGRESOS");
            mtdGrafica2();
            acumulador_ganancias = ingresos - gastos;
            txtGanancia.Text = acumulador_ganancias.ToString();

        }
        private void mtdGrafica2()
        {           
            ChReporte2.Series[0].Points.Clear();
            ChReporte2.Palette = ChartColorPalette.BrightPastel;
            ChReporte2.Titles.Add("GANANCIAS EN PIE");
            int i = 0;
            ChReporte2.Series[0].ChartType = SeriesChartType.Pie;
            foreach (DataGridViewRow item in dgConsulta.Rows)
            {
                ChReporte2.Series[0].Points.AddXY(item.Cells[1].Value.ToString(), item.Cells[0].Value.ToString());
            }

        }

        private void ChReporte_Click(object sender, EventArgs e)
        {

        }
    }
}
