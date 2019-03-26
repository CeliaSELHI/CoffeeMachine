using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.BusinessLogics
{
    public interface IDrinkService
    {
        void UpdateDrink(int typeDrink, int quantity);
       
    }
}
