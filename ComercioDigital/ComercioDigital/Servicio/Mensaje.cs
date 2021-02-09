using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ComercioDigital.Servicio
{
    public static class Mensaje
    {

        public static void SalirMenu(string s)
        {
            Console.Write(s);
            for (int i = 3; i > 0; i--)
            {
                Console.Write($" {i} ... ");
                Thread.Sleep(2000);
            }
        }
    }
}
