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
    public class MenuVendedor
    {

        public void EjecutarMenuVendedor(Vendedor vendedorSesion,GestionComercio gestionComercio,GestionVendedores gestionVendedores)
        {
            
            int opcionTemp=-1;
            do{
                MostrarMenuVendedor(vendedorSesion);
                opcionTemp = ElegirOpcionVendedor();
                EjecutarOpcionVendedor(opcionTemp,vendedorSesion,gestionComercio,gestionVendedores);
            }while(opcionTemp < 4);

            Console.WriteLine("Se cerro la sesion del vendedor");

            Console.ReadKey();
        }


        public void EjecutarOpcionVendedor(int opcion, Vendedor vendedorSesion, GestionComercio gestionComercio, GestionVendedores gestionVendedores)
        {

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Agregar producto");
                    InfoProducto infoproducto;
                    DateTime fechaAlta = DateTime.Today;


                    Console.WriteLine("Elija el tipo del producto:\n " +
                        "1-Tecnología\n" +
                        "2-Moda\n" +
                        "3-Multimedia\n");


                    bool opcionAgregarProductoIsInt = int.TryParse(Console.ReadLine(), out int opcionAgregarProducto);
                    if (opcionAgregarProductoIsInt)
                    {
                        switch (opcionAgregarProducto)
                        {
                            case 1:

                                Tecnologia productoTecnologia;
                                Console.WriteLine("Elija el tipo del producto de Tecnologia:\n " +
                                                  "1-Ordenador\n" +
                                                  "2-Videoconsola\n" +
                                                  "3-Tablet o smartphone\n");

                                bool opcionTecnologiaIsInt = int.TryParse(Console.ReadLine(), out int opcionTecnologia);

                                if (opcionTecnologiaIsInt)
                                {
                                    infoproducto = RecogerDatosGenericos(vendedorSesion);
                                    productoTecnologia = RecogerDatosTecnologia(infoproducto);
                                    switch (opcionTecnologia)
                                    {
                                        case 1:
                                            Console.WriteLine("Ordenador:");
                                            
                                            Console.Write("Placa Base:");
                                            string placaBase = Console.ReadLine();

                                            Console.Write("Tipo de ordenador(Portatil,sobremesa,surface...):");
                                            string tipoOrdenador = Console.ReadLine();

                                            Ordenador nuevoOrdenador = new Ordenador(productoTecnologia.Nombre, productoTecnologia.Marca, productoTecnologia.Precio, productoTecnologia.Vendedor, productoTecnologia.Descripcion,productoTecnologia.FechaPuestaVenta,productoTecnologia.CodigoDescuento,productoTecnologia.Stock,productoTecnologia.Color,productoTecnologia.Procesador,productoTecnologia.SO,productoTecnologia.Modelo,productoTecnologia.FechaLanzamiento,placaBase,tipoOrdenador);
                                            gestionComercio.AgregarProductoAlmacen(nuevoOrdenador);

                                            Console.ReadKey();
                                            break;

                                        case 2:
                                            Console.WriteLine("Videoconsola:");

                                            VideoConsola nuevoVideoConsola = new VideoConsola(productoTecnologia.Nombre, productoTecnologia.Marca, productoTecnologia.Precio, productoTecnologia.Vendedor, productoTecnologia.Descripcion,productoTecnologia.FechaPuestaVenta,productoTecnologia.CodigoDescuento,productoTecnologia.Stock,productoTecnologia.Color,productoTecnologia.Procesador,productoTecnologia.SO,productoTecnologia.Modelo,productoTecnologia.FechaLanzamiento);
                                            gestionComercio.AgregarProductoAlmacen(nuevoVideoConsola);
                                            break;

                                        case 3:
                                            Console.WriteLine("Movil o tablet:");

                                            Console.Write("Bateria:");
                                            int.TryParse(Console.ReadLine(), out int bateria);

                                            Console.Write("Pantalla:");
                                            float.TryParse(Console.ReadLine(), out float pantalla);

                                            Movil nuevoMovil = new Movil(productoTecnologia.Nombre, productoTecnologia.Marca, productoTecnologia.Precio, productoTecnologia.Vendedor, productoTecnologia.Descripcion, productoTecnologia.FechaPuestaVenta, productoTecnologia.CodigoDescuento, productoTecnologia.Stock, productoTecnologia.Color, productoTecnologia.Procesador, productoTecnologia.SO, productoTecnologia.Modelo, productoTecnologia.FechaLanzamiento,pantalla,bateria);

                                            gestionComercio.AgregarProductoAlmacen(nuevoMovil);
                                            Console.ReadKey();
                                            break;
                                    }
                                    
                                }
                     
                                break;

                            case 2:

                                Moda productoModa;
                                Console.WriteLine("Elija el tipo del producto de Tecnologia:\n " +
                                                  "1-Ropa\n" +
                                                  "2-Calzado\n" +
                                                  "3-Bolso\n" +
                                                  "4-Joyeria\n");
                                bool opcionModaIsInt = int.TryParse(Console.ReadLine(), out int opcionModa);
                                if (opcionModaIsInt)
                                {
                                    infoproducto = RecogerDatosGenericos(vendedorSesion);
                                    productoModa = RecogerDatosModa(infoproducto);
                                    switch (opcionModa)
                                    {
                                        case 1:
                                            Console.WriteLine("Ropa:");
                                            
                                            Console.Write("Tipo:");
                                            string tipoRopa = Console.ReadLine();

                                            Console.Write("Talla:");
                                            string tallaRopa = Console.ReadLine();


                                            Ropa nuevaRopa = new Ropa(productoModa.Nombre, productoModa.Marca,
                                                productoModa.Precio, productoModa.Vendedor, productoModa.Descripcion,
                                                productoModa.FechaPuestaVenta, productoModa.CodigoDescuento,
                                                productoModa.Stock, productoModa.Color,productoModa.Material,productoModa.Sexo,tallaRopa,tipoRopa);
                                            gestionComercio.AgregarProductoAlmacen(nuevaRopa);

                                            Console.ReadKey();
                                            break;

                                        case 2:
                                            Console.WriteLine("Calzado:");

                                            Console.Write("Tipo:");
                                            string tipoCalzado = Console.ReadLine();

                                            Console.Write("Talla:");
                                            int.TryParse(Console.ReadLine(),out int tallaCalzado);

                                            Calzado nuevoCalzado = new Calzado(productoModa.Nombre, productoModa.Marca,
                                                productoModa.Precio, productoModa.Vendedor, productoModa.Descripcion,
                                                productoModa.FechaPuestaVenta, productoModa.CodigoDescuento,
                                                productoModa.Stock, productoModa.Color, productoModa.Material, productoModa.Sexo,tallaCalzado,tipoCalzado);
                                            gestionComercio.AgregarProductoAlmacen(nuevoCalzado);

                                            Console.ReadKey();
                                            break;

                                        case 3:
                                            Console.WriteLine("Bolso:");

                                            Console.Write("Tipo:");
                                            string tipoBolso = Console.ReadLine();

                                            Bolso nuevoBolso = new Bolso(productoModa.Nombre, productoModa.Marca,
                                                productoModa.Precio, productoModa.Vendedor, productoModa.Descripcion,
                                                productoModa.FechaPuestaVenta, productoModa.CodigoDescuento,
                                                productoModa.Stock, productoModa.Color, productoModa.Material, productoModa.Sexo, tipoBolso);
                                            gestionComercio.AgregarProductoAlmacen(nuevoBolso);

                                            Console.ReadKey();
                                            break;
                                        case 4:
                                            Console.WriteLine("Joyeria:");

                                            Console.Write("Medida:");
                                            string medidaJoya = Console.ReadLine();

                                            Joyeria nuevaJoya = new Joyeria(productoModa.Nombre, productoModa.Marca,
                                                productoModa.Precio, productoModa.Vendedor, productoModa.Descripcion,
                                                productoModa.FechaPuestaVenta, productoModa.CodigoDescuento,
                                                productoModa.Stock, productoModa.Color, productoModa.Material, productoModa.Sexo, medidaJoya);
                                            gestionComercio.AgregarProductoAlmacen(nuevaJoya);

                                            Console.ReadKey();
                                            break;
                                    }
                                    
                                }


                                break;

                            case 3:

                                Multimedia productoMultimedia;
                                Console.WriteLine("Elija el tipo del producto de Tecnologia:\n " +
                                                  "1-Música\n" +
                                                  "2-Pelicula o Series\n" +
                                                  "3-VideoJuegos\n");
                                                  
                                bool opcionMultimediaIsInt = int.TryParse(Console.ReadLine(), out int opcionMultimedia);
                                if (opcionMultimediaIsInt)
                                {
                                    infoproducto = RecogerDatosGenericos(vendedorSesion);
                                    productoMultimedia = RecogerDatosMultimedia(infoproducto);
                                    switch (opcionMultimedia)
                                    {
                                        case 1:
                                            Console.WriteLine("Musica:");

                                            Console.Write("Tipo:");
                                            string artista = Console.ReadLine();


                                            Musica nuevaMusica = new Musica(productoMultimedia.Nombre, productoMultimedia.Marca,
                                                productoMultimedia.Precio, productoMultimedia.Vendedor, productoMultimedia.Descripcion,
                                                productoMultimedia.FechaPuestaVenta, productoMultimedia.CodigoDescuento,
                                                productoMultimedia.Stock,productoMultimedia.Genero,productoMultimedia.Formato,productoMultimedia.Idioma,
                                                productoMultimedia.FechaLanzamiento,artista);
                                                gestionComercio.AgregarProductoAlmacen(nuevaMusica);

                                            Console.ReadKey();
                                            break;

                                        case 2:
                                            Console.WriteLine("Pelicula y Series:");

                                        //public string Actores { get; set; }
                                        //public string Director { get; set; }
                                        //public int EdadRecomendad { get; set; }
                                        //public string Sinopsis { get; set; }

                                            Console.Write("Actores:");
                                            string actores = Console.ReadLine();

                                            Console.Write("Director:");
                                            string director = Console.ReadLine();

                                            Console.Write("Edad Recomendada:");
                                            int.TryParse(Console.ReadLine(), out int edadRecomendadaPelicula);

                                            Console.Write("Sinopsis:");
                                            string sinapsis= Console.ReadLine();

                                            Pelicula nuevaPelicula = new Pelicula(productoMultimedia.Nombre, productoMultimedia.Marca,
                                                productoMultimedia.Precio, productoMultimedia.Vendedor, productoMultimedia.Descripcion,
                                                productoMultimedia.FechaPuestaVenta, productoMultimedia.CodigoDescuento,
                                                productoMultimedia.Stock, productoMultimedia.Genero, productoMultimedia.Formato, productoMultimedia.Idioma,
                                                productoMultimedia.FechaLanzamiento, actores,director,edadRecomendadaPelicula,sinapsis);
                                            gestionComercio.AgregarProductoAlmacen(nuevaPelicula);

                                            Console.ReadKey();
                                            break;

                                        case 3:
                                            Console.WriteLine("VideoJuegos:");

                                            Console.Write("Edad Recomendada:");
                                            int.TryParse(Console.ReadLine(), out int edadRecomendadaVideoJuego);

                                            Console.Write("Plataforma:");
                                            string plataforma = Console.ReadLine();

                                            VideosJuego nuevoVideoJuego = new VideosJuego(productoMultimedia.Nombre, productoMultimedia.Marca,
                                                productoMultimedia.Precio, productoMultimedia.Vendedor, productoMultimedia.Descripcion,
                                                productoMultimedia.FechaPuestaVenta, productoMultimedia.CodigoDescuento,
                                                productoMultimedia.Stock, productoMultimedia.Genero, productoMultimedia.Formato, productoMultimedia.Idioma,
                                                productoMultimedia.FechaLanzamiento,plataforma,edadRecomendadaVideoJuego);
                                            gestionComercio.AgregarProductoAlmacen(nuevoVideoJuego);

                                            Console.ReadKey();
                                            break;
                                    }

                                }

                                break;
                        }
                    }
                    
                    break;

                case 2:

                    Console.WriteLine("Eliminar producto");

                    foreach (Producto producto in gestionComercio.FiltroProductoVendedor(vendedorSesion))
                    {
                        Console.WriteLine(producto);
                    }

                    Console.WriteLine("Elija el id del producto que queire eliminar");
                    bool opcionEliminarIsInt = int.TryParse(Console.ReadLine(), out int opcionEliminar);
                    if (opcionEliminarIsInt)
                    {
                        if (gestionComercio.EliminarProductoAlmacen(opcionEliminar))
                        {
                            Console.WriteLine("Producto Eliminado");
                        }
                        else
                        {
                            Console.WriteLine("Fallo al eliminar el producto");
                        }
                    }

                    Console.ReadKey();

                    break;

                case 3:
                    Console.WriteLine("Cambiar datos de vendedor");
                    Console.WriteLine("1-Nombre");
                    Console.WriteLine("2-Contraseña");
                    Console.Write("Elija una opcion:");
                    bool opcionDatosVendedorIsInt = int.TryParse(Console.ReadLine(), out int opcionDatosVendedor);
                    if (opcionDatosVendedorIsInt && opcionDatosVendedor > 0 && opcionDatosVendedor < 3)
                    {
                        switch (opcionDatosVendedor)
                        {
                            case 1:
                                Console.Write("Escriba el nuevo nombre:");
                                string nuevoNombre = Console.ReadLine();
                                gestionVendedores.ModificarVendedor(vendedorSesion, nuevoNombre, "nombre");

                                break;

                            case 2:
                                Console.Write("Escriba la nueva contraseña:");
                                string nuevaPass = Console.ReadLine();
                                gestionVendedores.ModificarVendedor(vendedorSesion, nuevaPass, "contraseña");

                                break;
                        }
                    }

                    Console.ReadKey();
                    break;

                case 4:
                    Console.WriteLine("Eliminar vendedor:");
                    Console.WriteLine("Escriba su nombre de vendedor si está de acuerdo en eliminar su cuenta");
                    string confirmacionEliminacion = Console.ReadLine();

                    if (vendedorSesion.Nombre.Equals(confirmacionEliminacion))
                    {
                        if (gestionVendedores.EliminarVendedor(vendedorSesion))
                        {
                            Console.WriteLine("Vendedor Eliminado correctamente");
                        }
                        else
                        {
                            Console.WriteLine("Error en la eliminacion del vendedor");
                        }
                        ;
                    }
                    else
                    {
                        Console.WriteLine("No he escrito correctamente su nombre. Su cuenta no se ha elimnado");
                    }

                    Console.ReadKey();

                    break;

                case 5:

                    Console.WriteLine("Saliendo de la sesion de vendedor...");
                    Thread.Sleep(4000);

                    break;
            }
        }

        public void MostrarMenuVendedor(Vendedor vendedor)
        {

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("1-Añadir Producto");
            Console.WriteLine("2-Retirar productos");
            Console.WriteLine("3-Cambiar datos de vendedor");
            Console.WriteLine("4-Eliminar cuenta");
            Console.WriteLine("5-Cerrar Sesion");
        }

        public int ElegirOpcionVendedor()
        {
            bool opcionCorrecta = false;
            int opcionVendedor = -1;
            do
            {
                bool opcionVendedorIsINt = int.TryParse(Console.ReadLine(), out opcionVendedor);

                if (opcionVendedorIsINt && opcionVendedor <= 5 && opcionVendedor >= 1)
                {
                    opcionCorrecta = true;
                }
                else
                {
                    Console.WriteLine("No has elegido una opción correcta");
                }
            } while (!opcionCorrecta);

            return opcionVendedor;

        }

        private InfoProducto RecogerDatosGenericos(Vendedor vendedorSesion)
        {
            Console.Write("Nombre del producto: ");
            string nombreProducto = Console.ReadLine();

            Console.Write("Marca del producto: ");
            string marcaProducto = Console.ReadLine();

            Console.Write("Precio del producto: ");
            float.TryParse(Console.ReadLine(), out float precioProducto);

            Console.Write("Descripcion del producto: ");
            string descripcionProducto = Console.ReadLine();

            Console.Write("Código de descuento: ");
            string codigoDescuentoProducto = Console.ReadLine();

            Console.Write("Stock: ");
            int.TryParse( Console.ReadLine(),out int stock);

            InfoProducto infoProductoGenerico = new InfoProducto(nombreProducto, marcaProducto, precioProducto, descripcionProducto, codigoDescuentoProducto, stock,vendedorSesion);


            return infoProductoGenerico;
        }

        private Tecnologia RecogerDatosTecnologia(InfoProducto infoProducto)
        {
            Console.Write("Color del producto: ");
            string color = Console.ReadLine();

            Console.Write("Procesador del producto: ");
            string procesador = Console.ReadLine();

            Console.Write("Sistema operativo del producto: ");
            string sistemaOperativo = Console.ReadLine();

            
            Console.Write("Modelo del producto");
            string modelo = Console.ReadLine();

            Console.WriteLine("Fecha de lanzamaiento del producto");
            Console.Write("Año: ");
            int.TryParse(Console.ReadLine(),out int year);
            Console.Write("Mes: ");
            int.TryParse(Console.ReadLine(), out int mes);
            Console.Write("Dia: ");
            int.TryParse(Console.ReadLine(), out int dia);
            DateTime fechaLanzamiento = new DateTime(year, mes,dia);

            Tecnologia productoTecnologiaGenerico = new Tecnologia(infoProducto.Nombre, infoProducto.Marca, infoProducto.Precio, infoProducto.Vendedor,infoProducto.Descripcion,DateTime.Today,infoProducto.CodigoDescuento,infoProducto.Stock,color,procesador,sistemaOperativo,modelo,fechaLanzamiento);

            return productoTecnologiaGenerico;
        }

        private Moda RecogerDatosModa(InfoProducto infoProducto)
        {
            Console.Write("Color del producto: ");
            string color = Console.ReadLine();

            Console.Write("Material del producto: ");
            string material = Console.ReadLine();

            int opcionSexo;
            string sexo;
            Console.WriteLine("Sexo:");
            Console.WriteLine("Selecione: 1-Masculino\n2-Femenino");
            int.TryParse(Console.ReadLine(), out opcionSexo);
            if (opcionSexo == 1)
            {
                sexo = "H";
            }else if (opcionSexo == 2)
            {
                sexo = "M";
            }
            else
            {
                sexo = "U";
            }


            Moda productoNuevoModa = new Moda(infoProducto.Nombre, infoProducto.Marca, infoProducto.Precio, infoProducto.Vendedor, infoProducto.Descripcion, DateTime.Today, infoProducto.CodigoDescuento, infoProducto.Stock,color,material,sexo);
            return productoNuevoModa;
        }

        private Multimedia RecogerDatosMultimedia(InfoProducto infoProducto)
        {
            Multimedia productoMultimedia;

            Console.Write("Genero del producto: ");
            string genero = Console.ReadLine();
            Console.Write("Formato del producto: ");
            string formato = Console.ReadLine();
            Console.Write("Idioma del producto: ");
            string idioma = Console.ReadLine();

            Console.WriteLine("Fecha de lanzamiento del producto");
            Console.Write("Año: ");
            int.TryParse(Console.ReadLine(), out int year);
            Console.Write("Mes: ");
            int.TryParse(Console.ReadLine(), out int mes);
            Console.Write("Dia: ");
            int.TryParse(Console.ReadLine(), out int dia);
            DateTime fechaLanzamiento = new DateTime(year, mes, dia);

            productoMultimedia = new Multimedia(infoProducto.Nombre, infoProducto.Marca, infoProducto.Precio,
                infoProducto.Vendedor, infoProducto.Descripcion,
                DateTime.Today, infoProducto.CodigoDescuento, infoProducto.Stock, genero, formato, idioma,
                fechaLanzamiento);
            
            return productoMultimedia;
        }
    }
}
