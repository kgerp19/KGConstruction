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
    
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public int CompanyId { get; set; }
        public string ProductType { get; set; }
        public int VendorId { get; set; }
        public Nullable<int> PaymentModeId { get; set; }
        public decimal InAmount { get; set; }
        public Nullable<decimal> OutAmount { get; set; }
        public string ReferenceNo { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public string DepositType { get; set; }
        public Nullable<int> BankId { get; set; }
        public string BranchName { get; set; }
        public string ChequeNo { get; set; }
        public string MoneyReceiptNo { get; set; }
        public string ReceiveLocation { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public bool IsActive { get; set; }
        public Nullable<long> OrderMasterId { get; set; }
        public Nullable<long> PurchaseOrderId { get; set; }
        public Nullable<int> PaymentMasterId { get; set; }
        public Nullable<int> PaymentFromHeadGLId { get; set; }
        public Nullable<long> CGID { get; set; }
        public Nullable<long> InstallmentId { get; set; }
        public Nullable<long> SCreditCollectionId { get; set; }
    
        public virtual PaymentMode PaymentMode { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}