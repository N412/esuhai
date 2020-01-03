using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Esuhai.Api.Migrations
{
    public partial class updateModels_first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ALLOWANCE");

            migrationBuilder.DropTable(
                name: "AllowanceType");

            migrationBuilder.DropTable(
                name: "AttachmentFiles");

            migrationBuilder.DropTable(
                name: "Configuration");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "DieuChinhNgayCong");

            migrationBuilder.DropTable(
                name: "Leave");

            migrationBuilder.DropTable(
                name: "MonthlyTimeSheet");

            migrationBuilder.DropTable(
                name: "OVERTIME");

            migrationBuilder.DropTable(
                name: "PhanBoNgayCongThieu");

            migrationBuilder.DropTable(
                name: "PublicHolidays");

            migrationBuilder.DropTable(
                name: "Section");

            migrationBuilder.DropTable(
                name: "TimeSheet");

            migrationBuilder.DropTable(
                name: "TongHopDuLieu");

            migrationBuilder.DropTable(
                name: "WorkingDayPerMonth");

            migrationBuilder.DropTable(
                name: "WorkingShifts");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
