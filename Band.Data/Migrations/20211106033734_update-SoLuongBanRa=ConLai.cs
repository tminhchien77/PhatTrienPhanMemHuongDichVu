using Microsoft.EntityFrameworkCore.Migrations;

namespace Band.Data.Migrations
{
    public partial class updateSoLuongBanRaConLai : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoLuongDaBan",
                table: "CHITIETVE_SHOW");

            migrationBuilder.AddColumn<int>(
                name: "ConLai",
                table: "CHITIETVE_SHOW",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConLai",
                table: "CHITIETVE_SHOW");

            migrationBuilder.AddColumn<int>(
                name: "SoLuongDaBan",
                table: "CHITIETVE_SHOW",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
