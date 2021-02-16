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
using ComercioDigital.Servicio.DB;
using ComercioDigital.Utiles;

namespace ComercioDigital.Presentacion
{
    public class MenuVendedor
    {

        public void EjecutarMenuVendedor(Vendedor vendedorSesion)
        {
            
            int opcionTemp=-1;
            do{
                MostrarMenuVendedor(vendedorSesion);
                opcionTemp = ElegirOpcionVendedor();
                EjecutarOpcionVendedor(opcionTemp,vendedorSesion);
            }while(opcionTemp < 4);

            Console.WriteLine("Se cerro la sesion del vendedor");

            Console.ReadKey();
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


        public void EjecutarOpcionVendedor(int opcion, Vendedor vendedorSesion)
        {

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Agregar producto");
                    SubMenuVendedorProducto subMenuVendedorProducto = new SubMenuVendedorProducto(vendedorSesion);
                    subMenuVendedorProducto.EjecutarMenu();

                   
                    break;

                case 2:

                    Console.WriteLine("Eliminar producto");

                    foreach (Producto producto in GestionComercio.FiltroProductoVendedor(vendedorSesion))
                    {
                        Console.WriteLine(producto);
                    }

                    Console.WriteLine("Elija el id del producto que queire eliminar");
                    bool opcionEliminarIsInt = int.TryParse(Console.ReadLine(), out int opcionEliminar);
                    if (opcionEliminarIsInt)
                    {

                            if (GestionComercio.EliminarProductoAlmacen(opcionEliminar))
                            {
                                Console.WriteLine("Producto Eliminado");
                            }
                            else
                            {
                                Console.WriteLine("Fallo al eliminar el producto");
                            }
                    }

                    Mensaje.PulsaTeclaSalir();

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
                                vendedorSesion.Nombre = nuevoNombre;
                                DBVendedores.ModificarVendedor(vendedorSesion);

                                break;

                            case 2:
                                Console.Write("Escriba la nueva contraseña:");
                                string nuevaPass = Console.ReadLine();
                                vendedorSesion.Contrasenna = nuevaPass;
                                DBVendedores.ModificarVendedor(vendedorSesion);

                                break;
                        }
                    }
                    


                    Mensaje.PulsaTeclaSalir();
                    break;

                case 4:
                    Console.WriteLine("Eliminar vendedor:");
                    Console.WriteLine("Escriba su nombre de vendedor si está de acuerdo en eliminar su cuenta");
                    string confirmacionEliminacion = Console.ReadLine();

                    if (vendedorSesion.Nombre.Equals(confirmacionEliminacion))
                    {
                        if (GestionVendedores.EliminarVendedor(vendedorSesion))
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

                    Mensaje.PulsaTeclaSalir();

                    break;

                case 5:

                    Console.WriteLine("Saliendo de la sesion de vendedor...");
                    Thread.Sleep(4000);

                    break;
            }
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

    }
}
