using Microsoft.EntityFrameworkCore.Migrations;

namespace Esuhai.Api.Migrations
{
    public partial class updateModelForLeave : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LyDoNghi",
                table: "Leave",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NhanVienThayTheId",
                table: "Leave",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NoiDungThayThe",
                table: "Leave",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LyDoNghi",
                table: "Leave");

            migrationBuilder.DropColumn(
                name: "NhanVienThayTheId",
                table: "Leave");

            migrationBuilder.DropColumn(
                name: "NoiDungThayThe",
                table: "Leave");
        }
    }
}
