using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_9
{
    internal class Pelota
    {
        public string marca { get; set; }
        public double gramos { get; set; }
        public double presionLibras { get; set; }
        public double diametroCm { get; set; }
        public double precio { get; set; }

        public Pelota(string marca, double gramos, double presionLibras, double diametroCm, double precio)
        {
            this.marca = marca;
            this.gramos = gramos;
            this.presionLibras = presionLibras;
            this.diametroCm = diametroCm;
            this.precio = precio;
        }

        public double HallarRadio()
        {
            return diametroCm / 2;
        }
        public double VolumenBalon()
        {
            return (4.0 / 3.0) * 3.1416 * Math.Pow(HallarRadio(), 3);
        }

        public double HallarDescuento()
        {
            return 0.10 * precio;
        }

        public double HallarImportePagar()
        {
            return precio - HallarDescuento();
        }

    }
}
