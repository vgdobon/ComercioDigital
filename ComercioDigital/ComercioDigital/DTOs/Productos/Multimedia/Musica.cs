using System;
using ComercioDigital.DTOs.Personas;

namespace ComercioDigital.DTOs.Productos.Multimedia
{
    public class Musica : Multimedia
    {
        public string Artista { get; set; }

        public Musica(string nombre, string marca, decimal precio, Vendedor vendedor, string descripcion,
            DateTime fechaPuestaVenta, string codigoDescuento, int stock, string genero, string formato, string idioma,
            DateTime fechaLanzamiento, string artista) : base(nombre, marca, precio, vendedor, descripcion,
            fechaPuestaVenta, codigoDescuento, stock, genero, formato, idioma, fechaLanzamiento)
        {
            Artista = artista ?? throw new ArgumentNullException(nameof(artista));
        }

        public override string ToString()
        {
            return $"{base.ToString()},\n {nameof(Artista)}: {Artista}\n";
        }
    }
}
