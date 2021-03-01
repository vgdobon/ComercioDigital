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
using ComercioDigital.Utiles;

namespace ComercioDigital.Presentacion
{
    public class MenuUsuario
    {

        public void EjecutarMenuUsuario(Usuario usuarioSesion)
        {

            int opcionTemp =-1;
            while (opcionTemp < 8)
            { 
                MostrarMenuUsuarios();
                opcionTemp = ElegirOpcionUsuario();
                EjecutarOpcionUsuario(opcionTemp,usuarioSesion);
            }
           
            
        }

        private void MostrarMenuUsuarios()
        {
            Console.Clear();
            Console.WriteLine("1-Tecnologia");
            Console.WriteLine("2-Moda");
            Console.WriteLine("3-Multimedia");
            Console.WriteLine("4-Filtro de productos");
            Console.WriteLine("5-Ver todos los productos");
            Console.WriteLine("6-Cuenta");
            Console.WriteLine("7-Carrito");
            Console.WriteLine("8-Eliminar cuenta");
            Console.WriteLine("9-Salir\n");
            Console.Write("Opcion Menu Principal:");
        }

        public void EjecutarOpcionUsuario(int opcion,Usuario usuarioSesion)
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

                        Console.Write("Elija una opcion: ");
                        bool opcionTecnologiaIsInt = int.TryParse(Console.ReadLine(), out int opcionTecnologia);
                        if (opcionTecnologiaIsInt)
                        {
                            switch (opcionTecnologia)
                            {
                                case 1:

                                    Console.WriteLine("ORDENADORES");

                                    if (GestionComercio.ExistenProductosTipo(typeof(Ordenador)))
                                    {
                                        foreach (Producto producto in GestionComercio.FiltroTipoProducto(
                                            typeof(Ordenador)))
                                        {
                                            Console.WriteLine(producto + "\n");
                                        }

                                        existenProductos = true;
                                    }
                                   

                                    break;

                                case 2:

                                    Console.WriteLine("MÓVILES");

                                    if (GestionComercio.ExistenProductosTipo(typeof(Movil)))
                                    {
                                        foreach (Producto producto in GestionComercio.FiltroTipoProducto(typeof(Movil)))
                                        {
                                            Console.WriteLine(producto + "\n");
                                        }

                                        existenProductos = true;
                                    }
                                    else
                                    {
                                        existenProductos = false;
                                    }
                                    

                                    break;

                                case 3:

                                    Console.WriteLine("VIDEOCONSOLAS");

                                    if (GestionComercio.ExistenProductosTipo(typeof(VideoConsola)))
                                    {
                                        foreach (Producto producto in GestionComercio.FiltroTipoProducto(
                                            typeof(VideoConsola)))
                                        {
                                            Console.WriteLine(producto + "\n");
                                        }

                                        existenProductos = true;
                                    }
                                    else
                                    {

                                        existenProductos = false;
                                    }
                                    

                                    break;

                                case 4:

                                    Console.WriteLine("PRODUCTOS DE TECNOLOGÍA");

                                    if (
                                        GestionComercio.ExistenProductosTipo(typeof(Ordenador)) ||
                                        GestionComercio.ExistenProductosTipo(typeof(Movil)) ||
                                        GestionComercio.ExistenProductosTipo(typeof(VideoConsola))
                                    )
                                    {
                                        foreach (Producto producto in GestionComercio.ListaAlmacen())
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
                                        existenProductos = false;
                                    }

                                    break;

                                case 5:

                                    salirMenuTecnologia = true;

                                    break;

                                default:

                                    Console.WriteLine("No has elegido una opción correcta");

                                    break;

                            }
                        }

                        if (!salirMenuTecnologia)
                        {
                            if (existenProductos)
                            {
                                Console.WriteLine("Escriba el id del producto que quieres añadir a tu carrito o 0 para volver al menu usuario");
                                Console.Write("Id producto:");
                                bool idProductoTecnologiaCarritoIsInt = int.TryParse(Console.ReadLine(),
                                    out int idProductoTecnologiaCarrito);
                                if (idProductoTecnologiaCarrito != 0)
                                {
                                    if (idProductoTecnologiaCarritoIsInt &&
                                    GestionComercio.ExisteProductoId(idProductoTecnologiaCarrito))
                                    {
                                        if (GestionComercio.GetProductoId(idProductoTecnologiaCarrito).Stock > 0)
                                        {

                                            GestionUsuarios.AnnadirProductoCarrito(GestionComercio.GetProductoId(idProductoTecnologiaCarrito), usuarioSesion);
                                            Console.WriteLine(
                                                $"Producto añadido al carrito correctamente: \n {GestionComercio.GetProductoId(idProductoTecnologiaCarrito).Nombre}");
                                            Mensaje.PulsaTeclaSalir();
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
                                else
                                {
                                    salirMenuTecnologia = true;
                                }
                            }else
                            {
                                Mensaje.SalirMenu("No quedan productos de ese tipo.");
                                salirMenuTecnologia = true;
                            }


                        }
                        

                        
                        if (!salirMenuTecnologia)
                        {
                            Mensaje.SalirMenu("Volviendo al menu tecnologia");
                        }
                
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

                        Console.Write("Elija una opcion: ");

                        bool opcionModaIsInt = int.TryParse(Console.ReadLine(), out int opcionModa);
                        if (opcionModaIsInt)
                        {
                            switch (opcionModa)
                            {
                                case 1:

                                    Console.WriteLine("CALZADO");

                                    if (GestionComercio.ExistenProductosTipo(typeof(Calzado)))
                                    {
                                        foreach (Producto producto in GestionComercio.FiltroTipoProducto(typeof(Calzado)))
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

                                    if (GestionComercio.ExistenProductosTipo(typeof(Ropa)))
                                    {
                                        foreach (Producto producto in GestionComercio.FiltroTipoProducto(typeof(Ropa)))
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

                                    if (GestionComercio.ExistenProductosTipo(typeof(Joyeria)))
                                    {
                                        foreach (Producto producto in GestionComercio.FiltroTipoProducto(typeof(Joyeria)))
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

                                    if (GestionComercio.ExistenProductosTipo(typeof(Bolso)))
                                    {
                                        foreach (Producto producto in GestionComercio.FiltroTipoProducto(typeof(Bolso)))
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
                                        GestionComercio.ExistenProductosTipo(typeof(Ropa)) ||
                                        GestionComercio.ExistenProductosTipo(typeof(Joyeria)) ||
                                        GestionComercio.ExistenProductosTipo(typeof(Bolso)) ||
                                        GestionComercio.ExistenProductosTipo(typeof(Calzado)) 
                                    )
                                    {
                                        foreach (Producto producto in GestionComercio.ListaAlmacen())
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

                                default:

                                    Console.WriteLine("No has elegido una opción correcta");

                                    break;

                            }
                        }

                        if (!salirMenuModa)
                        {
                            if (existenProductos)
                            {
                                    Console.WriteLine("Escriba el id del producto que quieres añadir a tu carrito o 0 para volver al menu usuario");
                                    Console.Write("Id producto:");
                                    bool idProductoModaCarritoIsInt = int.TryParse(Console.ReadLine(), out int idProductoModaCarrito);
                                    if(idProductoModaCarrito != 0)
                                    {
                                
                                        if (idProductoModaCarritoIsInt && GestionComercio.ExisteProductoId(idProductoModaCarrito))
                                        {

                                            if (GestionComercio.GetProductoId(idProductoModaCarrito).Stock > 0)
                                            {

                                                GestionUsuarios.AnnadirProductoCarrito(GestionComercio.GetProductoId(idProductoModaCarrito), usuarioSesion);
                                                Console.WriteLine($"Producto añadido al carrito correctamente: \n {GestionComercio.GetProductoId            (idProductoModaCarrito).Nombre}");
                                                Mensaje.PulsaTeclaSalir();
                                            
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
                                    else
                                    {
                                        salirMenuModa = true;
                                    }
                                
                            }else
                            {
                                Mensaje.SalirMenu("No quedan productos de ese tipo.");
                                salirMenuModa = true;
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

                        Console.Write("Elija una opcion: ");


                        bool opcionMultimediaIsInt = int.TryParse(Console.ReadLine(), out int opcionMultimedia);

                        if (opcionMultimediaIsInt)
                        {
                            switch (opcionMultimedia)
                            {
                                case 1:

                                    Console.WriteLine("MUSICA");

                                    if (GestionComercio.ExistenProductosTipo(typeof(Musica)))
                                    {
                                        foreach (Producto producto in GestionComercio.FiltroTipoProducto(typeof(Musica)))
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

                                    if (GestionComercio.ExistenProductosTipo(typeof(Pelicula)))
                                    {
                                        foreach (Producto producto in GestionComercio.FiltroTipoProducto(typeof(Pelicula)))
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

                                    if (GestionComercio.ExistenProductosTipo(typeof(VideoJuego)))
                                    {
                                        foreach (Producto producto in GestionComercio.FiltroTipoProducto(typeof(VideoJuego)))
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
                                        GestionComercio.ExistenProductosTipo(typeof(Musica)) ||
                                        GestionComercio.ExistenProductosTipo(typeof(VideoJuego)) ||
                                        GestionComercio.ExistenProductosTipo(typeof(Pelicula))
                                    )
                                    {
                                        foreach (Producto producto in GestionComercio.ListaAlmacen())
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

                                default:

                                    Console.WriteLine("No has elegido una opción correcta");

                                    break;

                            }
                        }


                        if (!salirMenuMultimedia)
                        {
                            if (existenProductos)
                            {
                                Console.WriteLine("Escriba el id del producto que quieres añadir a tu carrito o 0 para volver al menu usuario");
                                Console.Write("Id producto:");
                                bool idProductoMultimediaCarritoIsInt =
                                    int.TryParse(Console.ReadLine(), out int idProductoMultimediaCarrito);
                                if (idProductoMultimediaCarrito != 0)
                                {
                                    if (idProductoMultimediaCarritoIsInt &&
                                                                    GestionComercio.ExisteProductoId(idProductoMultimediaCarrito))
                                    {

                                        if (GestionComercio.GetProductoId(idProductoMultimediaCarrito).Stock > 0)
                                        {
                                            GestionUsuarios.AnnadirProductoCarrito(GestionComercio.GetProductoId(idProductoMultimediaCarrito), usuarioSesion);


                                            Console.WriteLine(
                                                $"Producto añadido al carrito correctamente: \n {GestionComercio.GetProductoId(idProductoMultimediaCarrito).Nombre}");
                                            Mensaje.PulsaTeclaSalir();
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
                                else
                                {
                                    salirMenuMultimedia = true;
                                }
                            }
                            else
                            {
                                Mensaje.SalirMenu("No existen productos");
                                salirMenuMultimedia = true;
                            }                         
                        }
                        
                        if(!salirMenuMultimedia)
                        {
                            Mensaje.SalirMenu("Volviendo al menu multimedia");
                        }

                    }

                    Mensaje.SalirMenu("Volviendo al menu usuario");

                    break;

                case 4:
                    bool salirMenuFiltro = false;
                    bool existenProductosFiltro = false;
                    if (GestionComercio.ListaAlmacen().Count > 0)
                    {
                        while (!salirMenuFiltro)
                        {
                            Console.WriteLine("Filtrado de productos");
                            Console.WriteLine("1 - Filtrar por precio");
                            Console.WriteLine("2 - Filtrar por Marca");
                            Console.WriteLine("3 - Filtrar por Identificativo");
                            Console.WriteLine("4 - Volver al menu usuario");

                            Console.WriteLine("Elija una opcion");
                            bool opcionFiltradoIsInt =
                                    int.TryParse(Console.ReadLine(), out int opcionFiltrado);
                            if (opcionFiltradoIsInt)
                            {
                                switch (opcionFiltrado)
                                {
                                    case 1:
                                        Console.WriteLine("Escriba el precio maximo de los productos que quiera ver:");
                                        bool precioIsDecimal = decimal.TryParse(Console.ReadLine(), out decimal precio);
                                        if (precioIsDecimal)
                                        {
                                            if (GestionComercio.FiltroProductoPrecio(precio).Count > 0) 
                                            {
                                                foreach(Producto producto in GestionComercio.FiltroProductoPrecio(precio))
                                                {
                                                    Console.WriteLine(producto);
                                                }
                                                existenProductosFiltro = true;
                                            }
                                            else
                                            {
                                                Console.WriteLine("No existen productos por debajo de ese precio");
                                                salirMenuFiltro = true;
                                            }
                                               
                                        }
                                        else
                                        {
                                            Console.WriteLine("No has introducido un número correcto");
                                            salirMenuFiltro = true;
                                        }
                                        break;

                                    case 2:
                                        Console.WriteLine("Escriba la marca de los productos que quiere ver:");
                                        string marcaConsultada = Console.ReadLine();
                                        if (GestionComercio.FiltroProductoMarca(marcaConsultada).Count > 0)
                                        {
                                            foreach(Producto producto in GestionComercio.FiltroProductoMarca(marcaConsultada))
                                            {
                                                Console.WriteLine(producto);
                                            }

                                            existenProductosFiltro = true;
                                        }
                                        else
                                        {
                                            Console.WriteLine($"No existen productos de la marca {marcaConsultada}");
                                            salirMenuFiltro = true;
                                        }


                                        break;

                                    case 3:

                                        foreach (Producto producto in GestionComercio.ListaAlmacen())
                                        {
                                            Console.WriteLine($"{producto.IdProducto} {producto.Nombre}\n");
                                        }

                                        Console.WriteLine("Escriba el id del producto que quiere ver en detalle:");
                                        bool idIsInt = int.TryParse(Console.ReadLine(), out int id);
                                            
                                        if (idIsInt)
                                        {
                                            if (GestionComercio.ExisteProductoId(id))
                                            {
                                                Console.WriteLine(GestionComercio.GetProductoId(id));
                                                existenProductosFiltro = true;
                                            }
                                            else
                                            {
                                                Console.WriteLine("No existe un producto con ese ID");
                                                salirMenuFiltro = true;
                                            }
                                            
                                        }
                                        else
                                        {
                                            Console.WriteLine("No has introducido un id correcto");
                                            salirMenuFiltro = true;
                                        }
                                       
                                        break;

                                    case 4:

                                        Mensaje.SalirMenu("Volviendo al menu usuario");
                                        salirMenuFiltro = true;

                                        break;
                                }

                                if (existenProductosFiltro && !salirMenuFiltro)
                                {
                                    Console.WriteLine("Escriba el id del producto que quieres añadir a tu carrito o 0 para volver al menu usuario");
                                    Console.Write("Id producto:");
                                    bool idProductoFiltradoIsInt =
                                        int.TryParse(Console.ReadLine(), out int idProductoFiltrado);
                                    if (idProductoFiltrado != 0)
                                    {
                                        if (idProductoFiltradoIsInt &&
                                                                        GestionComercio.ExisteProductoId(idProductoFiltrado))
                                        {

                                            if (GestionComercio.GetProductoId(idProductoFiltrado).Stock > 0)
                                            {
                                                GestionUsuarios.AnnadirProductoCarrito(GestionComercio.GetProductoId(idProductoFiltrado), usuarioSesion);


                                                Console.WriteLine(
                                                    $"Producto añadido al carrito correctamente: \n {GestionComercio.GetProductoId(idProductoFiltrado).Nombre}");
                                                
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

                            }
                            else
                            {
                                Console.WriteLine("No has elegido una opción correcta");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("No existen productos en el almacén");
                    }

                    Mensaje.PulsaTeclaSalir();

                    break;

                case 5:

                    existenProductos = false;
                    Console.WriteLine("Todos los productos de la tienda:");

                    if (GestionComercio.ListaAlmacen().Count > 0)
                    {
                        foreach (Producto producto in GestionComercio.ListaAlmacen())
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
                        Console.WriteLine("Escriba el id del producto que quieres añadir a tu carrito o 0 para volver al menu usuario");
                        Console.Write("Id producto:");
                        bool idProductoCarritoIsInt =
                            int.TryParse(Console.ReadLine(), out int idProductoCarrito);
                        if(idProductoCarrito != 0)
                        {
                            if (idProductoCarritoIsInt &&
                            GestionComercio.ExisteProductoId(idProductoCarrito))
                            {
                                usuarioSesion.CarritoCompra.CarritoCompra.Add(
                                    GestionComercio.GetProductoId(idProductoCarrito));
                                if (GestionComercio.GetProductoId(idProductoCarrito).Stock > 0)
                                {
                                    GestionUsuarios.AnnadirProductoCarrito(GestionComercio.GetProductoId(idProductoCarrito), usuarioSesion);
                                   
                                    Console.WriteLine(
                                        $"Producto añadido al carrito correctamente: \n {GestionComercio.GetProductoId(idProductoCarrito).Nombre}");
                                    Mensaje.PulsaTeclaSalir();
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
                    else
                    {
                        Mensaje.SalirMenu("No quedan productos de ese tipo.");
                        salirMenuModa = true;
                    }

                    Mensaje.SalirMenu("Volviendo al menu usuario");

                    break;

                case 6:

                    bool salirMenuCuenta = false;
                    while (!salirMenuCuenta)
                    {
                        
                        Console.WriteLine("\nCUENTA");
                        Console.WriteLine("1-Saldo");
                        Console.WriteLine("2-Configuracion");
                        Console.WriteLine("3-Volver al menu usuario");
                        Console.Write("Elija una opcion: ");
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

                                                    Console.Write($"Saldo de la cuenta: {GestionUsuarios.ConsultarSaldo(usuarioSesion)}");

                                                    Mensaje.PulsaTeclaSalir();
                                                    break;

                                                case 2:

                                                    Console.WriteLine("Ingresar saldo");
                                                    Console.Write("Ingrese la cantidad a ingresar:");
                                                    bool saldoIsFloat = decimal.TryParse(Console.ReadLine(), out decimal saldo);
                                                    if (saldoIsFloat)
                                                    {
                                                        GestionUsuarios.AnnadirSaldo(usuarioSesion,saldo);

                                                        Console.WriteLine($"Saldo añadido correctamente. Nuevo saldo: {GestionUsuarios.ConsultarSaldo(usuarioSesion)} ");
                                                    }

                                                    Mensaje.PulsaTeclaSalir();

                                                    break;

                                                case 3:

                                                    Mensaje.SalirMenu("Volviendo al menu cuenta");
                                                    salirMenuSaldo = true;
                                                    break;

                                                default:

                                                    Console.WriteLine("No has elegido una opción correcta");

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
                                                    GestionUsuarios.ModificarUsuario(usuarioSesion, nuevoNombre, "nombre");
                                                    Console.WriteLine("Nombre cambiado correctamente");

                                                    break;

                                                case 2:
                                                    Console.Write("Escriba la nueva contraseña:");
                                                    string nuevaPass = Console.ReadLine();
                                                    GestionUsuarios.ModificarUsuario(usuarioSesion, nuevaPass, "contraseña");
                                                    Console.WriteLine("Contraseña cambiada correctamente");

                                                    break;

                                                case 3:


                                                    Mensaje.SalirMenu("Volviendo al menu cuenta");
                                                    salirMenuConfiguracion = true;

                                                    break;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("No has elegido una opción correcta");
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

                case 7:

                    Console.WriteLine("CARRITO");

                    if (GestionUsuarios.ProductosCarrito(usuarioSesion) > 0 )
                    {
                        decimal sumaCarrito = 0;
                        foreach (Producto productoCarrito in usuarioSesion.CarritoCompra.CarritoCompra)
                        {
                            Console.WriteLine(productoCarrito);
                            sumaCarrito += productoCarrito.Precio;
                        }

                        Console.WriteLine($"PRECIO TOTAL: {sumaCarrito }");

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

                                    Mensaje.SalirMenu("Realizando pedido");


                                    if (GestionUsuarios.HacerPedido(usuarioSesion))
                                    {
                                        Console.WriteLine($"Pedido realizado.");

                                    }
                                    else
                                    {
                                        Console.WriteLine("No tienes suficiente saldo.\n" +
                                                          "Info: Para hacer una recarga de saldo -> CUENTA > SALDO > INGRESAR SALDO");
                                    }

                                    Mensaje.PulsaTeclaSalir();
                                    break;

                                case 2:

                                    Console.WriteLine("Eliminar producto del carrito");
                                    foreach (Producto producto in usuarioSesion.CarritoCompra.CarritoCompra)
                                    {
                                        Console.WriteLine(producto);
                                    }

                                    Console.WriteLine("Introduzca el id del producto que quiere eliminar de su carrito o 0 para cancelar");
                                    bool idProductoEliminarIsInt = int.TryParse(Console.ReadLine(),out int idProductoEliminar);

                                    if(idProductoEliminar != 0)
                                    {
                                        Producto productoEliminar = null;

                                        foreach (Producto producto in usuarioSesion.CarritoCompra.CarritoCompra)
                                        {
                                            if (producto.IdProducto == idProductoEliminar)
                                            {
                                                productoEliminar = producto;

                                            }
                                        }
                                        GestionUsuarios.EliminarProductoCarrito(productoEliminar, usuarioSesion);
                                    }

                                    Mensaje.PulsaTeclaSalir();

                                    break;

                                case 3:

                                    Console.WriteLine("Eliminando el carrito completo");
                                    GestionUsuarios.LimpiarCarrito(usuarioSesion);
                                    Console.WriteLine("Carrito limpio");
                                    Mensaje.PulsaTeclaSalir();
                                    break;


                                default:

                                    Console.WriteLine("No has elegido una opción correcta");

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

                case 8:

                    Console.WriteLine("Eliminar usuario");
                    Console.Write("Escriba su nombre de usuario si está de acuerdo en eliminar su cuenta: ");
                    string confirmacionEliminacion = Console.ReadLine();

                    if (usuarioSesion.Nombre.Equals(confirmacionEliminacion))
                    {
                        if (GestionUsuarios.EliminarUsuario(usuarioSesion))
                        {
                            Console.WriteLine("Usuario Eliminado correctamente");
                            

                        }
                        else
                        {
                            Console.WriteLine("Error en la eliminacion del usuario");
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("No he escrito correctamente su nombre. Su cuenta no se ha elimnado");
                        
                    }

                    Mensaje.SalirMenu("Saliendo de la sesion de usuario");
                    Mensaje.PulsaTeclaSalir();



                    break;

                case 9:
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

                if (opcionUsuarioIsINt && opcionUsuario <= 9 && opcionUsuario >= 1)
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
    }
}
