using CoffeeMachine.Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.Models
{
    public class BadgeDto
    {
        public string Id { get; set; }        
        public DrinkDto Drink { get; set; }
        public bool IsOwerMug { get; set; }
        
        public BadgeDto()
        {

        }
        public BadgeDto(Badge badge)
        {
            Id = badge.Id;
            Drink = badge.CurrentDrink != null ? new DrinkDto(badge.CurrentDrink) : new DrinkDto();
            IsOwerMug = badge.IsOwerMug;
        }
    }
}
