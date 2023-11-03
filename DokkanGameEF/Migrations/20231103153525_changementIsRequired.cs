using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DokkanGameEF.Migrations
{
    public partial class changementIsRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Number",
                table: "CardsPlayers",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 1,
                column: "PlayerPassword",
                value: new byte[] { 116, 181, 38, 176, 80, 87, 130, 152, 168, 205, 107, 30, 165, 90, 68, 38, 115, 251, 149, 107, 165, 235, 251, 87, 21, 184, 42, 67, 218, 233, 186, 60, 232, 135, 255, 130, 28, 169, 48, 43, 107, 208, 6, 7, 32, 238, 225, 235, 207, 50, 228, 209, 42, 70, 139, 163, 249, 200, 22, 71, 220, 33, 12, 125 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Number",
                table: "CardsPlayers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 1,
                column: "PlayerPassword",
                value: new byte[] { 249, 253, 73, 249, 129, 174, 73, 236, 167, 244, 116, 71, 213, 193, 113, 232, 205, 147, 179, 18, 29, 114, 226, 130, 36, 66, 10, 139, 213, 99, 234, 112, 73, 119, 74, 178, 40, 115, 103, 110, 46, 64, 229, 213, 251, 179, 38, 15, 134, 26, 218, 87, 224, 7, 249, 135, 221, 162, 11, 234, 64, 132, 65, 99 });
        }
    }
}
