namespace Server2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Server2.Models;
    internal sealed class Configuration : DbMigrationsConfiguration<Server2.Models.Server2Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Server2.Models.Server2Context context)
        {
            context.Users.AddOrUpdate(x => x.Id,
        new User() { Id = 1, FirstName="Fname",MiddleName="MName",LastName="LName",Iin=12345678,Birthday=new DateTime(2020,02,16) }
        );
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
