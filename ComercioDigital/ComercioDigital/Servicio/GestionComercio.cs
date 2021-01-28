using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComercioDigital.DTOs;
using ComercioDigital.DTOs.Productos;

namespace ComercioDigital.Servicio
{

    public class GestionComercio
    {
        private Almacen Almacen { get; set; }

        public GestionComercio()
        {
            Almacen = new Almacen();
        }

        public void AgregarProductoAlmacen(Producto producto)
        {
            if(producto!= null)
            {
                Almacen.AlmacenProductos.Add(producto);
            }
        }
    }
}
