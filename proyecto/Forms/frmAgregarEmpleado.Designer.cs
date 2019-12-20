namespace proyecto
{
    partial class frmAgregarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarEmpleado));
            this.ucEmpleado1 = new proyecto.User_Controls.ucEmpleado();
            this.btnVolverInicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucEmpleado1
            // 
            this.ucEmpleado1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucEmpleado1.BackgroundImage")));
            this.ucEmpleado1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucEmpleado1.Location = new System.Drawing.Point(0, 0);
            this.ucEmpleado1.Name = "ucEmpleado1";
            this.ucEmpleado1.Size = new System.Drawing.Size(1042, 544);
            this.ucEmpleado1.TabIndex = 0;
            
            // 
            // btnVolverInicio
            // 
            this.btnVolverInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVolverInicio.BackgroundImage = global::proyecto.Properties.Resources.Presentación11;
            this.btnVolverInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolverInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverInicio.Location = new System.Drawing.Point(794, 480);
            this.btnVolverInicio.Name = "btnVolverInicio";
            this.btnVolverInicio.Size = new System.Drawing.Size(103, 43);
            this.btnVolverInicio.TabIndex = 65;
            this.btnVolverInicio.UseVisualStyleBackColor = false;
            this.btnVolverInicio.Click += new System.EventHandler(this.btnVolverInicio_Click);
            // 
            // frmAgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proyecto.Properties.Resources.depositphotos_29231767_stock_illustration_orange_background;
            this.ClientSize = new System.Drawing.Size(1042, 544);
            this.Controls.Add(this.btnVolverInicio);
            this.Controls.Add(this.ucEmpleado1);
            this.Name = "frmAgregarEmpleado";
            this.Text = "Agregar Empleado";
            this.Load += new System.EventHandler(this.frmAgregarEmpleado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private User_Controls.ucEmpleado ucEmpleado1;
        private System.Windows.Forms.Button btnVolverInicio;
    }
}