using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelo
{
    public class Usuario
    {
        int id;
        string? nombreUsuario;
        string? contraseña;
        List<Carta> cartas;
        List<Carta> cartasJugadas;
        Carta cartaJugada;
        bool esMano = false;
        bool cantoEnvido = false;
        bool cantoFaltaEnvido = false;
        bool cantoTruco = false;
        bool sacoFlor = false;
        int puntosPartida;
        int manosGanadas;
        int partidasGanadas;
        int partidasPerdidas;
        int cantSacoFaltaEnvido;
        int cantAnchosDeEspada;
        bool estaJugando = false;

        public Usuario(int id, string? nombreUsuario, string? contraseña)
        {
            this.id = id;
            this.contraseña = contraseña;
            this.nombreUsuario = nombreUsuario;
            cartas = new List<Carta>();
            cartasJugadas = new List<Carta>();
        }

        public Usuario(int id, string? nombreUsuario, string? contraseña, int partidasGanadas, int partidasPerdidas, int cantAnchosDeEspada, int cantSacoFaltaEnvido) : this(id, nombreUsuario, contraseña)
        {
            this.partidasPerdidas = partidasPerdidas;
            this.partidasGanadas = partidasGanadas;
            this.cantSacoFaltaEnvido = cantSacoFaltaEnvido;
            this.cantAnchosDeEspada = cantAnchosDeEspada;
        }

        public string? NombreUsuario { get { return nombreUsuario; } } 
        public int Id { get { return id; } } 
        public bool EsMano { get { return esMano; } set { esMano = value; } } 
        public bool CantoEnvido { get { return cantoEnvido; } set { cantoEnvido = value; } } 
        public bool CantoFaltaEnvido { get { return cantoFaltaEnvido; } set { cantoFaltaEnvido = value; } } 
        public bool CantoTruco { get { return cantoTruco; } set { cantoTruco = value; } } 
        public bool SacoFlor { get { return sacoFlor; } set { sacoFlor = value; } }
        public List<Carta> Cartas { get { return cartas; } set { cartas = value; } } 
        public List<Carta> CartasJugadas { get { return cartasJugadas; } set { cartasJugadas = value; } } 
        public Carta CartaJugada { get { return cartaJugada; } set { cartaJugada = value; } } 
        public int ManosGanadas { get { return manosGanadas; } set { manosGanadas = value; } } 
        public int PuntosPartida { get { return puntosPartida; } set { puntosPartida = value; } } 
        public int PartidasGanadas { get { return partidasGanadas; } set { partidasGanadas = value; } } 
        public int PartidasPerdidas { get { return partidasPerdidas; } set { partidasPerdidas = value; } }
        public bool EstaJugando { get { return estaJugando; } set { estaJugando = value; } }
        public int CantSacoFaltaEnvido { get { return cantSacoFaltaEnvido; } set { cantSacoFaltaEnvido = value; } }
        public int CantAnchosDeEspada { get { return cantAnchosDeEspada; } set { cantAnchosDeEspada = value; } }
         
        /// <summary>
        /// comprueva si la contraseña ingresada es igual a la contraseña del usuario
        /// </summary>
        /// <param name="contraseñaIngresada"></param>
        /// <returns></returns>
        public bool ComprobarContraseña(string? contraseñaIngresada)
        {
            if (contraseña == contraseñaIngresada)
            {
                return true;
            }
            return false;
        }
        
        /// <summary>
        /// busca que las 3 cartas del jugador sean del mismo palo
        /// </summary>
        /// <returns></returns>
        public bool BuscarFlor()
        {
            if (cartas[0].Palo == cartas[1].Palo && cartas[1].Palo == cartas[2].Palo && cartas[0].Palo == cartas[2].Palo)
            {
                sacoFlor = true;
                return true;
            }
            return false;
        }


        /// <summary>
        /// devuelve la cantidad de envido que tiene un jugador, teniendo en cuenta si había alguna 
        /// carta de número superior a 9 o si ambas eran ese tipo de cartas. 
        /// </summary>
        /// <param name="jugador"></param>
        /// <returns></returns>
        public int DecirEnvido(/*Usuario jugador*/)
        {
            int envido = 0;
            for (int i = 0; i < cartas.Count; i++)
            {
                for (int j = i + 1; j < cartas.Count; j++)
                {
                    if (cartas[i].Palo == cartas[j].Palo)
                    {
                        int numeroUno = cartas[i].Numero;
                        int numeroDos = cartas[j].Numero;
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
        /// determina si quiere o no quiere truco según si en el total de cartas que tiene el jugador
        /// tiene por lo menos una carta mayor a un 2
        /// </summary>
        /// <param name="jugador"></param>
        /// <returns></returns>
        public string ContestarTruco()
        {
            string mensaje = "";
            List<Carta> cartasTotales = new List<Carta>();
            foreach (Carta item in cartas)
            {
                cartasTotales.Add(item);
            }
            foreach (Carta item in cartasJugadas)
            {
                cartasTotales.Add(item);
            }

            foreach (Carta item in cartasTotales)
            {
                if ((int)item.Valor < 6)
                {
                    mensaje = "Quiero";
                    cantoTruco = true;
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
        /// setea todos los atributos del usuario para que pueda jugar una nueva vuelta
        /// </summary>
        public void TerminarVuelta()
        {
            cartas.Clear();
            cartasJugadas.Clear();
            manosGanadas = 0;
            cartaJugada = null;
            cantoEnvido = false;
            cantoFaltaEnvido = false;
            cantoTruco = false;
            sacoFlor = false;
        }

        /// <summary>
        /// setea los atributos del usuario para que pueda jugar una nueva partida
        /// </summary>
        public void TerminarPartida()
        {
            puntosPartida = 0;
            esMano = false;
            estaJugando = false;
        }

    }
}
