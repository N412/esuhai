using System;
using System.Collections.Generic;

namespace Esuhai.Api.Models
{
    public partial class Overtime
    {
        public int Id { get; set; }
        public int IdNhanVien { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double? RequestedHours { get; set; }
        public string Description { get; set; }
        public string TpApprovalStatus { get; set; }
        public string TpApprovalNote { get; set; }
        public string HrApprovalStatus { get; set; }
        public string HrApprovalNote { get; set; }
        public double? ApprovalHours { get; set; }
        public double? OthoursWeekday { get; set; }
        public double? OthoursWeekend { get; set; }
        public double? OthoursHoliday { get; set; }
        public string Status { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string TbApprovalStatus { get; set; }
        public string TbApprovalNote { get; set; }
    }
}
