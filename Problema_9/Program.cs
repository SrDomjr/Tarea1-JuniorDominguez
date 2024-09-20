using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pelota pe = new Pelota("Adidas", 500, 33, 30, 100);
            Listar(pe);


            Console.WriteLine("___________________________");
            pe.precio *= 0.75;
            pe.diametroCm += 1;
            Listar(pe);

            Console.ReadKey();
        }

        public static void Listar(Pelota pel)
        {
            Console.WriteLine("Marca: " + pel.marca);
            Console.WriteLine("Peso en gramos: " + pel.gramos);
            Console.WriteLine("Presion en libras: " + pel.presionLibras);
            Console.WriteLine("Diametro en cm: " + pel.diametroCm);
            Console.WriteLine("Precio: " + pel.precio);
            Console.WriteLine("Radio: " + pel.HallarRadio());
            Console.WriteLine("Volumen balon: " + pel.VolumenBalon());
            Console.WriteLine("Descuento: " + pel.HallarDescuento());
            Console.WriteLine("Importe a pagar: " + pel.HallarImportePagar());


        }
    }
    
}
