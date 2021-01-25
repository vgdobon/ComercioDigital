using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioDigital.DTOs
{
    class Producto
    {
        public string Marca { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set; }
        public Vendedor vendedor { get; set; }
        public string Descripcion { get; set;}
        public int Valoracion { get; set; }
        public List<int> Valoraciones { get; set; }
        public static int Increment { get; set; }
        public int IdProducto { get; set; }
        private DateTime FechaPuestaVenta { get; set; }
        public string CodigoDescuento { get; set; }

        public Producto(string marca, string nombre, float precio, Vendedor vendedor, string descripcion, DateTime fechaPuestaVenta, string codigoDescuento)
        {
            Marca = marca;
            Nombre = nombre;
            Precio = precio;
            this.vendedor = vendedor;
            Descripcion = descripcion;
            FechaPuestaVenta = fechaPuestaVenta;
            CodigoDescuento = codigoDescuento;
        }
    }
}
