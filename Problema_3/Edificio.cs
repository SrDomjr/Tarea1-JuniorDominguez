using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3
{
    internal class Edificio
    {

        public int Codigo { get; set; }
        public int NumDepartamentos { get; set; }
        public int CantPisos { get; set; }
        public double PrecioDepaDolares { get; set; }

        public Edificio(int codigo, int numDepartamentos, int cantPisos, double precioDepaDolares)
        {
            Codigo = codigo;
            NumDepartamentos = numDepartamentos;
            CantPisos = cantPisos;
            PrecioDepaDolares = precioDepaDolares;
        }
        public double CalcularPrecioDolaresEdificio()
        {
            return NumDepartamentos * PrecioDepaDolares;
        }
    }
}
