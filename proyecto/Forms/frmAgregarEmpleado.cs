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
using System.IO;

namespace proyecto
{
    public partial class frmAgregarEmpleado : Form
    {

        Models.ProyectoLab3Entities dbContext;
        Models.Person oPerson;
        Models.Employee oEmployee;


        // constructor predeterminado
        public frmAgregarEmpleado()
        {
            InitializeComponent();
            ucEmpleado1.agregar();
           
            
        }
        // constructor 1
        public frmAgregarEmpleado(int ind)
        {
            InitializeComponent();
            dbContext = new Models.ProyectoLab3Entities();
            ucEmpleado1.modificarEmpleado(ind);
            
          

        }
      
        // LOAD FORMULARIO
        private void frmAgregarEmpleado_Load(object sender, EventArgs e)
            {
            ucEmpleado1.inicializarForm(this);
            
            }          

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
