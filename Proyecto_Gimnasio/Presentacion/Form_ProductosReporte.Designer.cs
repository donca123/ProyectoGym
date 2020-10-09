namespace Proyecto_Gimnasio.Presentacion
{
    partial class Form_ProductosReporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnSemestral = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgConsultas = new System.Windows.Forms.DataGridView();
            this.btnAnual = new System.Windows.Forms.Button();
            this.btnTrimestral = new System.Windows.Forms.Button();
            this.btnMensual = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSemestral
            // 
            this.btnSemestral.Location = new System.Drawing.Point(475, 25);
            this.btnSemestral.Name = "btnSemestral";
            this.btnSemestral.Size = new System.Drawing.Size(96, 44);
            this.btnSemestral.TabIndex = 17;
            this.btnSemestral.Text = "Semestral";
            this.btnSemestral.UseVisualStyleBackColor = true;
            this.btnSemestral.Click += new System.EventHandler(this.BtnSemestral_Click);
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(353, 110);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(522, 482);
            this.chart1.TabIndex = 19;
            this.chart1.Text = "chart1";
            // 
            // dgConsultas
            // 
            this.dgConsultas.AllowUserToAddRows = false;
            this.dgConsultas.AllowUserToDeleteRows = false;
            this.dgConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConsultas.Location = new System.Drawing.Point(31, 135);
            this.dgConsultas.Name = "dgConsultas";
            this.dgConsultas.ReadOnly = true;
            this.dgConsultas.Size = new System.Drawing.Size(286, 393);
            this.dgConsultas.TabIndex = 18;
            // 
            // btnAnual
            // 
            this.btnAnual.Location = new System.Drawing.Point(684, 25);
            this.btnAnual.Name = "btnAnual";
            this.btnAnual.Size = new System.Drawing.Size(96, 44);
            this.btnAnual.TabIndex = 16;
            this.btnAnual.Text = "Anual";
            this.btnAnual.UseVisualStyleBackColor = true;
            this.btnAnual.Click += new System.EventHandler(this.BtnAnual_Click);
            // 
            // btnTrimestral
            // 
            this.btnTrimestral.Location = new System.Drawing.Point(293, 25);
            this.btnTrimestral.Name = "btnTrimestral";
            this.btnTrimestral.Size = new System.Drawing.Size(96, 44);
            this.btnTrimestral.TabIndex = 15;
            this.btnTrimestral.Text = "Trimestral";
            this.btnTrimestral.UseVisualStyleBackColor = true;
            this.btnTrimestral.Click += new System.EventHandler(this.BtnTrimestral_Click);
            // 
            // btnMensual
            // 
            this.btnMensual.Location = new System.Drawing.Point(88, 25);
            this.btnMensual.Name = "btnMensual";
            this.btnMensual.Size = new System.Drawing.Size(96, 44);
            this.btnMensual.TabIndex = 14;
            this.btnMensual.Text = "Mensual";
            this.btnMensual.UseVisualStyleBackColor = true;
            this.btnMensual.Click += new System.EventHandler(this.BtnMensual_Click);
            // 
            // Form_ProductosReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 616);
            this.Controls.Add(this.btnSemestral);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dgConsultas);
            this.Controls.Add(this.btnAnual);
            this.Controls.Add(this.btnTrimestral);
            this.Controls.Add(this.btnMensual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ProductosReporte";
            this.Text = "Form_ProductosReporte";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSemestral;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dgConsultas;
        private System.Windows.Forms.Button btnAnual;
        private System.Windows.Forms.Button btnTrimestral;
        private System.Windows.Forms.Button btnMensual;
    }
}