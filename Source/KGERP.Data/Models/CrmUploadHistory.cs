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
    
    public partial class CrmUploadHistory
    {
        public int ClientId { get; set; }
        public string FileNo { get; set; }
        public string FullName { get; set; }
        public string BanglaName { get; set; }
        public string RegistrationName { get; set; }
        public string Spouse { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public int GenderId { get; set; }
        public string Gender { get; set; }
        public string Designation { get; set; }
        public string Profession { get; set; }
        public string DepartmentOrInstitution { get; set; }
        public string PresentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string OfficeAddress { get; set; }
        public Nullable<int> ReligionId { get; set; }
        public Nullable<System.DateTime> DateofBirth { get; set; }
        public string Nationality { get; set; }
        public string NID { get; set; }
        public string TIN { get; set; }
        public string CampaignName { get; set; }
        public string MobileNo { get; set; }
        public string MobileNo2 { get; set; }
        public string TelephoneRes { get; set; }
        public string TelephoneOffice { get; set; }
        public string Email { get; set; }
        public string Email1 { get; set; }
        public int SourceOfMediaId { get; set; }
        public string SourceOfMedia { get; set; }
        public string PromotionalOffer { get; set; }
        public int PromotionalOfferId { get; set; }
        public string Impression { get; set; }
        public int ServiceStatusId { get; set; }
        public string StatusLevel { get; set; }
        public int TypeOfInterestId { get; set; }
        public string TypeOfInterest { get; set; }
        public string Project { get; set; }
        public Nullable<int> ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int ChoieceAreaId { get; set; }
        public string ChoieceOfArea { get; set; }
        public string ReferredBy { get; set; }
        public string ServicesDescription { get; set; }
        public Nullable<System.DateTime> DateOfContact { get; set; }
        public Nullable<System.DateTime> LastContactDate { get; set; }
        public Nullable<System.DateTime> NextScheduleDate { get; set; }
        public Nullable<System.DateTime> LastMeetingDate { get; set; }
        public Nullable<System.DateTime> NextFollowupdate { get; set; }
        public int ResponsibleOfficerId { get; set; }
        public string ResponsibleOfficer { get; set; }
        public string KGRECompanyName { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public string FinalStatus { get; set; }
        public string Remarks { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public System.DateTime UploadDateTime { get; set; }
        public int UploadSerialNo { get; set; }
        public bool IsSync { get; set; }
    }
}