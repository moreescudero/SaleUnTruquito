using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Presentador
{
    public interface ILogin
    {
        string? NombreUsuario { get; set; }
        string? Contraseña { get; }
        string? UsuarioIncorrecto { get; set; }
        string? ContraseñaIncorrecta { get; set; }

        void IngresarAlMenuPrincipal();
        void Ingresar();
        void Limpiar();
    }
}
