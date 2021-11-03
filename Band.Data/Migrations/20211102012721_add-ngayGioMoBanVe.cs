using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Band.Data.Migrations
{
    public partial class addngayGioMoBanVe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ThoiGian",
                table: "SHOW",
                newName: "ThoiDiemMoBan");

            migrationBuilder.AddColumn<DateTime>(
                name: "ThoiDiemBieuDien",
                table: "SHOW",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ThoiDiemBieuDien",
                table: "SHOW");

            migrationBuilder.RenameColumn(
                name: "ThoiDiemMoBan",
                table: "SHOW",
                newName: "ThoiGian");
        }
    }
}
