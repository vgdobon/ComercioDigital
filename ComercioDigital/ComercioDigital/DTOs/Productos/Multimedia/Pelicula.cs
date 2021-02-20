using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComercioDigital.DTOs.Personas;

namespace ComercioDigital.DTOs.Productos.Multimedia
{
    public class Pelicula : Multimedia
    {
        public string Actores { get; set; }
        public string Director { get; set; }
        public int EdadRecomendad { get; set; }
        public string Sinopsis { get; set; }


        public Pelicula(int? id, string nombre, string marca, decimal precio, Vendedor vendedor, string descripcion,
            DateTime fechaPuestaVenta, string codigoDescuento, int stock, string genero, string formato, string idioma,
            DateTime fechaLanzamiento, string actores, string director, int edadRecomendad, string sinopsis) : base(
            id,nombre, marca, precio, vendedor, descripcion, fechaPuestaVenta, codigoDescuento, stock, genero, formato,
            idioma, fechaLanzamiento)
        {
            Actores = actores ?? throw new ArgumentNullException(nameof(actores));
            Director = director ?? throw new ArgumentNullException(nameof(director));
            EdadRecomendad = edadRecomendad;
            Sinopsis = sinopsis ?? throw new ArgumentNullException(nameof(sinopsis)); 
        }

        public override string ToString()
        {
            return $"{base.ToString()},\n {nameof(Actores)}: {Actores},\n {nameof(Director)}: {Director},\n {nameof(EdadRecomendad)}: {EdadRecomendad},\n {nameof(Sinopsis)}: {Sinopsis}\n";
        }
    }
}
 