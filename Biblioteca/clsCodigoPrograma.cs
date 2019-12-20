using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Biblioteca
{
    public class clsCodigoPrograma
    {
        const string ARCHIVO = "ClaveProducto.dat";
        const string PATH = "D:\\Proyecto";
        const string FULL_NAME = PATH + "\\" + ARCHIVO;
        FileStream fs;
        BinaryWriter bw;
        
         public clsCodigoPrograma()
        {
            if (!Directory.Exists(PATH))
                Directory.CreateDirectory(PATH);
            inicializarCodigo();
        }
         private string inicializarCodigo()
        {
            string res = string.Empty;

            try
            {
                if (!File.Exists(FULL_NAME))
                {
                    fs = new FileStream(FULL_NAME, FileMode.Create);
                    bw = new BinaryWriter(fs);

                    bw.Write("12345");
                    bw.Close();
                    fs.Close();
                }
                
            }
            catch (IOException ex)
            {
                res = ex.Message;
                bw.Close();
                fs.Close();
            }
            

            return res;
        }

         public string modificarCodigo(string codigoN)
         {
             string res = string.Empty;
             
             try
             {

                 fs = new FileStream(FULL_NAME, FileMode.Create);//revisar

                 bw = new BinaryWriter(fs);

                 bw.Write(codigoN);
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

         public string devolverCodigo()
         {
             string codigo = String.Empty;

             try
             {
                 FileStream fs = new FileStream(FULL_NAME, FileMode.Open);
                 BinaryReader br = new BinaryReader(fs);

                 while (br.PeekChar() != -1)
                 {                     
                     codigo = br.ReadString();                   
                 }
                 br.Close();
                 fs.Close();
             }

             catch (IOException ex)
             {
                 codigo = ex.Message;
             }

             return codigo;
         }
    }
}
