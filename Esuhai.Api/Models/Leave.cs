using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Esuhai.Api.Models
{
    public partial class Leave
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double? Days { get; set; }
        public int RequestId { get; set; }
        public string LeaveStatus { get; set; }
        public string RequestStatus { get; set; }
        public string PaymentStatus { get; set; }

        public int TruongPhongId { get; set; }
        public string TruongPhongApprovalStatus { get; set; }

        public int TruongBanId { get; set; }
        public string TruongBanApprovalStatus { get; set; }

        public int HRId { get; set; }
        public string HRApprovalStatus { get; set; }

        public string NoiDungThayThe { get; set; }
        public string LyDoNghi { get; set; }
        
        public int EmployeeId { get; set; }        
        public int NhanVienThayTheId { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee NhanVienNghiPhep { get; set; }
        [ForeignKey("NhanVienThayTheId")]
        public Employee NhanVienThayThe { get; set; }

        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }

        public bool? isCancel { get; set; }
    }
}
