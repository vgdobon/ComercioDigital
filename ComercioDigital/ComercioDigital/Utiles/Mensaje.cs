using System;
using System.Threading;

namespace ComercioDigital.Utiles
{
    public static class Mensaje
    {

        public static void SalirMenu(string s)
        {
            Console.Clear();
            Console.Write(s);
            
            for (int j = 0; j <= 3; j++)
            {
                Console.Write($" . ");
                Thread.Sleep(1000);
            }
            
            
        }

        public static void PulsaTeclaSalir()
        {
            Console.WriteLine("Pulsa cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
