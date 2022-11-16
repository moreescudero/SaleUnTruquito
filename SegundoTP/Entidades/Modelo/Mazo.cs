using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelo
{
    public class Mazo
    {
        List<Carta> mazos;

        public Mazo()
        {
            Mazos = new List<Carta>();
        }

        public List<Carta> Mazos
        {
            get { return mazos; }
            set { mazos = value; }
        }
    }
}
