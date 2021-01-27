using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComercioDigital.DTOs.Personas;
using ComercioDigital.Servicio;

namespace ComercioDigital.Presentacion
{
    public class MenuUsuario
    {

        public void EjecutarMenuUsuario(Usuario usuarioSesion ,GestionComercio gestionComercio, GestionUsuarios gestionUsuarios)
        {

            int opcionTemp =-1;
            do{
                MostrarMenuUsuarios();
                opcionTemp = ElegirOpcionUsuario();
                EjecutarOpcionUsuario(opcionTemp, gestionComercio, gestionUsuarios);
            }while(opcionTemp=!5);
           
            
        }

        public void EjecutarOpcionUsuario(int opcion, GestionComercio gestionComercio, GestionUsuarios gestionUsuarios)
        {

            switch (opcion)
            {
                case 1:

                    Console.WriteLine("TECNOLOGIA");
                    break;

                case 2:

                    Console.WriteLine("MODA");
                    break;

                case 3:

                    Console.WriteLine("MULTIMEDIA");
                    break;

                case 4:
                    Console.WriteLine("CUENTA");
                    break;

                case 5:
                    Console.WriteLine("CARRITO");
                    break;

                case 6:
                    Console.WriteLine("Se cerró la sesion de usuario");
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

                if (opcionUsuarioIsINt && opcionUsuario <= 5 && opcionUsuario >= 1)
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
            Console.WriteLine("4-Cuenta");
            Console.WriteLine("5-Carrito");
            Console.WriteLine("5-Salir");
            Console.Write("Opcion Menu Principal:");
        }

    }
}
