using Esuhai.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esuhai.Api.Dtos
{
    public class UserForLoginDto
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public Nullable<DateTime> Birthday { get; set; }
        public string ImageUrl { get; set; }
        public string MaNV { get; set; }
        public string SPUserName { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentDeptName { get; set; }
        public int SectionId { get; set; }
        public string SectionSectionName { get; set; }
        public string ChucDanh { get; set; }
        public bool? isHR { get; set; }
        //public List<Department> ListDepartments { get; set; }
        public int? TPXetDuyet { get; set; }
        public int? TBXetDuyet { get; set; }
        public string TinhTrang { get; set; }
    }
}
