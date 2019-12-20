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

namespace proyecto
{
    public partial class frmFactura : Form
    {
        clsCliente cliente;
        clsPersona persona;
        clsRegistoVentas Venta;
        clsProducto producto;
        clsEmpleado empleado;
        string numeroFactura;
        

        public frmFactura(string numeroFactura)
        {
            this.numeroFactura = numeroFactura;
            InitializeComponent();

        }

        private string toText(double value)
        {
            string Num2Text = "";
            value = Math.Truncate(value);
            if (value == 0) Num2Text = "CERO";
            else if (value == 1) Num2Text = "UNO";
            else if (value == 2) Num2Text = "DOS";
            else if (value == 3) Num2Text = "TRES";
            else if (value == 4) Num2Text = "CUATRO";
            else if (value == 5) Num2Text = "CINCO";
            else if (value == 6) Num2Text = "SEIS";
            else if (value == 7) Num2Text = "SIETE";
            else if (value == 8) Num2Text = "OCHO";
            else if (value == 9) Num2Text = "NUEVE";
            else if (value == 10) Num2Text = "DIEZ";
            else if (value == 11) Num2Text = "ONCE";
            else if (value == 12) Num2Text = "DOCE";
            else if (value == 13) Num2Text = "TRECE";
            else if (value == 14) Num2Text = "CATORCE";
            else if (value == 15) Num2Text = "QUINCE";
            else if (value < 20) Num2Text = "DIECI" + toText(value - 10);
            else if (value == 20) Num2Text = "VEINTE";
            else if (value < 30) Num2Text = "VEINTI" + toText(value - 20);
            else if (value == 30) Num2Text = "TREINTA";
            else if (value == 40) Num2Text = "CUARENTA";
            else if (value == 50) Num2Text = "CINCUENTA";
            else if (value == 60) Num2Text = "SESENTA";
            else if (value == 70) Num2Text = "SETENTA";
            else if (value == 80) Num2Text = "OCHENTA";
            else if (value == 90) Num2Text = "NOVENTA";
            else if (value < 100) Num2Text = toText(Math.Truncate(value / 10) * 10) + " Y " + toText(value % 10);
            else if (value == 100) Num2Text = "CIEN";
            else if (value < 200) Num2Text = "CIENTO " + toText(value - 100);
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = toText(Math.Truncate(value / 100)) + "CIENTOS";
            else if (value == 500) Num2Text = "QUINIENTOS";
            else if (value == 700) Num2Text = "SETECIENTOS";
            else if (value == 900) Num2Text = "NOVECIENTOS";
            else if (value < 1000) Num2Text = toText(Math.Truncate(value / 100) * 100) + " " + toText(value % 100);
            else if (value == 1000) Num2Text = "MIL";
            else if (value < 2000) Num2Text = "MIL " + toText(value % 1000);
            else if (value < 1000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000)) + " MIL";
                if ((value % 1000) > 0) Num2Text = Num2Text + " " + toText(value % 1000);
            }

            else if (value == 1000000) Num2Text = "UN MILLON";
            else if (value < 2000000) Num2Text = "UN MILLON " + toText(value % 1000000);
            else if (value < 1000000000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000000)) + " MILLONES ";
                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000) * 1000000);
            }

            else if (value == 1000000000000) Num2Text = "UN BILLON";
            else if (value < 2000000000000) Num2Text = "UN BILLON " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);

            else
            {
                Num2Text = toText(Math.Truncate(value / 1000000000000)) + " BILLONES";
                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            }
            return Num2Text;

        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
             Venta = new clsRegistoVentas();
             cliente = new clsCliente();
             producto = new clsProducto();
            empleado = new clsEmpleado();

            lblFacturaNumero.Text = ("N° " + numeroFactura).ToString();
           
            tbEmpleadoNombre.ReadOnly = true;
            tbClienteNombre.ReadOnly = true;
            tbEmpleadoCuil.ReadOnly = true;
            tbFacturaFecha.ReadOnly = true;
            tbFacturaSubTotal.ReadOnly = true;
            tbFechaVencimiento.ReadOnly = true;
           
            Venta = Venta.buscarVenta(numeroFactura);
            
            tbEmpleadoNombre.Text = Venta.NombreVendedor;            
            tbFacturaFecha.Text = Venta.FechaVenta;
            tbClienteNombre.Text = Venta.NombreCliente;
            tbFacturaFecha.Text = Venta.FechaVenta;
            DateTime fecha = Convert.ToDateTime( Venta.FechaVenta).AddDays(60);
            tbFechaVencimiento.Text = fecha.ToString("dd/MM/yyyy");
            
            tbClienteCuil.Text = "27 - 39.789.789 - 2 ";
            tbEmpleadoCuil.Text = "28 - 16.689.321 - 1 ";
                                   

            dgvFacturaVenta.DataSource = Venta.devolverProductos(numeroFactura);

            dgvFacturaVenta.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            dgvFacturaVenta.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            dgvFacturaVenta.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            dgvFacturaVenta.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvFacturaVenta.Columns[0].Visible = false;
            dgvFacturaVenta.Columns[6].Visible = false;
           
            dgvFacturaVenta.Columns[4].HeaderText= "Precio Unitario";
            dgvFacturaVenta.Columns.Add("colPrecioTotal", "Monto Total");
            dgvFacturaVenta.Columns[4].DefaultCellStyle.Format = "$##,#0.00";
            dgvFacturaVenta.Columns["colPrecioTotal"].DefaultCellStyle.Format = "$##,#0.00";
            int indice = 0;
            dgvFacturaVenta.Columns[2].HeaderText = "Codigo Barras";
            foreach (clsProducto c in Venta.devolverProductos(numeroFactura))
            {           
                dgvFacturaVenta.Rows[indice++].Cells["colPrecioTotal"].Value =  c.Precio * c.Cantidad;
                 
            }
            double totalMonto = 0;

            foreach (DataGridViewRow row in dgvFacturaVenta.Rows)
            {
                totalMonto = Convert.ToDouble(row.Cells["colPrecioTotal"].Value) + totalMonto;
            }

            lblSubTotal.Text = toText(totalMonto);

            tbFacturaSubTotal.Text = "$ " + Convert.ToString(totalMonto) + ",00" ;


            tbIva.Text = "$ " + Convert.ToString((totalMonto * 21) / 100) + ",00";
            

            totalMonto = (totalMonto * 21 / 100) + totalMonto;
            
            tbTotalFinal.Text = "$ " +Convert.ToString(totalMonto) + ",00";

            lblTotalFinal.Text = toText(totalMonto);
            
            
            
            
              


            tbFacturaSubTotal.ReadOnly = true;
           
        }

        private void tbFacturaTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAtrasFactura_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbClienteApellido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
