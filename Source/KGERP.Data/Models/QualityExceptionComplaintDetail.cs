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
    
    public partial class QualityExceptionComplaintDetail
    {
        public long QualityExceptionComplaintDetailId { get; set; }
        public long QualityExceptionComplaintId { get; set; }
        public long OrderDeliverDetailId { get; set; }
        public Nullable<decimal> DeliveredAffectedWeight { get; set; }
        public Nullable<decimal> DeliveredAffectedQty { get; set; }
        public string DescriptionQualityException { get; set; }
        public string OtherRemarks { get; set; }
        public Nullable<int> QualityException { get; set; }
        public Nullable<long> PersonsResponsibleForQualityException { get; set; }
        public string ExceptionExplanation { get; set; }
        public string StepsTakenToPreventRecurrence { get; set; }
        public Nullable<long> SignatureOfProductionInCharge { get; set; }
        public bool IsSubmited { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsActive { get; set; }
    
        public virtual QualityExceptionComplaintDetail QualityExceptionComplaintDetail1 { get; set; }
        public virtual QualityExceptionComplaintDetail QualityExceptionComplaintDetail2 { get; set; }
    }
}