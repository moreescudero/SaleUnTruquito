using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Presentador
{
    public interface ISala
    {
        string? UsuarioJugador1 { set; }
        string? UsuarioJugador2 { set; }
        string? Chat { get; set; }
        string? PuntosJug1 { set; }
        string? PuntosJug2 { set; }
        bool HayEnvido { get; set; }

        void FrenarTimer();
        void LimpiarVuelta();
        void GuardarPartida(string? ganador);
        void CargarFondo();
        void TirarCartaEnMesa(string? carta, int jug);
        void LimpiarMesa();
        void MostrarError(string mensaje);
    }
}
