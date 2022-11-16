using Entidades.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Presentador
{
    public class PresentadorMenuPrincipal
    {
        IMenuPrincipal menu;
        List<Partida> partidas;
        public static List<Usuario> usuarios;
        //List<Usuario> jugadores;
        public static Usuario usuarioActivo;

        public PresentadorMenuPrincipal (IMenuPrincipal menu)
        {
            this.menu = menu;
            ObtenerPartidas();
            usuarioActivo = PresentadorLogin.usuarioActivo;
            usuarios = PresentadorLogin.usuarios;
            partidas = new List<Partida>();
        }

        private int ObtenerUltimoID()
        {
            foreach (Partida partida in partidas)
            {
                if(partidas.Last() == partida)
                {
                    return partida.Id;
                }
            }
            return -1;
        }

        /// <summary>
        /// Obtiene las partidas de la base de datos
        /// </summary>
        public void ObtenerPartidas()
        {
            try
            {
                ConexionPartidas conexionPartidas = new ConexionPartidas();
                partidas = conexionPartidas.ObtenerPartidas(); 
            }
            catch(Exception ex)
            {
                menu.HabilitarPanel = true;
                menu.ErrorPanel = ex.Message;
            }
            //en el dgv solo se van a mostrar las partidas activas asi que a penas se ingrese a este frm
            //se deberian crear automaticamente entre 2 y 4 partidas para simular que ya exista gente jugando
        }

        /// <summary>
        /// muestra el usuario del jugador activo en un label 
        /// </summary>
        public void MostrarJugadorActivo()
        {
            menu.Bienvenido += usuarioActivo.NombreUsuario;
        }

        /// <summary>
        /// carga el datagridview con la lista de usuarios con mas cantidad de partidas ganadas
        /// </summary>
        public void CargarDataGridUsuarios()
        {
            // que en este dgv se muestren los usuarios con más cantidad de partidas ganadas
            menu.CargarDgvUsuarios(usuarios);
        }

        /// <summary>
        /// 
        /// </summary>
        public void CargarDataGridPartidas()
        {
            if(partidas.Count > 0)
            {
                partidas.ForEach((x) => x.ActivarEventoFinalizarPartida());
                partidas.Clear();
            }

            Random rnd = new Random();
            int tope = rnd.Next(1, 5);
            for (int i = 0; i < 3; i++)
            {
                partidas.Add(new Partida(0, AsignarJugadoresRandom(), DateTime.Now));
            }
            menu.CargarDgvPartidas(partidas);
        }

        /// <summary>
        /// actualiza la informacion de los usuarios (partidas ganadas y perdidas) en la base de datos 
        /// </summary>
        public void GuardarInfoUsuarios()
        {
            try
            {
                ConexionUsuarios conexionUsuarios = new ConexionUsuarios();
                conexionUsuarios.ModificarUsuarios(usuarios);
            }
            catch (Exception ex)
            {
                menu.HabilitarPanel = true;
                menu.ErrorPanel = ex.Message;
            }             
        }

        /// <summary>
        /// asigna 2 jugadores random disponibles a excepción del usuario activo y quienes se encuentren en otro partida
        /// </summary>
        private List<Usuario> AsignarJugadoresRandom()
        {
            List<Usuario> jugadores = new List<Usuario>();
            Random rnd = new Random();
            do
            {
                int indice = rnd.Next(0, usuarios.Count());
                Usuario usuario =usuarios[indice];
                if (!jugadores.Contains(usuario) && usuario != usuarioActivo && !usuario.EstaJugando)
                {
                    jugadores.Add(usuarios[indice]);
                }
            } while (jugadores.Count < 2);

            return jugadores;
        }

        public Partida DevolverPartidaElegida(int indice)
        {
            Partida partida = partidas[indice];
            partida.Id = (ObtenerUltimoID() + 1);
            partidas.Remove(partida);

            return partida;
        }

    }
}
