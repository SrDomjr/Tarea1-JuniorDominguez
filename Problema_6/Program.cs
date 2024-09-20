using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Paciente pa = new Paciente("Elmost", "Lopez", 20, 1.7, 50);
            Listado(pa);
            Console.WriteLine("_________________________");

            pa.Edad = 17;
            Listado(pa);

            Console.ReadKey();


        }

        public static void Listado(Paciente pac)
        {
            Console.WriteLine();
            Console.WriteLine("Nombre: " + pac.Nombre);
            Console.WriteLine("Apellido: " + pac.Apellido);
            Console.WriteLine("Edad: " + pac.Edad);
            Console.WriteLine("Talla: " + pac.Talla);
            Console.WriteLine("Peso: " + pac.Peso);
            Console.WriteLine("Mayor o Menor de edad: " + pac.Texto());

        }
    }
    }
}
