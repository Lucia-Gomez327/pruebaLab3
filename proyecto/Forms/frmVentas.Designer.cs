namespace proyecto.Forms
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.tbTipo = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.tbNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombreClienteVenta = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gbVendedor = new System.Windows.Forms.GroupBox();
            this.tbNombreVendedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbDetalle = new System.Windows.Forms.GroupBox();
            this.tbImporte = new System.Windows.Forms.TextBox();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.cboCodigo = new System.Windows.Forms.ComboBox();
            this.gbCarrito = new System.Windows.Forms.GroupBox();
            this.pnlEliminarProducto = new System.Windows.Forms.Panel();
            this.pnlAgregarProcucto = new System.Windows.Forms.Panel();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.colCodigoBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudCantidadProducto = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblCodigoP = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnVolverInicio = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.pnlClientes = new System.Windows.Forms.Panel();
            this.tbFiltrar = new System.Windows.Forms.TextBox();
            this.btnSeleccionarCliente = new System.Windows.Forms.Button();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.tbTotalVenta = new System.Windows.Forms.TextBox();
            this.lblTotalCompra = new System.Windows.Forms.Label();
            this.rbBaja = new System.Windows.Forms.RadioButton();
            this.rbAlta = new System.Windows.Forms.RadioButton();
            this.lblAltaBaja = new System.Windows.Forms.Label();
            this.gbCliente.SuspendLayout();
            this.gbVendedor.SuspendLayout();
            this.gbDetalle.SuspendLayout();
            this.gbCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadProducto)).BeginInit();
            this.pnlClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(186, 55);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.ReadOnly = true;
            this.tbCodigo.Size = new System.Drawing.Size(100, 22);
            this.tbCodigo.TabIndex = 0;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(337, 54);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(65, 25);
            this.lblFecha.TabIndex = 62;
            this.lblFecha.Text = "fecha";
            // 
            // gbCliente
            // 
            this.gbCliente.BackColor = System.Drawing.Color.Transparent;
            this.gbCliente.Controls.Add(this.tbNumero);
            this.gbCliente.Controls.Add(this.lblNumero);
            this.gbCliente.Controls.Add(this.tbTipo);
            this.gbCliente.Controls.Add(this.lblTipo);
            this.gbCliente.Controls.Add(this.tbNombreCliente);
            this.gbCliente.Controls.Add(this.lblNombreClienteVenta);
            this.gbCliente.Location = new System.Drawing.Point(44, 245);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(795, 131);
            this.gbCliente.TabIndex = 75;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(539, 70);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.ReadOnly = true;
            this.tbNumero.Size = new System.Drawing.Size(233, 22);
            this.tbNumero.TabIndex = 111;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.BackColor = System.Drawing.Color.Transparent;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(466, 72);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(73, 18);
            this.lblNumero.TabIndex = 110;
            this.lblNumero.Text = "Numero:";
            // 
            // tbTipo
            // 
            this.tbTipo.Location = new System.Drawing.Point(163, 68);
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.ReadOnly = true;
            this.tbTipo.Size = new System.Drawing.Size(237, 22);
            this.tbTipo.TabIndex = 109;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(6, 70);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(138, 18);
            this.lblTipo.TabIndex = 108;
            this.lblTipo.Text = "Tipo Documento:";
            // 
            // tbNombreCliente
            // 
            this.tbNombreCliente.Location = new System.Drawing.Point(163, 35);
            this.tbNombreCliente.Name = "tbNombreCliente";
            this.tbNombreCliente.ReadOnly = true;
            this.tbNombreCliente.Size = new System.Drawing.Size(609, 22);
            this.tbNombreCliente.TabIndex = 107;
            // 
            // lblNombreClienteVenta
            // 
            this.lblNombreClienteVenta.AutoSize = true;
            this.lblNombreClienteVenta.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreClienteVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreClienteVenta.Location = new System.Drawing.Point(79, 36);
            this.lblNombreClienteVenta.Name = "lblNombreClienteVenta";
            this.lblNombreClienteVenta.Size = new System.Drawing.Size(65, 18);
            this.lblNombreClienteVenta.TabIndex = 106;
            this.lblNombreClienteVenta.Text = "Cliente:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(73, 54);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(99, 25);
            this.lblCodigo.TabIndex = 76;
            this.lblCodigo.Text = "N° Venta";
            // 
            // gbVendedor
            // 
            this.gbVendedor.BackColor = System.Drawing.Color.Transparent;
            this.gbVendedor.Controls.Add(this.tbNombreVendedor);
            this.gbVendedor.Controls.Add(this.label3);
            this.gbVendedor.Location = new System.Drawing.Point(44, 129);
            this.gbVendedor.Name = "gbVendedor";
            this.gbVendedor.Size = new System.Drawing.Size(795, 89);
            this.gbVendedor.TabIndex = 77;
            this.gbVendedor.TabStop = false;
            this.gbVendedor.Text = "Vendedor";
            // 
            // tbNombreVendedor
            // 
            this.tbNombreVendedor.Location = new System.Drawing.Point(163, 34);
            this.tbNombreVendedor.Name = "tbNombreVendedor";
            this.tbNombreVendedor.ReadOnly = true;
            this.tbNombreVendedor.Size = new System.Drawing.Size(609, 22);
            this.tbNombreVendedor.TabIndex = 109;
            this.tbNombreVendedor.TextChanged += new System.EventHandler(this.TbNombreVendedor_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 18);
            this.label3.TabIndex = 108;
            this.label3.Text = "Codigo vendedor:";
            // 
            // gbDetalle
            // 
            this.gbDetalle.BackColor = System.Drawing.Color.Transparent;
            this.gbDetalle.Controls.Add(this.tbImporte);
            this.gbDetalle.Controls.Add(this.cboProducto);
            this.gbDetalle.Controls.Add(this.cboCodigo);
            this.gbDetalle.Controls.Add(this.gbCarrito);
            this.gbDetalle.Controls.Add(this.dgvProductos);
            this.gbDetalle.Controls.Add(this.nudCantidadProducto);
            this.gbDetalle.Controls.Add(this.label1);
            this.gbDetalle.Controls.Add(this.lblImporte);
            this.gbDetalle.Controls.Add(this.lblProducto);
            this.gbDetalle.Controls.Add(this.lblCodigoP);
            this.gbDetalle.Location = new System.Drawing.Point(44, 394);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Size = new System.Drawing.Size(795, 368);
            this.gbDetalle.TabIndex = 78;
            this.gbDetalle.TabStop = false;
            this.gbDetalle.Text = "Detalle";
            // 
            // tbImporte
            // 
            this.tbImporte.Location = new System.Drawing.Point(646, 66);
            this.tbImporte.Name = "tbImporte";
            this.tbImporte.ReadOnly = true;
            this.tbImporte.Size = new System.Drawing.Size(126, 22);
            this.tbImporte.TabIndex = 120;
            this.tbImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboProducto
            // 
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(145, 66);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(372, 24);
            this.cboProducto.TabIndex = 119;
            // 
            // cboCodigo
            // 
            this.cboCodigo.FormattingEnabled = true;
            this.cboCodigo.Items.AddRange(new object[] {
            "",
            ""});
            this.cboCodigo.Location = new System.Drawing.Point(32, 66);
            this.cboCodigo.Name = "cboCodigo";
            this.cboCodigo.Size = new System.Drawing.Size(96, 24);
            this.cboCodigo.TabIndex = 118;
            this.cboCodigo.SelectedIndexChanged += new System.EventHandler(this.cboCodigo_SelectedIndexChanged);
            this.cboCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbCodigo_KeyUp);
            // 
            // gbCarrito
            // 
            this.gbCarrito.BackColor = System.Drawing.Color.Transparent;
            this.gbCarrito.Controls.Add(this.pnlEliminarProducto);
            this.gbCarrito.Controls.Add(this.pnlAgregarProcucto);
            this.gbCarrito.Location = new System.Drawing.Point(710, 123);
            this.gbCarrito.Name = "gbCarrito";
            this.gbCarrito.Size = new System.Drawing.Size(62, 225);
            this.gbCarrito.TabIndex = 79;
            this.gbCarrito.TabStop = false;
            // 
            // pnlEliminarProducto
            // 
            this.pnlEliminarProducto.BackgroundImage = global::proyecto.Properties.Resources.eliminar_carrito;
            this.pnlEliminarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEliminarProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlEliminarProducto.Location = new System.Drawing.Point(11, 135);
            this.pnlEliminarProducto.Name = "pnlEliminarProducto";
            this.pnlEliminarProducto.Size = new System.Drawing.Size(45, 45);
            this.pnlEliminarProducto.TabIndex = 118;
            this.pnlEliminarProducto.Click += new System.EventHandler(this.pnlEliminarProducto_Click);
            this.pnlEliminarProducto.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlEliminarProducto_Paint);
            // 
            // pnlAgregarProcucto
            // 
            this.pnlAgregarProcucto.BackgroundImage = global::proyecto.Properties.Resources.agregar_carritos;
            this.pnlAgregarProcucto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAgregarProcucto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAgregarProcucto.Location = new System.Drawing.Point(11, 64);
            this.pnlAgregarProcucto.Name = "pnlAgregarProcucto";
            this.pnlAgregarProcucto.Size = new System.Drawing.Size(45, 45);
            this.pnlAgregarProcucto.TabIndex = 117;
            this.pnlAgregarProcucto.Click += new System.EventHandler(this.pnlAgregarProcucto_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigoBarra,
            this.Articulo,
            this.Cantidad,
            this.Precio,
            this.Importe});
            this.dgvProductos.Location = new System.Drawing.Point(32, 123);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(672, 225);
            this.dgvProductos.TabIndex = 116;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // colCodigoBarra
            // 
            this.colCodigoBarra.FillWeight = 80F;
            this.colCodigoBarra.HeaderText = "C. Barra";
            this.colCodigoBarra.MinimumWidth = 6;
            this.colCodigoBarra.Name = "colCodigoBarra";
            this.colCodigoBarra.ReadOnly = true;
            this.colCodigoBarra.Width = 90;
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
            this.Cantidad.HeaderText = "Cant";
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
            this.Precio.Width = 90;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.MinimumWidth = 6;
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Width = 80;
            // 
            // nudCantidadProducto
            // 
            this.nudCantidadProducto.Location = new System.Drawing.Point(538, 67);
            this.nudCantidadProducto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadProducto.Name = "nudCantidadProducto";
            this.nudCantidadProducto.Size = new System.Drawing.Size(86, 22);
            this.nudCantidadProducto.TabIndex = 115;
            this.nudCantidadProducto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadProducto.ValueChanged += new System.EventHandler(this.nudCantidadProducto_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(538, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 114;
            this.label1.Text = "Cantidad:";
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.BackColor = System.Drawing.Color.Transparent;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.Location = new System.Drawing.Point(643, 36);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(70, 18);
            this.lblImporte.TabIndex = 112;
            this.lblImporte.Text = "Importe:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(142, 36);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(82, 18);
            this.lblProducto.TabIndex = 110;
            this.lblProducto.Text = "Producto:";
            // 
            // lblCodigoP
            // 
            this.lblCodigoP.AutoSize = true;
            this.lblCodigoP.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoP.Location = new System.Drawing.Point(29, 36);
            this.lblCodigoP.Name = "lblCodigoP";
            this.lblCodigoP.Size = new System.Drawing.Size(67, 18);
            this.lblCodigoP.TabIndex = 108;
            this.lblCodigoP.Text = "Codigo:";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(736, 850);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(103, 43);
            this.btnModificar.TabIndex = 81;
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnVolverInicio
            // 
            this.btnVolverInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVolverInicio.BackgroundImage = global::proyecto.Properties.Resources.Presentación11;
            this.btnVolverInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolverInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverInicio.Location = new System.Drawing.Point(390, 850);
            this.btnVolverInicio.Name = "btnVolverInicio";
            this.btnVolverInicio.Size = new System.Drawing.Size(103, 43);
            this.btnVolverInicio.TabIndex = 80;
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
            this.btnCargar.Location = new System.Drawing.Point(563, 850);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(103, 43);
            this.btnCargar.TabIndex = 79;
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // pnlClientes
            // 
            this.pnlClientes.BackColor = System.Drawing.Color.Transparent;
            this.pnlClientes.Controls.Add(this.tbFiltrar);
            this.pnlClientes.Controls.Add(this.btnSeleccionarCliente);
            this.pnlClientes.Controls.Add(this.lblSeleccion);
            this.pnlClientes.Controls.Add(this.dgvClientes);
            this.pnlClientes.Location = new System.Drawing.Point(44, 47);
            this.pnlClientes.Name = "pnlClientes";
            this.pnlClientes.Size = new System.Drawing.Size(810, 846);
            this.pnlClientes.TabIndex = 105;
            // 
            // tbFiltrar
            // 
            this.tbFiltrar.Location = new System.Drawing.Point(463, 34);
            this.tbFiltrar.Name = "tbFiltrar";
            this.tbFiltrar.Size = new System.Drawing.Size(177, 22);
            this.tbFiltrar.TabIndex = 79;
            this.tbFiltrar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbFiltrar_KeyUp);
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.BackgroundImage = global::proyecto.Properties.Resources.ACEPTAR1;
            this.btnSeleccionarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(309, 21);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(91, 38);
            this.btnSeleccionarCliente.TabIndex = 78;
            this.btnSeleccionarCliente.UseVisualStyleBackColor = true;
            this.btnSeleccionarCliente.Click += new System.EventHandler(this.btnSeleccionarCliente_Click);
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.BackColor = System.Drawing.Color.Transparent;
            this.lblSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccion.Location = new System.Drawing.Point(69, 34);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(193, 25);
            this.lblSeleccion.TabIndex = 77;
            this.lblSeleccion.Text = "Seleccione Cliente";
            this.lblSeleccion.Click += new System.EventHandler(this.LblSeleccion_Click);
            // 
            // dgvClientes
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.Location = new System.Drawing.Point(74, 78);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(660, 637);
            this.dgvClientes.TabIndex = 0;
            // 
            // tbTotalVenta
            // 
            this.tbTotalVenta.Location = new System.Drawing.Point(612, 778);
            this.tbTotalVenta.Name = "tbTotalVenta";
            this.tbTotalVenta.Size = new System.Drawing.Size(142, 22);
            this.tbTotalVenta.TabIndex = 107;
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCompra.Location = new System.Drawing.Point(555, 782);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(51, 18);
            this.lblTotalCompra.TabIndex = 106;
            this.lblTotalCompra.Text = "Total:";
            // 
            // rbBaja
            // 
            this.rbBaja.AutoSize = true;
            this.rbBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBaja.Location = new System.Drawing.Point(272, 861);
            this.rbBaja.Name = "rbBaja";
            this.rbBaja.Size = new System.Drawing.Size(61, 21);
            this.rbBaja.TabIndex = 109;
            this.rbBaja.TabStop = true;
            this.rbBaja.Text = "Baja";
            this.rbBaja.UseVisualStyleBackColor = true;
            // 
            // rbAlta
            // 
            this.rbAlta.AutoSize = true;
            this.rbAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAlta.Location = new System.Drawing.Point(156, 861);
            this.rbAlta.Name = "rbAlta";
            this.rbAlta.Size = new System.Drawing.Size(57, 21);
            this.rbAlta.TabIndex = 108;
            this.rbAlta.TabStop = true;
            this.rbAlta.Text = "Alta";
            this.rbAlta.UseVisualStyleBackColor = true;
            // 
            // lblAltaBaja
            // 
            this.lblAltaBaja.AutoSize = true;
            this.lblAltaBaja.BackColor = System.Drawing.Color.Transparent;
            this.lblAltaBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaBaja.Location = new System.Drawing.Point(41, 862);
            this.lblAltaBaja.Name = "lblAltaBaja";
            this.lblAltaBaja.Size = new System.Drawing.Size(84, 18);
            this.lblAltaBaja.TabIndex = 110;
            this.lblAltaBaja.Text = "Alta / Baja";
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proyecto.Properties.Resources.depositphotos_29231767_stock_illustration_orange_background3;
            this.ClientSize = new System.Drawing.Size(891, 905);
            this.Controls.Add(this.rbBaja);
            this.Controls.Add(this.rbAlta);
            this.Controls.Add(this.lblAltaBaja);
            this.Controls.Add(this.tbTotalVenta);
            this.Controls.Add(this.lblTotalCompra);
            this.Controls.Add(this.pnlClientes);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnVolverInicio);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.gbDetalle);
            this.Controls.Add(this.gbVendedor);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.tbCodigo);
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbVendedor.ResumeLayout(false);
            this.gbVendedor.PerformLayout();
            this.gbDetalle.ResumeLayout(false);
            this.gbDetalle.PerformLayout();
            this.gbCarrito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadProducto)).EndInit();
            this.pnlClientes.ResumeLayout(false);
            this.pnlClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox tbNombreCliente;
        private System.Windows.Forms.Label lblNombreClienteVenta;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox tbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.GroupBox gbVendedor;
        private System.Windows.Forms.TextBox tbNombreVendedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblCodigoP;
        private System.Windows.Forms.NumericUpDown nudCantidadProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Panel pnlAgregarProcucto;
        private System.Windows.Forms.GroupBox gbCarrito;
        private System.Windows.Forms.Panel pnlEliminarProducto;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnVolverInicio;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Panel pnlClientes;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnSeleccionarCliente;
        private System.Windows.Forms.TextBox tbTotalVenta;
        private System.Windows.Forms.Label lblTotalCompra;
        private System.Windows.Forms.RadioButton rbBaja;
        private System.Windows.Forms.RadioButton rbAlta;
        private System.Windows.Forms.Label lblAltaBaja;
        private System.Windows.Forms.TextBox tbFiltrar;
        private System.Windows.Forms.ComboBox cboCodigo;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.TextBox tbImporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
    }
}