namespace proyecto.User_Controls
{
    partial class ucEmpleado
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucEmpleado));
            this.lblDatos = new System.Windows.Forms.Label();
            this.pnlAgregarEmpleado = new System.Windows.Forms.Panel();
            this.cboTipoDni = new System.Windows.Forms.ComboBox();
            this.lblTipoDni = new System.Windows.Forms.Label();
            this.tbNumeroDocumento = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblConfirmarClave = new System.Windows.Forms.Label();
            this.tbConfirmarClave = new System.Windows.Forms.TextBox();
            this.rbBajaEmpleado = new System.Windows.Forms.RadioButton();
            this.rbAltaEmpleado = new System.Windows.Forms.RadioButton();
            this.lblAltaBajaEmpleado = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.tbClaveNuevo = new System.Windows.Forms.TextBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblClaveNuevo = new System.Windows.Forms.Label();
            this.lblFechaPago = new System.Windows.Forms.Label();
            this.lblNombreUsuarioNuevo = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbSueldo = new System.Windows.Forms.TextBox();
            this.lblNumeroTelefono = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnVolverInicio = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.pnlAgregarEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDatos
            // 
            this.lblDatos.BackColor = System.Drawing.Color.Transparent;
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(61, 56);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(61, 23);
            this.lblDatos.TabIndex = 66;
            this.lblDatos.Text = "Datos";
            // 
            // pnlAgregarEmpleado
            // 
            this.pnlAgregarEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.pnlAgregarEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAgregarEmpleado.Controls.Add(this.cboTipoDni);
            this.pnlAgregarEmpleado.Controls.Add(this.lblTipoDni);
            this.pnlAgregarEmpleado.Controls.Add(this.tbNumeroDocumento);
            this.pnlAgregarEmpleado.Controls.Add(this.lblDni);
            this.pnlAgregarEmpleado.Controls.Add(this.lblConfirmarClave);
            this.pnlAgregarEmpleado.Controls.Add(this.tbConfirmarClave);
            this.pnlAgregarEmpleado.Controls.Add(this.rbBajaEmpleado);
            this.pnlAgregarEmpleado.Controls.Add(this.rbAltaEmpleado);
            this.pnlAgregarEmpleado.Controls.Add(this.lblAltaBajaEmpleado);
            this.pnlAgregarEmpleado.Controls.Add(this.lblNombre);
            this.pnlAgregarEmpleado.Controls.Add(this.dtpFechaPago);
            this.pnlAgregarEmpleado.Controls.Add(this.tbClaveNuevo);
            this.pnlAgregarEmpleado.Controls.Add(this.dtpFechaIngreso);
            this.pnlAgregarEmpleado.Controls.Add(this.lblClaveNuevo);
            this.pnlAgregarEmpleado.Controls.Add(this.lblFechaPago);
            this.pnlAgregarEmpleado.Controls.Add(this.lblNombreUsuarioNuevo);
            this.pnlAgregarEmpleado.Controls.Add(this.lblFechaIngreso);
            this.pnlAgregarEmpleado.Controls.Add(this.tbEmail);
            this.pnlAgregarEmpleado.Controls.Add(this.lblSueldo);
            this.pnlAgregarEmpleado.Controls.Add(this.tbTelefono);
            this.pnlAgregarEmpleado.Controls.Add(this.tbSueldo);
            this.pnlAgregarEmpleado.Controls.Add(this.lblNumeroTelefono);
            this.pnlAgregarEmpleado.Controls.Add(this.tbUserName);
            this.pnlAgregarEmpleado.Controls.Add(this.lblCorreo);
            this.pnlAgregarEmpleado.Controls.Add(this.lblDireccion);
            this.pnlAgregarEmpleado.Controls.Add(this.lblApellido);
            this.pnlAgregarEmpleado.Controls.Add(this.tbDireccion);
            this.pnlAgregarEmpleado.Controls.Add(this.tbNombre);
            this.pnlAgregarEmpleado.Controls.Add(this.cboSexo);
            this.pnlAgregarEmpleado.Controls.Add(this.tbApellido);
            this.pnlAgregarEmpleado.Controls.Add(this.lblSexo);
            this.pnlAgregarEmpleado.Location = new System.Drawing.Point(32, 71);
            this.pnlAgregarEmpleado.Name = "pnlAgregarEmpleado";
            this.pnlAgregarEmpleado.Size = new System.Drawing.Size(987, 385);
            this.pnlAgregarEmpleado.TabIndex = 65;
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
            this.cboTipoDni.Location = new System.Drawing.Point(58, 161);
            this.cboTipoDni.Name = "cboTipoDni";
            this.cboTipoDni.Size = new System.Drawing.Size(182, 24);
            this.cboTipoDni.TabIndex = 4;
            // 
            // lblTipoDni
            // 
            this.lblTipoDni.AutoSize = true;
            this.lblTipoDni.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDni.Location = new System.Drawing.Point(-1, 167);
            this.lblTipoDni.Name = "lblTipoDni";
            this.lblTipoDni.Size = new System.Drawing.Size(41, 18);
            this.lblTipoDni.TabIndex = 68;
            this.lblTipoDni.Text = "Tipo";
            // 
            // tbNumeroDocumento
            // 
            this.tbNumeroDocumento.Location = new System.Drawing.Point(335, 161);
            this.tbNumeroDocumento.MaxLength = 8;
            this.tbNumeroDocumento.Name = "tbNumeroDocumento";
            this.tbNumeroDocumento.Size = new System.Drawing.Size(142, 22);
            this.tbNumeroDocumento.TabIndex = 5;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.Transparent;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(246, 167);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(68, 18);
            this.lblDni.TabIndex = 67;
            this.lblDni.Text = "Numero";
            // 
            // lblConfirmarClave
            // 
            this.lblConfirmarClave.AutoSize = true;
            this.lblConfirmarClave.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmarClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarClave.Location = new System.Drawing.Point(13, 312);
            this.lblConfirmarClave.Name = "lblConfirmarClave";
            this.lblConfirmarClave.Size = new System.Drawing.Size(127, 18);
            this.lblConfirmarClave.TabIndex = 64;
            this.lblConfirmarClave.Text = "Confirmar clave";
            // 
            // tbConfirmarClave
            // 
            this.tbConfirmarClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirmarClave.Location = new System.Drawing.Point(183, 312);
            this.tbConfirmarClave.MaxLength = 50;
            this.tbConfirmarClave.Name = "tbConfirmarClave";
            this.tbConfirmarClave.Size = new System.Drawing.Size(294, 24);
            this.tbConfirmarClave.TabIndex = 8;
            // 
            // rbBajaEmpleado
            // 
            this.rbBajaEmpleado.AutoSize = true;
            this.rbBajaEmpleado.Location = new System.Drawing.Point(807, 342);
            this.rbBajaEmpleado.Name = "rbBajaEmpleado";
            this.rbBajaEmpleado.Size = new System.Drawing.Size(57, 21);
            this.rbBajaEmpleado.TabIndex = 62;
            this.rbBajaEmpleado.TabStop = true;
            this.rbBajaEmpleado.Text = "Baja";
            this.rbBajaEmpleado.UseVisualStyleBackColor = true;
            // 
            // rbAltaEmpleado
            // 
            this.rbAltaEmpleado.AutoSize = true;
            this.rbAltaEmpleado.Location = new System.Drawing.Point(691, 341);
            this.rbAltaEmpleado.Name = "rbAltaEmpleado";
            this.rbAltaEmpleado.Size = new System.Drawing.Size(53, 21);
            this.rbAltaEmpleado.TabIndex = 61;
            this.rbAltaEmpleado.TabStop = true;
            this.rbAltaEmpleado.Text = "Alta";
            this.rbAltaEmpleado.UseVisualStyleBackColor = true;
            // 
            // lblAltaBajaEmpleado
            // 
            this.lblAltaBajaEmpleado.AutoSize = true;
            this.lblAltaBajaEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblAltaBajaEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaBajaEmpleado.Location = new System.Drawing.Point(534, 341);
            this.lblAltaBajaEmpleado.Name = "lblAltaBajaEmpleado";
            this.lblAltaBajaEmpleado.Size = new System.Drawing.Size(84, 18);
            this.lblAltaBajaEmpleado.TabIndex = 60;
            this.lblAltaBajaEmpleado.Text = "Alta / Baja";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(55, 18);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(97, 18);
            this.lblNombre.TabIndex = 41;
            this.lblNombre.Text = "Nombre / s ";
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Location = new System.Drawing.Point(671, 226);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(294, 22);
            this.dtpFechaPago.TabIndex = 13;
            // 
            // tbClaveNuevo
            // 
            this.tbClaveNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClaveNuevo.Location = new System.Drawing.Point(183, 261);
            this.tbClaveNuevo.MaxLength = 50;
            this.tbClaveNuevo.Name = "tbClaveNuevo";
            this.tbClaveNuevo.Size = new System.Drawing.Size(294, 24);
            this.tbClaveNuevo.TabIndex = 7;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(671, 174);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(294, 22);
            this.dtpFechaIngreso.TabIndex = 12;
            // 
            // lblClaveNuevo
            // 
            this.lblClaveNuevo.AutoSize = true;
            this.lblClaveNuevo.BackColor = System.Drawing.Color.Transparent;
            this.lblClaveNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveNuevo.Location = new System.Drawing.Point(13, 264);
            this.lblClaveNuevo.Name = "lblClaveNuevo";
            this.lblClaveNuevo.Size = new System.Drawing.Size(139, 18);
            this.lblClaveNuevo.TabIndex = 31;
            this.lblClaveNuevo.Text = "Clave de Acceso ";
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPago.Location = new System.Drawing.Point(510, 235);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(119, 18);
            this.lblFechaPago.TabIndex = 56;
            this.lblFechaPago.Text = "Fecha de pago";
            // 
            // lblNombreUsuarioNuevo
            // 
            this.lblNombreUsuarioNuevo.AutoSize = true;
            this.lblNombreUsuarioNuevo.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreUsuarioNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuarioNuevo.Location = new System.Drawing.Point(15, 214);
            this.lblNombreUsuarioNuevo.Name = "lblNombreUsuarioNuevo";
            this.lblNombreUsuarioNuevo.Size = new System.Drawing.Size(137, 18);
            this.lblNombreUsuarioNuevo.TabIndex = 30;
            this.lblNombreUsuarioNuevo.Text = "Nombre Usuario ";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIngreso.Location = new System.Drawing.Point(510, 182);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(115, 18);
            this.lblFechaIngreso.TabIndex = 52;
            this.lblFechaIngreso.Text = "Fecha Ingreso";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(671, 18);
            this.tbEmail.MaxLength = 50;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(294, 22);
            this.tbEmail.TabIndex = 9;
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.BackColor = System.Drawing.Color.Transparent;
            this.lblSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldo.Location = new System.Drawing.Point(560, 288);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(65, 18);
            this.lblSueldo.TabIndex = 53;
            this.lblSueldo.Text = "Sueldo ";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(671, 122);
            this.tbTelefono.MaxLength = 10;
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(294, 22);
            this.tbTelefono.TabIndex = 11;
            // 
            // tbSueldo
            // 
            this.tbSueldo.Location = new System.Drawing.Point(671, 278);
            this.tbSueldo.MaxLength = 18;
            this.tbSueldo.Name = "tbSueldo";
            this.tbSueldo.Size = new System.Drawing.Size(294, 22);
            this.tbSueldo.TabIndex = 14;
            // 
            // lblNumeroTelefono
            // 
            this.lblNumeroTelefono.AutoSize = true;
            this.lblNumeroTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTelefono.Location = new System.Drawing.Point(497, 129);
            this.lblNumeroTelefono.Name = "lblNumeroTelefono";
            this.lblNumeroTelefono.Size = new System.Drawing.Size(126, 18);
            this.lblNumeroTelefono.TabIndex = 36;
            this.lblNumeroTelefono.Text = "Numero de Cel.";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(183, 211);
            this.tbUserName.MaxLength = 50;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(294, 22);
            this.tbUserName.TabIndex = 6;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(559, 23);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(66, 18);
            this.lblCorreo.TabIndex = 35;
            this.lblCorreo.Text = "Correo ";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(543, 76);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(80, 18);
            this.lblDireccion.TabIndex = 49;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(56, 68);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(96, 18);
            this.lblApellido.TabIndex = 42;
            this.lblApellido.Text = "Apellido / s ";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(671, 70);
            this.tbDireccion.MaxLength = 50;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(294, 22);
            this.tbDireccion.TabIndex = 10;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(183, 13);
            this.tbNombre.MaxLength = 30;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(294, 22);
            this.tbNombre.TabIndex = 1;
            // 
            // cboSexo
            // 
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cboSexo.Location = new System.Drawing.Point(183, 113);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(294, 24);
            this.cboSexo.TabIndex = 3;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(183, 63);
            this.tbApellido.MaxLength = 30;
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(294, 22);
            this.tbApellido.TabIndex = 2;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.BackColor = System.Drawing.Color.Transparent;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(101, 118);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(51, 18);
            this.lblSexo.TabIndex = 47;
            this.lblSexo.Text = "Sexo ";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(916, 478);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(103, 43);
            this.btnModificar.TabIndex = 67;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnVolverInicio
            // 
            this.btnVolverInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVolverInicio.BackgroundImage = global::proyecto.Properties.Resources.Presentación11;
            this.btnVolverInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolverInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverInicio.Location = new System.Drawing.Point(794, 478);
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
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(916, 478);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(103, 43);
            this.btnCargar.TabIndex = 63;
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // ucEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proyecto.Properties.Resources.depositphotos_29231767_stock_illustration_orange_background;
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.pnlAgregarEmpleado);
            this.Controls.Add(this.btnVolverInicio);
            this.Controls.Add(this.btnCargar);
            this.Name = "ucEmpleado";
            this.Size = new System.Drawing.Size(1047, 544);
            this.Load += new System.EventHandler(this.ucEmpleado_Load);
            this.pnlAgregarEmpleado.ResumeLayout(false);
            this.pnlAgregarEmpleado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Panel pnlAgregarEmpleado;
        private System.Windows.Forms.RadioButton rbBajaEmpleado;
        private System.Windows.Forms.RadioButton rbAltaEmpleado;
        private System.Windows.Forms.Label lblAltaBajaEmpleado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.TextBox tbClaveNuevo;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Label lblClaveNuevo;
        private System.Windows.Forms.Label lblFechaPago;
        private System.Windows.Forms.Label lblNombreUsuarioNuevo;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbSueldo;
        private System.Windows.Forms.Label lblNumeroTelefono;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Button btnVolverInicio;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox tbConfirmarClave;
        private System.Windows.Forms.Label lblConfirmarClave;
        private System.Windows.Forms.ComboBox cboTipoDni;
        private System.Windows.Forms.Label lblTipoDni;
        private System.Windows.Forms.TextBox tbNumeroDocumento;
        private System.Windows.Forms.Label lblDni;
    }
}
