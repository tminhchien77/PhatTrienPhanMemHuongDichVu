using Microsoft.EntityFrameworkCore.Migrations;

namespace Band.Data.Migrations
{
    public partial class addBankDbo2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NGANHANG",
                columns: table => new
                {
                    IdTaiKhoan = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    SoDu = table.Column<decimal>(type: "numeric", nullable: false),
                    MatKhau = table.Column<string>(type: "varchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NGANHANG", x => x.IdTaiKhoan);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NGANHANG");
        }
    }
}
