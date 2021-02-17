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

            Usuarios.Clear();
            if (usuario != null)
            {
                Usuarios.Add(usuario);
                return true;
            }

            return false;
        }


        public static bool AutentificarUsuario(string nombre, string pass)
        {
            Usuarios.Clear();
            DBUsuarios.CargarUsuariosDB(DBComerce.DBAccess);
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
            if (campo.Equals("nombre"))
            {
                usuario.Nombre = s;
                return true;
            }
            else if (campo.Equals("contraseña"))
            {
                usuario.Password = s;
                return true;
            }

            return false;
        }

        public static bool EliminarUsuario(Usuario usuario)
        {

            if (usuario != null)
            {
                Usuarios.Remove(usuario);
                return true;
            }

            return false;

        }
        
        public static void AnnadirProductoCarrito(Producto producto,Usuario usuarioSesion)
        {
            usuarioSesion.CarritoCompra.CarritoCompra.Add(GestionComercio.GetProductoId(producto.IdProducto));
        }
    }
}
