using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_8
{
    internal class Asesor
    {

        public int Codigo { get; set; }
        public string nombre { get; set; }
        public int horasTrabajadas { get; set; }
        public double tarifa { get; set; }

        public Asesor(int codigo, string nombre, int horasTrabajadas, double tarifa)
        {
            Codigo = codigo;
            this.nombre = nombre;
            this.horasTrabajadas = horasTrabajadas;
            this.tarifa = tarifa;
        }

        public double CalcularSueldoBruto()
        {
            return horasTrabajadas * tarifa;

        }

        public double CalcularDescuento()
        {
            return 0.15 * CalcularSueldoBruto();
        }

        public double CalcularSueldoNeto()
        {
            return CalcularSueldoBruto() - CalcularDescuento();
        }
    }
}
