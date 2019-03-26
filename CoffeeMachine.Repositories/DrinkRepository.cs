using CoffeeMachine.Data.Entities.Contexts;
using CoffeMachine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Repositories
{
    public class DrinkRepository
    {
        public DrinkDto Get(int drinkType)
        {
            CoffeeMachineContext context = new CoffeeMachineContext(); 
            
            var currentDrink = (from drink in context.Drinks
                                    where drink.IdType == drinkType
                                    select drink).FirstOrDefault();

            return currentDrink != null ? new DrinkDto(currentDrink) : new DrinkDto(); 
            
        }
        public void Store(DrinkDto drink)
        {
            throw new NotImplementedException();
        }
    }
}
