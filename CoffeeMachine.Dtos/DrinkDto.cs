using CoffeeMachine.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoffeeMachine.Data.Entities.Models;

namespace CoffeMachine.Models
{
    public class DrinkDto
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public DrinkTypeDto Type {get; set; }
        public SugarDto Sugar { get; set; }

        public DrinkDto()
        {

        }
        public DrinkDto(Drink drink)
        {
            Id = drink.Id;
            Quantity = drink.Quantity;
            Type = new DrinkTypeDto(drink.CurrentType);
            Sugar = new SugarDto(drink.CurrentSugar);  
        }
    }
}
