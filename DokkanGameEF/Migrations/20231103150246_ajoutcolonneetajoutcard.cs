using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DokkanGameEF.Migrations
{
    public partial class ajoutcolonneetajoutcard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Side",
                table: "Cards",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Cards",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "CardId", "Attack", "Card_attack_details", "Card_details", "Card_name", "Defense", "Leader_skill", "Life", "Side", "Type" },
                values: new object[] { 1, 7888, "Raises ATK & DEF for 1 turn and causes colossal damage to enemy", "ATK & DEF +59%; plus an additional ATK & DEF +59% when performing a Super Attack; all allies' Ki +2 and ATK & DEF +30%; plus an additional Ki +3 and ATK +59% when attacking Extreme Class enemies", "Son Goku", 7888, "All Types Ki +3 and HP, ATK & DEF +59%", 7888, "Super", "END" });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "CardId", "Attack", "Card_attack_details", "Card_details", "Card_name", "Defense", "Leader_skill", "Life", "Side", "Type" },
                values: new object[] { 2, 8887, "Greatly raises ATK, raises DEF and causes supreme damage to enemy", "Ki +1 at start of each turn and ATK +70% when there is a \"Goku's Family\" Category enemy; ATK & DEF +100% when performing a Super Attack; Ki +7 and DEF +70% when HP is 70% or less; chance of performing a critical hit +7% per PHY icon Ki Sphere obtained (up to 30%)", "Vegeta", 8887, "'Vegeta's Family' Category Ki +3 and HP, ATK & DEF +130%; or PHY icon Type Ki + 3 and HP, ATK & DEF + 100 %", 8887, "Extreme", "END" });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "CardId", "Attack", "Card_attack_details", "Card_details", "Card_name", "Defense", "Leader_skill", "Life", "Side", "Type" },
                values: new object[] { 3, 8887, "Greatly raises ATK & DEF for 1 turn and causes colossal damage to enemy", "ATK & DEF +50%; Ki +3 plus an additional DEF +50% as the 1st or 3rd attacker in a turn; plus an additional ATK +50% when performing an Ultra Super Attack; plus an additional Ki +3 when attacking Super Class enemies", "Frieza (1st Form)", 8887, "Extreme Class Ki +4 and HP, ATK & DEF +90%;\r\nor\r\nSuper Class Ki +3 and HP, ATK & DEF +70%", 8887, "Extreme", "STR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Side",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Cards");
        }
    }
}
