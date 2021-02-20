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
        public decimal Precio { get; set; }
        public Vendedor Vendedor { get; set; }
        public string Descripcion { get; set;}
        public int Valoracion { get; set; }
        public List<int> Valoraciones { get; set; }
        public DateTime FechaPuestaVenta { get; }
        public string CodigoDescuento { get; set; }
        public int Stock { get; set; }
        public int IdProducto { get; set; }

        public Producto(int? id, string nombre, string marca, decimal precio, Vendedor vendedor, string descripcion,
            DateTime fechaPuestaVenta, string codigoDescuento, int stock)
        {
            if (id != null)
            {
                IdProducto = (int)id;
            }
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Marca = marca ?? throw new ArgumentNullException(nameof(marca));
            Precio = precio;
            this.Vendedor = vendedor ?? throw new ArgumentNullException(nameof(vendedor));
            Descripcion = descripcion ?? throw new ArgumentNullException(nameof(descripcion));
            FechaPuestaVenta = fechaPuestaVenta;
            CodigoDescuento = codigoDescuento ?? throw new ArgumentNullException(nameof(codigoDescuento));
            Stock = stock;
        }





        public override string ToString()
        {
            return $" {nameof(Nombre)}: {Nombre},\n {nameof(Marca)}: {Marca},\n {nameof(Precio)}: {Precio},\n {nameof(Vendedor)}: {Vendedor},\n {nameof(Descripcion)}: {Descripcion},\n {nameof(Valoracion)}: {Valoracion},\n {nameof(FechaPuestaVenta)}: {FechaPuestaVenta},\n {nameof(CodigoDescuento)}: {CodigoDescuento},\n {nameof(Stock)}: {Stock},\n {nameof(IdProducto)}: {IdProducto}";
        }
    }
}
