using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComercioDigital.DTOs.Personas;

namespace ComercioDigital.DTOs.Productos.Tecnologia
{
    public class Ordenador : Tecnologia

    {
    public string PlacaBase { get; set; }
    public string Tipo { get; set; }

    public Ordenador(string nombre, string marca, float precio, Vendedor vendedor, string descripcion,
        DateTime fechaPuestaVenta, string codigoDescuento, int stock, string color, string procesador, string so,
        string modelo, DateTime fechaLanzamiento, string placaBase, string tipo) : base(nombre, marca, precio, vendedor,
        descripcion, fechaPuestaVenta, codigoDescuento, stock, color, procesador, so, modelo, fechaLanzamiento)
    {
        PlacaBase = placaBase ?? throw new ArgumentNullException(nameof(placaBase));
        Tipo = tipo ?? throw new ArgumentNullException(nameof(tipo));
    }

    public override string ToString()
    {
        return $"{base.ToString()},\n {nameof(PlacaBase)}: {PlacaBase},\n {nameof(Tipo)}: {Tipo}\n";
    }
    }
}
