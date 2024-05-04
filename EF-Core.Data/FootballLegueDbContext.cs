using Microsoft.EntityFrameworkCore;
using EF_Core.Domain;

namespace EF_Core.Data
{
    public class FootballLegueDbContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Coach> Coaches { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Using SQL Server
            /*optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;" +
                "Initial Catalog=FootballLegue_EFCore;Integrated Security=True;Connect Timeout=30;" +
                "Encrypt=False;Trust Server Certificate=True;" +
                "Application Intent=ReadWrite;Multi Subnet Failover=False");*/

            optionsBuilder.UseSqlite($"Data Source=FootballLegue_EFCore.db");
        }
    }
}
