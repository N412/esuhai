using System;
using System.Collections.Generic;

namespace Esuhai.Api.Models
{
    public partial class AllowanceType
    {
        public int Id { get; set; }
        public string AllowanceCode { get; set; }
        public string AllowanceName { get; set; }
        public double? Cost { get; set; }
        public string Description { get; set; }
    }
}
