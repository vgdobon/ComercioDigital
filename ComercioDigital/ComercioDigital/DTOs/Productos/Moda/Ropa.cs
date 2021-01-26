using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComercioDigital.DTOs.Personas;

namespace ComercioDigital.DTOs.Productos.Moda
{
    public class Ropa : Moda
    {
        public string Talla { get; set; }
        public string Tipo { get; set; }

        public Ropa(string nombre, string marca, float precio, Vendedor vendedor, string descripcion,
            DateTime fechaPuestaVenta, string codigoDescuento, int stock, string color, string mAterial, string sexo,
            string talla, string tipo) : base(nombre, marca, precio, vendedor, descripcion, fechaPuestaVenta,
            codigoDescuento, stock, color, mAterial, sexo)
        {
            Talla = talla ?? throw new ArgumentNullException(nameof(talla));
            Tipo = tipo ?? throw new ArgumentNullException(nameof(tipo));
        }
    }
}
