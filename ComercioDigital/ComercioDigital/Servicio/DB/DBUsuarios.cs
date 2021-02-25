using ComercioDigital.DTOs.Personas;
using ComercioDigital.DTOs.Productos;
using ComercioDigital.Model;
using ComercioDigital.Servicio.DB.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ComercioDigital.Servicio.DB
{
    public static class DBUsuarios
    {
        public static void CargarUsuariosDB(eCommerceEntitiesDB DBAccess)
        {
            foreach (var VARIABLE in DBAccess.Usuarios)
            {
                GestionUsuarios.CargarListaDB(MapUsuarioFromDBToDTO(VARIABLE));
            }
        }


        public static Usuario MapUsuarioFromDBToDTO(Usuarios usuarioDB)
        {
            Usuario resul = new Usuario(usuarioDB.Nombre,usuarioDB.Domicilio,usuarioDB.Pass,usuarioDB.Saldo,usuarioDB.Id);
            foreach(Carritos carrito in DBComerce.DBAccess.Carritos)
            {
                if(usuarioDB.IdCarrito == carrito.Id)
                {
                    foreach(Model.Productos productoCarritoDB in carrito.Productos)
                    {

                        if(productoCarritoDB is Bolsos)
                        {
                            Bolsos bolso = productoCarritoDB;
                        }
                        if (productoCarritoDB is Musicas)
                        {
                            Musicas musica =  productoCarritoDB;
                        }
                        
                    }
                
                    
                }
            }

            return resul;
        }

        public static Usuarios MapUsuarioFromDTOToDB(Usuario usuarioDTO, int idCarrito)
        {
            Usuarios resul = new Usuarios();         
            resul.Nombre = usuarioDTO.Nombre;
            resul.Pass = usuarioDTO.Password;
            resul.Domicilio = usuarioDTO.Domicilio;
            resul.Saldo = usuarioDTO.Saldo;
            resul.IdCarrito = idCarrito;
           
            return resul;
        }

        public static void AnnadirUsuarioDB(Usuario usuarioDTO)
        {
            Carritos nuevoCarrito = new Carritos();
            DBComerce.DBAccess.Carritos.Add(nuevoCarrito);
            DBComerce.DBAccess.Entry(nuevoCarrito).State = System.Data.Entity.EntityState.Added;
            DBComerce.DBAccess.SaveChanges();
            int idNuevoCarrito = nuevoCarrito.Id;

            Usuarios nuevoUsuario = MapUsuarioFromDTOToDB(usuarioDTO,idNuevoCarrito);
            DBComerce.DBAccess.Usuarios.Add(nuevoUsuario);
            DBComerce.DBAccess.SaveChangesAsync();
        }

        public static Usuarios BuscarPorId(int id)

        {
            return DBComerce.DBAccess.Usuarios.FirstOrDefault(
                x => x.Id == id);
        }

        public static void EliminarUsuario(int id)
        {
            Usuarios usuarioDB = BuscarPorId(id);
            DBComerce.DBAccess.Usuarios.Remove(usuarioDB);
        }

        public static void ModificarUsuario(Usuario usuarioDTO)
        {
            Usuarios usuarioDB = BuscarPorId(usuarioDTO.IdUsuario);
            int idBorrar = usuarioDTO.IdUsuario;
            usuarioDB = MapUsuarioFromDTOToDB(usuarioDTO, usuarioDB.IdCarrito);
            DBComerce.DBAccess.Entry(usuarioDB).State = System.Data.Entity.EntityState.Added;
            EliminarUsuario(idBorrar);
            DBComerce.DBAccess.SaveChanges();
        }

        public static void ModificarSaldo(Usuario usuarioDTO, decimal s)
        {
            Usuarios usuarioDB = BuscarPorId(usuarioDTO.IdUsuario);
            usuarioDB.Saldo += s;

            DBComerce.DBAccess.Entry(usuarioDB).State = System.Data.Entity.EntityState.Modified;

            DBComerce.DBAccess.SaveChangesAsync();

        }

        public static void ModificarNombre(Usuario usuarioDTO,string s) 
        {
            Usuarios usuarioDB = BuscarPorId(usuarioDTO.IdUsuario);
            usuarioDB.Nombre = s;

            DBComerce.DBAccess.Entry(usuarioDB).State = System.Data.Entity.EntityState.Modified;
            
            DBComerce.DBAccess.SaveChangesAsync();

        }

        public static void LimpiarCarrito(Usuario usuario)
        {
            Usuarios usuarioDB = BuscarPorId(usuario.IdUsuario);
            usuarioDB.Carritos.Productos.Clear();
            DBComerce.DBAccess.SaveChanges();
        }

        public static void ModificarContrasena(Usuario usuarioDTO, string s)
        {
            Usuarios usuarioDB = BuscarPorId(usuarioDTO.IdUsuario);
            usuarioDB.Pass = s;

            DBComerce.DBAccess.Entry(usuarioDB).State = System.Data.Entity.EntityState.Modified;
            DBComerce.DBAccess.SaveChangesAsync();

        }


        public static void AnnadirProductoCarrito(Usuario usuarioDTO,Producto producto)
        {
            Usuarios usuarioDB = BuscarPorId(usuarioDTO.IdUsuario);
            Model.Productos productoDB = DBProducto.BuscarPorId(producto.IdProducto);
            usuarioDB.Carritos.Productos.Add(productoDB);
            DBComerce.DBAccess.SaveChanges();
        }

        public static void EliminarProductoCarrito(Usuario usuarioDTO, Producto producto)
        {
            Usuarios usuarioDB = BuscarPorId(usuarioDTO.IdUsuario);
            Model.Productos productoDB = DBProducto.BuscarPorId(producto.IdProducto);
            usuarioDB.Carritos.Productos.Remove(productoDB);
            DBComerce.DBAccess.SaveChanges();
        }
        public static void HacerPedido(Usuario usuarioDTO)
        {
            Usuarios usuarioDB = BuscarPorId(usuarioDTO.IdUsuario);


        }

        internal static int ProductosCarrito(Usuario usuario)
        {
            Usuarios usuarioDB = BuscarPorId(usuario.IdUsuario);
            return usuarioDB.Carritos.Productos.Count();
        }
    }
}
