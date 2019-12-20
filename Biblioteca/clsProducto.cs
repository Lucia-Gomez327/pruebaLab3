using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Biblioteca
{
    public class clsProducto
    {
        const string ARCHIVO = "Stock.dat";
        const string PATH = "D:\\Proyecto";
        const string FULL_NAME = PATH + "\\" + ARCHIVO;
        const String archivo = "codigoStock.dat";
        const String path = "D:\\Proyecto";
        String Full_Name = path + "\\" + archivo;

        FileStream fs;
        BinaryWriter bw;

        string codigoDeBarras;
        string descripcion;
        string categoria;
        int codigo;

        int cantidad;
        double precio;
        bool alta_baja = true;

        public bool Alta_baja
        {
            get { return alta_baja; }
            set { alta_baja = value; }
        }
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public string CodigoDeBarras
        {
            get { return codigoDeBarras; }
            set { codigoDeBarras = value; }
        }   
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }     
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        
       
       
        
        
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        
        
        
        

        public clsProducto(string codigoDeBarras, string descripcion, string categoria, int cantidad, double precio)
        {
            this.codigoDeBarras = codigoDeBarras;
            this.descripcion = descripcion;
            this.categoria = categoria;
            this.cantidad = cantidad;
            this.precio = precio;
              if (!Directory.Exists(PATH))
                Directory.CreateDirectory(PATH);
        }

        

    public clsProducto()
    {
        if (!Directory.Exists(PATH))
            Directory.CreateDirectory(PATH);
    }

    private int codigoD()
    {


        if (!File.Exists(Full_Name))
        {
            fs = new FileStream(Full_Name, FileMode.Create);
            bw = new BinaryWriter(fs);
            codigo = 1;
            bw.Write(codigo);
            bw.Close();
            fs.Close();
            return codigo;
        }
        else
        {
            fs = new FileStream(Full_Name, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            codigo = br.ReadInt32();
            codigo++;
            fs.Close();
            br.Close();

            fs = new FileStream(Full_Name, FileMode.Create);
            bw = new BinaryWriter(fs);
            bw.Write(codigo);
            bw.Close();
            fs.Close();
            return codigo;
        }

    }

    public string cargar()
    {
        string res = string.Empty;

        try
        {
            if (!File.Exists(FULL_NAME))
            {
                fs = new FileStream(FULL_NAME, FileMode.Create);
            }

            else
            {
                fs = new FileStream(FULL_NAME, FileMode.Append);
            }

            bw = new BinaryWriter(fs);

            bw.Write(precio);
            bw.Write(cantidad);
            bw.Write(descripcion);
            bw.Write(categoria);            
            bw.Write(codigoDeBarras);
            bw.Write(alta_baja);
            bw.Write(codigoD());
        }
        catch (IOException ex)
        {
            res = ex.Message;
        }
        bw.Close();
        fs.Close();

        return res;
    }

    public List<clsProducto> listaAlta()
    {
        List<clsProducto> stock = new List<clsProducto>();

        try
        {
            FileStream fs = new FileStream(FULL_NAME, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            while (br.PeekChar() != -1)
            {
                clsProducto pro = new clsProducto();

                pro.precio = br.ReadDouble();
                pro.cantidad = br.ReadInt32();
                pro.descripcion=br.ReadString();
                pro.categoria = br.ReadString();
                pro.codigoDeBarras = br.ReadString();
                pro.alta_baja = br.ReadBoolean();
                pro.codigo = br.ReadInt32();

                if(pro.alta_baja)
                stock.Add(pro);
            }
            br.Close();
            fs.Close();
        }
        catch (IOException ex)
        {
            stock.Clear();
        }

        return stock;
    }

    public List<clsProducto> listaBaja()
    {
        List<clsProducto> stock = new List<clsProducto>();

        try
        {
            FileStream fs = new FileStream(FULL_NAME, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            while (br.PeekChar() != -1)
            {
                clsProducto pro = new clsProducto();

                pro.precio = br.ReadDouble();
                pro.cantidad = br.ReadInt32();
                pro.descripcion = br.ReadString();
                pro.categoria = br.ReadString();
                pro.codigoDeBarras = br.ReadString();
                pro.alta_baja = br.ReadBoolean();
                pro.codigo = br.ReadInt32();

                if (pro.alta_baja == false)
                {
                    stock.Add(pro);
                }
            }
            br.Close();
            fs.Close();
        }
        catch (IOException ex)
        {
            stock.Clear();
        }

        return stock;
    }
    public string Modificar(clsProducto modificado)
    {
        string res = string.Empty;
        List<clsProducto> modificar = listaAlta();
        modificar = modificar.Union(listaBaja()).ToList();
        int posicion = modificar.IndexOf(modificar.Find(e => e.codigo == modificado.codigo));
        modificar[posicion] = modificado;

        try
        {

            fs = new FileStream(FULL_NAME, FileMode.Create);//revisar

            bw = new BinaryWriter(fs);

            foreach (clsProducto x in modificar)
            {
                bw.Write(x.precio);
                bw.Write(x.cantidad);
                bw.Write(x.descripcion);
                bw.Write(categoria);
                bw.Write(x.codigoDeBarras);
                bw.Write(x.alta_baja);
                bw.Write(x.codigo);
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

    //public string Eliminar(int EliminarAux)
    //{
    //    string res = string.Empty;
    //    List<clsProducto> modificar = listaAlta();

    //    modificar.RemoveAt(EliminarAux);

    //    try
    //    {
    //        fs = new FileStream(FULL_NAME, FileMode.Create);//revisar

    //        bw = new BinaryWriter(fs);

    //        foreach (clsProducto x in modificar)
    //        {
    //            bw.Write(precio);
    //            bw.Write(cantidad);
    //            bw.Write(descripcion);
    //            bw.Write(categoria);
    //            bw.Write(codigoDeBarras);
    //            bw.Write(alta_baja);
    //            bw.Write(codigoD());
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

    public clsProducto Buscar(string producto)
    {
        clsProducto aux = new clsProducto();
        List<clsProducto> productos = listaAlta();
        productos = productos.Union(listaBaja()).ToList();
        int codigoA = Convert.ToInt32(producto);

        if (codigoA<100000)
        {
            aux = productos.Find(e => e.codigo == codigoA);
        }
        else
        {
            aux = productos.Find(e => e.codigoDeBarras == producto);
        }

        return aux;
    }


    }
}
