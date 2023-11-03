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
    internal class CardPlayerConfig : IEntityTypeConfiguration<CardPlayer>
    {
        public void Configure(EntityTypeBuilder<CardPlayer> builder)
        {
            builder.HasKey(cp => new { cp.CardId, cp.PlayerId });
            builder.HasOne(c => c.Card).WithMany(p => p.Players).HasForeignKey(p => p.CardId);
            builder.HasOne(c => c.Player).WithMany(p => p.Cards).HasForeignKey(p => p.PlayerId);
            builder.Property(cp => cp.Number).HasDefaultValue(1);
            builder.HasData(new CardPlayer
            {
                CardId = 1,
                PlayerId = 1,
                Number = 3,
            },
            new CardPlayer
            {
                CardId = 2,
                PlayerId = 1,
                Number = 2,
            },
            new CardPlayer
            {
                CardId = 3,
                PlayerId = 1,
                Number = 1,
            }
            );

        }
    }
}
