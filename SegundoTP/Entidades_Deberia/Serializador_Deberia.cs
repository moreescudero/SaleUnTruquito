using Entidades.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Deberia
{
    [TestClass]
    public class Serializador_Deberia
    {
        private List<Carta> RetornarCartas()
        {
            List<Carta> cartas = new List<Carta>();

            cartas.Add(new Carta(1,"Espada",EValores.AnchoEspada));
            cartas.Add(new Carta(2,"Espada",EValores.Dos));
            cartas.Add(new Carta(3,"Espada",EValores.Tres));
            cartas.Add(new Carta(4,"Espada",EValores.Cuatro));
            cartas.Add(new Carta(5,"Espada",EValores.Cinco));
            cartas.Add(new Carta(6,"Espada",EValores.Seis));

            return cartas;
        }

        [TestMethod]
        public void EscribirYLeerJson_Deberia()
        {
            string? nombre = "prueba";
            Mazo mazo = new Mazo();
            mazo.Mazos = RetornarCartas();

            Serializador<Mazo>.EscribirJSon(mazo, nombre);
            Mazo mazoAux = Serializador<Mazo>.LeerJSon(nombre);

            Assert.IsNotNull(mazoAux);

            File.Delete(@"./Archivos-Serializador" + @"/" + nombre);
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void EscribirYLeerJson_Fallo()
        {
            string? nombre = "prueba";
            Mazo mazo = new Mazo();
            mazo.Mazos = RetornarCartas();

            Serializador<Mazo>.EscribirJSon(mazo, nombre);
            Mazo mazoAux = Serializador<Mazo>.LeerJSon("error");

            File.Delete(@"./Archivos-Serializador" + @"/" + nombre);

        }
    }
}
