using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Biblioteca
{
    public class clsRegistoVentas
    {
        clsEmpleador empleador;
        clsEmpleado empleado;
        clsCliente cliente;
        clsProducto producto;
        
        string nombreVendedor;
        string tipoPago;
        string nombreCliente;

        
        Double totalCompra;
        string fechaVenta;
        string codigoDeBarra;
        string codigoVendedor;
        int cantidad;
        private string numeroDeVenta;
        public double total = 0;

        const string PATH = "D:\\Proyecto\\Registro";
        const string DireccionRegistro = PATH + "\\" + "RegistroTotal";
        const string DireccionRegistroProductos= "D:\\Proyecto\\Registro\\Productos";
        const string DireccionRegistroEmpleados= PATH+"\\"+"VentaEmpleado";
        const string DirrecionRegistroClientes = PATH + "\\" + "RegistroCliente";

        FileStream fs;
        BinaryWriter bw;
       
        public string NumeroDeVenta
        {
            get { return numeroDeVenta; }
            set { numeroDeVenta = value; }
        }
        public string CodigoVendedor
        {
            get { return codigoVendedor; }
            set { codigoVendedor = value; }
        }
        public string NombreVendedor
        {
            get { return nombreVendedor; }
            set { nombreVendedor = value; }
        }
        public string NombreCliente
        {
            get { return nombreCliente; }
            set { nombreCliente = value; }
        }
         
        public string CodigoDeBarra
        {
            get { return codigoDeBarra; }
            set { codigoDeBarra = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
       public string TipoPago
        {
            get { return tipoPago; }
            set { tipoPago = value; }
        }
        public string FechaVenta
        {
            get { return fechaVenta; }
            set { fechaVenta = value; }
        }
        public Double TotalCompra
        {
            get { return totalCompra; }
            set { totalCompra = value; }
        }
        

        


        public clsRegistoVentas(string codigoDeBarra, string fechaVenta,string nombreVendedor, string codigoEmpleado,string tipoPago, string nombreCliente,double totalCompra, int cantidad)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.fechaVenta = fechaVenta;
            this.nombreCliente = nombreCliente;
            this.nombreVendedor = nombreVendedor;
            this.tipoPago = tipoPago;
            this.codigoVendedor = codigoEmpleado;
            this.totalCompra = totalCompra;
            this.cantidad = cantidad;
            if (!Directory.Exists(DireccionRegistro))
                Directory.CreateDirectory(DireccionRegistro);
            if (!Directory.Exists(DireccionRegistroEmpleados))
                Directory.CreateDirectory(DireccionRegistroEmpleados);
            if (!Directory.Exists(DirrecionRegistroClientes))
                Directory.CreateDirectory(DirrecionRegistroClientes);
            if(!Directory.Exists(DireccionRegistroProductos))
                Directory.CreateDirectory(DireccionRegistroProductos);
        }
        public clsRegistoVentas()
        {
            if (!Directory.Exists(DireccionRegistro))
                Directory.CreateDirectory(DireccionRegistro);
            if (!Directory.Exists(DireccionRegistroEmpleados))
                Directory.CreateDirectory(DireccionRegistroEmpleados);
            if (!Directory.Exists(DirrecionRegistroClientes))
                Directory.CreateDirectory(DirrecionRegistroClientes);
            if(!Directory.Exists(DireccionRegistroProductos))
                Directory.CreateDirectory(DireccionRegistroProductos);
        }

         public clsRegistoVentas(string codigoDeBarra, int cantidad, string numeroDeVenta)
        {
             this.codigoDeBarra= codigoDeBarra;
             this.cantidad= cantidad;
             this.numeroDeVenta=numeroDeVenta;

            if (!Directory.Exists(DireccionRegistro))
                Directory.CreateDirectory(DireccionRegistro);
            if (!Directory.Exists(DireccionRegistroEmpleados))
                Directory.CreateDirectory(DireccionRegistroEmpleados);
            if (!Directory.Exists(DirrecionRegistroClientes))
                Directory.CreateDirectory(DirrecionRegistroClientes);
            if(!Directory.Exists(DireccionRegistroProductos))
                Directory.CreateDirectory(DireccionRegistroProductos);
        }

        private bool modificarStock_Restar(string codigoBarra, int cantidad)
        {
            clsProducto producto = new clsProducto();
            producto = producto.Buscar(codigoBarra);
            if (producto != null)
            {
                producto.Cantidad = producto.Cantidad - cantidad;
                producto.Modificar(producto);
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool modificarStock_Sumar(string codigoBarra, int cantidad)
        {
            clsProducto producto = new clsProducto();
            producto = producto.Buscar(codigoBarra);
            if (producto != null)
            {
                producto.Cantidad = producto.Cantidad + cantidad;
                producto.Modificar(producto);
                return true;
            }
            else
            {
                return false;
            }
        }



        private string NVenta()
        {
            int numeroDeVentaA;

            if (!File.Exists("D:\\Proyecto\\numeroDeVenta.dat"))
            {
                fs = new FileStream("D:\\Proyecto\\numeroDeVenta.dat", FileMode.Create);
                bw = new BinaryWriter(fs);
                numeroDeVentaA = 1;
                numeroDeVenta ="0001-000"+ Convert.ToString(numeroDeVentaA);
                bw.Write(numeroDeVentaA);
                bw.Close();
                fs.Close();
                return numeroDeVenta;
            }
            else
            {
                fs = new FileStream("D:\\Proyecto\\numeroDeVenta.dat", FileMode.Open);
                BinaryReader br = new BinaryReader(fs);

                numeroDeVentaA = br.ReadInt32();
                numeroDeVentaA++;
                fs.Close();
                br.Close();
                if (numeroDeVentaA < 10)
                {
                    numeroDeVenta = "0001-000" + Convert.ToString(numeroDeVentaA);
                }
                else if (numeroDeVentaA < 100)
                {
                    numeroDeVenta = "0001-00" + Convert.ToString(numeroDeVentaA);
                }
                else if (numeroDeVentaA < 1000)
                {
                    numeroDeVenta = "0001-0" + Convert.ToString(numeroDeVentaA);
                }
                else
                {
                    numeroDeVenta = "0001-" + Convert.ToString(numeroDeVentaA);
                }


                fs = new FileStream("D:\\Proyecto\\numeroDeVenta.dat", FileMode.Create);
                bw = new BinaryWriter(fs);
                bw.Write(numeroDeVentaA);
                bw.Close();
                fs.Close();
                return numeroDeVenta;
            }

        }

        private void cargarVentaEmpleado()
        { 
            
         try
            {
                if (!File.Exists(DireccionRegistroEmpleados + "\\" + nombreVendedor + ".dat"))
                {

                    fs = new FileStream(DireccionRegistroEmpleados +"\\"+nombreVendedor+".dat", FileMode.Create);
                }

                else
                {
                    fs = new FileStream(DireccionRegistroEmpleados + "\\" + nombreVendedor + ".dat", FileMode.Append);
                }

                bw = new BinaryWriter(fs);

                bw.Write(totalCompra);
                bw.Write(tipoPago);
                bw.Write(codigoDeBarra);
                bw.Write(fechaVenta);
                bw.Write(nombreVendedor);
                bw.Write(nombreCliente);
                bw.Write(codigoVendedor);
                bw.Write(cantidad);
                bw.Write(numeroDeVenta);
              
            }
            catch (IOException ex)
            {
                
            }
            bw.Close();
            fs.Close();

            
        }

        private void cargarVentaCliente()
        {

            try
            {
                if (!File.Exists(DirrecionRegistroClientes + "\\" + nombreCliente + ".dat"))
                {

                    fs = new FileStream(DirrecionRegistroClientes +"\\"+ nombreCliente+".dat", FileMode.Create);
                }

                else
                {
                    fs = new FileStream(DirrecionRegistroClientes + "\\" + nombreCliente + ".dat", FileMode.Append);
                }

                bw = new BinaryWriter(fs);

                bw.Write(totalCompra);
                bw.Write(tipoPago);
                bw.Write(codigoDeBarra);
                bw.Write(fechaVenta);
                bw.Write(nombreVendedor);
                bw.Write(nombreCliente);
                bw.Write(codigoVendedor);
                bw.Write(cantidad);
                bw.Write(numeroDeVenta);

            }
            catch (IOException ex)
            {

            }
            bw.Close();
            fs.Close();


        }       
        
        public string cargarVenta(string numerodeVenta )
        {
            string res = string.Empty;
            
            modificarStock_Restar(codigoDeBarra, cantidad);

            if (numerodeVenta == string.Empty)
            {
                try
                {
                    NVenta();
                    cargarVentaEmpleado();
                    cargarVentaCliente();
                  
                    if (!File.Exists(DireccionRegistro + "\\" + "RegistrosTotales.dat"))
                    {

                        fs = new FileStream(DireccionRegistro + "\\" + "RegistrosTotales.dat", FileMode.Create);
                    }

                    else
                    {
                        fs = new FileStream(DireccionRegistro + "\\" + "RegistrosTotales.dat", FileMode.Append);
                    }

                    bw = new BinaryWriter(fs);

                    bw.Write(totalCompra);
                    bw.Write(tipoPago);
                    bw.Write(codigoDeBarra);
                    bw.Write(fechaVenta);
                    bw.Write(nombreVendedor);
                    bw.Write(nombreCliente);
                    bw.Write(codigoVendedor);
                    bw.Write(cantidad);
                    bw.Write(numeroDeVenta);

                }
                catch (IOException ex)
                {
                    res = ex.Message;
                }
            
                bw.Close();
                fs.Close();
            }

                producto = new clsProducto();
                producto = producto.Buscar(codigoDeBarra);
            try{
                 if (!File.Exists(DireccionRegistroProductos+"\\" + numeroDeVenta+".dat"))
            {
                fs = new FileStream(DireccionRegistroProductos+"\\" + numeroDeVenta+".dat", FileMode.Create);
            }

            else
            {
                fs = new FileStream(DireccionRegistroProductos+"\\" + numeroDeVenta+".dat", FileMode.Append);
            }

            bw = new BinaryWriter(fs);

            bw.Write(producto.Precio);
            bw.Write(producto.Descripcion);
            bw.Write(producto.Categoria);
            bw.Write(Cantidad);
            bw.Write(producto.CodigoDeBarras);
            
            }
        
        catch (IOException ex)
        {
            res = ex.Message;
        }
                bw.Close();
                fs.Close();

            return res;
        }

        public List<clsProducto> devolverProductos(string numerdeVenta)
        {
            List<clsProducto> registroVentas = new List<clsProducto>();

            try
            {
                FileStream fs = new FileStream(DireccionRegistroProductos + "\\" + numerdeVenta+".dat", FileMode.Open);
                BinaryReader br = new BinaryReader(fs);

                while (br.PeekChar() != -1)
                {
                    clsProducto pro = new clsProducto();

                    pro.Precio = br.ReadDouble();

                    pro.Descripcion = br.ReadString();
                    pro.Categoria = br.ReadString();
                    pro.Cantidad = br.ReadInt32();
                    pro.CodigoDeBarras = br.ReadString();



                    total = total + (pro.Cantidad* pro.Precio);

                    registroVentas.Add(pro);
                }
                br.Close();
                fs.Close();
            }

            catch (IOException ex)
            {
                registroVentas.Clear();
            }

            return registroVentas;
        
        }


        public List<clsRegistoVentas> devolverRegistroDeVentas()
        {
            List<clsRegistoVentas> registroVentas = new List<clsRegistoVentas>();

            try
            {
                FileStream fs = new FileStream(DireccionRegistro + "\\" + "RegistrosTotales.dat", FileMode.Open);
                BinaryReader br = new BinaryReader(fs);

                while (br.PeekChar() != -1)
                {
                    clsRegistoVentas vent = new clsRegistoVentas();

                    vent.totalCompra = br.ReadDouble();
                    vent.tipoPago = br.ReadString();
                    vent.codigoDeBarra = br.ReadString();
                    vent.fechaVenta = br.ReadString();
                    vent.nombreVendedor = br.ReadString();
                    vent.nombreCliente = br.ReadString();
                    vent.codigoVendedor = br.ReadString();
                    vent.cantidad = br.ReadInt32();
                    vent.numeroDeVenta = br.ReadString();

                    total = total + vent.TotalCompra;

                    registroVentas.Add(vent);
                }
                br.Close();
                fs.Close();
            }

            catch (IOException ex)
            {
                registroVentas.Clear();
            }

            return registroVentas;
        }

        public List<clsRegistoVentas> devolverVentasEmpleado(string nombreempleado)
        {
            List<clsRegistoVentas> ventas = new List<clsRegistoVentas>();

            try
            {
                FileStream fs = new FileStream(DireccionRegistroEmpleados + "\\" + nombreempleado + ".dat", FileMode.Open);
                BinaryReader br = new BinaryReader(fs);

                while (br.PeekChar() != -1)
                {
                    clsRegistoVentas pro = new clsRegistoVentas();

                    pro.totalCompra = br.ReadDouble();
                    pro.tipoPago = br.ReadString();
                    pro.codigoDeBarra = br.ReadString();
                    pro.fechaVenta = br.ReadString();
                    pro.nombreVendedor = br.ReadString();
                    pro.nombreCliente = br.ReadString();
                    pro.codigoVendedor = br.ReadString();
                    pro.cantidad = br.ReadInt32();
                    pro.numeroDeVenta = br.ReadString();

                    total = total + pro.totalCompra;
                    ventas.Add(pro);
                }
                br.Close();
                fs.Close();
            }

            catch (IOException ex)
            {
                ventas.Clear();
            }

            return ventas;
        }

        public List<clsRegistoVentas> devolverRegistroCliente(string nombrecliente)
        {
            List<clsRegistoVentas> ventas = new List<clsRegistoVentas>();

            try
            {
                FileStream fs = new FileStream(DirrecionRegistroClientes + "\\" + nombrecliente + ".dat", FileMode.Open);
                BinaryReader br = new BinaryReader(fs);

                while (br.PeekChar() != -1)
                {
                    clsRegistoVentas pro = new clsRegistoVentas();

                    pro.totalCompra = br.ReadDouble();
                    pro.tipoPago = br.ReadString();
                    pro.codigoDeBarra = br.ReadString();
                    pro.fechaVenta = br.ReadString();
                    pro.nombreVendedor = br.ReadString();
                    pro.nombreCliente = br.ReadString();
                    pro.codigoVendedor = br.ReadString();
                    pro.cantidad = br.ReadInt32();
                    pro.numeroDeVenta = br.ReadString();

                    total = total + pro.totalCompra;
                    ventas.Add(pro);
                }
                br.Close();
                fs.Close();
            }

            catch (IOException ex)
            {
                ventas.Clear();
            }

            return ventas;
        }

        //public string modificarVentasEmpleado(clsRegistoVentas modificado)
        //{
        //    string res = string.Empty;
        //    List<clsRegistoVentas> modificar = devolverVentasEmpleado(modificado.codigoEmpleado);
        //    int posicion = modificar.IndexOf(modificar.Find(e => e.numeroDeVenta == modificado.numeroDeVenta));
        //    modificar[posicion] = modificado;
        //    modificarRegistroCliente(modificado);
        //    modificarRegistro(modificado);

        //    try
        //    {

        //        fs = new FileStream(DireccionRegistroEmpleados + "\\" +  modificado.codigoEmpleado + ".dat", FileMode.Create);//revisar

        //        bw = new BinaryWriter(fs);

        //        foreach (clsRegistoVentas x in modificar)
        //        {

        //            bw.Write(x.totalCompra);
        //            bw.Write(x.tipoPago);
        //            bw.Write(x.codigoDeBarra);
        //            bw.Write(x.fechaVenta);
        //            bw.Write(x.nombreVendedor);
        //            bw.Write(x.codigoCliente);
        //            bw.Write(x.codigoEmpleado);
        //            bw.Write(x.cantidad);
        //            bw.Write(x.numeroDeVenta);
        //        }
        //        res = "Usuario modificado";
        //    }
        //    catch (IOException ex)
        //    {
        //        res = ex.Message;
        //    }
        //    fs.Close();
        //    bw.Close();

        //    return res;

        //}

        //public string modificarRegistroCliente(clsRegistoVentas modificado)
        //{
        //    string res = string.Empty;
        //    List<clsRegistoVentas> modificar = devolverRegistroCliente(Convert.ToString(modificado.codigoCliente));
        //    int posicion = modificar.IndexOf(modificar.Find(e => e.numeroDeVenta == modificado.numeroDeVenta));
        //    modificar[posicion] = modificado;
        //    modificarVentasEmpleado(modificado);
        //    modificarRegistro(modificado);

        //    try
        //    {

        //        fs = new FileStream(DirrecionRegistroClientes + "\\" +Convert.ToString( modificado.codigoCliente) + ".dat", FileMode.Create);//revisar

        //        bw = new BinaryWriter(fs);

        //        foreach (clsRegistoVentas x in modificar)
        //        {

        //            bw.Write(x.totalCompra);
        //            bw.Write(x.tipoPago);
        //            bw.Write(x.codigoDeBarra);
        //            bw.Write(x.fechaVenta);
        //            bw.Write(x.nombreVendedor);
        //            bw.Write(x.codigoCliente);
        //            bw.Write(x.codigoEmpleado);
        //            bw.Write(cantidad);
        //            bw.Write(x.numeroDeVenta);

        //        }
        //        res = "Usuario modificado";
        //    }
        //    catch (IOException ex)
        //    {
        //        res = ex.Message;
        //    }
        //    fs.Close();
        //    bw.Close();

        //    return res;

        //}

        public string modificarRegistro(clsRegistoVentas modificado, int diferenciaCantidad)
        {
            int total;
            if (diferenciaCantidad > modificado.Cantidad)
            {
                total = diferenciaCantidad - modificado.Cantidad;
            }
            else
            {
                total = modificado.Cantidad - diferenciaCantidad;
            }
            if (diferenciaCantidad < modificado.Cantidad)
            {
                modificarStock_Restar(modificado.CodigoDeBarra, total);
            }
            else
            {
                modificarStock_Sumar(modificado.CodigoDeBarra, total);
            }

            string res = string.Empty;
            List<clsRegistoVentas> modificar = devolverRegistroDeVentas();
            int posicion = modificar.IndexOf(modificar.Find(e => e.numeroDeVenta == modificado.numeroDeVenta));
            modificar[posicion] = modificado;


            try
            {

                fs = new FileStream(DireccionRegistro + "\\" + "RegistrosTotales.dat", FileMode.Create);//revisar

                bw = new BinaryWriter(fs);

                foreach (clsRegistoVentas x in modificar)
                {

                    bw.Write(x.totalCompra);
                    bw.Write(x.tipoPago);
                    bw.Write(x.codigoDeBarra);
                    bw.Write(x.fechaVenta);
                    bw.Write(x.nombreVendedor);
                    bw.Write(x.nombreCliente);
                    bw.Write(x.codigoVendedor);
                    bw.Write(x.cantidad);
                    bw.Write(x.numeroDeVenta);
                }
                res = "Usuario modificado";
            }
            catch (IOException ex)
            {
                res = ex.Message;
            }
            fs.Close();
            bw.Close();
            

            //Modificar registro empleado
            
            modificar = devolverVentasEmpleado(modificado.codigoVendedor);
            posicion = modificar.IndexOf(modificar.Find(e => e.numeroDeVenta == modificado.numeroDeVenta));
            modificar[posicion] = modificado;

            try
            {

                fs = new FileStream(DireccionRegistroEmpleados + "\\" + modificado.codigoVendedor + ".dat", FileMode.Create);//revisar

                bw = new BinaryWriter(fs);

                foreach (clsRegistoVentas x in modificar)
                {

                    bw.Write(x.totalCompra);
                    bw.Write(x.tipoPago);
                    bw.Write(x.codigoDeBarra);
                    bw.Write(x.fechaVenta);
                    bw.Write(x.nombreVendedor);
                    bw.Write(x.nombreCliente);
                    bw.Write(x.codigoVendedor);
                    bw.Write(x.cantidad);
                    bw.Write(x.numeroDeVenta);
                }
                res = "Usuario modificado";
            }
            catch (IOException ex)
            {
                res = ex.Message;
            }
            fs.Close();
            bw.Close();
            
            //Modificar registro cliente

            modificar = devolverRegistroCliente(Convert.ToString(modificado.nombreCliente));
            posicion = modificar.IndexOf(modificar.Find(e => e.numeroDeVenta == modificado.numeroDeVenta));
            modificar[posicion] = modificado;
            try
            {

                fs = new FileStream(DirrecionRegistroClientes + "\\" + Convert.ToString(modificado.nombreCliente) + ".dat", FileMode.Create);//revisar

                bw = new BinaryWriter(fs);

                foreach (clsRegistoVentas x in modificar)
                {

                    bw.Write(x.totalCompra);
                    bw.Write(x.tipoPago);
                    bw.Write(x.codigoDeBarra);
                    bw.Write(x.fechaVenta);
                    bw.Write(x.nombreVendedor);
                    bw.Write(x.nombreCliente);
                    bw.Write(x.codigoVendedor);
                    bw.Write(cantidad);
                    bw.Write(x.numeroDeVenta);

                }
                res = "Usuario modificado";
            }
            catch (IOException ex)
            {
                res = ex.Message;
            }
            fs.Close();
            bw.Close();

            return res;
        }

        public List<clsRegistoVentas> devolverRegistroDeVentasPorFecha(string fecha)
        {
            List<clsRegistoVentas> registroVentas = new List<clsRegistoVentas>();

            try
            {
                FileStream fs = new FileStream(DireccionRegistro + "\\" + "RegistrosTotales.dat", FileMode.Open);
                BinaryReader br = new BinaryReader(fs);

                while (br.PeekChar() != -1)
                {
                    clsRegistoVentas vent = new clsRegistoVentas();

                    vent.totalCompra = br.ReadDouble();
                    vent.tipoPago = br.ReadString();
                    vent.codigoDeBarra = br.ReadString();
                    vent.fechaVenta = br.ReadString();
                    vent.nombreVendedor = br.ReadString();
                    vent.nombreCliente = br.ReadString();
                    vent.codigoVendedor = br.ReadString();
                    vent.cantidad = br.ReadInt32();
                    vent.numeroDeVenta = br.ReadString();

                    if (vent.fechaVenta == fecha)
                    {
                        registroVentas.Add(vent);
                        total = total + vent.totalCompra;
                    }
                }
                br.Close();
                fs.Close();
            }

            catch (IOException ex)
            {
                registroVentas.Clear();
            }

            return registroVentas;
        }

        public List<clsRegistoVentas> devolverVentasEmpleadoPorFecha(string nombreempleado, string fecha)
        {
            List<clsRegistoVentas> ventas = new List<clsRegistoVentas>();
            

            try
            {
                FileStream fs = new FileStream(DireccionRegistroEmpleados + "\\" + nombreempleado + ".dat", FileMode.Open);
                BinaryReader br = new BinaryReader(fs);

                while (br.PeekChar() != -1)
                {
                    clsRegistoVentas pro = new clsRegistoVentas();

                    pro.totalCompra = br.ReadDouble();
                    pro.tipoPago = br.ReadString();
                    pro.codigoDeBarra = br.ReadString();
                    pro.fechaVenta = br.ReadString();
                    pro.nombreVendedor = br.ReadString();
                    pro.nombreCliente = br.ReadString();
                    pro.codigoVendedor = br.ReadString();
                    pro.cantidad = br.ReadInt32();
                    pro.numeroDeVenta = br.ReadString();

                    if (pro.fechaVenta == fecha)
                    {
                        ventas.Add(pro);
                        total = total + pro.totalCompra;
                    }
                }
                br.Close();
                fs.Close();
            }

            catch (IOException ex)
            {
                ventas.Clear();
            }

            return ventas;
        }

        public List<clsRegistoVentas> devolverRegistroClientePorFecha(string nombrecliente, string fecha)
        {
            List<clsRegistoVentas> ventas = new List<clsRegistoVentas>();
            clsRegistoVentas pro;
            try
            {
                FileStream fs = new FileStream(DirrecionRegistroClientes + "\\" + nombrecliente  + ".dat", FileMode.Open);
                BinaryReader br = new BinaryReader(fs);

                while (br.PeekChar() != -1)
                {
                    pro = new clsRegistoVentas();

                    pro.totalCompra = br.ReadDouble();
                    pro.tipoPago = br.ReadString();
                    pro.codigoDeBarra = br.ReadString();
                    pro.fechaVenta = br.ReadString();
                    pro.nombreVendedor = br.ReadString();
                    pro.nombreCliente = br.ReadString();
                    pro.codigoVendedor = br.ReadString();
                    pro.cantidad = br.ReadInt32();
                    pro.numeroDeVenta = br.ReadString();
                    
                   
                    if (pro.fechaVenta == fecha)
                    {
                        ventas.Add(pro);
                        total = total + pro.totalCompra;
                    }

                }
                br.Close();
                fs.Close();
            }

            catch (IOException ex)
            {
                ventas.Clear();
            }

            return ventas;
        }

        public List<clsRegistoVentas> devolverRegistroDeVentasPorIntervaloDeFecha(DateTime fecha1, DateTime fecha2)
        {
            List<clsRegistoVentas> registroVentas = new List<clsRegistoVentas>();

            try
            {
                FileStream fs = new FileStream(DireccionRegistro + "\\" + "RegistrosTotales.dat", FileMode.Open);
                BinaryReader br = new BinaryReader(fs);

                while (br.PeekChar() != -1)
                {
                    clsRegistoVentas vent = new clsRegistoVentas();

                    vent.totalCompra = br.ReadDouble();
                    vent.tipoPago = br.ReadString();
                    vent.codigoDeBarra = br.ReadString();
                    vent.fechaVenta = br.ReadString();
                    vent.nombreVendedor = br.ReadString();
                    vent.nombreCliente = br.ReadString();
                    vent.codigoVendedor = br.ReadString();
                    vent.cantidad = br.ReadInt32();
                    vent.numeroDeVenta = br.ReadString();

                    if(Convert.ToDateTime(vent.fechaVenta)>= fecha1 && Convert.ToDateTime(vent.fechaVenta) <= fecha2)
                    {
                        registroVentas.Add(vent);
                        total = total + vent.totalCompra;

                    }
   

                }
                br.Close();
                fs.Close();
            }

            catch (IOException ex)
            {
                registroVentas.Clear();
            }

            return registroVentas;
        }

        public List<clsRegistoVentas> devolverVentasEmpleadoPorIntervaloDeFecha(string nombreempleado, DateTime fecha1, DateTime fecha2)
        {
            List<clsRegistoVentas> ventas = new List<clsRegistoVentas>();

            try
            {
                FileStream fs = new FileStream(DireccionRegistroEmpleados + "\\" + nombreempleado + ".dat", FileMode.Open);
                BinaryReader br = new BinaryReader(fs);

                while (br.PeekChar() != -1)
                {
                    clsRegistoVentas pro = new clsRegistoVentas();

                    pro.totalCompra = br.ReadDouble();
                    pro.tipoPago = br.ReadString();
                    pro.codigoDeBarra = br.ReadString();
                    pro.fechaVenta = br.ReadString();
                    pro.nombreVendedor = br.ReadString();
                    pro.nombreCliente = br.ReadString();
                    pro.codigoVendedor = br.ReadString();
                    pro.cantidad = br.ReadInt32();
                    pro.numeroDeVenta = br.ReadString();

                    if (Convert.ToDateTime(pro.fechaVenta) >= fecha1 && Convert.ToDateTime(pro.fechaVenta) <= fecha2)
                    {
                        ventas.Add(pro);
                        total = total + pro.totalCompra;
                    }
                }
                br.Close();
                fs.Close();
            }

            catch (IOException ex)
            {
                ventas.Clear();
            }

            return ventas;
        }

        public List<clsRegistoVentas> devolverRegistroClientePorIntervaloDeFecha(string nombrecliente, DateTime fecha1, DateTime fecha2)
        {
            List<clsRegistoVentas> ventas = new List<clsRegistoVentas>();

            try
            {
                FileStream fs = new FileStream(DirrecionRegistroClientes + "\\" + nombrecliente + ".dat", FileMode.Open);
                BinaryReader br = new BinaryReader(fs);

                while (br.PeekChar() != -1)
                {
                    clsRegistoVentas pro = new clsRegistoVentas();

                    pro.totalCompra = br.ReadDouble();
                    pro.tipoPago = br.ReadString();
                    pro.codigoDeBarra = br.ReadString();
                    pro.fechaVenta = br.ReadString();
                    pro.nombreVendedor = br.ReadString();
                    pro.nombreCliente = br.ReadString();
                    pro.codigoVendedor = br.ReadString();
                    pro.cantidad = br.ReadInt32();
                    pro.numeroDeVenta = br.ReadString();

                    if (Convert.ToDateTime(pro.fechaVenta) >= fecha1 && Convert.ToDateTime(pro.fechaVenta) <= fecha2)
                    {
                        ventas.Add(pro);
                        total = total + pro.totalCompra;
                    }
                }
                br.Close();
                fs.Close();
            }

            catch (IOException ex)
            {
                ventas.Clear();
            }

            return ventas;
        }

        public string eliminarVenta(string eliminar)
        {
            List<clsRegistoVentas> listaEliminar = devolverRegistroDeVentas();            
            clsRegistoVentas aux= listaEliminar.Find(e => e.numeroDeVenta == eliminar);
            
            listaEliminar.Remove(aux);

            string res = string.Empty;
            try
            {
                fs = new FileStream(DireccionRegistro + "\\" + "RegistrosTotales.dat", FileMode.Create);//revisar

                bw = new BinaryWriter(fs);

                foreach (clsRegistoVentas x in listaEliminar)
                {
                    bw.Write(x.totalCompra);
                    bw.Write(x.tipoPago);
                    bw.Write(x.codigoDeBarra);
                    bw.Write(x.fechaVenta);
                    bw.Write(x.nombreVendedor);
                    bw.Write(x.nombreCliente);
                    bw.Write(x.codigoVendedor);
                    bw.Write(x.cantidad);
                    bw.Write(x.numeroDeVenta);
                }
                res = "Usuario modificado";
            }
            catch (IOException ex)
            {
                res = ex.Message;
            }
            fs.Close();
            bw.Close();

            //Eliminar venta empleado
           listaEliminar = devolverVentasEmpleado(Convert.ToString(aux.nombreVendedor));
           aux = listaEliminar.Find(e => e.numeroDeVenta == eliminar);
           listaEliminar.Remove(aux);



           
            try
            {

                fs = new FileStream(DireccionRegistroEmpleados + "\\" + Convert.ToString(aux.nombreVendedor) + ".dat", FileMode.Create);//revisar

                bw = new BinaryWriter(fs);

                foreach (clsRegistoVentas x in listaEliminar)
                {

                    bw.Write(x.totalCompra);
                    bw.Write(x.tipoPago);
                    bw.Write(x.codigoDeBarra);
                    bw.Write(x.fechaVenta);
                    bw.Write(x.nombreVendedor);
                    bw.Write(x.nombreCliente);
                    bw.Write(x.codigoVendedor);
                    bw.Write(x.cantidad);
                    bw.Write(x.numeroDeVenta);
                }
                res = "Usuario modificado";
            }
            catch (IOException ex)
            {
                res = ex.Message;
            }
            fs.Close();
            bw.Close();

            //Eliminar venta cliente

           listaEliminar = devolverRegistroCliente(Convert.ToString(aux.nombreCliente));
           aux = listaEliminar.Find(e => e.numeroDeVenta == eliminar);
            listaEliminar.Remove(aux);


          
            try
            {

                fs = new FileStream(DirrecionRegistroClientes + "\\" + Convert.ToString(aux.nombreCliente) + ".dat", FileMode.Create);//revisar

                bw = new BinaryWriter(fs);

                foreach (clsRegistoVentas x in listaEliminar)
                {

                    bw.Write(x.totalCompra);
                    bw.Write(x.tipoPago);
                    bw.Write(x.codigoDeBarra);
                    bw.Write(x.fechaVenta);
                    bw.Write(x.nombreVendedor);
                    bw.Write(x.nombreCliente);
                    bw.Write(x.codigoVendedor);
                    bw.Write(x.cantidad);
                    bw.Write(x.numeroDeVenta);

                }
                res = "Usuario modificado";
            }
            catch (IOException ex)
            {
                res = ex.Message;
            }
            fs.Close();
            bw.Close();
            

            ////////////////Eliminar registro Producto/////////////////
            List<clsProducto> eliminarProducto = devolverProductos(eliminar);
            foreach (clsProducto x in eliminarProducto)
            {              
                modificarStock_Sumar(x.CodigoDeBarras, x.Cantidad);
            }

            return res;
        }


        public clsRegistoVentas buscarVenta(string numeroDeVenta)
        {
            List<clsRegistoVentas> buscar = devolverRegistroDeVentas();
            clsRegistoVentas aux = buscar.Find(e => e.numeroDeVenta == numeroDeVenta);
            return aux;
        }



        public string buscarNombreUsuario(string buscarNombreUsuario)
        {
            string valor = string.Empty;
            empleado = new clsEmpleado();
            empleador = new clsEmpleador();
            List<clsEmpleado> empleadosLista = empleado.UsuariosAlta();
            List<clsEmpleador> empleadorLista = empleador.Usuarios();
            empleadosLista = empleadosLista.Union(empleado.UsuariosBaja()).ToList();
            
            ArrayList empleados = new ArrayList();
            
            foreach (clsEmpleado x in empleadosLista)
            {
                empleados.Add(x.NombreUsuario);
            }
            foreach (clsEmpleador x in empleadorLista)
            {
                empleados.Add(x.NombreUsuario);
            }

            foreach (string k in empleados)
            {
                if (k == buscarNombreUsuario)
                {
                    valor = k;
                }
            }

            return valor;
            

          
        }

        public string buscarCodigo(string buscarNombreUsuario)
        {
            string valor = string.Empty;
            empleado = new clsEmpleado();
            empleador = new clsEmpleador();
            List<clsEmpleado> empleadosLista = empleado.UsuariosAlta();
            List<clsEmpleador> empleadorLista = empleador.Usuarios();
            empleadosLista = empleadosLista.Union(empleado.UsuariosBaja()).ToList();

            ArrayList empleados = new ArrayList();

            foreach (clsEmpleado x in empleadosLista)
            {
                empleados.Add(Convert.ToString(x.Codigo));
            }
            foreach (clsEmpleador x in empleadorLista)
            {
                empleados.Add(x.Codigo);
            }


            foreach (string k in empleados)
            {
                if (k == buscarNombreUsuario)
                {
                    valor = k;
                }
            }

            return valor;



        }


    }
}
