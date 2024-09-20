using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_7
{
    internal class Empleado
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int NumeroCelular { get; set; }
        public double SueldoSoles { get; set; }

        public Empleado(int codigo, string nombre, int numeroCelular, double sueldoSoles)
        {
            Codigo = codigo;
            Nombre = nombre;
            NumeroCelular = numeroCelular;
            SueldoSoles = sueldoSoles;
        }

        public string Texto()
        {
            if (SueldoSoles > 3500)
            {
                return "Mayor a 3500";
            }
            else if (SueldoSoles < 3500)
            {
                return "Menor 3500";
            }
            else
            {
                return "Igual a 3500";
            }
        }

    }
}
