using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Esuhai.Api.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string MaNv { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string FullName { get; set; }
        public string ChucDanh { get; set; }
        public int? DepartmentId { get; set; }
        //public int? Phong { get; set; }
        public int? SectionId { get; set; }
        //public int? Ban { get; set; }
        public string TinhTrang { get; set; }
        public int? TpxetDuyet { get; set; }
        public int? TbxetDuyet { get; set; }
        public string CardNo { get; set; }
        public string SpuserName { get; set; }
        public int? SpuserId { get; set; }
        public bool? NotActive { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public int? WorkingShiftId { get; set; }
        public bool? NotRemind { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public int? ListItemId { get; set; }
        public bool? ChamCongBangTay { get; set; }
        public bool? isHR { get; set; }
        public Department Department { get; set; }
        public Section Section { get; set; }

        [InverseProperty("NhanVienNghiPhep")]
        public ICollection<Leave> NghiPheps { get; set; }
        [InverseProperty("NhanVienThayThe")]
        public ICollection<Leave> HoTroNghiPheps { get; set; }
    }
}
