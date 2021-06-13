using leagueChampionStats.Models;
using Microsoft.EntityFrameworkCore;

namespace leagueChampionStats.DataAccessLayer
{
    public class championsContext : DbContext
    {
        public championsContext() 
        {
        }

        public DbSet<champion> champions {get; set; }

    }
}