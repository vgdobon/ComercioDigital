using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComercioDigital.DTOs.Personas;

namespace ComercioDigital.DTOs.Productos.Tecnologia
{
    public class Tecnologia : Producto
    {

        public string Color { get; set; }
        public string Procesador { get; set; }
        public string SO { get; set; }
        public string Modelo { get; set; 
        private DateTime FechaLanzamiento { get; }

        public Tecnologia(string nombre, string marca, float precio, Vendedor vendedor, string descripcion,
            DateTime fechaPuestaVenta, string codigoDescuento, int stock, string color, string procesador, string so,
            string modelo, DateTime fechaLanzamiento) : base(nombre, marca, precio, vendedor, descripcion,
            fechaPuestaVenta, codigoDescuento, stock)
        {
            Color = color ?? throw new ArgumentNullException(nameof(color));
            Procesador = procesador ?? throw new ArgumentNullException(nameof(procesador));
            SO = so ?? throw new ArgumentNullException(nameof(so));
            Modelo = modelo ?? throw new ArgumentNullException(nameof(modelo));
            FechaLanzamiento = fechaLanzamiento;
        }


    }
}
