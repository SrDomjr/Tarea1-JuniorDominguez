using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Obrero objObrero = new Obrero(1002, "Elmo", 30, 60);
            Listado(objObrero);

            Console.WriteLine("_______________________________________");

            objObrero.HorasTrabajadas += 8;
            objObrero.Tarifa *= 0.985;
            Listado(objObrero);


            Console.ReadKey();
        }

        public static void Listado(Obrero obre)
        {
            Console.WriteLine("Codigo: " + obre.Codigo);
            Console.WriteLine("Nombre: " + obre.Nombre);
            Console.WriteLine("Horas trabajadas: " + obre.HorasTrabajadas);
            Console.WriteLine("Tarifa Horaria: " + obre.Tarifa);
            Console.WriteLine("Sueldo Bruto: " + obre.CalcularSueldoBruto());
            Console.WriteLine("Descuento por AFP: " + obre.CalcularDescuentoAfp());
            Console.WriteLine("Descuento por EPS: " + obre.CalcularDescuentoEsp());
            Console.WriteLine("Sueldo neto: " + obre.CalcularSueldoNeto());


        }
    }
    
}
