using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DokkanGameEF.Migrations
{
    public partial class ajoutPlayer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "Birthdate", "Email", "FirstName", "LastName", "PlayerPassword", "Pseudo" },
                values: new object[] { 1, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nico.daddabbo7100@gmail.com", "Nicolas", "D'Addabbo", new byte[] { 149, 12, 113, 35, 58, 180, 78, 163, 84, 199, 37, 167, 137, 196, 161, 203, 176, 34, 86, 176, 173, 57, 110, 26, 161, 148, 85, 247, 65, 154, 83, 49, 88, 107, 180, 39, 76, 100, 161, 198, 182, 48, 163, 214, 177, 63, 6, 34, 106, 247, 219, 139, 133, 213, 219, 241, 255, 79, 246, 210, 181, 27, 71, 148 }, "Nico75" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 1);
        }
    }
}
