namespace Proyecto_Gimnasio.Presentacion
{
    partial class Form_Gastos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnMensual = new System.Windows.Forms.Button();
            this.btnTrimestral = new System.Windows.Forms.Button();
            this.btnAnual = new System.Windows.Forms.Button();
            this.btnSemestral = new System.Windows.Forms.Button();
            this.dgConsultas = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgCompras = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMensual
            // 
            this.btnMensual.Location = new System.Drawing.Point(108, 47);
            this.btnMensual.Name = "btnMensual";
            this.btnMensual.Size = new System.Drawing.Size(96, 44);
            this.btnMensual.TabIndex = 0;
            this.btnMensual.Text = "Mensual";
            this.btnMensual.UseVisualStyleBackColor = true;
            this.btnMensual.Click += new System.EventHandler(this.BtnMensual_Click);
            // 
            // btnTrimestral
            // 
            this.btnTrimestral.Location = new System.Drawing.Point(313, 47);
            this.btnTrimestral.Name = "btnTrimestral";
            this.btnTrimestral.Size = new System.Drawing.Size(96, 44);
            this.btnTrimestral.TabIndex = 2;
            this.btnTrimestral.Text = "Trimestral";
            this.btnTrimestral.UseVisualStyleBackColor = true;
            this.btnTrimestral.Click += new System.EventHandler(this.BtnTrimestral_Click);
            // 
            // btnAnual
            // 
            this.btnAnual.Location = new System.Drawing.Point(704, 47);
            this.btnAnual.Name = "btnAnual";
            this.btnAnual.Size = new System.Drawing.Size(96, 44);
            this.btnAnual.TabIndex = 5;
            this.btnAnual.Text = "Anual";
            this.btnAnual.UseVisualStyleBackColor = true;
            this.btnAnual.Click += new System.EventHandler(this.BtnAnual_Click);
            // 
            // btnSemestral
            // 
            this.btnSemestral.Location = new System.Drawing.Point(495, 47);
            this.btnSemestral.Name = "btnSemestral";
            this.btnSemestral.Size = new System.Drawing.Size(96, 44);
            this.btnSemestral.TabIndex = 6;
            this.btnSemestral.Text = "Semestral";
            this.btnSemestral.UseVisualStyleBackColor = true;
            this.btnSemestral.Click += new System.EventHandler(this.BtnSemestral_Click);
            // 
            // dgConsultas
            // 
            this.dgConsultas.AllowUserToAddRows = false;
            this.dgConsultas.AllowUserToDeleteRows = false;
            this.dgConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConsultas.Location = new System.Drawing.Point(51, 135);
            this.dgConsultas.Name = "dgConsultas";
            this.dgConsultas.ReadOnly = true;
            this.dgConsultas.Size = new System.Drawing.Size(286, 203);
            this.dgConsultas.TabIndex = 6;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(373, 119);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(522, 482);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // dgCompras
            // 
            this.dgCompras.AllowUserToAddRows = false;
            this.dgCompras.AllowUserToDeleteRows = false;
            this.dgCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCompras.Location = new System.Drawing.Point(51, 382);
            this.dgCompras.Name = "dgCompras";
            this.dgCompras.ReadOnly = true;
            this.dgCompras.Size = new System.Drawing.Size(286, 203);
            this.dgCompras.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gastos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Compras";
            // 
            // Form_Gastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(907, 616);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgCompras);
            this.Controls.Add(this.btnSemestral);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dgConsultas);
            this.Controls.Add(this.btnAnual);
            this.Controls.Add(this.btnTrimestral);
            this.Controls.Add(this.btnMensual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Gastos";
            this.Text = "Form_Gastos";
            this.Load += new System.EventHandler(this.Form_Gastos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMensual;
        private System.Windows.Forms.Button btnTrimestral;
        private System.Windows.Forms.Button btnSemestral;
        private System.Windows.Forms.Button btnAnual;
        private System.Windows.Forms.DataGridView dgConsultas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dgCompras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}