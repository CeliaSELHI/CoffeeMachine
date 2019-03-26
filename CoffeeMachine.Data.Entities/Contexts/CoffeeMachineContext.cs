using CoffeeMachine.Data.Entities.Models;
using CoffeeMachine.Repositories;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using System.Web.Configuration;

namespace CoffeeMachine.Data.Entities.Contexts
{
    public class CoffeeMachineContext : DbContext
    {
        public CoffeeMachineContext() : base("name = CoffeeMachine")
        {

        }
        public CoffeeMachineContext(string connectionString) : base(connectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
          
        }

        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Badge> Badges { get; set; }
        public DbSet<Sugar> Sugars { get; set; }
        public DbSet<DrinkType> DrinkTypes { get; set; }

    }
}
