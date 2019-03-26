using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Repositories
{
    public interface IDrinkTypesRepository
    {
        List<DrinkTypeDto> Get(); 
    }
}
