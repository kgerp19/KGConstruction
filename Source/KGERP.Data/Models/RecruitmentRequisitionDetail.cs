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
    
    public partial class RecruitmentRequisitionDetail
    {
        public int Id { get; set; }
        public int RecruitmentRequisitionId { get; set; }
        public int BusinessType { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public long ReportingManagerId { get; set; }
        public string JobTitle { get; set; }
        public string JobLocation { get; set; }
        public int VacancyType { get; set; }
        public int NumberOfVacancy { get; set; }
        public int JobNature { get; set; }
        public int JobType { get; set; }
        public decimal TargetSalary { get; set; }
        public Nullable<System.DateTime> ExpectedJoiningDate { get; set; }
        public string JobDetails { get; set; }
        public string AdvertisementMedia { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    }
}