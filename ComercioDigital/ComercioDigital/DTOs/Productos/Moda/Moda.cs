using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComercioDigital.DTOs.Personas;

namespace ComercioDigital.DTOs.Productos.Moda

{
    public class Moda : Producto
    {
        public string Color { get; set; }
        public string MAterial { get; set; }
        public string Sexo { get; set; }

        public Moda(string nombre, string marca, float precio, Vendedor vendedor, string descripcion,
            DateTime fechaPuestaVenta, string codigoDescuento, int stock, string color, string mAterial, string sexo) :
            base(nombre, marca, precio, vendedor, descripcion, fechaPuestaVenta, codigoDescuento, stock)
        {
            Color = color ?? throw new ArgumentNullException(nameof(color));
            MAterial = mAterial ?? throw new ArgumentNullException(nameof(mAterial));
            Sexo = sexo ?? throw new ArgumentNullException(nameof(sexo));
        }
    }
}
