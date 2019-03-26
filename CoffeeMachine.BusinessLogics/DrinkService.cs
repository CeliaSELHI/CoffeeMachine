using CoffeeMachine.Repositories;
using CoffeMachine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.BusinessLogics
{

    public class DrinkService : IDrinkService
    {
        private readonly IDrinkRepository _drinkRepository;
        public DrinkService(IDrinkRepository drinkRepository)
        {
            _drinkRepository = drinkRepository;
        }
        public void UpdateDrink(int type, int quantity)
        {
            DrinkDto currentDrink = _drinkRepository.Get(type);

            if (currentDrink.Quantity < quantity)
            {
                throw new NotEnoughSugarException();
            }
            currentDrink.Quantity -= quantity;
            _drinkRepository.Store(currentDrink);

        }
    }
}
