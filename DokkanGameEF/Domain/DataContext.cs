using DokkanGameEF.Configs;
using DokkanGameEF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DokkanGameEF.Domain
{
    public class DataContext : DbContext
    {
        private string cs = "Data Source=GOS-VDI202\\TFTIC;Initial Catalog=DokkanEF;User Id=nico; Password=123;Integrated Security=True; Trust Server Certificate=Yes";
        public DbSet<Card> Cards { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<CardPlayer> CardsPlayers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(cs);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CardConfig());
            modelBuilder.ApplyConfiguration(new PlayerConfig());
            modelBuilder.ApplyConfiguration(new CardPlayerConfig());

        }
    }
}
