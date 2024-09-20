using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Asesor ase = new Asesor(1002, "Junior", 23, 300);
            Listar(ase);


            Console.WriteLine("__________________________");
            ase.horasTrabajadas += 10;
            ase.tarifa *= 0.85;

            Listar(ase);

            Console.ReadKey();
        }

        public static void Listar(Asesor ases)
        {
            Console.WriteLine("Codigo: " + ases.Codigo);
            Console.WriteLine("Nombre: " + ases.nombre);
            Console.WriteLine("Horas trabajadas: " + ases.horasTrabajadas);
            Console.WriteLine("Tarifa por hora: " + ases.tarifa);
            Console.WriteLine("Sueldo bruto: " + ases.CalcularSueldoBruto());
            Console.WriteLine("Descuento: " + ases.CalcularDescuento());
            Console.WriteLine("Sueldo neto: " + ases.CalcularSueldoNeto());



        }
    }
    
}
