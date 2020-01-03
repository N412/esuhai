using System;
using System.Collections.Generic;

namespace Esuhai.Api.Models
{
    public partial class Allowance
    {
        public int Id { get; set; }
        public int IdNhanVien { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int AllowanceType { get; set; }
        public short? NumberAllowanceTime { get; set; }
        public short? MorningCount { get; set; }
        public short? AfternoonCount { get; set; }
        public short? MorningAfternoonCount { get; set; }
        public short? OvernightCount { get; set; }
        public string Description { get; set; }
        public string TpApprovalStatus { get; set; }
        public string TpApprovalNote { get; set; }
        public string HrApprovalStatus { get; set; }
        public string HrApprovalNote { get; set; }
        public DateTime? HrStartDate { get; set; }
        public DateTime? HrEndDate { get; set; }
        public short? ApprovalAllowanceTime { get; set; }
        public short? AllowanceTimeWeekday { get; set; }
        public short? AllowanceTimeWeekend { get; set; }
        public short? AllowanceTimeHoliday { get; set; }
        public short? ApprovalMorningCount { get; set; }
        public short? ApprovalAfternoonCount { get; set; }
        public short? ApprovalMorningAfternoonCount { get; set; }
        public short? ApprovalOvernightCount { get; set; }
        public string Status { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
