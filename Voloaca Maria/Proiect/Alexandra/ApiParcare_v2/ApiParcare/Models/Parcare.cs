//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiParcare.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Parcare
    {
        public int LocID { get; set; }
        public string StareLoc { get; set; }
        public string StareLoc_Veche { get; set; }
        public Nullable<System.DateTime> DataModificare { get; set; }
        public Nullable<decimal> BottomLeftLat { get; set; }
        public Nullable<decimal> BottomLeftLng { get; set; }
        public Nullable<decimal> BottomRightLat { get; set; }
        public decimal BottomRightLng { get; set; }
        public Nullable<decimal> TopRightLat { get; set; }
        public Nullable<decimal> TopRightLng { get; set; }
        public Nullable<decimal> TopLeftLat { get; set; }
        public Nullable<decimal> TopLeftLng { get; set; }
    }
}
