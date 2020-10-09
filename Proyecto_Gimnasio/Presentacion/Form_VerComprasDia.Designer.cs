namespace Proyecto_Gimnasio.Presentacion
{
    partial class Form_VerComprasDia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_VerComprasDia));
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFechainicio = new System.Windows.Forms.DateTimePicker();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgBoleta = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cbImpresion = new System.Windows.Forms.ComboBox();
            this.btnVerRangoFecha = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.dgConsultaBoleta = new System.Windows.Forms.DataGridView();
            this.picImprimir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgBoleta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultaBoleta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImprimir)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.Maroon;
            this.btnRefrescar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRefrescar.Location = new System.Drawing.Point(766, 105);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(128, 44);
            this.btnRefrescar.TabIndex = 58;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.BtnRefrescar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(396, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 57;
            this.label5.Text = "Fecha inicio";
            // 
            // dtFechainicio
            // 
            this.dtFechainicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechainicio.Location = new System.Drawing.Point(400, 52);
            this.dtFechainicio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtFechainicio.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtFechainicio.Name = "dtFechainicio";
            this.dtFechainicio.Size = new System.Drawing.Size(129, 21);
            this.dtFechainicio.TabIndex = 56;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(222, 564);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(124, 21);
            this.txtTotal.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(155, 567);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 54;
            this.label4.Text = "Total";
            // 
            // dgBoleta
            // 
            this.dgBoleta.AllowUserToAddRows = false;
            this.dgBoleta.AllowUserToDeleteRows = false;
            this.dgBoleta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgBoleta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgBoleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBoleta.Location = new System.Drawing.Point(356, 164);
            this.dgBoleta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgBoleta.Name = "dgBoleta";
            this.dgBoleta.ReadOnly = true;
            this.dgBoleta.Size = new System.Drawing.Size(538, 378);
            this.dgBoleta.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(593, 564);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 51;
            this.label3.Text = "Imprimir";
            // 
            // cbImpresion
            // 
            this.cbImpresion.BackColor = System.Drawing.Color.Maroon;
            this.cbImpresion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbImpresion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbImpresion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbImpresion.FormattingEnabled = true;
            this.cbImpresion.Items.AddRange(new object[] {
            "PDF",
            "WORD",
            "EXCEL"});
            this.cbImpresion.Location = new System.Drawing.Point(699, 561);
            this.cbImpresion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbImpresion.Name = "cbImpresion";
            this.cbImpresion.Size = new System.Drawing.Size(135, 23);
            this.cbImpresion.TabIndex = 50;
            // 
            // btnVerRangoFecha
            // 
            this.btnVerRangoFecha.BackColor = System.Drawing.Color.Maroon;
            this.btnVerRangoFecha.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnVerRangoFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerRangoFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerRangoFecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVerRangoFecha.Location = new System.Drawing.Point(572, 105);
            this.btnVerRangoFecha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVerRangoFecha.Name = "btnVerRangoFecha";
            this.btnVerRangoFecha.Size = new System.Drawing.Size(77, 44);
            this.btnVerRangoFecha.TabIndex = 49;
            this.btnVerRangoFecha.Text = "Ver";
            this.btnVerRangoFecha.UseVisualStyleBackColor = false;
            this.btnVerRangoFecha.Click += new System.EventHandler(this.BtnVerRangoFecha_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(396, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 48;
            this.label2.Text = "Fecha fin";
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.Location = new System.Drawing.Point(400, 119);
            this.dtFechaFin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtFechaFin.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(129, 21);
            this.dtFechaFin.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 46;
            this.label1.Text = "Fecha actual";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(191, 105);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 44);
            this.button1.TabIndex = 45;
            this.button1.Text = "Ver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dtFecha
            // 
            this.dtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(32, 119);
            this.dtFecha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtFecha.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(129, 21);
            this.dtFecha.TabIndex = 44;
            // 
            // dgConsultaBoleta
            // 
            this.dgConsultaBoleta.AllowUserToAddRows = false;
            this.dgConsultaBoleta.AllowUserToDeleteRows = false;
            this.dgConsultaBoleta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgConsultaBoleta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgConsultaBoleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConsultaBoleta.Location = new System.Drawing.Point(14, 164);
            this.dgConsultaBoleta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgConsultaBoleta.Name = "dgConsultaBoleta";
            this.dgConsultaBoleta.ReadOnly = true;
            this.dgConsultaBoleta.Size = new System.Drawing.Size(334, 378);
            this.dgConsultaBoleta.TabIndex = 43;
            this.dgConsultaBoleta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgConsultaBoleta_CellClick);
            // 
            // picImprimir
            // 
            this.picImprimir.Image = ((System.Drawing.Image)(resources.GetObject("picImprimir.Image")));
            this.picImprimir.Location = new System.Drawing.Point(859, 561);
            this.picImprimir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picImprimir.Name = "picImprimir";
            this.picImprimir.Size = new System.Drawing.Size(32, 30);
            this.picImprimir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImprimir.TabIndex = 52;
            this.picImprimir.TabStop = false;
            this.picImprimir.Click += new System.EventHandler(this.PicImprimir_Click);
            // 
            // Form_VerComprasDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(907, 616);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtFechainicio);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgBoleta);
            this.Controls.Add(this.picImprimir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbImpresion);
            this.Controls.Add(this.btnVerRangoFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtFechaFin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.dgConsultaBoleta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_VerComprasDia";
            this.Text = "Form_VerComprasDia";
            this.Load += new System.EventHandler(this.Form_VerComprasDia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBoleta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultaBoleta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImprimir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFechainicio;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgBoleta;
        private System.Windows.Forms.PictureBox picImprimir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbImpresion;
        private System.Windows.Forms.Button btnVerRangoFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.DataGridView dgConsultaBoleta;
    }
}