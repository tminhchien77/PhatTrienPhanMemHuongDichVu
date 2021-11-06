using Microsoft.EntityFrameworkCore.Migrations;

namespace Band.Data.Migrations
{
    public partial class addSoLuongBanRa_MaSoVe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MaSoVe",
                table: "VE",
                type: "varchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SoLuongDaBan",
                table: "CHITIETVE_SHOW",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_VE_MaSoVe",
                table: "VE",
                column: "MaSoVe",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_VE_MaSoVe",
                table: "VE");

            migrationBuilder.DropColumn(
                name: "MaSoVe",
                table: "VE");

            migrationBuilder.DropColumn(
                name: "SoLuongDaBan",
                table: "CHITIETVE_SHOW");
        }
    }
}
