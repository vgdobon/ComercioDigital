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

    public static class GestionComercio
    {



        public static void AgregarProductoAlmacen(Producto producto)
        {
            if(producto!= null)
            {
                Almacen.AlmacenProductos.Add(producto);
            }
        }

        public static bool EliminarProductoAlmacen(int id)
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

        public static List<Producto> FiltroProductoVendedor(Vendedor vendedor)
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

        public static bool ExisteProductoId(int id)
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

        public static Producto GetProductoId(int id)
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

        public static List<Producto> FiltroTipoProducto(Type type)
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



        public static bool ExistenProductosTipo(Type type)
        {
            if (FiltroTipoProducto(type).Count > 0)
            {
                return true;
            }

            return false;
        }

        public static List<Producto> ListaAlmacen()
        {
            return Almacen.AlmacenProductos;
        }
       
    }
}
