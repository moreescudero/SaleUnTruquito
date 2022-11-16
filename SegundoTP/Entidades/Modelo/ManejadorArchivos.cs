using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelo
{
    public static class ManejadorArchivos
    {
        static string? ruta;

        static ManejadorArchivos()
        {

        }

        /// <summary>
        /// escribe un archivo
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="archivo"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static bool EscribirArchivo(string? mensaje, /*string? archivo,*/ string? nombre)
        {
            string? ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //consigue la ruta desde cualquier pc
            ruta += @"/Partida"; //la carpeta
            string? completa = ruta + @"/" + nombre + ".txt";
            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                using (StreamWriter sw = new StreamWriter(completa))
                {
                    sw.WriteLine(mensaje);
                }
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Error en el archivo " + completa);
            }
        }

        /// <summary>
        /// busca un archivo
        /// </summary>
        /// <param name="archivo"></param>
        /// <returns></returns>
        private static string BuscarArchivo(string? archivo, string? ruta)
        {
            string[] archivos = Directory.GetFiles(ruta); 

            foreach (string item in archivos)
            {
                if(item.Contains(archivo))
                {
                    return item;
                }
            }
            return null;
        }

        /// <summary>
        /// lee un archivo específico en caso de que este exista
        /// </summary>
        /// <param name="archivo"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static string? LeerArchivo(string? ruta, string? archivo)
        {
            string? datos = "";

            if (Directory.Exists(ruta))
            {
                string? completa = BuscarArchivo(archivo, ruta);
                if(completa is not null)
                {
                    using (StreamReader sr = new StreamReader(completa))
                    {
                        string linea = sr.ReadToEnd();
                        datos += linea;
                    }
                }
                else
                {
                    throw new Exception("No se encontro el archivo");
                }
            }
               
            return datos;
        }
    }
}
