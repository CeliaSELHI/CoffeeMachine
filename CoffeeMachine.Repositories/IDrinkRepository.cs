using CoffeMachine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Repositories
{
    public interface IDrinkRepository
    {
        DrinkDto Get(int drinkType);
        void Store(DrinkDto tea);        
    }
}
