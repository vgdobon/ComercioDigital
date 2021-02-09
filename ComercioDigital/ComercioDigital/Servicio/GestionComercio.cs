using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComercioDigital.DTOs;
using ComercioDigital.DTOs.Personas;
using ComercioDigital.DTOs.Productos;
using ComercioDigital.DTOs.Productos.Moda;
using ComercioDigital.DTOs.Productos.Multimedia;
using ComercioDigital.DTOs.Productos.Tecnologia;

namespace ComercioDigital.Servicio
{

    public class GestionComercio
    {
        public Almacen Almacen { get; set; }

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

        public bool EliminarProductoAlmacen(int id)
        {
            foreach (Producto producto in Almacen.AlmacenProductos)
            {
                if (producto.IdProducto == id)
                {
                    Almacen.AlmacenProductos.Remove(producto);
                    return true;
                }
            }

            return false;
        }

        public List<Producto> FiltroProductoVendedor(Vendedor vendedor)
        {
            List<Producto> productosVendedor= new List<Producto>();

            foreach (Producto producto in Almacen.AlmacenProductos)
            {
                if (producto.Vendedor.Equals(vendedor))
                {
                    productosVendedor.Add(producto);
                }
            }

            return productosVendedor;

        }

        public bool ExisteProductoId(int id)
        {
            foreach (Producto producto in Almacen.AlmacenProductos)
            {
                if (producto.IdProducto == id)
                {
                    return true;
                }
            }

            return false;
        }

        public Producto GetProductoId(int id)
        {
            Producto productoID = null;

            foreach (Producto producto in Almacen.AlmacenProductos)
            {
                if (producto.IdProducto == id)
                {
                    productoID = producto;
                }
            }

            return productoID;
        }

        public List<Producto> FiltroTipoProducto(Type type)
        {

            List<Producto> filtroProductos = new List<Producto>();

            foreach (Producto producto in Almacen.AlmacenProductos)
            {

                if(producto.GetType() == type)
                {
                    filtroProductos.Add(producto);
                }
            }


            return filtroProductos;
        }



        public bool ExistenProductosTipo(Type type)
        {
            if (FiltroTipoProducto(type).Count > 0)
            {
                return true;
            }

            return false;
        }
       
    }
}
