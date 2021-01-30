using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComercioDigital.DTOs.Personas;
using ComercioDigital.DTOs.Productos;
using ComercioDigital.DTOs.Productos.Moda;
using ComercioDigital.DTOs.Productos.Tecnologia;
using ComercioDigital.Servicio;

namespace ComercioDigital.Presentacion
{
    public class MenuVendedor
    {

        public void EjecutarMenuVendedor(Vendedor vendedorSesion,GestionComercio gestionComercio,GestionVendedores gestionVendedores)
        {
            int opcionTemp=-1;
            do{
                MostrarMenuVendedor(vendedorSesion);
                opcionTemp = ElegirOpcionVendedor();
                EjecutarOpcionVendedor(opcionTemp,vendedorSesion,gestionComercio,gestionVendedores);
            }while(opcionTemp != 5);

            Console.WriteLine("Se cerro la sesion del vendedor");

            Console.ReadKey();
        }


        public void EjecutarOpcionVendedor(int opcion, Vendedor vendedorSesion, GestionComercio gestionComercio, GestionVendedores gestionVendedores)
        {

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Agregar producto");
                    InfoProducto infoproducto;
                    DateTime fechaAlta = DateTime.Today;


                    Console.WriteLine("Elija el tipo del producto:\n " +
                        "1-Tecnología\n" +
                        "2-Moda\n" +
                        "3-Multimedia\n");


                    bool opcionAgregarProductoIsInt = int.TryParse(Console.ReadLine(), out int opcionAgregarProducto);

                    switch (opcionAgregarProducto)
                    {
                        case 1:

                            Tecnologia productoTecnologia;
                            Console.WriteLine("Elija el tipo del producto de Tecnologia:\n " +
                                              "1-Ordenador\n" +
                                              "2-Videoconsola\n" +
                                              "3-Tablet o smartphone\n");

                            bool opcionTecnologiaIsInt = int.TryParse(Console.ReadLine(), out int opcionTecnologia);

                            if (opcionAgregarProductoIsInt)
                            {
                                infoproducto = RecogerDatosGenericos(vendedorSesion);
                                productoTecnologia = RecogerDatosTecnologia(infoproducto);
                                switch (opcionTecnologia)
                                {
                                    case 1:
                                        Console.WriteLine("Ordenador:");
                                        
                                        Console.Write("Placa Base:");
                                        string placaBase = Console.ReadLine();

                                        Console.Write("Tipo de ordenador(Portatil,sobremesa,surface...)");
                                        string tipoOrdenador = Console.ReadLine();

                                        Ordenador nuevoOrdenador = new Ordenador(productoTecnologia.Nombre, productoTecnologia.Marca, productoTecnologia.Precio, productoTecnologia.vendedor, productoTecnologia.Descripcion,productoTecnologia.FechaPuestaVenta,productoTecnologia.CodigoDescuento,productoTecnologia.Stock,productoTecnologia.Color,productoTecnologia.Procesador,productoTecnologia.SO,productoTecnologia.Modelo,productoTecnologia.FechaLanzamiento,placaBase,tipoOrdenador);
                                        gestionComercio.AgregarProductoAlmacen(nuevoOrdenador);
                                        break;

                                    case 2:
                                        Console.WriteLine("Videoconsola:");
                                        VideoConsola nuevoVideoConsola = new VideoConsola(productoTecnologia.Nombre, productoTecnologia.Marca, productoTecnologia.Precio, productoTecnologia.vendedor, productoTecnologia.Descripcion,productoTecnologia.FechaPuestaVenta,productoTecnologia.CodigoDescuento,productoTecnologia.Stock,productoTecnologia.Color,productoTecnologia.Procesador,productoTecnologia.SO,productoTecnologia.Modelo,productoTecnologia.FechaLanzamiento);
                                        gestionComercio.AgregarProductoAlmacen(nuevoVideoConsola);
                                        break;

                                    case 3:
                                        Console.WriteLine("Movil o tablet:");

                                        Console.Write("Pantalla:");
                                        int.TryParse(Console.ReadLine(), out int pantalla);

                                        Console.Write("Pantalla:");
                                        int.TryParse(Console.ReadLine(), out int bateria);

                                        Movil nuevoMovil = new Movil(productoTecnologia.Nombre, productoTecnologia.Marca, productoTecnologia.Precio, productoTecnologia.vendedor, productoTecnologia.Descripcion, productoTecnologia.FechaPuestaVenta, productoTecnologia.CodigoDescuento, productoTecnologia.Stock, productoTecnologia.Color, productoTecnologia.Procesador, productoTecnologia.SO, productoTecnologia.Modelo, productoTecnologia.FechaLanzamiento, pantalla, bateria);
                                        break;
                                }
                                
                            }
                 
                            break;

                        case 2:


                            break;

                        case 3:


                            break;

                    }
                   



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

        private InfoProducto RecogerDatosGenericos(Vendedor vendedorSesion)
        {
            Console.Write("Nombre del producto");
            string nombreProducto = Console.ReadLine();

            Console.Write("Marca del producto");
            string marcaProducto = Console.ReadLine();

            Console.Write("Precio del producto");
            float.TryParse(Console.ReadLine(), out float precioProducto);

            Console.Write("Descripcion del producto");
            string descripcionProducto = Console.ReadLine();

            Console.Write("Nombre del producto");
            string codigoDescuentoProducto = Console.ReadLine();

            Console.Write("Nombre del producto");
            int.TryParse( Console.ReadLine(),out int stock);

            InfoProducto infoProductoGenerico = new InfoProducto(nombreProducto, marcaProducto, precioProducto, descripcionProducto, codigoDescuentoProducto, stock,vendedorSesion);


            return infoProductoGenerico;
        }

        private Tecnologia RecogerDatosTecnologia(InfoProducto infoProducto)
        {
            Console.Write("Color del producto");
            string color = Console.ReadLine();

            Console.Write("Procesador del producto");
            string procesador = Console.ReadLine();

            Console.Write("Sistema operativo del producto");
            string sistemaOperativo = Console.ReadLine();

            
            Console.Write("Modelo del producto");
            string modelo = Console.ReadLine();

            Console.WriteLine("Fecha de lanzamaiento del producto");
            Console.Write("Año:");
            int.TryParse(Console.ReadLine(),out int year);
            Console.Write("Mes:");
            int.TryParse(Console.ReadLine(), out int mes);
            Console.Write("Dia:");
            int.TryParse(Console.ReadLine(), out int dia);
            DateTime fechaLanzamiento = new DateTime(year, mes,dia);

            Tecnologia productoTecnologiaGenerico = new Tecnologia(infoProducto.Nombre, infoProducto.Marca, infoProducto.Precio, infoProducto.Vendedor,infoProducto.Descripcion,DateTime.Today,infoProducto.CodigoDescuento,infoProducto.Stock,color,procesador,sistemaOperativo,modelo,fechaLanzamiento);

            return productoTecnologiaGenerico;
        }

        private Moda RecogerDatosModa(InfoProducto infoProducto)
        {
            Console.Write("Color del producto");
            string color = Console.ReadLine();

            Console.Write("Material del producto");
            string material = Console.ReadLine();

            int opcionSexo;
            string sexo;
            Console.WriteLine("Sexo:");
            Console.WriteLine("Selecione: 1-Masculino\n2-Femenino");
            int.TryParse(Console.ReadLine(), out opcionSexo);
            if (opcionSexo == 1)
            {
                sexo = "H";
            }else if (opcionSexo == 2)
            {
                sexo = "M";
            }
            else
            {
                sexo = "U";
            }

            Console.Write("Sistema operativo del producto");
            string sistemaOperativo = Console.ReadLine();

            Moda productoNuevoModa = new Moda(infoProducto.Nombre, infoProducto.Marca, infoProducto.Precio, infoProducto.Vendedor, infoProducto.Descripcion, DateTime.Today, infoProducto.CodigoDescuento, infoProducto.Stock,color,material,sexo);
            return productoNuevoModa;
        }
    }
}
