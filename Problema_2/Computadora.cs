using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    internal class Computadora
    {

        public int Codigo { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public double PrecioDolar { get; set; }

        public Computadora(int codigo, string marca, string color, double precioDolar)
        {
            Codigo = codigo;
            Marca = marca;
            Color = color;
            PrecioDolar = precioDolar;
        }

        public double calcularPrecioCompuSoles()
        {
            return PrecioDolar * 3.35;
        }

        public double calcularPrecioCompuEuros()
        {
            return PrecioDolar / 1.20;
        }

    }
}
