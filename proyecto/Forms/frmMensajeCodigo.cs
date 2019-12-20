using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;
namespace proyecto
{
    public partial class frmMensajeCodigo : Form
    {
        public frmMensajeCodigo()
        {
            InitializeComponent();
            tbCodigoPrograma.PasswordChar = '*';
            tbCodigoPrograma.Text = "12345";
            frmIncioSesion.controlCodigo(false);
        }

        private void frmMensajeCodigo_Load(object sender, EventArgs e)
        {
                   
        lblCodigoPrograma.Parent = pbMensajeCodigo;
        lblCodigoPrograma.BackColor = Color.Transparent;

        }

        

        private void tbCodigoPrograma_KeyDown(object sender, KeyEventArgs e)
        {
            Models.ProyectoLab3Entities dbContext = new Models.ProyectoLab3Entities();
           string oCode = dbContext.Codes.Find(0).key.Trim();       

            if (e.KeyCode == Keys.Enter)
            {
                
                bool cod ;
               
                if (tbCodigoPrograma.Text != string.Empty)
                {
                    
                    if (tbCodigoPrograma.Text == oCode)
                    {
                        cod = true;
                        frmIncioSesion.controlCodigo(cod);
                        this.Close();
                    }
                    else
                    {
                        cod = false;
                        frmIncioSesion.controlCodigo(cod);
                        MessageBox.Show("Clave de producto incorrecta", "  ", MessageBoxButtons.OK);
                    }

                    
                }
            }
        }

        private void tbCodigoPrograma_Enter(object sender, EventArgs e)
        {

        }
    }
    }

