using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Collections.Concurrent;
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

namespace proyecto
{
    public partial class frmAgregarVenta : Form
    {
        Models.ProyectoLab3Entities dbContext;
        Models.Person oPerson;
        Models.Employer oEmployer;
        Models.Employee oEmployee;
        Models.Product oProduct;
        Models.Sale oSale;
        Models.Client oClient;
        Models.SaleProduct oSaleProduct;
        List<Models.Product> prodcuts;
        List<int> listIdProducts;
        List<int> listIdClients;
        ArrayList clients;
        DialogResult result;

        int idSelected;
        int contData;

        decimal importeTotal = 0;
        int posicion;
        List<string> listaDes;

        // constructor
        public frmAgregarVenta(Models.Person oPerson)
        {
            this.oPerson = oPerson;

            InitializeComponent();

            btnCargar.Visible = true;
            btnModificar.Visible = false;
            rbAlta.Visible = false;
            rbBaja.Visible = false;
            lblAltaBaja.Visible = false;

            searchPerson();
        }
        public frmAgregarVenta(int idS)
        {
            InitializeComponent();

            int id = idS;
            btnCargar.Visible = false;
            btnModificar.Visible = true;
            rbAlta.Visible = true;
            rbBaja.Visible = true;
            lblAltaBaja.Visible = true;

            modifySale(id);
        }

        // LOAD FORMULARION
        private void frmAgregarVenta_Load(object sender, EventArgs e)
        {
            tbNombreUsuario.ReadOnly = true;

            tbTotalVenta.ReadOnly = true;


            fillCb();
            dgvProductos.MultiSelect = false;
            dgvProductos.AllowUserToAddRows = false;
            contData = -1;
            pnlAgregarCliente.Visible = true;
            pnlClientes.Visible = true;
            result = DialogResult.OK;

            dgvClientes.DataSource = dbContext.Clients.GroupJoin(dbContext.People, cli => cli.idPerson, peo => peo.idPerson, (cli, per) => new { per, cli }).Select(x => new { x.cli.Person.idPerson, Apellido = x.cli.Person.firstName, Nombre = x.cli.Person.lastName, Sexo = x.cli.Person.sex, x.cli.Person.type, x.cli.Person.documentNumber, x.cli.Person.state }).Where(x => x.state == 1).ToList();

            dgvClientes.Columns[0].Visible = false;
            dgvClientes.Columns[4].HeaderText = "Tipo Documento";
            dgvClientes.Columns[4].Width = 150;
            dgvClientes.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            dgvClientes.Columns[5].HeaderText = "Numero Documento";
            dgvClientes.Columns[5].Width = 150;
            dgvClientes.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            
            dgvClientes.Columns[6].Visible = false;

        }

        /////// procedimientos-funciones /////
        public void formatDGV()
        {
            //dgvProductos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            ////dgvProductos.Columns[1].Width = 70;
            //dgvProductos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            //dgvProductos.Columns[2].DefaultCellStyle.Format = "$##,#0.00";
            //dgvProductos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            //dgvProductos.Columns[3].DefaultCellStyle.Format = "$##,#0.00";
        }
        private void modifySale(int id)
        {
            dbContext = new Models.ProyectoLab3Entities();
            oSale = dbContext.Sales.Find(id);

            var listSaleProducts = (from saleProduct in dbContext.SaleProducts
                                    where saleProduct.idSale == id
                                    select saleProduct);
            int colum = 0;
            foreach (var x in listSaleProducts)
            {
                dgvProductos.Rows.Add();
                dgvProductos.Rows[colum].Cells["Articulo"].Value = dbContext.Products.Find(x.idProduct).barcode + "  " + dbContext.Products.Find(x.idProduct).description;
                dgvProductos.Rows[colum].Cells["Cantidad"].Value = x.cant;
                dgvProductos.Rows[colum].Cells["Precio"].Value = dbContext.Products.Find(x.idProduct).price;
                dgvProductos.Rows[colum].Cells["Importe"].Value = x.summary;

                colum++;

            }
            formatDGV();

            var sales = (from Sale in dbContext.Sales
                         from Prod in dbContext.Products
                         from Cliente in dbContext.Clients
                         from Person in dbContext.People
                         where Sale.IdSale == oSale.IdSale && Sale.idProduct == Prod.idProduct && Sale.idPerson == Person.idPerson && Sale.idClient == Cliente.idPerson
                         orderby Sale.saleNumber
                         select new
                         {
                             Sale.saleNumber,
                             Vendedor = Person.firstName,
                             Cliente = Cliente.Person.firstName,
                             Fecha = Sale.saleDate,
                             Total = Sale.summary,
                             Sale.state

                         }).Distinct().OrderBy(x => x.saleNumber);
            // cboNombreCliente.Text = (from Sale in sales select Sale.Cliente).ToString();

        }
        private void fillCb()
        {
            listIdProducts = new List<int>();
            listIdClients = new List<int>();
            prodcuts = new List<Models.Product>();
            clients = new ArrayList();

            var listProduct = from product in dbContext.Products where product.cant > 0 where product.state == 1 select product;

            var listClient = dbContext.Clients.GroupJoin(dbContext.People, cli => cli.idPerson, per => per.idPerson, (cli, per) => new { per, cli }).Select(x => new { x.cli.Person.idPerson, x.cli.Person.firstName, x.cli.Person.lastName, x.cli.Person.state }).Where(x => x.state == 1).ToList();

            foreach (var x in listProduct)
            {
                //cboCodigoBarra.Items.Add(x.barcode + "   " + x.description.Trim());
                listIdProducts.Add(x.idProduct);
                prodcuts.Add(x);
                
            }

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
                    tbNombreUsuario.Text = oEmployer.userName;
                    return true;
                }
                else
                { //empleado
                    tbNombreUsuario.Text = oEmployee.userName;
                    return true;
                }
            }
            catch (IOException EX)
            {
                return false;

            }





        }
        private void actualizarImporte(int cant, decimal importe)
        {
            if (dgvProductos.Rows.Count != 0)
            {
                if (posicion != -1 && cant < Convert.ToInt32(dgvProductos.Rows[posicion].Cells["Cantidad"].Value))
                {
                    importeTotal = importeTotal - importe;
                }
                else if (cant != Convert.ToInt32(dgvProductos.Rows[posicion].Cells["Cantidad"].Value))
                { importeTotal = importeTotal + importe; }

                tbTotalVenta.Text = Convert.ToString(importeTotal);

            }
        }
        private void actualizarDescripcion()
        {
            listaDes = new List<string>();
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                listaDes.Add(row.Cells[0].Value.ToString());
            }
            
        }

        // CARGAR/AGREGAR VENTA
        private void btnCargar_Click(object sender, EventArgs e)
        {

            //if (cboCodigoBarra.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Seleccione algun producto");
            //    cboCodigoBarra.Focus();
            //}
            if (dtpFechaVenta.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Fecha Invalida", "Aviso", MessageBoxButtons.OK);
                dtpFechaVenta.Focus();
            }
            else
            {
                dbContext = new Models.ProyectoLab3Entities();
                if (oEmployer != null)
                {

                    oSale = new Models.Sale
                    {
                        idPerson = oPerson.idPerson,
                        idClient = idSelected,
                        idProduct = oProduct.idProduct,
                        summary = Convert.ToDecimal(tbTotalVenta.Text),
                        saleDate = dtpFechaVenta.Value,
                        saleNumber = " ",
                        state = 1
                    };
                    dbContext.Sales.Add(oSale);
                    dbContext.SaveChanges();
                    oSale.saleNumber = DateTime.Now.Year.ToString() + "-" + oSale.IdSale;
                    dbContext.Entry(oSale).State = System.Data.Entity.EntityState.Modified;

                    dbContext.SaveChanges();

                    int contador = 0;
                    foreach (DataGridViewRow dg in dgvProductos.Rows)
                    {
                        string h = Convert.ToString(dg.Cells["Articulo"].Value);
                        if (listaDes.Contains(h))
                        {

                            int id = listaDes.IndexOf(dg.Cells["Articulo"].Value.ToString());

                            oSaleProduct = new Models.SaleProduct
                            {
                                idProduct = listIdProducts.ElementAt(id),
                                idSale = oSale.IdSale,
                                cant = Convert.ToInt32(dgvProductos.Rows[contador].Cells["Cantidad"].Value),
                                summary = Convert.ToInt32(dgvProductos.Rows[contador].Cells["Importe"].Value)

                            };
                            oProduct = dbContext.Products.Find(oSaleProduct.idProduct);
                            oProduct.cant = oProduct.cant - oSaleProduct.cant;
                            dbContext.Entry(oProduct).State = System.Data.Entity.EntityState.Modified;
                            dbContext.SaveChanges();
                            contador++;
                            dbContext = new Models.ProyectoLab3Entities();
                            dbContext.SaleProducts.Add(oSaleProduct);
                            dbContext.SaveChanges();

                        }
                    }

                    dbContext.SaveChanges();

                    MessageBox.Show("Venta Cargada", "Aviso", MessageBoxButtons.OK);
                }


            }
        }
        int indCliente;

        //int idg = 0;


        //CARGAR PRODUCTOS
        private void nudCantidadProducto_ValueChanged(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count != 0)
            {
                if (posicion != -1)
                {
                    actualizarImporte(Convert.ToInt32(nudCantidadProducto.Value), oProduct.price);

                    dgvProductos.Rows[contData].Cells["Cantidad"].Value = nudCantidadProducto.Value;
                    dgvProductos.Rows[contData].Cells["Importe"].Value = nudCantidadProducto.Value * oProduct.price;
                }
                else
                {
                    posicion = -1;
                    dgvProductos.Rows[contData].Cells["Cantidad"].Value = dgvProductos.Rows[contData].Cells["Cantidad"].Value;
                    nudCantidadProducto.Value = Convert.ToDecimal(dgvProductos.Rows[contData].Cells["Cantidad"].Value);

                }

            }
        }

        private void cboCodigoBarra_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            //int pos = cboCodigoBarra.SelectedIndex;
            //oProduct = prodcuts.ElementAt(pos);
            int cant = oProduct.cant;
            nudCantidadProducto.Maximum = cant;

            actualizarDescripcion();

            //posicion = listaDes.IndexOf(cboCodigoBarra.Text);

            if (posicion == -1)
            {
                dgvProductos.Rows.Add();
                contData = dgvProductos.Rows.Count - 1;
                importeTotal = importeTotal + oProduct.price;
                tbTotalVenta.Text = Convert.ToString(importeTotal);
               
                dgvProductos.Rows[contData].Cells["Cantidad"].Value = 1;
                dgvProductos.Rows[contData].Cells["Precio"].Value = oProduct.price;
                dgvProductos.Rows[contData].Cells["Importe"].Value = oProduct.price;
                nudCantidadProducto.Value = 1;
                formatDGV();


            }
            else
            {
                contData = posicion;
                dgvProductos.Rows[posicion].Selected = true;

                nudCantidadProducto.Value = Convert.ToDecimal(dgvProductos.Rows[posicion].Cells["Cantidad"].Value);
            }

            actualizarDescripcion();
            posicion = contData;




        }

        // MODIFICAR
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(nudCantidadProducto.Value) == 0)
            {
                MessageBox.Show("Ingrese Cantidad", "Aviso", MessageBoxButtons.OK);
            }


            else if (dtpFechaVenta.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Fecha Invalida", "Aviso", MessageBoxButtons.OK);
            }
            else
            {

            }
        }

        // VOLVER ATRAS
        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }







        private void dgvProductos_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            contData = dgvProductos.Rows.Count - 1;

            actualizarImporte(Convert.ToInt32(nudCantidadProducto.Value) * -1, oProduct.price);
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
                pnlAgregarCliente.Visible = true;
                tbNombreCliente.Text = dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[1].Value.ToString() + " " + dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[2].Value.ToString();
            }
        }
    }
}
