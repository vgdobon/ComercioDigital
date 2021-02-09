using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComercioDigital.DTOs.Personas;

namespace ComercioDigital.DTOs.Productos.Tecnologia
{
    public class Movil : Tecnologia
    {
        public float Pantalla { get; set; }
        public int Bateria { get; set; }
        public Movil(string nombre, string marca, float precio, Vendedor vendedor, string descripcion,
            DateTime fechaPuestaVenta, string codigoDescuento, int stock, string color, string procesador,
            string so, string modelo, DateTime fechaLanzamiento, float pantalla, int bateria)
            : base(nombre, marca, precio, vendedor, descripcion, fechaPuestaVenta, codigoDescuento, stock, color, procesador, so, modelo, fechaLanzamiento)
        {
            Pantalla = pantalla;
            Bateria = bateria;
        }

        public override string ToString()
        {
            return $"{base.ToString()},\n {nameof(Pantalla)}: {Pantalla},\n {nameof(Bateria)}: {Bateria}\n";
        }
    }
}
