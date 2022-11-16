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
        bool cantoRetruco = false;
        bool cantoQuieroVale4 = false;
        int puntosPartida;
        int manosGanadas;
        int partidasGanadas;
        int partidasPerdidas;
        bool estaJugando = false;

        public Usuario(int id, string? nombreUsuario, string? contraseña)
        {
            this.id = id;
            this.contraseña = contraseña;
            this.nombreUsuario = nombreUsuario;
            cartas = new List<Carta>();
            cartasJugadas = new List<Carta>();
        }
        public Usuario(int id, string? nombreUsuario, string? contraseña, int partidasGanadas, int partidasPerdidas) : this(id, nombreUsuario, contraseña)
        {
            this.partidasPerdidas = partidasPerdidas;
            this.partidasGanadas = partidasGanadas;
        }

        public string? NombreUsuario { get { return nombreUsuario; } } 
        public int Id { get { return id; } } 
        public bool EsMano { get { return esMano; } set { esMano = value; } } 
        public bool CantoEnvido { get { return cantoEnvido; } set { cantoEnvido = value; } } 
        public bool CantoFaltaEnvido { get { return cantoFaltaEnvido; } set { cantoFaltaEnvido = value; } } 
        public bool CantoTruco { get { return cantoTruco; } set { cantoTruco = value; } } 
        public bool CantoRetruco { get { return cantoRetruco; } set { cantoRetruco = value; } } 
        public bool CantoQuieroVale4 { get { return cantoQuieroVale4; } set { cantoQuieroVale4 = value; } } 
        public List<Carta> Cartas { get { return cartas; } set { cartas = value; } } 
        public List<Carta> CartasJugadas { get { return cartasJugadas; } set { cartasJugadas = value; } } 
        public Carta CartaJugada { get { return cartaJugada; } set { cartaJugada = value; } } 
        public int ManosGanadas { get { return manosGanadas; } set { manosGanadas = value; } } 
        public int PuntosPartida { get { return puntosPartida; } set { puntosPartida = value; } } 
        public int PartidasGanadas { get { return partidasGanadas; } set { partidasGanadas = value; } } 
        public int PartidasPerdidas { get { return partidasPerdidas; } set { partidasPerdidas = value; } }
        public bool EstaJugando { get { return estaJugando; } set { estaJugando = value; } }
         
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
            cantoRetruco = false;
            cantoQuieroVale4 = false;
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
