using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Biblioteca
{
     public class clsEmpleado:clsPersona
    {
        const string ARCHIVO = "Empleados.dat";
        const string PATH = "D:\\Proyecto";
        const string FULL_NAME = PATH + "\\" + ARCHIVO;
        const String archivo = "codigoEmpleado.dat";
        const String path = "D:\\Proyecto";
        String Full_Name = path + "\\" + archivo;

        FileStream fs;
        BinaryWriter bw;

        string fechaIngreso;
        string fechaDePago;       
        double sueldo;

        int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }
       

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        
        public string FechaIngreso
        {
            get { return fechaIngreso; }
            set { fechaIngreso = value; }
        }
        public string FechaDePago
        {
            get { return fechaDePago; }
            set { fechaDePago = value; }
        }         
        public double Salario
        {
            get { return sueldo; }
            set { sueldo = value; }
        }
        
         public clsEmpleado()
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
                  codigoD();
                  if (!File.Exists(FULL_NAME))
                  {
                      fs = new FileStream(FULL_NAME, FileMode.Create);
                  }

                  else
                  {
                      fs = new FileStream(FULL_NAME, FileMode.Append);
                  }

                  bw = new BinaryWriter(fs);
                  bw.Write(codigo);
                  bw.Write(nombre);
                  bw.Write(apellido);
                  bw.Write(email);
                  bw.Write(direccion);
                  bw.Write(telefono);
                  bw.Write(nombreUsuario);
                  bw.Write(clave);
                  bw.Write(Sexo);
                  bw.Write(sueldo);
                  bw.Write(Convert.ToString( fechaIngreso));
                  bw.Write(Convert.ToString(fechaDePago));
                  bw.Write(alta_baja);

              }
              catch (IOException ex)
              {
                  res = ex.Message;
              }
              bw.Close();
              fs.Close();

              return res;
          }


         public clsEmpleado(string nombre, string apellido, string email, string direccion, string telefono, string nombreUsuario, string clave, string sexo, string fechaIngreso, string fechaDePago, double salario)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.direccion = direccion;
            this.telefono = telefono;
            this.nombreUsuario = nombreUsuario;
            this.clave = clave;
            this.Sexo = sexo;
            this.sueldo = salario;
            this.fechaIngreso = fechaIngreso;
            this.fechaDePago = fechaDePago;
            if (!Directory.Exists(PATH))
                Directory.CreateDirectory(PATH);
            }

         

          public List<clsEmpleado> UsuariosAlta()
          {
              List<clsEmpleado> usuarios = new List<clsEmpleado>();

              try
              {
                  FileStream fs = new FileStream(FULL_NAME, FileMode.Open);
                  BinaryReader br = new BinaryReader(fs);

                  while (br.PeekChar() != -1)
                  {
                      clsEmpleado per = new clsEmpleado();

                      per.Codigo = br.ReadInt32();
                      per.Nombre = br.ReadString();
                      per.Apellido = br.ReadString();
                      per.Email = br.ReadString();
                      per.Direccion = br.ReadString();
                      per.Telefono = br.ReadString();
                      per.NombreUsuario = br.ReadString();
                      per.Clave = br.ReadString();
                      per.Sexo = br.ReadString();
                      per.Salario = br.ReadDouble();
                      per.FechaIngreso = br.ReadString();
                      per.FechaDePago= br.ReadString();
                      per.alta_baja = br.ReadBoolean();


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

          public List<clsEmpleado> UsuariosBaja()
          {
              List<clsEmpleado> usuarios = new List<clsEmpleado>();

              try
              {
                  FileStream fs = new FileStream(FULL_NAME, FileMode.Open);
                  BinaryReader br = new BinaryReader(fs);

                  while (br.PeekChar() != -1)
                  {
                      clsEmpleado per = new clsEmpleado();

                      per.Codigo = br.ReadInt32();
                      per.Nombre = br.ReadString();
                      per.Apellido = br.ReadString();
                      per.Email = br.ReadString();
                      per.Direccion = br.ReadString();
                      per.Telefono = br.ReadString();
                      per.NombreUsuario = br.ReadString();
                      per.Clave = br.ReadString();
                      per.Sexo = br.ReadString();
                      per.Salario = br.ReadDouble();
                      per.FechaIngreso = br.ReadString();
                      per.FechaDePago = br.ReadString();
                      per.alta_baja = br.ReadBoolean();

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

          public string Modificar(clsEmpleado modificado)
          {
              string res = string.Empty;
              List<clsEmpleado> modificar = UsuariosAlta();
              modificar = modificar.Union(UsuariosBaja()).ToList();
              int posicion = modificar.IndexOf(modificar.Find(e => e.codigo == modificado.codigo));
              modificar[posicion] = modificado;

              try
              {

                  fs = new FileStream(FULL_NAME, FileMode.Create);//revisar

                  bw = new BinaryWriter(fs);

                  foreach (clsEmpleado x in modificar)
                  {
                      bw.Write(x.codigo);
                      bw.Write(x.nombre);
                      bw.Write(x.apellido);
                      bw.Write(x.email);
                      bw.Write(x.direccion);
                      bw.Write(x.telefono);
                      bw.Write(x.nombreUsuario);
                      bw.Write(x.clave);
                      bw.Write(x.sexo);
                      bw.Write(x.sueldo);
                      bw.Write(Convert.ToString(x.fechaIngreso));
                      bw.Write(Convert.ToString(fechaDePago));
                      bw.Write(x.alta_baja);

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

          public clsEmpleado Buscar(string empleado)
          {
              clsEmpleado aux = new clsEmpleado();
              List<clsEmpleado> usuarios = UsuariosAlta();
              usuarios= usuarios.Union(UsuariosBaja()).ToList();
              int codigoA;
              if (int.TryParse(empleado, out codigoA))
              {
                  aux = usuarios.Find(e => e.codigo == codigoA);
              }
              else
              {
                  aux = usuarios.Find(e => e.nombreUsuario == empleado);
              }
              
              return aux;
          }

    }
}
