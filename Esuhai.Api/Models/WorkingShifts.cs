using System;
using System.Collections.Generic;

namespace Esuhai.Api.Models
{
    public partial class WorkingShifts
    {
        public int Id { get; set; }
        public string ShiftName { get; set; }
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }
        public DateTime BreakFrom { get; set; }
        public DateTime BreakTo { get; set; }
        public string Note { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
