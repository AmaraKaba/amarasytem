//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Veritabani
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sube_Table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sube_Table()
        {
            this.Devlet_memur_Table = new HashSet<Devlet_memur_Table>();
        }
    
        public int id { get; set; }
        public Nullable<int> Sehir { get; set; }
        public string Sube_Ad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Devlet_memur_Table> Devlet_memur_Table { get; set; }
        public virtual Sehir_Table Sehir_Table { get; set; }
    }
}
