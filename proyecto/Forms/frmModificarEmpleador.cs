using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace proyecto.Forms
{
    public partial class frmModificarEmpleador : Form
    {
        Models.Person oPerson;
        Models.Employer oEmployer;
        Models.ProyectoLab3Entities dbContext;
        ToolTip tp1;
        frmMenu menu;

        public frmModificarEmpleador(int id, frmMenu menu)
        {
            InitializeComponent();
            this.menu = menu;
            dbContext = new Models.ProyectoLab3Entities();
            this.oPerson = dbContext.People.Find(id);
            this.oEmployer = dbContext.Employers.Find(id);
        }
        //LOAD
        private void frmModificarEmpleador_Load(object sender, EventArgs e)
        {
            tp1 = new System.Windows.Forms.ToolTip();

            tbClave.PasswordChar = '*';
            tp1.SetToolTip(pnlVisualizar, "Ver Clave");           
            pnlClave.Visible = false;
            tbClave.ReadOnly = true;
            tbApellido.Text = oPerson.firstName;
            tbNombre.Text = oPerson.lastName;
            cboTipoDni.SelectedItem = oPerson.type;
            tbNumeroDocumento.Text = oPerson.documentNumber;
            cbSexo.SelectedItem = oPerson.sex;
            

            oEmployer = BuscarEmpleador(oPerson.idPerson);

            tbNombreUsuario.Text = oEmployer.userName;
            tbClave.Text = oEmployer.password;

            tbEmail.Text = oPerson.email;
            tbDireccion.Text = oPerson.dress;
            tbTelefono.Text = oPerson.telephone;

            lblClaveIncorrecta.Visible = false;
            lblClaveNoCoincide.Visible = false;
            tbClaveActual.PasswordChar = '*';
            tbClaveNueva.PasswordChar = '*';
            tbConfirmacionClave.PasswordChar = '*';
        }


        //PROCEDIMIENTOS Y FUNCIONES
        public Models.Employer BuscarEmpleador(int idPerson)
        {
            try
            {
               // dbContext = new Models.ProyectoLab3Entities();
                return dbContext.Employers.Find(idPerson);
            }
            catch (IOException EX)
            {
                return null;
            }


        }
        private bool verificarNombreUsuario(string nomUsuario) // usado en el boton aceptar
        {
            //dbContext = new Models.ProyectoLab3Entities();
            Models.Employer emp = new Models.Employer();
            try
            {
                var varEmpleador = from Empleador in dbContext.Employers where Empleador.userName == nomUsuario select Empleador;
                if (tbNombreUsuario.Text == oEmployer.userName)
                {
                    varEmpleador = null;
                }
                if (varEmpleador != null)
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
        private bool controlesVacios()
        {

            if (tbNombre.Text == string.Empty || tbApellido.Text == string.Empty || tbNombreUsuario.Text == string.Empty || tbEmail.Text == string.Empty || cbSexo.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                if (pnlClave.Visible)
                {
                    if (tbConfirmacionClave.Text == string.Empty)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        private int formatoNumeros()
        {
            long numeroTelefono;
            if (tbTelefono.Text != " ")
            {
                if (long.TryParse(tbTelefono.Text, out numeroTelefono) == false)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }

     

        private void tbClaveNuevo_Click(object sender, EventArgs e)
        {
           
            if (!pnlClave.Visible)
            {
                pnlClave.Visible = true;

            }
            else
            {
                if(tbClaveActual.Text != string.Empty || tbClaveNueva.Text != string.Empty || tbConfirmacionClave.Text != string.Empty)
                {
                    DialogResult result = MessageBox.Show("¿No desea modificar la clave?", "Cambios", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        pnlClave.Visible = false;
                    }
                }
                else
                {
                    pnlClave.Visible = false;
                }


                
            }

            
        }

       

        private void tbClaveActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (oEmployer.password != tbClaveActual.Text)
                {
                    lblClaveIncorrecta.Visible = true;

                }
                else
                {
                    lblClaveIncorrecta.Visible = false;
                }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (controlesVacios()) // controles vacios
            {
                MessageBox.Show("Rellene todos los campos", "Aviso", MessageBoxButtons.OK);
            }
            else if (lblClaveIncorrecta.Visible) // verifica clave actual
            {
                MessageBox.Show("Clave actual Incorrecta", "Aviso", MessageBoxButtons.OK);
                tbConfirmacionClave.Focus();
            }
            else if (!pnlClave.Visible && tbClaveNueva.Text != tbConfirmacionClave.Text) // verifica claves iguales
            {
                MessageBox.Show("Las claves no coinciden", "Aviso", MessageBoxButtons.OK);
                tbConfirmacionClave.Focus();
            }
            else if (tbTelefono.Text != string.Empty) // si llega a registrar un numero de telefono
            {
                if (formatoNumeros() == 1) // formato numero celular
                {
                    MessageBox.Show("Formato de Numero Telefonico no valido ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbTelefono.Focus();
                }               
            }
            else if (verificarNombreUsuario(tbNombreUsuario.Text)) // verifica si existe un usuario con ese nombre
            {
                MessageBox.Show("El Nombre de Usuario ya existe", " ", MessageBoxButtons.OK);
                tbNombreUsuario.Focus();
            }
            else
            {
                oPerson.firstName = tbApellido.Text;
                oPerson.lastName = tbNombre.Text;
                oPerson.email = tbEmail.Text;
                oPerson.dress = tbDireccion.Text;
                oPerson.telephone = tbTelefono.Text;
                oPerson.sex = cbSexo.SelectedItem.ToString();
                oPerson.documentNumber = tbNumeroDocumento.Text;
                oPerson.state = 1;
                oPerson.type = cboTipoDni.SelectedItem.ToString();

                
                dbContext.Entry(oPerson).State = System.Data.Entity.EntityState.Modified;
                dbContext.SaveChanges();

                int id = oPerson.idPerson;

                oEmployer.idPerson = id;
                if (pnlClave.Visible == true)
                {
                    oEmployer.password = tbClaveNueva.Text;
                }
                oEmployer.userName = tbNombreUsuario.Text;
               
                dbContext.Entry(oEmployer).State = System.Data.Entity.EntityState.Modified;
                dbContext.SaveChanges();
                MessageBox.Show("Usuario modificado");
            }
        } 

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            menu.setEmpleador(oPerson.idPerson);
            this.Close();
        }

        private void pnlVisualizar_MouseEnter(object sender, EventArgs e)
        {
            
                tbClaveNueva.PasswordChar = '\0';
                tbConfirmacionClave.PasswordChar = '\0';
               tp1.SetToolTip(pnlVisualizar, "Ocultar Claves");
            
        }

        private void pnlVisualizar_MouseLeave(object sender, EventArgs e)
        {
            tbClaveNueva.PasswordChar = '*';
            tbConfirmacionClave.PasswordChar = '*';
            tp1.SetToolTip(pnlVisualizar, "Ver Claves");
        }

        private void tbConfirmacionClave_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbClaveNueva.Text != tbConfirmacionClave.Text)
            {
                lblClaveNoCoincide.Visible = true;
            }
            else
            {
                lblClaveNoCoincide.Visible = false;
            }
        }
    }
}
