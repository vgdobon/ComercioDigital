using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComercioDigital.DTOs.Personas;

namespace ComercioDigital.DTOs.Productos.Moda
{
    public class Calzado : Moda
    {
        public int Talla { get; set; }
        public string Tipo { get; set; }

        public Calzado(string nombre, string marca, decimal precio, Vendedor vendedor, string descripcion,
            DateTime fechaPuestaVenta, string codigoDescuento, int stock, string color, string mAterial, string sexo,
            int talla, string tipo) : base(nombre, marca, precio, vendedor, descripcion, fechaPuestaVenta,
            codigoDescuento, stock, color, mAterial, sexo)
        {
            Talla = talla ;
            Tipo = tipo ?? throw new ArgumentNullException(nameof(tipo));
        }

        public override string ToString()
        {
            return $"{base.ToString()},\n {nameof(Talla)}: {Talla},\n {nameof(Tipo)}: {Tipo}\n";
        }
    }
}
