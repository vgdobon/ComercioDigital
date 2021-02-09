using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComercioDigital.DTOs.Personas;

namespace ComercioDigital.Servicio
{
    public class GestionUsuarios
    {
        public List<Usuario> Usuarios { get; set; }


        public GestionUsuarios()
        {
            Usuarios = new List<Usuario>();
        }

        public bool InsertarUsuario(Usuario usuario)

        {
            if (usuario != null)
            {
                Usuarios.Add(usuario);
                return true;
            }

            return false;
        }
        public bool AutentificarUsuario(string nombre, string pass)
        {

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

        public Usuario UsuarioSesion(string nombre, string pass)
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

        public bool ModificarUsuario(Usuario usuario, string s, string campo)
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

        public bool EliminarUsuario(Usuario usuario)
        {

            if (usuario != null)
            {
                Usuarios.Remove(usuario);
                return true;
            }

            return false;

        }
    }
}
