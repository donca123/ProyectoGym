﻿namespace Proyecto_Gimnasio.Presentacion
{
    partial class Form_Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Venta));
            this.lblProducto = new System.Windows.Forms.Label();
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNumeroBoleta = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMonedaEnLEtras = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIgv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picImprimir = new System.Windows.Forms.PictureBox();
            this.picAgregar = new System.Windows.Forms.PictureBox();
            this.picGuardar = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDNIEMP = new System.Windows.Forms.Label();
            this.cbTipoPago = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCantidadProducto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProducto.Location = new System.Drawing.Point(470, 120);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(129, 20);
            this.lblProducto.TabIndex = 80;
            this.lblProducto.Text = "no se encontro";
            // 
            // cbProductos
            // 
            this.cbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(107, 119);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(331, 21);
            this.cbProductos.TabIndex = 79;
            this.cbProductos.SelectedIndexChanged += new System.EventHandler(this.CbProductos_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(687, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 78;
            this.label8.Text = "-";
            // 
            // lblNumeroBoleta
            // 
            this.lblNumeroBoleta.AutoSize = true;
            this.lblNumeroBoleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroBoleta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNumeroBoleta.Location = new System.Drawing.Point(696, 53);
            this.lblNumeroBoleta.Name = "lblNumeroBoleta";
            this.lblNumeroBoleta.Size = new System.Drawing.Size(151, 20);
            this.lblNumeroBoleta.TabIndex = 77;
            this.lblNumeroBoleta.Text = "Numero de boleta";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSerie.Location = new System.Drawing.Point(651, 53);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(39, 20);
            this.lblSerie.TabIndex = 76;
            this.lblSerie.Text = "001";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmpleado.Location = new System.Drawing.Point(265, 23);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(57, 20);
            this.lblEmpleado.TabIndex = 74;
            this.lblEmpleado.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(103, 516);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = "Moneda en Letras";
            // 
            // txtMonedaEnLEtras
            // 
            this.txtMonedaEnLEtras.Enabled = false;
            this.txtMonedaEnLEtras.Location = new System.Drawing.Point(106, 532);
            this.txtMonedaEnLEtras.Name = "txtMonedaEnLEtras";
            this.txtMonedaEnLEtras.Size = new System.Drawing.Size(386, 20);
            this.txtMonedaEnLEtras.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(104, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Producto";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(750, 481);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "TOTAL";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(802, 478);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(59, 20);
            this.txtTotal.TabIndex = 64;
            this.txtTotal.TextChanged += new System.EventHandler(this.TxtTotal_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(620, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "IGV";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtIgv
            // 
            this.txtIgv.Enabled = false;
            this.txtIgv.Location = new System.Drawing.Point(672, 478);
            this.txtIgv.Name = "txtIgv";
            this.txtIgv.Size = new System.Drawing.Size(59, 20);
            this.txtIgv.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(488, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Subtotal";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(540, 478);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(59, 20);
            this.txtSubTotal.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(103, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Nombre Empleado";
            // 
            // picImprimir
            // 
            this.picImprimir.Image = ((System.Drawing.Image)(resources.GetObject("picImprimir.Image")));
            this.picImprimir.Location = new System.Drawing.Point(787, 522);
            this.picImprimir.Name = "picImprimir";
            this.picImprimir.Size = new System.Drawing.Size(59, 60);
            this.picImprimir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImprimir.TabIndex = 69;
            this.picImprimir.TabStop = false;
            // 
            // picAgregar
            // 
            this.picAgregar.Image = ((System.Drawing.Image)(resources.GetObject("picAgregar.Image")));
            this.picAgregar.Location = new System.Drawing.Point(782, 103);
            this.picAgregar.Name = "picAgregar";
            this.picAgregar.Size = new System.Drawing.Size(33, 32);
            this.picAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAgregar.TabIndex = 68;
            this.picAgregar.TabStop = false;
            this.picAgregar.Click += new System.EventHandler(this.PicAgregar_Click);
            // 
            // picGuardar
            // 
            this.picGuardar.Image = ((System.Drawing.Image)(resources.GetObject("picGuardar.Image")));
            this.picGuardar.Location = new System.Drawing.Point(672, 522);
            this.picGuardar.Name = "picGuardar";
            this.picGuardar.Size = new System.Drawing.Size(59, 60);
            this.picGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGuardar.TabIndex = 67;
            this.picGuardar.TabStop = false;
            this.picGuardar.Click += new System.EventHandler(this.PicGuardar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(104, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 82;
            this.label9.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(103, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 84;
            this.label2.Text = "DNI";
            // 
            // lblDNIEMP
            // 
            this.lblDNIEMP.AutoSize = true;
            this.lblDNIEMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNIEMP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDNIEMP.Location = new System.Drawing.Point(149, 53);
            this.lblDNIEMP.Name = "lblDNIEMP";
            this.lblDNIEMP.Size = new System.Drawing.Size(57, 20);
            this.lblDNIEMP.TabIndex = 85;
            this.lblDNIEMP.Text = "label8";
            // 
            // cbTipoPago
            // 
            this.cbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPago.FormattingEnabled = true;
            this.cbTipoPago.Items.AddRange(new object[] {
            "BOLETA",
            "FACTURA"});
            this.cbTipoPago.Location = new System.Drawing.Point(671, 173);
            this.cbTipoPago.Name = "cbTipoPago";
            this.cbTipoPago.Size = new System.Drawing.Size(121, 21);
            this.cbTipoPago.TabIndex = 86;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(663, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 20);
            this.label10.TabIndex = 87;
            this.label10.Text = "Tipo pago";
            this.label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // dgvCompra
            // 
            this.dgvCompra.AllowUserToAddRows = false;
            this.dgvCompra.AllowUserToDeleteRows = false;
            this.dgvCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCompra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.Sexo,
            this.importe,
            this.Precio,
            this.Eliminar});
            this.dgvCompra.Location = new System.Drawing.Point(107, 256);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.Size = new System.Drawing.Size(667, 173);
            this.dgvCompra.TabIndex = 125;
            this.dgvCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCompra_CellContentClick);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "id_producto";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 88;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Cantidad";
            this.Sexo.Name = "Sexo";
            this.Sexo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sexo.Width = 74;
            // 
            // importe
            // 
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            this.importe.ReadOnly = true;
            this.importe.Width = 67;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Width = 62;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Text = "Quitar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 5;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Enabled = false;
            this.txtPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioUnitario.Location = new System.Drawing.Point(389, 209);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(49, 22);
            this.txtPrecioUnitario.TabIndex = 148;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(278, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 16);
            this.label12.TabIndex = 147;
            this.label12.Text = "Precio Unitario";
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadProducto.Location = new System.Drawing.Point(171, 209);
            this.txtCantidadProducto.MaxLength = 5;
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.Size = new System.Drawing.Size(49, 22);
            this.txtCantidadProducto.TabIndex = 146;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(103, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 16);
            this.label11.TabIndex = 145;
            this.label11.Text = "Cantidad";
            // 
            // cbCliente
            // 
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(106, 173);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(331, 21);
            this.cbCliente.TabIndex = 149;
            this.cbCliente.SelectedIndexChanged += new System.EventHandler(this.CbCliente_SelectedIndexChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCliente.Location = new System.Drawing.Point(470, 173);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(129, 20);
            this.lblCliente.TabIndex = 150;
            this.lblCliente.Text = "no se encontro";
            // 
            // Form_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(938, 617);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.txtPrecioUnitario);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCantidadProducto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvCompra);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbTipoPago);
            this.Controls.Add(this.lblDNIEMP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.cbProductos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblNumeroBoleta);
            this.Controls.Add(this.lblSerie);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMonedaEnLEtras);
            this.Controls.Add(this.picImprimir);
            this.Controls.Add(this.picAgregar);
            this.Controls.Add(this.picGuardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIgv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Venta";
            this.Text = "Form_Venta";
            this.Load += new System.EventHandler(this.Form_Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNumeroBoleta;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMonedaEnLEtras;
        private System.Windows.Forms.PictureBox picImprimir;
        private System.Windows.Forms.PictureBox picAgregar;
        private System.Windows.Forms.PictureBox picGuardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIgv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDNIEMP;
        private System.Windows.Forms.ComboBox cbTipoPago;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvCompra;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCantidadProducto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}