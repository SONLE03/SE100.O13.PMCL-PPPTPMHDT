//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SE100.Model.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class BAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BAN()
        {
            this.HOADONs = new HashSet<HOADON>();
        }
    
        public int id { get; set; }
        public string MaBan { get; set; }
        public string TenBan { get; set; }
        public int MaKhuVuc { get; set; }
        public int TrangThai { get; set; }
    
        public virtual KHUVUC KHUVUC { get; set; }
        public virtual TRANGTHAIBAN TRANGTHAIBAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }
    }
}
