using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Video vi = new Video(1002, "El video de elmo", 3, 100, 3.7);
            Listar(vi);

            Console.WriteLine("_________Despues de modificar el precio____________");

            vi.precioSoles += 5.5;
            Listar(vi);

            Console.ReadKey();
        }

        public static void Listar(Video vide)
        {
            Console.WriteLine();
            Console.WriteLine("Codigo: " + vide.codigo);
            Console.WriteLine("Nombre Video: " + vide.nombreVideo);
            Console.WriteLine("Duracion: " + vide.duracion);
            Console.WriteLine("Precio en soles: " + vide.precioSoles);
            Console.WriteLine("Tipo de cambio: " + vide.tipoCambio);
            Console.WriteLine("Precio en dolares: " + vide.CalcularPrecioVideo());
            Console.WriteLine();
        }
    }
    
}
