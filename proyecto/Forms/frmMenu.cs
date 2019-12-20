using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace proyecto
{
    public partial class frmMenu : Form
    {

        frmAgregarEmpleado agregarEmpleado;
        frmAgregarCliente agregarCliente;
        frmAgregarVenta agregarVenta;
        frmAgregarProductos agregarProductos;
        proyecto.Forms.frmVentas frmVentas;

        int indice;
        int panelBusqueda;
        int indiceDGV;

        Models.ProyectoLab3Entities dbContext;
        Models.Employee oEmpleado = new Models.Employee();
        Models.Employer oEmpleador = new Models.Employer();
        Models.Person oPerson;
        int click;

        // Constructor

        
        public frmMenu(int id)
        {
            InitializeComponent();
            dbContext = new Models.ProyectoLab3Entities();
            ucDatosEmpleador1.setPanel(pnlMostrarDatosEmpleador);
            //ucEmpleado1.setPanel(pnlMostrarDatosEmpleado);

            this.oPerson = dbContext.People.Find(id);

            try
            {
                oEmpleador = BuscarEmpleador(oPerson.idPerson);
                oEmpleado = BuscarEmpleado(oPerson.idPerson);

                if (oEmpleador != null)
                {
                    pnlEmpleados.Enabled = false;
                    ucDatosEmpleador1.setEmployer(oEmpleador, oPerson, this);
                }
                else
                {
                    pnlEmpleador.Enabled = false;
                    //ucEmpleado1.setEmployee(oEmpleado, oPerson, this);
                }

            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            tbBuscar.ReadOnly = false;



        }

        // LOAD FORMULARIO

        private void frmMenu_Load(object sender, EventArgs e)
        {
            pnlEmpleadorMenu.Visible = false;
            pnlEmpleadoMenu.Visible = false;
            pnlMostrarDatosEmpleado.Visible = false;
            pnlMostrarDatosEmpleador.Visible = false;
            pnlMostrarDatos.Visible = false;

            pnlFiltro.Visible = false;

            dgvDatos.ReadOnly = true;

            ucDatosEmpleador1.setPanel(pnlMostrarDatosEmpleador);
            ucDatosEmpleador1.setForm(this);
            //ucEmpleado1.setPanel(pnlMostrarDatosEmpleado);

        }

        // Procedimiento - Funciones
        public void setEmpleador(int id)
        {
            this.oPerson = dbContext.People.Find(id);
            oEmpleador = BuscarEmpleador(oPerson.idPerson);
            ucDatosEmpleador1.setEmployer(oEmpleador, oPerson, this);
            ucDatosEmpleador1.setEmployer(oEmpleador, oPerson, this);
        }
        public Models.Employer BuscarEmpleador(int idPerson)
        {
            try
            {
                dbContext = new Models.ProyectoLab3Entities();
                oEmpleador = dbContext.Employers.Find(idPerson);

                return oEmpleador;
            }
            catch (IOException EX)
            {
                return null;
            }


        }

        public Models.Employee BuscarEmpleado(int idPerson)
        {
            try
            {
                dbContext = new Models.ProyectoLab3Entities();
                oEmpleado = dbContext.Employees.Find(idPerson);
                return oEmpleado;
            }
            catch (IOException EX)
            {
                return null;
            }
        }

        public void agregar()
        {
            switch (click)
            {
                case 1: //empleados
                    agregarEmpleado = new frmAgregarEmpleado();
                    agregarEmpleado.ShowDialog();
                    break;
                case 2: //clientes
                    agregarCliente = new frmAgregarCliente();
                    agregarCliente.ShowDialog();
                    break;
                case 3: //ventas
                    frmVentas = new Forms.frmVentas(oPerson);
                    frmVentas.ShowDialog();
                    //agregarVenta = new frmAgregarVenta(oPerson);
                    //agregarVenta.ShowDialog();
                    break;
                case 4: //productos
                    agregarProductos = new frmAgregarProductos();
                    agregarProductos.ShowDialog();
                    break;


            }

        }

        public void buscar()
        {
            //switch (click)
            //{
            //    case 1: //empleados
            //        agregarEmpleado = new frmAgregarEmpleado();
            //        agregarEmpleado.ShowDialog();
            //        break;
            //    case 2: //clientes
            //        agregarCliente = new frmAgregarCliente();
            //        agregarCliente.ShowDialog();
            //        break;
            //    case 3: //ventas
            //        agregarVenta = new frmAgregarVenta(oPerson);
            //        agregarVenta.ShowDialog();
            //        break;
            //    case 4: //productos
            //        agregarProductos = new frmAgregarProductos();
            //        agregarProductos.ShowDialog();
            //        break;
            //}

        }

        public void listarAltas()
        {
            dgvDatos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            switch (click)
            {
                case 1: //empleados                    
                    dgvDatos.DataSource = dbContext.Employees.GroupJoin(dbContext.People, emp => emp.IdPerson, peo => peo.idPerson, (emp, per) => new { per, emp }).Select(x => new { Id = x.emp.IdPerson, Apellido = x.emp.Person.firstName, Nombre = x.emp.Person.lastName, Sexo = x.emp.Person.sex, x.emp.Person.type, x.emp.Person.documentNumber, Direccion = x.emp.Person.dress, Email = x.emp.Person.email, Telefono = x.emp.Person.telephone, Usuario = x.emp.userName, Sueldo = x.emp.salary, x.emp.Person.state }).Where(x => x.state == 1).ToList();
                    dgvDatos.Columns[3].HeaderText = "Tipo Documento";
                    dgvDatos.Columns[3].Width = 150;
                    dgvDatos.Columns[4].HeaderText = "Numero Documento";
                    dgvDatos.Columns[4].Width = 150;
                    dgvDatos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                    dgvDatos.Columns[5].Width = 150;
                    dgvDatos.Columns[6].Width = 150;
                    dgvDatos.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                    dgvDatos.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                    dgvDatos.Columns[9].DefaultCellStyle.Format = "$##,#0.00";
                    dgvDatos.Columns[10].Visible = false;
                    break;
                case 2: //clientes

                    dgvDatos.DataSource = dbContext.Clients.GroupJoin(dbContext.People, cli => cli.idPerson, peo => peo.idPerson, (cli, per) => new { per, cli }).Select(x => new { x.cli.Person.idPerson, Apellido = x.cli.Person.firstName, Nombre = x.cli.Person.lastName, Sexo = x.cli.Person.sex, x.cli.Person.type, x.cli.Person.documentNumber, Direccion = x.cli.Person.dress, Email = x.cli.Person.email, Telefono = x.cli.Person.telephone, x.cli.Person.state }).Where(x => x.state == 1).ToList();

                    dgvDatos.Columns[0].Visible = false;
                    dgvDatos.Columns[4].HeaderText = "Tipo Documento";
                    dgvDatos.Columns[4].Width = 150;
                    dgvDatos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                    dgvDatos.Columns[5].HeaderText = "Numero Documento";
                    dgvDatos.Columns[5].Width = 150;
                    dgvDatos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                    dgvDatos.Columns[6].Width = 150;
                    dgvDatos.Columns[7].Width = 150;
                    dgvDatos.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                    break;
                case 3: //ventas
                    var sales = (from Sale in dbContext.Sales
                                 from Prod in dbContext.Products
                                 from Cliente in dbContext.Clients
                                 from Person in dbContext.People
                                 where Sale.idProduct == Prod.idProduct && Sale.idPerson == Person.idPerson && Sale.idClient == Cliente.idPerson && Sale.state == 1
                                 orderby Sale.saleNumber
                                 select new
                                 {
                                     Sale.IdSale,
                                     Sale.saleNumber,
                                     Vendedor = Person.firstName,
                                     Cliente = Cliente.Person.firstName,
                                     Fecha = Sale.saleDate,
                                     Total = Sale.summary,
                                     Sale.state



                                 }).Distinct().OrderBy(x => x.saleNumber);



                    ArrayList lista = new ArrayList();

                    dgvDatos.DataSource = sales.ToList();
                    dgvDatos.Columns[0].Visible = false;
                    dgvDatos.Columns[1].HeaderText = "N° Factura";
                    dgvDatos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                    dgvDatos.Columns[5].DefaultCellStyle.Format = "$##,#0.00";
                    dgvDatos.Columns[6].Visible = false;
                    break;
                case 4: //productos

                    dgvDatos.DataSource = dbContext.Products.Select(x => new { x.idProduct, x.barcode, Categoria = x.categorie, Descripcion = x.description, Cantidad = x.cant, Precio = x.price, x.state }).Where(x => x.state == 1).ToList();

                    dgvDatos.Columns[1].HeaderText = "Codigo de barras";
                    dgvDatos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                    dgvDatos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                    dgvDatos.Columns[5].DefaultCellStyle.Format = "$##,#0.00";
                    dgvDatos.Columns[6].Visible = false;

                    break;


            }

        }
        public void listarBajas()
        {
            dgvDatos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            switch (click)
            {
                case 1: //empleados                    
                    dgvDatos.DataSource = dbContext.Employees.GroupJoin(dbContext.People, emp => emp.IdPerson, peo => peo.idPerson, (emp, per) => new { per, emp }).Select(x => new { Id = x.emp.IdPerson, Apellido = x.emp.Person.firstName, Nombre = x.emp.Person.lastName, Sexo = x.emp.Person.sex, x.emp.Person.type, x.emp.Person.documentNumber, Direccion = x.emp.Person.dress, Email = x.emp.Person.email, Telefono = x.emp.Person.telephone, Usuario = x.emp.userName, Sueldo = x.emp.salary, x.emp.Person.state }).Where(x => x.state == 0).ToList();
                    dgvDatos.Columns[3].HeaderText = "Tipo Documento";
                    dgvDatos.Columns[3].Width = 150;
                    dgvDatos.Columns[4].HeaderText = "Numero Documento";
                    dgvDatos.Columns[4].Width = 150;
                    dgvDatos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                    dgvDatos.Columns[5].Width = 150;
                    dgvDatos.Columns[6].Width = 150;
                    dgvDatos.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                    dgvDatos.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                    dgvDatos.Columns[9].DefaultCellStyle.Format = "$##,#0.00";
                    dgvDatos.Columns[10].Visible = false;
                    break;
                case 2: //clientes

                    dgvDatos.DataSource = dbContext.Clients.GroupJoin(dbContext.People, cli => cli.idPerson, peo => peo.idPerson, (cli, per) => new { per, cli }).Select(x => new { x.cli.Person.idPerson, Apellido = x.cli.Person.firstName, Nombre = x.cli.Person.lastName, Sexo = x.cli.Person.sex, x.cli.Person.type, x.cli.Person.documentNumber, Direccion = x.cli.Person.dress, Email = x.cli.Person.email, Telefono = x.cli.Person.telephone, x.cli.Person.state }).Where(x => x.state == 0).ToList();

                    dgvDatos.Columns[0].Visible = false;
                    dgvDatos.Columns[4].HeaderText = "Tipo Documento";
                    dgvDatos.Columns[4].Width = 150;
                    dgvDatos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                    dgvDatos.Columns[5].HeaderText = "Numero Documento";
                    dgvDatos.Columns[5].Width = 150;
                    dgvDatos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                    dgvDatos.Columns[6].Width = 150;
                    dgvDatos.Columns[7].Width = 150;
                    dgvDatos.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                    break;
                case 3:
                    var sales = (from Sale in dbContext.Sales
                                 from Prod in dbContext.Products
                                 from Cliente in dbContext.Clients
                                 from Person in dbContext.People
                                 where Sale.idProduct == Prod.idProduct && Sale.idPerson == Person.idPerson && Sale.idClient == Cliente.idPerson && Sale.state == 0
                                 orderby Sale.saleNumber
                                 select new
                                 {
                                     Sale.IdSale,
                                     Sale.saleNumber,
                                     Vendedor = Person.firstName,
                                     Cliente = Cliente.Person.firstName,
                                     Fecha = Sale.saleDate,
                                     Total = Sale.summary,
                                     Sale.state



                                 }).Distinct().OrderBy(x => x.saleNumber);

                    ArrayList lista = new ArrayList();

                    dgvDatos.DataSource = sales.ToList();

                    dgvDatos.Columns[0].Visible = false;
                    dgvDatos.Columns[1].HeaderText = "N° Factura";
                    dgvDatos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                    dgvDatos.Columns[5].DefaultCellStyle.Format = "$##,#0.00";
                    dgvDatos.Columns[6].Visible = false;

                    break;
                case 4: //productos

                    dgvDatos.DataSource = dbContext.Products.Select(x => new { x.idProduct, x.barcode, Categoria = x.categorie, Descripcion = x.description, Cantidad = x.cant, Precio = x.price, x.state }).Where(x => x.state == 0).ToList();

                    dgvDatos.Columns[1].HeaderText = "Codigo de barras";
                    dgvDatos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                    dgvDatos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                    dgvDatos.Columns[5].DefaultCellStyle.Format = "$##,#0.00";
                    dgvDatos.Columns[6].Visible = false;

                    break;


            }

        }

        public void modificar()
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciones una fila para Modificar", "Aviso");

            }
            else
            {
                int idModificar = int.Parse(dgvDatos.Rows[dgvDatos.CurrentRow.Index].Cells[0].Value.ToString());
                switch (click)
                {
                    case 1:
                        agregarEmpleado = new frmAgregarEmpleado(idModificar);
                        agregarEmpleado.ShowDialog();
                        break;
                    case 2:
                        agregarCliente = new frmAgregarCliente(idModificar);
                        agregarCliente.ShowDialog();
                        break;
                    case 3:
                        agregarVenta = new frmAgregarVenta(idModificar);
                        agregarVenta.ShowDialog();
                        break;
                    case 4:
                        Models.Product prod = dbContext.Products.Find(idModificar);
                        agregarProductos = new frmAgregarProductos(idModificar);
                        agregarProductos.ShowDialog();
                        break;
                }
            }
        }

        /////////////////////////////// EMPLEADOR-EMPLEADOS //////////////////////////////////

        private void pnlEmpleador_Click(object sender, EventArgs e)
        {
            if (pnlEmpleadorMenu.Visible)
            {
                pnlEmpleadorMenu.Visible = false;
            }
            else
            {
                pnlEmpleadorMenu.Visible = true;

                pnlMostrarDatosEmpleado.Visible = false;
                pnlMostrarDatosEmpleador.Visible = false;
                pnlMostrarDatos.Visible = false;

            }



        }

        private void pnlDatosEmpleador_Click(object sender, EventArgs e)
        {
            pnlEmpleadorMenu.Visible = false;
            ucDatosEmpleador1.Visible = true;

            pnlMostrarDatosEmpleador.Visible = true;
        }

        private void pnlAgregar_Click(object sender, EventArgs e)
        {
            agregar();
        }

        private void pnlListarBajaEmpleado_Click(object sender, EventArgs e)
        {
            panelBusqueda = 1;
            listarBajas();



        }

        private void pnlListarAltaEmpleado_Click(object sender, EventArgs e)
        {
            listarAltas();
            buscar();
        }

        private void pnlEmpleadosEmpleador_Click(object sender, EventArgs e)
        {
            click = 1;
            listarAltas();
            pnlEmpleadorMenu.Visible = false;
            pnlMostrarDatos.Visible = true;
            lblDatos.Text = "EMPLEADOS";
            pnlModificar.Visible = true;
            lblModificar_filtrar.Text = "Modificar";
            pnlFiltrar.Visible = false;
            lblFiltro.Visible = false;
            pnlBuscar.Visible = true;
            tbBuscar.Visible = true;


        }

        private void pnlDatosEmpleador_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlModificarEmpleado_Click(object sender, EventArgs e)
        {
            modificar();

        }

        /////////////////////////////// CLIENTES //////////////////////////////////

        private void pnlClientes_Click(object sender, EventArgs e)
        {
            click = 2;
            listarAltas();
            pnlMostrarDatos.Visible = true;
            lblDatos.Text = "CLIENTES";
            pnlModificar.Visible = true;
            lblModificar_filtrar.Text = "Modificar";
            pnlFiltrar.Visible = false;
            pnlBuscar.Visible = true;
            tbBuscar.Visible = true;
            lblFiltro.Visible = false;

            pnlEmpleadorMenu.Visible = false;
            pnlMostrarDatosEmpleado.Visible = false;
            pnlMostrarDatosEmpleador.Visible = false;





        }

        //////////////////////////// EMPLEADO /////////////////////////////////

        private void pnlEmpleados_Click(object sender, EventArgs e)
        {
            if (pnlEmpleadoMenu.Visible)
            {
                pnlEmpleadoMenu.Visible = false;

            }
            else
            {
                lblFiltro.Visible = false;
                pnlEmpleadoMenu.Visible = true;
                pnlMostrarDatos.Visible = false;
                pnlMostrarDatosEmpleado.Visible = false;

            }
        }

        private void pnlDatosEmpleado_Click(object sender, EventArgs e)
        {
            pnlEmpleadoMenu.Visible = false;
            pnlMostrarDatosEmpleado.Visible = true;
            pnlEmpleadoMenu.Visible = false;
            //ucEmpleado1.Visible = true;


        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //pnlMostrarDatosEmpleador.Visible = false;

            //pnlMostrarDatos.Visible = false;
            //pnlMostrarDatosEmpleado.Visible = false;
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indiceDGV = e.RowIndex;
        }

        //////////////////////////// PRODUCTOS /////////////////////////////////

        private void pnlProductos_Click(object sender, EventArgs e)
        {
            click = 4;
            listarAltas();
            pnlMostrarDatos.Visible = true;
            lblDatos.Text = "PRODUCTOS";
            pnlModificar.Visible = true;
            lblModificar_filtrar.Text = "Modificar";
            pnlFiltrar.Visible = false;
            pnlBuscar.Visible = true;
            tbBuscar.Visible = true;
            lblFiltro.Visible = false;




        }

        //////////////////////////// VENTAS /////////////////////////////////

        private void pnlVentas_Click(object sender, EventArgs e)
        {
            click = 3;
            listarAltas();
            pnlMostrarDatos.Visible = true;
            lblDatos.Text = "REGISTRO VENTAS";


            pnlBuscar.Visible = false;
            pnlFiltrar.Visible = true;
            tbBuscar.Visible = false;


            pnlEmpleadoMenu.Visible = false;
            pnlEmpleadorMenu.Visible = false;
            pnlEmpleadorMenu.Visible = false;


        }



        private void rbMostrarTodo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVentas.Checked)
            {
                //    tbBuscarCodigo.Enabled = false;
                //    lblBuscarCodigo.Enabled = false;
                //    lbListarNombres.Visible = false;
            }
            else
            {
                //tbBuscarCodigo.Enabled = true;
                lblBuscarCodigo.Enabled = true;
            }

        }

        private void rbEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEmpleado.Checked)
            {
                //tbBuscarCodigo.Enabled = true;
                lblBuscarCodigo.Enabled = true;
            }
        }

        private void rbCliente_CheckedChanged(object sender, EventArgs e)
        {
            //if (rbEmpleado.Checked)
            //{
            //    tbBuscarCodigo.Enabled = true;
            //    lblBuscarCodigo.Enabled = true;
            //}

        }

        private void btnCerrarCesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cerrar cesion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmIncioSesion inicioCesion = new frmIncioSesion();
                this.Hide();
                inicioCesion.ShowDialog();

            }


        }

        private void pnlFiltrar_Click(object sender, EventArgs e)
        {
            if (pnlFiltro.Visible)
            {
                pnlFiltro.Visible = false;
            }
            else
            {
                pnlFiltro.Visible = true;
            }
        }

        private void pnlCerrar_Click(object sender, EventArgs e)
        {
            pnlFiltro.Visible = false;
        }

        public static void cerrar(Panel pnl)
        {
            pnl.Visible = false;

        }

        private void pnlCerrar_MouseMove(object sender, MouseEventArgs e)
        {
            pnlCerrar.BackgroundImage = proyecto.Properties.Resources.boton_rojo;
            pnlCerrar.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void pnlCerrar_MouseLeave(object sender, EventArgs e)
        {
            pnlCerrar.BackgroundImage = proyecto.Properties.Resources.boton_cerrar;
            pnlCerrar.BackgroundImageLayout = ImageLayout.Stretch;
        }


        private void pnlEmpleadosEmpleador_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            //    (dgvDatos.DataSource as DataTable).DefaultView.RowFilter = string.Format
            //   ("Nombre LIKE '%{0}%' OR rfc LIKE '%{0}%'", tbBuscar.Text);
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            pnlMostrarDatosEmpleador.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fi = new DateTime(2019,12,18);
            DateTime ff = new DateTime(2019, 12, 19);
            Forms.frmReport reporte = new Forms.frmReport();
            reporte.fechaIni = fi;
            reporte.fechaFin = ff;
            reporte.Show();
        }
    }


}

