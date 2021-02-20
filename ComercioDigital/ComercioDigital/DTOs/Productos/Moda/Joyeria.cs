using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComercioDigital.DTOs.Personas;

namespace ComercioDigital.DTOs.Productos.Moda
{
    public class Joyeria : Moda
    {
        public string Medida { get; set; }

        public Joyeria(int? id, string nombre, string marca, decimal precio, Vendedor vendedor, string descripcion,
            DateTime fechaPuestaVenta, string codigoDescuento, int stock, string color, string mAterial, string sexo,
            string medida) : base(id,nombre, marca, precio, vendedor, descripcion, fechaPuestaVenta, codigoDescuento,
            stock, color, mAterial, sexo)
        {
            Medida = medida ?? throw new ArgumentNullException(nameof(medida));
        }

        public override string ToString()
        {
            return $"{base.ToString()},\n {nameof(Medida)}: {Medida}\n";
        }
    }
}
