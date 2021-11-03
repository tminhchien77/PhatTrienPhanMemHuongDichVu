using Microsoft.EntityFrameworkCore.Migrations;

namespace Band.Data.Migrations
{
    public partial class updatedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_THANHVIEN_NHOMNHAC_NhomNhacTenNhom",
                table: "THANHVIEN");

            migrationBuilder.DropIndex(
                name: "IX_THANHVIEN_NhomNhacTenNhom",
                table: "THANHVIEN");

            migrationBuilder.DropColumn(
                name: "NhomNhacTenNhom",
                table: "THANHVIEN");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NhomNhacTenNhom",
                table: "THANHVIEN",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_THANHVIEN_NhomNhacTenNhom",
                table: "THANHVIEN",
                column: "NhomNhacTenNhom");

            migrationBuilder.AddForeignKey(
                name: "FK_THANHVIEN_NHOMNHAC_NhomNhacTenNhom",
                table: "THANHVIEN",
                column: "NhomNhacTenNhom",
                principalTable: "NHOMNHAC",
                principalColumn: "TenNhom",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
