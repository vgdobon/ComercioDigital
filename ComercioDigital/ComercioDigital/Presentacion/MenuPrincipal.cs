using System;
using System.Threading;
using ComercioDigital.DTOs.Personas;
using ComercioDigital.DTOs.Productos.Moda;
using ComercioDigital.DTOs.Productos.Multimedia;
using ComercioDigital.DTOs.Productos.Tecnologia;
using ComercioDigital.Servicio;
using ComercioDigital.Servicio.DB;
using ComercioDigital.Utiles;

namespace ComercioDigital.Presentacion
{
    public class MenuPrincipal

    {
        private Usuario UsuarioSesion;
        private Vendedor VendedorSesion;

        private MenuVendedor menuVendedor = new MenuVendedor();
        private MenuUsuario menuUsuario = new MenuUsuario();


        public void EjecutarApp()
        {

            IniciarApp();
            int opcionTemporal=-1;

            do
            {
                MostrarMenuPrincipal();
                opcionTemporal = ElegirOpcionPrincipal();
                EjecutarOpcionPrincipal(opcionTemporal);
            }while(opcionTemporal!=5);

        }

        private void IniciarApp()
        {
            //Vendedor vendedorInterno = new Vendedor("comercio", "Calle VendedorPrincipal", "1111");
            //GestionVendedores.InsertarVendedor(vendedorInterno);

            //Usuario usuarioInterno = new Usuario("victor", "Calle Usuario", "1111");
            //GestionUsuarios.InsertarUsuario(usuarioInterno);

            //Ordenador ordenadorInicial = new Ordenador("Pc sobremesa HP", "HP", 500.99M, vendedorInterno,
            //    "Potente y silencioso ordenador de sobremesa", DateTime.Today, "DESCUENTO", 4, "Negro",
            //    "Intel® Core™ i7-10700F", "Windows", "OMEN 25L GT11-0011ns", new DateTime(2021, 5, 1),
            //    "HP Placa base PC Pro 3010 MT", "Sobremesa");
            //GestionComercio.AgregarProductoAlmacen(ordenadorInicial);

            //VideoConsola nuevoVideoConsola = new VideoConsola("PlayStation 5", "Sony", 699.99M, vendedorInterno,
            //    "Consola de videojuegos 2021", DateTime.Today, "PLAY5", 100, "Blanca",
            //    " AMD Zen 2 de 8 núcleos a 3.5 GHz", "PlayStation 5 system software", "Pro",
            //    new DateTime(2020, 11, 12));
            //GestionComercio.AgregarProductoAlmacen(nuevoVideoConsola);

            //Movil nuevoMovil = new Movil("Smartphone Samsung S21 Blanco", "Samsung", 1300M, vendedorInterno,
            //    "Nuevo smartphone Samsung el mas potente del mercado", DateTime.Today, "S21", 10, "Blanco",
            //    "Qualcomm SM8350 Snapdragon 888", "Android 11", "Ultra 5G", new DateTime(2021, 1, 14), 6.2f, 4000);
            //GestionComercio.AgregarProductoAlmacen(nuevoMovil);


            //Ropa nuevaRopa = new Ropa("Pantalon vaquero", "productoModa.Marca", 25.50M, vendedorInterno,
            //    "Pantalón vaquero corte clásico", DateTime.Today, "VAQUEROCLASICO", 10, "Azul", "Vaquero", "H", "M",
            //    "Pantalon vaquero");
            //GestionComercio.AgregarProductoAlmacen(nuevaRopa);

            //Calzado nuevoCalzado = new Calzado("Bota alta", "GUESS", 50.50M, vendedorInterno, "Bota alta de vestir",
            //    DateTime.Today, "BOTAGUESS", 5, "Negro", "Cuero", "M", 40, "Bota");
            //GestionComercio.AgregarProductoAlmacen(nuevoCalzado);

            //Bolso nuevoBolso = new Bolso("Bolso de fiesta", "Dolce & Gabanna", 900.50M, vendedorInterno,
            //    "Bolso de fiesta pequeño",
            //    DateTime.Today, "BOLSOD&G", 10, "Leopardo", "Piel", "M", "Bolso");
            //GestionComercio.AgregarProductoAlmacen(nuevoBolso);

            //Joyeria nuevaJoya = new Joyeria("Anillo compromiso", "Gucci", 800M, vendedorInterno,
            //    "Anilllo de compromiso de alta calidad", DateTime.Today, "ANILLO", 2, "Plata", "Oro Blanco", "H", "18");
            //GestionComercio.AgregarProductoAlmacen(nuevaJoya);


            //Musica nuevaMusica = new Musica("Album Vértigo Pablo Alboran", "Pablo Alboran", 11.93M, vendedorInterno,
            //    "Ultimo albúm de Pablo Alboran 2021", DateTime.Today, "PABLOALBORAN", 10, "Latina", "MP3", "Español",
            //    new DateTime(2020, 9, 5), "Pabl Alboran");
            //GestionComercio.AgregarProductoAlmacen(nuevaMusica);

            //Pelicula nuevaPelicula = new Pelicula("Fast and Furious 9", "Universal Studios", 9M, vendedorInterno,
            //    "Pelicula de acción y conduccion peligrosa", DateTime.Today, "F&F9", 1000, "Accion", "Blu-Ray",
            //    "Español", new DateTime(2021, 4, 2),
            //    "Vin Diesel,Michelle Rodriguez,Charlize Theron,Jordana Brewster,Tyrese Gibson,Chris Ludacris Bridges,Nathalie Emmanuel,John Cena,Sung Kang,Lucas Black,Helen Mirren,Don Omar",
            //    "Justin Lin", 19,
            //    "Instalados en su vida familiar, Dom (Vin Diesel) y Letty (Michelle Rodriguez) viven en el campo con Brian, el hijo de Dom. Pero los problemas siguen tocando la puerta a la familia: Jakob (John Cena), el hermano menor de Dom, se ha unido con Cipher (Charlize Theron) para causar estragos y cumplir un deseo de venganza por parte de Cipher tras de los sucesos de The Fate of the Furious. El equipo se reunirá una vez más para mantener a la familia unida y deshacerse de los problemas de una vez por todas.");
            //GestionComercio.AgregarProductoAlmacen(nuevaPelicula);


            //VideosJuego nuevoVideoJuego = new VideosJuego("Call of Duty: Black Ops II", "Activision", 10.50M,
            //    vendedorInterno, "Juego de disparos en primera persona y modo Zombies", DateTime.Today, "BO2", 4,
            //    "Shooter", "DVD", "Español", new DateTime(2012, 8, 12), "PS3", 18);
            //GestionComercio.AgregarProductoAlmacen(nuevoVideoJuego);




        }

        public void EjecutarOpcionPrincipal(int opcion)
        {

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingreso de usuarios");

                    Console.Write("Nombre de usuario:");
                    string nombreUsuarioIngreso = Console.ReadLine();

                    Console.Write("Contraseña:");
                    string contrasennaUsuarioIngreso = Console.ReadLine();
                    UsuarioSesion = null;

                    if (GestionUsuarios.AutentificarUsuario(nombreUsuarioIngreso, contrasennaUsuarioIngreso))
                    {
                        UsuarioSesion = GestionUsuarios.UsuarioSesion(nombreUsuarioIngreso, contrasennaUsuarioIngreso);
                    }
                    

                    if (UsuarioSesion != null)
                    {
                        menuUsuario.EjecutarMenuUsuario(UsuarioSesion);
                    }
                    else
                    {
                        Console.WriteLine("Inicio de sesion incorrecto.");
                        Thread.Sleep(5000);
                    }


                    break;

                case 2:

                    Console.WriteLine("Ingreso de vendedores");

                    Console.Write("Nombre de Vendedor:");
                    string nombreVendedorIngreso = Console.ReadLine();

                    Console.Write("Contraseña:");
                    string contrasennaVendedorIngreso = Console.ReadLine();

                    VendedorSesion = null;

                    if (GestionVendedores.AutentificarVendedor(nombreVendedorIngreso, contrasennaVendedorIngreso))
                    {
                        VendedorSesion =
                            GestionVendedores.SesionVendedor(nombreVendedorIngreso, contrasennaVendedorIngreso);
                    }

                    if (VendedorSesion != null)
                    {
                       menuVendedor.EjecutarMenuVendedor(VendedorSesion);
                    }
                    else
                    {
                        Console.WriteLine("Inicio de sesion incorrecto.");
                    }

                    break;

                case 3:
                    Console.WriteLine("Registro de nuevo usuario");

                    Console.Write("Nombre de usuario:");
                    string nombreUsuarioRegistro = Console.ReadLine();

                    Console.Write("Direccion:");
                    string direccionUSuarioRegistro = Console.ReadLine();

                    Console.Write("Contraseña:");
                    string contrasennaUsuarioRegistro = Console.ReadLine();

                    foreach (Usuario usuario in GestionUsuarios.Usuarios)
                    {
                        if (usuario.Nombre.Equals(nombreUsuarioRegistro))
                        {
                            UsuarioSesion = usuario;
                        }
                    }

                    GestionUsuarios.InsertarUsuario(new Usuario( nombreUsuarioRegistro, direccionUSuarioRegistro,contrasennaUsuarioRegistro));

                    break;

                case 4:

                    Console.WriteLine("Registro de nuevo Vendedor");

                    Console.Write("Nombre:");
                    string nombreVendedor = Console.ReadLine();

                    Console.Write("Direccion:");
                    string direccionVendedor = Console.ReadLine();


                    Console.Write("Contraseña:");
                    string contrasennaVendedor = Console.ReadLine();


                    //GestionVendedores.InsertarVendedor();
                    DBVendedores.AnnadirVendedorDB(new Vendedor(nombreVendedor, direccionVendedor, contrasennaVendedor));
                    Console.WriteLine("Vendedor añadido correctamente");
                    Mensaje.SalirMenu("Volviendo al menu principal");


                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine();
                    Mensaje.SalirMenu("Gracias por usar nuestra tienda online. Vuelva pronto");

                    break;
            }
        }

        public void MostrarMenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("1-Ingresar como Usuario");
            Console.WriteLine("2-Ingresar como Vendedor");
            Console.WriteLine("3-Registrarse como Usuario");
            Console.WriteLine("4-Registrarse como Vendedor");
            Console.WriteLine("5-Salir");

            Console.Write("Opcion Menu Principal:");
        }

        public int ElegirOpcionPrincipal()
        {
            bool opcionCorrecta = false;
            int opcionPrincipal;
            do
            {
                
                bool opcionPrincipalIsINt = int.TryParse(Console.ReadLine(), out opcionPrincipal);

                if (opcionPrincipalIsINt && opcionPrincipal <= 5 && opcionPrincipal >= 1)
                {
                    opcionCorrecta = true;
                }
                else
                {
                    Console.WriteLine("No has elegido una opción correcta");
                }
            } while (!opcionCorrecta);

            return opcionPrincipal;

        }
    }
}
