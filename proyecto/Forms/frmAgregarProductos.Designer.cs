namespace proyecto
{
    partial class frmAgregarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarProductos));
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.pnlAgregarCliente = new System.Windows.Forms.Panel();
            this.nudCantidadProductos = new System.Windows.Forms.NumericUpDown();
            this.rbBajaProducto = new System.Windows.Forms.RadioButton();
            this.rbAltaProducto = new System.Windows.Forms.RadioButton();
            this.lblAltaBajaProductos = new System.Windows.Forms.Label();
            this.lblCodigoDeBarra = new System.Windows.Forms.Label();
            this.tbCategoria = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.Label();
            this.tbCodigoDeBarras = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.btnVolverInicio = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlAgregarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(513, 389);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(103, 43);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.BackColor = System.Drawing.Color.Transparent;
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(130, 67);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(61, 23);
            this.lblDatos.TabIndex = 71;
            this.lblDatos.Text = "Datos";
            // 
            // pnlAgregarCliente
            // 
            this.pnlAgregarCliente.BackColor = System.Drawing.Color.Transparent;
            this.pnlAgregarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAgregarCliente.Controls.Add(this.nudCantidadProductos);
            this.pnlAgregarCliente.Controls.Add(this.rbBajaProducto);
            this.pnlAgregarCliente.Controls.Add(this.rbAltaProducto);
            this.pnlAgregarCliente.Controls.Add(this.lblAltaBajaProductos);
            this.pnlAgregarCliente.Controls.Add(this.lblCodigoDeBarra);
            this.pnlAgregarCliente.Controls.Add(this.tbCategoria);
            this.pnlAgregarCliente.Controls.Add(this.tbPrecio);
            this.pnlAgregarCliente.Controls.Add(this.lblPrecio);
            this.pnlAgregarCliente.Controls.Add(this.lblCategoria);
            this.pnlAgregarCliente.Controls.Add(this.lblCantidad);
            this.pnlAgregarCliente.Controls.Add(this.Descripcion);
            this.pnlAgregarCliente.Controls.Add(this.tbCodigoDeBarras);
            this.pnlAgregarCliente.Controls.Add(this.tbDescripcion);
            this.pnlAgregarCliente.Location = new System.Drawing.Point(101, 82);
            this.pnlAgregarCliente.Name = "pnlAgregarCliente";
            this.pnlAgregarCliente.Size = new System.Drawing.Size(515, 301);
            this.pnlAgregarCliente.TabIndex = 70;
            // 
            // nudCantidadProductos
            // 
            this.nudCantidadProductos.Location = new System.Drawing.Point(207, 153);
            this.nudCantidadProductos.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCantidadProductos.Name = "nudCantidadProductos";
            this.nudCantidadProductos.Size = new System.Drawing.Size(120, 22);
            this.nudCantidadProductos.TabIndex = 4;
            // 
            // rbBajaProducto
            // 
            this.rbBajaProducto.AutoSize = true;
            this.rbBajaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBajaProducto.Location = new System.Drawing.Point(323, 258);
            this.rbBajaProducto.Name = "rbBajaProducto";
            this.rbBajaProducto.Size = new System.Drawing.Size(61, 21);
            this.rbBajaProducto.TabIndex = 7;
            this.rbBajaProducto.TabStop = true;
            this.rbBajaProducto.Text = "Baja";
            this.rbBajaProducto.UseVisualStyleBackColor = true;
            // 
            // rbAltaProducto
            // 
            this.rbAltaProducto.AutoSize = true;
            this.rbAltaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAltaProducto.Location = new System.Drawing.Point(207, 258);
            this.rbAltaProducto.Name = "rbAltaProducto";
            this.rbAltaProducto.Size = new System.Drawing.Size(57, 21);
            this.rbAltaProducto.TabIndex = 6;
            this.rbAltaProducto.TabStop = true;
            this.rbAltaProducto.Text = "Alta";
            this.rbAltaProducto.UseVisualStyleBackColor = true;
            // 
            // lblAltaBajaProductos
            // 
            this.lblAltaBajaProductos.AutoSize = true;
            this.lblAltaBajaProductos.BackColor = System.Drawing.Color.Transparent;
            this.lblAltaBajaProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaBajaProductos.Location = new System.Drawing.Point(79, 259);
            this.lblAltaBajaProductos.Name = "lblAltaBajaProductos";
            this.lblAltaBajaProductos.Size = new System.Drawing.Size(84, 18);
            this.lblAltaBajaProductos.TabIndex = 52;
            this.lblAltaBajaProductos.Text = "Alta / Baja";
            // 
            // lblCodigoDeBarra
            // 
            this.lblCodigoDeBarra.AutoSize = true;
            this.lblCodigoDeBarra.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoDeBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDeBarra.Location = new System.Drawing.Point(34, 19);
            this.lblCodigoDeBarra.Name = "lblCodigoDeBarra";
            this.lblCodigoDeBarra.Size = new System.Drawing.Size(129, 18);
            this.lblCodigoDeBarra.TabIndex = 41;
            this.lblCodigoDeBarra.Text = "Codigo de barra";
            // 
            // tbCategoria
            // 
            this.tbCategoria.Location = new System.Drawing.Point(207, 112);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Size = new System.Drawing.Size(247, 22);
            this.tbCategoria.TabIndex = 3;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(207, 207);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(247, 22);
            this.tbPrecio.TabIndex = 5;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(92, 209);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(71, 18);
            this.lblPrecio.TabIndex = 36;
            this.lblPrecio.Text = "Precio $";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(82, 108);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(81, 18);
            this.lblCategoria.TabIndex = 35;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(89, 158);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(74, 18);
            this.lblCantidad.TabIndex = 49;
            this.lblCantidad.Text = "Cantidad";
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.BackColor = System.Drawing.Color.Transparent;
            this.Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.Location = new System.Drawing.Point(65, 66);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(98, 18);
            this.Descripcion.TabIndex = 42;
            this.Descripcion.Text = "Descripcion";
            // 
            // tbCodigoDeBarras
            // 
            this.tbCodigoDeBarras.Location = new System.Drawing.Point(207, 14);
            this.tbCodigoDeBarras.Name = "tbCodigoDeBarras";
            this.tbCodigoDeBarras.Size = new System.Drawing.Size(247, 22);
            this.tbCodigoDeBarras.TabIndex = 1;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(207, 62);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(247, 22);
            this.tbDescripcion.TabIndex = 2;
            // 
            // btnVolverInicio
            // 
            this.btnVolverInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVolverInicio.BackgroundImage = global::proyecto.Properties.Resources.Presentación11;
            this.btnVolverInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolverInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverInicio.Location = new System.Drawing.Point(268, 389);
            this.btnVolverInicio.Name = "btnVolverInicio";
            this.btnVolverInicio.Size = new System.Drawing.Size(103, 43);
            this.btnVolverInicio.TabIndex = 10;
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
            this.btnCargar.Location = new System.Drawing.Point(393, 389);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(103, 43);
            this.btnCargar.TabIndex = 8;
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAgregarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proyecto.Properties.Resources.depositphotos_29231767_stock_illustration_orange_background;
            this.ClientSize = new System.Drawing.Size(717, 499);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.pnlAgregarCliente);
            this.Controls.Add(this.btnVolverInicio);
            this.Controls.Add(this.btnCargar);
            this.Name = "frmAgregarProductos";
            this.Text = "Agregar Productos";
            this.Load += new System.EventHandler(this.frmAgregarProductos_Load);
            this.pnlAgregarCliente.ResumeLayout(false);
            this.pnlAgregarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Panel pnlAgregarCliente;
        private System.Windows.Forms.Label lblCodigoDeBarra;
        private System.Windows.Forms.TextBox tbCategoria;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.TextBox tbCodigoDeBarras;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Button btnVolverInicio;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblAltaBajaProductos;
        private System.Windows.Forms.RadioButton rbBajaProducto;
        private System.Windows.Forms.RadioButton rbAltaProducto;
        private System.Windows.Forms.NumericUpDown nudCantidadProductos;
    }
}