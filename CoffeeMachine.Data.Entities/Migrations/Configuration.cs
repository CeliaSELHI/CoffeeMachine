namespace CoffeeMachine.Data.Entities.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CoffeeMachine.Data.Entities.Contexts.CoffeeMachineContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Contexts.CoffeeMachineContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.DrinkTypes.AddOrUpdate(
                new Repositories.DrinkType { Id = 1, Label = "Café" },
                new Repositories.DrinkType { Id = 2, Label = "Chocolat" },
                new Repositories.DrinkType { Id = 3, Label = "Thé" }
                );
          
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
