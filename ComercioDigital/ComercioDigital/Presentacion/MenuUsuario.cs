using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComercioDigital.Servicio;

namespace ComercioDigital.Presentacion
{
    public class MenuUsuario
    {

        public void EjecutarMenuUsuario(GestionComercio gestionComercio, GestionUsuarios gestionUsuarios)
        {
            MostrarMenuUsuarios();
            EjecutarOpcionUsuario(ElegirOpcionUsuario(), gestionComercio, gestionUsuarios);
        }

        public void EjecutarOpcionUsuario(int opcion, GestionComercio gestionComercio, GestionUsuarios gestionUsuarios)
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
            
        }
    }
}
