using System;
using System.Collections.Generic;

namespace Esuhai.Api.Models
{
    public partial class TongHopDuLieu
    {
        public int Id { get; set; }
        public DateTime? Ngay { get; set; }
        public int? IdNhanVien { get; set; }
        public bool? IsHoliday { get; set; }
        public bool? IsWeekend { get; set; }
        public DateTime? ShiftStartTime { get; set; }
        public DateTime? ShiftEndTime { get; set; }
        public DateTime? BreakFrom { get; set; }
        public DateTime? BreakTo { get; set; }
        public DateTime? TimesheetTimeIn { get; set; }
        public DateTime? TimesheetTimeOut { get; set; }
        public double? TimesheetGioCong { get; set; }
        public double? TimesheetNgayCong { get; set; }
        public double? InLater { get; set; }
        public double? OutEarly { get; set; }
        public int? BtId { get; set; }
        public DateTime? BtStartTime { get; set; }
        public DateTime? BtEndTime { get; set; }
        public double? BtNgayCong { get; set; }
        public int? LeaveId { get; set; }
        public DateTime? LeaveStartTime { get; set; }
        public DateTime? LeaveEndTime { get; set; }
        public string LeaveStatus { get; set; }
        public double? LeaveHopLeNgayCong { get; set; }
        public double? LeaveKhongHopLeNgayNghi { get; set; }
        public double? NghiLeNgayCong { get; set; }
        public double? NgayCong { get; set; }
        public double? FinalGioCong { get; set; }
        public DateTime? FinalIn { get; set; }
        public DateTime? FinalOut { get; set; }
        public DateTime? Created { get; set; }
    }
}
