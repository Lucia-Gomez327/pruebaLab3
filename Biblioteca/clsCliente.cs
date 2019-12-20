using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Biblioteca
{
    public class clsCliente
    {
        const string ARCHIVO = "Cliente.dat";
        const string PATH = "D:\\Proyecto";
        const string FULL_NAME = PATH + "\\" + ARCHIVO;
        const String archivo = "codigoCliente.dat";
        const String path = "D:\\Proyecto";
        String Full_Name = path + "\\" + archivo;

        FileStream fs;
        BinaryWriter bw;
        string celular;
        string nombre;
        string apellido;
        string email;
        string direccion;
        int codigo;
        public bool alta_baja = true;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }      
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }        
        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }       
        public string Email
        {
            get { return email; }
            set { email = value; }
        }        
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }        
        

           public clsCliente()
        {
            if (!Directory.Exists(PATH))
            {
                Directory.CreateDirectory(PATH);
            }
         
        }

          public int codigoD()
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

        public clsCliente(string nombre, string apellido, string celular, string email, string direccion)
           {
               this.nombre = nombre;
               this.apellido = apellido;
               this.celular = celular;
               this.email = email;
               this.direccion = direccion;
               if (!Directory.Exists(PATH))
                   Directory.CreateDirectory(PATH);
               
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

                   bw.Write(nombre);
                   bw.Write(apellido);
                   bw.Write(celular);
                   bw.Write(email);
                   bw.Write(direccion);
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

        /////////////////////////devuelve lista de usuarios//////////////////
           public List<clsCliente> usuariosAlta()
           {
               List<clsCliente> usuarios = new List<clsCliente>();

               try
               {
                   FileStream fs = new FileStream(FULL_NAME, FileMode.Open);
                   BinaryReader br = new BinaryReader(fs);

                   while (br.PeekChar() != -1)
                   {
                       clsCliente per = new clsCliente();

                       per.Nombre = br.ReadString();
                       per.Apellido = br.ReadString();
                       per.Celular = br.ReadString();
                       per.Email = br.ReadString();
                       per.Direccion = br.ReadString();
                       per.alta_baja = br.ReadBoolean();          
                       per.Codigo = br.ReadInt32();

                       if (per.alta_baja)
                       {
                           usuarios.Add(per);
                       }
                   }
                   br.Close();
                   fs.Close();
               }

               catch (IOException ex)
               {
                   usuarios.Clear();
               }

               return usuarios;
           }

           public List<clsCliente> usuariosBaja()
           {
               List<clsCliente> usuarios = new List<clsCliente>();

               try
               {
                   FileStream fs = new FileStream(FULL_NAME, FileMode.Open);
                   BinaryReader br = new BinaryReader(fs);

                   while (br.PeekChar() != -1)
                   {
                       clsCliente per = new clsCliente();

                       per.Nombre = br.ReadString();
                       per.Apellido = br.ReadString();
                       per.Celular = br.ReadString();
                       per.Email = br.ReadString();
                       per.Direccion = br.ReadString();
                       per.alta_baja = br.ReadBoolean();
                       per.Codigo = br.ReadInt32();

                       if (per.alta_baja == false)
                       {
                           usuarios.Add(per);
                       }

                   }
                   br.Close();
                   fs.Close();
               }

               catch (IOException ex)
               {
                   usuarios.Clear();
               }

               return usuarios;
           }

           public string Modificar(clsCliente modificado)
           {
               string res = string.Empty;
               List<clsCliente> modificar = usuariosAlta();
               modificar = modificar.Union(usuariosBaja()).ToList();
                   
               int posicion = modificar.IndexOf(modificar.Find(e => e.codigo == modificado.codigo));
               modificar[posicion] = modificado;

               try
               {

                   fs = new FileStream(FULL_NAME, FileMode.Create);//revisar

                   bw = new BinaryWriter(fs);

                   foreach (clsCliente x in modificar)
                   {
                       bw.Write(x.nombre);
                       bw.Write(x.apellido);
                       bw.Write(x.celular);
                       bw.Write(x.email);
                       bw.Write(x.direccion);
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

           public clsCliente Buscar(string cliente)
           {
               clsCliente aux = new clsCliente();
               List<clsCliente> usuarios = aux.usuariosAlta();
               usuarios = usuarios.Union(usuariosBaja()).ToList();

               int codigoA;
               if (int.TryParse(cliente, out codigoA))
               {
                   aux = usuarios.Find(e => e.codigo == codigoA);
               }
               else
               {
                   aux = usuarios.Find(e => (e.nombre + " " + e.apellido) == cliente);
               }

               return aux;
           }

           public clsCliente Buscar_Alta(string cliente)
           {
               clsCliente aux = new clsCliente();
               List<clsCliente> usuarios = aux.usuariosAlta();

               int codigoA;
               if (int.TryParse(cliente, out codigoA))
               {
                   aux = usuarios.Find(e => e.codigo == codigoA);
               }
               else
               {
                   aux = usuarios.Find(e => e.Nombre + e.apellido == cliente);
               }

               return aux;
           }
    }
}
