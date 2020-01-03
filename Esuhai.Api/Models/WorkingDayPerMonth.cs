using System;
using System.Collections.Generic;

namespace Esuhai.Api.Models
{
    public partial class WorkingDayPerMonth
    {
        public short Month { get; set; }
        public short Year { get; set; }
        public double? TotalWorkingDay { get; set; }
        public bool? ChotCong { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
