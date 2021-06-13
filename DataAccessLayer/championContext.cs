using leagueChampionStats.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
using Microsoft.EntityFrameworkCore;


namespace leagueChampionStats.DataAccessLayer
{
    public class championContext : DbContext
    {
        public championContext()   
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Champions.db");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<champion>().ToTable("Champions");
        }

        public DbSet<champion> champions {get; set; }

    }
}