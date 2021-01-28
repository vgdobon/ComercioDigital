using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComercioDigital.DTOs.Personas;

namespace ComercioDigital.DTOs.Productos
{
    public class InfoProducto
    {
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public float Precio { get; set; }
        public string Descripcion { get; set; }
        private DateTime FechaPuestaVenta { get; }
        public string CodigoDescuento { get; set; }
        public int Stock { get; set; }
        

        public InfoProducto(string nombre, string marca, float precio, string descripcion,
            DateTime fechaPuestaVenta, string codigoDescuento, int stock)
        {
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Marca = marca ?? throw new ArgumentNullException(nameof(marca));
            Precio = precio;
            Descripcion = descripcion ?? throw new ArgumentNullException(nameof(descripcion));
            FechaPuestaVenta = fechaPuestaVenta;
            CodigoDescuento = codigoDescuento ?? throw new ArgumentNullException(nameof(codigoDescuento));
            Stock = stock;
        }
    }
}
