using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComercioDigital.DTOs.Personas;

namespace ComercioDigital.DTOs.Productos.Multimedia
{
    public class Peliculas : Multimedia
    {
        public string Actores { get; set; }
        public string Director { get; set; }
        public int EdadRecomendad { get; set; }
        public string Sinapsis { get; set; }


        public Peliculas(string nombre, string marca, float precio, Vendedor vendedor, string descripcion,
            DateTime fechaPuestaVenta, string codigoDescuento, int stock, string genero, string formato, string idioma,
            DateTime fechaLanzamiento, string actores, string director, int edadRecomendad, string sinapsis) : base(
            nombre, marca, precio, vendedor, descripcion, fechaPuestaVenta, codigoDescuento, stock, genero, formato,
            idioma, fechaLanzamiento)
        {
            Actores = actores ?? throw new ArgumentNullException(nameof(actores));
            Director = director ?? throw new ArgumentNullException(nameof(director));
            EdadRecomendad = edadRecomendad;
            Sinapsis = sinapsis ?? throw new ArgumentNullException(nameof(sinapsis)); 
        }
    }
}
 