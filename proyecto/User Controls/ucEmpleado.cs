using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace proyecto.User_Controls
{
    public partial class ucEmpleado : UserControl
    {
        Models.Employee oEmployee;
        Models.ProyectoLab3Entities dbContext;
        Models.Person oPerson;
        Panel pnlDatos;
        int id;
        
        Form formulario;
        public ucEmpleado()
        {
            InitializeComponent();
            tbClaveNuevo.PasswordChar = '*';
            tbConfirmarClave.PasswordChar = '*';
        }

        public void inicializarForm(Form form) {
            formulario = form;

           
        }
        
        //PROCEDIMIENTOS y FUNCIONES
        public void agregar()
        {
            lblAltaBajaEmpleado.Visible = false;
            rbAltaEmpleado.Visible = false;
            rbBajaEmpleado.Visible = false;
            btnModificar.Visible = false;

        }
        public int formatoNumeros()
        {
            double sueldo;
            long numeroTelefono;
            if (double.TryParse(tbSueldo.Text, out sueldo) == false)
            {
                return 0;
            }
            else if (long.TryParse(tbTelefono.Text, out numeroTelefono) == false)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        public bool camposVacios()
        {
            if (tbNombre.Text == string.Empty || tbApellido.Text == string.Empty || tbUserName.Text == string.Empty || tbClaveNuevo.Text == string.Empty || tbEmail.Text == string.Empty || cboSexo.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
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
        private bool buscarUsuario(string nomUsuario) {
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
        public void setPanel(Panel pnl)
        {
            pnlDatos = pnl;
        }
        public void setEmployee (Models.Employee oEmployee, Models.Person oPerson,Control control)
        {
            this.oEmployee = oEmployee;
            this.oPerson = oPerson;
            tbNombre.Text = oPerson.firstName;
            tbApellido.Text = oPerson.lastName;
            cboSexo.SelectedItem = oPerson.sex;
            cboTipoDni.SelectedItem = oPerson.type;
            tbNumeroDocumento.Text = oPerson.documentNumber;
            tbClaveNuevo.Text = oEmployee.password;
            tbConfirmarClave.Text = oEmployee.password;
            tbEmail.Text = oPerson.email;
            tbDireccion.Text = oPerson.dress;
            tbTelefono.Text = oPerson.telephone;
            dtpFechaIngreso.Value =Convert.ToDateTime(oEmployee.hireDate);
            dtpFechaPago.Value = Convert.ToDateTime(oEmployee.payDate);
            tbSueldo.Text =Convert.ToString(oEmployee.salary);
            tbUserName.Text = oEmployee.userName;
            eliminarElementos(control);
        }
        public void eliminarElementos(Control control)
        {
            foreach (Control oControls in control.Controls)
            {
                if (oControls is Label)
                {
                    if (((Label)oControls).Name == "lblAltaBajaEmpleado")
                    {
                        ((Label)oControls).Visible = false;

                    }
                }
                else if (oControls is RadioButton)
                {
                    ((RadioButton)oControls).Visible = false;
                }
                if (oControls is TextBox)
                {
                    ((TextBox)oControls).ReadOnly = true;
                }
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
                    if (((ComboBox)oControls).Name == "cboSexo")
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
                else if (oControls is DateTimePicker)
                {
                    if (((DateTimePicker)oControls).Name == "dtpFechaIngreso")
                    { ((DateTimePicker)oControls).MaxDate = Convert.ToDateTime(oEmployee.hireDate);
                      ((DateTimePicker)oControls).MinDate = Convert.ToDateTime(oEmployee.hireDate);
                    }
                    else
                    {
                        ((DateTimePicker)oControls).MaxDate = Convert.ToDateTime(oEmployee.payDate);
                        ((DateTimePicker)oControls).MinDate = Convert.ToDateTime(oEmployee.payDate);
                    }
                            

                }
                else
                { eliminarElementos(oControls); }
            }
        }


       

        // CARGAR/AGREGAR EMPLEADOS
        private void btnCargar_Click(object sender, EventArgs e)
        {
            oEmployee = new Models.Employee();

            if (camposVacios()) // campos vacios
            {
                MessageBox.Show("Rellene todos los campos", " ", MessageBoxButtons.OK);
            }
            else if (buscarUsuario(tbUserName.Text)) // nombre empleado valido
            {
                MessageBox.Show("El Nombre de Usuario ya existe", " ", MessageBoxButtons.OK);
                tbUserName.Focus();
            }
            else if (verficacionClaves(tbClaveNuevo.Text, tbConfirmarClave.Text) == false) // verifica claves iguales
            {
                MessageBox.Show("Las claves no coinciden", " ", MessageBoxButtons.OK);
                tbConfirmarClave.Focus();
            }
            else if (dtpFechaPago.Value.Date <= dtpFechaIngreso.Value.Date) // fechas validas
            {
                MessageBox.Show("Las Fechas son Incorrectas", " ", MessageBoxButtons.OK);
            }
            else if (formatoNumeros() == 1) // formate numero celular
            {
                MessageBox.Show("Formato de Numero Telefonico no valido ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (formatoNumeros() == 0) // formato sueldo
            {
                MessageBox.Show("Formato de sueldo no valido ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // carga el emppleado
            {
                
                try
                {
                    oPerson = new Models.Person
                    {
                        firstName = tbApellido.Text,
                        lastName = tbNombre.Text,
                        email = tbEmail.Text,
                        dress = tbDireccion.Text,
                        telephone = tbTelefono.Text,
                        sex = cboSexo.SelectedItem.ToString(),
                        documentNumber = tbNumeroDocumento.Text,
                        state = 1,
                        type = cboTipoDni.SelectedItem.ToString()
                    };

                    dbContext.People.Add(oPerson);
                    dbContext.SaveChanges();
                    int id = oPerson.idPerson;

                    oEmployee = new Models.Employee
                    {
                        IdPerson = id,
                        password = tbClaveNuevo.Text,
                        userName = tbUserName.Text,
                        hireDate = dtpFechaIngreso.Value.Date,
                        payDate = dtpFechaPago.Value.Date,
                        salary = Convert.ToDecimal(tbSueldo.Text)
                    };
                    dbContext.Employees.Add(oEmployee);
                    dbContext.SaveChanges();
                    MessageBox.Show("Empleado Cargado ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (IOException ex)
                { MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
           
        }

        

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmMenu.cerrar(pnlDatos);
        }

        
        // MODIFICAR EMPLEADOS
        public void modificarEmpleado(int ind) {

            this.id = ind;

            dbContext = new Models.ProyectoLab3Entities();
            oPerson = dbContext.People.Find(ind);
            oEmployee = dbContext.Employees.Find(ind);
            lblAltaBajaEmpleado.Visible = true;
            rbAltaEmpleado.Visible = true;
            rbBajaEmpleado.Visible = true;
            btnModificar.Visible = true;

            tbNombre.Text = oPerson.firstName;
            tbApellido.Text = oPerson.lastName;
            cboSexo.SelectedItem = oPerson.sex;
            cboTipoDni.SelectedItem = oPerson.type;
            tbNumeroDocumento.Text = oPerson.documentNumber;
            tbUserName.Text = oEmployee.userName;
            tbClaveNuevo.Text = oEmployee.password;
            tbConfirmarClave.Text = oEmployee.password;
            tbEmail.Text = oPerson.email;
            tbDireccion.Text = oPerson.dress;
            tbTelefono.Text = oPerson.telephone;
            dtpFechaIngreso.Value = oEmployee.hireDate.Value;
            dtpFechaPago.Value = oEmployee.payDate.Value;
            tbSueldo.Text = Convert.ToString(oEmployee.salary);

            if (oPerson.state == 1)
            {
                rbAltaEmpleado.Checked=true;
            }
            else
            {
                rbBajaEmpleado.Checked = true;
            }

           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            dbContext = new Models.ProyectoLab3Entities();
            oPerson = new Models.Person();
            oEmployee = new Models.Employee();

            oPerson = dbContext.People.Find(id);
            oEmployee = dbContext.Employees.Find(id);

            oPerson.firstName = tbNombre.Text;
            oPerson.lastName = tbApellido.Text;
            oPerson.sex = cboSexo.SelectedItem.ToString();
            oPerson.type = cboTipoDni.SelectedItem.ToString();
            oPerson.documentNumber = tbNumeroDocumento.Text;
            oEmployee.password = tbClaveNuevo.Text;            
            oPerson.email = tbEmail.Text;
            oPerson.dress = tbDireccion.Text;
            oPerson.telephone = tbTelefono.Text;
            oEmployee.hireDate = dtpFechaIngreso.Value;
            oEmployee.payDate = dtpFechaPago.Value;
            oEmployee.salary = Convert.ToDecimal(tbSueldo.Text);
            if (rbAltaEmpleado.Checked)
            {
                oPerson.state = 1;
            }
            else
            {
                oPerson.state = 0;
            }

            dbContext.Entry(oEmployee).State = System.Data.Entity.EntityState.Modified;
            dbContext.Entry(oPerson).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
            MessageBox.Show("Empleado Modificado", "", MessageBoxButtons.OK);
        }

        private void ucEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
