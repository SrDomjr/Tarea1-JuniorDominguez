using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

                Edificio objEdificio = new Edificio(1002, 50, 10, 10000);
                Listado(objEdificio);


                Console.WriteLine("___________________________________");
                objEdificio.PrecioDepaDolares *= 1.20;
                Listado(objEdificio);


                Console.ReadKey();
            }

            public static void Listado(Edificio edi)
            {
                Console.WriteLine("Codigo: " + edi.Codigo);
                Console.WriteLine("Numero de departamentos: " + edi.NumDepartamentos);
                Console.WriteLine("Cantidad de pisos: " + edi.CantPisos);
                Console.WriteLine("Precio de departamentos en dolares: " + edi.PrecioDepaDolares);
                Console.WriteLine("Precio del edificio: " + edi.CalcularPrecioDolaresEdificio());

            }
        }
    
}
