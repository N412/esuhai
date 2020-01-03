using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Esuhai.Api.Dtos
{
    public class UserForLeaveDto
    {
        // Thong tin ca nhan
        [Display(Name = "Id")]
        public int NhanVienNghiPhepId { get; set; }
        [Display(Name = "FullName")]
        public string NhanVienNghiPhepFullName { get; set; }
        [Display(Name = "MaNV")]
        public string NhanVienNghiPhepMaNV { get; set; }
        [Display(Name = "SpuserName")]
        public string NhanVienNghiPhepUsername { get; set; }
        public string NhanVienNghiPhepChucDanh { get; set; }

        public int NhanVienNghiPhepDepartmentId { get; set; }
        [Display(Name = "DeptName")]
        public string NhanVienNghiPhepDepartmentDeptName { get; set; }

        public int? NhanVienNghiPhepSectionId { get; set; }
        [Display(Name = "SectionName")]
        public string NhanVienNghiPhepSectionName { get; set; }
        public int? NhanVienNghiPhepTbxetDuyet { get; set; }
        public int? NhanVienNghiPhepTpxetDuyet { get; set; }
        // Thong tin nghi phep
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double? Days { get; set; }
        public string LeaveStatus { get; set; }
        public string RequestStatus { get; set; }
        public bool TruongBanApprovalStatus { get; set; }
        public bool TruongPhongApprovalStatus { get; set; }
        public bool HrApprovalStatus { get; set; }
        public string NoiDungThayThe { get; set; }
        public string LyDoNghi { get; set; }
        // Nhan vien thay the
        public string NhanVienThayTheFullName { get; set; }
    }
}
