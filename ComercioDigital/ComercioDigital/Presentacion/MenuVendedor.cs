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

        public void EjecutarMenuVendedor(GestionComercio gestionComercio,GestionVendedores gestionVendedores)
        {
            MostrarMenuVendedor();
            EjecutarOpcionVendedor(ElegirOpcionVendedor(),gestionComercio,gestionVendedores);
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
            Console.WriteLine("4-Cerrar Sesion");
        }

        public int ElegirOpcionVendedor()
        {
            bool opcionCorrecta = false;
            int opcionVendedor = -1;
            do
            {
                bool opcionVendedorIsINt = int.TryParse(Console.ReadLine(), out opcionVendedor);

                if (opcionVendedorIsINt && opcionVendedor <= 4 && opcionVendedor >= 1)
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
