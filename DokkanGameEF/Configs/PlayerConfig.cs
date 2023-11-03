using DokkanGameEF.Entities;
using DokkanGameEF.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DokkanGameEF.Configs
{
    internal class PlayerConfig : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.HasKey(p => p.PlayerId);
            builder.Property(p => p.PlayerId).ValueGeneratedOnAdd();
            builder.Property(p => p.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(p => p.LastName).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Birthdate).IsRequired();
            builder.HasIndex(p => p.Pseudo).IsUnique();
            builder.Property(p => p.Pseudo).HasMaxLength(30).IsRequired();
            builder.HasIndex(p => p.Email).IsUnique();
            builder.Property(p => p.Email).HasMaxLength(100).IsRequired();
            builder.Property(p => p.PlayerPassword).IsRequired();
            builder.HasCheckConstraint("CK_Mail_Regex", "Email LIKE '_%@_%._%'");
            builder.HasData(new Player
            {
                PlayerId = 1,
                LastName = "D'Addabbo",
                FirstName = "Nicolas",
                Birthdate = new DateTime(2000,01,01),
                Email = "nico.daddabbo7100@gmail.com",
                PlayerPassword = Method.HashPassword("nico123123"),
                Pseudo = "Nico75"
            });
        }
    }
}
