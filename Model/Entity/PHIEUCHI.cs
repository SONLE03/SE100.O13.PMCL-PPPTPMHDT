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
    
    public partial class PHIEUCHI
    {
        public int id { get; set; }
        public string MaPhieuChi { get; set; }
        public Nullable<int> MaLoaiPhieuChi { get; set; }
        public Nullable<double> TongCong { get; set; }
    
        public virtual LOAIPHIEUCHI LOAIPHIEUCHI { get; set; }
    }
}
