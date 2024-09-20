using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_5
{
    internal class Video
    {

        public int codigo { get; set; }
        public string nombreVideo { get; set; }
        public double duracion { get; set; }
        public double precioSoles { get; set; }
        public double tipoCambio { get; set; }

        public Video(int codigo, string nombreVideo, double duracion, double precioSoles, double tipoCambio)
        {
            this.codigo = codigo;
            this.nombreVideo = nombreVideo;
            this.duracion = duracion;
            this.precioSoles = precioSoles;
            this.tipoCambio = tipoCambio;
        }

        public double CalcularPrecioVideo()
        {
            return precioSoles / tipoCambio;
        }
    }
}
