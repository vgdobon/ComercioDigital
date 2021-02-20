using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComercioDigital.DTOs;
using ComercioDigital.DTOs.Productos;
using ComercioDigital.Model;
using ComercioDigital.Presentacion;
using ComercioDigital.Servicio.DB;
using ComercioDigital.Utiles;

namespace ComercioDigital
{
    class Program
    {
        static void Main(string[] args)
        {
            //MenuPrincipal menuPrincipal = new MenuPrincipal();
            //menuPrincipal.EjecutarApp();





            // << - -  PRUEBAS - - >>


            DBComerce.CargarDB();

            foreach(Producto producto in Almacen.AlmacenProductos)
            {
                Console.WriteLine(producto);
            }

            Mensaje.PulsaTeclaSalir();


            //eCommerceEntities ecDB = new eCommerceEntities();


            //foreach (var ecDbUsuario in ecDB.Usuarios)
            //{
            //    Console.WriteLine(ecDbUsuario.Nombre);
            //    foreach (var eCarritosProducto in ecDbUsuario.Carritos.Productos)
            //    {
            //        Console.WriteLine(eCarritosProducto.Nombre);
            //    }
            //}

            //Console.WriteLine(ecDB.Usuarios.FirstOrDefault(usuarios => usuarios.Id == 5).IdPedido);

            //ecDB.Usuarios.FirstOrDefault(usuarios => usuarios.Id == 5).IdPedido = 5;
            //Console.WriteLine(ecDB.Usuarios.FirstOrDefault(usuarios => usuarios.Id == 5).IdPedido);
            //Console.ReadKey();

        }
    }
}
