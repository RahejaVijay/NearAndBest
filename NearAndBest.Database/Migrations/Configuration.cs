namespace NearAndBest.Database.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NearAndBest.Database.NearAndBestContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
          //  Database.SetInitializer<NearAndBestContext>(new MigrateDatabaseToLatestVersion<NearAndBestContext, Configuration>());
                

        }

        protected override void Seed(NearAndBest.Database.NearAndBestContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
