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
    
    public partial class BILL_DETAIL
    {
        public int BillID { get; set; }
        public int DrinksID { get; set; }
        public int SizeID { get; set; }
        public Nullable<int> Quantity { get; set; }
        public double Rate { get; set; }
        public Nullable<double> Amount { get; set; }
    
        public virtual C_SIZE C_SIZE { get; set; }
        public virtual BILL BILL { get; set; }
        public virtual DRINK DRINK { get; set; }
    }
}
