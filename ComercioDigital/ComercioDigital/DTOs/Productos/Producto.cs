using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComercioDigital.DTOs.Personas;

namespace ComercioDigital.DTOs.Productos
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public float Precio { get; set; }
        public Vendedor vendedor { get; set; }
        public string Descripcion { get; set;}
        public int Valoracion { get; set; }
        public List<int> Valoraciones { get; set; }
        public DateTime FechaPuestaVenta { get; }
        public string CodigoDescuento { get; set; }
        public int Stock { get; set; }
        public static int Incrementer { get; set; }
        public int IdProducto { get; set; }

        public Producto(string nombre, string marca, float precio, Vendedor vendedor, string descripcion,
            DateTime fechaPuestaVenta, string codigoDescuento, int stock)
        {
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Marca = marca ?? throw new ArgumentNullException(nameof(marca));
            Precio = precio;
            this.vendedor = vendedor ?? throw new ArgumentNullException(nameof(vendedor));
            Descripcion = descripcion ?? throw new ArgumentNullException(nameof(descripcion));
            FechaPuestaVenta = fechaPuestaVenta;
            CodigoDescuento = codigoDescuento ?? throw new ArgumentNullException(nameof(codigoDescuento));
            Stock = stock;
            Incrementer++;
            IdProducto = Incrementer;
        }
    }
}
