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
    
    public partial class EmployeeLoan
    {
        public int LoanID { get; set; }
        public string EmployeeId { get; set; }
        public Nullable<int> LoanType { get; set; }
        public string LoanPurpose { get; set; }
        public Nullable<int> Amount { get; set; }
        public Nullable<int> NoOfInstallment { get; set; }
        public Nullable<System.DateTime> LoanApplyDate { get; set; }
        public Nullable<int> InstallmentAmount { get; set; }
        public Nullable<System.DateTime> InstallStartDate { get; set; }
        public Nullable<System.DateTime> LoanEndDate { get; set; }
        public string Remarks { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}