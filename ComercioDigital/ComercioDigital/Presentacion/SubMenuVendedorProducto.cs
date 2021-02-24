using System;
using ComercioDigital.DTOs.Personas;
using ComercioDigital.DTOs.Productos;
using ComercioDigital.DTOs.Productos.Moda;
using ComercioDigital.DTOs.Productos.Multimedia;
using ComercioDigital.DTOs.Productos.Tecnologia;
using ComercioDigital.Servicio;
using ComercioDigital.Utiles;

namespace ComercioDigital.Presentacion
{
    public class SubMenuVendedorProducto
    {
        private Vendedor vendedorSesion;
        public bool salirMenu;

        public SubMenuVendedorProducto(Vendedor vendedor)
        {
            vendedorSesion = vendedor;
            salirMenu = false;
        }

        public void EjecutarMenu()
        {

            int opcionTemp = -1;
            do
            {
                MostrarMenuProducto();
                
                opcionTemp = RecogerOpcionMenu();
                if (opcionTemp > 0 && opcionTemp < 5)
                {
                    if(opcionTemp==4){
                        salirMenu=true;
                    }else{
                        EjecutarOpcionMenuProducto(opcionTemp);
                    }
                    
                }
                else
                {
                    opcionTemp = -1;
                    Console.WriteLine("No has elegido una opcion correcta\n");
                }
                

            } while (opcionTemp < 0 || !salirMenu);

            Console.WriteLine("Se cerro la sesion del vendedor");

            
        }

        private void MostrarMenuProducto()
        {
            Console.Clear();
            Console.WriteLine("Elija el tipo del producto:\n" +
                                  "1  Tecnología\n" +
                                  "2  Moda\n" + 
                                  "3  Multimedia\n" +
                                  "4  Volver al menu de vendedor\n");
        }

        private void EjecutarOpcionMenuProducto(int opcion)
        { 
            int opcionMenuProducto = 0;
            switch (opcion)
            { 
                   
                case 1:
                    do
                    {
                        MostrarMenuTecnologia();
                        opcionMenuProducto = RecogerOpcionMenu();
                        if (opcionMenuProducto > 0 && opcionMenuProducto < 5)
                        {
                            EjecutarOpcionMenuTecnologia(opcionMenuProducto);
                        }
                        else
                        {
                            Console.WriteLine("No has elegido una opcion correcta");
                            opcionMenuProducto = -1;
                        }
                    } while (opcionMenuProducto < 0 );
                    
                    

                    break;

                case 2:
                    do
                    {
                        MostrarMenuModa();
                        opcionMenuProducto = RecogerOpcionMenu();
                        if (opcionMenuProducto > 0 && opcionMenuProducto < 6)
                        {
                            EjecutarOpcionMenuModa(opcionMenuProducto);
                        }
                        else
                        {
                            Console.WriteLine("No has elegido una opcion correcta");
                            opcionMenuProducto = -1;
                        }
                    } while (opcionMenuProducto < 0);
                    


                    break;

                case 3:
                    do
                    {
                        MostrarMenuMultimedia();
                        opcionMenuProducto = RecogerOpcionMenu();
                        if (opcionMenuProducto > 0 && opcionMenuProducto < 5)
                        {
                            EjecutarOpcionMenMultimedia(opcionMenuProducto);
                        }
                        else
                        {
                            Console.WriteLine("No has elegido una opcion correcta");
                            opcionMenuProducto = -1;
                        }
                        
                    } while (opcionMenuProducto < 0);
                    

                    break;

                case 4:

                    Mensaje.SalirMenu("Volviendo al menu principal de vendendor");

                    break;

            }
        }

        private void MostrarMenuTecnologia()
        {
            Console.Clear();
            Console.WriteLine("Elija el tipo del producto de Tecnologia:\n" +
                              "1  Ordenador\n" +
                              "2  Videoconsola\n" +
                              "3  Tablet o smartphone\n" +
                              "4  Volver al menu vendedor\n");
        }

        private void EjecutarOpcionMenuTecnologia(int opcion)
        {
            

            switch (opcion)
            {

                case 1:
                    Tecnologia productoTecnologiaOrdenador = DatosProducto.RecogerDatosTecnologia(vendedorSesion);
                    Console.WriteLine("Ordenador:");

                    Console.Write("Placa Base:");
                    var placaBase = Console.ReadLine();

                    Console.Write("Tipo de ordenador(Portatil,sobremesa,surface...):");
                    var tipoOrdenador = Console.ReadLine();

                    var nuevoOrdenador = new Ordenador(null,productoTecnologiaOrdenador.Nombre,
                        productoTecnologiaOrdenador.Marca, productoTecnologiaOrdenador.Precio,
                        productoTecnologiaOrdenador.Vendedor, productoTecnologiaOrdenador.Descripcion,
                        productoTecnologiaOrdenador.FechaPuestaVenta, productoTecnologiaOrdenador.CodigoDescuento,
                        productoTecnologiaOrdenador.Stock, productoTecnologiaOrdenador.Color,
                        productoTecnologiaOrdenador.Procesador, productoTecnologiaOrdenador.SO, productoTecnologiaOrdenador.Modelo,
                        productoTecnologiaOrdenador.FechaLanzamiento, placaBase, tipoOrdenador);
                    GestionComercio.AgregarProductoAlmacen(nuevoOrdenador);

                    Mensaje.PulsaTeclaSalir();

                    break;

                case 2:
                    Tecnologia productoVideoconsola = DatosProducto.RecogerDatosTecnologia(vendedorSesion);
                    Console.WriteLine("Videoconsola:");

                    var nuevoVideoConsola = new VideoConsola(null, productoVideoconsola.Nombre,
                        productoVideoconsola.Marca, productoVideoconsola.Precio,
                        productoVideoconsola.Vendedor, productoVideoconsola.Descripcion,
                        productoVideoconsola.FechaPuestaVenta, productoVideoconsola.CodigoDescuento,
                        productoVideoconsola.Stock, productoVideoconsola.Color,
                        productoVideoconsola.Procesador, productoVideoconsola.SO, productoVideoconsola.Modelo,
                        productoVideoconsola.FechaLanzamiento);
                    GestionComercio.AgregarProductoAlmacen(nuevoVideoConsola);
                    Mensaje.PulsaTeclaSalir();

                    break;

                case 3:
                    Tecnologia productoTecnologiaMovil = DatosProducto.RecogerDatosTecnologia(vendedorSesion);
                    Console.WriteLine("Movil o tablet:");

                    Console.Write("Bateria:");
                    int.TryParse(Console.ReadLine(), out var bateria);

                    Console.Write("Pantalla:");
                    float.TryParse(Console.ReadLine(), out var pantalla);

                    var nuevoMovil = new Movil(null, productoTecnologiaMovil.Nombre, productoTecnologiaMovil.Marca,
                        productoTecnologiaMovil.Precio, productoTecnologiaMovil.Vendedor,
                        productoTecnologiaMovil.Descripcion, productoTecnologiaMovil.FechaPuestaVenta,
                        productoTecnologiaMovil.CodigoDescuento, productoTecnologiaMovil.Stock,
                        productoTecnologiaMovil.Color, productoTecnologiaMovil.Procesador, productoTecnologiaMovil.SO,
                        productoTecnologiaMovil.Modelo, productoTecnologiaMovil.FechaLanzamiento, pantalla,
                        bateria);

                    GestionComercio.AgregarProductoAlmacen(nuevoMovil);

                    Mensaje.PulsaTeclaSalir();

                    break;
                case 4:
                    Mensaje.SalirMenu("Volviendo al menu principal de vendendor");
                    salirMenu = true;
                    break;

            }
        }

        private void MostrarMenuModa()
        {
            Console.Clear();
            Console.WriteLine("Elija el tipo del producto de Tecnologia:\n" +
                              "1  Ropa\n" +
                              "2  Calzado\n" +
                              "3  Bolso\n" +
                              "4  Joyeria\n" +
                              "5  Volver al menu vendedor\n");
        }

        private void EjecutarOpcionMenuModa(int opcion)
        {
            
            switch (opcion)
            {

                case 1:
                    Moda productoModa = DatosProducto.RecogerDatosModa(vendedorSesion);
                    Console.WriteLine("Ropa:");

                    Console.Write("Tipo:");
                    var tipoRopa = Console.ReadLine();

                    Console.Write("Talla:");
                    var tallaRopa = Console.ReadLine();


                    var nuevaRopa = new Ropa(null, productoModa.Nombre, productoModa.Marca,
                        productoModa.Precio, productoModa.Vendedor, productoModa.Descripcion,
                        productoModa.FechaPuestaVenta, productoModa.CodigoDescuento,
                        productoModa.Stock, productoModa.Color, productoModa.Material,
                        productoModa.Sexo, tallaRopa, tipoRopa);
                    GestionComercio.AgregarProductoAlmacen(nuevaRopa);

                    Mensaje.PulsaTeclaSalir();

                    break;

                case 2:
                    Moda productoModaCalzado = DatosProducto.RecogerDatosModa(vendedorSesion);
                    Console.WriteLine("Calzado:");

                    Console.Write("Tipo:");
                    var tipoCalzado = Console.ReadLine();

                    Console.Write("Talla:");
                    int.TryParse(Console.ReadLine(), out var tallaCalzado);

                    var nuevoCalzado = new Calzado(null, productoModaCalzado.Nombre, productoModaCalzado.Marca,
                        productoModaCalzado.Precio, productoModaCalzado.Vendedor, productoModaCalzado.Descripcion,
                        productoModaCalzado.FechaPuestaVenta, productoModaCalzado.CodigoDescuento,
                        productoModaCalzado.Stock, productoModaCalzado.Color, productoModaCalzado.Material,
                        productoModaCalzado.Sexo, tallaCalzado, tipoCalzado);
                    GestionComercio.AgregarProductoAlmacen(nuevoCalzado);
                    Mensaje.PulsaTeclaSalir();

                    break;

                case 3:
                    Moda productoModaBolso = DatosProducto.RecogerDatosModa(vendedorSesion);
                    Console.WriteLine("Bolso:");

                    Console.Write("Tipo:");
                    var tipoBolso = Console.ReadLine();

                    var nuevoBolso = new Bolso(null, productoModaBolso.Nombre, productoModaBolso.Marca,
                        productoModaBolso.Precio, productoModaBolso.Vendedor, productoModaBolso.Descripcion,
                        productoModaBolso.FechaPuestaVenta, productoModaBolso.CodigoDescuento,
                        productoModaBolso.Stock, productoModaBolso.Color, productoModaBolso.Material,
                        productoModaBolso.Sexo, tipoBolso);
                    GestionComercio.AgregarProductoAlmacen(nuevoBolso);

                    Mensaje.PulsaTeclaSalir();

                    break;

                case 4:
                    Moda productoModaJoyeria = DatosProducto.RecogerDatosModa(vendedorSesion);
                    Console.WriteLine("Joyeria:");

                    Console.Write("Medida:");
                    var medidaJoya = Console.ReadLine();

                    var nuevaJoya = new Joyeria(null, productoModaJoyeria.Nombre, productoModaJoyeria.Marca,
                        productoModaJoyeria.Precio, productoModaJoyeria.Vendedor, productoModaJoyeria.Descripcion,
                        productoModaJoyeria.FechaPuestaVenta, productoModaJoyeria.CodigoDescuento,
                        productoModaJoyeria.Stock, productoModaJoyeria.Color, productoModaJoyeria.Material,
                        productoModaJoyeria.Sexo, medidaJoya);
                    GestionComercio.AgregarProductoAlmacen(nuevaJoya);

                    Mensaje.PulsaTeclaSalir();

                    break;
                case 5:
                    Mensaje.SalirMenu("Volviendo al menu principal de vendendor");
                    salirMenu = true;
                    break;

            }
        }

        private void MostrarMenuMultimedia()
        {
            Console.Clear();
            Console.WriteLine("Elija el tipo del producto de Multimedia:\n" +
                              "1  Música\n" +
                              "2  Pelicula o Series\n" +
                              "3  VideoJuegos\n" +
                              "4  Volver al menu vendedor\n");
        }

        private void EjecutarOpcionMenMultimedia(int opcion)
        {
            
            switch (opcion)
            {

                case 1:
                    Multimedia productoMultimediaMusica = DatosProducto.RecogerDatosMultimedia(vendedorSesion);
                    Console.WriteLine("Musica:");

                    Console.Write("Artista:");
                    var artista = Console.ReadLine();


                    var nuevaMusica = new Musica(null, productoMultimediaMusica.Nombre, productoMultimediaMusica.Marca,
                        productoMultimediaMusica.Precio, productoMultimediaMusica.Vendedor,
                        productoMultimediaMusica.Descripcion,
                        productoMultimediaMusica.FechaPuestaVenta, productoMultimediaMusica.CodigoDescuento,
                        productoMultimediaMusica.Stock, productoMultimediaMusica.Genero, productoMultimediaMusica.Formato,
                        productoMultimediaMusica.Idioma,
                        productoMultimediaMusica.FechaLanzamiento, artista);
                    GestionComercio.AgregarProductoAlmacen(nuevaMusica);

                    Console.ReadKey();

                    Mensaje.PulsaTeclaSalir();

                    break;

                case 2:
                    Multimedia productoMultimediaPelicula = DatosProducto.RecogerDatosMultimedia(vendedorSesion);
                    Console.WriteLine("Pelicula y Series:");

                    Console.Write("Actores:");
                    var actores = Console.ReadLine();

                    Console.Write("Director:");
                    var director = Console.ReadLine();

                    Console.Write("Edad Recomendada:");
                    int.TryParse(Console.ReadLine(), out var edadRecomendadaPelicula);

                    Console.Write("Sinopsis:");
                    var sinapsis = Console.ReadLine();

                    var nuevaPelicula = new Pelicula(null, productoMultimediaPelicula.Nombre,
                        productoMultimediaPelicula.Marca,
                        productoMultimediaPelicula.Precio, productoMultimediaPelicula.Vendedor,
                        productoMultimediaPelicula.Descripcion,
                        productoMultimediaPelicula.FechaPuestaVenta, productoMultimediaPelicula.CodigoDescuento,
                        productoMultimediaPelicula.Stock, productoMultimediaPelicula.Genero, productoMultimediaPelicula.Formato,
                        productoMultimediaPelicula.Idioma,
                        productoMultimediaPelicula.FechaLanzamiento, actores, director, edadRecomendadaPelicula,
                        sinapsis);
                    GestionComercio.AgregarProductoAlmacen(nuevaPelicula);
                    Mensaje.PulsaTeclaSalir();

                    break;

                case 3:
                    Multimedia productoMultimediaVideojuego = DatosProducto.RecogerDatosMultimedia(vendedorSesion);
                    Console.WriteLine("VideoJuegos:");

                    Console.Write("Edad Recomendada:");
                    int.TryParse(Console.ReadLine(), out var edadRecomendadaVideoJuego);

                    Console.Write("Plataforma:");
                    var plataforma = Console.ReadLine();

                    var nuevoVideoJuego = new VideoJuego(null, productoMultimediaVideojuego.Nombre,
                        productoMultimediaVideojuego.Marca,
                        productoMultimediaVideojuego.Precio, productoMultimediaVideojuego.Vendedor,
                        productoMultimediaVideojuego.Descripcion,
                        productoMultimediaVideojuego.FechaPuestaVenta, productoMultimediaVideojuego.CodigoDescuento,
                        productoMultimediaVideojuego.Stock, productoMultimediaVideojuego.Genero, productoMultimediaVideojuego.Formato,
                        productoMultimediaVideojuego.Idioma,
                        productoMultimediaVideojuego.FechaLanzamiento, plataforma, edadRecomendadaVideoJuego);
                    GestionComercio.AgregarProductoAlmacen(nuevoVideoJuego);

                    Mensaje.PulsaTeclaSalir();

                    break;

                case 4:


                    Mensaje.SalirMenu("Volviendo al menu principal de vendendor");
                    salirMenu = true;

                    break;

            }
        }

        private int RecogerOpcionMenu()
        {

            Console.WriteLine("Introduza una opción: ");
            var opcionMenuisInt = int.TryParse(Console.ReadLine(), out var opcionMenu);
            if (opcionMenuisInt)
            {
                return opcionMenu;
            }

            return 0;
        }
    }
}