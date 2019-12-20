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
    public partial class frmAgregarCliente : Form
    {       
        Models.ProyectoLab3Entities dbContext;
        Models.Client oClient;
        Models.Person oPerson;
        //hola
        
        // constructor predeterminado
        public frmAgregarCliente()
        {
            InitializeComponent();
            
            btnModificar.Visible = false;
            rbAltaCliente.Visible = false;
            rbBajaCliente.Visible = false;
            lblAltaBajaCliente.Visible = false;
        }

        // constructor 1 modificar
        public frmAgregarCliente(int id)
        {
            InitializeComponent();
            

            btnCargar.Visible = false;

            dbContext = new Models.ProyectoLab3Entities();
            oPerson = dbContext.People.Find(id);

            tbApellidoCliente.Text = oPerson.firstName;
            tbNombreCliente.Text = oPerson.lastName;
            tbNumeroDocumento.Text = Convert.ToString(oPerson.documentNumber);
            tbEmailCliente.Text = oPerson.email;
            tbDireccionCliente.Text = oPerson.dress;
            tbTelefonoCliente.Text = oPerson.telephone;
            cboTipoDni.SelectedItem = oPerson.type;
            cbSexo.SelectedItem = oPerson.sex;
            if (oPerson.state == 1)
            {
                rbAltaCliente.Checked = true;
            }
            else
            {
                rbBajaCliente.Checked = false;
            }


        }

        // LOAD FORMULARIO 
        private void frmAgregarCliente_Load(object sender, EventArgs e)
        {
               
        }

        /////// procedimientos-funciones /////
       
        public bool textBoxVacio()
        {
            if (tbNombreCliente.Text == string.Empty || tbApellidoCliente.Text == string.Empty || tbEmailCliente.Text == string.Empty || tbTelefonoCliente.Text == string.Empty || tbDireccionCliente.Text == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public int formatoNumeros()
        {
           
            int numeroTelefono;
           
            if (int.TryParse(tbTelefonoCliente.Text , out numeroTelefono) == false)
            {
                return 1;
            }
            else
            {
                return -1;
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
        public bool verificacion()
        {
            if (textBoxVacio()) // espacios vacios
            {
                MessageBox.Show("Rellene todos los campos", " ", MessageBoxButtons.OK);
                return false;

            }
            else if (searchClient(tbNumeroDocumento.Text, cbSexo.SelectedItem.ToString(), cboTipoDni.SelectedItem.ToString())) // exite cliente 
            {
                MessageBox.Show("Cliente ya existe", " ", MessageBoxButtons.OK);
                tbNombreCliente.Focus();
                return false;
            }
            else { return true; }
        }

        // CARGAR/AGREGAR CLIENTES
        private void btnCargar_Click(object sender, EventArgs e)
        {

            if (verificacion())
            {
                oPerson = new Models.Person
                {
                    firstName = tbApellidoCliente.Text,
                    lastName = tbNombreCliente.Text,
                    email = tbEmailCliente.Text,
                    dress = tbDireccionCliente.Text,
                    telephone = tbTelefonoCliente.Text,
                    sex = cbSexo.SelectedItem.ToString(),
                    documentNumber = tbNumeroDocumento.Text,
                    state = 1,
                    type = cboTipoDni.SelectedItem.ToString()
                };

                dbContext = new Models.ProyectoLab3Entities();
                dbContext.People.Add(oPerson);
                dbContext.SaveChanges();
                int id = oPerson.idPerson;

                oClient = new Models.Client
                {
                    idPerson = id
                };

                dbContext.Clients.Add(oClient);
                dbContext.SaveChanges();

                MessageBox.Show("Cliente Cargado ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbApellidoCliente.Clear();
                tbEmailCliente.Clear();
                tbDireccionCliente.Clear();
                tbNombreCliente.Clear();
                tbTelefonoCliente.Clear();
                cboTipoDni.SelectedIndex = 0;
                cbSexo.SelectedIndex = 0;
                tbNumeroDocumento.Clear();
            }
        }
       
        // MODIFICAR CLIENTES
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (textBoxVacio())
            {
                MessageBox.Show("Rellene todos los campos", " ", MessageBoxButtons.OK);
            }
            else if (formatoNumeros() == 1)
            {
                MessageBox.Show("Formato del numero de Telefono incorrecto", " ", MessageBoxButtons.OK);
                tbTelefonoCliente.Focus();
            }
            else
            {
                oPerson.firstName = tbApellidoCliente.Text;
                oPerson.lastName = tbNombreCliente.Text;
                oPerson.email = tbEmailCliente.Text;
                oPerson.dress = tbDireccionCliente.Text;
                oPerson.telephone = tbTelefonoCliente.Text;
                oPerson.sex = cbSexo.SelectedItem.ToString();
                oPerson.documentNumber = tbNumeroDocumento.Text;
                oPerson.type = cboTipoDni.SelectedItem.ToString();
                
                if (rbAltaCliente.Checked)
                {
                    oPerson.state = 1;
                }
                else
                {
                    oPerson.state = 0;
                }

                dbContext.Entry(oPerson).State = System.Data.Entity.EntityState.Modified;
                dbContext.SaveChanges();

                MessageBox.Show("Cliente Modificado ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        
        // VOLVER ATRAS
        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
