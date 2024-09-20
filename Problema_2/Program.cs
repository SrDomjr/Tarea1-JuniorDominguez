using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computadora objCompu = new Computadora(10001, "Lenovo", "Gris", 1200);
            Listado(objCompu);


            Console.WriteLine("___________________________________");
            objCompu.PrecioDolar *= 0.90;
            Listado(objCompu);

            Console.ReadKey();

        }

        public static void Listado(Computadora compu)
        {

            Console.WriteLine();
            Console.WriteLine("Codigo            : " + compu.Codigo);
            Console.WriteLine("Marca             : " + compu.Marca);
            Console.WriteLine("Precio en dolares : " + compu.PrecioDolar);
            Console.WriteLine("Precio en soles   : " + compu.calcularPrecioCompuSoles());
            Console.WriteLine("Precio en Euros   : " + compu.calcularPrecioCompuEuros());
            Console.WriteLine();




        }

    }
    
}
