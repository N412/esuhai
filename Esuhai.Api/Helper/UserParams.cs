using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esuhai.Api.Helper
{
    public class UserParams
    {
        private const int MaxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        private int pageSize = 20;
        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
        }

        public int DepartmentId { get; set; }
        public string FilterBy { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        //public string Keyword { get; set; }
        public int EmployeeId { get; set; }
    }
}
