using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MojStolAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAdminPassword2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: -1,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 20, 9, 42, 21, 826, DateTimeKind.Utc).AddTicks(1040), "13XQnYErav4CtoV/lIaYlTuHWpRLEsQ5pwNVOqQk6vViySho1WJKbSMakFGSWbjuPvzgKzDqPK1bV1tztBSlMA==", "X2SKEXWHzxu1teb/qv5A8Q==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: -1,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 20, 9, 35, 49, 607, DateTimeKind.Utc).AddTicks(7880), "StmHRgx8FzZlhNgL0XqaPvRvpspWZBwOwWw1FiWV/xE=", "7hZL7hMHJefKrNPV8bRg8w==" });
        }
    }
}
