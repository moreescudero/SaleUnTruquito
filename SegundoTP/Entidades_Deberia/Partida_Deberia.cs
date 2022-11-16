using Entidades.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Deberia
{
    [TestClass]
    public class Partida_Deberia
    {
        private Partida DevolverPartidaPrueba()
        {
            List<Usuario> jugadores = new List<Usuario>()
            {
                new Usuario (0, "jug1", "test"),
                new Usuario (0, "jug2", "test")
            };
            return new Partida(0, jugadores, DateTime.Now);
        }

        [TestMethod]
        public void ActivarEventoMazo_Deberia()
        {
            Partida partida = DevolverPartidaPrueba();

            partida.ActivarEventoMazo();

            Assert.IsNotNull(partida.Jugadores[0].Cartas);
            Assert.IsNotNull(partida.Jugadores[1].Cartas);
            Assert.IsTrue(partida.Jugadores[0].Cartas.Count == 3 && partida.Jugadores[0].Cartas.Count == 3);
        }

        [TestMethod]
        public void Barajar_Deberia()
        {
            Mazo mazo = Serializador<Mazo>.LeerJSon("mazo.json");
            List<Carta> listaMazo = mazo.Mazos;
            Partida partida = new Partida(0);

            partida.Barajar(listaMazo);

            Assert.IsTrue(listaMazo.Count == 6);
            Assert.IsNotNull(listaMazo);
        }

        [TestMethod]
        public void Repartir_Deberia()
        {
            Mazo mazo = Serializador<Mazo>.LeerJSon("mazo.json");
            List<Carta> listaMazo = mazo.Mazos;
            Partida partida = DevolverPartidaPrueba();

            partida.Barajar(listaMazo);
            partida.Repartir(listaMazo);

            Assert.IsTrue(partida.Jugadores[0].Cartas.Count == 3 && partida.Jugadores[1].Cartas.Count == 3);
        }

        [ExpectedException(typeof(NullReferenceException))]
        [TestMethod]
        public void Barajar_Fallo()
        {
            //Mazo mazo = Serializador<Mazo>.LeerJSon("mazo.json"); 
            List<Carta> listaMazo = null;
            Partida partida = new Partida(0);

            partida.Barajar(listaMazo);

            //Assert.IsFalse(listaMazo.Count == 6);
            //Assert.IsNull(listaMazo);
        }

        [ExpectedException(typeof(NullReferenceException))]
        [TestMethod]
        public void Repartir_Fallo()
        {
            //Mazo mazo = Serializador<Mazo>.LeerJSon("mazo.json"); 
            List<Carta> listaMazo = null;
            Partida partida = DevolverPartidaPrueba();

            //partida.Barajar(listaMazo);
            partida.Repartir(listaMazo);

            //Assert.IsFalse(partida.Jugadores[0].Cartas.Count == 3 && partida.Jugadores[1].Cartas.Count == 3);
            //Assert.IsNull(listaMazo);
        }

        [TestMethod]
        public void Jugar_DeberiaJug1TirarSuMejorCarta()
        {
            Partida partida = DevolverPartidaPrueba();
            partida.ActivarEventoMazo();
            Carta? carta = null;
            for (int i = 0; i < partida.Jugadores[0].Cartas.Count; i++)
            {
                if (carta is null || carta.Valor > partida.Jugadores[0].Cartas[i].Valor)
                {
                    carta = partida.Jugadores[0].Cartas[i];
                }
            }

            Carta cartaTirada = partida.Jugar(partida.Jugadores[0], null);

            Assert.AreEqual(carta.Valor, cartaTirada.Valor);
            Assert.IsTrue(partida.Jugadores[0].Cartas.Count == 2 && partida.Jugadores[0].CartasJugadas.Count == 1 && partida.Jugadores[0].CartaJugada is not null);
        }

        [TestMethod]
        public void Jugar_DeberiaJug2TirarSuMejorCarta()
        {
            Partida partida = DevolverPartidaPrueba();
            partida.ActivarEventoMazo();
            Carta? carta = null;
            for (int i = 0; i < partida.Jugadores[1].Cartas.Count; i++)
            {
                if (carta is null || carta.Valor > partida.Jugadores[1].Cartas[i].Valor)
                {
                    carta = partida.Jugadores[1].Cartas[i];
                }
            }

            Carta cartaTirada = partida.Jugar(partida.Jugadores[1], null);

            Assert.AreEqual(carta.Valor, cartaTirada.Valor);
            Assert.IsTrue(partida.Jugadores[1].Cartas.Count == 2 && partida.Jugadores[1].CartasJugadas.Count == 1 && partida.Jugadores[1].CartaJugada is not null);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void Jugar_Fallo()
        {
            Partida partida = new Partida(0);

            partida.Jugar(null, null);

        }

        [TestMethod]
        public void SumarPunto_DeberiaSumarJug1()
        {
            Partida partida = DevolverPartidaPrueba();
            int manosJug1 = partida.Jugadores[0].ManosGanadas;
            int manosJug2 = partida.Jugadores[1].ManosGanadas;
            partida.Jugadores[0].CartaJugada = new Carta(1, "basto", EValores.AnchoBasto);
            partida.Jugadores[1].CartaJugada = new Carta(3, "espada", EValores.Tres);

            partida.SumarMano();

            Assert.AreNotEqual(manosJug1, partida.Jugadores[0].ManosGanadas);
            Assert.AreEqual(manosJug2, partida.Jugadores[1].ManosGanadas);
        }

        [TestMethod]
        public void SumarPunto_DeberiaSumarJug2()
        {
            Partida partida = DevolverPartidaPrueba();
            int manosJug1 = partida.Jugadores[0].ManosGanadas;
            int manosJug2 = partida.Jugadores[1].ManosGanadas;
            partida.Jugadores[0].CartaJugada = new Carta(2, "basto", EValores.Dos);
            partida.Jugadores[1].CartaJugada = new Carta(3, "espada", EValores.Tres);

            partida.SumarMano();

            Assert.AreEqual(manosJug1, partida.Jugadores[0].ManosGanadas);
            Assert.AreNotEqual(manosJug2, partida.Jugadores[1].ManosGanadas);
        }

        [TestMethod]
        public void SumarPunto_Empardan()
        {
            Partida partida = DevolverPartidaPrueba();
            int manosJug1 = partida.Jugadores[0].ManosGanadas;
            int manosJug2 = partida.Jugadores[1].ManosGanadas;
            partida.Jugadores[0].CartaJugada = new Carta(7, "basto", EValores.Siete);
            partida.Jugadores[1].CartaJugada = new Carta(7, "copa", EValores.Siete);

            partida.SumarMano();

            Assert.AreEqual(partida.Jugadores[0].ManosGanadas, partida.Jugadores[1].ManosGanadas);
            Assert.AreNotEqual(manosJug1, partida.Jugadores[0].ManosGanadas);
            Assert.AreNotEqual(manosJug2, partida.Jugadores[1].ManosGanadas);
        }

        [TestMethod]
        public void SumarPunto_DeberiaEmpardarYSumarJug1()
        {
            Partida partida = DevolverPartidaPrueba();
            int manosJug1 = partida.Jugadores[0].ManosGanadas;
            int manosJug2 = partida.Jugadores[1].ManosGanadas;
            partida.Jugadores[0].CartasJugadas.Add(new Carta(1, "copa", EValores.Uno));
            partida.Jugadores[1].CartasJugadas.Add(new Carta(6, "copa", EValores.Seis));
            partida.Jugadores[0].CartaJugada = new Carta(2, "basto", EValores.Dos);
            partida.Jugadores[1].CartaJugada = new Carta(2, "espada", EValores.Dos);

            partida.SumarMano();

            Assert.AreNotEqual(manosJug1, partida.Jugadores[0].ManosGanadas);
            Assert.AreEqual(manosJug2, partida.Jugadores[1].ManosGanadas);
        }

        [TestMethod]
        public void SumarPunto_DeberiaEmpardarYSumarJug2()
        {
            Partida partida = DevolverPartidaPrueba();
            int manosJug1 = partida.Jugadores[0].ManosGanadas;
            int manosJug2 = partida.Jugadores[1].ManosGanadas;
            partida.Jugadores[0].CartasJugadas.Add(new Carta(1, "copa", EValores.Uno));
            partida.Jugadores[1].CartasJugadas.Add(new Carta(3, "copa", EValores.Tres));
            partida.Jugadores[0].CartaJugada = new Carta(3, "basto", EValores.Tres);
            partida.Jugadores[1].CartaJugada = new Carta(3, "espada", EValores.Tres);

            partida.SumarMano();

            Assert.AreEqual(manosJug1, partida.Jugadores[0].ManosGanadas);
            Assert.AreNotEqual(manosJug2, partida.Jugadores[1].ManosGanadas);
        }

        [TestMethod]
        public void SumarPunto_NoHaceNada()
        {
            Partida partida = DevolverPartidaPrueba();
            int manosJug1 = partida.Jugadores[0].ManosGanadas;
            int manosJug2 = partida.Jugadores[1].ManosGanadas;

            partida.SumarMano();

            Assert.AreEqual(manosJug1, partida.Jugadores[0].ManosGanadas);
            Assert.AreEqual(manosJug2, partida.Jugadores[1].ManosGanadas);
            Assert.AreEqual(manosJug1, manosJug2);
        }

        [TestMethod]
        public void CantarEnvido_DeberiaCantarJug1()
        {
            Partida partida = DevolverPartidaPrueba();
            partida.Jugadores[0].Cartas.Add(new Carta(5, "basto", EValores.Cinco));
            partida.Jugadores[0].Cartas.Add(new Carta(3, "basto", EValores.Tres));
            partida.Jugadores[0].Cartas.Add(new Carta(3, "espada", EValores.Tres));

            bool quiereEnvido = partida.CantarEnvido(partida.Jugadores[0]);

            Assert.IsTrue(quiereEnvido);
        }

        [TestMethod]
        public void CantarEnvido_NoDeberiaCantarJug1()
        {
            Partida partida = DevolverPartidaPrueba();
            partida.Jugadores[0].Cartas.Add(new Carta(5, "basto", EValores.Cinco));
            partida.Jugadores[0].Cartas.Add(new Carta(4, "oro", EValores.Cuatro));
            partida.Jugadores[0].Cartas.Add(new Carta(3, "espada", EValores.Tres));

            bool quiereEnvido = partida.CantarEnvido(partida.Jugadores[0]);

            Assert.IsFalse(quiereEnvido);
        }

        [TestMethod]
        public void CantarEnvido_DeberiaCantarJug2()
        {
            Partida partida = DevolverPartidaPrueba();
            partida.Jugadores[1].Cartas.Add(new Carta(5, "basto", EValores.Cinco));
            partida.Jugadores[1].Cartas.Add(new Carta(2, "basto", EValores.Dos));
            partida.Jugadores[1].Cartas.Add(new Carta(1, "espada", EValores.AnchoEspada));

            bool quiereEnvido = partida.CantarEnvido(partida.Jugadores[1]);

            Assert.IsTrue(quiereEnvido);
        }

        //[TestMethod]
        //public void Jugar_DeberiaJug2Ganar

        [DataRow(30, 20)]
        [DataRow(24, 22)]
        [DataRow(26, 26)]
        [TestMethod]
        public void DeterminarGanadorEnvido_DeberiaGanarJug1(int jug1, int jug2)
        {
            Partida partida = DevolverPartidaPrueba();
            partida.Jugadores[0].EsMano = true;
            partida.Jugadores[0].CantoEnvido = true;
            partida.Jugadores[1].CantoEnvido = true;


            string? ganador = partida.DeterminarGanadorEnvido(jug1, jug2);

            Assert.IsNotNull(ganador);
            Assert.AreEqual(partida.Jugadores[0].NombreUsuario + " ganó envido", ganador);
            Assert.AreEqual(2, partida.Jugadores[0].PuntosPartida);
            Assert.AreNotEqual(partida.Jugadores[1].NombreUsuario + " ganó envido", ganador);
            Assert.AreEqual(0, partida.Jugadores[1].PuntosPartida);
        } 
        
        
        [DataRow(21, 32)]
        [DataRow(26, 28)]
        [DataRow(29, 29)]
        [TestMethod]
        public void DeterminarGanadorEnvido_DeberiaGanarJug2(int jug1, int jug2)
        {
            Partida partida = DevolverPartidaPrueba();
            partida.Jugadores[1].EsMano = true;
            partida.Jugadores[1].CantoEnvido = true;
            partida.Jugadores[0].CantoEnvido = true;

            string? ganador = partida.DeterminarGanadorEnvido(jug1, jug2);

            Assert.IsNotNull(ganador);
            Assert.AreEqual(partida.Jugadores[1].NombreUsuario + " ganó envido", ganador);
            Assert.AreEqual(2, partida.Jugadores[1].PuntosPartida);
            Assert.AreNotEqual(partida.Jugadores[0].NombreUsuario + " ganó envido", ganador);
            Assert.AreEqual(0, partida.Jugadores[0].PuntosPartida);
        }
        
        [DataRow(25, 30)]
        [DataRow(26, 24)]
        [TestMethod]
        public void DeterminarGanadorEnvido_Deberia(int jug1, int jug2)
        {
            Partida partida = DevolverPartidaPrueba();
            partida.Jugadores[0].CantoEnvido = true;
            partida.Jugadores[1].CantoEnvido = true;

            string? ganador = partida.DeterminarGanadorEnvido(jug1, jug2);

            Assert.IsNotNull(ganador);
            Assert.IsTrue(partida.Jugadores[1].NombreUsuario + " ganó envido" == ganador || partida.Jugadores[0].NombreUsuario + " ganó envido" == ganador);
            Assert.IsTrue(2 == partida.Jugadores[1].PuntosPartida && partida.Jugadores[0].PuntosPartida == 0 || 2 == partida.Jugadores[0].PuntosPartida && partida.Jugadores[1].PuntosPartida == 0);
        }

        [TestMethod]
        public void AsignarTurno_DeberiaDarleElTurnoAlJug2() 
        {
            Partida partida = DevolverPartidaPrueba();

            bool EsTurnoDeJug2 = partida.AsignarTurno();

            Assert.IsTrue(EsTurnoDeJug2 && partida.Jugadores[1].CartaJugada is null && partida.Jugadores[0].CartaJugada is null);
        }
        
        [TestMethod]
        public void AsignarTurno_DeberiaDarleElTurnoAlJug2ConCartas() 
        {
            Partida partida = DevolverPartidaPrueba();
            partida.Jugadores[1].CartaJugada = new Carta(1, "espada", EValores.AnchoEspada);
            partida.Jugadores[0].CartaJugada = new Carta(3, "basto", EValores.Tres);

            bool EsTurnoDeJug2 = partida.AsignarTurno();

            Assert.IsTrue(EsTurnoDeJug2);
            Assert.IsNotNull(partida.Jugadores[0].CartaJugada);
            Assert.IsNotNull(partida.Jugadores[1].CartaJugada);
        }

        [TestMethod]
        public void AsignarTurno_DeberiaDarleElTurnoAlJug1() 
        {
            Partida partida = DevolverPartidaPrueba();
            partida.Jugadores[1].CartaJugada = new Carta(1, "espada", EValores.AnchoEspada);

            bool EsTurnoDeJug2 = partida.AsignarTurno();

            Assert.IsFalse(EsTurnoDeJug2 && partida.Jugadores[0].CartaJugada is null);
        }

        [TestMethod]
        public void AsignarTurno_DeberiaDarleElTurnoAlJug1ConCartas()
        {
            Partida partida = DevolverPartidaPrueba();
            partida.Jugadores[0].CartaJugada = new Carta(7, "espada", EValores.SieteEspada);
            partida.Jugadores[1].CartaJugada = new Carta(2, "basto", EValores.Dos);

            bool EsTurnoDeJug2 = partida.AsignarTurno();

            Assert.IsFalse(EsTurnoDeJug2);
            Assert.IsNotNull(partida.Jugadores[0].CartaJugada);
            Assert.IsNotNull(partida.Jugadores[1].CartaJugada);
        }


        //[DataRow (15,13)]
        //[DataRow (14,16)]
        //[TestMethod]
        //public void AsignarPuntos_Deberia(int jug1, int jug2)
        //{
        //    List<Usuario> jugadores = CrearPartidaPrueba();
        //    Partida partida = new Partida(0, jugadores, DateTime.Now);
        //    jugadores[0].PuntosPartida = jug1;
        //    jugadores[1].PuntosPartida = jug2;

        //    partida.AsignarPuntos();

        //}
    }
}
