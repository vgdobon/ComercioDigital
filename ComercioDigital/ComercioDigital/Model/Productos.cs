//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ComercioDigital.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Productos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Productos()
        {
            this.Modas = new HashSet<Modas>();
            this.Multimedias = new HashSet<Multimedias>();
            this.Tecnologicos = new HashSet<Tecnologicos>();
            this.Carritos = new HashSet<Carritos>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Marca { get; set; }
        public int IdVendedor { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> Valoracion { get; set; }
        public System.DateTime FechaPuestaVenta { get; set; }
        public string CodigoDescuento { get; set; }
        public int Stock { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Modas> Modas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Multimedias> Multimedias { get; set; }
        public virtual Almacenes Almacenes { get; set; }
        public virtual Vendedores Vendedores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tecnologicos> Tecnologicos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Carritos> Carritos { get; set; }
    }
}