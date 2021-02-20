using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComercioDigital.DTOs.Personas;
using ComercioDigital.DTOs.Productos;
using ComercioDigital.DTOs.Productos.Moda;
using ComercioDigital.DTOs.Productos.Multimedia;
using ComercioDigital.DTOs.Productos.Tecnologia;

namespace ComercioDigital.Utiles
{
    public static class DatosProducto
    {
        public static InfoProducto RecogerDatosGenericos(Vendedor vendedorSesion)
        {
            Console.Write("Nombre del producto: ");
            string nombreProducto = Console.ReadLine();

            Console.Write("Marca del producto: ");
            string marcaProducto = Console.ReadLine();

            Console.Write("Precio del producto: ");
            decimal.TryParse(Console.ReadLine(), out decimal precioProducto);

            Console.Write("Descripcion del producto: ");
            string descripcionProducto = Console.ReadLine();

            Console.Write("Código de descuento: ");
            string codigoDescuentoProducto = Console.ReadLine();

            Console.Write("Stock: ");
            int.TryParse(Console.ReadLine(), out int stock);

            InfoProducto infoProductoGenerico = new InfoProducto(nombreProducto, marcaProducto, precioProducto, descripcionProducto, codigoDescuentoProducto, stock, vendedorSesion);

            return infoProductoGenerico;
        }

        public static Tecnologia RecogerDatosTecnologia(Vendedor vendedorSesion)
        {
            InfoProducto infoProducto = RecogerDatosGenericos(vendedorSesion);
            Console.Write("Color del producto: ");
            string color = Console.ReadLine();

            Console.Write("Procesador del producto: ");
            string procesador = Console.ReadLine();

            Console.Write("Sistema operativo del producto: ");
            string sistemaOperativo = Console.ReadLine();


            Console.Write("Modelo del producto");
            string modelo = Console.ReadLine();

            Console.WriteLine("Fecha de lanzamaiento del producto");
            Console.Write("Año: ");
            int.TryParse(Console.ReadLine(), out int year);
            Console.Write("Mes: ");
            int.TryParse(Console.ReadLine(), out int mes);
            Console.Write("Dia: ");
            int.TryParse(Console.ReadLine(), out int dia);
            DateTime fechaLanzamiento = new DateTime(year, mes, dia);

            Tecnologia productoTecnologiaGenerico = new Tecnologia(null, infoProducto.Nombre, infoProducto.Marca, infoProducto.Precio, infoProducto.Vendedor, infoProducto.Descripcion, DateTime.Today, infoProducto.CodigoDescuento, infoProducto.Stock, color, procesador, sistemaOperativo, modelo, fechaLanzamiento);

            return productoTecnologiaGenerico;
        }
        public static Moda RecogerDatosModa(Vendedor vendedorSesion)
        {
            InfoProducto infoProducto = RecogerDatosGenericos(vendedorSesion);
            Console.Write("Color del producto: ");
            string color = Console.ReadLine();

            Console.Write("Material del producto: ");
            string material = Console.ReadLine();

            int opcionSexo;
            string sexo;
            Console.WriteLine("Sexo:");
            Console.WriteLine("Selecione: 1-Masculino\n2-Femenino");
            int.TryParse(Console.ReadLine(), out opcionSexo);
            if (opcionSexo == 1)
            {
                sexo = "H";
            }
            else if (opcionSexo == 2)
            {
                sexo = "M";
            }
            else
            {
                sexo = "U";
            }


            Moda productoNuevoModa = new Moda(null,infoProducto.Nombre, infoProducto.Marca, infoProducto.Precio, infoProducto.Vendedor, infoProducto.Descripcion, DateTime.Today, infoProducto.CodigoDescuento, infoProducto.Stock, color, material, sexo);
            return productoNuevoModa;
        }

        public static Multimedia RecogerDatosMultimedia(Vendedor vendedorSesion)
        {
            InfoProducto infoProducto = RecogerDatosGenericos(vendedorSesion);
            Multimedia productoMultimedia;

            Console.Write("Genero del producto: ");
            string genero = Console.ReadLine();
            Console.Write("Formato del producto: ");
            string formato = Console.ReadLine();
            Console.Write("Idioma del producto: ");
            string idioma = Console.ReadLine();

            Console.WriteLine("Fecha de lanzamiento del producto");
            Console.Write("Año: ");
            int.TryParse(Console.ReadLine(), out int year);
            Console.Write("Mes: ");
            int.TryParse(Console.ReadLine(), out int mes);
            Console.Write("Dia: ");
            int.TryParse(Console.ReadLine(), out int dia);
            DateTime fechaLanzamiento = new DateTime(year, mes, dia);

            productoMultimedia = new Multimedia(null,infoProducto.Nombre, infoProducto.Marca, infoProducto.Precio,
                infoProducto.Vendedor, infoProducto.Descripcion,
                DateTime.Today, infoProducto.CodigoDescuento, infoProducto.Stock, genero, formato, idioma,
                fechaLanzamiento);

            return productoMultimedia;
        }
    }
}
