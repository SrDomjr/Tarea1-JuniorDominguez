using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celular celu = new Celular(987654321, "Junior", 300, 0.5);
            Listado(celu);


            celu.SegConsumidos += 20;
            celu.PrecioXseg *= 0.95;
            Listado(celu);

            Console.ReadKey();
        }

        public static void Listado(Celular Celular)
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine("Número: " + Celular.Numero);
            Console.WriteLine("Usuario: " + Celular.Usuario);
            Console.WriteLine("Segundos Consumidos: " + Celular.SegConsumidos);
            Console.WriteLine("Precio por Segundo: " + Celular.PrecioXseg);
            Console.WriteLine("Costo por Consumo: " + Celular.CalcularCostoxConsumo());
            Console.WriteLine("Impuesto IGV: " + Celular.CalcularImpuestoxIgv());
            Console.WriteLine("Total a Pagar: " + Celular.CalcularTotalPagar());
            Console.WriteLine("*********************************************");

        }

    }
    
}
