using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComercioDigital.DTOs.Personas;

namespace ComercioDigital.DTOs.Productos.Multimedia
{
    public class VideoJuego : Multimedia
    {
        public string Plataforma { get; set; }
        public int EdadRecomendad { get; set; }

        public VideoJuego(int? id, string nombre, string marca, decimal precio, Vendedor vendedor, string descripcion,
            DateTime fechaPuestaVenta, string codigoDescuento, int stock, string genero, string formato, string idioma,
            DateTime fechaLanzamiento, string plataforma, int edadRecomendad) : base(id,nombre, marca, precio, vendedor,
            descripcion, fechaPuestaVenta, codigoDescuento, stock, genero, formato, idioma, fechaLanzamiento)
        {
            Plataforma = plataforma ?? throw new ArgumentNullException(nameof(plataforma));
            EdadRecomendad = edadRecomendad;
        }

        public override string ToString()
        {
            return $"{base.ToString()},\n {nameof(Plataforma)}: {Plataforma},\n {nameof(EdadRecomendad)}: {EdadRecomendad}\n";
        }
    }
}
