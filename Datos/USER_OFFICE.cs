//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class USER_OFFICE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USER_OFFICE()
        {
            this.OFFICE_DETAIL = new HashSet<OFFICE_DETAIL>();
        }
    
        public int ID_USER { get; set; }
        public string NAME_USER { get; set; }
        public string LAST_USER { get; set; }
        public string USER_USER { get; set; }
        public string PASSWORD_USER { get; set; }
        public int ID_OFFICE_USER { get; set; }
    
        public virtual OFFICE OFFICE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OFFICE_DETAIL> OFFICE_DETAIL { get; set; }
    }
}