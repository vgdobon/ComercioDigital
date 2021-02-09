using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ComercioDigital.DTOs.Personas;
using ComercioDigital.DTOs.Productos;
using ComercioDigital.DTOs.Productos.Moda;
using ComercioDigital.DTOs.Productos.Multimedia;
using ComercioDigital.DTOs.Productos.Tecnologia;
using ComercioDigital.Servicio;

namespace ComercioDigital.Presentacion
{
    public class MenuUsuario
    {

        public void EjecutarMenuUsuario(Usuario usuarioSesion ,GestionComercio gestionComercio, GestionUsuarios gestionUsuarios)
        {

            int opcionTemp =-1;
            while (opcionTemp < 8)
            { 
                MostrarMenuUsuarios();
                opcionTemp = ElegirOpcionUsuario();
                EjecutarOpcionUsuario(opcionTemp, gestionComercio, gestionUsuarios,usuarioSesion);
            }
           
            
        }

        public void EjecutarOpcionUsuario(int opcion, GestionComercio gestionComercio, GestionUsuarios gestionUsuarios,Usuario usuarioSesion)
        {
            bool existenProductos = false;
            switch (opcion)
            {
                    
                case 1:

                    

                    bool salirMenuTecnologia = false;

                    do
                    {

                        existenProductos = false;
                        Console.Clear();

                        Console.WriteLine("TECNOLOGIA");
                        Console.WriteLine("1 - Filtrar Ordenadores");
                        Console.WriteLine("2 - Filtrar Moviles");
                        Console.WriteLine("3 - Filtrar Videoconsolas");
                        Console.WriteLine("4 - Ver todos los productos de tecnologia");
                        Console.WriteLine("5 - Volver al menu usuario");

                        bool opcionTecnologiaIsInt = int.TryParse(Console.ReadLine(), out int opcionTecnologia);
                        if (opcionTecnologiaIsInt)
                        {
                            switch (opcionTecnologia)
                            {
                                case 1:

                                    Console.WriteLine("ORDENADORES");

                                    if (gestionComercio.ExistenProductosTipo(typeof(Ordenador)))
                                    {
                                        foreach (Producto producto in gestionComercio.FiltroTipoProducto(
                                            typeof(Ordenador)))
                                        {
                                            Console.WriteLine(producto + "\n");
                                        }

                                        existenProductos = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("No queda stock de ordenadores");
                                    }

                                    break;

                                case 2:

                                    Console.WriteLine("MÓVILES");

                                    if (gestionComercio.ExistenProductosTipo(typeof(Movil)))
                                    {
                                        foreach (Producto producto in gestionComercio.FiltroTipoProducto(typeof(Movil)))
                                        {
                                            Console.WriteLine(producto + "\n");
                                        }

                                        existenProductos = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("No queda stock de moviles");
                                    }

                                    break;

                                case 3:

                                    Console.WriteLine("VIDEOCONSOLAS");

                                    if (gestionComercio.ExistenProductosTipo(typeof(VideoConsola)))
                                    {
                                        foreach (Producto producto in gestionComercio.FiltroTipoProducto(
                                            typeof(VideoConsola)))
                                        {
                                            Console.WriteLine(producto + "\n");
                                        }

                                        existenProductos = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("No queda stock de videoconsolas");
                                    }

                                    break;

                                case 4:

                                    Console.WriteLine("PRODUCTOS DE TECNOLOGÍA");

                                    if (
                                        gestionComercio.ExistenProductosTipo(typeof(Ordenador)) ||
                                        gestionComercio.ExistenProductosTipo(typeof(Movil)) ||
                                        gestionComercio.ExistenProductosTipo(typeof(VideoConsola))
                                    )
                                    {
                                        foreach (Producto producto in gestionComercio.Almacen.AlmacenProductos)
                                        {
                                            if (producto is Tecnologia)
                                            {
                                                Console.Write(producto + "\n");
                                            }
                                        }


                                        existenProductos = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("No queda stock de productos de tecnologia");
                                    }

                                    break;

                                case 5:

                                    salirMenuTecnologia = true;

                                    break;

                            }
                        }

                        if (!salirMenuTecnologia && existenProductos)
                        {
                            Console.WriteLine("Escriba el id del producto que quieres añadir a tu carrito.");
                            Console.Write("Id producto:");
                            bool idProductoTecnologiaCarritoIsInt = int.TryParse(Console.ReadLine(),
                                out int idProductoTecnologiaCarrito);
                            if (idProductoTecnologiaCarritoIsInt &&
                                gestionComercio.ExisteProductoId(idProductoTecnologiaCarrito))
                            {
                                if (gestionComercio.GetProductoId(idProductoTecnologiaCarrito).Stock > 0)
                                {

                                    usuarioSesion.CarritoCompra.CarritoCompra.Add(
                                        gestionComercio.GetProductoId(idProductoTecnologiaCarrito));
                                    Console.WriteLine(
                                        $"Producto añadido al carrito correctamente: \n {gestionComercio.GetProductoId(idProductoTecnologiaCarrito).Nombre}");
                                }
                                else
                                {
                                    Console.WriteLine("No queda stock");
                                }

                            }
                            else
                            {
                                Console.WriteLine("Id de producto erróneo");
                            }
                        }

                        if (!salirMenuTecnologia)
                            Mensaje.SalirMenu("Volviendo al menu tecnologia");

                        

                    } while (!salirMenuTecnologia);

                    Mensaje.SalirMenu("Volviendo al menu usuario");

                    break;


                case 2:
                    bool salirMenuModa = false;

                    while (!salirMenuModa)
                    {

                        existenProductos = false;
                        Console.Clear();

                        Console.WriteLine("MODA");
                        Console.WriteLine("1 - Filtrar Calzado");
                        Console.WriteLine("2 - Filtrar Ropa");
                        Console.WriteLine("3 - Filtrar Joyeria");
                        Console.WriteLine("4 - Filtrar Bolsos");
                        Console.WriteLine("5 - Ver todos los productos de moda");
                        Console.WriteLine("6 - Volver al menu usuario");

                        

                        bool opcionModaIsInt = int.TryParse(Console.ReadLine(), out int opcionModa);
                        if (opcionModaIsInt)
                        {
                            switch (opcionModa)
                            {
                                case 1:

                                    Console.WriteLine("CALZADO");

                                    if (gestionComercio.ExistenProductosTipo(typeof(Calzado)))
                                    {
                                        foreach (Producto producto in gestionComercio.FiltroTipoProducto(typeof(Calzado)))
                                        {
                                            Console.WriteLine(producto + "\n");
                                        }
                                        existenProductos = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("No queda stock de calzado");
                                    }

                                    break;

                                case 2:

                                    Console.WriteLine("ROPA");

                                    if (gestionComercio.ExistenProductosTipo(typeof(Ropa)))
                                    {
                                        foreach (Producto producto in gestionComercio.FiltroTipoProducto(typeof(Ropa)))
                                        {
                                            Console.WriteLine(producto + "\n");
                                        }
                                        existenProductos = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("No queda stock de ropa");
                                    }

                                    break;

                                case 3:

                                    Console.WriteLine("JOYERIA");

                                    if (gestionComercio.ExistenProductosTipo(typeof(Joyeria)))
                                    {
                                        foreach (Producto producto in gestionComercio.FiltroTipoProducto(typeof(Joyeria)))
                                        {
                                            Console.WriteLine(producto + "\n");
                                        }
                                        existenProductos = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("No queda stock de joyeria");
                                    }

                                    break;

                                case 4:

                                    Console.WriteLine("BOLSOS");

                                    if (gestionComercio.ExistenProductosTipo(typeof(Bolso)))
                                    {
                                        foreach (Producto producto in gestionComercio.FiltroTipoProducto(typeof(Bolso)))
                                        {
                                            Console.WriteLine(producto + "\n");
                                        }
                                        existenProductos = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("No queda stock de ropa");
                                    }

                                    break;

                                case 5:

                                    Console.WriteLine("MODA");

                                    if (
                                        gestionComercio.ExistenProductosTipo(typeof(Ropa)) ||
                                        gestionComercio.ExistenProductosTipo(typeof(Joyeria)) ||
                                        gestionComercio.ExistenProductosTipo(typeof(Bolso)) ||
                                        gestionComercio.ExistenProductosTipo(typeof(Calzado)) 
                                    )
                                    {
                                        foreach (Producto producto in gestionComercio.Almacen.AlmacenProductos)
                                        {
                                            if (producto is Moda)
                                            {
                                                Console.Write(producto + "\n");
                                            }
                                        }


                                        existenProductos = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("No queda stock de productos de tecnologia");
                                    }

                                    break;

                                case 6:


                                    salirMenuModa = true;

                                    break;

                            }
                        }

                        if (!salirMenuModa && existenProductos)
                        {
                            Console.WriteLine("Escriba el id del producto que quieres añadir a tu carrito.");
                            Console.Write("Id producto:");
                            bool idProductoModaCarritoIsInt = int.TryParse(Console.ReadLine(), out int idProductoModaCarrito);
                            if (idProductoModaCarritoIsInt && gestionComercio.ExisteProductoId(idProductoModaCarrito))
                            {
                               
                                if (gestionComercio.GetProductoId(idProductoModaCarrito).Stock > 0)
                                {

                                    usuarioSesion.CarritoCompra.CarritoCompra.Add(gestionComercio.GetProductoId(idProductoModaCarrito));
                                    Console.WriteLine($"Producto añadido al carrito correctamente: \n {gestionComercio.GetProductoId(idProductoModaCarrito).Nombre}");
                                }
                                else
                                {
                                    Console.WriteLine("No queda stock");
                                }

                            }
                            else
                            {
                                Console.WriteLine("Id de producto erróneo");
                            }
                        }
                    }
                    
                    

                    Mensaje.SalirMenu("Volviendo al menu usuario");
                    

                   
                    break;

                case 3:
                    bool salirMenuMultimedia = false;
                    while (!salirMenuMultimedia)
                    {

                        existenProductos = false;
                        Console.Clear();

                        Console.WriteLine("MULTIMEDIA");
                        Console.WriteLine("1 - Musica");
                        Console.WriteLine("2 - Peliculas o Series");
                        Console.WriteLine("3 - Videojuegos");
                        Console.WriteLine("4 - Ver todos los productos multimedia");
                        Console.WriteLine("5 - Volver al menu usuario");




                        bool opcionMultimediaIsInt = int.TryParse(Console.ReadLine(), out int opcionMultimedia);

                        if (opcionMultimediaIsInt)
                        {
                            switch (opcionMultimedia)
                            {
                                case 1:

                                    Console.WriteLine("MUSICA");

                                    if (gestionComercio.ExistenProductosTipo(typeof(Musica)))
                                    {
                                        foreach (Producto producto in gestionComercio.FiltroTipoProducto(typeof(Musica)))
                                        {
                                            Console.WriteLine(producto + "\n");
                                        }
                                        existenProductos = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("No queda stock de productos de musica");
                                    }

                                    break;

                                case 2:
                                    Console.WriteLine("PELICULAS");

                                    if (gestionComercio.ExistenProductosTipo(typeof(Pelicula)))
                                    {
                                        foreach (Producto producto in gestionComercio.FiltroTipoProducto(typeof(Pelicula)))
                                        {
                                            Console.WriteLine(producto + "\n");
                                        }
                                        existenProductos = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("No queda stock de peliculas");
                                    }
                                    break;

                                case 3:
                                    Console.WriteLine("VIDEOJUEGOS");

                                    if (gestionComercio.ExistenProductosTipo(typeof(VideosJuego)))
                                    {
                                        foreach (Producto producto in gestionComercio.FiltroTipoProducto(typeof(VideosJuego)))
                                        {
                                            Console.WriteLine(producto + "\n");
                                        }
                                        existenProductos = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("No queda stock de videojuegos");
                                    }
                                    break;

                                case 4:

                                    Console.WriteLine("MULTIMEDIA");

                                    if (
                                        gestionComercio.ExistenProductosTipo(typeof(Musica)) ||
                                        gestionComercio.ExistenProductosTipo(typeof(VideosJuego)) ||
                                        gestionComercio.ExistenProductosTipo(typeof(Pelicula))
                                    )
                                    {
                                        foreach (Producto producto in gestionComercio.Almacen.AlmacenProductos)
                                        {
                                            if (producto is Multimedia)
                                            {
                                                Console.Write(producto + "\n");
                                            }
                                        }


                                        existenProductos = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("No queda stock de productos de tecnologia");
                                    }

                                    break;

                                case 5:

                                    salirMenuMultimedia = true;

                                    break;

                            }
                        }


                        if (!salirMenuMultimedia && existenProductos)
                        {

                            Console.WriteLine("Escriba el id del producto que quieres añadir a tu carrito.");
                            Console.Write("Id producto:");
                            bool idProductoMultimediaCarritoIsInt =
                                int.TryParse(Console.ReadLine(), out int idProductoMultimediaCarrito);
                            if (idProductoMultimediaCarritoIsInt &&
                                gestionComercio.ExisteProductoId(idProductoMultimediaCarrito))
                            {
                                
                                if (gestionComercio.GetProductoId(idProductoMultimediaCarrito).Stock > 0)
                                {

                                    usuarioSesion.CarritoCompra.CarritoCompra.Add(
                                        gestionComercio.GetProductoId(idProductoMultimediaCarrito));
                                    Console.WriteLine(
                                        $"Producto añadido al carrito correctamente: \n {gestionComercio.GetProductoId(idProductoMultimediaCarrito).Nombre}");
                                }
                                else
                                {
                                    Console.WriteLine("No queda stock");
                                }

                            }
                            else
                            {
                                Console.WriteLine("Id de producto erróneo");
                            }

                            Mensaje.SalirMenu("Volviendo al menu multimedia");

                        }


                    }
                    

                    Mensaje.SalirMenu("Volviendo al menu usuario");

                    break;

                case 4:

                    existenProductos = false;
                    Console.WriteLine("Todos los productos de la tienda:");

                    
                    
                    if (gestionComercio.Almacen.AlmacenProductos.Count > 0)
                    {
                        foreach (Producto producto in gestionComercio.Almacen.AlmacenProductos)
                        {
                            Console.WriteLine(producto + "\n");
                        }
                        existenProductos = true;
                    }
                    else
                    {
                        Console.WriteLine("No queda stock de productos");
                    }

                    if (existenProductos)
                    {

                        Console.WriteLine("Escriba el id del producto que quieres añadir a tu carrito.");
                        Console.Write("Id producto:");
                        bool idProductoCarritoIsInt =
                            int.TryParse(Console.ReadLine(), out int idProductoCarrito);
                        if (idProductoCarritoIsInt &&
                            gestionComercio.ExisteProductoId(idProductoCarrito))
                        {
                            usuarioSesion.CarritoCompra.CarritoCompra.Add(
                                gestionComercio.GetProductoId(idProductoCarrito));
                            if (gestionComercio.GetProductoId(idProductoCarrito).Stock > 0)
                            {

                                usuarioSesion.CarritoCompra.CarritoCompra.Add(
                                    gestionComercio.GetProductoId(idProductoCarrito));
                                Console.WriteLine(
                                    $"Producto añadido al carrito correctamente: \n {gestionComercio.GetProductoId(idProductoCarrito).Nombre}");
                            }
                            else
                            {
                                Console.WriteLine("No queda stock");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Id de producto erróneo");
                        }

                    }

                    Mensaje.SalirMenu("Volviendo al menu usuario");

                    break;

                case 5:

                    bool salirMenuCuenta = false;
                    while (!salirMenuCuenta)
                    {
                        
                        Console.WriteLine("CUENTA");
                        Console.WriteLine("1-Saldo");
                        Console.WriteLine("2-Configuracion");
                        Console.WriteLine("3-Volver al menu usuario");
                        bool opcionCuentaIsInt = int.TryParse(Console.ReadLine(), out int opcionCuenta);
                        if (opcionCuentaIsInt)
                        {
                            switch (opcionCuenta)
                            {
                                case 1:

                                    bool salirMenuSaldo = false;
                                    while (!salirMenuSaldo)
                                    {
                                        Console.WriteLine("SALDO");
                                        Console.WriteLine("1 - Consultar saldo");
                                        Console.WriteLine("2 - Ingresar saldo");
                                        Console.WriteLine("3 - Volver a menu cuenta");
                                        
                                        bool opcionSaldoIsInt = int.TryParse(Console.ReadLine(), out int opcionSaldo);
                                        if (opcionCuentaIsInt)
                                        {
                                            switch (opcionSaldo)
                                            {
                                                case 1:

                                                    Console.Write($"Saldo de la cuenta: {usuarioSesion.Saldo}");

                                                    Console.WriteLine("Pulse una letra para continuar");
                                                    Console.ReadKey();
                                                    break;

                                                case 2:

                                                    Console.WriteLine("Ingresar saldo");
                                                    Console.Write("Ingrese la cantidad a ingresar:");
                                                    bool saldoIsFloat = float.TryParse(Console.ReadLine(), out float saldo);
                                                    if (saldoIsFloat)
                                                    {
                                                        usuarioSesion.Saldo += saldo;
                                                        Console.WriteLine($"Saldo añadido correctamente. Nuevo saldo: {usuarioSesion.Saldo} ");
                                                    }



                                                    Console.WriteLine("Pulse una letra para continuar");
                                                    Console.ReadKey();

                                                    break;

                                                case 3:

                                                    Mensaje.SalirMenu("Volviendo al menu cuenta");
                                                    salirMenuSaldo = true;
                                                    break;
                                            }
                                        }

                                    }

                                    break;

                                case 2:

                                    bool salirMenuConfiguracion = false;

                                    while (!salirMenuConfiguracion)
                                    {
                                         Console.WriteLine("Configuracion cuenta de usuario");
                                        Console.WriteLine("1-Nombre");
                                        Console.WriteLine("2-Contraseña");
                                        Console.WriteLine("3-Salir");
                                        Console.Write("Elija una opcion:");
                                        bool opcionDatosUSuarioIsInt = int.TryParse(Console.ReadLine(), out int opcionDatosUsuario);
                                        if (opcionDatosUSuarioIsInt && opcionDatosUsuario > 0 && opcionDatosUsuario < 4)
                                        {
                                            switch (opcionDatosUsuario)
                                            {
                                                case 1:
                                                    Console.Write("Escriba el nuevo nombre:");
                                                    string nuevoNombre = Console.ReadLine();
                                                    gestionUsuarios.ModificarUsuario(usuarioSesion, nuevoNombre, "nombre");
                                                    Console.WriteLine("Nombre cambiado correctamente");

                                                    break;

                                                case 2:
                                                    Console.Write("Escriba la nueva contraseña:");
                                                    string nuevaPass = Console.ReadLine();
                                                    gestionUsuarios.ModificarUsuario(usuarioSesion, nuevaPass, "contraseña");
                                                    Console.WriteLine("Contraseña cambiada correctamente");

                                                    break;

                                                case 3:


                                                    Mensaje.SalirMenu("Volviendo al menu cuenta");
                                                    salirMenuConfiguracion = true;

                                                    break;
                                            }
                                        }
                                    }
                                   

                                    break;

                                case 3:

                                    Mensaje.SalirMenu("Volviendo al menu usuario");
                                    salirMenuCuenta= true;

                                    break;



                            }
                        }
                    }
                    

                    break;

                case 6:

                    Console.WriteLine("CARRITO");

                    if (usuarioSesion.CarritoCompra.CarritoCompra.Count > 0)
                    {
                        foreach (Producto productoCarrito in usuarioSesion.CarritoCompra.CarritoCompra)
                        {
                            Console.WriteLine(productoCarrito);
                        }

                        Console.WriteLine("1-Hacer pedido del carrito de compra");
                        Console.WriteLine("2-Eliminar producto");
                        Console.WriteLine("3-Eliminar carrito");
                        Console.WriteLine("4-Volver al menu de usuario");

                        bool opcionCarritoIsInt = int.TryParse(Console.ReadLine(), out int opcionCarrito);
                        if (opcionCarritoIsInt)
                        {
                            switch (opcionCarrito)
                            {
                                case 1:
                                    Console.WriteLine("Hacer pedido");
                                    float sumaProductos=0;
                                    bool compraCorrecta;
                                    
                                    foreach (Producto producto in usuarioSesion.CarritoCompra.CarritoCompra)
                                    {
                                        if (producto.Stock > 0)
                                        {
                                            sumaProductos += producto.Precio;
                                        }
                                    }

                                    if (sumaProductos <= usuarioSesion.Saldo)
                                    {

                                        sumaProductos = 0;
                                        foreach (Producto producto in usuarioSesion.CarritoCompra.CarritoCompra)
                                        {
                                            if (producto.Stock >= 0)
                                            {
                                                gestionComercio.GetProductoId(producto.IdProducto).Stock--;
                                                sumaProductos += producto.Precio;
                                            }
                                            else
                                            {
                                                Console.WriteLine($"No queda mas stock de {producto.Nombre}");
                                            }
                                            
                                        }
                                        usuarioSesion.Saldo -= sumaProductos;
                                        Console.WriteLine($"Pedido realizado.");
                                        usuarioSesion.CarritoCompra.CarritoCompra.Clear();

                                    }
                                    else
                                    {
                                        Console.WriteLine("No tienes suficiente saldo.\n" +
                                                          "Info: Para hacer una recarga de saldo -> CUENTA > SALDO > INGRESAR SALDO");
                                    }

                                    Console.WriteLine("Pulse una letra para continuar");
                                    Console.ReadKey();
                                    break;

                                case 2:
                                    Console.WriteLine("Eliminar producto del carrito");
                                    foreach (Producto producto in usuarioSesion.CarritoCompra.CarritoCompra)
                                    {
                                        Console.WriteLine(producto);
                                    }

                                    Console.WriteLine("Introduzca el id del producto que quiere eliminar de su carrito");
                                    bool idProductoEliminarIsInt = int.TryParse(Console.ReadLine(),out int idProductoEliminar);

                                    Producto productoEliminar = null;

                                    foreach (Producto producto in usuarioSesion.CarritoCompra.CarritoCompra)
                                    {
                                        if (producto.IdProducto == idProductoEliminar)
                                        {
                                            productoEliminar = producto;
                                        }
                                    }
                                    usuarioSesion.CarritoCompra.CarritoCompra.Remove(productoEliminar);
                                    Console.WriteLine("Pulse una letra para continuar");
                                    Console.ReadKey();

                                    break;
                                case 3:
                                    Console.WriteLine("Eliminando el carrito completo");
                                    usuarioSesion.CarritoCompra.CarritoCompra.Clear();

                                    Console.WriteLine("Carrito limpio");

                                    Console.WriteLine("Pulse una letra para continuar");
                                    Console.ReadKey();
                                    break;


                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("No tienes ningun producto en el carrito");
                    }

                    Mensaje.SalirMenu("Volviendo al menu usuario");
                    Thread.Sleep(1000);

                    break;

                case 7:

                    Console.WriteLine("Eliminar usuario");
                    Console.Write("Escriba su nombre de usuario si está de acuerdo en eliminar su cuenta: ");
                    string confirmacionEliminacion = Console.ReadLine();

                    if (usuarioSesion.Nombre.Equals(confirmacionEliminacion))
                    {
                        if (gestionUsuarios.EliminarUsuario(usuarioSesion))
                        {
                            Console.WriteLine("Usuario Eliminado correctamente");
                            

                        }
                        else
                        {
                            Console.WriteLine("Error en la eliminacion del usuario");
                        }
                        ;
                    }
                    else
                    {
                        Console.WriteLine("No he escrito correctamente su nombre. Su cuenta no se ha elimnado");
                        Mensaje.SalirMenu("Saliendo de la sesion de usuario");
                    }

                    Console.WriteLine("Pulse una letra para continuar");
                    Console.ReadKey();



                    break;

                case 8:
                    Mensaje.SalirMenu("Cerrando la sesion de usuario");
                    break;
            }
        }
        public int ElegirOpcionUsuario()
        {
            bool opcionCorrecta = false;
            int opcionUsuario = -1;
            do
            {
                bool opcionUsuarioIsINt = int.TryParse(Console.ReadLine(), out opcionUsuario);

                if (opcionUsuarioIsINt && opcionUsuario <= 7 && opcionUsuario >= 1)
                {
                    opcionCorrecta = true;
                }
                else
                {
                    Console.WriteLine("No has elegido una opción correcta");
                }
            } while (!opcionCorrecta);

            return opcionUsuario;

        }

        private void MostrarMenuUsuarios()
        {
            Console.Clear();
            Console.WriteLine("1-Tecnologia");
            Console.WriteLine("2-Moda");
            Console.WriteLine("3-Multimedia");
            Console.WriteLine("4-Ver todos los productos");
            Console.WriteLine("5-Cuenta");
            Console.WriteLine("6-CarritoCompra");
            Console.WriteLine("7-Eliminar cuenta");
            Console.WriteLine("8-Salir\n");
            Console.Write("Opcion Menu Principal:");
        }

    }
}
