using CoffeeMachine.Data.Entities.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Repositories
{
    public class DrinkTypesRepository : IDrinkTypesRepository
    {
        public List<DrinkTypeDto> Get()
        {
            CoffeeMachineContext context = new CoffeeMachineContext();

            var currentDrinkTypes = (from drinkTypes in context.DrinkTypes
                                     select drinkTypes);
            List<DrinkTypeDto> drinkList = new List<DrinkTypeDto>(); 
            foreach (var type in currentDrinkTypes)
            {
                drinkList.Add(new DrinkTypeDto(type)); 
            }
            return drinkList; 

        }
    }
}
