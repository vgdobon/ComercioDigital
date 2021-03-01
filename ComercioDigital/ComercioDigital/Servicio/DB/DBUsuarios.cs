using ComercioDigital.DTOs.Personas;
using ComercioDigital.DTOs.Productos;
using ComercioDigital.Model;
using ComercioDigital.Servicio.DB.Productos;
using System.Linq;

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
			foreach(Model.Productos productoCarritoDB in usuarioDB.Carritos.Productos)
			{

				//resul.usuarioSesion.CarritoCompra.CarritoCompra.Add(productoCarritoDB);

				if(productoCarritoDB.Modas != null)
				{
					if(productoCarritoDB.Modas.Bolsos != null){
						Bolsos bolso = productoCarritoDB;
						resul.CarritoCompra.CarritoCompra.Add(DBBolsos.MapBolsosFromDBToDTO(bolso));
					}
					else if(productoCarritoDB.Modas.Calzados != null)
					{
						Calzados calzados = productoCarritoDB;
						resul.CarritoCompra.CarritoCompra.Add(DBCalzados.MapCalzadosFromDBToDTO(calzados));
					}
					else if(productoCarritoDB.Modas.Joyas != null)
					{
						Joyas joyas = productoCarritoDB;
						resul.CarritoCompra.CarritoCompra.Add(DBJoyas.MapJoyasFromDBToDTO(joyas));
					}
					else
					{
						Ropas Ropas = productoCarritoDB;
						resul.CarritoCompra.CarritoCompra.Add(DBRopas.MapRopasFromDBToDTO(Ropas));
					}
					
				}
				else if(productoCarritoDB.Tecnologicos != null )
				{
					if(productoCarritoDB.Tecnologicos.Ordenadores != null)
					{
						Ordenadores ordenadores = productoCarritoDB;
						resul.CarritoCompra.CarritoCompra.Add(DBOrdenadores.MapOrdenadoresFromDBToDTO(ordenadores));
					}
					else if(productoCarritoDB.Tecnologicos.Moviles != null)
					{
						Moviles moviles = productoCarritoDB;
						resul.CarritoCompra.CarritoCompra.Add(DBMoviles.MapMovilesFromDBToDTO(moviles));
					}
					else
					{
						Videoconsolas videoconsolas = productoCarritoDB;
						resul.CarritoCompra.CarritoCompra.Add(DBVideoConsolas.MapVideoConsolasFromDBToDTO(videoconsolas));
					}
				}
				else 
				{
					if(productoCarritoDB.Multimedias.Peliculas != null)
					{
						Peliculas peliculas = productoCarritoDB;
						resul.CarritoCompra.CarritoCompra.Add(DBPeliculas.MapPeliculasFromDBToDTO(peliculas));
					}
					else if(productoCarritoDB.Multimedias.Videojuegos != null)
					{
						Videojuegos videojuegos = productoCarritoDB;
						resul.CarritoCompra.CarritoCompra.Add(DBVideoJuegos.MapVideoJuegosFromDBToDTO(videojuegos));
					}
					else
					{
						Musicas musicas = productoCarritoDB;
						resul.CarritoCompra.CarritoCompra.Add(DBMusicas.MapMusicasFromDBToDTO(musicas));
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

		public static void EliminarUsuario(Usuario usuario)
		{
			Usuarios usuarioDB = BuscarPorId(usuario.IdUsuario);
			LimpiarCarrito(usuario);
			DBComerce.DBAccess.Usuarios.Remove(usuarioDB);
			DBComerce.DBAccess.Entry(usuarioDB).State = System.Data.Entity.EntityState.Deleted;
			DBComerce.DBAccess.SaveChanges();
		}

		public static void ModificarSaldo(Usuario usuarioDTO)
		{
			Usuarios usuarioDB = BuscarPorId(usuarioDTO.IdUsuario);
			usuarioDB.Saldo = usuarioDTO.Saldo;

			DBComerce.DBAccess.Entry(usuarioDB).State = System.Data.Entity.EntityState.Modified;

			DBComerce.DBAccess.SaveChanges();

		}

		public static void ModificarNombre(Usuario usuarioDTO,string s) 
		{
			Usuarios usuarioDB = BuscarPorId(usuarioDTO.IdUsuario);
			usuarioDB.Nombre = s;

			DBComerce.DBAccess.Entry(usuarioDB).State = System.Data.Entity.EntityState.Modified;
			
			DBComerce.DBAccess.SaveChanges();

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
			DBComerce.DBAccess.SaveChanges();

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
