using KGERP.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGERP.Service.Implementation.General_Requisition.ViewModels
{
    public class RequisitionApprovalVM
    {
        public int RequisitionApprovalId { get; set; }
        public int CompanyId { get; set; }
        public long EmployeeId { get; set; }
        public long IntregratedFromId { get; set; }
        public string EmployeeIdString { get; set; }
        public string EmployeeName { get; set; }
        public string DesignationName { get; set; }
        public string DepartmentName { get; set; }
        public SignatoryStatusEnum  Status { get; set; }
        public string  StatusString { get; set; }
        public string ApprovedTime { get; set; }
        public int OrderBy { get; set; }
        public string Comment { get; set; }
        public string CSNO { get; set; }
        public string ProductName { get; set; }
        
        public decimal? RequirQuantity { get; set; }
        public DateTime? CSDate { get; set; }
        public SignatoryStatusEnum SignatoryStatus { get; set; }

       
        public int LeaveStatus { get; set; }
        public int ApprovalStatus { get; set; }
   
      

    }


    public class SystemApprovalVM
    {
        public long SignatoryApprovalMapId { get; set; }
        public int ApprovalId { get; set; }
        public int CompanyId { get; set; }
        public long EmployeeId { get; set; }
        public long IntregratedFromId { get; set; }
        public string EmployeeIdString { get; set; }
        public string EmployeeName { get; set; }
        public string DesignationName { get; set; }
        public string DepartmentName { get; set; }
         
        public string StatusString { get; set; }
        public string ApprovedTime { get; set; }
        public int OrderBy { get; set; }
        public string Comment { get; set; }
        public string CSNO { get; set; }
        public string ProductName { get; set; }

        public decimal? RequirQuantity { get; set; }
        public DateTime? CSDate { get; set; }
     //   public SignatoryStatusEnum SignatoryStatus { get; set; }

        public int Status { get; set; }       
        public int ApprovalStatus { get; set; }
        public long SigID { get; set; }
        public long CSID { get; set; }
        public IEnumerable<SystemApprovalVM> DataList { get; set; }



    }
}
