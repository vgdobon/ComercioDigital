using System;
using System.Collections.Generic;
using System.Linq;

namespace ComercioDigital.DTOs.Personas
{
    public class Vendedor
    {
        public int IdVendedor { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        public string Contrasenna { get; set; }

        public int Valoracion { get; set; }

        public List<int> Valoraciones;

        public Vendedor(string nombre, string direccion,string contrasenna,int id)
        {
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Direccion = direccion ?? throw new ArgumentNullException(nameof(direccion));
            Contrasenna = contrasenna ?? throw new ArgumentNullException(nameof(contrasenna));
            IdVendedor = id;
            //Valoracion =  Valoraciones.Sum() / Valoraciones.Count();
        }

        public Vendedor(string nombre, string direccion, string contrasenna)
        {
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Direccion = direccion ?? throw new ArgumentNullException(nameof(direccion));
            Contrasenna = contrasenna ?? throw new ArgumentNullException(nameof(contrasenna));
            //Valoracion =  Valoraciones.Sum() / Valoraciones.Count();
        }


        public override string ToString()
        {
            return $"{Nombre}";
        }
    }
}