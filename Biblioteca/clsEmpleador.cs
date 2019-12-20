using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Biblioteca
{
    public class clsEmpleador : clsPersona
    {
        const string ARCHIVO = "Empleador.dat";
        const string PATH = "D:\\Proyecto";
        const string FULL_NAME = PATH + "\\" + ARCHIVO;
        const String archivo = "codigoEmpleador.dat";
        const String path = "D:\\Proyecto";
        String Full_Name = path + "\\" + archivo;
        FileStream fs;
        BinaryWriter bw;

        string codigo;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
       
 
        public clsEmpleador(string nombre, string apellido, string email, string direccion, string telefono, string nombreUsuario, string clave, string sexo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.direccion = direccion;
            this.telefono = telefono;
            this.nombreUsuario = nombreUsuario;
            this.clave = clave;
            this.Sexo = sexo;
            if (!Directory.Exists(PATH))
                Directory.CreateDirectory(PATH);
        }

        public clsEmpleador()
        {
            if (!Directory.Exists(PATH))
                Directory.CreateDirectory(PATH);
        }

        private string codigoD()
        {

            int codigo2;
            if (!File.Exists(Full_Name))
            {
                fs = new FileStream(Full_Name, FileMode.Create);
                bw = new BinaryWriter(fs);
                codigo2 = 1;
               codigo = "A" + Convert.ToString(codigo2);

                bw.Write(codigo2);
                bw.Close();
                fs.Close();
                return codigo;
            }
            else
            {
                fs = new FileStream(Full_Name, FileMode.Open);
                BinaryReader br = new BinaryReader(fs);

                codigo2 = br.ReadInt32();
                codigo2++;
                codigo = "A" + Convert.ToString(codigo2);
                fs.Close();
                br.Close();

                fs = new FileStream(Full_Name, FileMode.Create);
                bw = new BinaryWriter(fs);
                bw.Write(codigo2);
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

            }
            catch (IOException ex)
            {
                res = ex.Message;
            }
            bw.Close();
            fs.Close();

            return res;
        }

        public List<clsEmpleador> Usuarios() 
        {
            List<clsEmpleador> usuarios = new List<clsEmpleador>();

            try
            {
                FileStream fs = new FileStream(FULL_NAME, FileMode.Open);
                BinaryReader br = new BinaryReader(fs);

                while (br.PeekChar() != -1)
                {
                    clsEmpleador per = new clsEmpleador();

                    per.codigo = br.ReadString();
                    per.Nombre = br.ReadString();
                    per.Apellido = br.ReadString();
                    per.Email = br.ReadString();
                    per.Direccion = br.ReadString();
                    per.Telefono = br.ReadString();
                    per.NombreUsuario = br.ReadString();
                    per.Clave = br.ReadString();
                    per.Sexo = br.ReadString();
                    


                    usuarios.Add(per);
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

        public string Modificar(clsEmpleador modificado, int posicion)
        {
            string res = string.Empty;
            List<clsEmpleador> modificar = Usuarios();
            modificar[posicion] = modificado;

            try
            {

                fs = new FileStream(FULL_NAME, FileMode.Create);//revisar

                bw = new BinaryWriter(fs);

                foreach (clsEmpleador x in modificar)
                {
                    bw.Write(x.codigo);
                    bw.Write(x.nombre);
                    bw.Write(x.apellido);
                    bw.Write(x.email);
                    bw.Write(x.direccion);
                    bw.Write(x.telefono);
                    bw.Write(x.nombreUsuario);
                    bw.Write(x.clave);
                    bw.Write(sexo);
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


        public string Eliminar(clsEmpleador Eliminar)
        {
            string res = string.Empty;
            List<clsEmpleador> modificar = Usuarios();
            modificar.Remove(Eliminar);

            try
            {

                fs = new FileStream(FULL_NAME, FileMode.Create);//revisar

                bw = new BinaryWriter(fs);

                foreach (clsEmpleador x in modificar)
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

       

    }
}