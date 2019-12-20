namespace proyecto
{
    partial class frmAgregarCliente
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.pnlAgregarCliente = new System.Windows.Forms.Panel();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cboTipoDni = new System.Windows.Forms.ComboBox();
            this.lblTipoDni = new System.Windows.Forms.Label();
            this.tbNumeroDocumento = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.rbBajaCliente = new System.Windows.Forms.RadioButton();
            this.rbAltaCliente = new System.Windows.Forms.RadioButton();
            this.lblAltaBajaCliente = new System.Windows.Forms.Label();
            this.lblNombreC = new System.Windows.Forms.Label();
            this.tbEmailCliente = new System.Windows.Forms.TextBox();
            this.tbTelefonoCliente = new System.Windows.Forms.TextBox();
            this.lblNumeroTelefonoCliente = new System.Windows.Forms.Label();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.lblDireccionCliente = new System.Windows.Forms.Label();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.tbDireccionCliente = new System.Windows.Forms.TextBox();
            this.tbNombreCliente = new System.Windows.Forms.TextBox();
            this.tbApellidoCliente = new System.Windows.Forms.TextBox();
            this.btnVolverInicio = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.pnlAgregarCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModificar.BackgroundImage = global::proyecto.Properties.Resources.Diapositiva2;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(455, 433);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(103, 43);
            this.btnModificar.TabIndex = 67;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.BackColor = System.Drawing.Color.Transparent;
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(78, 26);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(61, 23);
            this.lblDatos.TabIndex = 66;
            this.lblDatos.Text = "Datos";
            // 
            // pnlAgregarCliente
            // 
            this.pnlAgregarCliente.BackColor = System.Drawing.Color.Transparent;
            this.pnlAgregarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAgregarCliente.Controls.Add(this.cbSexo);
            this.pnlAgregarCliente.Controls.Add(this.lblSexo);
            this.pnlAgregarCliente.Controls.Add(this.cboTipoDni);
            this.pnlAgregarCliente.Controls.Add(this.lblTipoDni);
            this.pnlAgregarCliente.Controls.Add(this.tbNumeroDocumento);
            this.pnlAgregarCliente.Controls.Add(this.lblDni);
            this.pnlAgregarCliente.Controls.Add(this.rbBajaCliente);
            this.pnlAgregarCliente.Controls.Add(this.rbAltaCliente);
            this.pnlAgregarCliente.Controls.Add(this.lblAltaBajaCliente);
            this.pnlAgregarCliente.Controls.Add(this.lblNombreC);
            this.pnlAgregarCliente.Controls.Add(this.tbEmailCliente);
            this.pnlAgregarCliente.Controls.Add(this.tbTelefonoCliente);
            this.pnlAgregarCliente.Controls.Add(this.lblNumeroTelefonoCliente);
            this.pnlAgregarCliente.Controls.Add(this.lblEmailCliente);
            this.pnlAgregarCliente.Controls.Add(this.lblDireccionCliente);
            this.pnlAgregarCliente.Controls.Add(this.lblApellidoCliente);
            this.pnlAgregarCliente.Controls.Add(this.tbDireccionCliente);
            this.pnlAgregarCliente.Controls.Add(this.tbNombreCliente);
            this.pnlAgregarCliente.Controls.Add(this.tbApellidoCliente);
            this.pnlAgregarCliente.Location = new System.Drawing.Point(49, 41);
            this.pnlAgregarCliente.Name = "pnlAgregarCliente";
            this.pnlAgregarCliente.Size = new System.Drawing.Size(562, 371);
            this.pnlAgregarCliente.TabIndex = 65;
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cbSexo.Location = new System.Drawing.Point(219, 149);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(273, 24);
            this.cbSexo.TabIndex = 62;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.BackColor = System.Drawing.Color.Transparent;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(106, 150);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(46, 18);
            this.lblSexo.TabIndex = 63;
            this.lblSexo.Text = "Sexo";
            // 
            // cboTipoDni
            // 
            this.cboTipoDni.AutoCompleteCustomSource.AddRange(new string[] {
            "Documento Nacional Identidad",
            "Libreta de Enrolamiento",
            "Libreta Civica"});
            this.cboTipoDni.FormattingEnabled = true;
            this.cboTipoDni.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.cboTipoDni.Items.AddRange(new object[] {
            "Documento Nacional Identidad",
            "Libreta de Enrolamiento",
            "Libreta Civica"});
            this.cboTipoDni.Location = new System.Drawing.Point(58, 102);
            this.cboTipoDni.Name = "cboTipoDni";
            this.cboTipoDni.Size = new System.Drawing.Size(215, 24);
            this.cboTipoDni.TabIndex = 58;
            // 
            // lblTipoDni
            // 
            this.lblTipoDni.AutoSize = true;
            this.lblTipoDni.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDni.Location = new System.Drawing.Point(11, 105);
            this.lblTipoDni.Name = "lblTipoDni";
            this.lblTipoDni.Size = new System.Drawing.Size(41, 18);
            this.lblTipoDni.TabIndex = 61;
            this.lblTipoDni.Text = "Tipo";
            // 
            // tbNumeroDocumento
            // 
            this.tbNumeroDocumento.Location = new System.Drawing.Point(353, 105);
            this.tbNumeroDocumento.MaxLength = 8;
            this.tbNumeroDocumento.Name = "tbNumeroDocumento";
            this.tbNumeroDocumento.Size = new System.Drawing.Size(139, 22);
            this.tbNumeroDocumento.TabIndex = 59;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.Transparent;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(279, 106);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(68, 18);
            this.lblDni.TabIndex = 60;
            this.lblDni.Text = "Numero";
            // 
            // rbBajaCliente
            // 
            this.rbBajaCliente.AutoSize = true;
            this.rbBajaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBajaCliente.Location = new System.Drawing.Point(373, 317);
            this.rbBajaCliente.Name = "rbBajaCliente";
            this.rbBajaCliente.Size = new System.Drawing.Size(61, 21);
            this.rbBajaCliente.TabIndex = 57;
            this.rbBajaCliente.TabStop = true;
            this.rbBajaCliente.Text = "Baja";
            this.rbBajaCliente.UseVisualStyleBackColor = true;
            // 
            // rbAltaCliente
            // 
            this.rbAltaCliente.AutoSize = true;
            this.rbAltaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAltaCliente.Location = new System.Drawing.Point(257, 317);
            this.rbAltaCliente.Name = "rbAltaCliente";
            this.rbAltaCliente.Size = new System.Drawing.Size(57, 21);
            this.rbAltaCliente.TabIndex = 56;
            this.rbAltaCliente.TabStop = true;
            this.rbAltaCliente.Text = "Alta";
            this.rbAltaCliente.UseVisualStyleBackColor = true;
            // 
            // lblAltaBajaCliente
            // 
            this.lblAltaBajaCliente.AutoSize = true;
            this.lblAltaBajaCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblAltaBajaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaBajaCliente.Location = new System.Drawing.Point(68, 318);
            this.lblAltaBajaCliente.Name = "lblAltaBajaCliente";
            this.lblAltaBajaCliente.Size = new System.Drawing.Size(84, 18);
            this.lblAltaBajaCliente.TabIndex = 55;
            this.lblAltaBajaCliente.Text = "Alta / Baja";
            // 
            // lblNombreC
            // 
            this.lblNombreC.AutoSize = true;
            this.lblNombreC.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreC.Location = new System.Drawing.Point(55, 18);
            this.lblNombreC.Name = "lblNombreC";
            this.lblNombreC.Size = new System.Drawing.Size(97, 18);
            this.lblNombreC.TabIndex = 41;
            this.lblNombreC.Text = "Nombre / s ";
            // 
            // tbEmailCliente
            // 
            this.tbEmailCliente.Location = new System.Drawing.Point(219, 192);
            this.tbEmailCliente.Name = "tbEmailCliente";
            this.tbEmailCliente.Size = new System.Drawing.Size(275, 22);
            this.tbEmailCliente.TabIndex = 37;
            // 
            // tbTelefonoCliente
            // 
            this.tbTelefonoCliente.Location = new System.Drawing.Point(219, 276);
            this.tbTelefonoCliente.Name = "tbTelefonoCliente";
            this.tbTelefonoCliente.Size = new System.Drawing.Size(275, 22);
            this.tbTelefonoCliente.TabIndex = 38;
            // 
            // lblNumeroTelefonoCliente
            // 
            this.lblNumeroTelefonoCliente.AutoSize = true;
            this.lblNumeroTelefonoCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroTelefonoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTelefonoCliente.Location = new System.Drawing.Point(26, 276);
            this.lblNumeroTelefonoCliente.Name = "lblNumeroTelefonoCliente";
            this.lblNumeroTelefonoCliente.Size = new System.Drawing.Size(126, 18);
            this.lblNumeroTelefonoCliente.TabIndex = 36;
            this.lblNumeroTelefonoCliente.Text = "Numero de Cel.";
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCliente.Location = new System.Drawing.Point(102, 192);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(50, 18);
            this.lblEmailCliente.TabIndex = 35;
            this.lblEmailCliente.Text = "Email";
            // 
            // lblDireccionCliente
            // 
            this.lblDireccionCliente.AutoSize = true;
            this.lblDireccionCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionCliente.Location = new System.Drawing.Point(72, 234);
            this.lblDireccionCliente.Name = "lblDireccionCliente";
            this.lblDireccionCliente.Size = new System.Drawing.Size(80, 18);
            this.lblDireccionCliente.TabIndex = 49;
            this.lblDireccionCliente.Text = "Direccion";
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoCliente.Location = new System.Drawing.Point(56, 60);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(96, 18);
            this.lblApellidoCliente.TabIndex = 42;
            this.lblApellidoCliente.Text = "Apellido / s ";
            // 
            // tbDireccionCliente
            // 
            this.tbDireccionCliente.Location = new System.Drawing.Point(219, 234);
            this.tbDireccionCliente.Name = "tbDireccionCliente";
            this.tbDireccionCliente.Size = new System.Drawing.Size(275, 22);
            this.tbDireccionCliente.TabIndex = 50;
            // 
            // tbNombreCliente
            // 
            this.tbNombreCliente.Location = new System.Drawing.Point(219, 18);
            this.tbNombreCliente.Name = "tbNombreCliente";
            this.tbNombreCliente.Size = new System.Drawing.Size(275, 22);
            this.tbNombreCliente.TabIndex = 43;
            // 
            // tbApellidoCliente
            // 
            this.tbApellidoCliente.Location = new System.Drawing.Point(219, 60);
            this.tbApellidoCliente.Name = "tbApellidoCliente";
            this.tbApellidoCliente.Size = new System.Drawing.Size(275, 22);
            this.tbApellidoCliente.TabIndex = 44;
            // 
            // btnVolverInicio
            // 
            this.btnVolverInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVolverInicio.BackgroundImage = global::proyecto.Properties.Resources.Presentación11;
            this.btnVolverInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolverInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverInicio.Location = new System.Drawing.Point(211, 433);
            this.btnVolverInicio.Name = "btnVolverInicio";
            this.btnVolverInicio.Size = new System.Drawing.Size(103, 43);
            this.btnVolverInicio.TabIndex = 64;
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
            this.btnCargar.Location = new System.Drawing.Point(333, 433);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(103, 43);
            this.btnCargar.TabIndex = 63;
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // frmAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proyecto.Properties.Resources.depositphotos_29231767_stock_illustration_orange_background;
            this.ClientSize = new System.Drawing.Size(663, 517);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.pnlAgregarCliente);
            this.Controls.Add(this.btnVolverInicio);
            this.Controls.Add(this.btnCargar);
            this.Name = "frmAgregarCliente";
            this.Text = "Agregar Cliente";
            this.Load += new System.EventHandler(this.frmAgregarCliente_Load);
            this.pnlAgregarCliente.ResumeLayout(false);
            this.pnlAgregarCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Panel pnlAgregarCliente;
        private System.Windows.Forms.Label lblNombreC;
        private System.Windows.Forms.TextBox tbEmailCliente;
        private System.Windows.Forms.TextBox tbTelefonoCliente;
        private System.Windows.Forms.Label lblNumeroTelefonoCliente;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.Label lblDireccionCliente;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.TextBox tbDireccionCliente;
        private System.Windows.Forms.TextBox tbNombreCliente;
        private System.Windows.Forms.TextBox tbApellidoCliente;
        private System.Windows.Forms.Button btnVolverInicio;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.RadioButton rbBajaCliente;
        private System.Windows.Forms.RadioButton rbAltaCliente;
        private System.Windows.Forms.Label lblAltaBajaCliente;
        private System.Windows.Forms.ComboBox cboTipoDni;
        private System.Windows.Forms.Label lblTipoDni;
        private System.Windows.Forms.TextBox tbNumeroDocumento;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label lblSexo;
    }
}