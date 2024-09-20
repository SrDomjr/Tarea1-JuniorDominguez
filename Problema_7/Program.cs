using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Empleado em = new Empleado(1002, "Junior", 987654321, 3400);
            Listar(em);


            Console.WriteLine("____________________________");
            em.NumeroCelular = 999888777;
            em.SueldoSoles += 200;
            Listar(em);


            Console.ReadKey();

        }

        public static void Listar(Empleado empl)
        {
            Console.WriteLine("Codigo: " + empl.Codigo);
            Console.WriteLine("Nombre: " + empl.Nombre);
            Console.WriteLine("Numero de calular: " + empl.NumeroCelular);
            Console.WriteLine("Sueldo en soles: " + empl.SueldoSoles);
            Console.WriteLine("Texto: " + empl.Texto());
        
    }
    }
}
