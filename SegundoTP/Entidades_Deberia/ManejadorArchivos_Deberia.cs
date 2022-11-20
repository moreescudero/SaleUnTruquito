using Entidades.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Deberia
{
    [TestClass]
    public class ManejadorArchivos_Deberia
    {
        [TestMethod]
        public void EscribirArchivo_Deberia()
        {
            string? mensaje = "esto es una prueba";
            string? nombre = "prueba";

            bool escribio = ManejadorArchivos.EscribirArchivo(mensaje, nombre);

            Assert.IsTrue(escribio);

            File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/" + nombre + ".txt");
        }

        [DataRow("esto es una prueba", null)]
        [DataRow(null, "prueba")]
        [DataRow(null, null)]
        [TestMethod]
        public void EscribirArchivo_Fallo(string? mensaje, string? nombre)
        {
            bool escribio = ManejadorArchivos.EscribirArchivo(mensaje, nombre);

            Assert.IsFalse(escribio);
        }

        [TestMethod]
        public void LeerArchivo_Deberia()
        {
            string? mensaje = "esto es una prueba";
            string? nombre = "prueba";
            string? ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/Partida" /*+ @"/" + nombre + ".txt"*/;
            bool escribio = ManejadorArchivos.EscribirArchivo(mensaje, nombre);

            string? lectura = ManejadorArchivos.LeerArchivo(ruta, nombre + ".txt");

            Assert.IsTrue(lectura != string.Empty);
            Assert.IsNotNull(lectura);

            File.Delete(ruta + nombre + ".txt");
        }
    }
}
