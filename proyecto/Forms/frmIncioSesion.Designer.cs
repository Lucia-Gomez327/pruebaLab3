namespace proyecto
{
    partial class frmIncioSesion
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIncioSesion));
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.ucInicio = new proyecto.UserControl1();
            this.pnlIniciarSesion = new System.Windows.Forms.Panel();
            this.pnlInicio1 = new System.Windows.Forms.Panel();
            this.cbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.tbNombreUsuario = new System.Windows.Forms.TextBox();
            this.tbClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.pbFondo = new System.Windows.Forms.PictureBox();
            this.pnlVisualizar = new System.Windows.Forms.Panel();
            this.pnlFondo.SuspendLayout();
            this.pnlIniciarSesion.SuspendLayout();
            this.pnlInicio1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFondo
            // 
            this.pnlFondo.Controls.Add(this.ucInicio);
            this.pnlFondo.Controls.Add(this.pnlIniciarSesion);
            this.pnlFondo.Controls.Add(this.pbFondo);
            this.pnlFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFondo.Location = new System.Drawing.Point(0, 0);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(539, 500);
            this.pnlFondo.TabIndex = 1;
            // 
            // ucInicio
            // 
            this.ucInicio.BackColor = System.Drawing.Color.Transparent;
            this.ucInicio.Location = new System.Drawing.Point(12, 12);
            this.ucInicio.Name = "ucInicio";
            this.ucInicio.Size = new System.Drawing.Size(506, 457);
            this.ucInicio.TabIndex = 9;
            this.ucInicio.Tag = "Inicio";
            this.ucInicio.Load += new System.EventHandler(this.ucInicio_Load);
            // 
            // pnlIniciarSesion
            // 
            this.pnlIniciarSesion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlIniciarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlIniciarSesion.BackgroundImage")));
            this.pnlIniciarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlIniciarSesion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlIniciarSesion.Controls.Add(this.pnlInicio1);
            this.pnlIniciarSesion.Controls.Add(this.btnRegistrarse);
            this.pnlIniciarSesion.Controls.Add(this.btnIniciarSesion);
            this.pnlIniciarSesion.Location = new System.Drawing.Point(40, 45);
            this.pnlIniciarSesion.Name = "pnlIniciarSesion";
            this.pnlIniciarSesion.Size = new System.Drawing.Size(449, 265);
            this.pnlIniciarSesion.TabIndex = 7;
            // 
            // pnlInicio1
            // 
            this.pnlInicio1.BackColor = System.Drawing.Color.Transparent;
            this.pnlInicio1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlInicio1.BackgroundImage")));
            this.pnlInicio1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlInicio1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInicio1.Controls.Add(this.pnlVisualizar);
            this.pnlInicio1.Controls.Add(this.cbTipoUsuario);
            this.pnlInicio1.Controls.Add(this.lblTipo);
            this.pnlInicio1.Controls.Add(this.lblNombreUsuario);
            this.pnlInicio1.Controls.Add(this.tbNombreUsuario);
            this.pnlInicio1.Controls.Add(this.tbClave);
            this.pnlInicio1.Controls.Add(this.lblClave);
            this.pnlInicio1.Location = new System.Drawing.Point(8, 15);
            this.pnlInicio1.Name = "pnlInicio1";
            this.pnlInicio1.Size = new System.Drawing.Size(423, 131);
            this.pnlInicio1.TabIndex = 9;
            // 
            // cbTipoUsuario
            // 
            this.cbTipoUsuario.FormattingEnabled = true;
            this.cbTipoUsuario.Items.AddRange(new object[] {
            "Empleador",
            "Empleado"});
            this.cbTipoUsuario.Location = new System.Drawing.Point(155, 92);
            this.cbTipoUsuario.Name = "cbTipoUsuario";
            this.cbTipoUsuario.Size = new System.Drawing.Size(237, 24);
            this.cbTipoUsuario.TabIndex = 28;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(3, 95);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(105, 18);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Tipo Usuario";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(3, 24);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(132, 18);
            this.lblNombreUsuario.TabIndex = 2;
            this.lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // tbNombreUsuario
            // 
            this.tbNombreUsuario.Location = new System.Drawing.Point(155, 24);
            this.tbNombreUsuario.MaxLength = 50;
            this.tbNombreUsuario.Name = "tbNombreUsuario";
            this.tbNombreUsuario.Size = new System.Drawing.Size(237, 22);
            this.tbNombreUsuario.TabIndex = 4;
            // 
            // tbClave
            // 
            this.tbClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClave.Location = new System.Drawing.Point(155, 57);
            this.tbClave.MaxLength = 50;
            this.tbClave.Name = "tbClave";
            this.tbClave.Size = new System.Drawing.Size(237, 24);
            this.tbClave.TabIndex = 5;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.BackColor = System.Drawing.Color.Transparent;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(3, 60);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(134, 18);
            this.lblClave.TabIndex = 3;
            this.lblClave.Text = "Clave de Acceso";
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarse.BackgroundImage = global::proyecto.Properties.Resources.REGISTRARSE2;
            this.btnRegistrarse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.Location = new System.Drawing.Point(246, 212);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(121, 34);
            this.btnRegistrarse.TabIndex = 8;
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackgroundImage = global::proyecto.Properties.Resources.INICIAR1;
            this.btnIniciarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.Location = new System.Drawing.Point(246, 172);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(121, 34);
            this.btnIniciarSesion.TabIndex = 6;
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // pbFondo
            // 
            this.pbFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFondo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbFondo.ErrorImage")));
            this.pbFondo.Image = ((System.Drawing.Image)(resources.GetObject("pbFondo.Image")));
            this.pbFondo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbFondo.InitialImage")));
            this.pbFondo.Location = new System.Drawing.Point(0, 0);
            this.pbFondo.Name = "pbFondo";
            this.pbFondo.Size = new System.Drawing.Size(539, 500);
            this.pbFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFondo.TabIndex = 0;
            this.pbFondo.TabStop = false;
            // 
            // pnlVisualizar
            // 
            this.pnlVisualizar.BackColor = System.Drawing.Color.Transparent;
            this.pnlVisualizar.BackgroundImage = global::proyecto.Properties.Resources.visualizar;
            this.pnlVisualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlVisualizar.Location = new System.Drawing.Point(395, 53);
            this.pnlVisualizar.Name = "pnlVisualizar";
            this.pnlVisualizar.Size = new System.Drawing.Size(27, 33);
            this.pnlVisualizar.TabIndex = 78;
            this.pnlVisualizar.MouseEnter += new System.EventHandler(this.pnlVisualizar_MouseEnter);
            this.pnlVisualizar.MouseLeave += new System.EventHandler(this.pnlVisualizar_MouseLeave);
            // 
            // frmIncioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 500);
            this.Controls.Add(this.pnlFondo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimizeBox = false;
            this.Name = "frmIncioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Acceso";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlFondo.ResumeLayout(false);
            this.pnlIniciarSesion.ResumeLayout(false);
            this.pnlInicio1.ResumeLayout(false);
            this.pnlInicio1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFondo;
        private System.Windows.Forms.Panel pnlFondo;
        private System.Windows.Forms.Panel pnlIniciarSesion;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox tbClave;
        private System.Windows.Forms.TextBox tbNombreUsuario;
        private System.Windows.Forms.Panel pnlInicio1;
        private System.Windows.Forms.ComboBox cbTipoUsuario;
        private System.Windows.Forms.Label lblTipo;
        private UserControl1 ucInicio;
        private System.Windows.Forms.Panel pnlVisualizar;
    }
}

