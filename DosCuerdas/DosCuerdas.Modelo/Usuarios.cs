//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DosCuerdas.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuarios()
        {
            this.Bitacora_Movimientos = new HashSet<Bitacora_Movimientos>();
            this.Bitacora_Sesiones = new HashSet<Bitacora_Sesiones>();
            this.Cita = new HashSet<Cita>();
        }
    
        public int Id_Usuario { get; set; }
        public Nullable<int> Id_Rol { get; set; }
        public Nullable<int> ID_PERSONA { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public Nullable<int> Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bitacora_Movimientos> Bitacora_Movimientos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bitacora_Sesiones> Bitacora_Sesiones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cita> Cita { get; set; }
        public virtual Personas Personas { get; set; }
        public virtual Roles Roles { get; set; }
    }
}
