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

namespace Proyecto_Gimnasio.Presentacion
{
    public partial class Form_VentasDia : Form
    {
        public Form_VentasDia()
        {
            InitializeComponent();
        }
        public static ArrayList Aboleta = new ArrayList();

        private void Form_VentasDia_Load(object sender, EventArgs e)
        {
            Cls_N_Reportes objN = new Cls_N_Reportes();
            Aboleta = objN.MtdLeerBoleta();
            dgBoleta.DataSource = null;
            dgBoleta.DataSource = Aboleta;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Cls_N_Reportes.acumulador = 0;
            ArrayList temp = new ArrayList();
            temp.Clear();
            foreach (DataGridViewRow fila in dgBoleta.Rows)
            {
                if (fila.Cells[3].Value.ToString() == dtFecha.Value.ToShortDateString() && fila.Cells[8].Value.ToString() != "0")
                {
                    Cls_N_Reportes objN = new Cls_N_Reportes();
                    Cls_E_Boleta objEBoleta = new Cls_E_Boleta();
                    objEBoleta.Serie = fila.Cells[0].Value.ToString();
                    objEBoleta.Numero = fila.Cells[1].Value.ToString();
                    objEBoleta.Empleado = fila.Cells[2].Value.ToString();
                    objEBoleta.Fecha = Convert.ToDateTime(fila.Cells[3].Value.ToString());
                    objEBoleta.Cliente = fila.Cells[4].Value.ToString();
                    objEBoleta.Subtotal = double.Parse(fila.Cells[5].Value.ToString());
                    objEBoleta.Igv = double.Parse(fila.Cells[6].Value.ToString());
                    objEBoleta.Total = double.Parse(fila.Cells[7].Value.ToString());
                    objEBoleta.Estado = fila.Cells[8].Value.ToString();
                    temp.Add(objEBoleta);
                    if(objEBoleta.Estado!="0")
                    {
                        Cls_N_Reportes.acumulador = Cls_N_Reportes.acumulador + float.Parse(fila.Cells[7].Value.ToString());
                    }
                }
            }
            dgConsultaBoleta.DataSource = null;
            dgConsultaBoleta.DataSource = temp;
            txtTotal.Text = Cls_N_Reportes.acumulador.ToString();
            mtdPintarCeldas();
        }

        private void mtdPintarCeldas()
        {
            foreach (DataGridViewRow fila in dgConsultaBoleta.Rows)
            {
                if (fila.Cells[8].Value.ToString() is "1")
                {
                    fila.DefaultCellStyle.ForeColor = Color.Blue;
                }
                else if (fila.Cells[8].Value.ToString() is "0")
                {
                    fila.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void BtnVerRangoFecha_Click(object sender, EventArgs e)
        {
            Cls_N_Reportes.acumulador = 0;
            ArrayList temp = new ArrayList();
            DateTime fechainicio = Convert.ToDateTime(dtFechainicio.Value.ToShortDateString());
            DateTime fechafin = Convert.ToDateTime(dtFechaFin.Value.ToShortDateString());
            DateTime fecha;

            foreach (DataGridViewRow fila in dgBoleta.Rows)
            {
                fecha = Convert.ToDateTime(fila.Cells[3].Value);
                if (fecha >= fechainicio && fecha <= fechafin && fila.Cells[8].Value.ToString() != "0")
                {
                    Cls_E_Boleta objE = new Cls_E_Boleta();
                    Cls_N_Reportes objN = new Cls_N_Reportes();
                    Cls_E_Boleta objEBoleta = new Cls_E_Boleta();
                    objEBoleta.Serie = fila.Cells[0].Value.ToString();
                    objEBoleta.Numero = fila.Cells[1].Value.ToString();
                    objEBoleta.Empleado = fila.Cells[2].Value.ToString();
                    objEBoleta.Fecha = Convert.ToDateTime(fila.Cells[3].Value.ToString());
                    objEBoleta.Cliente = fila.Cells[4].Value.ToString();
                    objEBoleta.Subtotal =double.Parse(fila.Cells[5].Value.ToString());
                    objEBoleta.Igv = double.Parse(fila.Cells[6].Value.ToString());
                    objEBoleta.Total = double.Parse(fila.Cells[7].Value.ToString());
                    objEBoleta.Estado = fila.Cells[8].Value.ToString();
                    temp.Add(objEBoleta);
                    Cls_N_Reportes.acumulador = Cls_N_Reportes.acumulador + float.Parse(fila.Cells[7].Value.ToString());
                }
            }
            dgConsultaBoleta.DataSource = null;
            dgConsultaBoleta.DataSource = temp;
            txtTotal.Text = Cls_N_Reportes.acumulador.ToString();

        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            Cls_N_Reportes objN = new Cls_N_Reportes();
            Aboleta = objN.MtdLeerBoleta();
            dgBoleta.DataSource = null;
            dgBoleta.DataSource = Aboleta;
        }        
        private void PicImprimir_Click(object sender, EventArgs e)
        {
            if (cbImpresion.SelectedIndex == 0)
            {
                SaveFileDialog ficheroPdf = new SaveFileDialog();
                ficheroPdf.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
                if (ficheroPdf.ShowDialog() == DialogResult.OK)
                {
                    string filename = ficheroPdf.FileName;
                    Document doc = new Document(PageSize.A3, 9, 9, 9, 9);
                    Chunk encab = new Chunk("REPORTE DE VENTA DE FECHA " + dtFecha.Value.ToShortDateString(), FontFactory.GetFont("COURIER", 18));
                    Chunk salto = new Chunk("\n");

                    try
                    {
                        FileStream file = new FileStream(filename, FileMode.OpenOrCreate);
                        PdfWriter writer = PdfWriter.GetInstance(doc, file);
                        writer.ViewerPreferences = PdfWriter.PageModeUseThumbs;
                        writer.ViewerPreferences = PdfWriter.PageLayoutOneColumn;
                        doc.Open();

                        doc.Add(new Paragraph(encab));
                        doc.Add(new Paragraph(salto));
                        doc.Add(new Paragraph(salto));
                        Cls_N_Reportes objN = new Cls_N_Reportes();

                        GenerarDocumentos(doc);
                        Process.Start(filename);
                        doc.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (cbImpresion.SelectedIndex == 2)
            {
                SaveFileDialog ficheroExcel = new SaveFileDialog();
                ficheroExcel.Filter = "Excel (*.xls)|*.xls";
                if (ficheroExcel.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo =
                        (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                    hoja_trabajo.Cells[2, 2] = "REPORTE - FECHA " + dtFecha.Value.ToShortDateString();
                    hoja_trabajo.Cells[4, 1] = "SERIE";
                    hoja_trabajo.Cells[4, 2] = "NUMERO";
                    hoja_trabajo.Cells[4, 3] = "SERIE";
                    hoja_trabajo.Cells[4, 4] = "EMPLEADO";
                    hoja_trabajo.Cells[4, 5] = "FECHA";
                    hoja_trabajo.Cells[4, 6] = "IMPORTE";
                    hoja_trabajo.Cells[4, 7] = "IGV";
                    hoja_trabajo.Cells[4, 8] = "TOTAL";
                    hoja_trabajo.Cells[4, 9] = "ESTADO";

                    //Recorremos el DataGridView rellenando la hoja de trabajo
                    for (int i = 0; i < dgConsultaBoleta.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgConsultaBoleta.Columns.Count; j++)
                        {
                            hoja_trabajo.Cells[i + 5, j + 1] = dgConsultaBoleta.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    hoja_trabajo.Cells[dgConsultaBoleta.Rows.Count + 6, 7] = "TOTAL: ";
                    hoja_trabajo.Cells[dgConsultaBoleta.Rows.Count + 6, 8] = txtTotal.Text;
                    libros_trabajo.SaveAs(ficheroExcel.FileName,
                        Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);
                    aplicacion.Quit();
                }
            }
            else if (cbImpresion.SelectedIndex == 1)
            {
                SaveFileDialog sfd = new SaveFileDialog();

                sfd.Filter = "Word Documents (*.doc)|*.doc";

                sfd.FileName = "";

                if (sfd.ShowDialog() == DialogResult.OK)
                {

                    //ToCsV(dataGridView1, @"c:\export.xls");

                    ToCsV(dgConsultaBoleta, sfd.FileName); // Here dataGridview1 is your grid view name 

                }

            }
        }
        public void GenerarDocumentos(Document document)
        {
            //se crea un objeto PdfTable con el numero de columnas del dataGridView  
            PdfPTable datatable = new PdfPTable(dgConsultaBoleta.ColumnCount);

            //asignamos algunas propiedades para el diseño del pdf  
            datatable.DefaultCell.Padding = 1;
            float[] headerwidths = GetTamañoColumnas(dgConsultaBoleta);

            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 1;

            //DEFINIMOS EL COLOR DE LAS CELDAS EN EL PDF 
            datatable.DefaultCell.BackgroundColor = iTextSharp.text.BaseColor.WHITE;

            //DEFINIMOS EL COLOR DE LOS BORDES 
            datatable.DefaultCell.BorderColor = iTextSharp.text.BaseColor.BLACK;

            //LA FUENTE DE NUESTRO TEXTO 
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA);

            Phrase objP = new Phrase("A", fuente);

            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

            //SE GENERA EL ENCABEZADO DE LA TABLA EN EL PDF  
            for (int i = 0; i < dgConsultaBoleta.ColumnCount; i++)
            {

                objP = new Phrase(dgConsultaBoleta.Columns[i].HeaderText, fuente);
                datatable.HorizontalAlignment = Element.ALIGN_CENTER;

                datatable.AddCell(objP);

            }
            datatable.HeaderRows = 2;

            datatable.DefaultCell.BorderWidth = 1;

            //SE GENERA EL CUERPO DEL PDF 
            for (int i = 0; i < dgConsultaBoleta.RowCount; i++)
            {
                for (int j = 0; j < dgConsultaBoleta.ColumnCount; j++)
                {
                    objP = new Phrase(dgConsultaBoleta[j, i].Value.ToString(), fuente);
                    datatable.AddCell(objP);
                }
                datatable.CompleteRow();
            }


            document.Add(datatable);
            Paragraph saltoDeLinea1 = new Paragraph(" ");
            document.Add(saltoDeLinea1);
            document.Add(new Chunk("                                                                                                                                                                                  TOTAL: " + txtTotal.Text));
        }

        public float[] GetTamañoColumnas(DataGridView dg)
        {
            //Tomamos el numero de columnas 
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                //Tomamos el ancho de cada columna 
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;
        }

        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }

            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Write("TOTAL:  " + txtTotal.Text);
            bw.Flush();
            bw.Close();
            fs.Close();
        }

        private void DgConsultaBoleta_Click(object sender, EventArgs e)
        {
            Cls_N_Reportes objN = new Cls_N_Reportes();
            dgBoleta.DataSource = null;


        }
    }   
}
