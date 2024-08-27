using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MojStolAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAdminPass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: -1,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 20, 9, 25, 19, 38, DateTimeKind.Utc).AddTicks(4010), "StmHRgx8FzZlhNgL0XqaPvRvpspWZBwOwWw1FiWV/xE=", "7hZL7hMHJefKrNPV8bRg8w==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: -1,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 20, 9, 14, 10, 125, DateTimeKind.Utc).AddTicks(1310), "e5g1b1jRxJmnIO2/KszU8NxDdrYPjYr3RJUZVG6V7cs=", "F0Yx6TgVbTgbnt+EpDK5MDqGrzSOmghFZIRFPpjOz9c=" });
        }
    }
}
