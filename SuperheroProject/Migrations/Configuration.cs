namespace SuperheroProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using SuperheroProject.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<SuperheroProject.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SuperheroProject.Models.ApplicationDbContext context)
        {
            //context.Superheroes.AddOrUpdate(s => s.Id,
            //    new Superhero() { Id = 1, SuperName = "Spider-Man", AlterEgo = "Peter B. Parker", PrimaryAbility = "Sticky", SecondaryAbility = "Swingy", CatchPhrase = "That's so cool!"}
            //    );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
