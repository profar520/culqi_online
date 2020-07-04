//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Culqi_Online.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Venta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Venta()
        {
            this.Detalle_Venta = new HashSet<Detalle_Venta>();
        }
    
        public int ID_Venta { get; set; }
        public int ID_Comercio { get; set; }
        public int ID_referencia { get; set; }
        public int ID_Tarjeta { get; set; }
        public int ID_Deposito { get; set; }
        public string Nombre_Comercio { get; set; }
        public Nullable<double> Monto { get; set; }
        public string Correo { get; set; }
        public string Estado { get; set; }
        public Nullable<System.DateTime> Fecha_Hora { get; set; }
    
        public virtual Comercio Comercio { get; set; }
        public virtual Deposito Deposito { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_Venta> Detalle_Venta { get; set; }
        public virtual Efectivo Efectivo { get; set; }
        public virtual tarjeta tarjeta { get; set; }
    }
}
