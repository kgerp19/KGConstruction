//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KGERP.Data.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PurchaseReturnDetail
    {
        public long PurchaseReturnDetailId { get; set; }
        public long PurchaseReturnId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<decimal> COGS { get; set; }
        public bool IsActive { get; set; }
        public Nullable<long> MaterialReceiveDetailId { get; set; }
    
        public virtual PurchaseReturn PurchaseReturn { get; set; }
    }
}