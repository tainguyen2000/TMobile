//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EC_TH2012_J.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DanhsachdangkisanphamNCC
    {
        public int ID { get; set; }
        public Nullable<int> MaSPCanMua { get; set; }
        public string MaNCC { get; set; }
        public string Ghichu { get; set; }
        public Nullable<System.DateTime> NgayDK { get; set; }
        public Nullable<int> Trangthai { get; set; }
        public Nullable<int> TienmoiSP { get; set; }
    
        public virtual NhaCungCap NhaCungCap { get; set; }
        public virtual Sanphamcanmua Sanphamcanmua { get; set; }
    }
}
