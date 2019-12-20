namespace proyecto
{
    partial class frmFactura
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
            this.pnlFacturaLogo = new System.Windows.Forms.Panel();
            this.pnlFacuraNumero = new System.Windows.Forms.Panel();
            this.lblFacturaNumero = new System.Windows.Forms.Label();
            this.lblFactura = new System.Windows.Forms.Label();
            this.dgvFacturaVenta = new System.Windows.Forms.DataGridView();
            this.lblFacturaDetalle = new System.Windows.Forms.Label();
            this.lblFacturaSubTotal = new System.Windows.Forms.Label();
            this.tbFacturaSubTotal = new System.Windows.Forms.TextBox();
            this.pnlFacturaFecha = new System.Windows.Forms.Panel();
            this.tbFechaVencimiento = new System.Windows.Forms.TextBox();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.tbFacturaFecha = new System.Windows.Forms.TextBox();
            this.lblFacturaFecha = new System.Windows.Forms.Label();
            this.btnAtrasFactura = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.tbClienteNombre = new System.Windows.Forms.TextBox();
            this.tbClienteCuil = new System.Windows.Forms.TextBox();
            this.lblClienteNombre = new System.Windows.Forms.Label();
            this.lblClienteCuil = new System.Windows.Forms.Label();
            this.pnlFacturaDatos = new System.Windows.Forms.Panel();
            this.tbEmpleadoCuil = new System.Windows.Forms.TextBox();
            this.lblCuilEmpleado = new System.Windows.Forms.Label();
            this.tbEmpleadoNombre = new System.Windows.Forms.TextBox();
            this.lblEmpleadoNombre = new System.Windows.Forms.Label();
            this.tbIva = new System.Windows.Forms.TextBox();
            this.lvlIva = new System.Windows.Forms.Label();
            this.tbTotalFinal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTotalFinal = new System.Windows.Forms.Label();
            this.lblFacturaA = new System.Windows.Forms.Label();
            this.pnlFacuraNumero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturaVenta)).BeginInit();
            this.pnlFacturaFecha.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlFacturaDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFacturaLogo
            // 
            this.pnlFacturaLogo.BackColor = System.Drawing.Color.Transparent;
            this.pnlFacturaLogo.BackgroundImage = global::proyecto.Properties.Resources.alev_logo_png_1;
            this.pnlFacturaLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFacturaLogo.Location = new System.Drawing.Point(245, 22);
            this.pnlFacturaLogo.Name = "pnlFacturaLogo";
            this.pnlFacturaLogo.Size = new System.Drawing.Size(161, 156);
            this.pnlFacturaLogo.TabIndex = 0;
            // 
            // pnlFacuraNumero
            // 
            this.pnlFacuraNumero.BackColor = System.Drawing.Color.Transparent;
            this.pnlFacuraNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFacuraNumero.Controls.Add(this.lblFacturaNumero);
            this.pnlFacuraNumero.Controls.Add(this.lblFactura);
            this.pnlFacuraNumero.Location = new System.Drawing.Point(508, 22);
            this.pnlFacuraNumero.Name = "pnlFacuraNumero";
            this.pnlFacuraNumero.Size = new System.Drawing.Size(362, 156);
            this.pnlFacuraNumero.TabIndex = 1;
            // 
            // lblFacturaNumero
            // 
            this.lblFacturaNumero.AutoSize = true;
            this.lblFacturaNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturaNumero.Location = new System.Drawing.Point(79, 93);
            this.lblFacturaNumero.Name = "lblFacturaNumero";
            this.lblFacturaNumero.Size = new System.Drawing.Size(56, 32);
            this.lblFacturaNumero.TabIndex = 1;
            this.lblFacturaNumero.Text = "N° ";
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactura.Location = new System.Drawing.Point(103, 40);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(154, 32);
            this.lblFactura.TabIndex = 0;
            this.lblFactura.Text = "FACTURA";
            // 
            // dgvFacturaVenta
            // 
            this.dgvFacturaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturaVenta.Location = new System.Drawing.Point(33, 442);
            this.dgvFacturaVenta.Name = "dgvFacturaVenta";
            this.dgvFacturaVenta.RowTemplate.Height = 24;
            this.dgvFacturaVenta.Size = new System.Drawing.Size(861, 261);
            this.dgvFacturaVenta.TabIndex = 2;
            // 
            // lblFacturaDetalle
            // 
            this.lblFacturaDetalle.AutoSize = true;
            this.lblFacturaDetalle.BackColor = System.Drawing.Color.Transparent;
            this.lblFacturaDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFacturaDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturaDetalle.Location = new System.Drawing.Point(33, 405);
            this.lblFacturaDetalle.Name = "lblFacturaDetalle";
            this.lblFacturaDetalle.Size = new System.Drawing.Size(114, 34);
            this.lblFacturaDetalle.TabIndex = 4;
            this.lblFacturaDetalle.Text = "Detalle";
            // 
            // lblFacturaSubTotal
            // 
            this.lblFacturaSubTotal.AutoSize = true;
            this.lblFacturaSubTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblFacturaSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFacturaSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturaSubTotal.Location = new System.Drawing.Point(613, 719);
            this.lblFacturaSubTotal.Name = "lblFacturaSubTotal";
            this.lblFacturaSubTotal.Size = new System.Drawing.Size(102, 26);
            this.lblFacturaSubTotal.TabIndex = 5;
            this.lblFacturaSubTotal.Text = "Sub-Total";
            // 
            // tbFacturaSubTotal
            // 
            this.tbFacturaSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFacturaSubTotal.Location = new System.Drawing.Point(754, 716);
            this.tbFacturaSubTotal.Name = "tbFacturaSubTotal";
            this.tbFacturaSubTotal.Size = new System.Drawing.Size(140, 28);
            this.tbFacturaSubTotal.TabIndex = 6;
            this.tbFacturaSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbFacturaSubTotal.TextChanged += new System.EventHandler(this.tbFacturaTotal_TextChanged);
            // 
            // pnlFacturaFecha
            // 
            this.pnlFacturaFecha.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlFacturaFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFacturaFecha.Controls.Add(this.tbFechaVencimiento);
            this.pnlFacturaFecha.Controls.Add(this.lblFechaVencimiento);
            this.pnlFacturaFecha.Controls.Add(this.tbFacturaFecha);
            this.pnlFacturaFecha.Controls.Add(this.lblFacturaFecha);
            this.pnlFacturaFecha.Location = new System.Drawing.Point(595, 184);
            this.pnlFacturaFecha.Name = "pnlFacturaFecha";
            this.pnlFacturaFecha.Size = new System.Drawing.Size(202, 140);
            this.pnlFacturaFecha.TabIndex = 7;
            // 
            // tbFechaVencimiento
            // 
            this.tbFechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFechaVencimiento.Location = new System.Drawing.Point(17, 98);
            this.tbFechaVencimiento.Name = "tbFechaVencimiento";
            this.tbFechaVencimiento.Size = new System.Drawing.Size(165, 28);
            this.tbFechaVencimiento.TabIndex = 6;
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVencimiento.Location = new System.Drawing.Point(33, 70);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(127, 24);
            this.lblFechaVencimiento.TabIndex = 5;
            this.lblFechaVencimiento.Text = "Vencimiento";
            // 
            // tbFacturaFecha
            // 
            this.tbFacturaFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFacturaFecha.Location = new System.Drawing.Point(17, 39);
            this.tbFacturaFecha.Name = "tbFacturaFecha";
            this.tbFacturaFecha.Size = new System.Drawing.Size(165, 28);
            this.tbFacturaFecha.TabIndex = 4;
            // 
            // lblFacturaFecha
            // 
            this.lblFacturaFecha.AutoSize = true;
            this.lblFacturaFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturaFecha.Location = new System.Drawing.Point(33, 11);
            this.lblFacturaFecha.Name = "lblFacturaFecha";
            this.lblFacturaFecha.Size = new System.Drawing.Size(129, 24);
            this.lblFacturaFecha.TabIndex = 1;
            this.lblFacturaFecha.Text = "Fecha Venta";
            // 
            // btnAtrasFactura
            // 
            this.btnAtrasFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAtrasFactura.BackgroundImage = global::proyecto.Properties.Resources.Presentación11;
            this.btnAtrasFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtrasFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtrasFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtrasFactura.Location = new System.Drawing.Point(791, 820);
            this.btnAtrasFactura.Name = "btnAtrasFactura";
            this.btnAtrasFactura.Size = new System.Drawing.Size(103, 43);
            this.btnAtrasFactura.TabIndex = 70;
            this.btnAtrasFactura.UseVisualStyleBackColor = false;
            this.btnAtrasFactura.Click += new System.EventHandler(this.btnAtrasFactura_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Controls.Add(this.tbClienteNombre);
            this.panel1.Controls.Add(this.tbClienteCuil);
            this.panel1.Controls.Add(this.lblClienteNombre);
            this.panel1.Controls.Add(this.lblClienteCuil);
            this.panel1.Location = new System.Drawing.Point(81, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 105);
            this.panel1.TabIndex = 71;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(-5, -1);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(135, 26);
            this.lblCliente.TabIndex = 6;
            this.lblCliente.Text = "Datos Cliente";
            // 
            // tbClienteNombre
            // 
            this.tbClienteNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClienteNombre.Location = new System.Drawing.Point(139, 19);
            this.tbClienteNombre.Name = "tbClienteNombre";
            this.tbClienteNombre.Size = new System.Drawing.Size(317, 28);
            this.tbClienteNombre.TabIndex = 5;
            // 
            // tbClienteCuil
            // 
            this.tbClienteCuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClienteCuil.Location = new System.Drawing.Point(139, 53);
            this.tbClienteCuil.Name = "tbClienteCuil";
            this.tbClienteCuil.Size = new System.Drawing.Size(317, 28);
            this.tbClienteCuil.TabIndex = 4;
            this.tbClienteCuil.TextChanged += new System.EventHandler(this.tbClienteApellido_TextChanged);
            // 
            // lblClienteNombre
            // 
            this.lblClienteNombre.AutoSize = true;
            this.lblClienteNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteNombre.Location = new System.Drawing.Point(19, 24);
            this.lblClienteNombre.Name = "lblClienteNombre";
            this.lblClienteNombre.Size = new System.Drawing.Size(85, 24);
            this.lblClienteNombre.TabIndex = 1;
            this.lblClienteNombre.Text = "Nombre";
            // 
            // lblClienteCuil
            // 
            this.lblClienteCuil.AutoSize = true;
            this.lblClienteCuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteCuil.Location = new System.Drawing.Point(19, 57);
            this.lblClienteCuil.Name = "lblClienteCuil";
            this.lblClienteCuil.Size = new System.Drawing.Size(46, 24);
            this.lblClienteCuil.TabIndex = 0;
            this.lblClienteCuil.Text = "Cuil";
            // 
            // pnlFacturaDatos
            // 
            this.pnlFacturaDatos.BackColor = System.Drawing.Color.Transparent;
            this.pnlFacturaDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFacturaDatos.Controls.Add(this.tbEmpleadoCuil);
            this.pnlFacturaDatos.Controls.Add(this.lblCuilEmpleado);
            this.pnlFacturaDatos.Controls.Add(this.tbEmpleadoNombre);
            this.pnlFacturaDatos.Controls.Add(this.lblEmpleadoNombre);
            this.pnlFacturaDatos.Location = new System.Drawing.Point(77, 184);
            this.pnlFacturaDatos.Name = "pnlFacturaDatos";
            this.pnlFacturaDatos.Size = new System.Drawing.Size(508, 95);
            this.pnlFacturaDatos.TabIndex = 3;
            // 
            // tbEmpleadoCuil
            // 
            this.tbEmpleadoCuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmpleadoCuil.Location = new System.Drawing.Point(139, 56);
            this.tbEmpleadoCuil.Name = "tbEmpleadoCuil";
            this.tbEmpleadoCuil.Size = new System.Drawing.Size(317, 28);
            this.tbEmpleadoCuil.TabIndex = 9;
            // 
            // lblCuilEmpleado
            // 
            this.lblCuilEmpleado.AutoSize = true;
            this.lblCuilEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuilEmpleado.Location = new System.Drawing.Point(19, 55);
            this.lblCuilEmpleado.Name = "lblCuilEmpleado";
            this.lblCuilEmpleado.Size = new System.Drawing.Size(46, 24);
            this.lblCuilEmpleado.TabIndex = 6;
            this.lblCuilEmpleado.Text = "Cuil";
            // 
            // tbEmpleadoNombre
            // 
            this.tbEmpleadoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmpleadoNombre.Location = new System.Drawing.Point(139, 22);
            this.tbEmpleadoNombre.Name = "tbEmpleadoNombre";
            this.tbEmpleadoNombre.Size = new System.Drawing.Size(317, 28);
            this.tbEmpleadoNombre.TabIndex = 5;
            // 
            // lblEmpleadoNombre
            // 
            this.lblEmpleadoNombre.AutoSize = true;
            this.lblEmpleadoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleadoNombre.Location = new System.Drawing.Point(19, 22);
            this.lblEmpleadoNombre.Name = "lblEmpleadoNombre";
            this.lblEmpleadoNombre.Size = new System.Drawing.Size(85, 24);
            this.lblEmpleadoNombre.TabIndex = 2;
            this.lblEmpleadoNombre.Text = "Nombre";
            // 
            // tbIva
            // 
            this.tbIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIva.Location = new System.Drawing.Point(754, 750);
            this.tbIva.Name = "tbIva";
            this.tbIva.Size = new System.Drawing.Size(140, 28);
            this.tbIva.TabIndex = 73;
            this.tbIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lvlIva
            // 
            this.lvlIva.AutoSize = true;
            this.lvlIva.BackColor = System.Drawing.Color.Transparent;
            this.lvlIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvlIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlIva.Location = new System.Drawing.Point(613, 753);
            this.lvlIva.Name = "lvlIva";
            this.lvlIva.Size = new System.Drawing.Size(89, 26);
            this.lvlIva.TabIndex = 72;
            this.lvlIva.Text = "IVA 21%";
            // 
            // tbTotalFinal
            // 
            this.tbTotalFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalFinal.Location = new System.Drawing.Point(754, 784);
            this.tbTotalFinal.Name = "tbTotalFinal";
            this.tbTotalFinal.Size = new System.Drawing.Size(140, 28);
            this.tbTotalFinal.TabIndex = 75;
            this.tbTotalFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(613, 787);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(110, 26);
            this.lblTotal.TabIndex = 74;
            this.lblTotal.Text = "Total Final";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(39, 719);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(546, 23);
            this.lblSubTotal.TabIndex = 76;
            // 
            // lblTotalFinal
            // 
            this.lblTotalFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFinal.Location = new System.Drawing.Point(39, 791);
            this.lblTotalFinal.Name = "lblTotalFinal";
            this.lblTotalFinal.Size = new System.Drawing.Size(546, 23);
            this.lblTotalFinal.TabIndex = 77;
            // 
            // lblFacturaA
            // 
            this.lblFacturaA.BackColor = System.Drawing.Color.Transparent;
            this.lblFacturaA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFacturaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturaA.Location = new System.Drawing.Point(412, 5);
            this.lblFacturaA.Name = "lblFacturaA";
            this.lblFacturaA.Size = new System.Drawing.Size(90, 90);
            this.lblFacturaA.TabIndex = 78;
            this.lblFacturaA.Text = "A";
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proyecto.Properties.Resources.fondod1;
            this.ClientSize = new System.Drawing.Size(915, 1055);
            this.Controls.Add(this.lblFacturaA);
            this.Controls.Add(this.lblTotalFinal);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.tbTotalFinal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.tbIva);
            this.Controls.Add(this.lvlIva);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAtrasFactura);
            this.Controls.Add(this.pnlFacturaFecha);
            this.Controls.Add(this.tbFacturaSubTotal);
            this.Controls.Add(this.lblFacturaSubTotal);
            this.Controls.Add(this.lblFacturaDetalle);
            this.Controls.Add(this.pnlFacturaDatos);
            this.Controls.Add(this.dgvFacturaVenta);
            this.Controls.Add(this.pnlFacuraNumero);
            this.Controls.Add(this.pnlFacturaLogo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFactura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            this.pnlFacuraNumero.ResumeLayout(false);
            this.pnlFacuraNumero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturaVenta)).EndInit();
            this.pnlFacturaFecha.ResumeLayout(false);
            this.pnlFacturaFecha.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlFacturaDatos.ResumeLayout(false);
            this.pnlFacturaDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFacturaLogo;
        private System.Windows.Forms.Panel pnlFacuraNumero;
        private System.Windows.Forms.DataGridView dgvFacturaVenta;
        private System.Windows.Forms.Label lblFacturaNumero;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.Label lblFacturaDetalle;
        private System.Windows.Forms.Label lblFacturaSubTotal;
        private System.Windows.Forms.TextBox tbFacturaSubTotal;
        private System.Windows.Forms.Panel pnlFacturaFecha;
        private System.Windows.Forms.TextBox tbFacturaFecha;
        private System.Windows.Forms.Label lblFacturaFecha;
        private System.Windows.Forms.Button btnAtrasFactura;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox tbClienteNombre;
        private System.Windows.Forms.Label lblClienteNombre;
        private System.Windows.Forms.TextBox tbFechaVencimiento;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.Panel pnlFacturaDatos;
        private System.Windows.Forms.TextBox tbEmpleadoNombre;
        private System.Windows.Forms.Label lblEmpleadoNombre;
        private System.Windows.Forms.TextBox tbClienteCuil;
        private System.Windows.Forms.Label lblClienteCuil;
        private System.Windows.Forms.TextBox tbEmpleadoCuil;
        private System.Windows.Forms.Label lblCuilEmpleado;
        private System.Windows.Forms.TextBox tbIva;
        private System.Windows.Forms.Label lvlIva;
        private System.Windows.Forms.TextBox tbTotalFinal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblTotalFinal;
        private System.Windows.Forms.Label lblFacturaA;
    }
}