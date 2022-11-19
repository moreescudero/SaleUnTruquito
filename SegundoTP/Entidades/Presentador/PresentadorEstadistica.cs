using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Modelo;

namespace Entidades.Presentador
{
    public class PresentadorEstadistica
    {
        IEstadistica estadistica;
        List<Partida> partidasGanadas;
        Usuario usuarioActivo = PresentadorLogin.usuarioActivo;

        public PresentadorEstadistica (IEstadistica estadistica)
        {
            this.estadistica = estadistica;
            partidasGanadas = new List<Partida>();
            ObtenerPartidasGanadas();
        }

        public void Cargar()
        {
            estadistica.PartidasGanadas += usuarioActivo.PartidasGanadas.ToString();
            estadistica.PartidasPerdidas += usuarioActivo.PartidasPerdidas.ToString();
            estadistica.FaltaEnvido += usuarioActivo.CantSacoFaltaEnvido.ToString();
            estadistica.AnchoEspada += usuarioActivo.CantAnchosDeEspada.ToString();
            estadistica.Activo += usuarioActivo.NombreUsuario;
        }

        private void ObtenerPartidasGanadas()
        {
            ConexionPartidas conexionPartidas = new ConexionPartidas();
            partidasGanadas = conexionPartidas.ObtenerPartidas(usuarioActivo.NombreUsuario);
        }

        public void CargarDgv()
        {
            estadistica.CargarDgv(partidasGanadas);
        }
    }
}
