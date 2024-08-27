using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MojStolAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAdminSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: -1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 20, 9, 35, 49, 607, DateTimeKind.Utc).AddTicks(7880));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: -1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 20, 9, 25, 19, 38, DateTimeKind.Utc).AddTicks(4010));
        }
    }
}
