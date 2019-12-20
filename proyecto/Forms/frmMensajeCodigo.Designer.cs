namespace proyecto
{
    partial class frmMensajeCodigo
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
            this.pnlMensajeCodigo = new System.Windows.Forms.Panel();
            this.tbCodigoPrograma = new System.Windows.Forms.TextBox();
            this.lblCodigoPrograma = new System.Windows.Forms.Label();
            this.pbMensajeCodigo = new System.Windows.Forms.PictureBox();
            this.pnlMensajeCodigo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensajeCodigo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMensajeCodigo
            // 
            this.pnlMensajeCodigo.Controls.Add(this.tbCodigoPrograma);
            this.pnlMensajeCodigo.Controls.Add(this.lblCodigoPrograma);
            this.pnlMensajeCodigo.Controls.Add(this.pbMensajeCodigo);
            this.pnlMensajeCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMensajeCodigo.Location = new System.Drawing.Point(0, 0);
            this.pnlMensajeCodigo.Name = "pnlMensajeCodigo";
            this.pnlMensajeCodigo.Size = new System.Drawing.Size(485, 152);
            this.pnlMensajeCodigo.TabIndex = 0;
            // 
            // tbCodigoPrograma
            // 
            this.tbCodigoPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoPrograma.Location = new System.Drawing.Point(155, 68);
            this.tbCodigoPrograma.Name = "tbCodigoPrograma";
            this.tbCodigoPrograma.Size = new System.Drawing.Size(166, 24);
            this.tbCodigoPrograma.TabIndex = 22;
            this.tbCodigoPrograma.Enter += new System.EventHandler(this.tbCodigoPrograma_Enter);
            this.tbCodigoPrograma.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCodigoPrograma_KeyDown);
            // 
            // lblCodigoPrograma
            // 
            this.lblCodigoPrograma.AutoSize = true;
            this.lblCodigoPrograma.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPrograma.Location = new System.Drawing.Point(127, 22);
            this.lblCodigoPrograma.Name = "lblCodigoPrograma";
            this.lblCodigoPrograma.Size = new System.Drawing.Size(221, 18);
            this.lblCodigoPrograma.TabIndex = 21;
            this.lblCodigoPrograma.Text = "Ingrese codigo de Programa";
            // 
            // pbMensajeCodigo
            // 
            this.pbMensajeCodigo.BackColor = System.Drawing.Color.Transparent;
            this.pbMensajeCodigo.BackgroundImage = global::proyecto.Properties.Resources.capture_20181216_230242;
            this.pbMensajeCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMensajeCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMensajeCodigo.Location = new System.Drawing.Point(0, 0);
            this.pbMensajeCodigo.Name = "pbMensajeCodigo";
            this.pbMensajeCodigo.Size = new System.Drawing.Size(485, 152);
            this.pbMensajeCodigo.TabIndex = 0;
            this.pbMensajeCodigo.TabStop = false;
            // 
            // frmMensajeCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 152);
            this.Controls.Add(this.pnlMensajeCodigo);
            this.MaximizeBox = false;
            this.Name = "frmMensajeCodigo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensaje Codigo";
            this.Load += new System.EventHandler(this.frmMensajeCodigo_Load);
            this.pnlMensajeCodigo.ResumeLayout(false);
            this.pnlMensajeCodigo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensajeCodigo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMensajeCodigo;
        private System.Windows.Forms.PictureBox pbMensajeCodigo;
        private System.Windows.Forms.Label lblCodigoPrograma;
        private System.Windows.Forms.TextBox tbCodigoPrograma;
    }
}