namespace Proyecto_Gimnasio.Presentacion
{
    partial class Form_Panel
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
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnCLientes = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(356, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 12;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmpleado.Location = new System.Drawing.Point(38, 186);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(76, 25);
            this.lblEmpleado.TabIndex = 20;
            this.lblEmpleado.Text = "label1";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCargo.Location = new System.Drawing.Point(94, 246);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(57, 20);
            this.lblCargo.TabIndex = 21;
            this.lblCargo.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "label1";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFecha.Location = new System.Drawing.Point(48, 347);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(57, 20);
            this.lblFecha.TabIndex = 23;
            this.lblFecha.Text = "label1";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblHora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHora.Location = new System.Drawing.Point(188, 347);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(57, 20);
            this.lblHora.TabIndex = 24;
            this.lblHora.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::Proyecto_Gimnasio.Properties.Resources.ventas2;
            this.button2.Location = new System.Drawing.Point(812, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 165);
            this.button2.TabIndex = 25;
            this.button2.Text = "Agregar Venta";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::Proyecto_Gimnasio.Properties.Resources.cerrar;
            this.button1.Location = new System.Drawing.Point(812, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 156);
            this.button1.TabIndex = 19;
            this.button1.Text = "Cerrar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.BackColor = System.Drawing.Color.Maroon;
            this.btnAsistencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAsistencia.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistencia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAsistencia.Image = global::Proyecto_Gimnasio.Properties.Resources.pesa;
            this.btnAsistencia.Location = new System.Drawing.Point(513, 183);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(293, 202);
            this.btnAsistencia.TabIndex = 15;
            this.btnAsistencia.Text = "Servicios";
            this.btnAsistencia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAsistencia.UseVisualStyleBackColor = false;
            this.btnAsistencia.Click += new System.EventHandler(this.BtnAsistencia_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.Maroon;
            this.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReportes.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnReportes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReportes.Image = global::Proyecto_Gimnasio.Properties.Resources.reporte;
            this.btnReportes.Location = new System.Drawing.Point(513, 392);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(293, 157);
            this.btnReportes.TabIndex = 16;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.BtnReportes_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.BackColor = System.Drawing.Color.Maroon;
            this.btnVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVenta.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnVenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVenta.Image = global::Proyecto_Gimnasio.Properties.Resources.ventas2;
            this.btnVenta.Location = new System.Drawing.Point(812, 183);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(205, 203);
            this.btnVenta.TabIndex = 17;
            this.btnVenta.Text = "Agregar Compra";
            this.btnVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVenta.UseVisualStyleBackColor = false;
            this.btnVenta.Click += new System.EventHandler(this.BtnVenta_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.Maroon;
            this.btnProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProveedores.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnProveedores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProveedores.Image = global::Proyecto_Gimnasio.Properties.Resources.provedor;
            this.btnProveedores.Location = new System.Drawing.Point(306, 392);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(201, 157);
            this.btnProveedores.TabIndex = 14;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.Click += new System.EventHandler(this.BtnProveedores_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.Maroon;
            this.btnInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInventario.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnInventario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInventario.Image = global::Proyecto_Gimnasio.Properties.Resources.inventario;
            this.btnInventario.Location = new System.Drawing.Point(513, 12);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(293, 166);
            this.btnInventario.TabIndex = 13;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.BtnInventario_Click);
            // 
            // btnCLientes
            // 
            this.btnCLientes.BackColor = System.Drawing.Color.Maroon;
            this.btnCLientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCLientes.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnCLientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCLientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCLientes.Image = global::Proyecto_Gimnasio.Properties.Resources.asistencias;
            this.btnCLientes.Location = new System.Drawing.Point(306, 184);
            this.btnCLientes.Name = "btnCLientes";
            this.btnCLientes.Size = new System.Drawing.Size(201, 201);
            this.btnCLientes.TabIndex = 11;
            this.btnCLientes.Text = "Clientes";
            this.btnCLientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCLientes.UseVisualStyleBackColor = false;
            this.btnCLientes.Click += new System.EventHandler(this.BtnCLientes_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Maroon;
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnUsuarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUsuarios.Image = global::Proyecto_Gimnasio.Properties.Resources.cliente;
            this.btnUsuarios.Location = new System.Drawing.Point(306, 12);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(201, 166);
            this.btnUsuarios.TabIndex = 10;
            this.btnUsuarios.Text = "Empleados";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // Form_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1029, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAsistencia);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.btnProveedores);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.btnCLientes);
            this.Controls.Add(this.btnUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Panel";
            this.Load += new System.EventHandler(this.Form_Panel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnCLientes;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
    }
}