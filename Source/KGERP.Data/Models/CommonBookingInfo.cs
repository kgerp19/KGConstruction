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
    
    public partial class CommonBookingInfo
    {
        public long BookingId { get; set; }
        public string BookingNo { get; set; }
        public int ProductId { get; set; }
        public int CompanyId { get; set; }
        public decimal BookingAmt { get; set; }
        public double DiscountPercentage { get; set; }
        public Nullable<decimal> SpecialDiscountAmt { get; set; }
        public bool IsInstallment { get; set; }
        public Nullable<int> NoOfInstallment { get; set; }
        public Nullable<int> InstallmentTypeId { get; set; }
        public string OtherInformation { get; set; }
        public Nullable<System.DateTime> FinalApvDate { get; set; }
        public Nullable<long> FinalApproverBy { get; set; }
        public Nullable<System.DateTime> ApproveDate { get; set; }
        public Nullable<long> ApprovedBy { get; set; }
        public Nullable<System.DateTime> CheckDate { get; set; }
        public Nullable<long> CheckedBy { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
        public Nullable<long> EntryBy { get; set; }
        public Nullable<long> SoldBy { get; set; }
        public Nullable<int> Status { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> ApplicationDate { get; set; }
        public decimal RestofAmount { get; set; }
        public Nullable<System.DateTime> BookingDate { get; set; }
        public bool IsSubmitted { get; set; }
        public string FileNo { get; set; }
        public decimal PaidBookingAmt { get; set; }
        public decimal InstallmentAmount { get; set; }
        public decimal ProductValue { get; set; }
        public bool IsIncentive { get; set; }
        public int FileStatus { get; set; }
        public decimal Parcentage { get; set; }
        public decimal ParcentageAmount { get; set; }
        public int VendorId { get; set; }
        public Nullable<decimal> COGSPrice { get; set; }
        public decimal DeliveredQuantity { get; set; }
    
        public virtual BookingInstallmentType BookingInstallmentType { get; set; }
    }
}