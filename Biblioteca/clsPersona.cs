using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Biblioteca
{
    public class clsPersona
    {
        protected string nombre;
        protected string apellido;
        protected string email;
        protected string direccion;
        protected string telefono;
        protected string nombreUsuario;
        protected string clave;
        protected string sexo;
        public bool alta_baja = true;


       
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
        
        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }
        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
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
       

    }
}
