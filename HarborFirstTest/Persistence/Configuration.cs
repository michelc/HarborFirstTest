using System.Data.Entity.Migrations;

namespace HarborFirstTest.Persistence
{
    public class Configuration : DbMigrationsConfiguration<HftContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}