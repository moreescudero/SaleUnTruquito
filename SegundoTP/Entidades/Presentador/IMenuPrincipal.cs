using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Presentador
{
    public interface IMenuPrincipal
    {
        string? Bienvenido { get; set; }
        string? UsuariosCargados { get; set; }
        string? ErrorPanel { set; }
        bool HabilitarBotonAbrirSala { get; set; }
        bool HabilitarPanel { set; }

        Task CrearPartida();
        void CargarDgvUsuarios(Object fuente);
        void CargarDgvPartidas(Object fuente);
    }
}
