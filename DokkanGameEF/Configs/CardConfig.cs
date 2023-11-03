using DokkanGameEF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DokkanGameEF.Configs
{
    public class CardConfig : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.HasKey(c => c.CardId);
            builder.Property(c => c.CardId).ValueGeneratedOnAdd();
            builder.Property(c => c.Card_name).HasMaxLength(100).IsRequired();
            builder.Property(c => c.Type).HasMaxLength(3).IsRequired();
            builder.Property(c => c.Side).HasMaxLength(7).IsRequired();
            builder.Property(c => c.Card_details).IsRequired();
            builder.Property(c => c.Card_attack_details).IsRequired();
            builder.Property(c => c.Card_details).IsRequired();
            builder.Property(c => c.Defense).HasMaxLength(5);
            builder.Property(c => c.Attack).HasMaxLength(5);
            builder.Property(c => c.Life).HasMaxLength(5);
            builder.HasData(new Card
            {
                CardId = 1,
                Card_name = "Son Goku",
                Type = "END",
                Side = "Super",
                Attack = 7888,
                Defense = 7888,
                Life = 7888,
                Leader_skill = "All Types Ki +3 and HP, ATK & DEF +59%",
                Card_attack_details = "Raises ATK & DEF for 1 turn and causes colossal damage to enemy",
                Card_details = "ATK & DEF +59%; plus an additional ATK & DEF +59% when performing a Super Attack; all allies' Ki +2 and ATK & DEF +30%; plus an additional Ki +3 and ATK +59% when attacking Extreme Class enemies",
            },
            new Card
            {
                CardId = 2,
                Card_name = "Vegeta",
                Type = "END",
                Side = "Extreme",
                Attack = 8887,
                Defense = 8887,
                Life = 8887,
                Leader_skill = "'Vegeta's Family' Category Ki +3 and HP, ATK & DEF +130%; or PHY icon Type Ki + 3 and HP, ATK & DEF + 100 %",
                Card_attack_details = "Greatly raises ATK, raises DEF and causes supreme damage to enemy",
                Card_details = "Ki +1 at start of each turn and ATK +70% when there is a \"Goku's Family\" Category enemy; ATK & DEF +100% when performing a Super Attack; Ki +7 and DEF +70% when HP is 70% or less; chance of performing a critical hit +7% per PHY icon Ki Sphere obtained (up to 30%)"
            },
              new Card
              {
                  CardId = 3,
                  Card_name = "Frieza (1st Form)",
                  Type = "STR",
                  Side = "Extreme",
                  Attack = 8887,
                  Defense = 8887,
                  Life = 8887,
                  Leader_skill = "Extreme Class Ki +4 and HP, ATK & DEF +90%;\r\nor\r\nSuper Class Ki +3 and HP, ATK & DEF +70%",
                  Card_attack_details = "Greatly raises ATK & DEF for 1 turn and causes colossal damage to enemy",
                  Card_details = "ATK & DEF +50%; Ki +3 plus an additional DEF +50% as the 1st or 3rd attacker in a turn; plus an additional ATK +50% when performing an Ultra Super Attack; plus an additional Ki +3 when attacking Super Class enemies"
              }
            );
        }
    }
}
