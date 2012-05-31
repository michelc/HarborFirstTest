using System.Data.Entity;
using HarborFirstTest.Models;

namespace HarborFirstTest.Persistence
{
    public class HftContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<HftContext, Configuration>());
        }
    }
}