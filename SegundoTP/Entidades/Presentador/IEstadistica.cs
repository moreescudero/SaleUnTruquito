using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Presentador
{
    public interface IEstadistica
    {
        string PartidasGanadas { get; set; }
        string PartidasPerdidas { get; set; }
        string FaltaEnvido { get; set; }
        string AnchoEspada { get; set; }
        string Activo { get; set; }

        void CargarDgv(Object obj);
    }
}
