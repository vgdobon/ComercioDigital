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
    }
}
