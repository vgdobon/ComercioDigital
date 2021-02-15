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
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }
        public string CodigoDescuento { get; set; }
        public int Stock { get; set; }
        public Vendedor Vendedor { get; set; }
        

        public InfoProducto(string nombre, string marca, decimal precio, string descripcion,
             string codigoDescuento, int stock,Vendedor vendedor)
        {
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Marca = marca ?? throw new ArgumentNullException(nameof(marca));
            Precio = precio;
            Descripcion = descripcion ?? throw new ArgumentNullException(nameof(descripcion));
            CodigoDescuento = codigoDescuento ?? throw new ArgumentNullException(nameof(codigoDescuento));
            Stock = stock;
            Vendedor = vendedor;
        }
    }
}
