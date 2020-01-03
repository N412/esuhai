using System;
using System.Collections.Generic;

namespace Esuhai.Api.Models
{
    public partial class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        public string DeptManager { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public ICollection<Employee> Employee { get; set; }
    }
}
