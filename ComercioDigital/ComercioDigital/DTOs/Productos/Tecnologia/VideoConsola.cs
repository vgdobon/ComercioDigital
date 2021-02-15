using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComercioDigital.DTOs.Personas;

namespace ComercioDigital.DTOs.Productos.Tecnologia
{
    public class VideoConsola : Tecnologia
    {
        public VideoConsola(string nombre, string marca, decimal precio, Vendedor vendedor, string descripcion, DateTime fechaPuestaVenta, string codigoDescuento, int stock, string color, string procesador, string so, string modelo, DateTime fechaLanzamiento) : base(nombre, marca, precio, vendedor, descripcion, fechaPuestaVenta, codigoDescuento, stock, color, procesador, so, modelo, fechaLanzamiento)
        {
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n";
        }
    }
}
