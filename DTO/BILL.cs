//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class BILL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BILL()
        {
            this.BILL_DETAIL = new HashSet<BILL_DETAIL>();
        }
    
        public int id { get; set; }
        public string BillID { get; set; }
        public System.DateTime BillDate { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> TableID { get; set; }
        public int Status { get; set; }
        public string Note { get; set; }
        public Nullable<double> Total { get; set; }
    
        public virtual C_TABLE C_TABLE { get; set; }
        public virtual C_USER C_USER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BILL_DETAIL> BILL_DETAIL { get; set; }
    }
}
