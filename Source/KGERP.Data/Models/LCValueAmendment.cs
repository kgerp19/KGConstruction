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
    
    public partial class LCValueAmendment
    {
        public long LCValueAmendmentId { get; set; }
        public long LCId { get; set; }
        public System.DateTime AmendmentDate { get; set; }
        public decimal LCValue { get; set; }
        public decimal LCValueInBDT { get; set; }
        public decimal CashMarginPercent { get; set; }
        public decimal CashMarginAmount { get; set; }
        public decimal BankCharge { get; set; }
        public decimal InsuranceValue { get; set; }
        public decimal CommissionValue { get; set; }
        public decimal FreightCharges { get; set; }
        public decimal OtherCharge { get; set; }
        public bool IsActive { get; set; }
        public int Status { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}