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
    
    public partial class AnnualPerformanceDetail
    {
        public long AnnualPerformanceDetailId { get; set; }
        public long AnnualPerformanceId { get; set; }
        public long EmployeeId { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public int Recommendation { get; set; }
        public Nullable<int> IncreaseProMonth { get; set; }
        public string PerformanceInReportingYear { get; set; }
        public string AdditionalPerformance { get; set; }
        public string PlanforNextYear { get; set; }
        public decimal SalesTarget { get; set; }
        public Nullable<decimal> SalesAchievement { get; set; }
        public decimal RecoveryTarget { get; set; }
        public Nullable<decimal> RecoveryAchievement { get; set; }
        public Nullable<decimal> FinalMarking { get; set; }
        public int FinalRecommendation { get; set; }
        public int Status { get; set; }
        public string MajorWorkOne { get; set; }
        public string MajorWorkTwo { get; set; }
        public string MajorWorkThree { get; set; }
        public string MajorWorkFour { get; set; }
        public Nullable<decimal> WorkWithReportingOfficer { get; set; }
        public string PerformingPlanForNextYear { get; set; }
        public bool IsSubmitted { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsActive { get; set; }
    }
}