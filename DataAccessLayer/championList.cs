using leagueChampionStats.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace leagueChampionStats.DataAccessLayer
{
    public class championsContext : DbContext
    {
        public championsContext() :base (new SQLiteConnection()
            {
                ConnectionString = new SQLiteConnectionStringBuilder() 
                { DataSource = "..\\Database\\SQLiteChampions.db", ForeignKeys = true }.ConnectionString
            }, true)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<champion> champions {get; set; }

    }
}