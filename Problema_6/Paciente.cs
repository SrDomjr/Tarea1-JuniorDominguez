using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_6
{
    internal class Paciente
    {

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public double Talla { get; set; }
        public double Peso { get; set; }

        public Paciente(string nombre, string apellido, int edad, double talla, double peso)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Talla = talla;
            Peso = peso;
        }

        public string Texto()
        {
            if (Edad >= 18)
            {
                return "Mayor de edad";
            }
            else
            {
                return "Menor de edad";
            }
        }
    }
}
