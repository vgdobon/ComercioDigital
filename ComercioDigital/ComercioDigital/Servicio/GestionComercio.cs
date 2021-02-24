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
using ComercioDigital.Model;
using ComercioDigital.Servicio.DB;
using ComercioDigital.Servicio.DB.Productos;

namespace ComercioDigital.Servicio
{

    public static class GestionComercio
    {

        public static bool CargarlistaBD(Producto producto)

        {
            if (producto != null)
            {
                Almacen.AlmacenProductos.Add(producto);
                return true;
            }

            return false;
        }

        public static void AgregarProductoAlmacen(Producto producto)
        {
            if (producto!= null)
            {
                if(producto is Multimedia)
                {
                    if(producto is Musica)
                    {
                        DBMusicas.AnnadirMusica((Musica)producto);
                    }else if(producto is Pelicula)
                    {
                        DBPeliculas.AnnadirPelicula((Pelicula)producto);
                    }
                    else
                    {
                        DBVideoJuegos.AnnadirVideoJuego((VideoJuego)producto);
                    }
                }
                else if(producto is Tecnologia)
                {
                    if(producto is Movil)
                    {
                        DBMoviles.AnnadirMovil((Movil)producto);
                    }
                    else if(producto is Ordenador)
                    {
                        DBOrdenadores.AnnadirOrdenador((Ordenador)producto);
                    }
                    else
                    {
                        DBVideoConsolas.AnnadirVideoConsola((VideoConsola)producto);
                    }

                }
                else
                {
                    if(producto is Ropa)
                    {
                        DBRopas.AnnadirRopa((Ropa)producto);
                    }else if(producto is Calzado)
                    {
                        DBCalzados.AnnadirCalzado((Calzado)producto);
                    }else if(producto is Joyeria)
                    {
                        DBJoyas.AnnadirJoya((Joyeria)producto);
                    }
                    else
                    {
                        DBBolsos.AnnadirBolso((Bolso)producto);
                    }
                }
                Almacen.AlmacenProductos.Add(producto);
            }
        }

        public static bool EliminarProductoAlmacen(int id)
        {
            ActualizarAlmacen();
            foreach (Producto producto in Almacen.AlmacenProductos)
            {
                if (producto.IdProducto == id)
                {
                    DBProducto.EliminarProducto(producto.IdProducto);
                    Almacen.AlmacenProductos.Remove(producto);
                    return true;
                }
            }

            return false;
        }

        public static List<Producto> FiltroProductoVendedor(Vendedor vendedor)
        {
            ActualizarAlmacen();
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
            ActualizarAlmacen();
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

            ActualizarAlmacen();
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
            ActualizarAlmacen();

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

        public static void EntregarProducto(Producto producto)
        {

        }

        public static bool ExistenProductosTipo(Type type)
        {
            ActualizarAlmacen();
            if (FiltroTipoProducto(type).Count > 0)
            {
                return true;
            }

            return false;
        }

        public static List<Producto> ListaAlmacen()
        {
            ActualizarAlmacen();
            return Almacen.AlmacenProductos;
        }

        public static void ActualizarAlmacen()
        {
            Almacen.AlmacenProductos.Clear();
            DBProducto.CargarProductosDB(DBComerce.DBAccess);
        }
       
    }
}
