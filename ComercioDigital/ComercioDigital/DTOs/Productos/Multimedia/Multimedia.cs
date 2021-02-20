using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComercioDigital.DTOs.Personas;

namespace ComercioDigital.DTOs.Productos.Multimedia
{
    public class Multimedia : Producto
    {
        public string Genero { get; set; }
        public string Formato { get; set; }
        public string Idioma { get; set; }
        public DateTime FechaLanzamiento { get; set; }

        public Multimedia(int? id, string nombre, string marca, decimal precio, Vendedor vendedor, string descripcion,
            DateTime fechaPuestaVenta, string codigoDescuento, int stock, string genero, string formato, string idioma,
            DateTime fechaLanzamiento) : base(id,nombre, marca, precio, vendedor, descripcion, fechaPuestaVenta,
            codigoDescuento, stock)
        {
            Genero = genero ?? throw new ArgumentNullException(nameof(genero));
            Formato = formato ?? throw new ArgumentNullException(nameof(formato));
            Idioma = idioma ?? throw new ArgumentNullException(nameof(idioma));
            FechaLanzamiento = fechaLanzamiento;
        }

        public override string ToString()
        {
            return $"{base.ToString()},\n {nameof(Genero)}: {Genero},\n {nameof(Formato)}: {Formato},\n {nameof(Idioma)}: {Idioma},\n {nameof(FechaLanzamiento)}: {FechaLanzamiento}";
        }
    }
}
