using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelo
{
    public enum EValores
    {
        AnchoEspada,
        AnchoBasto,
        SieteEspada,
        SieteOro,
        Tres,
        Dos,
        Uno,
        Doce,
        Once,
        Diez,
        Siete,
        Seis,
        Cinco,
        Cuatro
    }

    public class Carta
    {
        int numero;
        string? palo;
        EValores valor;

        //public Carta ()
        //{

        //}
        public Carta(int numero, string? palo, EValores valor)
        {
            this.palo = palo;
            this.valor = valor;
            this.numero = numero;
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string? Palo
        {
            get { return palo; }
            set { palo = value; }
        }

        public EValores Valor
        {
            get { return valor; }
            set { valor = value; }
        }

    }
}
