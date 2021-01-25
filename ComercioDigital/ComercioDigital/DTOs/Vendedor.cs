using System;
using System.Collections.Generic;
using System.Linq;

namespace ComercioDigital.DTOs
{
    public class Vendedor
    {
        public static int Incrementer { get; set; }
        public int IdVendedor { get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public int Valoracion { get; set; }

        public List<int> Valoraciones;

        public Vendedor(string nombre, string ciudad)
        {
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Ciudad = ciudad ?? throw new ArgumentNullException(nameof(ciudad));
            Valoracion =  Valoraciones.Sum() / Valoraciones.Count();
            Incrementer++;
            IdVendedor = Incrementer;


        }
    }
}