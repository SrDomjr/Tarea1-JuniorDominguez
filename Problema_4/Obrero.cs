using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4
{
    internal class Obrero
    {

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int HorasTrabajadas { get; set; }
        public double Tarifa { get; set; }

        public Obrero(int codigo, string nombre, int horasTrabajadas, double tarifa)
        {
            Codigo = codigo;
            Nombre = nombre;
            HorasTrabajadas = horasTrabajadas;
            Tarifa = tarifa;
        }

        public double CalcularSueldoBruto()
        {
            return HorasTrabajadas * Tarifa;
        }

        public double CalcularDescuentoAfp()
        {
            return 0.10 * CalcularSueldoBruto();
        }

        public double CalcularDescuentoEsp()
        {
            return 0.05 * CalcularSueldoBruto();
        }
        public double CalcularSueldoNeto()
        {
            return CalcularSueldoBruto() - CalcularDescuentoAfp() - CalcularDescuentoEsp();

        }
    }
}
