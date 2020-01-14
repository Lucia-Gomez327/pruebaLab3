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
using System.Data.Entity.Validation;
using Biblioteca;

/////////////////////////////////////// AGREGAR PRODUCTOS //////////////////////////////////
namespace proyecto
{
    public partial class frmAgregarProductos : Form
    {
        //clsProducto Producto;
        Models.ProyectoLab3Entities dbContext;
        Models.Product oProduct;
        
       
        // constructor predeterminado
        public frmAgregarProductos()
        {
            InitializeComponent();
            btnModificar.Visible = false;
            lblAltaBajaProductos.Visible = false;
            rbAltaProducto.Visible = false;
            rbBajaProducto.Visible = false;
            tbCodigoDeBarras.ReadOnly = false;
            tbCategoria.ReadOnly = false;
            dbContext = new Models.ProyectoLab3Entities();
        }
        // constructor 1
        public frmAgregarProductos(int id)
        {
            InitializeComponent();

            dbContext = new Models.ProyectoLab3Entities();
            btnCargar.Visible = false;
            tbCodigoDeBarras.ReadOnly = true;
            tbCategoria.ReadOnly = true;
            oProduct = dbContext.Products.Find(id);
            tbCodigoDeBarras.Text = Convert.ToString( oProduct.barcode);
            tbDescripcion.Text = oProduct.description;
            tbCategoria.Text = oProduct.categorie;
            tbPrecio.Text = Convert.ToString(oProduct.price);
            nudCantidadProductos.Value = oProduct.cant;
            if (oProduct.state == 1)
            {
                rbAltaProducto.Checked = true;
            }
            else
            {
                rbBajaProducto.Checked = true;
            }
            //nudCantidadProductos.Value = oProduct.cant;


        }
        
        // LOAD FORMULARIO 
        private void frmAgregarProductos_Load(object sender, EventArgs e)
        {
            tbCodigoDeBarras.MaxLength = 8;
           

        }
        /////// procedimientos /////
        
        private bool tetxBoxVacio()
              {
                  if (tbCategoria.Text == string.Empty || tbCodigoDeBarras.Text == string.Empty || tbDescripcion.Text == string.Empty || tbPrecio.Text == string.Empty )
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        private int formatoNumeros()
        {
            
            double precio;
            if (double.TryParse(tbPrecio.Text, out precio) == false) // precio
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        private bool searchCodeBar()
        {
            oProduct = new Models.Product();
            
            try
            {

                var resProduct = from product in dbContext.Products where product.barcode.ToString() == tbCodigoDeBarras.Text select product;

                oProduct = resProduct.ToList().Find(x => x.barcode.ToString() ==tbCodigoDeBarras.Text);
               
                if (oProduct != null )
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
        
        // CARGAR/AGREGAR PRODUCTOS
        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (tetxBoxVacio())
            {
                MessageBox.Show("Rellene todos los campos", "Aviso ", MessageBoxButtons.OK);
            }
            else if(tbCodigoDeBarras.TextLength < 8)
            {
                MessageBox.Show("Codigo de Barra invalido", "Aviso ", MessageBoxButtons.OK);
                tbCodigoDeBarras.Focus();
            }
           else if (searchCodeBar())
            {
                MessageBox.Show("Producto ya existente", "Aviso ", MessageBoxButtons.OK);
                tbCodigoDeBarras.Focus();
            }
            else if (formatoNumeros() == 1)
            {
                MessageBox.Show("Formate del precio incorrecto", "Aviso ", MessageBoxButtons.OK);
                tbPrecio.Focus();
            }
            else
            {
                try {
                    
                    oProduct = new Models.Product
                    {
                        cant = Convert.ToInt32(nudCantidadProductos.Value),
                        price = Convert.ToInt32(tbPrecio.Text),
                        description = tbDescripcion.Text,
                        barcode = Convert.ToInt32(tbCodigoDeBarras.Text),
                        categorie = tbCategoria.Text,
                        state = 1
                };

                    dbContext = new Models.ProyectoLab3Entities();
                    dbContext.Products.Add(oProduct);
                dbContext.SaveChanges();
          
                MessageBox.Show("Producto cargado", "Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbCategoria.Clear();
                tbCodigoDeBarras.Clear();
                tbDescripcion.Clear();
                tbPrecio.Clear();
                nudCantidadProductos.Value = 0;
                }
                catch(DbEntityValidationException ex)
                {
                    
                }
            }

        }
        
        // MODIFICAR PRODUCTOS
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (rbAltaProducto.Checked && tetxBoxVacio() == false && nudCantidadProductos.Value == 0)
            {              
                    MessageBox.Show("Rellene todos los campos", " Aviso", MessageBoxButtons.OK);               
            }
            else if(tetxBoxVacio())
                {
                    MessageBox.Show("Rellene todos los campos", " Aviso", MessageBoxButtons.OK);               
                }
                else if (formatoNumeros() == 1)
                {
                    MessageBox.Show("Formate del precio incorrecto", "Aviso ", MessageBoxButtons.OK);
                    tbPrecio.Focus();
                }
                else
                {
                if (rbAltaProducto.Checked)
                {
                    oProduct.state = 1;
                }
                else
                {
                    oProduct.state = 0;
                }
                oProduct.price = Convert.ToDecimal(tbPrecio.Text);
                oProduct.description = tbDescripcion.Text;
                oProduct.cant =Convert.ToInt32( nudCantidadProductos.Value);
               
                dbContext.Entry(oProduct).State = System.Data.Entity.EntityState.Modified;
                dbContext.SaveChanges();
                MessageBox.Show("Producto modificado", " Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
        
        
        // VOLVER ATRAS
        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
