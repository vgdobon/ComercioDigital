//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ComercioDigital.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ropas
    {
        public int Id { get; set; }
        public string Talla { get; set; }
        public string Tipo { get; set; }
    
        public virtual Modas Modas { get; set; }

        public static implicit operator Ropas(Productos v)
        {
            Ropas resul = new Ropas();
            resul.Modas.Productos.Nombre = v.Nombre;
            resul.Modas.Productos.Precio = v.Precio;
            resul.Modas.Productos.Marca = v.Marca;
            resul.Modas.Productos.IdVendedor = v.IdVendedor;
            resul.Modas.Productos.Descripcion = v.Descripcion;
            resul.Modas.Productos.Valoracion = v.Valoracion;
            resul.Modas.Productos.FechaPuestaVenta = v.FechaPuestaVenta;
            resul.Modas.Productos.CodigoDescuento = v.CodigoDescuento;
            resul.Modas.Productos.Stock = v.Stock;
            resul.Modas.Color = v.Modas.Color;
            resul.Modas.Material = v.Modas.Material;
            resul.Modas.Sexo = v.Modas.Sexo;
            resul.Tipo = v.Modas.Ropas.Tipo;
            resul.Talla = v.Modas.Ropas.Talla;

            return resul;
        }
    }
}
