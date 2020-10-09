namespace Proyecto_Gimnasio.Presentacion
{
    partial class Form_VerGanancia
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtGanancia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgConsulta = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChReporte = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChReporte2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChReporte2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGanancia
            // 
            this.txtGanancia.Enabled = false;
            this.txtGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGanancia.Location = new System.Drawing.Point(665, 125);
            this.txtGanancia.Name = "txtGanancia";
            this.txtGanancia.Size = new System.Drawing.Size(108, 26);
            this.txtGanancia.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(671, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ganancia";
            // 
            // dgConsulta
            // 
            this.dgConsulta.AllowUserToAddRows = false;
            this.dgConsulta.AllowUserToDeleteRows = false;
            this.dgConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgConsulta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgConsulta.Location = new System.Drawing.Point(310, 67);
            this.dgConsulta.Name = "dgConsulta";
            this.dgConsulta.ReadOnly = true;
            this.dgConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgConsulta.Size = new System.Drawing.Size(286, 120);
            this.dgConsulta.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "TIPO";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 57;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DINERO";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 74;
            // 
            // ChReporte
            // 
            this.ChReporte.BackColor = System.Drawing.SystemColors.ControlLightLight;
            chartArea1.Name = "ChartArea1";
            this.ChReporte.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChReporte.Legends.Add(legend1);
            this.ChReporte.Location = new System.Drawing.Point(551, 12);
            this.ChReporte.Name = "ChReporte";
            this.ChReporte.Size = new System.Drawing.Size(332, 313);
            this.ChReporte.TabIndex = 9;
            this.ChReporte.Text = "chart1";
            this.ChReporte.Click += new System.EventHandler(this.ChReporte_Click);
            // 
            // ChReporte2
            // 
            this.ChReporte2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            chartArea2.Name = "ChartArea1";
            this.ChReporte2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChReporte2.Legends.Add(legend2);
            this.ChReporte2.Location = new System.Drawing.Point(195, 217);
            this.ChReporte2.Name = "ChReporte2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChReporte2.Series.Add(series1);
            this.ChReporte2.Size = new System.Drawing.Size(535, 375);
            this.ChReporte2.TabIndex = 10;
            this.ChReporte2.Text = "chart1";
            // 
            // Form_VerGanancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(907, 616);
            this.Controls.Add(this.ChReporte2);
            this.Controls.Add(this.ChReporte);
            this.Controls.Add(this.txtGanancia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_VerGanancia";
            this.Text = "Form_VerGanancia";
            this.Load += new System.EventHandler(this.Form_VerGanancia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChReporte2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGanancia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgConsulta;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChReporte;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChReporte2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}