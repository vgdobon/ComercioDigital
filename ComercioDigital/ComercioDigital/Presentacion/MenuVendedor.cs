using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComercioDigital.Servicio;

namespace ComercioDigital.Presentacion
{
    class MenuVendedor
    {

        public void EjecutarMenuVendedor(Vendedor vendedorSesion,GestionComercio gestionComercio,GestionVendedores gestionVendedores)
        {
            int opcionTemp=-1;
            do{
                MostrarMenuVendedor();
                opcionTemp = ElegirOpcionVendedor();
                EjecutarOpcionVendedor(opcionTemp,gestionComercio,gestionVendedores);
            }while(opcionTemp=!5);

            Console.WriteLine("Se cerro la sesion del vendedor");

            Console.ReadKey();
        }


        public void EjecutarOpcionVendedor(int opcion,GestionComercio gestionComercio,GestionVendedores gestionVendedores)
        {

            switch (opcion)
            {
                case 1:


                    break;

                case 2:

                    break;

                case 3:

                    break;

                case 4:

                    break;

                case 5:

                    break;
            }
        }

        public void MostrarMenuVendedor()
        {
            Console.Clear();
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

        private Producto RecogerDatosGenericos(){
            Console.Write("Nombre del producto");
            string nombreProducto = Console.ReadLine();

            Console.Write("Marca del producto");
            string marcaProducto = Console.ReadLine();

            Console.Write("Precio del producto");
            float.TryParse(Console.ReadLine(); out float precioProducto;

            Console.Write("Descripcion del producto");
            string descripcionProducto = Console.ReadLine();

            DateTime fechaActual = DateTime.Now;
            Console.Write("Nombre del producto");
            string nombreProducto = Console.ReadLine();

            Console.Write("Nombre del producto");
            string nombreProducto = Console.ReadLine();
        }
    }
}
