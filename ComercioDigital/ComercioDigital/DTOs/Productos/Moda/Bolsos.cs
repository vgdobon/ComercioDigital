using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComercioDigital.DTOs.Personas;

namespace ComercioDigital.DTOs.Productos.Moda
{
    public class Bolsos : Moda
    {

        public string Tipo { get; set; }

        public Bolsos(string nombre, string marca, float precio, Vendedor vendedor, string descripcion,
            DateTime fechaPuestaVenta, string codigoDescuento, int stock, string color, string mAterial, string sexo,
            string tipo) : base(nombre, marca, precio, vendedor, descripcion, fechaPuestaVenta, codigoDescuento, stock,
            color, mAterial, sexo)
        {
            Tipo = tipo ?? throw new ArgumentNullException(nameof(tipo));
        }
    }
}
