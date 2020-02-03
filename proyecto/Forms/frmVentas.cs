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
using System.Globalization;
using System.Data.Entity.Validation;

namespace proyecto.Forms
{
    public partial class frmVentas : Form
    {
        Models.ProyectoLab3Entities dbContext;
        Models.Employee oEmployee;
        Models.Employer oEmployer;
        Models.Person oPerson;
        Models.Product oProduct;
        Models.Sale oSale;
        Models.SaleProduct oSaleProduct;
        Models.Code Code_sales;
        List<Models.Product> listProducts;
        int idSelected;
        int indic;
        bool v;

        //CONSTRUCTOR   
        public frmVentas(Models.Person oPerson)
        {
            this.oPerson = oPerson;
            InitializeComponent();
            btnModificar.Visible = false;
            rbAlta.Visible = false;
            rbBaja.Visible = false;
            lblAltaBaja.Visible = false;
            searchPerson();

        }

        //LOAD

        private void frmVentas_Load(object sender, EventArgs e)
        {

            lblFecha.Text = DateTime.Now.ToString("dddd',' dd MMMM 'de' yyyy");
            dgvProductos.MultiSelect = false;
            dgvProductos.AllowUserToAddRows = false;
            dbContext = new Models.ProyectoLab3Entities();
            dgvProductos.MultiSelect = false;
            dgvClientes.DataSource = (from Personas in dbContext.People
                                      from Clientes in dbContext.Clients
                                      where Personas.idPerson == Clientes.idPerson && Personas.state == 1
                                      orderby Personas.documentNumber
                                      select new
                                      {
                                          Personas.idPerson,
                                          Apellido = Personas.firstName,
                                          Nombre = Personas.lastName,
                                          Personas.type,
                                          Personas.documentNumber,
                                          Sexo = Personas.sex,


                                          Personas.state
                                      }).ToList();

            dgvClientes.Columns[0].Visible = false;
            dgvClientes.Columns[3].HeaderText = "Tipo Documento";
            dgvClientes.Columns[3].Width = 150;
            dgvClientes.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            dgvClientes.Columns[4].HeaderText = "N° Documento";
            dgvClientes.Columns[4].Width = 100;
            dgvClientes.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;



            dgvClientes.Columns[6].Visible = false;
            Code_sales = dbContext.Codes.Find(1);
            
            Code_sales.key_sales = Code_sales.key_sales+1;
            tbCodigo.Text = DateTime.Now.Year.ToString() + "-" + Code_sales.key_sales.ToString();

            autoComplete();
            fillCb();





        }

        //PROCEDIMIENTOS Y FUNCIONES
        private void autoComplete()
        {
            AutoCompleteStringCollection datos = new AutoCompleteStringCollection();
            AutoCompleteStringCollection datos1 = new AutoCompleteStringCollection();

            listProducts = (from product in dbContext.Products where product.state == 1 && product.cant != 0 select product).ToList();

            foreach (Models.Product c in listProducts)
            {
                datos.Add(c.barcode.ToString());
                string product = c.categorie.Trim() + " " + c.description.Trim();
                datos1.Add(product);
            }

            cboCodigo.AutoCompleteCustomSource = datos;
            cboCodigo.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboCodigo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboProducto.AutoCompleteCustomSource = datos1;
            cboProducto.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;


        }
        private void fillCb()
        {
            var lista = from product in dbContext.Products where product.state == 1 && product.cant != 0 select product;

            List<Models.Product> list = (from product in dbContext.Products
                                         where product.state == 1 && product.cant != 0
                                         select product).ToList();

            cboProducto.DataSource = list.Select(x => x.description.Trim() + " " + x.categorie.Trim()).ToList();

            cboCodigo.DataSource = (from pro in lista select pro.barcode).ToList();


        }
        private Models.Employer searchEmployer(int idPerson)
        {
            try
            {
                dbContext = new Models.ProyectoLab3Entities();
                oEmployer = null;
                var varEmpleador = from Employer in dbContext.Employers select Employer;
                oEmployer = varEmpleador.ToList().Find(x => x.idPerson == idPerson);

                return oEmployer;
            }
            catch (IOException ex) { return null; }
        }
        private Models.Employee searchEmployee(int idPerson)
        {
            try
            {
                dbContext = new Models.ProyectoLab3Entities();
                oEmployee = null;
                var varEmpleado = from Employees in dbContext.Employees select Employees;
                oEmployee = varEmpleado.ToList().Find(x => x.IdPerson == idPerson);
                return oEmployee;
            }
            catch (IOException EX) { return null; }

        }
        private bool searchPerson()
        {

            try
            {
                oEmployee = searchEmployee(oPerson.idPerson);
                oEmployer = searchEmployer(oPerson.idPerson);

                if (oEmployer != null) // empleador
                {
                    tbNombreVendedor.Text = oEmployer.idPerson.ToString();
                    return true;
                }
                else
                { //empleado
                    tbNombreVendedor.Text = oEmployee.IdPerson.ToString();
                    return true;
                }
            }
            catch (IOException EX)
            {
                return false;

            }

        }

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciones una fila para Modificar", "Aviso");

            }
            else
            {
                idSelected = int.Parse(dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[0].Value.ToString());
                pnlClientes.Visible = false;
                tbNombreCliente.Text = new CultureInfo("es-MX").TextInfo.ToTitleCase(dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[1].Value.ToString().Trim() + " " + dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[2].Value.ToString().Trim());
                tbTipo.Text = new CultureInfo("es-MX").TextInfo.ToTitleCase(dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[4].Value.ToString().Trim());
                tbNumero.Text = new CultureInfo("es-MX").TextInfo.ToTitleCase(dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[5].Value.ToString().Trim());
            }
        }

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {


            this.Close();
        }

        private void pnlEliminarProducto_Click(object sender, EventArgs e)
        {
            tbTotalVenta.Text = (Convert.ToDecimal(tbTotalVenta.Text) - Convert.ToDecimal(dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells["Importe"].Value)).ToString();
            dgvProductos.Rows.RemoveAt(dgvProductos.CurrentRow.Index);
            
           
        }

        private void tbFiltrar_KeyUp(object sender, KeyEventArgs e)
        {

            dgvClientes.DataSource = (from Personas in dbContext.People
                                      from Clientes in dbContext.Clients
                                      where Personas.idPerson == Clientes.idPerson && Personas.state == 1 &&
                                      (Personas.documentNumber.Contains(tbFiltrar.Text) ||

                                      (((Personas.lastName.Trim() + " " + Personas.firstName.Trim()).Contains(tbFiltrar.Text))) || (Personas.firstName.Trim() + " " + Personas.lastName.Trim()).Contains(tbFiltrar.Text))
                                      orderby Personas.documentNumber
                                      select new
                                      {
                                          Personas.idPerson,
                                          Apellido = Personas.firstName,
                                          Nombre = Personas.lastName,
                                          Personas.type,
                                          Personas.documentNumber,
                                          Sexo = Personas.sex,


                                          Personas.state
                                      }).ToList();
            dgvClientes.Columns[0].Visible = false;
            dgvClientes.Columns[4].HeaderText = "Tipo Documento";
            dgvClientes.Columns[4].Width = 150;
            dgvClientes.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            dgvClientes.Columns[5].HeaderText = "N° Documento";
            dgvClientes.Columns[5].Width = 100;
            dgvClientes.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;

            dgvClientes.Columns[6].Visible = false;


        }

        private void cbCodigo_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void cboCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //nudCantidadProducto.Value = 1;
            cboProducto.SelectedIndex = cboCodigo.SelectedIndex;
            tbImporte.Text = "$ " + (listProducts.ElementAt(cboCodigo.SelectedIndex).price * nudCantidadProducto.Value).ToString();
            nudCantidadProducto.Maximum = listProducts.ElementAt(cboCodigo.SelectedIndex).cant;

        }
        
        private void pnlAgregarProcucto_Click(object sender, EventArgs e)
        {
            var a = (from row in dgvProductos.Rows.Cast<DataGridViewRow>()
                     let codigo = Convert.ToString(row.Cells["colCodigoBarra"].Value)
                     where codigo.Contains(cboCodigo.SelectedItem.ToString())
                     select row).ToList<DataGridViewRow>();

            if (a.Count == 0)
            {
                dgvProductos.Rows.Add();
                int contData = dgvProductos.Rows.Count - 1;
                // importeTotal = importeTotal + oProduct.price;
                // tbTotalVenta.Text = Convert.ToString(importeTotal);

                dgvProductos.Rows[contData].Cells["colCodigoBarra"].Value = cboCodigo.SelectedItem;
                dgvProductos.Rows[contData].Cells["Articulo"].Value = cboProducto.SelectedItem;
                dgvProductos.Rows[contData].Cells["Cantidad"].Value = nudCantidadProducto.Value;
                dgvProductos.Rows[contData].Cells["Precio"].Value = listProducts.ElementAt(cboCodigo.SelectedIndex).price.ToString();
                dgvProductos.Rows[contData].Cells["Importe"].Value = (Convert.ToDecimal(tbImporte.Text.Trim('$', ' '))).ToString();
                dgvProductos.ClearSelection();
                decimal importe = 0;
                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    importe += Convert.ToDecimal(row.Cells["Importe"].Value);
                    
                }
                tbTotalVenta.Text = importe.ToString();

            }
            else
            {
                var co = (from item in a let cell = item select item).ToList().ElementAt(0);
                List<DataGridViewCell> cells = (from item in co.Cells.Cast<DataGridViewCell>() select item).ToList<DataGridViewCell>();
                int indice = cells.ElementAt(0).RowIndex;
                dgvProductos.Rows[indice].Selected = true;         
                nudCantidadProducto.Value = Convert.ToDecimal(dgvProductos.Rows[indice].Cells["Cantidad"].Value);
                decimal importe = 0;
                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    importe += Convert.ToDecimal(row.Cells["Importe"].Value);

                }
                tbTotalVenta.Text = importe.ToString();

            }







        }
        
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indic = dgvProductos.CurrentCell.RowIndex;
            cboCodigo.SelectedItem = dgvProductos.Rows[indic].Cells["colCodigoBarra"].Value;
            cboProducto.SelectedItem = dgvProductos.Rows[indic].Cells["Articulo"].Value;
            nudCantidadProducto.Value = Convert.ToDecimal(dgvProductos.Rows[indic].Cells["Cantidad"].Value);
            tbImporte.Text = (Convert.ToDecimal( dgvProductos.Rows[indic].Cells["Precio"].Value) * Convert.ToDecimal(dgvProductos.Rows[indic].Cells["Cantidad"].Value)).ToString();
             v = true;
        }
        
        private void nudCantidadProducto_ValueChanged(object sender, EventArgs e)
        {
            tbImporte.Text = "$ " + (listProducts.ElementAt(cboCodigo.SelectedIndex).price * nudCantidadProducto.Value).ToString();
            if (dgvProductos.Rows.Count != 0 && v== true && indic == dgvProductos.CurrentCell.RowIndex)
            {
                dgvProductos.Rows[dgvProductos.CurrentCell.RowIndex].Cells["Cantidad"].Value = nudCantidadProducto.Value;
                dgvProductos.Rows[dgvProductos.CurrentCell.RowIndex].Cells["Importe"].Value = (Convert.ToDecimal(tbImporte.Text.Trim('$', ' '))).ToString();
                v = true;
            }
            else
            {
                v = false;
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count == 0)
            {
                MessageBox.Show("No ingresó ningun producto", "Aviso");
                cboCodigo.Focus();
            }
            else
            {
                try {
                    oSale = new Models.Sale
                    {
                        idPerson = oPerson.idPerson,
                        idClient = idSelected,
                        summary = Convert.ToDecimal(tbTotalVenta.Text),
                        saleDate = Convert.ToDateTime(lblFecha.Text),
                        state = 1,
                        saleNumber = tbCodigo.Text
                    };

                    dbContext.Sales.Add(oSale);
                    dbContext.SaveChanges();


                    foreach (DataGridViewRow row in dgvProductos.Rows)
                    {
                        foreach (Models.Product p in listProducts)
                        {
                            if (p.barcode.ToString() == row.Cells["colCodigoBarra"].Value.ToString())
                            {
                                oSaleProduct = new Models.SaleProduct
                                {
                                    idProduct = p.idProduct,
                                    idSale = oSale.IdSale,
                                    cant = Convert.ToInt32(row.Cells["Cantidad"].Value),
                                    summary = Convert.ToDecimal(row.Cells["Importe"].Value),
                                    

                                };

                                oProduct = dbContext.Products.Find(oSaleProduct.idProduct);
                                oProduct.cant = oProduct.cant - oSaleProduct.cant;
                                dbContext.Entry(oProduct).State = System.Data.Entity.EntityState.Modified;
                                dbContext.SaveChanges();

                               // dbContext = new Models.ProyectoLab3Entities();
                                dbContext.SaleProducts.Add(oSaleProduct);
                                dbContext.SaveChanges();

                            }

                        }

                    }
                    
                    dbContext.SaveChanges();
                    dbContext.Entry(Code_sales).State = System.Data.Entity.EntityState.Modified;
                    dbContext.SaveChanges();


                    MessageBox.Show("Venta Cargada", "Aviso", MessageBoxButtons.OK);
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var eve in ex.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                            MessageBox.Show("- Property: \"{0}\", Error: \"{1}\""+
                                ve.PropertyName+ ve.ErrorMessage, "Aviso", MessageBoxButtons.OK);
                        }
                    }
                  
                }
            }

        }

        private void LblSeleccion_Click(object sender, EventArgs e)
        {

        }

        private void TbNombreVendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void PnlEliminarProducto_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
