using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MojStolAPI.Migrations
{
    /// <inheritdoc />
    public partial class UserModelUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PasswordSalt",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: -1,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 56, 59, 753, DateTimeKind.Utc).AddTicks(3320), "G4oSrmSV0dnsYVCKW5r7npavrUv2RgAUxuMDxs+9PCV3bAp1d6gqH9pCBWC1vueYIc6GWN+KVTn7i4kJHUHptQ==", "3z7SmrxK8jVM/4JUlC1Lbg==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PasswordSalt",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: -1,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 20, 9, 42, 21, 826, DateTimeKind.Utc).AddTicks(1040), "13XQnYErav4CtoV/lIaYlTuHWpRLEsQ5pwNVOqQk6vViySho1WJKbSMakFGSWbjuPvzgKzDqPK1bV1tztBSlMA==", "X2SKEXWHzxu1teb/qv5A8Q==" });
        }
    }
}
