using System;
using System.Collections.Generic;

namespace Esuhai.Api.Models
{
    public partial class Section
    {
        public int Id { get; set; }
        public int? DepartmentId { get; set; }
        public string SectionName { get; set; }
        public string SectionManager { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public ICollection<Employee> Employee { get; set; }
    }
}
