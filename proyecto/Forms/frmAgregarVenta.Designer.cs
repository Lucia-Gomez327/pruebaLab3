namespace proyecto
{
    partial class frmAgregarVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarVenta));
            this.pnlAgregarCliente = new System.Windows.Forms.Panel();
            this.tbNombreCliente = new System.Windows.Forms.TextBox();
            this.rbBaja = new System.Windows.Forms.RadioButton();
            this.pnlClientes = new System.Windows.Forms.Panel();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.rbAlta = new System.Windows.Forms.RadioButton();
            this.lblAltaBaja = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbTotalVenta = new System.Windows.Forms.TextBox();
            this.lblTotalCompra = new System.Windows.Forms.Label();
            this.lblNombreClienteVenta = new System.Windows.Forms.Label();
            this.nudCantidadProducto = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.lblNombreVendedor = new System.Windows.Forms.Label();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.tbNombreUsuario = new System.Windows.Forms.TextBox();
            this.btnSeleccionarCliente = new System.Windows.Forms.Button();
            this.btnVolverInicio = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblVentas = new System.Windows.Forms.Label();
            this.pnlAgregarCliente.SuspendLayout();
            this.pnlClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAgregarCliente
            // 
            this.pnlAgregarCliente.BackColor = System.Drawing.Color.Transparent;
            this.pnlAgregarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAgregarCliente.Controls.Add(this.tbNombreCliente);
            this.pnlAgregarCliente.Controls.Add(this.rbBaja);
            this.pnlAgregarCliente.Controls.Add(this.pnlClientes);
            this.pnlAgregarCliente.Controls.Add(this.rbAlta);
            this.pnlAgregarCliente.Controls.Add(this.lblAltaBaja);
            this.pnlAgregarCliente.Controls.Add(this.dgvProductos);
            this.pnlAgregarCliente.Controls.Add(this.tbTotalVenta);
            this.pnlAgregarCliente.Controls.Add(this.lblTotalCompra);
            this.pnlAgregarCliente.Controls.Add(this.lblNombreClienteVenta);
            this.pnlAgregarCliente.Controls.Add(this.nudCantidadProducto);
            this.pnlAgregarCliente.Controls.Add(this.lblCantidad);
            this.pnlAgregarCliente.Controls.Add(this.dtpFechaVenta);
            this.pnlAgregarCliente.Controls.Add(this.lblNombreVendedor);
            this.pnlAgregarCliente.Controls.Add(this.lblFechaVenta);
            this.pnlAgregarCliente.Controls.Add(this.lblProducto);
            this.pnlAgregarCliente.Controls.Add(this.tbNombreUsuario);
            this.pnlAgregarCliente.Location = new System.Drawing.Point(45, 56);
            this.pnlAgregarCliente.Name = "pnlAgregarCliente";
            this.pnlAgregarCliente.Size = new System.Drawing.Size(1228, 371);
            this.pnlAgregarCliente.TabIndex = 70;
            // 
            // tbNombreCliente
            // 
            this.tbNombreCliente.Location = new System.Drawing.Point(204, 87);
            this.tbNombreCliente.Name = "tbNombreCliente";
            this.tbNombreCliente.ReadOnly = true;
            this.tbNombreCliente.Size = new System.Drawing.Size(247, 22);
            this.tbNombreCliente.TabIndex = 105;
            // 
            // rbBaja
            // 
            this.rbBaja.AutoSize = true;
            this.rbBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBaja.Location = new System.Drawing.Point(320, 266);
            this.rbBaja.Name = "rbBaja";
            this.rbBaja.Size = new System.Drawing.Size(61, 21);
            this.rbBaja.TabIndex = 102;
            this.rbBaja.TabStop = true;
            this.rbBaja.Text = "Baja";
            this.rbBaja.UseVisualStyleBackColor = true;
            // 
            // pnlClientes
            // 
            this.pnlClientes.BackColor = System.Drawing.Color.Transparent;
            this.pnlClientes.BackgroundImage = global::proyecto.Properties.Resources.depositphotos_29231767_stock_illustration_orange_background1;
            this.pnlClientes.Controls.Add(this.dgvClientes);
            this.pnlClientes.Location = new System.Drawing.Point(503, 66);
            this.pnlClientes.Name = "pnlClientes";
            this.pnlClientes.Size = new System.Drawing.Size(686, 371);
            this.pnlClientes.TabIndex = 104;
            // 
            // dgvClientes
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvClientes.Location = new System.Drawing.Point(15, 4);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(1092, 371);
            this.dgvClientes.TabIndex = 0;
            // 
            // rbAlta
            // 
            this.rbAlta.AutoSize = true;
            this.rbAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAlta.Location = new System.Drawing.Point(204, 266);
            this.rbAlta.Name = "rbAlta";
            this.rbAlta.Size = new System.Drawing.Size(57, 21);
            this.rbAlta.TabIndex = 101;
            this.rbAlta.TabStop = true;
            this.rbAlta.Text = "Alta";
            this.rbAlta.UseVisualStyleBackColor = true;
            // 
            // lblAltaBaja
            // 
            this.lblAltaBaja.AutoSize = true;
            this.lblAltaBaja.BackColor = System.Drawing.Color.Transparent;
            this.lblAltaBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaBaja.Location = new System.Drawing.Point(89, 267);
            this.lblAltaBaja.Name = "lblAltaBaja";
            this.lblAltaBaja.Size = new System.Drawing.Size(84, 18);
            this.lblAltaBaja.TabIndex = 103;
            this.lblAltaBaja.Text = "Alta / Baja";
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Articulo,
            this.Cantidad,
            this.Precio,
            this.Importe});
            this.dgvProductos.Location = new System.Drawing.Point(541, 22);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(672, 315);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvProductos_UserDeletedRow);
            // 
            // Articulo
            // 
            this.Articulo.HeaderText = "Articulo";
            this.Articulo.MinimumWidth = 6;
            this.Articulo.Name = "Articulo";
            this.Articulo.ReadOnly = true;
            this.Articulo.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 70;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 125;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.MinimumWidth = 6;
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Width = 125;
            // 
            // tbTotalVenta
            // 
            this.tbTotalVenta.Location = new System.Drawing.Point(1071, 343);
            this.tbTotalVenta.Name = "tbTotalVenta";
            this.tbTotalVenta.Size = new System.Drawing.Size(142, 22);
            this.tbTotalVenta.TabIndex = 100;
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCompra.Location = new System.Drawing.Point(1019, 347);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(46, 18);
            this.lblTotalCompra.TabIndex = 99;
            this.lblTotalCompra.Text = "Total";
            // 
            // lblNombreClienteVenta
            // 
            this.lblNombreClienteVenta.AutoSize = true;
            this.lblNombreClienteVenta.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreClienteVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreClienteVenta.Location = new System.Drawing.Point(48, 87);
            this.lblNombreClienteVenta.Name = "lblNombreClienteVenta";
            this.lblNombreClienteVenta.Size = new System.Drawing.Size(125, 18);
            this.lblNombreClienteVenta.TabIndex = 94;
            this.lblNombreClienteVenta.Text = "Nombre Cliente";
            // 
            // nudCantidadProducto
            // 
            this.nudCantidadProducto.Location = new System.Drawing.Point(204, 210);
            this.nudCantidadProducto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadProducto.Name = "nudCantidadProducto";
            this.nudCantidadProducto.Size = new System.Drawing.Size(86, 22);
            this.nudCantidadProducto.TabIndex = 93;
            this.nudCantidadProducto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadProducto.ValueChanged += new System.EventHandler(this.nudCantidadProducto_ValueChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(102, 213);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(74, 18);
            this.lblCantidad.TabIndex = 92;
            this.lblCantidad.Text = "Cantidad";
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Location = new System.Drawing.Point(204, 127);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(247, 22);
            this.dtpFechaVenta.TabIndex = 91;
            // 
            // lblNombreVendedor
            // 
            this.lblNombreVendedor.AutoSize = true;
            this.lblNombreVendedor.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreVendedor.Location = new System.Drawing.Point(29, 45);
            this.lblNombreVendedor.Name = "lblNombreVendedor";
            this.lblNombreVendedor.Size = new System.Drawing.Size(144, 18);
            this.lblNombreVendedor.TabIndex = 88;
            this.lblNombreVendedor.Text = "Nombre Vendedor";
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVenta.Location = new System.Drawing.Point(49, 131);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(124, 18);
            this.lblFechaVenta.TabIndex = 87;
            this.lblFechaVenta.Text = "Fecha de Venta";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(89, 174);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(77, 18);
            this.lblProducto.TabIndex = 90;
            this.lblProducto.Text = "Producto";
            // 
            // tbNombreUsuario
            // 
            this.tbNombreUsuario.Location = new System.Drawing.Point(204, 41);
            this.tbNombreUsuario.Name = "tbNombreUsuario";
            this.tbNombreUsuario.Size = new System.Drawing.Size(247, 22);
            this.tbNombreUsuario.TabIndex = 89;
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(1236, 79);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(91, 26);
            this.btnSeleccionarCliente.TabIndex = 1;
            this.btnSeleccionarCliente.Text = "Seleccionar Cliente";
            this.btnSeleccionarCliente.UseVisualStyleBackColor = true;
            this.btnSeleccionarCliente.Click += new System.EventHandler(this.btnSeleccionarCliente_Click);
            // 
            // btnVolverInicio
            // 
            this.btnVolverInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVolverInicio.BackgroundImage = global::proyecto.Properties.Resources.Presentación11;
            this.btnVolverInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolverInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverInicio.Location = new System.Drawing.Point(822, 451);
            this.btnVolverInicio.Name = "btnVolverInicio";
            this.btnVolverInicio.Size = new System.Drawing.Size(103, 43);
            this.btnVolverInicio.TabIndex = 69;
            this.btnVolverInicio.UseVisualStyleBackColor = false;
            this.btnVolverInicio.Click += new System.EventHandler(this.btnVolverInicio_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCargar.BackgroundImage = global::proyecto.Properties.Resources.Diapositiva1;
            this.btnCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(995, 451);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(103, 43);
            this.btnCargar.TabIndex = 68;
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(1168, 451);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(103, 43);
            this.btnModificar.TabIndex = 72;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.BackColor = System.Drawing.Color.Transparent;
            this.lblVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.Location = new System.Drawing.Point(395, 24);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(115, 29);
            this.lblVentas.TabIndex = 73;
            this.lblVentas.Text = "VENTAS";
            // 
            // frmAgregarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proyecto.Properties.Resources.depositphotos_29231767_stock_illustration_orange_background;
            this.ClientSize = new System.Drawing.Size(1325, 564);
            this.Controls.Add(this.btnSeleccionarCliente);
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.pnlAgregarCliente);
            this.Controls.Add(this.btnVolverInicio);
            this.Controls.Add(this.btnCargar);
            this.Name = "frmAgregarVenta";
            this.Text = "Agregar Venta";
            this.Load += new System.EventHandler(this.frmAgregarVenta_Load);
            this.pnlAgregarCliente.ResumeLayout(false);
            this.pnlAgregarCliente.PerformLayout();
            this.pnlClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAgregarCliente;
        private System.Windows.Forms.Button btnVolverInicio;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TextBox tbTotalVenta;
        private System.Windows.Forms.Label lblTotalCompra;
        private System.Windows.Forms.NumericUpDown nudCantidadProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.Label lblNombreVendedor;
        private System.Windows.Forms.Label lblFechaVenta;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox tbNombreUsuario;
        private System.Windows.Forms.RadioButton rbBaja;
        private System.Windows.Forms.RadioButton rbAlta;
        private System.Windows.Forms.Label lblAltaBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.Panel pnlClientes;
        private System.Windows.Forms.Button btnSeleccionarCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox tbNombreCliente;
        private System.Windows.Forms.Label lblNombreClienteVenta;
    }
}