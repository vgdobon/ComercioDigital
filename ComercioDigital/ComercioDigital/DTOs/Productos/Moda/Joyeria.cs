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

        public Joyeria(string nombre, string marca, float precio, Vendedor vendedor, string descripcion,
            DateTime fechaPuestaVenta, string codigoDescuento, int stock, string color, string mAterial, string sexo,
            string medida) : base(nombre, marca, precio, vendedor, descripcion, fechaPuestaVenta, codigoDescuento,
            stock, color, mAterial, sexo)
        {
            Medida = medida ?? throw new ArgumentNullException(nameof(medida));
        }
    }
}
