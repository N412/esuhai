using Microsoft.EntityFrameworkCore.Migrations;

namespace Esuhai.Api.Migrations
{
    public partial class updateModels_leave1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
                        migrationBuilder.AddColumn<string>(
                name: "HRApprovalStatus",
                table: "Leave",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HRId",
                table: "Leave",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TruongBanApprovalStatus",
                table: "Leave",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TruongBanId",
                table: "Leave",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TruongPhongApprovalStatus",
                table: "Leave",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TruongPhongId",
                table: "Leave",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HRApprovalStatus",
                table: "Leave");

            migrationBuilder.DropColumn(
                name: "HRId",
                table: "Leave");

            migrationBuilder.DropColumn(
                name: "TruongBanApprovalStatus",
                table: "Leave");

            migrationBuilder.DropColumn(
                name: "TruongBanId",
                table: "Leave");

            migrationBuilder.DropColumn(
                name: "TruongPhongApprovalStatus",
                table: "Leave");

            migrationBuilder.DropColumn(
                name: "TruongPhongId",
                table: "Leave");

            migrationBuilder.CreateIndex(
                name: "IX_Leave_EmpId",
                table: "Leave",
                column: "EmpId");

            migrationBuilder.AddForeignKey(
                name: "FK_Leave_Employee_EmpId",
                table: "Leave",
                column: "EmpId",
                principalTable: "Employee",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
