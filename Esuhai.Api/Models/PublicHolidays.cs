using System;
using System.Collections.Generic;

namespace Esuhai.Api.Models
{
    public partial class PublicHolidays
    {
        public int Id { get; set; }
        public DateTime? Day { get; set; }
        public DateTime? FixDay { get; set; }
        public string Note { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
