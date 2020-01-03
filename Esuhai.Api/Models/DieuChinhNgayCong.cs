using System;
using System.Collections.Generic;

namespace Esuhai.Api.Models
{
    public partial class DieuChinhNgayCong
    {
        public int Id { get; set; }
        public short Month { get; set; }
        public short Year { get; set; }
        public int IdNhanVien { get; set; }
        public double? DieuChinhTang { get; set; }
        public double? DieuChinhGiam { get; set; }
        public string Description { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
