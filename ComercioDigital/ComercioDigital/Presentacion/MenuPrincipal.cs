using System;
using ComercioDigital.DTOs.Personas;
using ComercioDigital.Servicio;

namespace ComercioDigital.Presentacion
{
    public class MenuPrincipal

    {
        private GestionUsuarios gestionUsuarios = new GestionUsuarios();
        private GestionVendedores gestionVendedores = new GestionVendedores();
        private GestionComercio GestionComercio = new GestionComercio();

        private Usuario UsuarioSesion;
        private Vendedor VendedorSesion;

        private MenuVendedor menuVendedor = new MenuVendedor();
        private MenuUsuario menuUsuario = new MenuUsuario();


        public void EjecutarApp()
        {
            int opcionTemporal=-1;

            do
            {
            MostrarMenuPrincipal();
            opcionTemporal = ElegirOpcionPrincipal();
            EjecutarOpcionPrincipal(opcionTemporal);
            }while(opcionTemporal!=5);

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

                    foreach (Usuario usuario in gestionUsuarios.Usuarios)
                    {
                        if (usuario.Nombre.Equals(nombreUsuarioIngreso) &&
                            usuario.Password.Equals(contrasennaUsuarioIngreso))
                        {
                            UsuarioSesion = usuario;
                        }
                    }

                    if (UsuarioSesion != null)
                    {
                        menuUsuario.EjecutarMenuUsuario(UsuarioSesion, GestionComercio, gestionUsuarios);
                    }
                    else
                    {
                        Console.WriteLine("Inicio de sesion incorrecto.");
                    }


                    break;

                case 2:

                     Console.WriteLine("Ingreso de vendedores");

                    Console.Write("Nombre de Vendedor:");
                    string nombreVendedorIngreso = Console.ReadLine();

                    Console.Write("Contraseña:");
                    string contrasennaVendedorIngreso = Console.ReadLine();

                    foreach (Vendedor vendedor in gestionVendedores.Vendedores)
                    {
                        if (vendedor.Nombre.Equals(nombreVendedorIngreso) &&
                            vendedor.Contrasenna.Equals(contrasennaVendedorIngreso)
                        {
                            VendedorSesion = vendedor;
                        }
                    }

                    if (VendedorSesion != null)
                    {
                       menuVendedor.EjecutarMenuVendedor(vendedorSesion,GestionComercio,gestionVendedores);
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

                    foreach (Usuario usuario in gestionUsuarios.Usuarios)
                    {
                        if (usuario.Nombre.Equals(nombreUsuarioRegistro))
                        {
                            UsuarioSesion = usuario;
                        }
                    }

                    gestionUsuarios.InsertarUsuario(new Usuario( nombreUsuarioRegistro, direccionUSuarioRegistro,contrasennaUsuarioRegistro));

                    break;

                case 4:

                    Console.WriteLine("Registro de nuevo Vendedor");

                    Console.Write("Nombre:");
                    string nombreVendedor = Console.ReadLine();

                    Console.Write("Direccion:");
                    string direccionVendedor = Console.ReadLine();


                    Console.Write("Contraseña:");
                    string contrasennaVendedor = Console.ReadLine();


                    gestionVendedores.InsertarVendedor(new Vendedor(nombreVendedor, direccionVendedor,contrasennaVendedor));

                    break;

                case 5:

                    Console.WriteLine("Gracias por usar nuestra tienda online. Vuelva pronto.");

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
            int opcionPrincipal = -1;
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
