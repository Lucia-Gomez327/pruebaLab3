using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Biblioteca;

namespace proyecto
{
    public partial class frmIncioSesion : Form
    {
        // Variables   


        Models.ProyectoLab3Entities dbContext;      
        Models.Employee oEmpleado;
        Models.Employer oEmpleador;
        Models.Person oPerson;
        static bool cod;
        

        // Contructor
        public frmIncioSesion()
        {
            InitializeComponent();                  
        }

        //LOAD FORMULARIO
        private void Form1_Load(object sender, EventArgs e)
        {
            ucInicio.Visible = false;
            tbNombreUsuario.Focus();           
            tbClave.PasswordChar = '*';
            
            tbClave.Text = "123";
            tbNombreUsuario.Text = "lucia";
            cbTipoUsuario.Text = "Empleador";
            oEmpleado = new Models.Employee();
            oEmpleador = new Models.Employer();


        }

        // Procedimientos - Funciones

        public static void controlCodigo(bool codi)
        {
            cod = codi;            
        }

        private int searchPerson(string userName)
        {
           // oPerson = new Models.Person();
           
            dbContext = new Models.ProyectoLab3Entities();
            try
            {
                BuscarEmpleado(userName);
                 BuscarEmpleador(userName);

                if (oEmpleador != null) // empleador
                {
                    oPerson = dbContext.People.Find(oEmpleador.idPerson);
                    return oPerson.idPerson;
                }
                else if (oEmpleado != null)
                { //empleado

                    oPerson = dbContext.People.Find(oEmpleado.IdPerson);
                    return oPerson.idPerson;
                }
                else {
                    return -1;
                }
            }
            catch (IOException EX)
            {
                return -1;

            }





        }
      
        private int verficarEmpleador(string nomUsuario, string clave)
        {
            dbContext = new Models.ProyectoLab3Entities();
            try {
                
                 BuscarEmpleador(nomUsuario);

                if (oEmpleador != null)
                {
                    if (clave == oEmpleador.password)
                    {
                        return 1; // clave correcta
                    }
                    else
                    {
                        return 0; // clave incorrecta
                    }
                }
                else
                {
                    return -1;
                }
               
            }   
            catch(IOException ex)
            {
                return -1; // nombre incorrecto o no existe
            }
            
        }

      
        private void BuscarEmpleador(string nomUsuario)
        {
            try { 
            dbContext = new Models.ProyectoLab3Entities();
                oEmpleador = null;
                var varEmpleador = from Employer in dbContext.Employers select Employer;
                oEmpleador = varEmpleador.ToList().Find(x => x.userName == nomUsuario);

                
            }
            catch(IOException ex) {  oEmpleador = null; }
        }
        

        private void BuscarEmpleado(string nomUsuario)
        {
            try
            {
                dbContext = new Models.ProyectoLab3Entities();
                oEmpleado = null;                              
                var varEmpleado = from Employees in dbContext.Employees select Employees;              
                oEmpleado = varEmpleado.ToList().Find(x => x.userName == nomUsuario);              
               
            }
            catch (IOException EX) { oEmpleado = null; }

        }
        private int verficarEmpleado(string nomUsuario, string clave)
        {
            dbContext = new Models.ProyectoLab3Entities();
            try {
                
                BuscarEmpleado(nomUsuario);
            if (oEmpleado != null)
            {
                if (clave == oEmpleado.password)
                {
                    return 1; // clave correcta
                }
                else
                {
                    return 0; // clave incorrecta
                }
            }
            else
            {
                return -1; // nombre incorrecto o no existe
            }

            }
            catch(IOException ex) { return -1; }
        }

        private bool controlesVacios()
        {
            if ( tbNombreUsuario.Text == string.Empty || tbClave.Text == string.Empty || cbTipoUsuario.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // BOTON PARA REGISTRARSE
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            frmMensajeCodigo mensajeCodigo = new frmMensajeCodigo();           
            mensajeCodigo.ShowDialog();

            if (cod)
            { ucInicio.Visible = true; }
            
        }
            
        // BOTON REGISTRARSE
        private void btnAceptar_Click(object sender, EventArgs e)
        {                     
            tbNombreUsuario.Focus();


        }
        
        // BOTON INICIAR SESION
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (controlesVacios()) // en el caso de que esten vacias
            {
                MessageBox.Show("Rellene todos los campos", " ", MessageBoxButtons.OK);
            }
            else if (cbTipoUsuario.SelectedIndex == 0) // selecciono empleador en el cbTipoUsuario       
               {
                if (verficarEmpleador(tbNombreUsuario.Text, tbClave.Text) == 1) // clave y usuario correcto
                {
                    this.Hide();
                  
                        frmMenu menu = new frmMenu(searchPerson(tbNombreUsuario.Text));
                        menu.ShowDialog();
                    
                }

                else if  (verficarEmpleador(tbNombreUsuario.Text, tbClave.Text) == 0) // clave incorrecta
                    {
                        MessageBox.Show("Clave de usuario incorrecta", " ", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Nombre de usuario incorrecto", " ", MessageBoxButtons.OK);
                    }
                }

            else if (cbTipoUsuario.SelectedIndex == 1) // selecciono empleado en el cbTipoUsuario       
            {
                if (verficarEmpleado(tbNombreUsuario.Text, tbClave.Text) == 1) // clave y usuario correcto
                {
                    this.Hide();
                    frmMenu menu = new frmMenu(searchPerson(tbNombreUsuario.Text));
                    menu.ShowDialog();
                }

                else if (verficarEmpleado(tbNombreUsuario.Text, tbClave.Text) == 0) // clave incorrecta
                {
                    MessageBox.Show("Clave de usuario incorrecta", " ", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Nombre de usuario incorrecto", " ", MessageBoxButtons.OK);
                }
            }
        }


        
        // BOTON VOLVER ATRAS
        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            //pnlRegistrarse.Visible = false;                    
        }

        private void ucInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
