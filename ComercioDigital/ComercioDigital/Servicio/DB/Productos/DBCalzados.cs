using ComercioDigital.DTOs.Productos.Moda;
using ComercioDigital.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioDigital.Servicio.DB.Productos
{
    public static class DBCalzados
    {
        public static void CargarCalzadosDB(eCommerceEntitiesDB DBAccess)
        {
            foreach (var VARIABLE in DBAccess.Calzados)
            {
                GestionComercio.CargarlistaBD(MapCalzadosFromDBToDTO(VARIABLE));
            }
        }

        public static Calzado MapCalzadosFromDBToDTO(Calzados CalzadoDB)
        {

            Calzado resul = new Calzado(CalzadoDB.Modas.Productos.Id, CalzadoDB.Modas.Productos.Nombre, CalzadoDB.Modas.Productos.Marca, CalzadoDB.Modas.Productos.Precio, GestionVendedores.BuscarPorId(CalzadoDB.Modas.Productos.IdVendedor), CalzadoDB.Modas.Productos.Descripcion, CalzadoDB.Modas.Productos.FechaPuestaVenta, CalzadoDB.Modas.Productos.CodigoDescuento,
                CalzadoDB.Modas.Productos.Stock, CalzadoDB.Modas.Color, CalzadoDB.Modas.Material, CalzadoDB.Modas.Sexo,(int)CalzadoDB.Talla,CalzadoDB.Tipo);
            return resul;
        }

        public static Calzados MapCalzadosFromDTOToDB(Calzado calzadoDTO)
        {

            Calzados resul = new Calzados();
            if (resul.Modas == null)
            {
                resul.Modas = new Modas();
                if (resul.Modas.Productos == null)
                {
                    resul.Modas.Productos = new Model.Productos();
                }


            }
            resul.Modas.Productos.Nombre = calzadoDTO.Nombre;
            resul.Modas.Productos.Precio = calzadoDTO.Precio;
            resul.Modas.Productos.Marca = calzadoDTO.Marca;
            resul.Modas.Productos.IdVendedor = calzadoDTO.Vendedor.IdVendedor;
            resul.Modas.Productos.Descripcion = calzadoDTO.Descripcion;
            resul.Modas.Productos.Valoracion = calzadoDTO.Valoracion;
            resul.Modas.Productos.FechaPuestaVenta = calzadoDTO.FechaPuestaVenta;
            resul.Modas.Productos.CodigoDescuento = calzadoDTO.CodigoDescuento;
            resul.Modas.Productos.Stock = calzadoDTO.Stock;
            resul.Modas.Color = calzadoDTO.Color;
            resul.Modas.Material = calzadoDTO.Material;
            resul.Modas.Sexo = calzadoDTO.Sexo;
            resul.Talla = calzadoDTO.Talla;
            resul.Tipo = calzadoDTO.Tipo;

            return resul;
        }

        public static void AnnadirCalzado(Calzado calzadoDTO)
        {

            Calzados nuevoCalzado = MapCalzadosFromDTOToDB(calzadoDTO);
            DBComerce.DBAccess.Calzados.Add(nuevoCalzado);

            DBComerce.DBAccess.SaveChangesAsync();

        }
    }
}
