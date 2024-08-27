using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MojStolAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedAdminData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "DateOfBirth", "Email", "FailedTwoFactorAttempts", "IsActive", "Name", "PasswordHash", "PasswordSalt", "PhoneNumber", "ResetToken", "RoleId", "Surname", "TokenExpires", "TwoFactorCode", "TwoFactorEnabled", "TwoFactorExpiration" },
                values: new object[] { -1, new DateTime(2024, 8, 20, 9, 14, 10, 125, DateTimeKind.Utc).AddTicks(1310), null, "admin@gmail.com", null, true, "Admin", "e5g1b1jRxJmnIO2/KszU8NxDdrYPjYr3RJUZVG6V7cs=", "F0Yx6TgVbTgbnt+EpDK5MDqGrzSOmghFZIRFPpjOz9c=", null, null, 1, "Account", null, null, false, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: -1);
        }
    }
}
