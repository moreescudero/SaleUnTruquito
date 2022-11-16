using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelo
{
    public class Partida
    {
        int id;
        bool activa = true;
        List<Usuario> jugadores = new List<Usuario>();
        DateTime fecha;
        string? ganador;
        public event Action<List<Carta>> eventoMazo; 
        public event Action eventoFinalizarPartida; 

        public Partida (int id)
        {
            this.id = id;
            activa = true;
            eventoMazo = Barajar;
            eventoMazo += Repartir;
            eventoFinalizarPartida = FinalizarVuelta;
            eventoFinalizarPartida += AsignarPuntos;
            eventoFinalizarPartida += FinalizarPartida;
        }

        public Partida(int id,  string ganador, DateTime fecha) : this (id)
        {
            activa = false;
            this.ganador = ganador;
            this.fecha = fecha;
        }
        public Partida(int id, List<Usuario> jugadores, DateTime fecha) : this(id)
        {
            this.jugadores = jugadores;
            this.fecha = fecha;
            jugadores.ForEach((x) => x.EstaJugando = true);
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public List<Usuario> Jugadores
        {
            get { return jugadores; }
        }

        public string? Ganador
        {
            get { return ganador; }
            set { ganador = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string? JugadorUno
        {
            get { return jugadores[0].NombreUsuario; }
        }
        
        public string? JugadorDos
        {
            get { return jugadores[1].NombreUsuario; }
        }

        public bool Activa
        {
            get { return activa; }
            set { activa = value; }
        }

        /// <summary>
        /// deserializa el mazo de cartas y activa el evento eventoMazo para que se pueda acceder 
        /// desde el presentador
        /// </summary>
        public void ActivarEventoMazo()
        {
            Mazo mazoAux = Serializador<Mazo>.LeerJSon("mazo.json");
            List<Carta> mazo = mazoAux.Mazos;
            eventoMazo(mazo);
        }

        /// <summary>
        /// activa el evento eventoFinalizarPartida para que se pueda acceder desde el presentador
        /// </summary>
        public void ActivarEventoFinalizarPartida()
        {
            eventoFinalizarPartida();
        }

        /// <summary>
        /// "mezcla el mazo" eligiendo 6 cartas aleatorias
        /// </summary>
        /// <param name="mazo"></param>
        public void Barajar(List<Carta> mazo)
        {
            if (mazo is not null)
            {
                List<Carta> mazoMezclado = new List<Carta>();
                Random rnd = new Random();
                int indice;

                for (int i = 0; i < 6; i++)
                {
                    indice = rnd.Next(0, mazo.Count());
                    mazoMezclado.Add(mazo[indice]);
                    mazo.RemoveAt(indice);
                }
                mazo.Clear();
                for (int i = 0; i < 6; i++)
                {
                    mazo.Add(mazoMezclado[i]);
                }
            }
            else
            {
                throw new NullReferenceException("Mazo no cargado");
            }
        }

        /// <summary>
        /// reparte 3 cartas a cada jugador
        /// </summary>
        /// <param name="mazo"></param>
        public void Repartir(List<Carta> mazo)
        {
            if (mazo is not null)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (i < 3)
                    {
                        jugadores[0].Cartas.Add(mazo[i]);
                    }
                    else
                    {
                        jugadores[1].Cartas.Add(mazo[i]);
                    }
                }
            }
            else
            {
                throw new NullReferenceException("Mazo no cargado");
            }
        }

        /// <summary>
        /// elige cuál es la carta más conveniente de tirar teniendo en cuenta si todavía no se tiraron cartas que 
        /// el jugador juegue su mejor carta, si el contrincante ya tiró una carta entonces toma en cuenta si
        /// tiene alguna carta que pueda ganarle y la tira, sino tira la de menor valor
        /// </summary>
        /// <param name="jugador"></param>
        /// <param name="cartaContrincante"></param>
        /// <returns></returns>
        private Carta? TirarCarta(Usuario jugador, Carta cartaContrincante)
        {
            Carta? cartaElegida = null;
            bool gana = false;
            if(jugadores[0].Cartas.Count == jugadores[1].Cartas.Count)
            {
                cartaContrincante = null;
            }
            if (cartaContrincante is not null)
            {
                for (int i = 0; i < jugador.Cartas.Count; i++)
                {
                    if (cartaContrincante.Valor > jugador.Cartas[i].Valor)
                    {
                        gana = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < jugador.Cartas.Count; i++)
            {
                if (cartaContrincante is null || cartaElegida is null || (cartaContrincante is not null && gana))
                {
                    if (cartaElegida is null || cartaElegida.Valor > jugador.Cartas[i].Valor)
                    {
                        cartaElegida = jugador.Cartas[i];
                        if (cartaContrincante is not null && cartaElegida.Valor < cartaContrincante.Valor)
                        {
                            break;
                        }
                    }
                }
                else if (cartaContrincante is not null && !gana)
                {
                    if (cartaElegida.Valor < jugador.Cartas[i].Valor)
                    {
                        cartaElegida = jugador.Cartas[i];
                    }
                }
            }
            return cartaElegida;
        }

        /// <summary>
        /// llama a un método, remueve la carta elegida de las cartas que tiene el jugador en mano y la 
        /// agrega a las cartas en mesa
        /// </summary>
        /// <param name="jugador"></param>
        /// <param name="cartaContrincante"></param>
        /// <returns></returns>
        public Carta Jugar(Usuario jugador, Carta cartaContrincante)
        {
            try
            {
                jugador.CartaJugada = TirarCarta(jugador, cartaContrincante);
                jugador.Cartas.Remove(jugador.CartaJugada);
                jugador.CartasJugadas.Add(jugador.CartaJugada);
                return jugador.CartaJugada;
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new ArgumentOutOfRangeException("Existen datos nulos");
            }
        }

        /// <summary>
        /// suma manos ganadas cuando los dos jugadores tiraron una carta cada uno 
        /// </summary>
        public void SumarMano()
        {
            if (jugadores[0].CartaJugada is not null && jugadores[1].CartaJugada is not null)
            {
                if (jugadores[0].CartaJugada.Valor < jugadores[1].CartaJugada.Valor)
                {
                    jugadores[0].ManosGanadas++;
                }
                else if (jugadores[0].CartaJugada.Valor > jugadores[1].CartaJugada.Valor)
                {
                    jugadores[1].ManosGanadas++;
                }
                else
                {
                    if (jugadores[0].CartasJugadas.Count > 0 && jugadores[1].CartasJugadas.Count > 0)
                    {
                        if (jugadores[0].CartasJugadas[0].Valor < jugadores[1].CartasJugadas[0].Valor)
                        {
                            jugadores[0].ManosGanadas++;
                        }
                        else
                        {
                            jugadores[1].ManosGanadas++;
                        }
                    }
                    else
                    {
                        jugadores[0].ManosGanadas++;
                        jugadores[1].ManosGanadas++;
                    }
                }
            }
        }

        /// <summary>
        /// busca que el jugador tenga dos cartas del mismo palo
        /// </summary>
        /// <param name="jugador"></param>
        /// <returns></returns>
        public bool CantarEnvido(Usuario jugador)
        {
            for (int i = 0; i < jugador.Cartas.Count; i++)
            {
                for (int j = i + 1; j < jugador.Cartas.Count; j++)
                {
                    if (jugador.Cartas[i].Palo == jugador.Cartas[j].Palo)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        /// <summary>
        /// devuelve la cantidad de envido que tiene un jugador, teniendo en cuenta si había alguna 
        /// carta de número superior a 9 o si ambas eran ese tipo de cartas. 
        /// </summary>
        /// <param name="jugador"></param>
        /// <returns></returns>
        public int DecirEnvido(Usuario jugador)
        {
            int envido = 0;
            for (int i = 0; i < jugador.Cartas.Count; i++)
            {
                for (int j = i + 1; j < jugador.Cartas.Count; j++)
                {
                    if (jugador.Cartas[i].Palo == jugador.Cartas[j].Palo)
                    {
                        int numeroUno = jugador.Cartas[i].Numero;
                        int numeroDos = jugador.Cartas[j].Numero;
                        if (numeroUno >= 10)
                        {
                            numeroUno = 20;
                        }
                        if (numeroDos >= 10)
                        {
                            numeroDos = 20;
                        }
                        if (numeroUno == 20 || numeroDos == 20)
                        {
                            if (numeroUno == 20 && numeroDos == 20)
                            {
                                envido = 20;
                            }
                            else
                            {
                                envido = numeroUno + numeroDos;
                            }
                        }
                        else
                        {
                            envido = numeroUno + numeroDos + 20;
                        }

                        break;
                    }
                }
            }
            return envido;
        }


        /// <summary>
        /// Determina el ganador del envido según quien haya ganado en numero o, si empataron, según quién 
        /// es mano
        /// </summary>
        /// <param name="jugadorUno"></param>
        /// <param name="jugadorDos"></param>
        /// <returns></returns>
        public string? DeterminarGanadorEnvido(int jugadorUno, int jugadorDos)
        {
            string retorno = "";
            if (jugadorUno > jugadorDos || (jugadores[0].EsMano && jugadorUno == jugadorDos))
            {
                if (jugadores[0].CantoEnvido || jugadores[1].CantoEnvido)
                {
                    jugadores[0].PuntosPartida += 2;
                    retorno = jugadores[0].NombreUsuario + " ganó envido";
                }
                else if (jugadores[0].CantoFaltaEnvido || jugadores[1].CantoFaltaEnvido)
                {
                    int puntos = 15 - jugadores[1].PuntosPartida;
                    jugadores[0].PuntosPartida += puntos;
                    retorno = jugadores[0].NombreUsuario + " ganó falta envido";
                }
            }
            else if (jugadorUno < jugadorDos || (jugadores[1].EsMano && jugadorUno == jugadorDos))
            {
                if (jugadores[0].CantoEnvido || jugadores[1].CantoEnvido)
                {
                    jugadores[1].PuntosPartida += 2;
                    retorno = jugadores[1].NombreUsuario + " ganó envido";
                }
                else if (jugadores[0].CantoFaltaEnvido || jugadores[1].CantoFaltaEnvido)
                {
                    int puntos = 15 - jugadores[0].PuntosPartida;
                    jugadores[1].PuntosPartida += puntos;
                    retorno = jugadores[1].NombreUsuario + " ganó falta envido";
                }
            }
            return retorno;
        }

        /// <summary>
        /// determina si quiere o no quiere truco según si en el total de cartas que tiene el jugador
        /// tiene por lo menos una carta mayor a un 2
        /// </summary>
        /// <param name="jugador"></param>
        /// <returns></returns>
        public string ContestarTruco(Usuario jugador)
        {
            string mensaje = "";
            List<Carta> cartasTotales = new List<Carta>();
            foreach (Carta item in jugador.Cartas)
            {
                cartasTotales.Add(item);
            }
            foreach (Carta item in jugador.CartasJugadas)
            {
                cartasTotales.Add(item);
            }

            foreach (Carta item in cartasTotales)
            {
                if ((int)item.Valor < 6)
                {
                    mensaje = "Quiero";
                    jugador.CantoTruco = true;
                    break;
                }
                else
                {
                    mensaje = "No quiero";
                }
            }
            return mensaje;
        }

        /// <summary>
        /// asigna el turno segun quien no haya tirado una carta o quien haya ganado la mano y
        /// debe tirar una carta
        /// </summary>
        /// <returns></returns>
        public bool AsignarTurno()
        {
            if (jugadores[1].CartaJugada is not null && jugadores[0].CartaJugada is not null)
            {
                if (jugadores[0].CartaJugada.Valor < jugadores[1].CartaJugada.Valor)
                {
                    return false;
                }
                return true;
            }
            else if (jugadores[1].CartaJugada is null)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        /// <summary>
        /// según quién haya ganado la partida le agrega una partida ganada y al perdedor le agrega
        /// una partida perdida
        /// </summary>
        private void AsignarPuntos()
        {
            if (jugadores[0].PuntosPartida > jugadores[1].PuntosPartida)
            {
                jugadores[0].PartidasGanadas++;
                ganador = jugadores[0].NombreUsuario;
                jugadores[1].PartidasPerdidas++;
            }
            else if(jugadores[0].PuntosPartida < jugadores[1].PuntosPartida)
            {
                jugadores[1].PartidasGanadas++;
                ganador = jugadores[1].NombreUsuario;
                jugadores[0].PartidasPerdidas++;
            }
        }

        /// <summary>
        /// setea todos los atributos de los jugadores para volver a jugar una vuelta
        /// </summary>
        public void FinalizarVuelta()
        {
            jugadores.ForEach((x) => x.TerminarVuelta());
        }

        /// <summary>
        /// setea todos los atributos de los jugadores para volver a jugar una partida
        /// </summary>
        public void FinalizarPartida()
        {
            //FinalizarVuelta();
            //AsignarPuntos();
            jugadores.ForEach((x) => x.TerminarPartida());
        }
    }
}
