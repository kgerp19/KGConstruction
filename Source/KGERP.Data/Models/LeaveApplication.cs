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
    
    public partial class LeaveApplication
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LeaveApplication()
        {
            this.LeaveApplicationDetails = new HashSet<LeaveApplicationDetail>();
        }
    
        public long LeaveApplicationId { get; set; }
        public long Id { get; set; }
        public Nullable<long> ManagerId { get; set; }
        public Nullable<long> HrAdminId { get; set; }
        public int LeaveCategoryId { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public int LeaveDays { get; set; }
        public string Address { get; set; }
        public string ContactName { get; set; }
        public string Reason { get; set; }
        public string Remarks { get; set; }
        public string AppliedBy { get; set; }
        public string IP { get; set; }
        public string ManagerStatus { get; set; }
        public string ManagerComment { get; set; }
        public string HrAdminStatus { get; set; }
        public string HrAdminComment { get; set; }
        public System.DateTime ApplicationDate { get; set; }
        public Nullable<System.DateTime> ManagerApprovalDate { get; set; }
        public Nullable<System.DateTime> HRApprovalDate { get; set; }
        public Nullable<int> Active { get; set; }
        public Nullable<int> OperationId { get; set; }
        public int LeaveStatus { get; set; }
        public int Status { get; set; }
    
        public virtual LeaveCategory LeaveCategory { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Employee Employee1 { get; set; }
        public virtual Employee Employee2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeaveApplicationDetail> LeaveApplicationDetails { get; set; }
    }
}