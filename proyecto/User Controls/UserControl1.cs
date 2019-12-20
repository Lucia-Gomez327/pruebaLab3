using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace proyecto
{
    public partial class UserControl1 : UserControl
    {
        Models.ProyectoLab3Entities dbContext;
        Models.Employer oEmpleador;
        Models.Person oPerson;
        Models.Employer oEmployer;
        proyecto.Forms.frmModificarEmpleador frmModificarEmpleado;
        frmMenu menu;



        Panel pnlDatos;

        Form formulario;

        public UserControl1()
        {
            InitializeComponent();
            tbClaveNuevo.PasswordChar = '*';
            tbConfirmacionClave.PasswordChar = '*';

        }

        private void pnlRegistrarse_Paint(object sender, PaintEventArgs e)
        {

        }
        public void inicializarForm(Form form)
        {
            formulario = form;


        }


        public void setEmployer(Models.Employer oEmpleador, Models.Person oPerson, Control control)
        {
            this.oEmpleador = oEmpleador;
            this.oPerson = oPerson;

            tbNombre.Text = new CultureInfo("en-US", false).TextInfo.ToTitleCase(oPerson.lastName);
            tbApellido.Text = oPerson.firstName;
            cbSexo.SelectedItem = oPerson.sex.Trim();
            cboTipoDni.SelectedItem = oPerson.type.Trim();
            tbNumeroDocumento.Text = oPerson.documentNumber;
            tbNombreUsuarioNuevo.Text = oEmpleador.userName;
            tbEmail.Text = oPerson.email;
            if (oPerson.dress.Trim() != "")
            {
                tbDireccion.Text = oPerson.dress;
            }
            if (oPerson.telephone.Trim() != "")
            {
                tbTelefono.Text = oPerson.telephone;
            }
            tbClaveNuevo.Text = oEmpleador.password;
            tbConfirmacionClave.Text = oEmpleador.password;
            if (control.Name != "us")
            {
                eliminarElementos(control);
            }
        }


        public void setPanel(Panel pnl)
        {
            pnlDatos = pnl;
        }
        public void setForm(frmMenu menu)
        {
            this.menu = menu;
        }

        public void eliminarElementos(Control control)
        {
            foreach (Control oControls in control.Controls)
            {

                if (oControls is Label)
                {
                    if (((Label)oControls).Text == "*" || ((Label)oControls).Name == "lblCamposObligatorios")
                    {
                        ((Label)oControls).Visible = false;
                    }

                }
                if (oControls is Button)
                {
                    if (((Button)oControls).Name == "btnAceptar")
                    {
                        ((Button)oControls).BackgroundImage = proyecto.Properties.Resources.Diapositiva2;
                        ((Button)oControls).Name = "btnModificar";
                    }
                }
                //if (oControls is TextBox)
                //{
                //    ((TextBox)oControls).ReadOnly = true;
                //}
                if (oControls is ComboBox)
                {
                    if (((ComboBox)oControls).Name == "cboTipoDni")
                    {
                        ((ComboBox)oControls).SelectedItem = oPerson.type;
                        string type = ((ComboBox)oControls).Text;
                        for (int x = ((ComboBox)oControls).Items.Count - 1; x > -1; x--)
                        {
                            ((ComboBox)oControls).Items.RemoveAt(x);
                        }
                        ((ComboBox)oControls).Items.Add(type);
                    }
                    if (((ComboBox)oControls).Name == "cbSexo")
                    {
                        ((ComboBox)oControls).SelectedItem = oPerson.sex;
                        string sex = ((ComboBox)oControls).Text;
                        for (int x = ((ComboBox)oControls).Items.Count - 1; x > -1; x--)
                        {
                            ((ComboBox)oControls).Items.RemoveAt(x);
                        }
                        ((ComboBox)oControls).Items.Add(sex);

                    }

                }
                else
                { eliminarElementos(oControls); }
            }
        }
        public bool textBoxVacio()
        {
            if (tbNombre.Text == string.Empty || tbApellido.Text == string.Empty || tbEmail.Text == string.Empty || tbTelefono.Text == string.Empty || tbDireccion.Text == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public bool searchClient(string documentNumber, string sex, string type)
        {
            oPerson = new Models.Person();
            dbContext = new Models.ProyectoLab3Entities();
            try
            {
                oPerson = null;


                var varPerson = from x in dbContext.People where x.documentNumber == documentNumber && x.sex == sex && x.type == type select x;

                if (varPerson.Count() != 0)
                {
                    oPerson = varPerson.First();
                    return true;
                }
                else { return false; }
            }

            catch (IOException ex) { return false; }


        }



        private int formatoNumeros()
        {
            long numeroTelefono;
            if (long.TryParse(tbTelefono.Text, out numeroTelefono) == false)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        private bool verficacionClaves(string clave, string clave1)
        {
            if (string.Equals(clave, clave1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool controlesVacios()
        {
            if (tbNombre.Text == string.Empty || tbApellido.Text == string.Empty || tbNombreUsuarioNuevo.Text == string.Empty || tbClaveNuevo.Text == string.Empty || tbConfirmacionClave.Text == string.Empty || tbEmail.Text == string.Empty || cbSexo.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool verificarNombreUsuario(string nomUsuario) // usado en el boton aceptar
        {
            Models.Employer emp = new Models.Employer();
            dbContext = new Models.ProyectoLab3Entities();
            try
            {
                var varEmpleador = from Employer in dbContext.Employers select Employer;
                var varEmpleado = from Employees in dbContext.Employees select Employees;

                var resEmpleador = varEmpleador.ToList().Find(x => x.userName == nomUsuario);
                var resEmpleado = varEmpleado.ToList().Find(x => x.userName == nomUsuario);

                if (resEmpleador != null || resEmpleado != null)
                {
                    return true;
                }
                else
                {

                    return false;
                }

            }
            catch (IOException ex)
            {
                return false;
            }



        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            if (btnAceptar.Name == "btnAceptar")
            {
                if (controlesVacios()) // controles vacios
                {
                    MessageBox.Show("Rellene todos los campos", " ", MessageBoxButtons.OK);
                }
                else if (verificarNombreUsuario(tbNombreUsuarioNuevo.Text)) // verifica si existe un usuario con ese nombre
                {
                    MessageBox.Show("El Nombre de Usuario ya existe", " ", MessageBoxButtons.OK);
                    tbNombreUsuarioNuevo.Focus();
                }
                else if (tbTelefono.Text != string.Empty) // si llega a registrar un numero de telefono
                {
                    if (formatoNumeros() == 1) // formato numero celular
                    {
                        MessageBox.Show("Formato de Numero Telefonico no valido ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbTelefono.Focus();
                    }
                }
                else if (verficacionClaves(tbClaveNuevo.Text, tbConfirmacionClave.Text) == false) // verifica claves iguales
                {
                    MessageBox.Show("Las claves no coinciden", " ", MessageBoxButtons.OK);
                    tbConfirmacionClave.Focus();
                }
                else
                {

                    oPerson = new Models.Person
                    {
                        firstName = new CultureInfo("en-US", false).TextInfo.ToTitleCase(tbApellido.Text),
                        lastName = new CultureInfo("en-US", false).TextInfo.ToTitleCase(tbNombre.Text),
                        email = new CultureInfo("en-US", false).TextInfo.ToTitleCase(tbEmail.Text),
                        dress = new CultureInfo("en-US", false).TextInfo.ToTitleCase(tbDireccion.Text),
                        telephone = tbTelefono.Text,
                        sex = cbSexo.SelectedItem.ToString().Trim(),
                        documentNumber = tbNumeroDocumento.Text,
                        state = 1,
                        type = cboTipoDni.SelectedItem.ToString().Trim()
                    };

                    dbContext.People.Add(oPerson);
                    dbContext.SaveChanges();
                    int id = oPerson.idPerson;

                    oEmployer = new Models.Employer
                    {
                        idPerson = id,
                        password = tbClaveNuevo.Text,
                        userName = tbNombreUsuarioNuevo.Text,
                    };

                    dbContext.Employers.Add(oEmployer);
                    dbContext.SaveChanges();
                    MessageBox.Show("Registro Completado", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                int id = oPerson.idPerson;
                
               
                frmModificarEmpleado = new Forms.frmModificarEmpleador(id,menu);
                frmModificarEmpleado.ShowDialog();
                

            }
        }

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {

            this.Visible = false;

            if (this.Name == "ucDatosEmpleador")
            {
                frmMenu.cerrar(pnlDatos);
            }


        }
    }
}
