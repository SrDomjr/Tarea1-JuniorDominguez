using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_2
{
    internal class Celular
    {

        public int Numero { get; private set; }
        public string Usuario { get; private set; }
        public int SegConsumidos { get; set; }
        public double PrecioXseg { get; set; }

        public Celular(int numero, string usuario, int segConsumidos, double precioXseg)
        {
            this.Numero = numero;
            this.Usuario = usuario;
            this.SegConsumidos = segConsumidos;
            this.PrecioXseg = precioXseg;
        }

        public double CalcularCostoxConsumo()
        {
            return SegConsumidos * PrecioXseg;
        }

        public double CalcularImpuestoxIgv()
        {
            return 0.18 * CalcularCostoxConsumo();
        }

        public double CalcularTotalPagar()
        {
            return CalcularCostoxConsumo() + CalcularImpuestoxIgv();
        }
    }
}
