using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Esuhai.Api.Models
{
    public partial class ESUHAI_HRContext : DbContext
    {
        public ESUHAI_HRContext()
        {
        }

        public ESUHAI_HRContext(DbContextOptions<ESUHAI_HRContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Allowance> Allowance { get; set; }
        public virtual DbSet<AllowanceType> AllowanceType { get; set; }
        public virtual DbSet<AttachmentFiles> AttachmentFiles { get; set; }
        public virtual DbSet<Configuration> Configuration { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<DieuChinhNgayCong> DieuChinhNgayCong { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<MonthlyTimeSheet> MonthlyTimeSheet { get; set; }
        public virtual DbSet<Overtime> Overtime { get; set; }
        public virtual DbSet<PhanBoNgayCongThieu> PhanBoNgayCongThieu { get; set; }
        public virtual DbSet<PublicHolidays> PublicHolidays { get; set; }
        public virtual DbSet<Section> Section { get; set; }
        public virtual DbSet<TimeSheet> TimeSheet { get; set; }
        public virtual DbSet<TongHopDuLieu> TongHopDuLieu { get; set; }
        public virtual DbSet<WorkingDayPerMonth> WorkingDayPerMonth { get; set; }
        public virtual DbSet<WorkingShifts> WorkingShifts { get; set; }
        public virtual DbSet<Leave> Leave { get; set; }

        // Unable to generate entity type for table 'dbo.Leave'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BusinessTrip'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=ESUHAI_HR;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Allowance>(entity =>
            {
                entity.ToTable("ALLOWANCE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AllowanceTimeHoliday).HasColumnName("AllowanceTime_Holiday");

                entity.Property(e => e.AllowanceTimeWeekday).HasColumnName("AllowanceTime_Weekday");

                entity.Property(e => e.AllowanceTimeWeekend).HasColumnName("AllowanceTime_Weekend");

                entity.Property(e => e.Created).HasColumnType("smalldatetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.HrApprovalNote)
                    .HasColumnName("HR_ApprovalNote")
                    .HasMaxLength(4000);

                entity.Property(e => e.HrApprovalStatus)
                    .HasColumnName("HR_ApprovalStatus")
                    .HasMaxLength(50);

                entity.Property(e => e.HrEndDate)
                    .HasColumnName("HR_EndDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.HrStartDate)
                    .HasColumnName("HR_StartDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Modified).HasColumnType("smalldatetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.TpApprovalNote)
                    .HasColumnName("TP_ApprovalNote")
                    .HasMaxLength(4000);

                entity.Property(e => e.TpApprovalStatus)
                    .HasColumnName("TP_ApprovalStatus")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AllowanceType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AllowanceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AllowanceName).HasMaxLength(250);

                entity.Property(e => e.Description).HasMaxLength(500);
            });

            modelBuilder.Entity<AttachmentFiles>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Created).HasColumnType("smalldatetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ItemType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Modified).HasColumnType("smalldatetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<Configuration>(entity =>
            {
                entity.Property(e => e.CfgKey)
                    .IsRequired()
                    .HasColumnName("cfgKey")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CfgValue)
                    .IsRequired()
                    .HasColumnName("cfgValue")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(500);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Created).HasColumnType("smalldatetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeptManager).HasMaxLength(100);

                entity.Property(e => e.DeptName).HasMaxLength(50);

                entity.Property(e => e.Modified).HasColumnType("smalldatetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<DieuChinhNgayCong>(entity =>
            {
                entity.HasKey(e => new { e.Month, e.Year, e.IdNhanVien });

                entity.Property(e => e.Created).HasColumnType("smalldatetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Modified).HasColumnType("smalldatetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CardNo)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ChucDanh).HasMaxLength(50);

                entity.Property(e => e.Created).HasColumnType("smalldatetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FullName).HasMaxLength(200);

                entity.Property(e => e.Ho).HasMaxLength(50);

                entity.Property(e => e.ListItemId).HasColumnName("ListItemID");

                entity.Property(e => e.MaNv)
                    .IsRequired()
                    .HasColumnName("MaNV")
                    .HasMaxLength(10);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Modified).HasColumnType("smalldatetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.SpuserId).HasColumnName("SPUserID");

                entity.Property(e => e.SpuserName)
                    .HasColumnName("SPUserName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TbxetDuyet).HasColumnName("TBXetDuyet");

                entity.Property(e => e.Ten).HasMaxLength(50);

                entity.Property(e => e.TinhTrang).HasMaxLength(50);

                entity.Property(e => e.TpxetDuyet).HasColumnName("TPXetDuyet");
                entity.Property(e => e.DepartmentId).HasColumnName("Phong");
                entity.Property(e => e.SectionId).HasColumnName("Ban");
            });

            modelBuilder.Entity<MonthlyTimeSheet>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BtNgayCong).HasColumnName("BT_NgayCong");

                entity.Property(e => e.BtQuaDem).HasColumnName("BT_QuaDem");

                entity.Property(e => e.BtSang).HasColumnName("BT_Sang");

                entity.Property(e => e.BtSangTrua).HasColumnName("BT_SangTrua");

                entity.Property(e => e.BtTrua).HasColumnName("BT_Trua");

                entity.Property(e => e.Created).HasColumnType("smalldatetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.GhiChuDieuChinh).HasMaxLength(500);

                entity.Property(e => e.GhiChuPhanBo).HasMaxLength(500);

                entity.Property(e => e.Modified).HasColumnType("smalldatetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.OthoursNgayLe).HasColumnName("OTHours_NgayLe");

                entity.Property(e => e.OthoursNgayNghi).HasColumnName("OTHours_NgayNghi");

                entity.Property(e => e.OthoursNgayThuong).HasColumnName("OTHours_NgayThuong");

                entity.Property(e => e.TimesheetNgayCong).HasColumnName("Timesheet_NgayCong");

                entity.Property(e => e.XuatCanhNgayLe).HasColumnName("XuatCanh_NgayLe");

                entity.Property(e => e.XuatCanhNgayNghi).HasColumnName("XuatCanh_NgayNghi");

                entity.Property(e => e.XuatCanhNgayThuong).HasColumnName("XuatCanh_NgayThuong");
            });

            modelBuilder.Entity<Overtime>(entity =>
            {
                entity.ToTable("OVERTIME");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Created).HasColumnType("smalldatetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.EndTime).HasColumnType("smalldatetime");

                entity.Property(e => e.HrApprovalNote)
                    .HasColumnName("HR_ApprovalNote")
                    .HasMaxLength(4000);

                entity.Property(e => e.HrApprovalStatus)
                    .HasColumnName("HR_ApprovalStatus")
                    .HasMaxLength(50);

                entity.Property(e => e.Modified).HasColumnType("smalldatetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.OthoursHoliday).HasColumnName("OTHours_Holiday");

                entity.Property(e => e.OthoursWeekday).HasColumnName("OTHours_Weekday");

                entity.Property(e => e.OthoursWeekend).HasColumnName("OTHours_Weekend");

                entity.Property(e => e.RequestDate).HasColumnType("smalldatetime");

                entity.Property(e => e.StartTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.TbApprovalNote)
                    .HasColumnName("TB_ApprovalNote")
                    .HasMaxLength(500);

                entity.Property(e => e.TbApprovalStatus)
                    .HasColumnName("TB_ApprovalStatus")
                    .HasMaxLength(50);

                entity.Property(e => e.TpApprovalNote)
                    .HasColumnName("TP_ApprovalNote")
                    .HasMaxLength(4000);

                entity.Property(e => e.TpApprovalStatus)
                    .HasColumnName("TP_ApprovalStatus")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PhanBoNgayCongThieu>(entity =>
            {
                entity.HasKey(e => new { e.Month, e.Year, e.IdNhanVien })
                    .HasName("PK_PhanBoNgayCongThieu_1");

                entity.Property(e => e.Created).HasColumnType("smalldatetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Modified).HasColumnType("smalldatetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<PublicHolidays>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.Day).HasColumnType("datetime");

                entity.Property(e => e.FixDay).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(255);
            });

            modelBuilder.Entity<Section>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Created).HasColumnType("smalldatetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Modified).HasColumnType("smalldatetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.SectionManager).HasMaxLength(10);

                entity.Property(e => e.SectionName).HasMaxLength(50);
            });

            modelBuilder.Entity<TimeSheet>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CardNo)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Created).HasColumnType("smalldatetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.HrApprovalNote)
                    .HasColumnName("HR_ApprovalNote")
                    .HasMaxLength(500);

                entity.Property(e => e.HrApprovalStatus)
                    .HasColumnName("HR_ApprovalStatus")
                    .HasMaxLength(50);

                entity.Property(e => e.HrTimeIn)
                    .HasColumnName("HR_TimeIn")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.HrTimeOut)
                    .HasColumnName("HR_TimeOut")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ManualIn).HasColumnType("smalldatetime");

                entity.Property(e => e.ManualOut).HasColumnType("smalldatetime");

                entity.Property(e => e.Modified).HasColumnType("smalldatetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.RequestorNote).HasMaxLength(500);

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.Property(e => e.ShiftBreakFrom)
                    .HasColumnName("Shift_BreakFrom")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShiftBreakTo)
                    .HasColumnName("Shift_BreakTo")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShiftFromTime)
                    .HasColumnName("Shift_FromTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShiftToTime)
                    .HasColumnName("Shift_ToTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.TbApprovalNote)
                    .HasColumnName("TB_ApprovalNote")
                    .HasMaxLength(500);

                entity.Property(e => e.TbApprovalStatus)
                    .HasColumnName("TB_ApprovalStatus")
                    .HasMaxLength(50);

                entity.Property(e => e.TimeIn).HasColumnType("smalldatetime");

                entity.Property(e => e.TimeOut).HasColumnType("smalldatetime");

                entity.Property(e => e.TpApprovalNote)
                    .HasColumnName("TP_ApprovalNote")
                    .HasMaxLength(500);

                entity.Property(e => e.TpApprovalStatus)
                    .HasColumnName("TP_ApprovalStatus")
                    .HasMaxLength(50);

                entity.Property(e => e.WorkingDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TongHopDuLieu>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BreakFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.BreakTo).HasColumnType("smalldatetime");

                entity.Property(e => e.BtEndTime)
                    .HasColumnName("BT_EndTime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.BtId).HasColumnName("BT_ID");

                entity.Property(e => e.BtNgayCong).HasColumnName("BT_NgayCong");

                entity.Property(e => e.BtStartTime)
                    .HasColumnName("BT_StartTime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Created).HasColumnType("smalldatetime");

                entity.Property(e => e.FinalGioCong).HasColumnName("Final_GioCong");

                entity.Property(e => e.FinalIn)
                    .HasColumnName("Final_In")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FinalOut)
                    .HasColumnName("Final_Out")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LeaveEndTime)
                    .HasColumnName("Leave_EndTime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LeaveHopLeNgayCong).HasColumnName("LeaveHopLe_NgayCong");

                entity.Property(e => e.LeaveId).HasColumnName("Leave_ID");

                entity.Property(e => e.LeaveKhongHopLeNgayNghi).HasColumnName("LeaveKhongHopLe_NgayNghi");

                entity.Property(e => e.LeaveStartTime)
                    .HasColumnName("Leave_StartTime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LeaveStatus)
                    .HasColumnName("Leave_Status")
                    .HasMaxLength(50);

                entity.Property(e => e.Ngay).HasColumnType("date");

                entity.Property(e => e.NghiLeNgayCong).HasColumnName("NghiLe_NgayCong");

                entity.Property(e => e.ShiftEndTime)
                    .HasColumnName("Shift_EndTime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ShiftStartTime)
                    .HasColumnName("Shift_StartTime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.TimesheetGioCong).HasColumnName("Timesheet_GioCong");

                entity.Property(e => e.TimesheetNgayCong).HasColumnName("Timesheet_NgayCong");

                entity.Property(e => e.TimesheetTimeIn)
                    .HasColumnName("Timesheet_TimeIn")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.TimesheetTimeOut)
                    .HasColumnName("Timesheet_TimeOut")
                    .HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<WorkingDayPerMonth>(entity =>
            {
                entity.HasKey(e => new { e.Month, e.Year })
                    .HasName("PK_WorkingDayOfMonth");

                entity.Property(e => e.Created).HasColumnType("smalldatetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.Modified).HasColumnType("smalldatetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<WorkingShifts>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BreakFrom).HasColumnType("datetime");

                entity.Property(e => e.BreakTo).HasColumnType("datetime");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.FromTime).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(255);

                entity.Property(e => e.ShiftName).HasMaxLength(255);

                entity.Property(e => e.ToTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Leave>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("rowId");

                entity.Property(e => e.EmployeeId).HasColumnName("EmpId");
            });
        }
    }
}
