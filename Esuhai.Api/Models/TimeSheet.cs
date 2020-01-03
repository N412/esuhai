using System;
using System.Collections.Generic;

namespace Esuhai.Api.Models
{
    public partial class TimeSheet
    {
        public int Id { get; set; }
        public int IdNhanVien { get; set; }
        public DateTime WorkingDate { get; set; }
        public short Month { get; set; }
        public short Year { get; set; }
        public string CardNo { get; set; }
        public DateTime? ShiftFromTime { get; set; }
        public DateTime? ShiftToTime { get; set; }
        public DateTime? ShiftBreakFrom { get; set; }
        public DateTime? ShiftBreakTo { get; set; }
        public DateTime? TimeIn { get; set; }
        public DateTime? TimeOut { get; set; }
        public DateTime? ManualIn { get; set; }
        public DateTime? ManualOut { get; set; }
        public string RequestorNote { get; set; }
        public string TpApprovalStatus { get; set; }
        public string TpApprovalNote { get; set; }
        public string HrApprovalStatus { get; set; }
        public string HrApprovalNote { get; set; }
        public DateTime? HrTimeIn { get; set; }
        public DateTime? HrTimeOut { get; set; }
        public string Status { get; set; }
        public DateTime? SendDate { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string TbApprovalStatus { get; set; }
        public string TbApprovalNote { get; set; }
    }
}
