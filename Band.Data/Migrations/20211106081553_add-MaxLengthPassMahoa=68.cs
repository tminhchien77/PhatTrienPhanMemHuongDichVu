using Microsoft.EntityFrameworkCore.Migrations;

namespace Band.Data.Migrations
{
    public partial class addMaxLengthPassMahoa68 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MatKhau",
                table: "NGANHANG",
                type: "varchar(68)",
                maxLength: 68,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar");

            migrationBuilder.AlterColumn<string>(
                name: "IdTaiKhoan",
                table: "NGANHANG",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldMaxLength: 15);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MatKhau",
                table: "NGANHANG",
                type: "varchar",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(68)",
                oldMaxLength: 68);

            migrationBuilder.AlterColumn<string>(
                name: "IdTaiKhoan",
                table: "NGANHANG",
                type: "varchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20);
        }
    }
}
