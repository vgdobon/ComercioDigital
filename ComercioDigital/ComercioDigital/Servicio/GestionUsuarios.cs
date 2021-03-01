using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComercioDigital.DTOs.Personas;
using ComercioDigital.DTOs.Productos;
using ComercioDigital.Servicio.DB;

namespace ComercioDigital.Servicio
{
    public static class GestionUsuarios
    {
        public static List<Usuario> Usuarios { get; set; } = new List<Usuario>();

        public static bool InsertarUsuario(Usuario usuario)

        {
            if (usuario != null)
            {
                
                Usuarios.Add(usuario);
                DBUsuarios.AnnadirUsuarioDB(usuario);
                return true;
            }

            return false;
        }

        public static bool CargarListaDB(Usuario usuario)

        {

            if (usuario != null)
            {
                Usuarios.Add(usuario);
                
                return true;
            }

            return false;
        }


        public static bool AutentificarUsuario(string nombre, string pass)
        {
            ActualizarUsuariosDB();

            foreach (Usuario usuario in Usuarios)
            {

                if (usuario.Nombre.Equals(nombre) &&
                    usuario.Password.Equals(pass))
                {

                    return true;
                }

            }

            return false;
        }

        public static Usuario UsuarioSesion(string nombre, string pass)
        {
            ActualizarUsuariosDB();
            Usuario usuarioSesion = null;

            foreach (Usuario usuario in Usuarios)
            {

                if (usuario.Nombre.Equals(nombre) &&
                    usuario.Password.Equals(pass))
                {
                    usuarioSesion = usuario;
                }

            }

            return usuarioSesion;
        }

        public static bool ModificarUsuario(Usuario usuario, string s, string campo)
        {
            ActualizarUsuariosDB();
            if (campo.Equals("nombre"))
            {
                usuario.Nombre = s;
                DBUsuarios.ModificarNombre(usuario,s);
                return true;
            }
            else if (campo.Equals("contraseña"))
            {
                usuario.Password = s;
                DBUsuarios.ModificarContrasena(usuario,s);
                return true;
            }

            return false;
        }

        public static bool EliminarUsuario(Usuario usuario)
        {
            ActualizarUsuariosDB();
            if (usuario != null)
            {
                Usuarios.Remove(usuario);
                DBUsuarios.EliminarUsuario(usuario);
                return true;
            }

            return false;

        }
        
        public static void AnnadirProductoCarrito(Producto producto,Usuario usuarioSesion)
        {
            usuarioSesion.CarritoCompra.CarritoCompra.Add(producto);
            DBUsuarios.AnnadirProductoCarrito(usuarioSesion,producto);

        }

        public static void EliminarProductoCarrito(Producto producto, Usuario usuarioSesion)
        { 

            DBUsuarios.EliminarProductoCarrito(usuarioSesion,producto);
            usuarioSesion.CarritoCompra.CarritoCompra.Remove(producto);

        }

        public static void LimpiarCarrito(Usuario usuario)
        {
            DBUsuarios.LimpiarCarrito(usuario);
            usuario.CarritoCompra.CarritoCompra.Clear();
        }

        public static void AnnadirSaldo(Usuario usuario, decimal saldo)
        {
            usuario.Saldo += saldo;
            DBUsuarios.ModificarSaldo(usuario);
            
            
        }

        public static void ActualizarUsuariosDB()
        {
            Usuarios.Clear();
            DBUsuarios.CargarUsuariosDB(DBComerce.DBAccess);
        }

        public static bool HacerPedido(Usuario usuarioSesion)
        {
            ActualizarUsuariosDB();
            GestionComercio.ActualizarAlmacen();
            decimal sumaProductos = SumaProductosCarrito(usuarioSesion);
            if (sumaProductos <= usuarioSesion.Saldo)
            {

                sumaProductos = 0;
                foreach (Producto producto in usuarioSesion.CarritoCompra.CarritoCompra)
                {
                    if (GestionComercio.GetProductoId( producto.IdProducto).Stock > 0)
                    {

                        GestionComercio.ModificarStockProducto(producto);

                        sumaProductos += producto.Precio;
                    }
                    else
                    {
                        Console.WriteLine($"No queda mas stock de {producto.Nombre}. Se borrará el producto del carrito");
                    }

                }
                usuarioSesion.Saldo -= sumaProductos;
                DBUsuarios.ModificarSaldo(usuarioSesion);
                
                LimpiarCarrito(usuarioSesion);
                return true;
            }

            return false;
        }



        public static decimal SumaProductosCarrito(Usuario usuarioSesion)
        {
            decimal sumaProductos = 0;
            foreach (Producto producto in usuarioSesion.CarritoCompra.CarritoCompra)
            {
                    sumaProductos += producto.Precio;
                
            }

            return sumaProductos;
        }

        public static decimal ConsultarSaldo(Usuario usuarioSesion)
        {


            return DBUsuarios.BuscarPorId(usuarioSesion.IdUsuario).Saldo;


        }

        public static int ProductosCarrito(Usuario usuario)
        {
            return DBUsuarios.ProductosCarrito(usuario);
        }

       
    }
}
