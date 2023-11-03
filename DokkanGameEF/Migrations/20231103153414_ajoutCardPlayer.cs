using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DokkanGameEF.Migrations
{
    public partial class ajoutCardPlayer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Number",
                table: "CardsPlayers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.InsertData(
                table: "CardsPlayers",
                columns: new[] { "CardId", "PlayerId", "Number" },
                values: new object[,]
                {
                    { 1, 1, 3 },
                    { 2, 1, 2 },
                    { 3, 1, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 1,
                column: "PlayerPassword",
                value: new byte[] { 249, 253, 73, 249, 129, 174, 73, 236, 167, 244, 116, 71, 213, 193, 113, 232, 205, 147, 179, 18, 29, 114, 226, 130, 36, 66, 10, 139, 213, 99, 234, 112, 73, 119, 74, 178, 40, 115, 103, 110, 46, 64, 229, 213, 251, 179, 38, 15, 134, 26, 218, 87, 224, 7, 249, 135, 221, 162, 11, 234, 64, 132, 65, 99 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CardsPlayers",
                keyColumns: new[] { "CardId", "PlayerId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CardsPlayers",
                keyColumns: new[] { "CardId", "PlayerId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "CardsPlayers",
                keyColumns: new[] { "CardId", "PlayerId" },
                keyValues: new object[] { 3, 1 });

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
                value: new byte[] { 149, 12, 113, 35, 58, 180, 78, 163, 84, 199, 37, 167, 137, 196, 161, 203, 176, 34, 86, 176, 173, 57, 110, 26, 161, 148, 85, 247, 65, 154, 83, 49, 88, 107, 180, 39, 76, 100, 161, 198, 182, 48, 163, 214, 177, 63, 6, 34, 106, 247, 219, 139, 133, 213, 219, 241, 255, 79, 246, 210, 181, 27, 71, 148 });
        }
    }
}
