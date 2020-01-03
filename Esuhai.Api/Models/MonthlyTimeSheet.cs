using System;
using System.Collections.Generic;

namespace Esuhai.Api.Models
{
    public partial class MonthlyTimeSheet
    {
        public int Id { get; set; }
        public short Month { get; set; }
        public short Year { get; set; }
        public int IdNhanVien { get; set; }
        public double? TongNgayCong { get; set; }
        public double? TimesheetNgayCong { get; set; }
        public double? NghiPhep { get; set; }
        public double? NghiLe { get; set; }
        public double? NghiViecRieng { get; set; }
        public double? TonPhep { get; set; }
        public double? CongPhep { get; set; }
        public double? TruPhep { get; set; }
        public double? NgayPhepThangSau { get; set; }
        public double? TruCong { get; set; }
        public string GhiChuPhanBo { get; set; }
        public double? OthoursNgayThuong { get; set; }
        public double? OthoursNgayNghi { get; set; }
        public double? OthoursNgayLe { get; set; }
        public double? BtNgayCong { get; set; }
        public double? BtSang { get; set; }
        public double? BtTrua { get; set; }
        public double? BtSangTrua { get; set; }
        public double? BtQuaDem { get; set; }
        public double? XuatCanhNgayThuong { get; set; }
        public double? XuatCanhNgayNghi { get; set; }
        public double? XuatCanhNgayLe { get; set; }
        public double? DonKhach { get; set; }
        public double? InLater { get; set; }
        public double? OutEarly { get; set; }
        public double? ViecCaNhan { get; set; }
        public double? DieuChinhTangGiam { get; set; }
        public string GhiChuDieuChinh { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
